<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CUSTOMER
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CUSTOMER))
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtTelNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.cboTelType = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtCustomerNM = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_NM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_TELNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.H_TELNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FAX_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COMPANY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEPARTMENT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JOB_TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WOO_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_ADDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_ETC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.pnlCustomerBottom = New System.Windows.Forms.Panel
        Me.btnZipCode = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtEtcInfo = New System.Windows.Forms.TextBox
        Me.txtWP2 = New System.Windows.Forms.TextBox
        Me.txtWP1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlCustomerMiddle = New System.Windows.Forms.Panel
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtJobTitle = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.btnTelNoAdd = New System.Windows.Forms.Button
        Me.btnIni = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtFaxNo3 = New System.Windows.Forms.TextBox
        Me.txtFaxNo2 = New System.Windows.Forms.TextBox
        Me.txtHP2 = New System.Windows.Forms.TextBox
        Me.txtWorkTelNo3 = New System.Windows.Forms.TextBox
        Me.txtWorkTelNo2 = New System.Windows.Forms.TextBox
        Me.cboHP = New System.Windows.Forms.ComboBox
        Me.cboCustomerType = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFaxNo1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtHP1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtWorkTelNo1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlCustomerBottom.SuspendLayout()
        Me.pnlCustomerMiddle.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(194, 22)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(115, 21)
        Me.txtTelNo.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "조회조건"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.cboTelType)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtCustomerNM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTelNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(871, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(822, 20)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(45, 25)
        Me.btnExcel.TabIndex = 105
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(774, 20)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 104
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cboTelType
        '
        Me.cboTelType.BackColor = System.Drawing.Color.MintCream
        Me.cboTelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTelType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboTelType.FormattingEnabled = True
        Me.cboTelType.Items.AddRange(New Object() {"직장전화번호", "핸드폰번호", "팩스번호"})
        Me.cboTelType.Location = New System.Drawing.Point(73, 22)
        Me.cboTelType.Name = "cboTelType"
        Me.cboTelType.Size = New System.Drawing.Size(114, 20)
        Me.cboTelType.TabIndex = 101
        '
        'Label12
        '
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(323, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 12)
        Me.Label12.TabIndex = 107
        '
        'Label30
        '
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(6, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 106
        '
        'txtCustomerNM
        '
        Me.txtCustomerNM.Location = New System.Drawing.Point(383, 22)
        Me.txtCustomerNM.Name = "txtCustomerNM"
        Me.txtCustomerNM.Size = New System.Drawing.Size(115, 21)
        Me.txtCustomerNM.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "고객명"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMER_ID, Me.CUSTOMER_NM, Me.C_TELNO, Me.H_TELNO, Me.FAX_NO, Me.COMPANY, Me.DEPARTMENT, Me.JOB_TITLE, Me.EMAIL, Me.CUSTOMER_TYPE, Me.WOO_NO, Me.CUSTOMER_ADDR, Me.CUSTOMER_ETC})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(13, 64)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(871, 303)
        Me.DataGridView1.TabIndex = 106
        '
        'CUSTOMER_ID
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CUSTOMER_ID.DefaultCellStyle = DataGridViewCellStyle20
        Me.CUSTOMER_ID.HeaderText = "고객아이디"
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.ReadOnly = True
        Me.CUSTOMER_ID.Width = 90
        '
        'CUSTOMER_NM
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CUSTOMER_NM.DefaultCellStyle = DataGridViewCellStyle21
        Me.CUSTOMER_NM.HeaderText = "고객명"
        Me.CUSTOMER_NM.Name = "CUSTOMER_NM"
        Me.CUSTOMER_NM.ReadOnly = True
        Me.CUSTOMER_NM.Width = 80
        '
        'C_TELNO
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.C_TELNO.DefaultCellStyle = DataGridViewCellStyle22
        Me.C_TELNO.HeaderText = "전화번호"
        Me.C_TELNO.Name = "C_TELNO"
        Me.C_TELNO.ReadOnly = True
        '
        'H_TELNO
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.H_TELNO.DefaultCellStyle = DataGridViewCellStyle23
        Me.H_TELNO.HeaderText = "휴대폰번호"
        Me.H_TELNO.Name = "H_TELNO"
        Me.H_TELNO.ReadOnly = True
        '
        'FAX_NO
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FAX_NO.DefaultCellStyle = DataGridViewCellStyle24
        Me.FAX_NO.HeaderText = "팩스번호"
        Me.FAX_NO.Name = "FAX_NO"
        Me.FAX_NO.ReadOnly = True
        '
        'COMPANY
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.COMPANY.DefaultCellStyle = DataGridViewCellStyle25
        Me.COMPANY.HeaderText = "회사"
        Me.COMPANY.Name = "COMPANY"
        Me.COMPANY.ReadOnly = True
        '
        'DEPARTMENT
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DEPARTMENT.DefaultCellStyle = DataGridViewCellStyle26
        Me.DEPARTMENT.HeaderText = "소속"
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.ReadOnly = True
        '
        'JOB_TITLE
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.JOB_TITLE.DefaultCellStyle = DataGridViewCellStyle27
        Me.JOB_TITLE.HeaderText = "직급"
        Me.JOB_TITLE.Name = "JOB_TITLE"
        Me.JOB_TITLE.ReadOnly = True
        '
        'EMAIL
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.EMAIL.DefaultCellStyle = DataGridViewCellStyle28
        Me.EMAIL.HeaderText = "이메일"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'CUSTOMER_TYPE
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CUSTOMER_TYPE.DefaultCellStyle = DataGridViewCellStyle29
        Me.CUSTOMER_TYPE.HeaderText = "고객유형"
        Me.CUSTOMER_TYPE.Name = "CUSTOMER_TYPE"
        Me.CUSTOMER_TYPE.ReadOnly = True
        '
        'WOO_NO
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.WOO_NO.DefaultCellStyle = DataGridViewCellStyle30
        Me.WOO_NO.HeaderText = "우편번호"
        Me.WOO_NO.Name = "WOO_NO"
        Me.WOO_NO.ReadOnly = True
        '
        'CUSTOMER_ADDR
        '
        Me.CUSTOMER_ADDR.HeaderText = "주소"
        Me.CUSTOMER_ADDR.Name = "CUSTOMER_ADDR"
        Me.CUSTOMER_ADDR.ReadOnly = True
        Me.CUSTOMER_ADDR.Width = 200
        '
        'CUSTOMER_ETC
        '
        Me.CUSTOMER_ETC.HeaderText = "기타정보"
        Me.CUSTOMER_ETC.Name = "CUSTOMER_ETC"
        Me.CUSTOMER_ETC.ReadOnly = True
        Me.CUSTOMER_ETC.Width = 500
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 373)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 291)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlCustomerBottom)
        Me.TabPage1.Controls.Add(Me.pnlCustomerMiddle)
        Me.TabPage1.Controls.Add(Me.btnTelNoAdd)
        Me.TabPage1.Controls.Add(Me.btnIni)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnModify)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.txtFaxNo3)
        Me.TabPage1.Controls.Add(Me.txtFaxNo2)
        Me.TabPage1.Controls.Add(Me.txtHP2)
        Me.TabPage1.Controls.Add(Me.txtWorkTelNo3)
        Me.TabPage1.Controls.Add(Me.txtWorkTelNo2)
        Me.TabPage1.Controls.Add(Me.cboHP)
        Me.TabPage1.Controls.Add(Me.cboCustomerType)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtFaxNo1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtHP1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtWorkTelNo1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtCustomerName)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtCustomerID)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(864, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "고객정보등록"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlCustomerBottom
        '
        Me.pnlCustomerBottom.Controls.Add(Me.btnZipCode)
        Me.pnlCustomerBottom.Controls.Add(Me.Label17)
        Me.pnlCustomerBottom.Controls.Add(Me.Label16)
        Me.pnlCustomerBottom.Controls.Add(Me.Label15)
        Me.pnlCustomerBottom.Controls.Add(Me.txtEtcInfo)
        Me.pnlCustomerBottom.Controls.Add(Me.txtWP2)
        Me.pnlCustomerBottom.Controls.Add(Me.txtWP1)
        Me.pnlCustomerBottom.Controls.Add(Me.Label11)
        Me.pnlCustomerBottom.Controls.Add(Me.txtAddress)
        Me.pnlCustomerBottom.Controls.Add(Me.Label8)
        Me.pnlCustomerBottom.Controls.Add(Me.Label5)
        Me.pnlCustomerBottom.Location = New System.Drawing.Point(6, 127)
        Me.pnlCustomerBottom.Name = "pnlCustomerBottom"
        Me.pnlCustomerBottom.Size = New System.Drawing.Size(777, 125)
        Me.pnlCustomerBottom.TabIndex = 220
        '
        'btnZipCode
        '
        Me.btnZipCode.Font = New System.Drawing.Font("굴림", 8.0!)
        Me.btnZipCode.Location = New System.Drawing.Point(205, 8)
        Me.btnZipCode.Name = "btnZipCode"
        Me.btnZipCode.Size = New System.Drawing.Size(60, 18)
        Me.btnZipCode.TabIndex = 223
        Me.btnZipCode.Text = "우편번호"
        Me.btnZipCode.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(4, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 12)
        Me.Label17.TabIndex = 127
        '
        'Label16
        '
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(4, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 12)
        Me.Label16.TabIndex = 126
        '
        'Label15
        '
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(4, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 12)
        Me.Label15.TabIndex = 125
        '
        'txtEtcInfo
        '
        Me.txtEtcInfo.Location = New System.Drawing.Point(85, 62)
        Me.txtEtcInfo.Multiline = True
        Me.txtEtcInfo.Name = "txtEtcInfo"
        Me.txtEtcInfo.Size = New System.Drawing.Size(682, 52)
        Me.txtEtcInfo.TabIndex = 225
        '
        'txtWP2
        '
        Me.txtWP2.Location = New System.Drawing.Point(144, 5)
        Me.txtWP2.Name = "txtWP2"
        Me.txtWP2.Size = New System.Drawing.Size(56, 21)
        Me.txtWP2.TabIndex = 222
        '
        'txtWP1
        '
        Me.txtWP1.Location = New System.Drawing.Point(85, 5)
        Me.txtWP1.Name = "txtWP1"
        Me.txtWP1.Size = New System.Drawing.Size(56, 21)
        Me.txtWP1.TabIndex = 221
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "우편번호"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(85, 35)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(682, 21)
        Me.txtAddress.TabIndex = 224
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "주소"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "기타정보"
        '
        'pnlCustomerMiddle
        '
        Me.pnlCustomerMiddle.Controls.Add(Me.Label45)
        Me.pnlCustomerMiddle.Controls.Add(Me.txtEmail)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label46)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label43)
        Me.pnlCustomerMiddle.Controls.Add(Me.txtJobTitle)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label44)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label41)
        Me.pnlCustomerMiddle.Controls.Add(Me.txtDepartment)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label42)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label39)
        Me.pnlCustomerMiddle.Controls.Add(Me.txtCompany)
        Me.pnlCustomerMiddle.Controls.Add(Me.Label40)
        Me.pnlCustomerMiddle.Location = New System.Drawing.Point(6, 69)
        Me.pnlCustomerMiddle.Name = "pnlCustomerMiddle"
        Me.pnlCustomerMiddle.Size = New System.Drawing.Size(793, 57)
        Me.pnlCustomerMiddle.TabIndex = 214
        '
        'Label45
        '
        Me.Label45.Image = CType(resources.GetObject("Label45.Image"), System.Drawing.Image)
        Me.Label45.Location = New System.Drawing.Point(4, 34)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(13, 12)
        Me.Label45.TabIndex = 135
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(85, 31)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(115, 21)
        Me.txtEmail.TabIndex = 218
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(17, 34)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(41, 12)
        Me.Label46.TabIndex = 133
        Me.Label46.Text = "이메일"
        '
        'Label43
        '
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.Location = New System.Drawing.Point(582, 7)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(13, 12)
        Me.Label43.TabIndex = 132
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Location = New System.Drawing.Point(654, 4)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(115, 21)
        Me.txtJobTitle.TabIndex = 217
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(595, 7)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 12)
        Me.Label44.TabIndex = 130
        Me.Label44.Text = "직급"
        '
        'Label41
        '
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(326, 7)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 12)
        Me.Label41.TabIndex = 129
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(385, 4)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(115, 21)
        Me.txtDepartment.TabIndex = 216
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(339, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(29, 12)
        Me.Label42.TabIndex = 127
        Me.Label42.Text = "소속"
        '
        'Label39
        '
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(4, 7)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 12)
        Me.Label39.TabIndex = 126
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(85, 4)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(115, 21)
        Me.txtCompany.TabIndex = 215
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(17, 7)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(29, 12)
        Me.Label40.TabIndex = 124
        Me.Label40.Text = "회사"
        '
        'btnTelNoAdd
        '
        Me.btnTelNoAdd.Font = New System.Drawing.Font("굴림", 8.0!)
        Me.btnTelNoAdd.Location = New System.Drawing.Point(211, 43)
        Me.btnTelNoAdd.Name = "btnTelNoAdd"
        Me.btnTelNoAdd.Size = New System.Drawing.Size(60, 21)
        Me.btnTelNoAdd.TabIndex = 207
        Me.btnTelNoAdd.Text = "추가"
        Me.btnTelNoAdd.UseVisualStyleBackColor = True
        '
        'btnIni
        '
        Me.btnIni.Location = New System.Drawing.Point(785, 218)
        Me.btnIni.Name = "btnIni"
        Me.btnIni.Size = New System.Drawing.Size(64, 25)
        Me.btnIni.TabIndex = 229
        Me.btnIni.Text = "초기화"
        Me.btnIni.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(785, 190)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 25)
        Me.btnDelete.TabIndex = 228
        Me.btnDelete.Text = "삭제"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(785, 162)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(64, 25)
        Me.btnModify.TabIndex = 227
        Me.btnModify.Text = "수정"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(785, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 25)
        Me.btnSave.TabIndex = 226
        Me.btnSave.Text = "신규등록"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFaxNo3
        '
        Me.txtFaxNo3.Location = New System.Drawing.Point(739, 43)
        Me.txtFaxNo3.MaxLength = 4
        Me.txtFaxNo3.Name = "txtFaxNo3"
        Me.txtFaxNo3.Size = New System.Drawing.Size(35, 21)
        Me.txtFaxNo3.TabIndex = 213
        '
        'txtFaxNo2
        '
        Me.txtFaxNo2.Location = New System.Drawing.Point(700, 43)
        Me.txtFaxNo2.MaxLength = 4
        Me.txtFaxNo2.Name = "txtFaxNo2"
        Me.txtFaxNo2.Size = New System.Drawing.Size(35, 21)
        Me.txtFaxNo2.TabIndex = 212
        '
        'txtHP2
        '
        Me.txtHP2.Location = New System.Drawing.Point(482, 43)
        Me.txtHP2.MaxLength = 4
        Me.txtHP2.Name = "txtHP2"
        Me.txtHP2.Size = New System.Drawing.Size(35, 21)
        Me.txtHP2.TabIndex = 210
        '
        'txtWorkTelNo3
        '
        Me.txtWorkTelNo3.Location = New System.Drawing.Point(171, 43)
        Me.txtWorkTelNo3.MaxLength = 4
        Me.txtWorkTelNo3.Name = "txtWorkTelNo3"
        Me.txtWorkTelNo3.Size = New System.Drawing.Size(35, 21)
        Me.txtWorkTelNo3.TabIndex = 206
        '
        'txtWorkTelNo2
        '
        Me.txtWorkTelNo2.Location = New System.Drawing.Point(132, 43)
        Me.txtWorkTelNo2.MaxLength = 4
        Me.txtWorkTelNo2.Name = "txtWorkTelNo2"
        Me.txtWorkTelNo2.Size = New System.Drawing.Size(35, 21)
        Me.txtWorkTelNo2.TabIndex = 205
        '
        'cboHP
        '
        Me.cboHP.BackColor = System.Drawing.Color.MintCream
        Me.cboHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHP.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboHP.FormattingEnabled = True
        Me.cboHP.Items.AddRange(New Object() {"", "010", "011", "016", "017", "018", "019"})
        Me.cboHP.Location = New System.Drawing.Point(391, 43)
        Me.cboHP.Name = "cboHP"
        Me.cboHP.Size = New System.Drawing.Size(49, 20)
        Me.cboHP.TabIndex = 208
        '
        'cboCustomerType
        '
        Me.cboCustomerType.BackColor = System.Drawing.Color.MintCream
        Me.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomerType.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboCustomerType.FormattingEnabled = True
        Me.cboCustomerType.Location = New System.Drawing.Point(660, 16)
        Me.cboCustomerType.Name = "cboCustomerType"
        Me.cboCustomerType.Size = New System.Drawing.Size(114, 20)
        Me.cboCustomerType.TabIndex = 203
        '
        'Label38
        '
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.Location = New System.Drawing.Point(586, 46)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 12)
        Me.Label38.TabIndex = 131
        '
        'Label37
        '
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.Location = New System.Drawing.Point(586, 19)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 12)
        Me.Label37.TabIndex = 130
        '
        'Label19
        '
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.Location = New System.Drawing.Point(331, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 12)
        Me.Label19.TabIndex = 129
        '
        'Label18
        '
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(331, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 12)
        Me.Label18.TabIndex = 128
        '
        'Label14
        '
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(10, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 12)
        Me.Label14.TabIndex = 124
        '
        'Label13
        '
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(10, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 12)
        Me.Label13.TabIndex = 123
        '
        'txtFaxNo1
        '
        Me.txtFaxNo1.Location = New System.Drawing.Point(660, 43)
        Me.txtFaxNo1.MaxLength = 4
        Me.txtFaxNo1.Name = "txtFaxNo1"
        Me.txtFaxNo1.Size = New System.Drawing.Size(35, 21)
        Me.txtFaxNo1.TabIndex = 211
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(598, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "팩스번호"
        '
        'txtHP1
        '
        Me.txtHP1.Location = New System.Drawing.Point(441, 43)
        Me.txtHP1.MaxLength = 4
        Me.txtHP1.Name = "txtHP1"
        Me.txtHP1.Size = New System.Drawing.Size(35, 21)
        Me.txtHP1.TabIndex = 209
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "핸드폰"
        '
        'txtWorkTelNo1
        '
        Me.txtWorkTelNo1.Location = New System.Drawing.Point(91, 43)
        Me.txtWorkTelNo1.MaxLength = 4
        Me.txtWorkTelNo1.Name = "txtWorkTelNo1"
        Me.txtWorkTelNo1.Size = New System.Drawing.Size(35, 21)
        Me.txtWorkTelNo1.TabIndex = 204
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "전화번호"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(600, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "고객유형"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(391, 16)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(126, 21)
        Me.txtCustomerName.TabIndex = 202
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "고객명"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(91, 16)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(115, 21)
        Me.txtCustomerID.TabIndex = 201
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "고객아이디"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(864, 265)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "상담이력"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle33.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Column10})
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(852, 253)
        Me.DataGridView2.TabIndex = 79
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "고객명"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "통화일자"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "통화시간"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "통화번호"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "상담유형"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "상담결과"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "통화자"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "상담내용"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 130
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(668, 119)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(58, 25)
        Me.Button5.TabIndex = 122
        Me.Button5.Text = "초기화"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(668, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(58, 25)
        Me.Button6.TabIndex = 121
        Me.Button6.Text = "삭제"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(668, 57)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(58, 25)
        Me.Button7.TabIndex = 120
        Me.Button7.Text = "저장"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(90, 124)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(508, 108)
        Me.TextBox4.TabIndex = 66
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(484, 46)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(115, 21)
        Me.TextBox5.TabIndex = 65
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(425, 49)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 12)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = "팩스번호"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(149, 67)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(56, 21)
        Me.TextBox6.TabIndex = 63
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(90, 67)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(56, 21)
        Me.TextBox7.TabIndex = 62
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(22, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 12)
        Me.Label28.TabIndex = 61
        Me.Label28.Text = "우편번호"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(91, 97)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(508, 21)
        Me.TextBox8.TabIndex = 60
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(23, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 12)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "주소"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(289, 43)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(115, 21)
        Me.TextBox9.TabIndex = 58
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(237, 46)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 12)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "핸드폰"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(91, 43)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(115, 21)
        Me.TextBox10.TabIndex = 56
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(23, 46)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(53, 12)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "직장번호"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(23, 123)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 12)
        Me.Label33.TabIndex = 53
        Me.Label33.Text = "기타정보"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(484, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 20)
        Me.ComboBox1.TabIndex = 52
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(425, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 12)
        Me.Label34.TabIndex = 51
        Me.Label34.Text = "고객유형"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(289, 16)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(115, 21)
        Me.TextBox11.TabIndex = 50
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(237, 19)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(41, 12)
        Me.Label35.TabIndex = 49
        Me.Label35.Text = "고객명"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(91, 16)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(115, 21)
        Me.TextBox12.TabIndex = 48
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(23, 19)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(65, 12)
        Me.Label36.TabIndex = 47
        Me.Label36.Text = "고객아이디"
        '
        'Label20
        '
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(227, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 12)
        Me.Label20.TabIndex = 129
        '
        'Label21
        '
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(227, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 12)
        Me.Label21.TabIndex = 128
        '
        'Label22
        '
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(11, 124)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 12)
        Me.Label22.TabIndex = 127
        '
        'Label23
        '
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(11, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 12)
        Me.Label23.TabIndex = 126
        '
        'Label24
        '
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(11, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 12)
        Me.Label24.TabIndex = 125
        '
        'Label25
        '
        Me.Label25.Image = CType(resources.GetObject("Label25.Image"), System.Drawing.Image)
        Me.Label25.Location = New System.Drawing.Point(11, 46)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 12)
        Me.Label25.TabIndex = 124
        '
        'Label26
        '
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.Location = New System.Drawing.Point(11, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 12)
        Me.Label26.TabIndex = 123
        '
        'formFrameSkinner
        '
        Me.formFrameSkinner.Form = Me
        '
        'SaveFileDialog1
        '
        '
        'FRM_CUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_CUSTOMER"
        Me.Text = "고객정보"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pnlCustomerBottom.ResumeLayout(False)
        Me.pnlCustomerBottom.PerformLayout()
        Me.pnlCustomerMiddle.ResumeLayout(False)
        Me.pnlCustomerMiddle.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtFaxNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtWP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtWorkTelNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEtcInfo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents cboTelType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboHP As System.Windows.Forms.ComboBox
    Friend WithEvents txtWorkTelNo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkTelNo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFaxNo2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnIni As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTelNoAdd As System.Windows.Forms.Button
    Friend WithEvents btnZipCode As System.Windows.Forms.Button
    Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlCustomerMiddle As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtJobTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents pnlCustomerBottom As System.Windows.Forms.Panel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents CUSTOMER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_TELNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H_TELNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAX_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMPANY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPARTMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JOB_TITLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WOO_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_ADDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_ETC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
