Public Class FRM_SCHEDULE

    Private temp As String
    Private temp2 As String = ""
    Private temp_Date As String = ""
    Private sel_day As Label = New Label

    Private Sub FRM_SCHEDULE_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            Call SettoolBar(False, False, True, True, False, True, True)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_SCHEDULE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Call Controls_Setting()
            Call Calendar_Setting()
            DPYear.Value = Today
            DPMonth.Value = Today
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub Controls_Setting()
        Dim dt As DataTable
        Try
            Me.WindowState = FormWindowState.Maximized
            DPYear.CustomFormat = "yyyy"
            DPMonth.CustomFormat = "MM"
            DPYear.Value = New Date(DPYear.Value.Year, DPMonth.Value.Month, 1)
            DPMonth.Value = New Date(DPYear.Value.Year, DPMonth.Value.Month, 1)

            txtTitle.MaxLength = 50
            txtSchedule.MaxLength = 200
            txtWLoc.MaxLength = 30
            txtTitle.ImeMode = Windows.Forms.ImeMode.Hangul
            txtSchedule.ImeMode = Windows.Forms.ImeMode.Hangul
            txtWLoc.ImeMode = Windows.Forms.ImeMode.Hangul
            drpUser.Enabled = False
            drpWReason.Enabled = False
            txtWLoc.Enabled = False

            DPDate1.Value = Now
            DPDate2.Value = Now
            CB_Set2(drpHour1, "datetime", 0, 23, 1, "")
            CB_Set2(drpHour2, "datetime", 0, 23, 1, "")
            CB_Set2(drpMin1, "datetime", 0, 50, 10, "")
            CB_Set2(drpMin2, "datetime", 0, 50, 10, "")
            drpHour1.Text = "00"
            drpHour2.Text = "23"
            drpMin1.Text = "00"
            drpMin2.Text = "50"

            '팀명
            temp = "SELECT '' S_MENU_CD, '-' S_MENU_NM UNION " & _
                    "SELECT S_MENU_CD, S_MENU_NM FROM t_s_code Where COM_CD='" & gsCOM_CD & "' and L_MENU_CD='010' Order By S_MENU_CD "
            CB_Set(gsConString, temp, drpTeam, "S_MENU_NM", "S_MENU_CD", gsTeam_CD)
            '구분
            temp = "SELECT '0' S_MENU_CD, '일정관리' S_MENU_NM UNION " & _
                    "SELECT '1', '외근관리' Order By S_MENU_CD "
            CB_Set(gsConString, temp, drpGubun, "S_MENU_NM", "S_MENU_CD", "0")
            '외근자
            temp = "SELECT '' USER_ID, '-' USER_NM UNION " & _
                    "SELECT USER_ID, Concat(USER_ID,'.',USER_NM) USER_NM FROM t_user Where COM_CD='" & gsCOM_CD & "' AND (RETIRE_DD IS NULL OR RTRIM(RETIRE_DD)='') Order By USER_ID "
            CB_Set(gsConString, temp, drpUser, "USER_NM", "USER_ID", "")
            '외근사유
            temp = "SELECT '' S_MENU_CD, '-' S_MENU_NM UNION " & _
                    "SELECT S_MENU_CD, S_MENU_NM FROM t_s_code Where COM_CD='" & gsCOM_CD & "' and L_MENU_CD='007' Order By S_MENU_CD "
            CB_Set(gsConString, temp, drpWReason, "S_MENU_NM", "S_MENU_CD", "")


            '달력에 있는 라벨 클릭 이벤트에 Day_Click 함수 연결
            Dim obj As Label = New Label
            For Each ctrl In FlowLayoutPanel1.Controls
                If ctrl.GetType() Is obj.GetType Then
                    obj = ctrl
                    AddHandler obj.Click, AddressOf Day_Click
                End If
            Next

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Private Sub UserList_Setting()
        Dim dt As DataTable
        Dim i As Short
        Dim item1 As DataRowView
        Dim Team_cd As String = ""
        Try
            If drpTeam.SelectedIndex > -1 AndAlso drpTeam.SelectedValue.ToString.Contains("System.") = False Then
                Team_cd = drpTeam.SelectedValue.ToString()
            End If

            temp = "SELECT USER_ID, Concat(USER_ID,'.',USER_NM) USER_NM, DEPART_CD, DEPART_NM " & _
                   "From t_user a " & _
                   "Where COM_CD='" & gsCOM_CD & _
                   " AND TEAM_CD like '" & Team_cd & "%' AND (RETIRE_DD IS NULL OR RTRIM(RETIRE_DD)='') "
            CB_Set(gsConString, temp, UserLB3, "USER_NM", "USER_ID", "")

            UserLB1.BeginUpdate()
            UserLB1.Items.Clear()
            For i = 0 To UserLB3.Items.Count - 1
                item1 = UserLB3.Items(i)
                If UserLB2.FindString(item1.Row(1).ToString) < 0 Then _
                    UserLB1.Items.Add(item1.Row(1).ToString) 'item1.Row(0) : ValueMember, item1.Row(1) : DisplayMember
            Next
            UserLB1.EndUpdate()

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Private Sub Calendar_Setting()
        Try
            Dim obj As Label = New Label
            Dim i As Short = 0
            Dim j As Short = 0
            Dim cur_month As Integer = DPMonth.Value.Month
            Dim startday As Date = New Date(DPYear.Value.Year, DPMonth.Value.Month, 1)
            Dim startdayofweek As Short = CShort(startday.DayOfWeek)
            'startday.DayOfWeek :1(sun:0, sat:6)   startday.DayOfWeek.ToString : Monday 

            For Each ctrl In FlowLayoutPanel1.Controls
                If ctrl.GetType() Is obj.GetType Then
                    obj = ctrl
                    obj.Image = Nothing
                    obj.BackColor = Color.White
                    obj.BorderStyle = BorderStyle.None
                    'Call WriteLog(Me.Name & " : j=" & j.ToString & " startdayofweek=" & startdayofweek.ToString & " i=" & i.ToString & " startday.AddDays(i).Month=" & startday.AddDays(i).Month.ToString & " DTMonth=" & cur_month)
                    If j < 7 AndAlso j < startdayofweek Then
                        obj.Text = ""
                        obj.Enabled = False
                    Else
                        obj.Enabled = Enabled
                        If startday.AddDays(i).Month = cur_month Then
                            i += 1
                            '날짜 지정
                            obj.Text = i.ToString
                            '요일별 폰트 색상 지정
                            Select Case startday.AddDays(i - 1).DayOfWeek
                                Case DayOfWeek.Sunday
                                    obj.ForeColor = Color.Red
                                Case DayOfWeek.Saturday
                                    obj.ForeColor = Color.Blue
                                Case Else
                                    obj.ForeColor = Color.Black
                            End Select
                            '오늘 표시
                            If startday.AddDays(i - 1) = Today Then
                                obj.BorderStyle = BorderStyle.FixedSingle
                            End If
                        Else
                            obj.Text = ""
                            obj.Enabled = False
                        End If
                    End If

                    j += 1
                    'Call WriteLog(Me.Name & " : " & obj.Name & "-" & obj.Text & "-" & obj.Tag)
                End If
            Next

            Call Schedule_Get()

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub Schedule_Get()
        Dim dt As DataTable
        Dim i As Short
        Dim obj As Label = New Label
        Dim tmpDate As String
        'Dim tmpPath As String = Application.StartupPath & "\resources\mark1.bmp"
        'Call WriteLog(Me.Name & " : tmpPath=" & tmpPath)
        Try
            temp = "SELECT SUBSTRING(S_START_TIME,1,8) S_START_DD " & _
                   " ,SUBSTRING(S_END_TIME,1,8) S_END_DD " & _
                   " ,if(SHARING_TYPE = 'S',1,0) SHARING " & _
                   " ,SHARING_TYPE " & _
                   " FROM t_schedule  " & _
                   " WHERE COM_CD='" & gsCOM_CD & _
                   "' AND S_START_TIME <= '" & DPYear.Text & DPMonth.Text & "320000'" & _
                   " AND S_END_TIME >= '" & DPYear.Text & DPMonth.Text & "000000'" & _
                   " AND ((SHARING_TYPE = 'P' AND REGISTRANT LIKE '" & gsUSER_ID.Trim & ".%')" & _
                   "      OR SHARING_TYPE = 'S' OR SHARING_TYPE = 'O')" & _
                   " ORDER BY S_START_TIME, S_END_TIME "
            dt = Mysql_GetData_table(gsConString, temp)

            For i = 0 To dt.Rows.Count - 1
                For Each ctrl In FlowLayoutPanel1.Controls
                    If ctrl.GetType() Is obj.GetType Then
                        obj = ctrl
                        tmpDate = DPYear.Text & DPMonth.Text & If(obj.Text.Length = 2, obj.Text, "0" & obj.Text)
                        tmpDate = If(tmpDate.Length = 8, tmpDate, "")
                        If obj.Text.Trim <> "" AndAlso _
                            dt.Rows(i).Item(0).ToString <= tmpDate AndAlso dt.Rows(i).Item(1).ToString >= tmpDate Then
                            'obj.Image = Image.FromFile(tmpPath)
                            ' obj.Image = PictureBox2.Image  '20*20
                            obj.Image = PictureBox2.Image  '15*15
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Private Sub Day_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim obj As Label = CType(sender, Label)
            Dim obj2 As Label = New Label
            For Each ctrl In FlowLayoutPanel1.Controls
                If ctrl.GetType() Is obj2.GetType Then                    
                    obj2 = ctrl
                    obj2.BackColor = Color.White
                End If
            Next

            sel_day = obj           
            'If obj.Text.Trim.Length < 1 Then
            '    Schedule_Init(0)
            '    Exit Try
            'End If

            obj.BackColor = Color.WhiteSmoke

            temp = "SELECT Concat(SUBSTRING(S_START_TIME,1,4),'-',SUBSTRING(S_START_TIME,5,2),'-',SUBSTRING(S_START_TIME,7,2),' ',SUBSTRING(S_START_TIME,9,2),':',SUBSTRING(S_START_TIME,11,2)) S_START_TIME " & _
                   " ,Concat(SUBSTRING(S_END_TIME,1,4),'-',SUBSTRING(S_END_TIME,5,2),'-',SUBSTRING(S_END_TIME,7,2),' ',SUBSTRING(S_END_TIME,9,2),':',SUBSTRING(S_END_TIME,11,2)) S_END_TIME " & _
                   " ,if(SHARING_TYPE = 'P',0,1) SHARING, REGISTRANT, SHARING_TYPE, if(SHARING_TYPE = 'O','외근관리','일정관리') SHARING_TYPE2, S_TITLE, S_DESC, S_COMPANY_COWORKER, S_WORKOUT_REASON, S_WORKOUT_LOC " & _
                   " FROM t_schedule  " & _
                   " WHERE COM_CD='" & gsCOM_CD & _
                   "' AND S_START_TIME <= '" & DPYear.Text & DPMonth.Text & If(obj.Text.Length = 1, "0" & obj.Text, obj.Text) & "2400'" & _
                   " AND S_END_TIME >= '" & DPYear.Text & DPMonth.Text & If(obj.Text.Length = 1, "0" & obj.Text, obj.Text) & "0000'" & _
                   " AND ((SHARING_TYPE = 'P' AND REGISTRANT LIKE '" & gsUSER_ID.Trim & ".%')" & _
                   "      OR SHARING_TYPE = 'S' OR SHARING_TYPE = 'O')" & _
                   " ORDER BY S_START_TIME, S_END_TIME, SHARING_TYPE, REGISTRANT "
            GV_DataBind(gsConString, temp, DataGridView1)
            Schedule_Init(1)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex
            Dim info As String = ""
            'With DataGridView1.Rows(i)
            '    info = .Cells("S_START_TIME").Value.ToString & "^" & .Cells("S_END_TIME").Value.ToString & "^" & .Cells("SHARING").Value.ToString & _
            '    "^" & .Cells("REGISTRANT").Value.ToString & "^" & .Cells("S_TITLE").Value.ToString & "^" & .Cells("SHARING_TYPE").Value.ToString & _
            '    "^" & .Cells("S_COMPANY_COWORKER").Value.ToString & "^" & .Cells("S_DESC").Value.ToString & _
            '    "^" & .Cells("SHARING_TYPE2").Value.ToString & "^" & .Cells("S_WORKOUT_REASON").Value.ToString & "^" & .Cells("S_WORKOUT_LOC").Value.ToString
            'End With
            Schedule_Setting(i)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub


    Private Sub Schedule_Setting(ByVal k As Short)
        Dim dt As DataTable
        Try
            If k < 0 Then Exit Try
            'DataGridView1 컬럼 : S_START_TIME, S_END_TIME, SHARING, SHARING_TYPE2, REGISTRANT, S_TITLE, SHARING_TYPE, S_DESC, S_COMPANY_COWORKER, S_WORKOUT_REASON, S_WORKOUT_LOC
            '데이타 포맷: 201108051900  201108060000    0   일정관리    0001.개똥이	전체회식1   P	'전체' "회식1" & ....	0001,0002,0003,0004             
            With DataGridView1.Rows(k)
                drpGubun.SelectedValue = If(.Cells("SHARING_TYPE").Value.ToString.Trim = "O", "1", "0")
                DPDate1.Text = .Cells("S_START_TIME").Value.ToString.Trim.Split(" ")(0)
                drpHour1.Text = .Cells("S_START_TIME").Value.ToString.Trim.Split(" ")(1).Split(":")(0)
                drpMin1.Text = .Cells("S_START_TIME").Value.ToString.Trim.Split(" ")(1).Split(":")(1)
                DPDate2.Text = .Cells("S_END_TIME").Value.ToString.Trim.Split(" ")(0)
                drpHour2.Text = .Cells("S_END_TIME").Value.ToString.Trim.Split(" ")(1).Split(":")(0)
                drpMin2.Text = .Cells("S_END_TIME").Value.ToString.Trim.Split(" ")(1).Split(":")(1)
                chkSharing.Checked = .Cells("SHARING").Value
                txtTitle.Text = .Cells("S_TITLE").Value.ToString
                txtSchedule.Text = .Cells("S_DESC").Value.ToString.Trim
                drpTeam.SelectedValue = ""
                UserLB1.Items.Clear()
                UserLB2.Items.Clear()

                Call UserList_Setting()
                'Call WriteLog("Schedule_Setting>>>  drpGubun:" & drpGubun.SelectedValue & " S_COMPANY_COWORKER:" & .Cells("S_COMPANY_COWORKER").Value.ToString.Trim)
                '일정관리
                '20120120 ' If .Cells("S_COMPANY_COWORKER").Value.ToString.Trim <> "" Then
                If drpGubun.SelectedValue = "0" And .Cells("S_COMPANY_COWORKER").Value.ToString.Trim <> "" Then
                    Dim str As String() = .Cells("S_COMPANY_COWORKER").Value.ToString.Split(",")
                    Dim i, j As Short
                    UserLB2.BeginUpdate()
                    For i = 0 To str.Length - 1
                        j = UserLB3.FindString(str(i) & ".")
                        If j > -1 Then
                            UserLB2.Items.Add(UserLB3.GetItemText(UserLB3.Items(j)))
                        End If
                    Next
                    UserLB2.EndUpdate()

                    If UserLB1.Items.Count > 0 AndAlso UserLB2.Items.Count > 0 Then
                        UserLB1.BeginUpdate()
                        For i = 0 To UserLB2.Items.Count - 1
                            If UserLB1.Items.Contains(UserLB2.Items(i).ToString) Then
                                UserLB1.Items.Remove(UserLB2.Items(i).ToString)
                            End If
                        Next
                        UserLB1.EndUpdate()
                    End If

                End If
                '외근관리
                If drpGubun.SelectedValue = "1" And .Cells("S_COMPANY_COWORKER").Value.ToString.Trim <> "" Then
                    drpUser.SelectedValue = .Cells("S_COMPANY_COWORKER").Value.ToString.Trim.Split(".")(0)
                End If
                drpWReason.SelectedValue = .Cells("S_WORKOUT_REASON").Value.ToString.Trim
                txtWLoc.Text = .Cells("S_WORKOUT_LOC").Value.ToString.Trim

            End With
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Private Sub Schedule_Init(ByVal Gubun As Short)
        Try
            If Gubun = 0 Then DataGridView1.DataSource = Nothing
            DPDate1.Value = Now
            DPDate2.Value = Now
            drpHour1.Text = "00"
            drpHour2.Text = "23"
            drpMin1.Text = "00"
            drpMin2.Text = "50"
            chkSharing.Checked = False
            txtTitle.Text = ""
            txtSchedule.Text = ""
            drpTeam.SelectedValue = ""
            'drpTeam.SelectedValue = gsTeam_CD
            UserLB1.Items.Clear()
            UserLB2.Items.Clear()
            txtWLoc.Text = ""
            Call UserList_Setting()
            drpGubun.SelectedValue = "0"
            drpUser.SelectedValue = ""
            drpWReason.SelectedValue = ""
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub DTYear_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPYear.ValueChanged
        Try
            If temp_Date = DPYear.Text & DPMonth.Text Then Exit Sub
            temp_Date = DPYear.Text & DPMonth.Text
            Calendar_Setting()
            Schedule_Init(0)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub DTMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPMonth.ValueChanged
        Try
            If temp_Date = DPYear.Text & DPMonth.Text Then Exit Sub
            temp_Date = DPYear.Text & DPMonth.Text
            Calendar_Setting()
            Schedule_Init(0)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub btn_today_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_today.Click
        Try
            If DPYear.Value.Year <> Today.Year Then DPYear.Value = Today
            If DPMonth.Value.Month <> Today.Month Then DPMonth.Value = Today
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub


    Private Sub drpTeam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drpTeam.SelectedIndexChanged
        Try
            UserList_Setting()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub drpGubun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drpGubun.SelectedIndexChanged
        Try
            Select Case drpGubun.SelectedValue.ToString
                Case "1"   '외근관리
                    drpUser.Enabled = True
                    drpWReason.Enabled = True
                    txtWLoc.Enabled = True
                    chkSharing.Enabled = False
                    drpTeam.Enabled = False
                    UserLB1.Enabled = False
                    UserLB2.Enabled = False
                    btnAdd.Enabled = False
                    btnRemove.Enabled = False
                    btnAdd2.Enabled = False
                    btnRemove2.Enabled = False
                Case Else
                    drpUser.Enabled = False
                    drpWReason.Enabled = False
                    txtWLoc.Enabled = False
                    chkSharing.Enabled = True
                    drpTeam.Enabled = True
                    UserLB1.Enabled = True
                    UserLB2.Enabled = True
                    btnAdd.Enabled = True
                    btnRemove.Enabled = True
                    btnAdd2.Enabled = True
                    btnRemove2.Enabled = True
            End Select
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If UserLB1.SelectedIndex > -1 Then
                If UserLB2.Items.Contains(UserLB1.SelectedItem) = False Then UserLB2.Items.Add(UserLB1.SelectedItem)
                UserLB1.Items.Remove(UserLB1.SelectedItem)
                UserLB1.ClearSelected()
                UserLB2.ClearSelected()
            End If
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If UserLB2.SelectedIndex > -1 Then
                If UserLB3.FindString(UserLB2.SelectedItem.ToString) >= 0 AndAlso UserLB1.Items.Contains(UserLB2.SelectedItem) = False Then UserLB1.Items.Add(UserLB2.SelectedItem)
                UserLB2.Items.Remove(UserLB2.SelectedItem)
                UserLB1.ClearSelected()
                UserLB2.ClearSelected()
            End If
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub btnAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd2.Click
        Try
            Dim i As Integer
            For i = 0 To UserLB1.Items.Count - 1
                UserLB2.Items.Add(UserLB1.Items(i))
            Next
            UserLB1.Items.Clear()
            UserLB1.ClearSelected()
            UserLB2.ClearSelected()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub btnRemove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove2.Click
        Try
            Dim i As Integer
            For i = 0 To UserLB2.Items.Count - 1
                UserLB1.Items.Add(UserLB2.Items(i))
            Next
            UserLB2.Items.Clear()
            UserLB1.ClearSelected()
            UserLB2.ClearSelected()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally

        End Try
    End Sub

    Public Sub gsSave()
        Dim dt As DataTable
        Dim i As Short
        Dim users As String = ""
        Try
            If txtTitle.Text.Trim = "" Then
                MsgBox("제목을 입력하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf drpHour1.Text.Trim = "" OrElse drpMin1.Text.Trim = "" Then
                MsgBox("시작시간을 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf drpHour2.Text.Trim = "" OrElse drpMin2.Text.Trim = "" Then
                MsgBox("종료시간을 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf DPDate1.Text.Replace("-", "").Replace("/", "") & drpHour1.Text.Trim & drpMin1.Text.Trim > DPDate2.Text.Replace("-", "").Replace("/", "") & drpHour2.Text.Trim & drpMin2.Text.Trim Then
                MsgBox("종료일시는 시작일시 이후로 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf drpGubun.SelectedValue.ToString.Trim = "1" And drpUser.SelectedValue.ToString = "" Then
                MsgBox("외근자를 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            ElseIf drpGubun.SelectedValue.ToString.Trim = "0" Then
                drpUser.SelectedValue = ""
                drpWReason.SelectedValue = ""
                txtWLoc.Text = ""
            End If

            temp = "SELECT count(S_START_TIME) From t_schedule  "
            '20120120
            If drpGubun.SelectedValue = "0" Then   '일정관리
                temp2 = " Where COM_CD='" & gsCOM_CD & _
                       "' AND S_START_TIME='" & DPDate1.Text.Replace("-", "").Replace("/", "") & drpHour1.Text & drpMin1.Text & _
                       "' AND REGISTRANT LIKE '" & gsUSER_ID.Trim & ".%" & _
                       "' AND SHARING_TYPE='" & If(drpGubun.SelectedValue.ToString.Trim = "1", "O", If(chkSharing.Checked = False, "P", "S")) & _
                       "' AND S_TITLE='" & txtTitle.Text.Trim & "' "

                For i = 0 To UserLB2.Items.Count - 1
                    users &= UserLB2.Items(i).ToString.Split(".")(0) & ","
                Next
                If users.Trim.Length > 0 Then users = users.Substring(0, users.Trim.Length - 1)

            Else '외근관리
                temp2 = " Where COM_CD='" & gsCOM_CD & _
                       "' AND S_START_TIME='" & DPDate1.Text.Replace("-", "").Replace("/", "") & drpHour1.Text & drpMin1.Text & _
                       "' AND S_COMPANY_COWORKER LIKE '" & drpUser.SelectedValue.ToString.Trim & ".%" & _
                       "' AND SHARING_TYPE='" & If(drpGubun.SelectedValue.ToString.Trim = "1", "O", If(chkSharing.Checked = False, "P", "S")) & "' "

                users = drpUser.Text
                'Call WriteLog("drpUser.Text:" & drpUser.Text & "  drpUser.SelectedValue:" & drpUser.SelectedValue & "  drpUser.SelectedText:" & drpUser.SelectedText & "  drpUser.SelectedItem:" & drpUser.SelectedItem.ToString)
            End If

            dt = Mysql_GetData_table(gsConString, temp & temp2)

            If dt.Rows(0).Item(0).ToString.Trim = "0" Then
                temp = "Insert into t_schedule(COM_CD,S_START_TIME,S_END_TIME,REGISTRANT,SHARING_TYPE,S_TITLE,S_COMPANY_COWORKER,S_DESC,S_WORKOUT_REASON,S_WORKOUT_LOC) values('" & _
                        gsCOM_CD & "','" & DPDate1.Text.Replace("-", "").Replace("/", "") & drpHour1.Text & drpMin1.Text & "','" & _
                        DPDate2.Text.Replace("-", "").Replace("/", "") & drpHour2.Text & drpMin2.Text & "','" & _
                        gsUSER_ID.Trim & "." & gsUSER_NM.Trim & "','" & If(drpGubun.SelectedValue = "1", "O", If(chkSharing.Checked = False, "P", "S")) & "','" & _
                        txtTitle.Text.Trim & "','" & users & "','" & txtSchedule.Text.Trim.Replace("'", "''") & "','" & drpWReason.SelectedValue.ToString.Trim & "','" & txtWLoc.Text.Trim & "') "

                temp2 = ""
            Else
                temp = "Update t_schedule set S_END_TIME='" & DPDate2.Text.Replace("-", "").Replace("/", "") & drpHour2.Text & drpMin2.Text & "' " & _
                        ",S_COMPANY_COWORKER='" & users & "',S_DESC='" & txtSchedule.Text.Trim.Replace("'", "''") & "',S_WORKOUT_REASON='" & drpWReason.SelectedValue.ToString.Trim & "',S_WORKOUT_LOC='" & txtWLoc.Text.Trim & "' "
            End If
            dt.Reset()

            dt = Mysql_GetData_table(gsConString, temp & temp2)
            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            Call Calendar_Setting()
            Day_Click(sel_day, Nothing)
            Schedule_Init(1)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Public Sub gsDelete()
        Dim dt As DataTable
        Try
            If txtTitle.Text.Trim = "" Then
                MsgBox("삭제할 일정을 다시 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If
            temp = "SELECT count(S_START_TIME) From t_schedule "
            If drpGubun.SelectedValue = "0" Then   '일정관리
                temp2 = " Where COM_CD='" & gsCOM_CD & _
                       "' AND S_START_TIME='" & DPDate1.Text.Replace("-", "").Replace("/", "") & drpHour1.Text & drpMin1.Text & _
                       "' AND REGISTRANT LIKE '" & gsUSER_ID.Trim & ".%" & _
                       "' AND SHARING_TYPE='" & If(drpGubun.SelectedValue.ToString.Trim = "1", "O", If(chkSharing.Checked = False, "P", "S")) & _
                       "' AND S_TITLE='" & txtTitle.Text.Trim & "' "

            Else '외근관리
                temp2 = " Where COM_CD='" & gsCOM_CD & _
                       "' AND S_START_TIME='" & DPDate1.Text.Replace("-", "").Replace("/", "") & drpHour1.Text & drpMin1.Text & _
                       "' AND S_COMPANY_COWORKER LIKE '" & drpUser.SelectedValue.ToString.Trim & ".%" & _
                       "' AND SHARING_TYPE='" & If(drpGubun.SelectedValue.ToString.Trim = "1", "O", If(chkSharing.Checked = False, "P", "S")) & "' "
            End If

            dt = Mysql_GetData_table(gsConString, temp & temp2)

            If dt.Rows(0).Item(0).ToString.Trim = "0" Then
                MsgBox("삭제할 일정을 다시 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If
            dt.Reset()
            MsgBox(txtTitle.Text.Trim & " 일정을 삭제하시겠습니까?", MsgBoxStyle.YesNo, "확인")

            temp = "Delete from t_schedule "
            dt = Mysql_GetData_table(gsConString, temp & temp2)
            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            Call Calendar_Setting()
            Day_Click(sel_day, Nothing)
            Schedule_Init(1)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            dt = Nothing
        End Try
    End Sub

    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call gsSave()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Call gsDelete()
    End Sub

End Class