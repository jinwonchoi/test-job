Public Class FRM_INNER_WORK

    Private result As Integer = 0
    Private Sub FRM_INNER_WORK_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SettoolBar(True, True, True, False, False, True, True)
    End Sub

    Private Sub FRM_INNER_WORK_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '
        Call SettoolBar(True, True, True, False, False, True, True)
        DPDate11.Value = Format(Now, "yyyy-MM-dd")
        DPDate22.Value = Format(Now, "yyyy-MM-dd")
        DPDate33.Value = Format(Now, "yyyy-MM-dd")

        txtJupsuJa.Text = gsUSER_ID & "." & gsUSER_NM

        cboGubun.SelectedIndex = 0

    End Sub

    Public Sub gsFormExit()
        Me.Close()
    End Sub

    Private Sub btnSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect1.Click
        Call gsSelect()
    End Sub

    Public Sub gsSelect()
        Try

            Dim SQL As String = " SELECT JUPSU_NO,CUSTOMER_NM,CASE WHEN GUBUN = '0' THEN '0.접수/처리중' WHEN GUBUN='1' THEN '1.처리완료' END GUBUN "
            SQL = SQL & ", CONCAT(SUBSTRING(JUPSU_DD,1,4) , '-' , SUBSTRING(JUPSU_DD,5,2) , '-' , SUBSTRING(JUPSU_DD,7,2 )) JUPSU_DD"
            SQL = SQL & ", JUPSUJA JUPSUJA,JUPSU_CONTENTS "
            SQL = SQL & ", CASE WHEN LENGTH(CHURY_DD) = 8 THEN  CONCAT(SUBSTRING(CHURY_DD,1,4) , '-' , SUBSTRING(CHURY_DD,5,2) , '-' , SUBSTRING(CHURY_DD,7,2 )) ELSE '' END CHURY_DD"
            SQL = SQL & ", CHURYJA,CHURY_CONTENTS,CUSTOMER_ID "
            SQL = SQL & " FROM t_inner_work "
            SQL = SQL & " WHERE  COM_CD = '" & gsCOM_CD & "'" & " AND JUPSU_DD >= '" & DPDate11.Text.ToString.Replace("-", "") & "'"
            SQL = SQL & " AND JUPSU_DD <= '" & DPDate22.Text.ToString.Replace("-", "") & "'"


            If cboGubun.SelectedIndex = 1 Then
                SQL = SQL & " AND GUBUN ='0'"          '처리/접수중
            ElseIf cboGubun.SelectedIndex = 2 Then
                SQL = SQL & " AND GUBUN ='1'"          '처리완료
            End If

            'If rbNo.Checked Then
            '    SQL = SQL & " AND GUBUN ='0'"          '처리/접수중
            'ElseIf rbOK.Checked Then
            '    SQL = SQL & " AND GUBUN ='1'"          '처리완료
            'End If

            If txtCHPerson.Text.Trim <> "" Then
                SQL = SQL & " AND CHURYJA LIKE '%" & txtCHPerson.Text.Trim & "%' "
            End If

            SQL = SQL & " ORDER BY JUPSU_DD  ASC "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView2.DataSource = Nothing

            DataGridView2.Columns.Clear()

            DataGridView2.DataSource = dt1
            DataGridView2.Columns.Item(0).HeaderText = "접수번호"
            DataGridView2.Columns.Item(0).Width = 130
            DataGridView2.Columns.Item(1).HeaderText = "고객"
            DataGridView2.Columns.Item(1).Width = 200
            DataGridView2.Columns.Item(2).HeaderText = "처리결과"
            DataGridView2.Columns.Item(3).HeaderText = "접수일자"
            DataGridView2.Columns.Item(4).HeaderText = "접수자"

            DataGridView2.Columns.Item(5).HeaderText = "접수내용"
            DataGridView2.Columns.Item(5).Width = 300
            DataGridView2.Columns.Item(6).HeaderText = "처리일자"
            DataGridView2.Columns.Item(7).HeaderText = "처리자"
            DataGridView2.Columns.Item(8).HeaderText = "처리내용"
            DataGridView2.Columns.Item(8).Width = 300
            DataGridView2.Columns.Item(9).HeaderText = "고객아이디"


            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

            txtCID.Focus()

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        Finally
            result = 1
        End Try

    End Sub

    Private Sub btnClose22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose22.Click
        Call gsFormExit()
    End Sub

    Private Sub btnContentsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContentsSave.Click
        Call gsSave()
    End Sub

    Public Sub gsSave()
        'select COM_CD,JUPSU_DD,JUPSU_NO,JUPSUJA,IFNULL(CHURYJA,''),CUSTOMER_ID,JUPSU_CONTENTS,CHURY_DD,GUBUN,CHURY_CONTENTS,CUSTOMER_NM from t_inner_work;
        Dim Sql As String = " INSERT INTO t_inner_work(COM_CD,JUPSU_DD,JUPSU_NO,JUPSUJA,CHURYJA,CUSTOMER_ID,JUPSU_CONTENTS,CHURY_DD,GUBUN,CHURY_CONTENTS,CUSTOMER_NM ) "
        Sql = Sql & "values( '" & gsCOM_CD & "'"
        Sql = Sql & ",'" & DPDate11.Text.ToString.Replace("-", "") & "'"
        Sql = Sql & ",'" & DPDate11.Text.ToString.Replace("-", "") & "_" & gsUSER_ID & "_" & Format(Now, "hhmmss") & "'"
        Sql = Sql & ",'" & gsUSER_ID & "." & gsUSER_NM & "'"
        Sql = Sql & ",'" & "" & "'"

        If Not IsNumeric(txtCID.Text.Trim) Then
            Sql = Sql & "," & "0"
        Else
            Sql = Sql & "," & txtCID.Text.Trim
        End If

        Sql = Sql & ",'" & txtJupsuContents.Text.Trim & "'"
        Sql = Sql & ",'" & "" & "'"
        Sql = Sql & ",'" & "0" & "'"
        Sql = Sql & ",'" & "" & "'"
        Sql = Sql & ",'" & txtCName.Text.Trim & "'"
        Sql = Sql & ")"
        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, Sql)

            dt = Nothing
            ' 삭제된 데이터를 refresh 한다
            Call gsInit()
            Call gsSelect()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try

    End Sub

    Private Sub btnInit22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInit22.Click
        Call gsInit()
    End Sub
    Public Sub gsInit()
        txtCID.Text = ""
        txtJupsuContents.Text = ""
        txtCName.Text = ""
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Try
            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex

            Dim tag_string As String

            With DataGridView2.Rows(i)

                tag_string = .Cells(0).Value.ToString & "$" & _
                                             .Cells(1).Value.ToString & "$" & _
                                              .Cells(2).Value.ToString & "$" & _
                                              .Cells(3).Value.ToString & "$" & _
                                              .Cells(4).Value.ToString & "$" & _
                                              .Cells(5).Value.ToString & "$" & _
                                              .Cells(6).Value.ToString & "$" & _
                                              .Cells(7).Value.ToString & "$" & _
                                              .Cells(8).Value.ToString & "$" & _
                                              .Cells(9).Value.ToString
            End With

            FRM_INNER_WORK_UPDATE.ParentFrm = Me
            FRM_INNER_WORK_UPDATE.Tag = tag_string
            AddHandler FRM_INNER_WORK_UPDATE.btnContentsSave33.Click, AddressOf inner_work_save
            FRM_INNER_WORK_UPDATE.ShowDialog()
            FRM_INNER_WORK_UPDATE.Focus()



        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub inner_work_save(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Call gsSelect()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub txtCID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCID.KeyDown
        Try
            If e.KeyValue = Keys.Enter Then  'Keys.Enter : 13

                FRM_FIND_CUSTOMERID.ParentFrm = Me
                FRM_FIND_CUSTOMERID.Tag = txtCID.Text.Trim
                AddHandler FRM_FIND_CUSTOMERID.btnClose44.Click, AddressOf return_customerid_name
                FRM_FIND_CUSTOMERID.ShowDialog()
                FRM_FIND_CUSTOMERID.Focus()
            End If

        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub return_customerid_name(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim str As String = Me.Tag.ToString
            Dim tmp As String() = str.Split("^")
            txtCID.Text = tmp(0)
            txtCName.Text = tmp(1)
            txtJupsuContents.Focus()

        Catch ex As Exception
            txtCID.Text = ""
            txtCName.Text = ""
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub


    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            With SaveFileDialog1
                .CheckPathExists = True
                .Filter = "Excel통합문서(*.xlsx)|*.xlsx|Excel97-2003문서(*.xls)|*.xls"
                .FileName = "직원업무일지" & "_" & Format(Now, "yyyyMMdd")
                .Title = "직원업무일지 엑셀로 내보내기"
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
            Call Excel_Export2(SaveFileDialog1.FileName, SaveFileDialog1.Title, DataGridView2, "0,1,")
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try
    End Sub
End Class