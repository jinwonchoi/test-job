Public Class FRM_CUSTOMER_HISTORY_MODIFY

    Public ParentFrm As Windows.Forms.Form

    Private Sub FRM_CUSTOMER_HISTORY_MODIFY_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim SQL_TEMP As String = Find_Query("006")

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

            '************************************** 콜타입입력 *********************************************
            SQL_TEMP = Find_Query("005")
            Dim dt4 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboCallType.DataSource = dt4
            cboCallType.DisplayMember = dt4.Columns(0).ToString
            cboCallType.ValueMember = dt4.Columns(1).ToString

            cboCallType.SelectedIndex = 0
            dt4 = Nothing

            Dim str() As String = Me.Tag.ToString.Split("$")

            txtCCId.Text = str(0).ToString.Trim
            txtSubCustomerName.Text = str(1).ToString.Trim
            txtDate.Text = str(2).ToString.Trim
            txtTongTime.Text = str(3).ToString.Trim

            If str(4).ToString.Trim.Replace("-", "").Length < 9 Then
                txtTongNo.Text = ""
            Else
                txtTongNo.Text = gfTelNoTransReturn(str(4).ToString.Trim.Replace("-", ""))
            End If

            cboConsultType.SelectedValue = str(5).ToString.Trim
            cboConsultResult.SelectedValue = str(6).ToString.Trim

            txtTongUser.Text = str(7).ToString.Trim
            txtTongEtcInfo.Text = str(8).ToString.Trim
            cboCallType.SelectedValue = str(9).ToString.Trim

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnContentsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim sql As String

            If cboCallType.SelectedValue.ToString.Trim = "XXXX" Then
                sql = "UPDATE T_CUSTOMER_HISTORY SET CALL_TYPE = '" & "" & "'"
            Else
                sql = "UPDATE T_CUSTOMER_HISTORY SET CALL_TYPE = '" & cboCallType.SelectedValue.ToString.Trim & "'"
            End If

            'If cboConsultResult.SelectedText = "" Then
            '    sql = sql & " ,CONSULT_RESULT =''"
            'Else
            If cboConsultResult.SelectedValue.ToString.Trim = "XXXX" Then
                sql = sql & " ,CONSULT_RESULT =''"
            Else
                sql = sql & " ,CONSULT_RESULT = '" & cboConsultResult.SelectedValue.ToString.Trim & "'"   ' 상담결과
            End If
            'End If

            'If cboConsultType.SelectedText = "" Then
            '    sql = sql & " ,CONSULT_TYPE = '' "
            'Else
            If cboConsultType.SelectedValue.ToString.Trim = "XXXX" Then
                sql = sql & " ,CONSULT_TYPE = '' "
            Else
                sql = sql & " , CONSULT_TYPE ='" & cboConsultType.SelectedValue.ToString.Trim & "'"    ' 상담유형
            End If

            'End If

            sql = sql & ", TONG_CONTENTS = '" & txtTongEtcInfo.Text.Trim & "'"    ' 통화내용
            sql = sql & " ,TONG_USER = '" & txtTongUser.Text.Trim & "'"    ' 통화자
            sql = sql & " ,CUSTOMER_NM = '" & txtSubCustomerName.Text.Trim & "'"    ' 통화자
            sql = sql & " ,TONG_TELNO = '" & txtTongNo.Text.Trim.Replace("-", "") & "'"    ' 전화번호


            sql = sql & " WHERE COM_CD =  '" & gsCOM_CD & "'"

            If txtCCId.Text.Trim = "" Then
                sql = sql & " AND CUSTOMER_ID =  0 "
            Else
                sql = sql & " AND CUSTOMER_ID =  " & txtCCId.Text.Trim
            End If
            sql = sql & " AND TOND_DD =  '" & txtDate.Text.Trim.Replace("-", "") & "'"
            sql = sql & " AND TONG_TIME =  '" & txtTongTime.Text.Trim.Replace(":", "") & "'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, sql)

            dt = Nothing
            MsgBox("데이터가 수정됐됐습니다.", MsgBoxStyle.OkOnly, "알림")
            'MessageBox.Show("데이터가 수정됐됐습니다")

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FRM_CUSTOMER_POPUP.gsSubSelect(txtCCId.Text.Trim)
        Me.Close()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '저장
        Try
            Dim sql As String

            If cboCallType.SelectedIndex < 0 Then
                sql = "UPDATE T_CUSTOMER_HISTORY SET CALL_TYPE = '" & "" & "'"
            Else
                sql = "UPDATE T_CUSTOMER_HISTORY SET CALL_TYPE = '" & cboCallType.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"

            End If


            If cboConsultResult.SelectedIndex < 0 Then
                sql = sql & " ,CONSULT_RESULT =''"
            Else
                sql = sql & " ,CONSULT_RESULT = '" & cboConsultResult.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"   ' 상담결과
            End If

            If cboConsultType.SelectedIndex < 0 Then
                sql = sql & " ,CONSULT_TYPE = '' "
            Else
                sql = sql & " ,CONSULT_TYPE ='" & cboConsultType.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"    ' 상담유형
            End If


            sql = sql & " ,TONG_CONTENTS = '" & txtTongEtcInfo.Text.Trim & "'"    ' 통화내용
            sql = sql & " ,TONG_USER = '" & txtTongUser.Text.Trim & "'"    ' 통화자
            sql = sql & " ,CUSTOMER_NM = '" & txtSubCustomerName.Text.Trim & "'"    ' 통화자
            sql = sql & " ,TONG_TELNO = '" & txtTongNo.Text.Trim.Replace("-", "") & "'"    ' 통화자


            sql = sql & " WHERE COM_CD =  '" & gsCOM_CD & "'"

            If txtCCId.Text.Trim = "" Then
                sql = sql & " AND CUSTOMER_ID =  0 "
            Else
                sql = sql & " AND CUSTOMER_ID =  " & txtCCId.Text.Trim
            End If
            sql = sql & " AND TOND_DD =  '" & txtDate.Text.Trim.Replace("-", "") & "'"
            sql = sql & " AND TONG_TIME =  '" & txtTongTime.Text.Trim.Replace(":", "") & "'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, sql)

            dt = Nothing
            MsgBox("데이터가 수정됐됐습니다.", MsgBoxStyle.OkOnly, "알림")
            'MessageBox.Show("데이터가 수정됐됐습니다")

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        '닫기
        'FRM_CUSTOMER_POPUP.gsSubSelect(txtCCId.Text.Trim)
        Me.Close()
    End Sub
End Class