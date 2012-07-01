Public Class FRM_CUSTOMER_FIND

    Public ParentFrm As Windows.Forms.Form

    Private Sub FRM_CUSTOMER_FIND_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim info As String() = Me.Tag.ToString.Split("^")

        txtCMName.Text = info(0)
        txtTelNo.Text = info(1)

        Call VarInit()
        Call lsSelect()

    End Sub

    Private Sub VarInit()
        txtFindCmName.Text = ""
        txtID.Text = ""
    End Sub
    Private Sub btnCmSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmSelect.Click
        Call VarInit()
        Call lsSelect()
    End Sub

    Private Sub lsSelect()
        Try
            Dim SQL As String = " select CUSTOMER_NM,C_TELNO,H_TELNO,CUSTOMER_ID from t_customer WHERE COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_NM like '%" & txtCMName.Text.Trim & "%'"

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
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex


            With DataGridView1.Rows(i)
                txtFindCmName.Text = .Cells(0).Value.ToString
                txtID.Text = .Cells(3).Value.ToString
            End With


        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub btnTelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTelAdd.Click
        Try
            If txtTelNo.Text.Trim = "" Then
                MsgBox("등록할 전화번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If gfTelNoTransReturn(txtTelNo.Text.Trim) = "000-0000-0000" Then
                MsgBox("등록할 전화번호를 정확히 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If
            'select COM_CD,CUSTOMER_ID,TELNO_TYPE,TELNO from t_customer_telno

            Dim SQL As String = " SELECT COUNT(*) FROM t_customer_telno  WHERE COM_CD ='" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & txtID.Text.Trim
            SQL = SQL & " AND TELNO = '" & txtTelNo.Text.Trim.Replace("-", "") & "'"

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
                SQL = SQL & "," & txtID.Text.Trim

                SQL = SQL & ",'" & txtTelNo.Text.Trim & "')"

            ElseIf CNT > "0" Then
                MsgBox("이미 등록되어 있는 전화 번호입니다.다른 번호를 등록하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub

            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            MsgBox("데이터가 저장 됐습니다.", MsgBoxStyle.OkOnly, "알림")
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name & ":" & ex.ToString)
        End Try

        ParentFrm.Tag = save_telno()
        Me.Close()

    End Sub

    Public Function save_telno() As String
        Return txtTelNo.Text.Trim
    End Function

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class