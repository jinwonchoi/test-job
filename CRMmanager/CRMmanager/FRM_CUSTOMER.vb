Public Class FRM_CUSTOMER

    Dim mCustomer As String = ""
    Private result As Integer = 0

    Private Sub FRM_CUSTOMER_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SettoolBar(True, True, True, True, False, True, True)
    End Sub

    Private Sub FRM_CUSTOMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt1 As DataTable
        Try
            btnTelNoAdd.Enabled = False

            cboTelType.SelectedIndex = 0
            cboHP.SelectedIndex = 0

            Call SettoolBar(True, True, True, True, False, True, True)

            '******************************************* 고객 유형 입력 ***********************************************************
            Dim SQL_TEMP As String = " SELECT '' S_MENU_NM,'XXXX' S_MENU_CD UNION ALL SELECT S_MENU_NM,S_MENU_CD FROM T_S_CODE WHERE  COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '006' "

            dt1 = GetData_table1(gsConString, SQL_TEMP)

            cboCustomerType.DataSource = dt1
            cboCustomerType.DisplayMember = dt1.Columns(0).ToString
            cboCustomerType.ValueMember = dt1.Columns(1).ToString

            cboCustomerType.SelectedIndex = 0
            If Not gbIsCustomerTablePatched Then
                pnlCustomerMiddle.Hide()
                pnlCustomerBottom.Top = pnlCustomerMiddle.Top
            End If
        Catch ex As Exception
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        Finally
            dt1 = Nothing
        End Try
    End Sub

    Public Sub gsFormExit()
        Try
            Me.Close()
        Catch ex As Exception
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSelect()

        Try

            Dim SQL_TEMP As String = " SELECT CUSTOMER_ID ,CUSTOMER_NM ,C_TELNO ,H_TELNO ,FAX_NO "
            If gbIsCustomerTablePatched Then
                SQL_TEMP = SQL_TEMP & ",COMPANY, DEPARTMENT, JOB_TITLE, EMAIL "
            End If
            SQL_TEMP = SQL_TEMP & " ,CONCAT(CUSTOMER_TYPE ,'.', (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '006' AND S_MENU_CD = CUSTOMER_TYPE )) CUSTOMER_TYPE  "
            SQL_TEMP = SQL_TEMP & ",WOO_NO ,CUSTOMER_ADDR ,CUSTOMER_ETC "
            SQL_TEMP = SQL_TEMP & " FROM T_CUSTOMER "

            Dim custom_id As String = "0"
            Dim dt1 As DataTable

            If txtTelNo.Text.Trim <> "" Then
                Dim SQL As String = " SELECT ifnull(max(CUSTOMER_ID),'0') FROM t_customer_telno  WHERE COM_CD ='" & gsCOM_CD & "'"
                'SQL = SQL & " AND CUSTOMER_ID = " & txtFrmTelNoID.Text.Trim
                SQL = SQL & " AND TELNO = '" & txtTelNo.Text.Trim.Replace("-", "") & "'"

                dt1 = GetData_table1(gsConString, SQL)

                Dim CNT As String = "0"
                Dim i As Integer

                If dt1.Rows.Count > 0 Then

                    For i = 0 To dt1.Rows.Count - 1
                        custom_id = dt1.Rows(i).Item(0).ToString
                    Next
                Else
                    custom_id = "0"
                End If
                dt1 = Nothing

            End If

            If custom_id = "0" Then

                Dim i As Integer = 0

                If cboTelType.SelectedIndex = 0 Then
                    i = 1
                    SQL_TEMP = SQL_TEMP & " WHERE  C_TELNO LIKE '" & txtTelNo.Text.Trim & "%'"
                End If

                If cboTelType.SelectedIndex = 1 Then
                    i = 1
                    SQL_TEMP = SQL_TEMP & " WHERE H_TELNO LIKE '" & txtTelNo.Text.Trim & "%'"
                End If

                If cboTelType.SelectedIndex = 2 Then
                    i = 1
                    SQL_TEMP = SQL_TEMP & " WHERE FAX_NO LIKE '" & txtTelNo.Text.Trim & "%'"
                End If

                If i = 0 Then
                    SQL_TEMP = SQL_TEMP & " WHERE  COM_CD = '" & gsCOM_CD & "' AND  CUSTOMER_NM LIKE '" & txtCustomerNM.Text.Trim & "%' ORDER BY CUSTOMER_NM ASC"
                Else
                    SQL_TEMP = SQL_TEMP & " AND COM_CD = '" & gsCOM_CD & "' AND   CUSTOMER_NM LIKE '" & txtCustomerNM.Text.Trim & "%'  ORDER BY CUSTOMER_NM ASC"
                End If

            Else
                SQL_TEMP = SQL_TEMP & " WHERE  customer_id = " & custom_id & " AND  CUSTOMER_NM LIKE '" & txtCustomerNM.Text.Trim & "%' ORDER BY CUSTOMER_NM ASC"

            End If


            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


            Dim dt2 As DataTable = GetData_table1(gsConString, SQL_TEMP)
            DataGridView1.DataSource = Nothing


            'Dim i, j As Integer

            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = dt2
            DataGridView1.Columns.Item(0).HeaderText = "고객아이디"
            DataGridView1.Columns.Item(1).HeaderText = "고객명"
            DataGridView1.Columns.Item(2).HeaderText = "전화번호"
            DataGridView1.Columns.Item(3).HeaderText = "휴대폰"
            DataGridView1.Columns.Item(4).HeaderText = "팩스번호"
            If gbIsCustomerTablePatched Then
                DataGridView1.Columns.Item(5).HeaderText = "회사"
                DataGridView1.Columns.Item(6).HeaderText = "소속"
                DataGridView1.Columns.Item(7).HeaderText = "직급"
                DataGridView1.Columns.Item(8).HeaderText = "이메일"
                DataGridView1.Columns.Item(9).HeaderText = "고객유형"
                DataGridView1.Columns.Item(10).HeaderText = "우편번호"
                DataGridView1.Columns.Item(11).HeaderText = "주소"
                DataGridView1.Columns.Item(12).HeaderText = "기타정보"
            Else
                DataGridView1.Columns.Item(5).HeaderText = "고객유형"
                DataGridView1.Columns.Item(6).HeaderText = "우편번호"
                DataGridView1.Columns.Item(7).HeaderText = "주소"
                DataGridView1.Columns.Item(8).HeaderText = "기타정보"
            End If

            dt2 = Nothing

            Call gsInit()

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        Finally
            result = 1
        End Try
    End Sub

    Private Sub gsSubSelect()
        Try
            Dim SQL As String = "Select CUSTOMER_NM "
            SQL = SQL & " ,CONCAT(SUBSTRING(TOND_DD,1,4) ,'-', SUBSTRING(TOND_DD,5,2) ,'-' , SUBSTRING(TOND_DD,7,2)) tong_dd "
            SQL = SQL & " ,CONCAT(SUBSTRING(TONG_TIME,1,2) , ':' , SUBSTRING(TONG_TIME,3,2), ':', SUBSTRING(TONG_TIME,5,2)) tong_time "
            SQL = SQL & " ,TONG_TELNO"
            SQL = SQL & " ,(SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '003' AND S_MENU_CD = CONSULT_TYPE ) CONSULT_TYPE "
            SQL = SQL & " ,(SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '004' AND S_MENU_CD = CONSULT_RESULT ) CONSULT_RESULT"
            SQL = SQL & " ,TONG_USER,TONG_CONTENTS "
            SQL = SQL & " FROM T_CUSTOMER_HISTORY "
            SQL = SQL & " WHERE TONG_USER LIKE '" & gsUSER_ID & "%' "
            SQL = SQL & " AND CUSTOMER_ID = " & mCustomer.Trim
            SQL = SQL & " ORDER BY TOND_DD + TONG_TIME DESC "


            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView2.DataSource = Nothing


            'Dim i, j As Integer

            DataGridView2.Columns.Clear()

            DataGridView2.DataSource = dt1
            DataGridView2.Columns.Item(0).HeaderText = "고객명"
            DataGridView2.Columns.Item(1).HeaderText = "통화일자"
            DataGridView2.Columns.Item(2).HeaderText = "통화시간"
            DataGridView2.Columns.Item(3).HeaderText = "통화전화번호"
            DataGridView2.Columns.Item(4).HeaderText = "상담유형"
            DataGridView2.Columns.Item(5).HeaderText = "상담결과"
            DataGridView2.Columns.Item(6).HeaderText = "통화자"
            DataGridView2.Columns.Item(7).HeaderText = "통화내용"

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSave()

        If txtCustomerID.Text.Trim <> "" Then
            MsgBox("고객을 신규 등록 할 수 없습니다.먼저 초기화 시킨후 신규 등록 하세요.", MsgBoxStyle.OkOnly, "알림")
            Exit Sub
        End If

        Dim SQL As String = ""

        If txtWorkTelNo1.Text.Trim <> "" Then
            If Not IsNumeric(txtWorkTelNo1.Text.Trim) Then
                MsgBox("전화번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("전화번호를 숫자로 입력하세요")
                txtWorkTelNo1.Focus()
                Exit Sub
            End If
        End If
        If txtWorkTelNo2.Text.Trim <> "" Then
            If Not IsNumeric(txtWorkTelNo2.Text.Trim) Then
                MsgBox("전화번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("전화번호를 숫자로 입력하세요")
                txtWorkTelNo2.Focus()
                Exit Sub
            End If
        End If
        If txtWorkTelNo3.Text.Trim <> "" Then
            If Not IsNumeric(txtWorkTelNo3.Text.Trim) Then
                MsgBox("전화번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("전화번호를 숫자로 입력하세요")
                txtWorkTelNo3.Focus()
                Exit Sub
            End If
        End If

        If txtHP1.Text.Trim <> "" Then
            If Not IsNumeric(txtHP1.Text.Trim) Then
                MsgBox("핸드폰 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("핸드폰 번호를 숫자로 입력하세요")
                txtHP1.Focus()
                Exit Sub
            End If
        End If
        If txtHP2.Text.Trim <> "" Then
            If Not IsNumeric(txtHP2.Text.Trim) Then
                MsgBox("핸드폰 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("핸드폰 번호를 숫자로 입력하세요")
                txtHP2.Focus()
                Exit Sub
            End If
        End If

        If txtFaxNo1.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo1.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("팩스 번호를 숫자로 입력하세요")
                txtFaxNo1.Focus()
                Exit Sub
            End If
        End If
        If txtFaxNo2.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo2.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("팩스 번호를 숫자로 입력하세요")
                txtFaxNo2.Focus()
                Exit Sub
            End If
        End If
        If txtFaxNo3.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo3.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("팩스 번호를 숫자로 입력하세요")
                txtFaxNo3.Focus()
                Exit Sub
            End If
        End If

        If txtWP1.Text.Trim <> "" Then '
            If Not IsNumeric(txtWP1.Text.Trim) Then
                MsgBox("우편 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("우편 번호를 숫자로 입력하세요")
                txtWP1.Focus()
                Exit Sub
            End If
        End If

        If txtWP2.Text.Trim <> "" Then '
            If Not IsNumeric(txtWP2.Text.Trim) Then
                MsgBox("우편 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "에러")
                'MessageBox.Show("우편 번호를 숫자로 입력하세요")
                txtWP2.Focus()
                Exit Sub
            End If
        End If

        If txtCustomerName.Text.Trim = "" Then
            MsgBox("고객명을 입력 하세요.", MsgBoxStyle.OkOnly, "에러")
            'MessageBox.Show("고객명을 입력 하세요")
            txtCustomerName.Focus()
            Exit Sub
        End If

        SQL = " INSERT INTO T_CUSTOMER( COM_CD,CUSTOMER_NM,C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR"
        SQL = SQL & ",CUSTOMER_ETC, UPDATE_DATE "
        If gbIsCustomerTablePatched Then
            SQL = SQL & ",COMPANY, DEPARTMENT, JOB_TITLE, EMAIL "
        End If
        SQL = SQL & ") values( '" & gsCOM_CD & "'"
        SQL = SQL & ",'" & txtCustomerName.Text.Trim & "'"
        SQL = SQL & ",'" & txtWorkTelNo1.Text.Trim + txtWorkTelNo2.Text.Trim + txtWorkTelNo3.Text.Trim & "'"

        If cboHP.SelectedIndex < 0 Then
            SQL = SQL & ",'" & "" & "'"
        Else
            SQL = SQL & ",'" & cboHP.SelectedItem.ToString.Trim.Replace("XXXX", "") + txtHP1.Text.Trim + txtHP2.Text.Trim & "'"
        End If

        SQL = SQL & ",'" & txtFaxNo1.Text.Trim + txtFaxNo2.Text.Trim + txtFaxNo3.Text.Trim & "'"

        If cboCustomerType.SelectedIndex < 0 Then
            SQL = SQL & ",'" & "" & "'" ' CUSTOMER TYPE
        Else
            SQL = SQL & ",'" & cboCustomerType.SelectedValue.ToString.Replace("XXXX", "") & "'" ' CUSTOMER TYPE
        End If

        SQL = SQL & ",'" & txtWP1.Text.Trim & txtWP2.Text.Trim & "'"
        SQL = SQL & ",'" & txtAddress.Text.Trim & "'"
        SQL = SQL & ",'" & txtEtcInfo.Text.Trim & "'"

        SQL = SQL & ",'" & Format(Now, "yyyyMMddHHmmss") & "'"
        If gbIsCustomerTablePatched Then
            SQL = SQL & ",'" & txtCompany.Text.Trim & "'"
            SQL = SQL & ",'" & txtDepartment.Text.Trim & "'"
            SQL = SQL & ",'" & txtJobTitle.Text.Trim & "'"
            SQL = SQL & ",'" & txtEmail.Text.Trim & "'"
        End If
        SQL = SQL & ")"



        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            ' 삭제된 데이터를 refresh 한다
            Call gsSelect()
            Call gsInit()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try

    End Sub

    Public Sub gsDelete()
        '
        Try
            If txtCustomerID.Text.Trim = "" Then
                MsgBox("삭제할 데이터를 위데이터 목록에서 선택 하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("삭제할 데이터를 위데이터 목록에서 선택 하세요")
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim SQL As String = " DELETE FROM T_CUSTOMER WHERE COM_CD = '" & gsCOM_CD & "' AND CUSTOMER_ID = " & txtCustomerID.Text.Trim
            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            ' 삭제된 데이터를 refresh 한다
            Call gsSelect()
            Call gsInit()

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try

    End Sub


    Public Sub gsInit()

        btnTelNoAdd.Enabled = False
        '모든 입력 변수를 초기화 시킬때 사용

        txtCustomerID.Text = ""
        txtCustomerName.Text = ""
        txtWorkTelNo1.Text = ""
        txtWorkTelNo2.Text = ""
        txtWorkTelNo3.Text = ""
        txtHP1.Text = ""
        txtHP2.Text = ""
        txtFaxNo1.Text = ""
        txtFaxNo2.Text = ""
        txtFaxNo3.Text = ""
        txtWP1.Text = ""
        txtWP2.Text = ""
        txtAddress.Text = ""
        txtEtcInfo.Text = ""

        txtCompany.Text = ""
        txtDepartment.Text = ""
        txtJobTitle.Text = ""
        txtEmail.Text = ""

        cboHP.SelectedIndex = 0

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try

            If TabControl1.SelectedIndex = 1 Then
                Call gsSubSelect()
            End If

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Call gsSelect()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' 신규등록
        Call gsSave()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        ' 수정
        Dim SQL As String = ""

        If txtCustomerID.Text.Trim = "" Then
            MsgBox("수정할 데이터를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
            'MessageBox.Show("수정할 데이터를 선택하세요")
            Exit Sub
        End If

        If txtWorkTelNo1.Text.Trim <> "" Then
            If Not IsNumeric(txtWorkTelNo1.Text.Trim) Then
                MsgBox("전화번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("전화번호를 숫자로 입력하세요")
                txtWorkTelNo1.Focus()
                Exit Sub
            End If
        End If
        If txtWorkTelNo2.Text.Trim <> "" Then
            If Not IsNumeric(txtWorkTelNo2.Text.Trim) Then
                MsgBox("전화번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("전화번호를 숫자로 입력하세요")
                txtWorkTelNo2.Focus()
                Exit Sub
            End If
        End If
        If txtWorkTelNo3.Text.Trim <> "" Then
            If Not IsNumeric(txtWorkTelNo3.Text.Trim) Then
                MsgBox("전화번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("전화번호를 숫자로 입력하세요")
                txtWorkTelNo3.Focus()
                Exit Sub
            End If
        End If

        If txtHP1.Text.Trim <> "" Then
            If Not IsNumeric(txtHP1.Text.Trim) Then
                MsgBox("핸드폰 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("핸드폰 번호를 숫자로 입력하세요")
                txtHP1.Focus()
                Exit Sub
            End If
        End If
        If txtHP2.Text.Trim <> "" Then
            If Not IsNumeric(txtHP2.Text.Trim) Then
                MsgBox("핸드폰 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("핸드폰 번호를 숫자로 입력하세요")
                txtHP2.Focus()
                Exit Sub
            End If
        End If

        If txtFaxNo1.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo1.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("팩스 번호를 숫자로 입력하세요")
                txtFaxNo1.Focus()
                Exit Sub
            End If
        End If
        If txtFaxNo2.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo2.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("팩스 번호를 숫자로 입력하세요")
                txtFaxNo2.Focus()
                Exit Sub
            End If
        End If
        If txtFaxNo3.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo3.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("팩스 번호를 숫자로 입력하세요")
                txtFaxNo3.Focus()
                Exit Sub
            End If
        End If

        If txtWP1.Text.Trim <> "" Then '
            If Not IsNumeric(txtWP1.Text.Trim) Then
                MsgBox("우편 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("우편 번호를 숫자로 입력하세요")
                txtWP1.Focus()
                Exit Sub
            End If
        End If

        If txtWP2.Text.Trim <> "" Then '
            If Not IsNumeric(txtWP2.Text.Trim) Then
                MsgBox("우편 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                'MessageBox.Show("우편 번호를 숫자로 입력하세요")
                txtWP2.Focus()
                Exit Sub
            End If
        End If



        ' 업데이트
        SQL = " UPDATE T_CUSTOMER SET CUSTOMER_NM = '" & txtCustomerName.Text.Trim & "'"
        SQL = SQL & ",C_TELNO= '" & txtWorkTelNo1.Text.Trim + txtWorkTelNo2.Text.Trim + txtWorkTelNo3.Text.Trim & "'"


        If cboHP.SelectedIndex < 0 Then
            SQL = SQL & ",H_TELNO= '" & "" & "'"
        Else
            SQL = SQL & ",H_TELNO= '" & cboHP.SelectedItem.ToString.Trim.Replace("XXXX", "") + txtHP1.Text.Trim + txtHP2.Text.Trim & "'"
        End If

        SQL = SQL & ",FAX_NO='" & txtFaxNo1.Text.Trim + txtFaxNo2.Text.Trim + txtFaxNo3.Text.Trim & "'"

        If gbIsCustomerTablePatched Then
            SQL = SQL & ",COMPANY= '" & txtCompany.Text.Trim & "'"
            SQL = SQL & ",DEPARTMENT= '" & txtDepartment.Text.Trim & "'"
            SQL = SQL & ",JOB_TITLE= '" & txtJobTitle.Text.Trim & "'"
            SQL = SQL & ",EMAIL= '" & txtEmail.Text.Trim & "'"
        End If

        If cboCustomerType.SelectedIndex < 0 Then
            SQL = SQL & ",CUSTOMER_TYPE= '" & "" & "'" ' CUSTOMER TYPE
        Else
            SQL = SQL & ",CUSTOMER_TYPE= '" & cboCustomerType.SelectedValue.ToString.Replace("XXXX", "") & "'" ' CUSTOMER TYPE
        End If

        SQL = SQL & ",WOO_NO= '" & txtWP1.Text.Trim & txtWP2.Text.Trim & "'"
        SQL = SQL & ",CUSTOMER_ADDR= '" & txtAddress.Text.Trim & "'"
        SQL = SQL & ",CUSTOMER_ETC= '" & txtEtcInfo.Text.Trim & "'"

        SQL = SQL & ",UPDATE_DATE='" & Format(Now, "yyyyMMddHHmmss") & "'"


        SQL = SQL & " WHERE COM_CD = '" & gsCOM_CD & "'"
        SQL = SQL & " AND CUSTOMER_ID = " & txtCustomerID.Text.Trim

        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            ' 삭제된 데이터를 refresh 한다
            btnTelNoAdd.Enabled = False
            Call gsSelect()
            Call gsInit()
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        '삭제
        If MessageBox.Show("선택한 고객정보를 삭제하시겠습니까?", "고객정보삭제", _
                           MessageBoxButtons.OKCancel, _
                            Nothing, _
                            MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Call gsDelete()
        End If
    End Sub

    Private Sub btnIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIni.Click
        '변수초기화

        Call gsInit()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        'gfTelNoTransReturn()

        Try
            If e.RowIndex < 0 And e.RowIndex = DataGridView1.Rows.Count Then Exit Try
            Dim i As Integer = e.RowIndex


            With DataGridView1.Rows(i)
                mCustomer = .Cells(0).Value.ToString

                txtCustomerID.Text = .Cells(0).Value.ToString
                txtCustomerName.Text = .Cells(1).Value.ToString

                If .Cells(2).Value.ToString.Trim.Replace("-", "").Length < 9 Then
                    txtWorkTelNo1.Text = ""
                    txtWorkTelNo2.Text = ""
                    txtWorkTelNo3.Text = ""
                Else
                    Dim telno() As String = gfTelNoTransReturn(.Cells(2).Value.ToString.Trim.Replace("-", "")).Split("-")

                    txtWorkTelNo1.Text = telno(0)
                    txtWorkTelNo2.Text = telno(1)
                    txtWorkTelNo3.Text = telno(2)
                End If


                If .Cells(3).Value.ToString.Replace("-", "").Length < 9 Then
                    cboHP.SelectedItem = ""
                    txtHP1.Text = ""
                    txtHP2.Text = ""
                Else
                    Dim txthp() As String = gfTelNoTransReturn(.Cells(3).Value.ToString.Trim.Replace("-", "")).Split("-")
                    cboHP.SelectedItem = txthp(0).Trim
                    txtHP1.Text = txthp(1).Trim
                    txtHP2.Text = txthp(2).Trim
                End If


                If .Cells(4).Value.ToString.Replace("-", "").Length < 9 Then
                    txtFaxNo1.Text = ""
                    txtFaxNo2.Text = ""
                    txtFaxNo3.Text = ""

                Else
                    Dim faxno() As String = gfTelNoTransReturn(.Cells(4).Value.ToString.Trim.Replace("-", "")).Split("-")

                    txtFaxNo1.Text = faxno(0)
                    txtFaxNo2.Text = faxno(1)
                    txtFaxNo3.Text = faxno(2)
                End If

                Dim _customertype As String = ""
                Dim _woo_no As String = ""
                Dim _address As String = ""
                Dim _etcInfo As String = ""

                If gbIsCustomerTablePatched Then
                    txtCompany.Text = .Cells(5).Value.ToString
                    txtDepartment.Text = .Cells(6).Value.ToString
                    txtJobTitle.Text = .Cells(7).Value.ToString
                    txtEmail.Text = .Cells(8).Value.ToString
                    _customertype = .Cells(9).Value.ToString
                    _woo_no = .Cells(10).Value.ToString
                    _address = .Cells(11).Value.ToString
                    _etcInfo = .Cells(12).Value.ToString

                Else
                    _customertype = .Cells(5).Value.ToString
                    _woo_no = .Cells(6).Value.ToString
                    _address = .Cells(7).Value.ToString
                    _etcInfo = .Cells(8).Value.ToString
                End If

                If _customertype.Contains(".") Then
                    Dim str() As String = _customertype.Split(".")
                    cboCustomerType.SelectedValue = str(0)
                Else
                    cboCustomerType.SelectedValue = "XXXX"
                End If

                If _woo_no.Length = 6 Then
                    txtWP1.Text = _woo_no.Substring(0, 3)
                    txtWP2.Text = _woo_no.Substring(3)
                Else
                    txtWP1.Text = ""
                    txtWP2.Text = ""
                End If
                txtAddress.Text = _address
                txtEtcInfo.Text = _etcInfo

                btnTelNoAdd.Enabled = True

                Call gsSubSelect()

            End With


        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnTelNoAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTelNoAdd.Click

        If txtCustomerID.Text.Trim = "" Then
            MsgBox("등록할 데이터를 먼저 고객리스트에서 클릭하세요.", MsgBoxStyle.OkOnly, "알림")
            Exit Sub
        End If
        'FRM_TELNO_ADD.Tag = txtCustomerID.Text.Trim
        'FRM_TELNO_ADD.ShowDialog()
        Try
            FRM_CUSTOMER_TELNO.ParentFrm = Me
            FRM_CUSTOMER_TELNO.setInfo(txtCustomerID.Text, txtCustomerName.Text)
            FRM_CUSTOMER_TELNO.ShowDialog()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnZipCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZipCode.Click
        Try
            FRM_ZIPCODE.ParentFrm = Me
            AddHandler FRM_ZIPCODE.btnConfirm.Click, AddressOf Setting_Address
            FRM_ZIPCODE.ShowDialog()
            FRM_ZIPCODE.Focus()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub Setting_Address(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim str As String = Me.Tag.ToString
            Dim tmp As String() = str.Split("^")
            If tmp.Length < 3 Then Exit Try
            txtWP1.Text = tmp(0).Substring(0, 3)
            txtWP2.Text = tmp(0).Substring(4, 3)
            txtAddress.Text = tmp(1).ToString.Trim & IIf(tmp(2).ToString.Trim = "", "", " " & tmp(2).ToString.Trim)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cboHP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHP.SelectedIndexChanged

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            With SaveFileDialog1
                .CheckPathExists = True
                .Filter = "Excel통합문서(*.xlsx)|*.xlsx|Excel97-2003문서(*.xls)|*.xls"
                .FileName = "고객정보" & "_" & Format(Now, "yyyyMMdd")
                .Title = "고객정보 엑셀로 내보내기"
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
            Call Excel_Export2(SaveFileDialog1.FileName, SaveFileDialog1.Title, DataGridView1, "0,1,")
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try

    End Sub
End Class