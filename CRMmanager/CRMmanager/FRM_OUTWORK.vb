Public Class FRM_OUTWORK

    Private result As Integer = 0
    Private Sub FRM_OUTWORK_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SettoolBar(True, True, True, True, False, True, True)
    End Sub

    Private Sub FRM_OUTWORK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call SetToolBar(True, True, True, True, False, True, True)

            dpt1.Value = Format(Now, "yyyy-MM-dd")
            dpt2.Value = Format(Now, "yyyy-MM-dd")
            dpt3.Value = Format(Now, "yyyy-MM-dd")

            CB_Set2(drpHour11, "datetime", 0, 23, 1, "")
            CB_Set2(drpMin11, "datetime", 0, 55, 5, "")
            drpHour11.Text = "00"
            drpMin11.Text = "00"

            '************************************** 수행자 *********************************************
            Dim SQL As String = " SELECT '' ,'XXXX' UNION ALL SELECT LTRIM(RTRIM(USER_NM)), CONCAT(USER_ID,'.',LTRIM(RTRIM(USER_NM))) FROM T_USER WHERE COM_CD = '" & gsCOM_CD & "'"
            Dim dt4 As DataTable = GetData_table1(gsConString, SQL)
            Dim dt5 As DataTable = GetData_table1(gsConString, SQL)

            cboUser.DataSource = dt4
            cboUser.DisplayMember = dt4.Columns(0).ToString
            cboUser.ValueMember = dt4.Columns(1).ToString

            cboUser.SelectedIndex = 0

            cboUser1.DataSource = dt5
            cboUser1.DisplayMember = dt5.Columns(0).ToString
            cboUser1.ValueMember = dt5.Columns(1).ToString

            cboUser1.SelectedIndex = 0

            dt4 = Nothing
            dt5 = Nothing

            '************************************** 상담결과 입력 *********************************************
            Dim SQL_TEMP As String = Find_Query("007")
            Dim dt2 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboWorkReason1.DataSource = dt2
            cboWorkReason1.DisplayMember = dt2.Columns(0).ToString
            cboWorkReason1.ValueMember = dt2.Columns(1).ToString

            cboWorkReason1.SelectedIndex = 0

            '************************************** 상담결과 입력 *********************************************
            Dim SQL_TEMP1 As String = Find_Query("007")
            Dim dt3 As DataTable = GetData_table1(gsConString, SQL_TEMP1)

            cboWorkReason2.DataSource = dt3
            cboWorkReason2.DisplayMember = dt3.Columns(0).ToString
            cboWorkReason2.ValueMember = dt3.Columns(1).ToString
            cboWorkReason2.SelectedIndex = 0

            dt3 = Nothing

            Call gsSelect()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub gsInit()
        dpt3.Value = Format(Now, "yyyy-MM-dd")
        drpHour11.Text = "00"
        drpMin11.Text = "00"

        cboUser1.SelectedIndex = 0
        cboWorkReason2.SelectedIndex = 0
        txtWorkArea.Text = ""
        txtWorkContents.Text = ""

    End Sub
    Public Sub gsSave()
        Try
            Dim temp, temp2 As String
            Dim dt As DataTable

            If cboUser1.SelectedValue.ToString.Replace("XXXX", "") = "" Then
                MsgBox("외근자를 선택하십시오.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            temp = "SELECT count(S_START_TIME) From t_schedule  "
            temp2 = " Where COM_CD='" & gsCOM_CD & _
                   "' AND S_START_TIME='" & dpt3.Text.ToString.Replace("-", "") & drpHour11.Text & drpMin11.Text & _
                   "' AND S_COMPANY_COWORKER LIKE '" & cboUser1.SelectedValue.ToString.Trim & "%" & _
                   "' AND SHARING_TYPE='O'"
            '20120120 "' AND REGISTRANT LIKE '" & gsUSER_ID & ".%" & _
            '"' AND S_TITLE='" & txtTitle.Text.Trim & "' "
            'Call WriteLog(temp & temp2)
            'Call WriteLog("cboUser1:" & cboUser1.SelectedValue.ToString.Trim & " - " & cboUser1.SelectedValue.ToString.Split(".")(0))

            dt = Mysql_GetData_table(gsConString, temp & temp2)

            If dt.Rows(0).Item(0).ToString.Trim = "0" Then

                temp = "Insert into t_schedule(COM_CD,S_START_TIME,S_END_TIME,REGISTRANT,SHARING_TYPE,S_TITLE,S_COMPANY_COWORKER,S_DESC,S_WORKOUT_REASON,S_WORKOUT_LOC) values('"
                temp = temp & gsCOM_CD & "','" & dpt3.Text.ToString.Replace("-", "") & drpHour11.Text & drpMin11.Text & "','"
                temp = temp & dpt3.Text.ToString.Replace("-", "") & "2359" & "','"
                temp = temp & gsUSER_ID.Trim & "." & gsUSER_NM.Trim & "','O','"
                temp = temp & "외근등록" & "','" & cboUser1.SelectedValue.ToString.Trim & "','" & txtWorkContents.Text.Trim & "'"    '& "') "

                If cboWorkReason2.SelectedValue.ToString.Replace("XXXX", "") <> "" Then
                    Dim str() As String = cboWorkReason2.SelectedValue.ToString.Split(".")
                    temp = temp & " ,'" & str(0).Trim & "'"
                Else
                    temp = temp & " ,''"
                End If
                'End If

                temp = temp & ",'" & txtWorkArea.Text.Trim & "') "
                temp2 = ""

            Else
                temp = " UPDATE t_schedule SET S_WORKOUT_LOC = '" & txtWorkArea.Text.Trim & "', S_DESC ='" & txtWorkContents.Text.Trim & "', S_COMPANY_COWORKER='" & cboUser1.SelectedValue.ToString.Trim & "', REGISTRANT='" & gsUSER_ID.Trim & "." & gsUSER_NM.Trim

                If cboWorkReason2.SelectedValue.ToString.Replace("XXXX", "") <> "" Then
                    Dim str() As String = cboWorkReason2.SelectedValue.ToString.Split(".")
                    temp = temp & "' , S_WORKOUT_REASON =  '" & str(0).Trim & "'"
                Else
                    temp = temp & "' , S_WORKOUT_REASON =  ''"
                End If


            End If
            'Call WriteLog(temp & temp2)
            dt.Reset()

            dt = Mysql_GetData_table(gsConString, temp & temp2)
            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            dt = Nothing

            Call gsInit()
            Call gsSelect()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Public Sub gsDelete()
        Try
          
            Dim Update_SQL As String = " DELETE FROM  t_schedule "

            Update_SQL = Update_SQL & " WHERE COM_CD = '" & gsCOM_CD & "'"
            Update_SQL = Update_SQL & " AND S_START_TIME = '" & dpt3.Text.ToString.Replace("-", "") & drpHour11.Text & drpMin11.Text & "'"
            Update_SQL = Update_SQL & " AND  SHARING_TYPE = 'O' "
            '20120120  'Update_SQL = Update_SQL & " AND REGISTRANT LIKE '" & gsUSER_ID & ".%'"
            Update_SQL = Update_SQL & " AND S_COMPANY_COWORKER LIKE '" & cboUser1.SelectedValue.ToString.Trim & "%'"

            'Call WriteLog(Update_SQL)

            Dim DT2 As DataTable = GetData_table1(gsConString, Update_SQL)
            DT2 = Nothing

            Call gsInit()
            Call gsSelect()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Public Sub gsSelect()
        Try

            Dim SQL As String = " SELECT CONCAT(SUBSTRING(S_START_TIME,1,4) , '-' , SUBSTRING(S_START_TIME,5,2) , '-' , SUBSTRING(S_START_TIME,7,2) ,' ',SUBSTRING(S_START_TIME,9,2),':',SUBSTRING(S_START_TIME,11,2),':','00') work_out "
            '20120120 'SQL = SQL & ",REGISTRANT USER_NM"
            SQL = SQL & ",S_COMPANY_COWORKER USER_NM"
            SQL = SQL & ",CONCAT(S_WORKOUT_REASON , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '007' AND S_MENU_CD = S_WORKOUT_REASON )) workout_reason "
            SQL = SQL & " ,IFNULL(S_WORKOUT_LOC,'') S_WORKOUT_LOC "
            SQL = SQL & " ,S_DESC "
            SQL = SQL & " FROM t_schedule X "
            SQL = SQL & " WHERE COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND S_START_TIME >= '" & dpt1.Text.ToString.Replace("-", "") & "000000'"
            SQL = SQL & " AND S_START_TIME <= '" & dpt2.Text.ToString.Replace("-", "") & "235959'"
            SQL = SQL & " AND SHARING_TYPE = 'O'"

            If cboUser.SelectedValue.ToString.Replace("XXXX", "") <> "" Then
                '20120120  'SQL = SQL & " AND REGISTRANT like  '" & cboUser.SelectedValue.ToString() & "%'"
                SQL = SQL & " AND S_COMPANY_COWORKER like  '" & cboUser.SelectedValue.ToString() & "%'"
            End If

            If cboWorkReason1.SelectedValue.ToString.Replace("XXXX", "") <> "" Then
                Dim str() As String = cboWorkReason1.SelectedValue.ToString.Split(".")
                SQL = SQL & " AND S_WORKOUT_REASON =  '" & str(0).Trim & "'"
            End If

            SQL = SQL & " ORDER BY S_START_TIME  DESC "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView1.DataSource = Nothing


            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dt1
            DataGridView1.Columns.Item(0).HeaderText = "외근일시"
            DataGridView1.Columns.Item(0).Width = 150
            DataGridView1.Columns.Item(1).HeaderText = "외근자"
            DataGridView1.Columns.Item(2).HeaderText = "외근사유"
            DataGridView1.Columns.Item(3).HeaderText = "외근지역"
            DataGridView1.Columns.Item(4).HeaderText = "외근내용"
            DataGridView1.Columns.Item(4).Width = 500

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        Finally
            result = 1
        End Try
    End Sub
    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call gsSave()
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        '조회
        Call gsSelect()
    End Sub

    Private Sub btnCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        '닫기
        Call gsFormExit()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        '삭제
        Call gsDelete()
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '저장
        Call gsSave()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex

            With DataGridView1.Rows(i)
                Dim dd() As String = .Cells(0).Value.ToString.Split(" ")
                Dim hm() As String = dd(1).Split(":")

                dpt3.Value = dd(0)                  '.Cells(0).Value.ToString '외근일자(2011-12-12 12:12:12)
                drpHour11.Text = hm(0)
                drpMin11.Text = hm(1)


                txtWorkArea.Text = .Cells(3).Value.ToString '외근지
                txtWorkContents.Text = .Cells(4).Value.ToString '외근내용
                cboUser1.SelectedValue = .Cells(1).Value.ToString '외근자
                Dim customertype As String = .Cells(2).Value.ToString

                If customertype.Contains(".") Then
                    Dim str() As String = customertype.Split(".")
                    cboWorkReason2.SelectedValue = str(0)
                Else
                    cboWorkReason2.SelectedValue = "XXXX"
                End If
            End With

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            With SaveFileDialog1
                .CheckPathExists = True
                .Filter = "Excel통합문서(*.xlsx)|*.xlsx|Excel97-2003문서(*.xls)|*.xls"
                .FileName = "외근관리" & "_" & Format(Now, "yyyyMMdd")
                .Title = "외근관리 엑셀로 내보내기"
                .ShowDialog()
            End With
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            result = 0
            Call gsSelect()
            While (result = 0)
                Threading.Thread.Sleep(1000)
            End While
            Call Excel_Export2(SaveFileDialog1.FileName, SaveFileDialog1.Title, DataGridView1, "0,1,")
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub
End Class