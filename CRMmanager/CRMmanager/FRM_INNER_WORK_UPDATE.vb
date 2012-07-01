Imports Excel = Microsoft.Office.Interop.Excel

Public Class FRM_INNER_WORK_UPDATE
    Public ParentFrm As Windows.Forms.Form

    Dim excelApp As New Microsoft.Office.Interop.Excel.Application

    Private Sub btnClose2233_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose2233.Click
        Me.Close()
    End Sub

    Private Sub FRM_INNER_WORK_UPDATE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'DataGridView2.DataSource = dt1
        'DataGridView2.Columns.Item(0).HeaderText = "접수번호"
        'DataGridView2.Columns.Item(0).Width = 130
        'DataGridView2.Columns.Item(1).HeaderText = "고객"
        'DataGridView2.Columns.Item(1).Width = 200
        'DataGridView2.Columns.Item(2).HeaderText = "처리결과"
        'DataGridView2.Columns.Item(3).HeaderText = "접수일자"
        'DataGridView2.Columns.Item(4).HeaderText = "접수자"

        'DataGridView2.Columns.Item(5).HeaderText = "접수내용"
        'DataGridView2.Columns.Item(5).Width = 300
        'DataGridView2.Columns.Item(6).HeaderText = "처리일자"
        'DataGridView2.Columns.Item(7).HeaderText = "처리자"
        'DataGridView2.Columns.Item(8).HeaderText = "처리내용"
        'DataGridView2.Columns.Item(8).Width = 300
        'DataGridView2.Columns.Item(9).HeaderText = "고객아이디"

        Dim dt As DataTable
        Try

            Dim temp() As String = Me.Tag.ToString.Split("$")

            Dim SQL_TEMP As String = " SELECT CUSTOMER_ID ,CUSTOMER_NM ,C_TELNO ,H_TELNO ,FAX_NO "
            SQL_TEMP = SQL_TEMP & " ,CONCAT(CUSTOMER_TYPE ,'.', (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '006' AND S_MENU_CD = CUSTOMER_TYPE )) CUSTOMER_TYPE  "
            SQL_TEMP = SQL_TEMP & ",WOO_NO ,CUSTOMER_ADDR ,CUSTOMER_ETC "
            SQL_TEMP = SQL_TEMP & " FROM T_CUSTOMER "
            SQL_TEMP = SQL_TEMP & " WHERE  CUSTOMER_ID = " & temp(9)

            dt = GetData_table1(gsConString, SQL_TEMP)

            If dt.Rows.Count > 0 Then

                For i = 0 To dt.Rows.Count - 1
                    txtCustomerID33.Text = dt.Rows(i).Item(0).ToString
                    txtCustomerName33.Text = dt.Rows(i).Item(1).ToString

                    Dim kk() As String = gfTelNoTransReturn(dt.Rows(i).Item(2).ToString).Split("-")

                    txtWorkTelNo433.Text = kk(0)
                    txtWorkTelNo533.Text = kk(1)
                    txtWorkTelNo633.Text = kk(2)

                    Dim hp() As String = gfTelNoTransReturn(dt.Rows(i).Item(3).ToString).Split("-")
                    txtHP033.Text = hp(0)
                    txtHP133.Text = hp(1)
                    txtHP233.Text = hp(2)

                    Dim fax() As String = gfTelNoTransReturn(dt.Rows(i).Item(4).ToString).Split("-")
                    txtFaxNo133.Text = fax(0)
                    txtFaxNo233.Text = fax(1)
                    txtFaxNo333.Text = fax(2)

                    If dt.Rows(i).Item(6).ToString.Length = 6 Then
                        txtWP333.Text = dt.Rows(i).Item(6).ToString.Substring(0, 3)
                        txtWP433.Text = dt.Rows(i).Item(6).ToString.Substring(3, 3)
                    Else
                        txtWP333.Text = ""
                        txtWP433.Text = ""
                    End If


                    txtCustomertype33.Text = dt.Rows(i).Item(5).ToString
                    txtAddress133.Text = dt.Rows(i).Item(7).ToString
                    txtEtcInfo33.Text = dt.Rows(i).Item(8).ToString
                Next

            End If


            If temp(3).Trim <> "" Then
                DPDate3333.Value = temp(3)
            Else
                DPDate3333.Value = Format(Now, "yyyy-MM-dd")
            End If

            txtJupsuNo33.Text = temp(0).Trim
            txtJupsuJa33.Text = temp(4).Trim
            txtJupsuContents33.Text = temp(5).Trim

            If temp(6).Trim <> "" Then
                DPDate4333.Value = temp(6)
            Else
                DPDate4333.Value = Format(Now, "yyyy-MM-dd")
            End If


            If temp(7).Trim <> "" Then
                txtChury33.Text = temp(7).Trim
            Else
                txtChury33.Text = gsUSER_ID & "." & gsUSER_NM
            End If


            If temp(2).Trim.Substring(0, 1) = "0" Then
                rbOK33.Checked = False
                rbNo33.Checked = True
            ElseIf temp(2).Trim.Substring(0, 1) = "1" Then
                rbOK33.Checked = True
                rbNo33.Checked = False
            Else
                rbOK33.Checked = False
                rbNo33.Checked = True
            End If

            txtChuryContents33.Text = temp(8).Trim

            txtChuryContents33.Focus()

        Catch ex As Exception

        Finally
            dt = Nothing
        End Try

    End Sub

    Private Sub btnContentsSave33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContentsSave33.Click

        'select COM_CD,JUPSU_DD,JUPSU_NO,JUPSUJA,IFNULL(CHURYJA,''),CUSTOMER_ID,JUPSU_CONTENTS,CHURY_DD,GUBUN,CHURY_CONTENTS,CUSTOMER_NM from t_inner_work;

        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim sql As String = " UPDATE t_inner_work SET CHURY_DD = '" & DPDate4333.Text.Trim.Replace("-", "") & "'"
            sql = sql & ",CHURYJA = '" & txtChury33.Text.Trim & "'"
            sql = sql & ",CHURY_CONTENTS = '" & txtChuryContents33.Text.Trim & "'"
            If rbOK33.Checked Then
                sql = sql & ",GUBUN = '1'"
            ElseIf rbOK33.Checked Then
                sql = sql & ",GUBUN = '0'"
            End If
            sql = sql & " WHERE COM_CD = '" & gsCOM_CD & "'"
            sql = sql & " AND  JUPSU_DD = '" & DPDate3333.Text.Trim.Replace("-", "") & "'"
            sql = sql & " AND  JUPSU_NO = '" & txtJupsuNo33.Text.Trim & "'"
            sql = sql & " AND  JUPSUJA = '" & txtJupsuJa33.Text.Trim & "'"

            Dim dt As DataTable = GetData_table1(gsConString, sql)

            dt = Nothing

            MsgBox("데이터가 업데이트 됐습니다.", MsgBoxStyle.OkOnly, "알림")
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            Me.Close()

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try

    End Sub

    'Private Sub btnDelete33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete33.Click
    '    Try

    '    Catch ex As Exception

    '    End Try

    'End Sub



    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim filepath As String = "C:\MiniCTI\접수처리이력.xls"
        Dim filepath As String = Application.StartupPath & "\INNER_WORK_UPDATE.xls"
        Dim temp12 As String = "미처리"
        Dim temp As String = ""
        Dim excelBook As Microsoft.Office.Interop.Excel.Workbook
        Dim excelWorksheet As Microsoft.Office.Interop.Excel.Worksheet
        Try
            If excelApp Is Nothing Then
                MsgBox("엑셀이 설치되지 않았거나 다른문제가 있습니다.", MsgBoxStyle.OkOnly, "정보")
                Exit Try
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            'If System.IO.File.Exists(filepath) = False Then
            Dim misValue As Object = System.Reflection.Missing.Value

            excelApp = New Excel.ApplicationClass
            excelBook = excelApp.Workbooks.Add(misValue)
            excelWorksheet = excelBook.Sheets("sheet1")
            'excelWorksheet.Cells(1, 1) = "http://vb.net-informations.com"
            'excelWorksheet.SaveAs("C:\vbexcel.xlsx")

            'excelBook.Close()
            'excelApp.Quit()

            'releaseObject(excelApp)
            'releaseObject(excelBook)
            'releaseObject(excelWorksheet)

            'MsgBox("인쇄용 엑셀 파일이 존재하지 않습니다.", MsgBoxStyle.OkOnly, "정보")
            'Exit Try
            'End If

            ''excelBook = excelApp.Workbooks.Add
            'excelBook = excelApp.Workbooks.Open(filepath)
            excelWorksheet = CType(excelBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            If rbOK33.Checked = True Then temp12 = "처리"

            With excelWorksheet
                '{"고객아이디", "고객명", "전화번호", "핸드폰", "팩스번호", "우편번호", "고객유형", "주소", "기타정보", "접수일자", "접수번호", "접수자", "접수내용", "처리일자", "처리자", "처리여부", "처리내용"})
                .Cells(4, 1) = "고객아이디"
                .Cells(4, 2) = txtCustomerID33.Text.Trim
                .Cells(4, 3) = "고객명"
                .Cells(4, 4) = txtCustomerName33.Text.Trim
                .Cells(5, 2) = txtWorkTelNo433.Text.Trim & "-" & txtWorkTelNo533.Text.Trim & "-" & txtWorkTelNo633.Text.Trim
                .Cells(5, 4) = txtHP033.Text.Trim & "-" & txtHP133.Text.Trim & "-" & txtHP233.Text.Trim
                .Cells(5, 6) = txtFaxNo133.Text.Trim & "-" & txtFaxNo233.Text.Trim & "-" & txtFaxNo333.Text.Trim
                .Cells(6, 2) = txtWP333.Text.Trim & "-" & txtWP433.Text.Trim
                .Cells(6, 4) = txtCustomertype33.Text.Trim
                .Cells(7, 2) = txtAddress133.Text.Trim
                .Cells(8, 2) = txtEtcInfo33.Text.Trim
                .Cells(12, 2) = DPDate3333.Text.Trim
                .Cells(12, 4) = txtJupsuNo33.Text.Trim
                .Cells(12, 6) = txtJupsuJa33.Text.Trim
                .Cells(13, 2) = txtJupsuContents33.Text.Trim
                .Cells(17, 2) = DPDate4333.Text.Trim
                .Cells(17, 4) = txtChury33.Text.Trim
                .Cells(17, 6) = temp12
                .Cells(18, 2) = txtChuryContents33.Text.Trim
            End With
            excelApp.Visible = True '자동으로 엑셀 파일이 열린다
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            excelWorksheet = Nothing
            excelBook = Nothing
            GC.Collect()

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            WriteLog(ex.ToString)
            excelWorksheet = Nothing
            excelBook = Nothing
            excelApp.Quit()
            excelApp = Nothing
            GC.Collect()
        Finally

        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        excelApp.Quit()
        excelApp = Nothing
        GC.Collect()
    End Sub
End Class