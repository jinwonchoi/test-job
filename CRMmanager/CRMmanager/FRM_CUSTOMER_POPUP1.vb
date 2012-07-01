Imports System.Net.Sockets
Imports System.Text

Public Class FRM_CUSTOMER_POPUP1

    Private WithEvents ss As New CRMmanager
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim mIsTransfered As Boolean = False

    Dim mWoopyonNumber As String = ""

    Dim dgTelNocol_DeleteRecord As DataGridViewButtonColumn = New DataGridViewButtonColumn()
    Dim mIsEnteringNoQueried As Boolean = False
    'Dim mIsCustomerTablePatched As Boolean = False

    Public Enum PANEL_FOCUS
        NONE = -1
        CUSTOMER_INFO = 0
        CONSULT_INFO = 1
        CONSULT_HISTORY = 2
    End Enum

    Private Sub Call_history_Init()
        '***************** 화면 맨 아래 상담이력 수정 화면 데이터 클리어 시킴****************************************
        On Error Resume Next
        txtDate4.Text = ""   ' 통화일자
        txtTongTime4.Text = "" ' 통화시간
        cboCallType4.SelectedValue = "XXXX" ' 콜타입
        txtSubCustomerName4.Text = "" '고객명
        chCallBack4.Checked = False  ' 콜백여부
        txtTongNo4.Text = ""
        cboConsultType4.SelectedValue = "XXXX" ' 콜타입
        cboConsultResult4.SelectedValue = "XXXX" ' 콜타입
        txtTongUser4.Text = "" '통화자
        cboHandleType4.SelectedValue = "XXXX" ' 콜타입
        txtTongEtcInfo4.Text = "" '기타정보
        txtCCId4.Text = ""  '고객아이디
        'DataGridView2.Columns.Clear()
    End Sub

    Private Sub Customer_info_init()
        On Error Resume Next
        '********************************* 고객기본정보 클리어 시킴 ************************************************
        txtCustomerID.Text = ""
        txtCustomerID.ReadOnly = True
        txtCustomerName.Text = ""
        txtTelInfo1.Text = ""
        txtHP1.Text = ""
        txtFaxNo1.Text = ""

        txtCompany.Text = ""
        txtDepartment.Text = ""
        txtJobTitle.Text = ""
        txtEmail.Text = ""

        cboCustomerType.SelectedValue = "XXXX"
        txtAddress1.Text = ""
        txtEtcInfo1.Text = ""


        '조회전 초기상태에서 상태설정
        chModification1.Text = "고객정보등록"
        chModification1.Checked = False



    End Sub

    Private Sub Call_Consult_Init()
        On Error Resume Next
        '************************* 상담이력 등록 화면 클리어 ******************************************************
        setComboSelect(cboConsultResult2, 3) 'cboConsultResult2.SelectedIndex = 3 '미처리
        
        setComboSelect(cboConsultType2, 1) 'cboConsultType2.SelectedIndex = 1 '일반상담
        setComboSelect(cboCustomerType2, 3) 'cboCustomerType2.SelectedIndex = 3 '일반고객
        setComboSelect(cboHandleType2, 1) 'cboHandleType2.SelectedIndex = 1 '보통0
        setComboSelect(cboCallType2, 1) 'cboCallType2.SelectedIndex = 1 '인바운드
            txtDate2.Text = ""
            txtTongTime2.Text = ""
            txtTongUser2.Text = ""
            chCallBack2.Checked = False
            txtTongEtcInfo2.Text = ""

            mIsTransfered = False
            '외부업무등록
            dpt333.Value = Format(Now, "yyyy-MM-dd")

            CB_Set2(drpHour3, "datetime", 0, 23, 1, "")
            CB_Set2(drpMin3, "datetime", 0, 55, 5, "")
            drpHour3.Text = "00"
            drpMin3.Text = "00"

            cboCoWorker3.SelectedValue = "XXXX"
            cboWorkReason3.SelectedValue = "XXXX"
            txtWorkArea3.Text = ""
            txtWorkContents3.Text = ""
            '이관담당자
            cboDamdangja.SelectedValue = "XXXX"

    End Sub

    Public Sub HideCustomerNewInfo()
        pnlCustomerMiddle.Hide()
        pnlCustomerBottom.Top = pnlCustomerMiddle.Top
        pnlEmail.Hide()
    End Sub

    Public Sub gsInit()
        Try
            Call Customer_info_init()
            Call Call_history_Init()
            Call Call_Consult_Init()
            Call switchFocus(PANEL_FOCUS.NONE)
        Catch ex As Exception
            Call WriteLog(Me.Name.ToString & " : " & ex.ToString)
        End Try

    End Sub

    Declare Function FlashWindowEx Lib "user32" (ByVal pfwi As FLASHWINFO) As Boolean


    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> _
       Class FLASHWINFO
        Public Size As Int32
        Public Hwnd As IntPtr
        Public Flags As FlashWindowFlags
        Public Count As Int32
        Public TimeOut As Int32

        Sub New(ByVal hwnd As IntPtr, ByVal flags As FlashWindowFlags, ByVal count As Int32)
            Me.New(hwnd, flags, Count, 0)
        End Sub

        Sub New(ByVal hwnd As IntPtr, ByVal flags As FlashWindowFlags, ByVal count As Int32, ByVal timeout As Int32)
            With Me
                .Size = Runtime.InteropServices.Marshal.SizeOf(GetType(FLASHWINFO))
                Debug.WriteLine(.Size)
                .Hwnd = hwnd
                .Flags = flags
                .Count = Count
                .TimeOut = timeout
            End With
        End Sub
    End Class

    Enum FlashWindowFlags
        [Stop] = 0
        Caption = 1
        Tray = 2
        All = Caption Or Tray
        Timer = 4
        TimertillforeGround = &HC
    End Enum


    Public Sub switchFocus(ByVal focus As PANEL_FOCUS)
        Select Case focus
            Case PANEL_FOCUS.CUSTOMER_INFO
                'gbCustomerInfo.BackColor = Color.FromArgb(224, 224, 224) 'System.Drawing.SystemColors.GradientActiveCaption
                blinkFocus(gbCustomerInfo)
                gbConsultInfo.BackColor = System.Drawing.SystemColors.Control
                gbCustomerHistory.BackColor = System.Drawing.SystemColors.Control
            Case PANEL_FOCUS.CONSULT_INFO
                gbCustomerInfo.BackColor = System.Drawing.SystemColors.Control
                'gbConsultInfo.BackColor = Color.FromArgb(224, 224, 224) 'System.Drawing.SystemColors.GradientActiveCaption
                blinkFocus(gbConsultInfo)
                gbCustomerHistory.BackColor = System.Drawing.SystemColors.Control
            Case PANEL_FOCUS.CONSULT_HISTORY
                gbCustomerInfo.BackColor = System.Drawing.SystemColors.Control
                gbConsultInfo.BackColor = System.Drawing.SystemColors.Control
                'gbCustomerHistory.BackColor = Color.FromArgb(224, 224, 224) 'System.Drawing.SystemColors.GradientActiveCaption
                blinkFocus(gbCustomerHistory)
            Case PANEL_FOCUS.NONE
                gbCustomerInfo.BackColor = System.Drawing.SystemColors.Control
                gbConsultInfo.BackColor = System.Drawing.SystemColors.Control
                gbCustomerHistory.BackColor = System.Drawing.SystemColors.Control
        End Select
    End Sub


    Private Sub blinkFocus(ByVal sender As System.Object)
        Dim gBox As GroupBox = sender
        'gBox.BackColor = Color.FromArgb(224, 224, 224)
        'System.Threading.Thread.Sleep(500)
        'gBox.BackColor = System.Drawing.SystemColors.Control
        'System.Threading.Thread.Sleep(500)
        'gBox.BackColor = Color.FromArgb(224, 224, 224)
        'System.Threading.Thread.Sleep(500)
        'gBox.BackColor = System.Drawing.SystemColors.Control
        'System.Threading.Thread.Sleep(500)
        gBox.BackColor = Color.MistyRose 'Color.FromArgb(224, 224, 224)
        Dim x As New FLASHWINFO(Me.Handle, FlashWindowFlags.All, 2)
        FlashWindowEx(x)
    End Sub


    '팝업호출 테스트용
    Private Sub ss_Var_Trans(ByVal tel_no As String, _
                             ByVal tong_date As String, _
                             ByVal tong_time As String, _
                             ByVal CALL_TYPE As String) Handles ss.Var_Trans

        If chModification1.Checked = True Then
            Call Control_disable(True)
        Else
            Call Control_disable(False)
        End If

        txtEnteringNo.Text = tel_no

        If txtEnteringNo.Text.Trim = "" Then Exit Sub
        Call gsInit()                   ' 모든 항목을 초기화 시킨다.

        Call WriteLog("CUSTOMER_POP_UP Var_Trans1:tel_no[" & tel_no & "]" & "tong_date[" & tong_date & "]tong_time[" & tong_time & "]")

        'txtEnteringNo.Text = tel_no
        txtDate2.Text = tong_date
        txtTongTime2.Text = tong_time
        txtTongUser2.Text = gsUSER_ID & "." & gsUSER_NM


        'Call WriteLog("ss_Var_Trans: " & "tel_no=" & tel_no & " tong_date=" & tong_date & " tong_time=" & tong_time & " CALL_TYPE=" & CALL_TYPE)

        Call gsSelect("")

        cboConsultType2.Focus()

    End Sub

    '이관용 팝업호출 테스트용
    Public Sub Var_Trans2(ByVal tel_no As String, _
                              ByVal tong_date As String, _
                              ByVal tong_time As String)
        Call ss_Var_Trans2(tel_no, tong_date, tong_time)
    End Sub


    Private Sub ss_Var_Trans2(ByVal tel_no As String, _
                              ByVal tong_date As String, _
                              ByVal tong_time As String) Handles ss.Var_Trans2

        Call WriteLog("CUSTOMER_POP_UP Var_Trans2 1")
        If chModification1.Checked = True Then
            Call WriteLog("CUSTOMER_POP_UP Var_Trans2 2")
            Call Control_disable(True)
        Else
            Call WriteLog("CUSTOMER_POP_UP Var_Trans2 3")
            Call Control_disable(False)
        End If

        Call WriteLog("CUSTOMER_POP_UP Var_Trans2 4")
        txtEnteringNo.Text = tel_no

        Call WriteLog("CUSTOMER_POP_UP Var_Trans2 5")
        If txtEnteringNo.Text.Trim = "" Then Exit Sub
        Call WriteLog("CUSTOMER_POP_UP Var_Trans2 6")
        Call gsInit()                   ' 모든 항목을 초기화 시킨다.
        Call WriteLog("CUSTOMER_POP_UP Var_Trans2 7")

        Call WriteLog("CUSTOMER_POP_UP Var_Trans2:tel_no[" & tel_no & "]" & "tong_date[" & tong_date & "]tong_time[" & tong_time & "]")
        'txtEnteringNo.Text = tel_no
        txtDate2.Text = tong_date
        txtTongTime2.Text = tong_time
        txtTongUser2.Text = gsUSER_ID & "." & gsUSER_NM

        Call gsSelect("")

        Call findCellInDataGridView2(tel_no, tong_date, tong_time, False)
        'Call gsStatistics()
        txtTongEtcInfo4.Focus()

    End Sub

    Public Sub setIsTransfer(ByVal isTransfer As Boolean)
        mIsTransfered = isTransfer
    End Sub

    '이관처리호출 테스트용
    '실제 함수는 FRM_MAIN.OpenCustomerPopupTransfer
    Private Sub ss_Var_Trans3(ByVal tel_no As String, _
                                ByVal tong_date As String, _
                                ByVal tong_time As String, _
                                ByVal CALL_TYPE As String) Handles ss.Var_Trans3

        If chModification1.Checked = True Then
            Call Control_disable(True)
        Else
            Call Control_disable(False)
        End If

        txtEnteringNo.Text = tel_no

        If txtEnteringNo.Text.Trim = "" Then Exit Sub
        Call gsInit()                   ' 모든 항목을 초기화 시킨다.

        Call WriteLog("CUSTOMER_POP_UP Var_Trans3:tel_no[" & tel_no & "]" & "tong_date[" & tong_date & "]tong_time[" & tong_time & "]")

        '이관된 건은 현재시간을 새로운 처리시간으로 하여 상담건을 생성한다.
        Dim tm As String = Format(Now, "yyyyMMddhhmmss")
        txtDate2.Text = tm.Substring(0, 4) + "-" + tm.Substring(4, 2) + "-" + tm.Substring(6, 2)
        txtTongTime2.Text = tm.Substring(8, 2) + ":" + tm.Substring(10, 2) + ":" + tm.Substring(12, 2)
        txtTongUser2.Text = gsUSER_ID & "." & gsUSER_NM

        Call gsSelect("")

        mIsTransfered = True

        Call findCellInDataGridView2(tel_no, tong_date, tong_time, True)

        txtTongEtcInfo2.Focus()
    End Sub

    Public Sub gsSelect(ByVal flag As String)

        Try
            Dim SQL As String = ""
            Dim custom_id = "0"
            Dim selectPhoneNumber As String = ""

            selectPhoneNumber = txtEnteringNo.Text

            If selectPhoneNumber.Trim = "" Then
                MsgBox("전화번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            If selectPhoneNumber.Trim.Length >= 3 Then

                If selectPhoneNumber.Trim <> "" Then
                    SQL = " SELECT ifnull(max(CUSTOMER_ID),'0') FROM t_customer_telno  WHERE COM_CD ='" & gsCOM_CD & "'"
                    SQL = SQL & " AND TELNO = '" & selectPhoneNumber.Trim.Replace("-", "") & "'"

                    Dim dt1 As DataTable = GetData_table1(gsConString, SQL)

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

                '기등록된 경우
                If custom_id <> "0" Then
                    SQL = "SELECT COM_CD,CUSTOMER_ID,CUSTOMER_NM,C_TELNO,"
                    SQL = SQL & "H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC "
                    If gbIsCustomerTablePatched Then
                        SQL = SQL & ",COMPANY, DEPARTMENT, JOB_TITLE, EMAIL"
                    End If
                    SQL = SQL & " FROM T_CUSTOMER where customer_id = " & custom_id
                    SQL = SQL & " LIMIT 1"
                    '결과없는 경우 2차 검색
                Else
                    SQL = "SELECT COM_CD,CUSTOMER_ID,CUSTOMER_NM,C_TELNO"
                    SQL = SQL & ",H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO"
                    SQL = SQL & ",CUSTOMER_ADDR,CUSTOMER_ETC"
                    If gbIsCustomerTablePatched Then
                        SQL = SQL & ",COMPANY, DEPARTMENT, JOB_TITLE, EMAIL"
                    End If
                    SQL = SQL & " FROM T_CUSTOMER "
                    If IsHPNumber(selectPhoneNumber.Trim) Then
                        SQL = SQL & " WHERE H_TELNO LIKE '" & selectPhoneNumber.Trim.Replace("-", "") & "%'"
                    Else
                        SQL = SQL & " WHERE C_TELNO LIKE '" & selectPhoneNumber.Trim.Replace("-", "") & "%'"
                    End If
                        SQL = SQL & " LIMIT 1"
                End If
            Else
                SQL = ""
            End If

            If SQL <> "" Then

                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                '************************************ 체크하자
                Dim dt1 As DataTable = GetData_table1(gsConString, SQL)

                Call WriteLog("CUSTOMER_POP_UP dt1.Rows.Count[" & dt1.Rows.Count & "]")

                If dt1.Rows.Count > 0 Then
                    Dim I As Integer
                    For I = 0 To dt1.Rows.Count - 1
                        '                       0        1          2            3      4     5        6            7         8            9 
                        ' SQL = "SELECT TOP 1 COM_CD,CUSTOMER_ID,CUSTOMER_NM,C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC FROM T_CUSTOMER "

                        txtCustomerID.Text = dt1.Rows(I).Item(1).ToString()
                        txtCustomerName.Text = dt1.Rows(I).Item(2).ToString()

                        txtTelInfo1.Text = dt1.Rows(I).Item(3).ToString.Trim
                        txtHP1.Text = dt1.Rows(I).Item(4).ToString.Trim

                        txtFaxNo1.Text = dt1.Rows(I).Item(5).ToString.Trim.Replace("-", "")
                        
                        Dim customertype As String = dt1.Rows(I).Item(6).ToString.Trim

                        If customertype <> "" Then
                            cboCustomerType.SelectedValue = customertype
                        Else
                            cboCustomerType.SelectedValue = "XXXX"
                        End If

                        Dim woo_no As String = dt1.Rows(I).Item(7).ToString
                        If woo_no.Length = 6 Then
                            mWoopyonNumber = woo_no
                        Else
                            mWoopyonNumber = ""
                        End If
                        txtAddress1.Text = dt1.Rows(I).Item(8).ToString
                        txtEtcInfo1.Text = dt1.Rows(I).Item(9).ToString

                        If gbIsCustomerTablePatched Then
                            txtCompany.Text = dt1.Rows(I).Item(10).ToString
                            txtDepartment.Text = dt1.Rows(I).Item(11).ToString
                            txtJobTitle.Text = dt1.Rows(I).Item(12).ToString
                            txtEmail.Text = dt1.Rows(I).Item(13).ToString
                        End If

                        If I = 0 Then Exit For

                    Next

                    dt1 = Nothing

                    '조회상태에서 상태설정
                    chModification1.Text = "고객정보수정"
                    chModification1.Checked = False
                    Call gsSelectTelNo(txtCustomerID.Text.Trim)
                    Call gsSubSelect(txtCustomerID.Text.Trim)
                Else
                    Call WriteLog("CUSTOMER_POP_UP gsSelect MAIN-002 No Data SQL[" & SQL & "]")

                    If IsHPNumber(selectPhoneNumber.Trim) Then
                        txtHP1.Text = selectPhoneNumber.Trim
                    Else
                        txtTelInfo1.Text = selectPhoneNumber.Trim
                    End If
                End If
            Else
                MsgBox("전화번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
            End If

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CUSTOMER_POPUP1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call SettoolBar(False, False, False, False, False, True, True)
        Me.Focus()
    End Sub

    Private Sub FRM_CUSTOMER_POPUP1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '이벤트 관련 메모리를 해제하여 이벤트가 두번 실행 되지 않게 한다
        ss = Nothing
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Call selectEnteringNo()
    End Sub

    Private Sub selectEnteringNo()
        '조회
        If txtEnteringNo.Text.Trim = "" Then
            MsgBox("전화번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
            Exit Sub
        End If

        Call gsInit()
        Call gsSubSelect("") '하단 클리어
        Call gsSelect("POPUP")
        mIsEnteringNoQueried = True
        btnFindId.Enabled = True
        If (txtCustomerID.Text.Trim = "") Then
            switchFocus(PANEL_FOCUS.CUSTOMER_INFO)
        Else
            switchFocus(PANEL_FOCUS.CONSULT_INFO)
        End If
    End Sub

    Public Sub gsSubSelect(ByVal customerid As String)

        '***************************************컬럼 두개 추가 됐어요 반영 하세요 ??????
        Try
            Dim SQL As String = "Select CUSTOMER_ID,CUSTOMER_NM "
            SQL = SQL & " ,CONCAT(SUBSTRING(TOND_DD,1,4),'-', SUBSTRING(TOND_DD,5,2) ,'-',SUBSTRING(TOND_DD,7,2)) Tong_dd"
            SQL = SQL & " ,CONCAT(SUBSTRING(TONG_TIME,1,2), ':', SUBSTRING(TONG_TIME,3,2), ':' , SUBSTRING(TONG_TIME,5,2)) tong_tm"
            SQL = SQL & " ,TONG_TELNO"
            SQL = SQL & " ,CONCAT(CONSULT_TYPE , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '003' AND S_MENU_CD = CONSULT_TYPE )) consult_type "
            SQL = SQL & " ,CONCAT(CONSULT_RESULT , '.' , (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '004' AND S_MENU_CD = CONSULT_RESULT )) call_result "
            SQL = SQL & " ,TONG_USER,TONG_CONTENTS "
            SQL = SQL & " ,CONCAT(CALL_TYPE ,'.', (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '005' AND S_MENU_CD = CALL_TYPE )) call_type "



            SQL = SQL & " ,CALL_BACK_YN CALL_BACK_YN"
            SQL = SQL & " ,CONCAT(HANDLE_TYPE ,'.', (SELECT LTRIM(RTRIM(S_MENU_NM)) FROM T_S_CODE WHERE COM_CD = '" & gsCOM_CD & "' AND L_MENU_CD = '012' AND S_MENU_CD = HANDLE_TYPE )) HANDLE_TYPE "


            SQL = SQL & " FROM T_CUSTOMER_HISTORY "
            SQL = SQL & " WHERE COM_CD ='" & gsCOM_CD & "'"

            If customerid.Trim = "" Then
                SQL = SQL & " AND CUSTOMER_ID = 0"
            Else
                SQL = SQL & " AND CUSTOMER_ID = " & customerid
            End If


            SQL = SQL & " ORDER BY TOND_DD DESC, TONG_TIME DESC "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            DataGridView2.DataSource = Nothing


            DataGridView2.Columns.Clear()
            DataGridView2.DataSource = dt1

            Call WriteLog("FRM_CUSTOMER : DataGridView2.Columns=" & DataGridView2.Columns.Count)

            DataGridView2.Columns.Item(0).HeaderText = "고객아이디"
            DataGridView2.Columns.Item(1).HeaderText = "고객명"
            DataGridView2.Columns.Item(2).HeaderText = "통화일자"
            DataGridView2.Columns.Item(3).HeaderText = "통화시간"
            DataGridView2.Columns.Item(4).HeaderText = "통화전화번호"
            DataGridView2.Columns.Item(5).HeaderText = "상담유형"
            DataGridView2.Columns.Item(6).HeaderText = "상담결과"
            DataGridView2.Columns.Item(7).HeaderText = "통화자"
            DataGridView2.Columns.Item(8).HeaderText = "통화내용"
            DataGridView2.Columns.Item(9).HeaderText = "콜타입"
            DataGridView2.Columns.Item(10).HeaderText = "콜백"
            DataGridView2.Columns.Item(11).HeaderText = "처리유형"
            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsSelectTelNo(ByVal customerid As String)

        Try
            Dim SQL As String = "Select TELNO "
            SQL = SQL & " FROM T_CUSTOMER_TELNO "
            SQL = SQL & " WHERE COM_CD ='" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & customerid
            SQL = SQL & " ORDER BY TELNO "

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            '************************************ 체크하자
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL)
            dgTelNo.DataSource = Nothing

            With dgTelNo
                .Columns.Clear()
                .DataSource = dt1
                .Columns.Item(0).FillWeight = 20
                .Columns.Item(0).Width = 120
                .Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Call WriteLog("FRM_CUSTOMER_POPUP : dgTelNo.Columns=" & .Columns.Count)
                'dgTelNo.EditMode = DataGridViewEditMode.EditProgrammatically

                'dgTelNocol_DeleteRecord.UseColumnTextForButtonValue = True
                'dgTelNocol_DeleteRecord.Text = "삭제"
                'dgTelNocol_DeleteRecord.Resizable = DataGridViewTriState.False
                'dgTelNocol_DeleteRecord.FlatStyle = FlatStyle.Standard
                'dgTelNocol_DeleteRecord.HeaderText = ""
                'dgTelNocol_DeleteRecord.Width = 50
                'dgTelNo.Columns.Insert(1, dgTelNocol_DeleteRecord)
            End With

            dt1 = Nothing
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER_POPUP : " & ex.ToString)
        End Try
    End Sub


    Public Sub gsFormExit()
        Try
            Me.Close()
        Catch ex As Exception
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try
    End Sub

    Private Sub FRM_CUSTOMER_POPUP1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If chModification1.Checked = True Then
                Call Control_disable(True)
            Else
                Call Control_disable(False)
            End If

            If DBConReadYn = "N" Then
                Call XmlReadMode()
            End If

            'txtTongUser4.Text = gsUSER_ID & "." & gsUSER_NM

            '******************************************* 고객 유형 입력 ***********************************************************
            Dim SQL_TEMP As String = Find_Query("006")
            Dim dt1 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboCustomerType.DataSource = dt1
            cboCustomerType.DisplayMember = dt1.Columns(0).ToString
            cboCustomerType.ValueMember = dt1.Columns(1).ToString

            setComboSelect(cboCustomerType, 0) 'cboCustomerType.SelectedIndex = 0 '3 '일반고객
            dt1 = Nothing


            '************************************** 상담결과 입력 *********************************************
            SQL_TEMP = Find_Query("004")
            Dim dt2 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboConsultResult2.DataSource = dt2
            cboConsultResult2.DisplayMember = dt2.Columns(0).ToString
            cboConsultResult2.ValueMember = dt2.Columns(1).ToString

            setComboSelect(cboConsultResult2, 3) 'cboConsultResult2.SelectedIndex = 3 '미처리

            dt2 = Nothing

            '************************************** 상담유형 입력 *********************************************
            SQL_TEMP = Find_Query("003")
            Dim dt3 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboConsultType2.DataSource = dt3
            cboConsultType2.DisplayMember = dt3.Columns(0).ToString
            cboConsultType2.ValueMember = dt3.Columns(1).ToString

            setComboSelect(cboConsultType2, 1) 'cboConsultType2.SelectedIndex = 1 '일반상담
            dt3 = Nothing

            '************************************** 콜타입입력 *********************************************
            SQL_TEMP = Find_Query("005")
            Dim dt4 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboCallType2.DataSource = dt4
            cboCallType2.DisplayMember = dt4.Columns(0).ToString
            cboCallType2.ValueMember = dt4.Columns(1).ToString

            setComboSelect(cboCallType2, 1) 'cboCallType2.SelectedIndex = 1 '인바운드
            dt4 = Nothing

            cboCallType4.SelectedValue = Me.Tag


            '******************************************* 고객 유형 입력 ***********************************************************
            SQL_TEMP = Find_Query("006")
            Dim dt5 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboCustomerType2.DataSource = dt5
            cboCustomerType2.DisplayMember = dt5.Columns(0).ToString
            cboCustomerType2.ValueMember = dt5.Columns(1).ToString

            setComboSelect(cboCustomerType2, 3) 'cboCustomerType2.SelectedIndex = 3 '일반고객
            dt5 = Nothing


            '******************************************* 처리 유형 입력 ***********************************************************
            SQL_TEMP = Find_Query("012")
            Dim dt6 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboHandleType2.DataSource = dt6
            cboHandleType2.DisplayMember = dt6.Columns(0).ToString
            cboHandleType2.ValueMember = dt6.Columns(1).ToString

            setComboSelect(cboHandleType2, 1) 'cboHandleType2.SelectedIndex = 1 '보통
            dt6 = Nothing


            '************************************** 상담결과 입력 *********************************************
            SQL_TEMP = Find_Query("004")
            Dim dt7 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboConsultResult4.DataSource = dt7
            cboConsultResult4.DisplayMember = dt7.Columns(0).ToString
            cboConsultResult4.ValueMember = dt7.Columns(1).ToString

            cboConsultResult4.SelectedIndex = 0 '3 '미처리
            dt7 = Nothing

            '************************************** 상담유형 입력 *********************************************
            SQL_TEMP = Find_Query("003")
            Dim dt8 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboConsultType4.DataSource = dt8
            cboConsultType4.DisplayMember = dt8.Columns(0).ToString
            cboConsultType4.ValueMember = dt8.Columns(1).ToString

            cboConsultType4.SelectedIndex = 0 '1 '일반상담
            dt8 = Nothing

            '************************************** 콜타입입력 *********************************************
            SQL_TEMP = Find_Query("005")
            Dim dt9 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboCallType4.DataSource = dt9
            cboCallType4.DisplayMember = dt9.Columns(0).ToString
            cboCallType4.ValueMember = dt9.Columns(1).ToString

            cboCallType4.SelectedIndex = 0
            dt9 = Nothing

            cboCallType4.SelectedValue = 0


            '******************************************* 처리 유형 입력 ***********************************************************
            SQL_TEMP = Find_Query("012")
            Dim dt10 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboHandleType4.DataSource = dt10
            cboHandleType4.DisplayMember = dt10.Columns(0).ToString
            cboHandleType4.ValueMember = dt10.Columns(1).ToString

            cboHandleType4.SelectedIndex = 0
            dt10 = Nothing


            '******************************************* 처리 유형 입력 ***********************************************************
            SQL_TEMP = "select '' user_name  ,'XXXX' user_id  union all select concat(user_id , '.' , user_nm) user_name , user_id user_id from t_user where com_cd ='" & gsCOM_CD & "'"
            Dim dt11 As DataTable = GetData_table1(gsConString, SQL_TEMP)

            cboDamdangja.DataSource = dt11
            cboDamdangja.DisplayMember = dt11.Columns(0).ToString
            cboDamdangja.ValueMember = dt11.Columns(1).ToString

            cboDamdangja.SelectedIndex = 0

            cboCoWorker3.DataSource = dt11
            cboCoWorker3.DisplayMember = dt11.Columns(0).ToString
            cboCoWorker3.ValueMember = dt11.Columns(1).ToString

            cboCoWorker3.SelectedIndex = 0

            dt11 = Nothing


            dpt333.Value = Format(Now, "yyyy-MM-dd")

            CB_Set2(drpHour3, "datetime", 0, 23, 1, "")
            CB_Set2(drpMin3, "datetime", 0, 55, 5, "")
            drpHour3.Text = "00"
            drpMin3.Text = "00"


            '**************************************외근사유 입력 *********************************************
            Dim SQL_TEMP1 As String = Find_Query("007")
            Dim dt13 As DataTable = GetData_table1(gsConString, SQL_TEMP1)

            cboWorkReason3.DataSource = dt13
            cboWorkReason3.DisplayMember = dt13.Columns(0).ToString
            cboWorkReason3.ValueMember = dt13.Columns(1).ToString
            cboWorkReason3.SelectedIndex = 0

            dt13 = Nothing

            If Not gbIsCustomerTablePatched Then
                Call HideCustomerNewInfo()
            End If

            Call WriteLog(Me.Name.ToString & " Popup Load :gsInit ")
            'Call gsInit()

        Catch ex As Exception
            Call WriteLog(Me.Name.ToString & " Popup Load : " & ex.ToString)
        End Try

    End Sub

    Private Sub btnZipCode1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZipCode1.Click
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
            mWoopyonNumber = tmp(0).Substring(0, 3) & tmp(0).Substring(4, 3)
            txtAddress1.Text = tmp(1).ToString.Trim & IIf(tmp(2).ToString.Trim = "", "", " " & tmp(2).ToString.Trim)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Sub gsDisplayTransferDetail(ByVal tel_no As String, ByVal tong_date As String, ByVal tong_time As String, ByVal isTrans As Boolean)
        Call findCellInDataGridView2(tel_no, tong_date, tong_time, isTrans)
    End Sub


    Private Sub findCellInDataGridView2(ByVal tel_no As String, ByVal tong_date As String, ByVal tong_time As String, ByVal isTrans As Boolean)
        Dim intcount As Integer = 0
        For Each Row As DataGridViewRow In DataGridView2.Rows
            With DataGridView2.Rows(intcount)

                'txtDate4.Text = .Cells(2).Value.ToString   ' 통화일자
                'txtTongTime4.Text = .Cells(3).Value.ToString ' 통화시간
                Call WriteLog("findCellInDataGridView2_1" & .Cells(4).Value.ToString & ":" & .Cells(2).Value.ToString & ":" & .Cells(3).Value.ToString)
                Call WriteLog("findCellInDataGridView2_2" & tel_no & ":" & tong_date & ":" & tong_time)

                If .Cells(4).Value.ToString = tel_no.Trim.Replace("-", "") And .Cells(2).Value.ToString = tong_date.Trim And .Cells(3).Value.ToString = tong_time.Trim Then
                    'Do Something
                    .Selected = True
                    Exit For
                Else
                    intcount += 1
                End If
            End With
        Next Row
        Call WriteLog("intcount=" & intcount)

        If isTrans Then
            Call setTransDetailByGridCell(intcount)
        Else
            Call setSubDetailByGridCell(intcount)
        End If

    End Sub

    Private Sub setSubDetailByGridCell(ByVal idx As Integer)
        With DataGridView2.Rows(idx)
            txtDate4.Text = .Cells(2).Value.ToString   ' 통화일자
            txtTongTime4.Text = .Cells(3).Value.ToString ' 통화시간

            Dim call_type As String = .Cells(9).Value.ToString

            If call_type.Contains(".") Then
                Dim str() As String = call_type.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboCallType4.SelectedValue = str(0) ' 콜타입
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboCallType4.SelectedValue = "XXXX" ' 콜타입
            End If

            txtSubCustomerName4.Text = .Cells(1).Value.ToString '고객명

            If .Cells(10).Value.ToString = "Y" Then
                chCallBack4.Checked = True  ' 콜백여부
            Else
                chCallBack4.Checked = False  ' 콜백여부
            End If


            If .Cells(4).Value.ToString.Trim.Replace("-", "").Length < 9 Then
                txtTongNo4.Text = ""
            Else
                txtTongNo4.Text = gfTelNoTransReturn(.Cells(4).Value.ToString.Trim.Replace("-", ""))
            End If


            Dim Consult_Type As String = .Cells(5).Value.ToString

            If Consult_Type.Contains(".") Then
                Dim str() As String = Consult_Type.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboConsultType4.SelectedValue = str(0) ' 상담유형
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboConsultType4.SelectedValue = "XXXX" ' 상담유형
            End If

            Dim Consult_result As String = .Cells(6).Value.ToString

            If Consult_result.Contains(".") Then
                Dim str() As String = Consult_result.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboConsultResult4.SelectedValue = str(0) ' 상담결과
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboConsultResult4.SelectedValue = "XXXX" ' 상담결과
            End If

            txtTongUser4.Text = .Cells(7).Value.ToString '통화자


            Dim handle_type As String = .Cells(11).Value.ToString

            If handle_type.Contains(".") Then
                Dim str() As String = handle_type.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboHandleType4.SelectedValue = str(0) ' 처리유형
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboHandleType4.SelectedValue = "XXXX" ' 처리유형
            End If

            txtTongEtcInfo4.Text = .Cells(8).Value.ToString '기타정보
            txtCCId4.Text = .Cells(0).Value.ToString  '고객아이디

        End With

    End Sub

    Private Sub setTransDetailByGridCell(ByVal idx As Integer)
        With DataGridView2.Rows(idx)
            txtDate2.Text = .Cells(2).Value.ToString   ' 통화일자
            txtTongTime2.Text = .Cells(3).Value.ToString ' 통화시간

            Dim call_type As String = .Cells(9).Value.ToString

            If call_type.Contains(".") Then
                Dim str() As String = call_type.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboCallType2.SelectedValue = str(0) ' 콜타입
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboCallType2.SelectedValue = "XXXX" ' 콜타입
            End If

            'txtSubCustomerName2.Text = .Cells(1).Value.ToString '고객명

            If .Cells(10).Value.ToString = "Y" Then
                chCallBack2.Checked = True  ' 콜백여부
            Else
                chCallBack2.Checked = False  ' 콜백여부
            End If


            'If .Cells(4).Value.ToString.Trim.Replace("-", "").Length < 9 Then
            'txtTongNo2.Text = ""
            'Else
            'txtTongNo2.Text = gfTelNoTransReturn(.Cells(4).Value.ToString.Trim.Replace("-", ""))
            'End If


            Dim Consult_Type As String = .Cells(5).Value.ToString

            If Consult_Type.Contains(".") Then
                Dim str() As String = Consult_Type.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboConsultType2.SelectedValue = str(0) ' 상담유형
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboConsultType2.SelectedValue = "XXXX" ' 상담유형
            End If

            Dim Consult_result As String = .Cells(6).Value.ToString

            If Consult_result.Contains(".") Then
                Dim str() As String = Consult_result.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboConsultResult2.SelectedValue = str(0) ' 상담결과
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboConsultResult2.SelectedValue = "XXXX" ' 상담결과
            End If

            'txtTongUser2.Text = gsUSER_ID & "." & gsUSER_NM '통화자


            Dim handle_type As String = .Cells(11).Value.ToString

            If handle_type.Contains(".") Then
                Dim str() As String = handle_type.Split(".")
                'tag_string = tag_string & "$" & str(0)
                cboHandleType2.SelectedValue = str(0) ' 처리유형
            Else
                'tag_string = tag_string & "$" & "XXXX"
                cboHandleType2.SelectedValue = "XXXX" ' 처리유형
            End If

            txtTongEtcInfo2.Text = .Cells(8).Value.ToString '기타정보
            'txtCCId2.Text = .Cells(0).Value.ToString  '고객아이디

        End With

    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick

        Try

            If e.RowIndex < 0 Then Exit Try
            Dim i As Integer = e.RowIndex

            Call Call_history_Init()

            Call setSubDetailByGridCell(i)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub btnCallHistoryUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallHistoryUpdate.Click
        '저장
        Try
            Dim sql As String


            If txtCCId4.Text.Trim = "" Then
                MsgBox("수정할 데이터를 상담이력에서 선택하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            If cboCallType4.SelectedIndex < 0 Then
                sql = "UPDATE T_CUSTOMER_HISTORY SET CALL_TYPE = '" & "" & "'"
            Else
                sql = "UPDATE T_CUSTOMER_HISTORY SET CALL_TYPE = '" & cboCallType4.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"

            End If


            If cboConsultResult4.SelectedIndex < 0 Then
                sql = sql & " ,CONSULT_RESULT =''"
            Else
                sql = sql & " ,CONSULT_RESULT = '" & cboConsultResult4.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"   ' 상담결과
            End If

            If cboConsultType4.SelectedIndex < 0 Then
                sql = sql & " ,CONSULT_TYPE = '' "
            Else
                sql = sql & " ,CONSULT_TYPE ='" & cboConsultType4.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"    ' 상담유형
            End If


            sql = sql & " ,TONG_CONTENTS = '" & txtTongEtcInfo4.Text.Trim & "'"    ' 통화내용
            sql = sql & " ,TONG_USER = '" & txtTongUser4.Text.Trim & "'"    ' 통화자
            sql = sql & " ,CUSTOMER_NM = '" & txtSubCustomerName4.Text.Trim & "'"    ' 통화자
            sql = sql & " ,TONG_TELNO = '" & txtTongNo4.Text.Trim.Replace("-", "") & "'"    ' 통화자

            If chCallBack4.Checked = True Then
                sql = sql & " ,CALL_BACK_YN = 'Y'"    ' 콜백여부
            Else
                sql = sql & " ,CALL_BACK_YN = 'N'"    ' 콜백여부
            End If

            If cboHandleType4.SelectedIndex < 0 Then
                sql = sql & " ,HANDLE_TYPE = '0' "
            Else
                sql = sql & " ,HANDLE_TYPE ='" & cboHandleType4.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"    ' 처리유형
            End If

            sql = sql & ",UPDATE_DATE= '" & Format(Now, "yyyyMMddHHmmss") & "'"


            sql = sql & " WHERE COM_CD =  '" & gsCOM_CD & "'"

            If txtCCId4.Text.Trim = "" Then
                sql = sql & " AND CUSTOMER_ID =  0 "
            Else
                sql = sql & " AND CUSTOMER_ID =  " & txtCCId4.Text.Trim
            End If
            sql = sql & " AND TOND_DD =  '" & txtDate4.Text.Trim.Replace("-", "") & "'"
            sql = sql & " AND TONG_TIME =  '" & txtTongTime4.Text.Trim.Replace(":", "") & "'"

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, sql)

            dt = Nothing
            MsgBox("데이터가 수정되었습니다.", MsgBoxStyle.OkOnly, "알림")
            Call gsSubSelect(txtCCId4.Text.Trim)
            Call Call_history_Init()
            txtCCId4.Text = ""
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Call gsSubSelect(txtCCId4.Text.Trim)
            Call Call_history_Init()
            txtCCId4.Text = ""
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog("FRM_CUSTOMER : " & ex.ToString)
        End Try


    End Sub

    Private Sub btnContentsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContentsSave.Click

        Dim tm As String = ""

        If txtDate2.Text.Trim.Replace("-", "") = "" _
            And txtTongTime2.Text.Trim.Replace(":", "") = "" Then
            If cboCallType2.SelectedIndex = 2 Then '아웃바운드
                tm = Format(Now, "yyyyMMddHHmmss")
                txtDate2.Text = tm.Substring(0, 4) + "-" + tm.Substring(4, 2) + "-" + tm.Substring(6, 2)
                txtTongTime2.Text = tm.Substring(8, 2) + ":" + tm.Substring(10, 2) + ":" + tm.Substring(12, 2)
                txtTongUser2.Text = gsUSER_ID & "." & gsUSER_NM
            End If

        End If

        If CallHistorySave() Then
            FRM_NOTI_MSG.Show("저장되었습니다.")
            System.Threading.Thread.Sleep(1000)
            FRM_NOTI_MSG.Hide()

            Call gsFormExit()
        Else
            ''
        End If
    End Sub

    Private Function CallHistorySave(Optional ByVal flag As String = "") As Boolean
        Try
            CallHistorySave = False
            'Dim NeedUpdate As Boolean = False
            Dim IsManualOutBound As Boolean = False
            Dim SendUserId As String = ""

            If txtDate2.Text.Trim.Replace("-", "") = "" Then
                MsgBox("저장되지 않았습니다. 통화일자 및 시간이 설정되지 않았습니다.", MsgBoxStyle.OkOnly, "알림")
                Exit Function
            End If

            If txtTongTime2.Text.Trim.Replace(":", "") = "" Then
                MsgBox("저장되지 않았습니다. 통화일자 및 시간이 설정되지 않았습니다.", MsgBoxStyle.OkOnly, "알림")
                Exit Function
            End If

            Dim SQL As String = ""

            If txtCustomerID.Text.Trim = "" Then
                If flag <> "trans" Then
                    MsgBox("확인할 수 없는 고객입니다.고객정보를 신규 등록후 상담이력을 등록하세요.", MsgBoxStyle.OkOnly, "알림")
                End If

                Exit Function
            End If

            Try
                SQL = " SELECT count(*) FROM T_CUSTOMER_HISTORY  WHERE COM_CD ='" & gsCOM_CD & "'"
                SQL = SQL & " AND CUSTOMER_ID = '" & txtCustomerID.Text.Trim & "'"
                SQL = SQL & " AND TOND_DD = '" & txtDate2.Text.Trim.Replace("-", "") & "'"
                SQL = SQL & " AND TONG_TIME = '" & txtTongTime2.Text.Trim.Replace(":", "") & "'"  ' 통화시간
                SQL = SQL & " AND TONG_USER = '" & txtTongUser2.Text.Trim & "'"  ' 통화유저

                Dim dt1 As DataTable = GetData_table1(gsConString, SQL)

                Dim CNT As String = "0"
                Dim i As Integer

                If dt1.Rows.Count > 0 Then
                    For i = 0 To dt1.Rows.Count - 1
                        CNT = dt1.Rows(i).Item(0).ToString
                    Next
                End If

                dt1 = Nothing

                If CNT <> "0" Then
                    If mIsTransfered = False Then

                        If flag = "trans" Then '이관처리할 경우
                            ''
                        Else '이관건이 아니고 수정하려고 할때
                            MsgBox("이미 데이터가 저장 되어 있습니다.상담이력건을 선택한후 하단 통화이력 상세내역에서 수정하세요.", MsgBoxStyle.OkOnly, "알림")
                        End If
                        Call gsSubSelect(txtCustomerID.Text.Trim)
                        Exit Function
                    Else
                        '이관건을 insert로 처리
                        'NeedUpdate = True
                    End If
                End If


            Catch ex As Exception
                Call WriteLog(Me.Name.ToString & " Select1 : " & ex.ToString)

            End Try

            SQL = "INSERT INTO T_CUSTOMER_HISTORY(COM_CD,CUSTOMER_ID,TOND_DD,TONG_TIME,CALL_TYPE,CONSULT_RESULT, CONSULT_TYPE, TONG_CONTENTS,TONG_USER,CUSTOMER_NM,TONG_TELNO,HANDLE_TYPE,CALL_BACK_YN,UPDATE_DATE, PREV_TONG_DD, PREV_TONG_TIME, PREV_TONG_USER, TRANS_YN) "
            SQL = SQL & " values( '" & gsCOM_CD & "'"

            If txtCustomerID.Text.Trim = "" Then
                SQL = SQL & " ,'0'"
            Else
                SQL = SQL & " ," & txtCustomerID.Text.Trim
            End If
            If mIsTransfered Then '이관된 건은 이관후 통화시간으로 변경함
                Dim tm As String = Format(Now, "yyyyMMddHHmmss")
                SQL = SQL & " ,'" & tm.Substring(0, 8) & "'"   ' 변경된 통화일자
                SQL = SQL & " ,'" & tm.Substring(8, 6) & "'"  '  변경된 통화시간
            Else
                SQL = SQL & " ,'" & txtDate2.Text.Trim.Replace("-", "") & "'"   ' 통화일자
                SQL = SQL & " ,'" & txtTongTime2.Text.Trim.Replace(":", "") & "'"  ' 통화시간
            End If

            If cboCallType2.SelectedIndex < 0 Then
                SQL = SQL & " ,'" & "" & "'"    ' 콜타입
            Else
                SQL = SQL & " ,'" & cboCallType2.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"    ' 콜타입
            End If


            If flag = "trans" Then '이관하는 경우 "이관처리"로 등록
                SQL = SQL & " ,'06'"   ' 상담결과 = "이관처리"
            Else
                If cboConsultResult2.SelectedIndex < 0 Then
                    SQL = SQL & " ,'" & "" & "'"    ' 상담결과
                Else
                    SQL = SQL & " ,'" & cboConsultResult2.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"   ' 상담결과
                End If
            End If


            If cboConsultType2.SelectedIndex < 0 Then
                SQL = SQL & " ,'" & "" & "'"    ' 상담유형
            Else
                SQL = SQL & " ,'" & cboConsultType2.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"    ' 상담유형
            End If

            SQL = SQL & " ,'" & txtTongEtcInfo2.Text.Trim & "'"    ' 통화내용
            If mIsTransfered Then
                SQL = SQL & " ,'" & gsUSER_ID & "." & gsUSER_NM & "'"    ' 통화자(이관받은자)
            Else
                SQL = SQL & " ,'" & txtTongUser2.Text.Trim & "'"    ' 통화자
            End If

            If txtCustomerID.Text.Trim = "" Then
                SQL = SQL & " ,'미등록고객'"    ' 고객명
            Else
                SQL = SQL & " ,'" & txtCustomerName.Text.Trim & "'"    ' 고객명
            End If

            SQL = SQL & " ,'" & txtEnteringNo.Text.Trim.Replace("-", "") & "'"    ' 통화전화번호

            If cboHandleType2.SelectedIndex < 0 Then
                SQL = SQL & " ,'0'"    ' 처리유형
            Else
                SQL = SQL & " ,'" & cboHandleType2.SelectedValue.ToString.Trim.Replace("XXXX", "") & "'"    ' 처리유형
            End If

            If chCallBack2.Checked = True Then
                SQL = SQL & " ,'Y'"    ' 콜백여부
            Else
                SQL = SQL & " ,'N'"    ' 콜백여부
            End If
            SQL = SQL & ",'" & Format(Now, "yyyyMMddHHmmss") & "'"
            If mIsTransfered = True Then
                SQL = SQL & " ,'" & txtDate2.Text.Trim.Replace("-", "") & "'"   ' 이전통화일자
                SQL = SQL & " ,'" & txtTongTime2.Text.Trim.Replace(":", "") & "'"  ' 이전통화시간
                SQL = SQL & " ,'" & txtTongUser2.Text.Trim & "'"    ' 통화자
                SQL = SQL & " ,'Y'"    ' 이관처리여부
            Else
                SQL = SQL & " ,NULL"   ' 이전통화일자
                SQL = SQL & " ,NULL"  ' 이전통화시간
                SQL = SQL & " ,NULL"    ' 통화자
                SQL = SQL & " ,NULL"    ' 이관처리여부
            End If

            SQL = SQL & ")"


            Try
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

                Dim dt As DataTable = GetData_table1(gsConString, SQL)
                dt = Nothing

                If flag <> "trans" Then
                    Call gsSubSelect(txtCustomerID.Text.Trim)
                End If


                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                'btnContentsSave.Enabled = False
            Catch ex As Exception
                Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
            End Try
        Catch ex As Exception
            Call WriteLog(Me.Name.ToString & " CallHistorySave : " & ex.ToString)

        End Try
        CallHistorySave = True

    End Function

    Private Sub chModification1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chModification1.CheckedChanged

        If chModification1.Checked = True Then
            Call Control_disable(True)
        Else
            Call Control_disable(False)
        End If

    End Sub

    Public Sub Control_disable(ByVal flag As Boolean)
        On Error Resume Next
        ' 여기서 초기 컨트롤을 초기화 시킨다.
        'txtCustomerName.Enabled = flag
        'txtTelInfo1.Enabled = flag
        'cboCustomerType.Enabled = flag
        btnZipCode1.Enabled = flag

        'txtAddress1.Enabled = flag
        'txtEtcInfo1.Enabled = flag
        btnSave1.Enabled = flag
        btnDel1.Enabled = flag
        btnIni1.Enabled = flag

        btnFindId.Enabled = flag
        btnCustomerTelNo.Enabled = flag

        'txtCustomerID.BackColor = Color.White
        txtCustomerName.ReadOnly = Not flag
        txtTelInfo1.ReadOnly = Not flag
        txtHP1.ReadOnly = Not flag
        txtFaxNo1.ReadOnly = Not flag
        txtCompany.ReadOnly = Not flag
        txtDepartment.ReadOnly = Not flag
        txtJobTitle.ReadOnly = Not flag
        txtEmail.ReadOnly = Not flag

        txtAddress1.ReadOnly = Not flag
        txtEtcInfo1.ReadOnly = Not flag

    End Sub

    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        Call CustomerInfoSave()
    End Sub
    Private Sub CustomerInfoSave()

        ' 고객정보저장
        Dim SQL As String = ""

        If txtTelInfo1.Text.Trim = "" And txtHP1.Text.Trim = "" Then
            MsgBox("전화 번호를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
            txtTelInfo1.Focus()
            Exit Sub
        End If

        If txtTelInfo1.Text.Trim <> "" Then
            If Not IsNumeric(txtTelInfo1.Text.Trim) Then
                MsgBox("전화 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtTelInfo1.Focus()
                Exit Sub
            End If
            If Not txtTelInfo1.Text.Trim.Length >= 8 Then
                MsgBox("전화번호가 잘못된 유형입니다. 다시 확인하시고 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtTelInfo1.Focus()
                Exit Sub
            End If
        End If


        If txtHP1.Text.Trim <> "" Then
            If Not IsNumeric(txtHP1.Text.Trim) Then
                MsgBox("핸드폰 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtHP1.Focus()
                Exit Sub
            End If

            Dim tel_no As String = txtHP1.Text.Trim.Substring(0, 3)

            If Not txtTelInfo1.Text.Trim.Length >= 8 _
                And Not (tel_no = "010" Or tel_no = "011" Or tel_no = "016" _
                     Or tel_no = "017" Or tel_no = "018" Or tel_no = "019") Then
                MsgBox("핸드폰 번호가 잘못된 유형입니다. 다시 확인하시고 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtHP1.Focus()
                Exit Sub
            End If
        End If

        If txtFaxNo1.Text.Trim <> "" Then
            If Not IsNumeric(txtFaxNo1.Text.Trim) Then
                MsgBox("팩스 번호를 숫자로 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtFaxNo1.Focus()
                Exit Sub
            End If
        End If

        If txtCustomerName.Text.Trim = "" Then
            MsgBox("고객명을 입력하세요.", MsgBoxStyle.OkOnly, "알림")
            txtCustomerName.Focus()
            Exit Sub
        End If

        Dim chk As String

        If txtCustomerID.Text.Trim = "" Then       ' 입력
            chk = "I"
            If gbIsCustomerTablePatched Then
                SQL = " INSERT INTO T_CUSTOMER( COM_CD,CUSTOMER_NM,C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC, UPDATE_DATE, COMPANY, DEPARTMENT, JOB_TITLE, EMAIL ) "
            Else
                SQL = " INSERT INTO T_CUSTOMER( COM_CD,CUSTOMER_NM,C_TELNO,H_TELNO,FAX_NO,CUSTOMER_TYPE,WOO_NO,CUSTOMER_ADDR,CUSTOMER_ETC, UPDATE_DATE ) "
            End If
            SQL = SQL & "values( '" & gsCOM_CD & "'"
            SQL = SQL & ",'" & txtCustomerName.Text.Trim & "'"

            If txtTelInfo1.Text.Trim <> "" And txtTelInfo1.Text.Trim.Length >= 8 Then
                SQL = SQL & ",'" & txtTelInfo1.Text.Trim & "'"
            Else
                SQL = SQL & ",''"
            End If

            If txtHP1.Text.Trim <> "" And txtHP1.Text.Trim.Length >= 8 Then
                SQL = SQL & ",'" & txtHP1.Text.Trim & "'"
            Else
                SQL = SQL & ",''"
            End If

            SQL = SQL & ",'" & txtFaxNo1.Text.Trim & "'"

            If cboCustomerType.SelectedIndex < 0 Then
                SQL = SQL & ",'" & "" & "'" ' CUSTOMER TYPE
            Else
                SQL = SQL & ",'" & cboCustomerType.SelectedValue.ToString.Replace("XXXX", "") & "'" ' CUSTOMER TYPE
            End If

            SQL = SQL & ",'" & mWoopyonNumber.Trim & "'"
            SQL = SQL & ",'" & txtAddress1.Text.Trim & "'"
            SQL = SQL & ",'" & txtEtcInfo1.Text.Trim & " '"

            SQL = SQL & ",'" & Format(Now, "yyyyMMddHHmmss") & "'"
            If gbIsCustomerTablePatched Then
                SQL = SQL & ",'" & txtCompany.Text.Trim & " '"
                SQL = SQL & ",'" & txtDepartment.Text.Trim & " '"
                SQL = SQL & ",'" & txtJobTitle.Text.Trim & " '"
                SQL = SQL & ",'" & txtEmail.Text.Trim & " '"
            End If
            SQL = SQL & ")"
        Else                                       ' 업데이트
            chk = "U"
            SQL = " UPDATE T_CUSTOMER SET CUSTOMER_NM = '" & txtCustomerName.Text.Trim & "'"

            If txtTelInfo1.Text.Trim <> "" And txtTelInfo1.Text.Trim.Length >= 8 Then
                SQL = SQL & ",C_TELNO= '" & txtTelInfo1.Text.Trim & "'"
            End If
            If txtHP1.Text.Trim <> "" And txtHP1.Text.Trim.Length >= 8 Then
                SQL = SQL & ",H_TELNO='" & txtHP1.Text.Trim & "'"
            End If

            SQL = SQL & ",FAX_NO='" & txtFaxNo1.Text.Trim & "'"

            If cboCustomerType.SelectedIndex < 0 Then
                SQL = SQL & ",CUSTOMER_TYPE= '" & "" & "'" ' CUSTOMER TYPE
            Else
                SQL = SQL & ",CUSTOMER_TYPE= '" & cboCustomerType.SelectedValue.ToString.Replace("XXXX", "") & "'" ' CUSTOMER TYPE
            End If

            SQL = SQL & ",WOO_NO= '" & mWoopyonNumber.Trim & "'"
            SQL = SQL & ",CUSTOMER_ADDR= '" & txtAddress1.Text.Trim & "'"
            SQL = SQL & ",CUSTOMER_ETC= '" & txtEtcInfo1.Text.Trim & "'"

            SQL = SQL & ",UPDATE_DATE= '" & Format(Now, "yyyyMMddHHmmss") & "'"

            If gbIsCustomerTablePatched Then
                SQL = SQL & ",COMPANY= '" & txtCompany.Text.Trim & "'"
                SQL = SQL & ",DEPARTMENT= '" & txtDepartment.Text.Trim & "'"
                SQL = SQL & ",JOB_TITLE= '" & txtJobTitle.Text.Trim & "'"
                SQL = SQL & ",EMAIL= '" & txtEmail.Text.Trim & "'"
            End If
            SQL = SQL & " WHERE COM_CD = '" & gsCOM_CD & "'"
            SQL = SQL & " AND CUSTOMER_ID = " & txtCustomerID.Text.Trim
        End If


        Try
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing

            If chk = "I" Then
                MsgBox("데이터가 등록되었습니다.", MsgBoxStyle.OkOnly, "알림")
                Call gsSelect("")
            ElseIf chk = "U" Then
                MsgBox("데이터가 변경되었습니다.", MsgBoxStyle.OkOnly, "알림")
            End If
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try
    End Sub

    Private Sub btnDel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel1.Click
        '고객정보삭제
        Try
            If txtCustomerID.Text.Trim = "" Then
                MsgBox("삭제할 고객정보를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
                Exit Sub
            End If

            '삭제
            If MessageBox.Show("선택한 고객정보를 삭제하시겠습니까?", "고객정보삭제", _
                               MessageBoxButtons.OKCancel, _
                                Nothing, _
                                MessageBoxDefaultButton.Button1) = DialogResult.Cancel Then
                Exit Sub
            End If


            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            Dim SQL As String = " DELETE FROM T_CUSTOMER WHERE COM_CD = '" & gsCOM_CD & "' AND CUSTOMER_ID = " & txtCustomerID.Text.Trim
            Dim dt As DataTable = GetData_table1(gsConString, SQL)

            dt = Nothing
            MsgBox("데이터가 삭제되었습니다.", MsgBoxStyle.OkOnly, "알림")
            Call gsSelect("")

            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try
    End Sub

    Private Sub info_trans()


        If cboDamdangja.SelectedValue = "XXXX" Or cboDamdangja.SelectedIndex < 0 Then
            MsgBox("대상자를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
            cboDamdangja.Focus()
            Exit Sub
        End If

        '전달
        If txtEnteringNo.Text.Trim = "" Then
            MsgBox("전달할 전화번호가 없습니다.", MsgBoxStyle.OkOnly, "알림")
            txtEnteringNo.Focus()
            Exit Sub
        ElseIf txtEnteringNo.Text.Trim.Length < 9 Then
            MsgBox("전달할 전화번호를 정확히 입력하세요.", MsgBoxStyle.OkOnly, "알림")
            txtEnteringNo.Focus()
            Exit Sub
        End If

        If txtCustomerID.Text.Trim = "" Then
            MsgBox("신규 고객이거나 전달할 고객 정보가 없습니다.고객을 먼저 등록후 데이터를 이관하세요.", MsgBoxStyle.OkOnly, "알림")
            Exit Sub
        End If

        Try
            clientSocket.Connect(gsSocketIP, CLng(gsSocketPort))

            Dim serverStream As NetworkStream = clientSocket.GetStream()

            Dim outStreamString As String = ""
            If mIsTransfered Then '이관된 건은 이관후 통화시간으로 변경함
                Dim tm As String = Format(Now, "yyyyMMddHHmmss")
                Dim tong_date As String = tm.Substring(0, 4) + "-" + tm.Substring(4, 2) + "-" + tm.Substring(6, 2)
                Dim tong_time As String = tm.Substring(8, 2) + ":" + tm.Substring(10, 2) + ":" + tm.Substring(12, 2)
                outStreamString = _
                "22&" & txtEnteringNo.Text.Trim _
                      & "&" & gsUSER_ID _
                      & "&" & cboDamdangja.SelectedValue.ToString _
                      & "&" & tong_date _
                      & "&" & tong_time    ' 변경된 통화일자/시간
            Else
                outStreamString = _
                "22&" & txtEnteringNo.Text.Trim _
                      & "&" & gsUSER_ID _
                      & "&" & cboDamdangja.SelectedValue.ToString _
                      & "&" & txtDate2.Text.Trim _
                      & "&" & txtTongTime2.Text.Trim
            End If


            '22&전화번호&유저아이&대상자아이디
            Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(outStreamString)
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

        Catch ex As Exception
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try

        Try
            clientSocket.Close()
        Catch ex As Exception
            Call WriteLog(Me.Name.ToString & ":" & ex.ToString)
        End Try

        Try
            'Call CustomerInfoSave()  고객정보를 저장할 이유가 없잔여
            If CallHistorySave("trans") Then

                FRM_NOTI_MSG.Show("이관되었습니다.")
                System.Threading.Thread.Sleep(1000)
                FRM_NOTI_MSG.Hide()

                Call gsFormExit()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        Call info_trans()
    End Sub

    Private Sub btnSave3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave3.Click

        Try
            Dim temp, temp2 As String
            Dim dt As DataTable

            If cboCoWorker3.SelectedValue = "XXXX" Or cboCoWorker3.SelectedIndex < 0 Then
                MsgBox("대상자를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
                cboCoWorker3.Focus()
                Exit Sub
            End If

            If cboWorkReason3.SelectedValue = "XXXX" Or cboWorkReason3.SelectedIndex < 0 Then
                MsgBox("약속사유를 선택하세요.", MsgBoxStyle.OkOnly, "알림")
                cboWorkReason3.Focus()
                Exit Sub
            End If


            '전달
            If txtWorkArea3.Text.Trim = "" Then
                MsgBox("약속장소를 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtWorkArea3.Focus()
                Exit Sub
            ElseIf txtWorkContents3.Text.Trim = "" Then
                MsgBox("업무 세부내용을 입력하세요.", MsgBoxStyle.OkOnly, "알림")
                txtWorkContents3.Focus()
                Exit Sub
            End If

            temp = "SELECT count(S_START_TIME) From t_schedule  "
            temp2 = " Where COM_CD='" & gsCOM_CD & _
                   "' AND S_START_TIME='" & dpt333.Text.ToString.Replace("-", "") & drpHour3.Text & drpMin3.Text & _
                   "' AND REGISTRANT LIKE '" & gsUSER_ID & ".%" & _
                   "' AND S_COMPANY_COWORKER LIKE '%" & cboCoWorker3.SelectedIndex.ToString & "%" & _
                   "' AND SHARING_TYPE='O'"
            '"' AND S_TITLE='" & txtTitle.Text.Trim & "' "

            dt = Mysql_GetData_table(gsConString, temp & temp2)

            If dt.Rows(0).Item(0).ToString.Trim = "0" Then

                temp = "Insert into t_schedule(COM_CD,S_START_TIME,S_END_TIME,REGISTRANT,SHARING_TYPE,S_TITLE,S_COMPANY_COWORKER,S_DESC,S_WORKOUT_REASON,S_WORKOUT_LOC) values('"
                temp = temp & gsCOM_CD & "','" & dpt333.Text.ToString.Replace("-", "") & drpHour3.Text & drpMin3.Text & "','"
                temp = temp & dpt333.Text.ToString.Replace("-", "") & "2359" & "','"
                temp = temp & gsUSER_ID.Trim & "." & gsUSER_NM.Trim & "','O','"
                temp = temp & "외근등록" & "','" & cboCoWorker3.SelectedValue.ToString & "','" & txtWorkContents3.Text.Trim & "'"    '& "') "

                If cboWorkReason3.SelectedValue.ToString.Replace("XXXX", "") <> "" Then
                    Dim str() As String = cboWorkReason3.SelectedValue.ToString.Split(".")
                    temp = temp & " ,'" & str(0).Trim & "'"
                Else
                    temp = temp & " ,''"
                End If
                'End If

                temp = temp & ",'" & txtWorkArea3.Text.Trim & "') "
                'temp = temp & ",'" & "" & "') "
                temp2 = ""

            Else
                temp = " UPDATE t_schedule SET S_WORKOUT_LOC = '" & txtWorkArea3.Text.Trim & "'" & " , S_DESC ='" & txtWorkContents3.Text.Trim & "'"
                'temp = " UPDATE t_schedule SET S_WORKOUT_LOC = '" & txtWorkArea3.Text.Trim & "'" & " , S_DESC ='" & txtWorkContents3.Text.Trim & "'"
                If cboWorkReason3.SelectedValue.ToString.Replace("XXXX", "") <> "" Then
                    Dim str() As String = cboWorkReason3.SelectedValue.ToString.Split(".")
                    temp = temp & " , S_WORKOUT_REASON =  '" & str(0).Trim & "'"
                Else
                    temp = temp & " , S_WORKOUT_REASON =  '" & "" & "'"
                End If
            End If
            dt.Reset()

            dt = Mysql_GetData_table(gsConString, temp & temp2)
            MsgBox("처리되었습니다.", MsgBoxStyle.OkOnly, "정보")
            dt = Nothing

        Catch ex As Exception
            Call WriteLog("외부업무 등록 실패:" & ex.Message)

            MsgBox("등록에 실패했습니다.", MsgBoxStyle.OkOnly, "정보")
        End Try
    End Sub

    Private Sub cboCustomerType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomerType.SelectedIndexChanged

    End Sub

    Private Sub txtEnteringNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEnteringNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call selectEnteringNo()
        End If
    End Sub

    Private Sub txtTongEtcInfo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTongEtcInfo2.TextChanged
        If (txtCustomerID.Text.Trim <> "" And txtDate2.Text = "" And gsUseARS = "Y") Then
            Dim tm As String = Format(Now, "yyyyMMddHHmmss")
            txtDate2.Text = tm.Substring(0, 4) + "-" + tm.Substring(4, 2) + "-" + tm.Substring(6, 2)
            txtTongTime2.Text = tm.Substring(8, 2) + ":" + tm.Substring(10, 2) + ":" + tm.Substring(12, 2)
            txtTongUser2.Text = gsUSER_ID & "." & gsUSER_NM
        End If
    End Sub

    Private Sub btnIni1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIni1.Click

    End Sub

    Private Sub btnFindId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindId.Click
        Try
            FRM_FIND_ID_BY_TELNO.ParentFrm = Me
            FRM_FIND_ID_BY_TELNO.setInfo(txtEnteringNo.Text.Trim, txtCustomerName.Text.Trim)
            AddHandler FRM_FIND_ID_BY_TELNO.btnConfirm.Click, AddressOf Setting_CustomerId
            FRM_FIND_ID_BY_TELNO.ShowDialog()
            FRM_FIND_ID_BY_TELNO.Focus()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub
    Private Sub Setting_CustomerId(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            'Dim str As String = Me.Tag.ToString
            Call selectEnteringNo()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub chModification1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chModification1.Click
        If (chModification1.Checked = True And mIsEnteringNoQueried = False) Then
            MsgBox("고객번호를 조회 후 등록하세요.", MsgBoxStyle.OkOnly, "알림")
            chModification1.Checked = False
        End If

    End Sub

    Private Sub txtEnteringNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnteringNo.TextChanged
        mIsEnteringNoQueried = False
        btnFindId.Enabled = False
    End Sub


    Private Sub GroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbConsultInfo.Enter, gbCustomerInfo.Enter, gbCustomerHistory.Enter
        Dim gBox As GroupBox = sender

        If gBox.Equals(gbCustomerInfo) Then
            switchFocus(PANEL_FOCUS.CUSTOMER_INFO)
        ElseIf gBox.Equals(gbConsultInfo) Then
            switchFocus(PANEL_FOCUS.CONSULT_INFO)
        ElseIf gBox.Equals(gbCustomerHistory) Then
            switchFocus(PANEL_FOCUS.CONSULT_HISTORY)
        End If
        'For Each mBtn In Me.btnGrpConsult.Controls
        '    If TypeOf mBtn Is Elegant.Ui.ToggleButton Then
        '        Dim mTestBtn As Elegant.Ui.ToggleButton = mBtn
        '        If mTestBtn.Tag = btn.Tag Then
        '            'MsgBox(btn.Tag, MsgBoxStyle.OkOnly, "알림")
        '        Else
        '            mTestBtn.Pressed = False
        '        End If
        '    End If
        'Next
    End Sub

    Private Sub GroupBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbCustomerInfo.Leave, gbCustomerHistory.Leave, gbConsultInfo.Leave
        switchFocus(PANEL_FOCUS.NONE)
    End Sub

    Private Sub btnCustomerTelNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerTelNo.Click
        Try
            FRM_CUSTOMER_TELNO.ParentFrm = Me
            FRM_CUSTOMER_TELNO.setInfo(txtCustomerID.Text, txtCustomerName.Text)
            AddHandler FRM_CUSTOMER_TELNO.btnConfirm.Click, AddressOf Setting_TelNo
            FRM_CUSTOMER_TELNO.ShowDialog()
            FRM_CUSTOMER_TELNO.Focus()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub
    Private Sub Setting_TelNo(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Call gsSelectTelNo(txtCustomerID.Text.Trim)
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub
End Class