Public Class FRM_CUSTOMER_TELNO
    Public ParentFrm As Windows.Forms.Form
    Dim mCustomerId As String = ""
    Dim mSelectedTelNo As String = ""

    Public Sub setInfo(ByVal customerId As String, ByVal customerName As String)
        mCustomerId = customerId
        txtCMName1.Text = customerName
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Try
            'ParentFrm.Tag = Setting_TelNo()
            Setting_TelNo()
            Me.Close()
        Catch ex As Exception
            MsgBox("고객정보를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Function Setting_TelNo() As String
        Return ""
    End Function

    Private Sub selectId()
        Try
            txtFindTelNo.Text = ""
            mSelectedTelNo = ""

            Dim SQL As String = " select TELNO from t_customer_telno WHERE COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID like '%" & mCustomerId.Trim & "%'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView1.DataSource = Nothing


            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dt1
            DataGridView1.Columns.Item(0).FillWeight = 20
            DataGridView1.Columns.Item(0).Width = 120
            DataGridView1.Columns.Item(0).HeaderText = "전화번호"
            DataGridView1.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name & ":" & ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex

            With DataGridView1.Rows(i)
                txtFindTelNo.Text = .Cells(0).Value.ToString
                mSelectedTelNo = .Cells(0).Value.ToString
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim IsInsert As Boolean = False
        Try
            If mSelectedTelNo.Trim = "" Then
                IsInsert = True
            End If
            '
            If txtFindTelNo.Text.Trim = "" Then
                If IsInsert Then
                    MsgBox("등록할 전화번호가 없습니다.", MsgBoxStyle.OkOnly, "알림")
                Else
                    MsgBox("수정할 전화번호가 없습니다.", MsgBoxStyle.OkOnly, "알림")
                End If
                Exit Sub
            End If

            If gfTelNoTransReturn(txtFindTelNo.Text.Trim) = "000-0000-0000" Then
                MsgBox("등록할 전화번호를 정확히 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            'select COM_CD,CUSTOMER_ID,TELNO_TYPE,TELNO from t_customer_telno

            Dim SQL As String = " SELECT COUNT(*) FROM t_customer_telno "
            SQL = SQL & " WHERE COM_CD ='" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & mCustomerId
            SQL = SQL & " AND TELNO = '" & txtFindTelNo.Text.Trim.Replace("-", "") & "'"

            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            Dim CNT As String = "0"


            If dt1.Rows.Count > 0 Then

                Dim i As Integer
                Dim CntString As String = "0"

                For i = 0 To dt1.Rows.Count - 1
                    CNT = dt1.Rows(i).Item(0).ToString
                Next
            Else
                MsgBox("전화번호를 저장할 수 없습니다.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If IsInsert And CNT > 0 Then
                MsgBox("등록할 전화번호가 이미 존재합니다.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            dt1 = Nothing

            If Not IsInsert Then
                If Not DeleteTelNo() Then
                    MsgBox("전화번호를 변경하지 못했습니다..", MsgBoxStyle.OkOnly, "알림")
                    Exit Sub
                End If
            End If

            If Not InsertTelNo() Then
                If IsInsert Then
                    MsgBox("전화번호를 등록하지 못했습니다..", MsgBoxStyle.OkOnly, "알림")
                Else
                    MsgBox("전화번호를 변경하지 못했습니다..", MsgBoxStyle.OkOnly, "알림")
                End If
                Exit Sub
            End If

            If IsInsert Then
                MsgBox("전화번호가 등록되었습니다.", MsgBoxStyle.OkOnly, "알림")
            Else
                MsgBox("선택한 번호가 수정되었습니다.", MsgBoxStyle.OkOnly, "알림")
            End If
            Call selectId()
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name & ":btnModify_Click:" & mCustomerId & ":" & txtFindTelNo.Text & ex.ToString)
        End Try
    End Sub

    Private Function InsertTelNo()
        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim Sql As String = "Insert Into t_customer_telno (COM_CD, CUSTOMER_ID, TELNO, TELNO_TYPE) Values("
            Sql = Sql & " '" & gsCOM_CD & "'"
            Sql = Sql & " ,'" & mCustomerId & "'"
            Sql = Sql & " ,'" & txtFindTelNo.Text.Trim & "','')"

            Dim dt As DataTable = GetData_table1(gsConString, Sql)

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Return True
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":InsertTelNo:" & mCustomerId & ":" & txtFindTelNo.Text & ex.ToString)
            Return False
        End Try

    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        '고객정보삭제
        If txtFindTelNo.Text.Trim = "" Then
            MsgBox("삭제할 데이터를 선택 하세요.", MsgBoxStyle.OkOnly, "알림")
            Exit Sub
        End If
        If deleteTelNo() Then
            MsgBox("데이터가 삭제 됐습니다.", MsgBoxStyle.OkOnly, "알림")
            Call selectId()
        Else
            MsgBox("데이터가 삭제되지 않았습니다.", MsgBoxStyle.OkOnly, "알림")
        End If
    End Sub

    Private Function DeleteTelNo() As Boolean
        '고객정보삭제
        Try

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim SQL As String = " DELETE FROM T_CUSTOMER_TELNO WHERE COM_CD = '" & gsCOM_CD & _
                                "' AND CUSTOMER_ID = '" & mCustomerId.Trim & _
                                "' AND TELNO = '" & mSelectedTelNo.Trim & "'"
            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Return True
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":DeleteTelNo:" & mCustomerId & ":" & txtFindTelNo.Text & ex.ToString)
            Return False
        End Try

    End Function

    Private Sub FRM_CUSTOMER_TELNO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call selectId()
    End Sub

End Class