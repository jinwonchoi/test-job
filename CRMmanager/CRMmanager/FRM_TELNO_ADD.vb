Public Class FRM_TELNO_ADD

    Private Function gfTelNoReturn(ByVal telno As String) As String
        Dim tel As String = "000-0000-0000"

        Try
            Dim tel_no As String = txtFrmTelNo.Text.Trim.Substring(0, 3)

            Dim pre_tel_no As String = "0000"
            Dim mid_tel_no As String = "0000"
            Dim last_tel_no As String = "0000"

            If tel_no = "010" Or tel_no = "011" Or tel_no = "016" Or tel_no = "017" Or tel_no = "018" Or tel_no = "019" Then
                pre_tel_no = tel_no
                Dim rest_telno As String = telno.Substring(3)
                If rest_telno.Length = 7 Then
                    mid_tel_no = telno.Substring(3, 3)
                    last_tel_no = telno.Substring(6)
                ElseIf rest_telno.Length = 8 Then
                    mid_tel_no = telno.Substring(3, 4)
                    last_tel_no = telno.Substring(7)
                End If

                tel = pre_tel_no + "-" + mid_tel_no + "-" + last_tel_no
            Else

                tel_no = txtFrmTelNo.Text.Trim.Substring(0, 2)

                If tel_no = "02" Then            ' 서울 지역일때
                    pre_tel_no = "02"

                    Dim rest_telno As String = telno.Substring(2)
                    If rest_telno.Length = 7 Then
                        mid_tel_no = telno.Substring(2, 3)
                        last_tel_no = telno.Substring(5)
                    ElseIf rest_telno.Length = 8 Then
                        mid_tel_no = telno.Substring(2, 4)
                        last_tel_no = telno.Substring(6)
                    End If

                    tel = pre_tel_no + "-" + mid_tel_no + "-" + last_tel_no
                Else
                    pre_tel_no = telno.Substring(0, 3)

                    Dim rest_telno As String = telno.Substring(3)
                    If rest_telno.Length = 7 Then
                        mid_tel_no = telno.Substring(3, 3)
                        last_tel_no = telno.Substring(6)
                    ElseIf rest_telno.Length = 8 Then
                        mid_tel_no = telno.Substring(3, 4)
                        last_tel_no = telno.Substring(7)
                    End If

                    tel = pre_tel_no + "-" + mid_tel_no + "-" + last_tel_no
                End If

            End If

        Catch ex As Exception
            tel = "000-0000-0000"
        End Try

        Return tel

    End Function

    Private Sub btnSaveTelNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTelNo.Click
        Try
            If txtFrmTelNo.Text.Trim = "" Then
                MsgBox("등록할 전화번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If gfTelNoReturn(txtFrmTelNo.Text.Trim) = "000-0000-0000" Then
                MsgBox("등록할 전화번호를 정확히 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If
            'select COM_CD,CUSTOMER_ID,TELNO_TYPE,TELNO from t_customer_telno

            Dim SQL As String = " SELECT COUNT(*) FROM t_customer_telno  WHERE COM_CD ='" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & txtFrmTelNoID.Text.Trim
            SQL = SQL & " AND TELNO = '" & txtFrmTelNo.Text.Trim.Replace("-", "") & "'"

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
                SQL = SQL & "," & txtFrmTelNoID.Text.Trim

                SQL = SQL & ",'" & txtFrmTelNo.Text.Trim & "')"

            ElseIf CNT > "0" Then
                MsgBox("이미 등록되어 있는 전화 번호입니다.다른 번호를 등록하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub

            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            MsgBox("데이터가 저장 됐습니다.", MsgBoxStyle.OkOnly, "알림")
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call gsSelect()

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("btnDelTelNo : " & ex.ToString)
        End Try
    End Sub


    Private Sub gsSelect()
        Try
            Dim SQL As String = " select  y.CUSTOMER_nm ,x.TELNO,x.CUSTOMER_ID from t_customer_telno x,t_customer y  WHERE x.COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND x.CUSTOMER_ID =" & Me.Tag.ToString
            SQL = SQL & " AND x.CUSTOMER_ID = y.CUSTOMER_ID "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView1.DataSource = Nothing


            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dt1
            DataGridView1.Columns.Item(0).HeaderText = "고객"
            DataGridView1.Columns.Item(1).HeaderText = "전화번호"
            DataGridView1.Columns.Item(2).HeaderText = "고객아이디"


            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_TELNO_ADD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtFrmTelNoID.Text = Me.Tag
            Call gsSelect()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTelAddClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTelAddClose.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelTelNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelTelNo.Click
        Try
            If txtFrmTelNo.Text.Trim = "" Then
                MsgBox("삭제할 전화번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If
            'select COM_CD,CUSTOMER_ID,TELNO_TYPE,TELNO from t_customer_telno

            Dim SQL As String = " DELETE FROM t_customer_telno WHERE COM_CD ='" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & txtFrmTelNoID.Text.Trim
            SQL = SQL & " AND TELNO = '" & txtFrmTelNo.Text.Trim.Replace("-", "") & "'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            MsgBox("데이터가 삭제 됐습니다.", MsgBoxStyle.OkOnly, "알림")
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call gsSelect()

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("btnDelTelNo : " & ex.ToString)
        End Try

    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex


            With DataGridView1.Rows(i)
                txtFrmTelNoID.Text = .Cells(2).Value.ToString
                txtFrmTelNo.Text = .Cells(1).Value.ToString
            End With


        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class