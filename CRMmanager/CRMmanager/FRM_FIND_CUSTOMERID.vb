Public Class FRM_FIND_CUSTOMERID
    Public ParentFrm As Windows.Forms.Form

    Private Sub btnClose44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose44.Click
        Try
            ParentFrm.Tag = txtCustomerId55.Text.Trim & "^" & txtCustomerNm55.Text.Trim
            Me.Close()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try

    End Sub

    Private Sub control_init()
        txtCustomerNm55.Text = ""
        txtCustomerId55.Text = ""
    End Sub
    Private Sub btnCmSelect44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmSelect44.Click
        Call control_init()
        Call lsSelect()

    End Sub

    Private Sub FRM_FIND_CUSTOMERID_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtCMName44.Text = Me.Tag.ToString.Trim
            Call control_init()
            Call lsSelect()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lsSelect()
        Try
            Dim SQL As String = " select CUSTOMER_NM,C_TELNO,H_TELNO,CUSTOMER_ID from t_customer WHERE COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_NM like '%" & txtCMName44.Text.Trim & "%'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView1.DataSource = Nothing


            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dt1
            DataGridView1.Columns.Item(0).HeaderText = "고객"
            DataGridView1.Columns.Item(1).HeaderText = "전화번호"
            DataGridView1.Columns.Item(2).HeaderText = "핸드폰번호"
            DataGridView1.Columns.Item(3).HeaderText = "고객아이디"


            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name & ":" & ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        '
        Try
            If e.RowIndex < 0 Then Exit Try

            Call control_init()

            Dim i As Integer = e.RowIndex

            With DataGridView1.Rows(i)

                txtCustomerNm55.Text = .Cells(0).Value.ToString
                txtCustomerId55.Text = .Cells(3).Value.ToString
            End With

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class