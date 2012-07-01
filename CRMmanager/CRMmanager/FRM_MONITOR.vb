Public Class FRM_MONITOR
    
    Dim isTest As Boolean = False

    Private Sub FRM_MONITOR_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SettoolBar(False, True, False, False, False, True, True)
    End Sub

    Private Sub FRM_MONITOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Call gsInit(SELECT_INIT.CONSULT)
            Call getConsultStatus()
            Call gsSelect("all", SELECT_TYPE1.NORMAL, dgViewMain)

            Call gsInit(SELECT_INIT.TRANS)
            Call getTransStatus()
            Call gsSelect("all", SELECT_TYPE1.TRANS, dgViewTrans)

            Call gsInit(SELECT_INIT.CALLBACK)
            Call getCallbackStatus()
            Call gsSelectCallback(3, dgViewCallback)


        Catch ex As Exception
            Call WriteLog("FRM_MONITOR_Load : " & ex.ToString)
        End Try


    End Sub
    Enum SELECT_INIT
        CONSULT = 0
        TRANS = 1
        CALLBACK = 2
    End Enum


    Public Sub gsInit(ByVal selectInit As SELECT_INIT)
        Select Case selectInit
            Case SELECT_INIT.CONSULT
                ToggleButton1.Text = "상담완료( 0 )"
                ToggleButton2.Text = "진행중( 0 )"
                ToggleButton3.Text = "미처리( 0 )"
                ToggleButton4.Text = "이관처리( 0 )"
                'ToggleButton4.Text = "AS요청( 0 )"
                'ToggleButton5.Text = "기타요청( 0 )"
                ToggleButton6.Text = "전체( 0 )"
            Case SELECT_INIT.CALLBACK
                ToggleButton7.Text = "처리완료( 0 )"
                ToggleButton8.Text = "미처리( 0 )"
                ToggleButton9.Text = "전체( 0 )"
            Case SELECT_INIT.TRANS
                ToggleButton10.Text = "상담완료( 0 )"
                ToggleButton11.Text = "진행중( 0 )"
                ToggleButton12.Text = "미처리( 0 )"
                ToggleButton5.Text = "이관처리( 0 )"
                'ToggleButton13.Text = "AS요청( 0 )"
                'ToggleButton14.Text = "기타요청( 0 )"
                ToggleButton15.Text = "전체( 0 )"

        End Select
    End Sub

    Public Sub getConsultStatus()
        Try
            Dim SQL As String
            Dim strNow As String = Format(Now, "yyyyMMdd")
            SQL = "select consult_result, count(*) "
            SQL = SQL & " from t_customer_history  "
            If isTest = True Then
                SQL = SQL & " where tond_dd like '" & Format(Now, "yyyyMM") & "%' "
            Else
                SQL = SQL & " where tond_dd =  '" & strNow & "' "
            End If

            SQL = SQL & " and com_cd ='" & gsCOM_CD & "'"
            SQL = SQL & " and trans_yn is null"
            SQL = SQL & " group by consult_result "

            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)

            If dt1.Rows.Count > 0 Then
                Dim i As Integer
                Dim iAll As Integer = 0
                For i = 0 To dt1.Rows.Count - 1

                    Dim flag As String = dt1.Rows(i).Item(0).ToString()

                    If flag = "01" Then '상담완료
                        ToggleButton1.Text = "상담완료( " & dt1.Rows(i).Item(1).ToString() & " )"
                    ElseIf flag = "02" Then '진행중
                        ToggleButton2.Text = "진행중( " & dt1.Rows(i).Item(1).ToString() & " )"
                    ElseIf flag = "03" Then '미처리
                        ToggleButton3.Text = "미처리(" & dt1.Rows(i).Item(1).ToString() & " )"
                        'ElseIf flag = "04" Then 'AS요청
                        '   ToggleButton4.Text = "AS요청( " & dt1.Rows(i).Item(1).ToString() & " )"
                        '  iAll += dt1.Rows(i).Item(1).ToString
                        'ElseIf flag = "05" Then '기타요청
                        '   ToggleButton5.Text = "기타요청( " & dt1.Rows(i).Item(1).ToString() & " )"
                        '  iAll += dt1.Rows(i).Item(1).ToString
                    ElseIf flag = "06" Then '이관처리
                        ToggleButton4.Text = "이관처리(" & dt1.Rows(i).Item(1).ToString() & " )"
                    End If
                    iAll += dt1.Rows(i).Item(1).ToString
                Next
                ToggleButton6.Text = "전체( " & iAll & " )"

            Else
                Call gsInit(SELECT_INIT.CONSULT)
            End If

            dt1 = Nothing

        Catch ex As Exception
            Call gsInit(SELECT_INIT.CONSULT)
            Call WriteLog("getConsultStatus : " & ex.ToString)
        End Try

    End Sub

    Public Sub getTransStatus()
        Try
            Dim SQL As String
            Dim strNow As String = Format(Now, "yyyyMMdd")
            SQL = "select consult_result, count(*) "
            SQL = SQL & " from t_customer_history  "
            If isTest = True Then
                SQL = SQL & " where tond_dd like '" & Format(Now, "yyyyMM") & "%' "
            Else
                SQL = SQL & " where tond_dd =  '" & strNow & "' "
            End If

            SQL = SQL & " and com_cd ='" & gsCOM_CD & "'"
            SQL = SQL & " and trans_yn ='Y'"  '이관처리
            SQL = SQL & " group by consult_result "

            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)

            If dt1.Rows.Count > 0 Then
                Dim i As Integer
                Dim iAll As Integer = 0
                For i = 0 To dt1.Rows.Count - 1

                    Dim flag As String = dt1.Rows(i).Item(0).ToString()

                    If flag = "01" Then '상담완료
                        ToggleButton10.Text = "상담완료( " & dt1.Rows(i).Item(1).ToString() & " )"
                    ElseIf flag = "02" Then '진행중
                        ToggleButton11.Text = "진행중( " & dt1.Rows(i).Item(1).ToString() & " )"
                    ElseIf flag = "03" Then '미처리
                        ToggleButton12.Text = "미처리(" & dt1.Rows(i).Item(1).ToString() & " )"
                    ElseIf flag = "06" Then '미처리
                        ToggleButton5.Text = "이관처리(" & dt1.Rows(i).Item(1).ToString() & " )"
                        'ElseIf flag = "04" Then 'AS요청
                        '   ToggleButton13.Text = "AS요청( " & dt1.Rows(i).Item(1).ToString() & " )"
                        '  iAll += dt1.Rows(i).Item(1).ToString
                        'ElseIf flag = "05" Then '기타요청
                        '   ToggleButton14.Text = "기타요청( " & dt1.Rows(i).Item(1).ToString() & " )"
                        '  iAll += dt1.Rows(i).Item(1).ToString
                    End If
                    iAll += dt1.Rows(i).Item(1).ToString
                Next
                ToggleButton15.Text = "전체( " & iAll & " )"

            Else
                Call gsInit(SELECT_INIT.TRANS)
            End If

            dt1 = Nothing

        Catch ex As Exception
            Call gsInit(SELECT_INIT.TRANS)
            Call WriteLog("getTransStatus : " & ex.ToString)
        End Try

    End Sub


    Public Sub getCallbackStatus()
        Try
            Dim SQL As String
            Dim strNow As String = Format(Now, "yyyyMMdd")
            SQL = "select call_back_result, count(*) "
            SQL = SQL & " from t_customer_history  "
            If isTest = True Then
                SQL = SQL & " where tond_dd like '" & Format(Now, "yyyyMM") & "%' "
            Else
                SQL = SQL & " where tond_dd =  '" & strNow & "' "
            End If
            SQL = SQL & " and com_cd ='" & gsCOM_CD & "'"
            SQL = SQL & " and call_back_yn ='Y'"
            SQL = SQL & " group by call_back_result "

            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)

            If dt1.Rows.Count > 0 Then
                Dim i As Integer
                Dim iAll As Integer = 0
                For i = 0 To dt1.Rows.Count - 1

                    Dim flag As String = dt1.Rows(i).Item(0).ToString()

                    If flag = "1" Then '처리완료
                        ToggleButton7.Text = "처리완료( " & dt1.Rows(i).Item(1).ToString() & " )"
                    ElseIf flag = "2" Then '미처리
                        ToggleButton8.Text = "미처리( " & dt1.Rows(i).Item(1).ToString() & " )"
                    End If
                    iAll += dt1.Rows(i).Item(1).ToString
                Next
                ToggleButton9.Text = "전체( " & iAll & " )"

            Else
                Call gsInit(SELECT_INIT.CALLBACK)
            End If

            dt1 = Nothing

        Catch ex As Exception
            Call gsInit(SELECT_INIT.CALLBACK)
            Call WriteLog("getConsultStatus : " & ex.ToString)
        End Try

    End Sub

    Enum SELECT_TYPE1
        NORMAL = 0
        TRANS = 1
    End Enum

    Public Sub gsSelect(ByVal sConsultType As String, ByVal selectMode As SELECT_TYPE1, ByRef dgView As System.Windows.Forms.DataGridView)

        Try
            Dim strNow As String = Format(Now, "yyyyMMdd")
            Dim SQL As String = "Select CUSTOMER_ID,CUSTOMER_NM "
            SQL = SQL & " ,CONCAT(SUBSTRING(TOND_DD,1,4) , '-' , SUBSTRING(TOND_DD,5,2) , '-' , SUBSTRING(TOND_DD,7,2)) tong_dd "
            SQL = SQL & " ,CONCAT(SUBSTRING(TONG_TIME,1,2) , ':' , SUBSTRING(TONG_TIME,3,2), ':' , SUBSTRING(TONG_TIME,5,2)) tong_time "
            SQL = SQL & " ,TONG_TELNO"
            SQL = SQL & " ,CONCAT(CONSULT_TYPE , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '003' AND S_MENU_CD = CONSULT_TYPE )) CONSULT_TYPE "
            SQL = SQL & " ,CONCAT(CONSULT_RESULT , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '004' AND S_MENU_CD = CONSULT_RESULT )) CONSULT_RESULT"
            SQL = SQL & " ,TONG_USER,TONG_CONTENTS "
            SQL = SQL & " ,CONCAT(CALL_TYPE , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '005' AND S_MENU_CD = CALL_TYPE )) CALL_TYPE "

            If selectMode = SELECT_TYPE1.TRANS Then
                SQL = SQL & " ,CONCAT(SUBSTRING(PREV_TONG_DD,1,4) , '-' , SUBSTRING(PREV_TONG_DD,5,2) , '-' , SUBSTRING(PREV_TONG_DD,7,2)) prev_tong_dd "
                SQL = SQL & " ,CONCAT(SUBSTRING(PREV_TONG_TIME,1,2) , ':' , SUBSTRING(PREV_TONG_TIME,3,2), ':' , SUBSTRING(PREV_TONG_TIME,5,2)) prev_tong_time "
                SQL = SQL & " ,PREV_TONG_USER "
            End If
            SQL = SQL & " FROM T_CUSTOMER_HISTORY "
            SQL = SQL & " WHERE COM_CD = '" & gsCOM_CD & "'"

            If isTest = True Then
                SQL = SQL & " AND tond_dd like '" & Format(Now, "yyyyMM") & "%' "
            Else
                SQL = SQL & " AND tond_dd =  '" & strNow & "' "
            End If

            If sConsultType = "all" Then
                ' all
            ElseIf sConsultType <> "" Then
                SQL = SQL & " AND CONSULT_RESULT = '" & sConsultType & "'"
            End If
            If selectMode = SELECT_TYPE1.NORMAL Then '상담결과
                'SQL = SQL & " AND CONSULT_RESULT <> '06'" '이관처리아닌 경우
                SQL = SQL & " AND TRANS_YN IS NULL " '이관처리아닌 경우
            Else '이관후 상담결과
                SQL = SQL & " AND TRANS_YN = 'Y' " '이관처리
            End If


            SQL = SQL & " ORDER BY TOND_DD + TONG_TIME DESC "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            dgView.DataSource = Nothing


            dgView.Columns.Clear()

            dgView.DataSource = dt1
            dgView.Columns.Item(0).HeaderText = "고객아이디"
            dgView.Columns.Item(1).HeaderText = "고객명"
            dgView.Columns.Item(2).HeaderText = "통화일자"
            dgView.Columns.Item(3).HeaderText = "통화시간"
            dgView.Columns.Item(4).HeaderText = "통화전화번호"
            dgView.Columns.Item(5).HeaderText = "상담유형"
            dgView.Columns.Item(6).HeaderText = "상담결과"
            dgView.Columns.Item(7).HeaderText = "통화자"
            dgView.Columns.Item(8).HeaderText = "통화내용"
            dgView.Columns.Item(9).HeaderText = "콜타입"

            If selectMode = SELECT_TYPE1.TRANS Then
                dgView.Columns.Item(10).HeaderText = "이전통화일자"
                dgView.Columns.Item(11).HeaderText = "이전통화시간"
                dgView.Columns.Item(12).HeaderText = "이전통화자"
            End If

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_MONITOR : " & ex.ToString)
        End Try
    End Sub

    Enum SELECT_TYPE
        CALLBACK_DONE = 1
        CALLBACK_UNDONE = 2
        CALLBACK_ALL = 3
    End Enum

    Public Sub gsSelectCallback(ByVal selectMode As SELECT_TYPE, ByRef dgView As System.Windows.Forms.DataGridView)
        Try
            Dim strNow As String = Format(Now, "yyyyMMdd")
            Dim SQL As String = "Select CUSTOMER_ID,CUSTOMER_NM "
            SQL = SQL & " ,CONCAT(SUBSTRING(TOND_DD,1,4) , '-' , SUBSTRING(TOND_DD,5,2) , '-' , SUBSTRING(TOND_DD,7,2)) tong_dd "
            SQL = SQL & " ,CONCAT(SUBSTRING(TONG_TIME,1,2) , ':' , SUBSTRING(TONG_TIME,3,2), ':' , SUBSTRING(TONG_TIME,5,2)) tong_time "
            SQL = SQL & " ,TONG_TELNO"
            SQL = SQL & " ,CONCAT(CALL_BACK_RESULT , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '014' AND S_MENU_CD = CALL_BACK_RESULT )) CALL_BACK_RESULT "
            SQL = SQL & " ,CONCAT(CONSULT_TYPE , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '003' AND S_MENU_CD = CONSULT_TYPE )) CONSULT_TYPE "
            SQL = SQL & " ,CONCAT(CONSULT_RESULT , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '004' AND S_MENU_CD = CONSULT_RESULT )) CONSULT_RESULT"
            SQL = SQL & " ,TONG_USER,TONG_CONTENTS "
            SQL = SQL & " ,CONCAT(CALL_TYPE , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '005' AND S_MENU_CD = CALL_TYPE )) CALL_TYPE "
            SQL = SQL & " FROM T_CUSTOMER_HISTORY "
            SQL = SQL & " WHERE COM_CD = '" & gsCOM_CD & "'"

            If isTest = True Then
                SQL = SQL & " AND tond_dd like '" & Format(Now, "yyyyMM") & "%' "
            Else
                SQL = SQL & " AND tond_dd =  '" & strNow & "' "
            End If

            If selectMode = SELECT_TYPE.CALLBACK_DONE Then
                SQL = SQL & " AND CALL_BACK_YN = 'Y'"
                SQL = SQL & " AND CALL_BACK_RESULT = '1'" '처리완료
            ElseIf selectMode = SELECT_TYPE.CALLBACK_UNDONE Then
                SQL = SQL & " AND CALL_BACK_YN = 'Y'"
                SQL = SQL & " AND CALL_BACK_RESULT = '2'" '미처리
            ElseIf selectMode = SELECT_TYPE.CALLBACK_ALL Then
                SQL = SQL & " AND CALL_BACK_YN = 'Y'"     '콜백전체
            End If

            SQL = SQL & " ORDER BY TOND_DD + TONG_TIME DESC "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            dgView.DataSource = Nothing


            dgView.Columns.Clear()

            dgView.DataSource = dt1
            dgView.DataSource = dt1
            dgView.Columns.Item(0).HeaderText = "고객아이디"
            dgView.Columns.Item(1).HeaderText = "고객명"
            dgView.Columns.Item(2).HeaderText = "통화일자"
            dgView.Columns.Item(3).HeaderText = "통화시간"
            dgView.Columns.Item(4).HeaderText = "통화전화번호"
            dgView.Columns.Item(5).HeaderText = "콜백처리결과"
            dgView.Columns.Item(6).HeaderText = "상담유형"
            dgView.Columns.Item(7).HeaderText = "상담결과"
            dgView.Columns.Item(8).HeaderText = "통화자"
            dgView.Columns.Item(9).HeaderText = "통화내용"
            dgView.Columns.Item(10).HeaderText = "콜타입"

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_MONITOR : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsFormExit()
        Try
            Me.Close()
        Catch ex As Exception
            Call WriteLog("FRM_MONITOR : " & ex.ToString)
        End Try
    End Sub


    Private Sub FRM_MONITOR_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Call gsFormExit()
    End Sub

    Private Sub ToggleModeSwitch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToggleButton1.Click, ToggleButton3.Click, ToggleButton2.Click, ToggleButton6.Click, ToggleButton4.Click
        Dim btn As Elegant.Ui.ToggleButton = sender

        For Each mBtn In Me.btnGrpConsult.Controls
            If TypeOf mBtn Is Elegant.Ui.ToggleButton Then
                Dim mTestBtn As Elegant.Ui.ToggleButton = mBtn
                If mTestBtn.Tag = btn.Tag Then
                    'MsgBox(btn.Tag, MsgBoxStyle.OkOnly, "알림")
                Else
                    mTestBtn.Pressed = False
                End If
            End If
        Next

        Select Case btn.Tag
            Case 1
                Call gsSelect("01", SELECT_TYPE1.NORMAL, dgViewMain)
            Case 2
                Call gsSelect("02", SELECT_TYPE1.NORMAL, dgViewMain)
            Case 3
                Call gsSelect("03", SELECT_TYPE1.NORMAL, dgViewMain)
            Case 4
                Call gsSelect("06", SELECT_TYPE1.NORMAL, dgViewMain)
                'Case 5
                '    Call gsSelect("05", SELECT_TYPE1.NORMAL, dgViewMain)
            Case 7
                Call gsSelect("all", SELECT_TYPE1.NORMAL, dgViewMain)
        End Select

        '값변경가능성 대비 refresh기능
        Call gsInit(SELECT_INIT.CONSULT)
        Call getConsultStatus()

    End Sub

    Private Sub ToggleTransSwitch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToggleButton10.Click, ToggleButton11.Click, ToggleButton12.Click, ToggleButton15.Click, ToggleButton5.Click
        Dim btn As Elegant.Ui.ToggleButton = sender

        For Each mBtn In Me.btnGrpTrans.Controls
            If TypeOf mBtn Is Elegant.Ui.ToggleButton Then
                Dim mTestBtn As Elegant.Ui.ToggleButton = mBtn
                If mTestBtn.Tag = btn.Tag Then
                    'MsgBox(btn.Tag, MsgBoxStyle.OkOnly, "알림")
                Else
                    mTestBtn.Pressed = False
                End If
            End If
        Next

        Select Case btn.Tag
            Case 1
                Call gsSelect("01", SELECT_TYPE1.TRANS, dgViewTrans)
            Case 2
                Call gsSelect("02", SELECT_TYPE1.TRANS, dgViewTrans)
            Case 3
                Call gsSelect("03", SELECT_TYPE1.TRANS, dgViewTrans)
            Case 4
                Call gsSelect("06", SELECT_TYPE1.TRANS, dgViewTrans)
                'Case 5
                '    Call gsSelect("05", SELECT_TYPE1.TRANS, dgViewTrans)
            Case 7
                Call gsSelect("all", SELECT_TYPE1.TRANS, dgViewTrans)
        End Select

        '값변경가능성 대비 refresh기능
        Call gsInit(SELECT_INIT.TRANS)
        Call getTransStatus()

    End Sub



    Private Sub ToggleCallbackSwitch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToggleButton7.Click, ToggleButton8.Click, ToggleButton9.Click
        Dim btn As Elegant.Ui.ToggleButton = sender

        For Each mBtn In Me.btnGrpCallback.Controls
            If TypeOf mBtn Is Elegant.Ui.ToggleButton Then
                Dim mTestBtn As Elegant.Ui.ToggleButton = mBtn
                If mTestBtn.Tag = btn.Tag Then
                    'MsgBox(btn.Tag, MsgBoxStyle.OkOnly, "알림")
                Else
                    mTestBtn.Pressed = False
                End If
            End If
        Next

        Select Case btn.Tag
            Case 1
                Call gsSelectCallback(SELECT_TYPE.CALLBACK_DONE, dgViewCallback)
            Case 2
                Call gsSelectCallback(SELECT_TYPE.CALLBACK_UNDONE, dgViewCallback)
            Case 3
                Call gsSelectCallback(SELECT_TYPE.CALLBACK_ALL, dgViewCallback)
        End Select

        '값변경가능성 대비 refresh기능
        Call gsInit(SELECT_INIT.CALLBACK)
        Call getCallbackStatus()
    End Sub

    Private Sub dgViewMain_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgViewMain.CellContentDoubleClick
        'Call WriteLog("FRM_MONITOR : " & _
        'dgViewMain.Rows(e.RowIndex).Cells(0).Value.ToString & ":" & _
        'dgViewMain.Rows(e.RowIndex).Cells(1).Value & ":" & _
        'dgViewMain.Rows(e.RowIndex).Cells(2).Value & ":" & _
        'dgViewMain.Rows(e.RowIndex).Cells(3).Value & ":" & _
        'dgViewMain.Rows(e.RowIndex).Cells(4).Value & ":" & _
        'dgViewMain.Rows(e.RowIndex).Cells(5).Value)

        'dgView.Columns.Item(2).HeaderText = "통화일자"
        'dgView.Columns.Item(3).HeaderText = "통화시간"
        'dgView.Columns.Item(4).HeaderText = "통화전화번호"
        Dim telNo As String = dgViewMain.Rows(e.RowIndex).Cells(4).Value
        Dim tongDate As String = dgViewMain.Rows(e.RowIndex).Cells(2).Value
        Dim tongTime As String = dgViewMain.Rows(e.RowIndex).Cells(3).Value
        Dim frm As FRM_MAIN = Me.MdiParent
        Call frm.OpenCustomerPopupMod(telNo, tongDate, tongTime)
    End Sub

    Private Sub dgViewTrans_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgViewTrans.CellContentDoubleClick
        Dim telNo As String = dgViewTrans.Rows(e.RowIndex).Cells(4).Value
        Dim tongDate As String = dgViewTrans.Rows(e.RowIndex).Cells(2).Value
        Dim tongTime As String = dgViewTrans.Rows(e.RowIndex).Cells(3).Value
        Dim frm As FRM_MAIN = Me.MdiParent
        Call frm.OpenCustomerPopupMod(telNo, tongDate, tongTime)
    End Sub

    Private Sub dgViewCallback_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgViewCallback.CellContentDoubleClick
        Dim telNo As String = dgViewCallback.Rows(e.RowIndex).Cells(4).Value
        Dim tongDate As String = dgViewCallback.Rows(e.RowIndex).Cells(2).Value
        Dim tongTime As String = dgViewCallback.Rows(e.RowIndex).Cells(3).Value
        Dim frm As FRM_MAIN = Me.MdiParent
        Call frm.OpenCustomerPopupMod(telNo, tongDate, tongTime)
    End Sub
End Class