

Public Class FRM_HISTORY_CALLBACK

    Private ss As New CRMmanager
    Private result As Integer = 0

    Private Sub FRM_HISTORY_CALLBACK_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SettoolBar(False, True, False, False, False, True, True)
    End Sub

    Private Sub FRM_HISTORY_CALLBACK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Call SettoolBar(False, True, False, False, False, True, True)

            dpt1.Value = Format(Now, "yyyy-MM-dd")
            dpt2.Value = Format(Now, "yyyy-MM-dd")

            cbH1.SelectedIndex = 0
            cbT1.SelectedIndex = 0

            cbH2.SelectedIndex = 23
            cbT2.SelectedIndex = 6

            '************************************** 콜백처리결과 입력 *********************************************
            Dim SQL_TEMP As String = Find_Query("014")
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboCallBackResult.DataSource = dt1
            cboCallBackResult.DisplayMember = dt1.Columns(0).ToString
            cboCallBackResult.ValueMember = dt1.Columns(1).ToString

            setComboSelect(cboCallBackResult, 2) 'cboCallBackResult.SelectedIndex = 2
            dt1 = Nothing

            '************************************** 상담결과 입력 *********************************************
            SQL_TEMP = Find_Query("004")
            Dim dt2 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboConsultResult.DataSource = dt2
            cboConsultResult.DisplayMember = dt2.Columns(0).ToString
            cboConsultResult.ValueMember = dt2.Columns(1).ToString

            cboConsultResult.SelectedIndex = 0
            dt2 = Nothing

            '************************************** 상담유형 입력 *********************************************
            SQL_TEMP = Find_Query("003")
            Dim dt3 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboConsultType.DataSource = dt3
            cboConsultType.DisplayMember = dt3.Columns(0).ToString
            cboConsultType.ValueMember = dt3.Columns(1).ToString

            cboConsultType.SelectedIndex = 0
            dt3 = Nothing

            '************************************** 통화자 *********************************************
            Dim SQL As String = " SELECT '' ,'XXXX' UNION ALL SELECT LTRIM(RTRIM(USER_NM)), CONCAT(USER_ID,'.',LTRIM(RTRIM(USER_NM))) FROM T_USER WHERE COM_CD = '" & gsCOM_CD & "'"
            Dim dt4 As DataTable = GetData_table1(gsConString, SQL)

            cboUser.DataSource = dt4
            cboUser.DisplayMember = dt4.Columns(0).ToString
            cboUser.ValueMember = dt4.Columns(1).ToString

            'cboConsultType.SelectedIndex = 0
            cboUser.SelectedIndex = 0
            dt4 = Nothing


            Call gsSelect(True)

        Catch ex As Exception
            Call WriteLog("FRM_HISTORY_CALLBACK : " & ex.ToString)
        End Try


    End Sub

    Public Sub gsSelect(ByVal isInit As Boolean)
        Try
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
            If Not isInit Then
                SQL = SQL & " AND TOND_DD >= '" & dpt1.Text.ToString.Replace("-", "") & "'"
                SQL = SQL & " AND TOND_DD <= '" & dpt2.Text.ToString.Replace("-", "") & "'"
                SQL = SQL & " AND TONG_TIME >= '" & cbH1.Text & cbT1.Text & "00" & "'"
                SQL = SQL & " AND TONG_TIME <= '" & cbH2.Text & cbT2.Text & "00" & "'"
                SQL = SQL & " AND TONG_TELNO LIKE  '" & txtTongNo.Text.Trim & "%'"
                SQL = SQL & " AND TONG_USER LIKE  '" & cboUser.SelectedValue.ToString.Replace("XXXX", "") & "%'"
                SQL = SQL & " AND CALL_BACK_YN = 'Y'"
                'If cboConsultType.SelectedIndex >= 0 Then
                '    SQL = SQL & " AND CONSULT_TYPE LIKE  '" & cboConsultType.SelectedValue.ToString.Replace("XXXX", "") & "%'"
                'End If
                If cboCallBackResult.SelectedValue.ToString <> "" Then
                    SQL = SQL & " AND CALL_BACK_RESULT LIKE  '" & cboCallBackResult.SelectedValue.ToString.Replace("XXXX", "") & "%'"
                End If
                If cboConsultType.SelectedValue.ToString <> "" Then
                    SQL = SQL & " AND CONSULT_TYPE LIKE  '" & cboConsultType.SelectedValue.ToString.Replace("XXXX", "") & "%'"
                End If

                'If cboConsultResult.SelectedIndex >= 0 Then
                '    SQL = SQL & " AND CONSULT_RESULT LIKE  '" & cboConsultResult.SelectedValue.ToString.Replace("XXXX", "") & "%'"
                'End If
                If cboConsultResult.SelectedValue.ToString <> "" Then
                    SQL = SQL & " AND CONSULT_RESULT LIKE  '" & cboConsultResult.SelectedValue.ToString.Replace("XXXX", "") & "%'"
                End If
            Else
                Dim tm As String = Format(Now, "yyyyMMdd")
                SQL = SQL & " AND TOND_DD >= '" & tm & "'"
                SQL = SQL & " AND CALL_BACK_YN = 'Y'"
                SQL = SQL & " AND CALL_BACK_RESULT LIKE  '2'"
            End If
            SQL = SQL & " ORDER BY TOND_DD + TONG_TIME DESC "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView2.DataSource = Nothing


            DataGridView2.Columns.Clear()

            DataGridView2.DataSource = dt1
            DataGridView2.Columns.Item(0).HeaderText = "고객아이디"
            DataGridView2.Columns.Item(1).HeaderText = "고객명"
            DataGridView2.Columns.Item(2).HeaderText = "통화일자"
            DataGridView2.Columns.Item(3).HeaderText = "통화시간"
            DataGridView2.Columns.Item(4).HeaderText = "통화전화번호"
            DataGridView2.Columns.Item(5).HeaderText = "콜백처리결과"
            DataGridView2.Columns.Item(6).HeaderText = "상담유형"
            DataGridView2.Columns.Item(7).HeaderText = "상담결과"
            DataGridView2.Columns.Item(8).HeaderText = "통화자"
            DataGridView2.Columns.Item(9).HeaderText = "통화내용"
            DataGridView2.Columns.Item(10).HeaderText = "콜타입"

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            Call subVarInit()

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_HISTORY_CALLBACK : " & ex.ToString)
        Finally
            result = 1
        End Try
    End Sub

    Private Sub subVarInit()
        txtSubCustomerName.Text = ""
        txtDate.Text = ""
        txtTongTime.Text = ""
        txtSubTongNo.Text = ""

        txtCallBackResult.Text = ""
        txtConsultType.Text = ""
        txtConsultResult.Text = ""
        txtSubTongUser.Text = ""
        txtTongEtcInfo.Text = ""
    End Sub

    Public Sub gsFormExit()
        Try
            Me.Close()
        Catch ex As Exception
            Call WriteLog("FRM_HISTORY_CALLBACK : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        '조회
        Call gsSelect(False)
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Try

            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex


            With DataGridView2.Rows(i)
                Call subVarInit()

                txtSubCustomerName.Text = .Cells(1).Value.ToString
                txtDate.Text = .Cells(2).Value.ToString
                txtTongTime.Text = .Cells(3).Value.ToString
                txtSubTongNo.Text = gfTelNoTransReturn(.Cells(4).Value.ToString)

                txtCallBackResult.Text = .Cells(5).Value.ToString
                txtConsultType.Text = .Cells(6).Value.ToString
                txtConsultResult.Text = .Cells(7).Value.ToString
                txtSubTongUser.Text = .Cells(8).Value.ToString
                txtTongEtcInfo.Text = .Cells(9).Value.ToString
            End With

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub btnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        'Dim tm As String = Format(Now, "yyyyMMddhhmmss")
        'ss.POPUP_Selected(txtSubTongNo.Text.Trim, txtDate.Text.Trim, txtTongTime.Text.Trim)
        Dim frm As FRM_MAIN = Me.MdiParent
        Call frm.OpenCustomerPopupMod(txtSubTongNo.Text.Trim, txtDate.Text.Trim, txtTongTime.Text.Trim)
    End Sub

    Private Sub FRM_HISTORY_CALLBACK_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Call gsFormExit()

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            With SaveFileDialog1
                .CheckPathExists = True
                .Filter = "Excel통합문서(*.xlsx)|*.xlsx|Excel97-2003문서(*.xls)|*.xls"
                .FileName = "콜백조회" & "_" & Format(Now, "yyyyMMdd")
                .Title = "콜백조회 엑셀로 내보내기"
                .ShowDialog()
            End With
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            result = 0
            Call gsSelect(False)
            While (result = 0)
                Threading.Thread.Sleep(1000)
            End While
            Call Excel_Export2(SaveFileDialog1.FileName, SaveFileDialog1.Title, DataGridView2, "0,1,")
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub
End Class