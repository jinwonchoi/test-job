Public Class FRM_FIND_ID_BY_TELNO
    Public ParentFrm As Windows.Forms.Form
    Dim mEnteringNo As String = ""
    Dim mCustomerId As String = ""

    Public Sub setInfo(ByVal enteringNo As String, ByVal customerName As String)
        mEnteringNo = enteringNo
        txtEnteringNo.Text = enteringNo
        txtCMName1.Text = customerName
        Call queryCustomerInfo()
    End Sub

    Public Sub queryCustomerInfo()
        Call initCustomerInfo()
        Call selectId()
    End Sub

    Public Sub initCustomerInfo()
        mCustomerId = ""
        txtFindCmName1.Text = ""
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Try
            ParentFrm.Tag = Setting_CustomerId()
            Me.Close()
        Catch ex As Exception
            MsgBox("고객정보를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Function Setting_CustomerId() As String
        Try
            If mCustomerId.Trim = "" Then
                Call WriteLog(Me.Name & " : customer id doesn't exist")
                Exit Try
            End If
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            Setting_CustomerId = mCustomerId.Trim
        End Try
    End Function

    Private Sub selectId()
        Try
            Dim SQL As String = " select CUSTOMER_ID,CUSTOMER_NM,C_TELNO,H_TELNO from t_customer WHERE COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_NM like '%" & txtCMName1.Text.Trim & "%'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView1.DataSource = Nothing


            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dt1
            DataGridView1.Columns.Item(0).HeaderText = "고객아이디"
            DataGridView1.Columns.Item(1).HeaderText = "고객"
            DataGridView1.Columns.Item(2).HeaderText = "전화번호"
            DataGridView1.Columns.Item(3).HeaderText = "핸드폰번호"

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name & ":" & ex.ToString)
        End Try

    End Sub

    Private Sub btnCmSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmSelect1.Click
        Call queryCustomerInfo()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            txtFindCmName1.Text = ""
            mCustomerId = ""

            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex


            With DataGridView1.Rows(i)
                mCustomerId = .Cells(0).Value.ToString
                txtFindCmName1.Text = .Cells(1).Value.ToString
            End With

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub btnTelAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTelAdd1.Click

        Try
            If txtEnteringNo.Text.Trim = "" Then
                MsgBox("등록할 전화번호가 없습니다.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If gfTelNoTransReturn(txtEnteringNo.Text.Trim) = "000-0000-0000" Then
                MsgBox("등록할 전화번호를 정확히 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If
            If mCustomerId.Trim = "" Then
                MsgBox("고객정보를 선택하세요. 조회된 고객정보가 없는 경우, 고객정보를 먼저 등록하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            'select COM_CD,CUSTOMER_ID,TELNO_TYPE,TELNO from t_customer_telno

            Dim SQL As String = " SELECT COUNT(*) FROM t_customer_telno  WHERE COM_CD ='" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & mCustomerId.Trim
            SQL = SQL & " AND TELNO = '" & txtEnteringNo.Text.Trim.Replace("-", "") & "'"

            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            Dim CNT As String = "0"


            If dt1.Rows.Count > 0 Then

                Dim i As Integer
                Dim CntString As String = "0"

                For i = 0 To dt1.Rows.Count - 1
                    CNT = dt1.Rows(i).Item(0).ToString
                Next
            Else
                CNT = "0"
            End If

            dt1 = Nothing

            If CNT = "0" Then
                SQL = " INSERT INTO t_customer_telno( COM_CD,CUSTOMER_ID,TELNO) VALUES( "
                SQL = SQL & "'" & gsCOM_CD & "'"
                SQL = SQL & "," & mCustomerId.Trim

                SQL = SQL & ",'" & txtEnteringNo.Text.Trim & "')"

            ElseIf CNT > "0" Then
                MsgBox("이미 등록되어 있는 전화 번호입니다.다른 번호를 등록하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            MsgBox("선택한 번호가 추가되었습니다.", MsgBoxStyle.OkOnly, "알림")

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name & ":" & ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '고객정보삭제
        Try
            If txtFindCmName1.Text.Trim = "" Then
                MsgBox("삭제할 데이터를 선택 하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim SQL As String = " DELETE FROM T_CUSTOMER_TELNO WHERE COM_CD = '" & gsCOM_CD & _
                                "' AND CUSTOMER_ID = '" & mCustomerId.Trim & _
                                "' AND TELNO = '" & txtEnteringNo.Text.Trim & "'"
            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            MsgBox("데이터가 삭제 됐습니다.", MsgBoxStyle.OkOnly, "알림")

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try
    End Sub

    Private Sub txtCMName1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCMName1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call queryCustomerInfo()
        End If
    End Sub
End Class