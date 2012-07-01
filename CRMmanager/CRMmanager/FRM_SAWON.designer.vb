<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_SAWON
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_SAWON))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.COM_NM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TEAM_NM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.USER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.USER_NM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COM_CD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnInit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnSelect = New System.Windows.Forms.Button
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtName2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnZipCode = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.cboTeam = New System.Windows.Forms.ComboBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtPW = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cboGrade = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtExt = New System.Windows.Forms.TextBox
        Me.txtWP2 = New System.Windows.Forms.TextBox
        Me.txtWP1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DPDate2 = New System.Windows.Forms.DateTimePicker
        Me.chkRetire = New System.Windows.Forms.CheckBox
        Me.DPDate1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtHP = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboPosition = New System.Windows.Forms.ComboBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COM_NM, Me.TEAM_NM, Me.USER_ID, Me.USER_NM, Me.COM_CD})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(12, 75)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(410, 510)
        Me.DataGridView1.TabIndex = 0
        '
        'COM_NM
        '
        Me.COM_NM.DataPropertyName = "COM_NM"
        Me.COM_NM.HeaderText = "사업장"
        Me.COM_NM.Name = "COM_NM"
        Me.COM_NM.ReadOnly = True
        '
        'TEAM_NM
        '
        Me.TEAM_NM.DataPropertyName = "TEAM_NM"
        Me.TEAM_NM.HeaderText = "팀명"
        Me.TEAM_NM.Name = "TEAM_NM"
        Me.TEAM_NM.ReadOnly = True
        '
        'USER_ID
        '
        Me.USER_ID.DataPropertyName = "USER_ID"
        Me.USER_ID.HeaderText = "사원번호"
        Me.USER_ID.Name = "USER_ID"
        Me.USER_ID.ReadOnly = True
        Me.USER_ID.Width = 80
        '
        'USER_NM
        '
        Me.USER_NM.DataPropertyName = "USER_NM"
        Me.USER_NM.HeaderText = "이름"
        Me.USER_NM.Name = "USER_NM"
        Me.USER_NM.ReadOnly = True
        '
        'COM_CD
        '
        Me.COM_CD.DataPropertyName = "COM_CD"
        Me.COM_CD.HeaderText = "사업장코드"
        Me.COM_CD.Name = "COM_CD"
        Me.COM_CD.ReadOnly = True
        Me.COM_CD.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtName2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(830, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(748, 19)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(63, 25)
        Me.btnInit.TabIndex = 123
        Me.btnInit.Text = "초기화"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(686, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 25)
        Me.btnDelete.TabIndex = 122
        Me.btnDelete.Text = "삭제"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(624, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 25)
        Me.btnSave.TabIndex = 121
        Me.btnSave.Text = "저장"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(562, 19)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 120
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(6, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 105
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(77, 20)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(150, 21)
        Me.txtName2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "이름"
        '
        'Label28
        '
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.Location = New System.Drawing.Point(24, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 12)
        Me.Label28.TabIndex = 107
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(430, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(415, 380)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnZipCode)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label43)
        Me.TabPage1.Controls.Add(Me.cboTeam)
        Me.TabPage1.Controls.Add(Me.Label44)
        Me.TabPage1.Controls.Add(Me.Label42)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.Label40)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.txtPW)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.cboGrade)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtExt)
        Me.TabPage1.Controls.Add(Me.txtWP2)
        Me.TabPage1.Controls.Add(Me.txtWP1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DPDate2)
        Me.TabPage1.Controls.Add(Me.chkRetire)
        Me.TabPage1.Controls.Add(Me.DPDate1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtHP)
        Me.TabPage1.Controls.Add(Me.txtTel)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cboPosition)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtId)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(407, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "사원정보"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnZipCode
        '
        Me.btnZipCode.Location = New System.Drawing.Point(201, 161)
        Me.btnZipCode.Name = "btnZipCode"
        Me.btnZipCode.Size = New System.Drawing.Size(64, 22)
        Me.btnZipCode.TabIndex = 36
        Me.btnZipCode.Text = "우편번호"
        Me.btnZipCode.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(219, 50)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 12)
        Me.Label25.TabIndex = 117
        Me.Label25.Text = "등급"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "내선번호"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "핸드폰"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "직급"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "이름"
        '
        'Label43
        '
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.Location = New System.Drawing.Point(9, 80)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(13, 12)
        Me.Label43.TabIndex = 136
        '
        'cboTeam
        '
        Me.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Location = New System.Drawing.Point(81, 76)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(115, 20)
        Me.cboTeam.TabIndex = 29
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(22, 80)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 12)
        Me.Label44.TabIndex = 134
        Me.Label44.Text = "팀명"
        '
        'Label42
        '
        Me.Label42.Image = CType(resources.GetObject("Label42.Image"), System.Drawing.Image)
        Me.Label42.Location = New System.Drawing.Point(9, 138)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(13, 12)
        Me.Label42.TabIndex = 133
        '
        'Label41
        '
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(207, 108)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 12)
        Me.Label41.TabIndex = 108
        '
        'Label40
        '
        Me.Label40.Image = CType(resources.GetObject("Label40.Image"), System.Drawing.Image)
        Me.Label40.Location = New System.Drawing.Point(207, 79)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(13, 12)
        Me.Label40.TabIndex = 132
        '
        'Label39
        '
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(207, 50)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 12)
        Me.Label39.TabIndex = 131
        '
        'Label38
        '
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.Location = New System.Drawing.Point(207, 21)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 12)
        Me.Label38.TabIndex = 130
        '
        'Label37
        '
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.Location = New System.Drawing.Point(9, 253)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 12)
        Me.Label37.TabIndex = 129
        '
        'Label36
        '
        Me.Label36.Image = CType(resources.GetObject("Label36.Image"), System.Drawing.Image)
        Me.Label36.Location = New System.Drawing.Point(9, 224)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 12)
        Me.Label36.TabIndex = 128
        '
        'Label34
        '
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.Location = New System.Drawing.Point(9, 166)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 12)
        Me.Label34.TabIndex = 108
        '
        'Label33
        '
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.Location = New System.Drawing.Point(9, 109)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 12)
        Me.Label33.TabIndex = 126
        '
        'Label31
        '
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.Location = New System.Drawing.Point(9, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 12)
        Me.Label31.TabIndex = 124
        '
        'Label29
        '
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.Location = New System.Drawing.Point(9, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 12)
        Me.Label29.TabIndex = 123
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(11, 61)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 12)
        Me.Label26.TabIndex = 122
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(81, 47)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(115, 21)
        Me.txtPW.TabIndex = 27
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(22, 50)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 12)
        Me.Label27.TabIndex = 120
        Me.Label27.Text = "비밀번호"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(216, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 12)
        Me.Label24.TabIndex = 119
        '
        'cboGrade
        '
        Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Location = New System.Drawing.Point(277, 47)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(115, 20)
        Me.cboGrade.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(216, 142)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 12)
        Me.Label20.TabIndex = 116
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(216, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 12)
        Me.Label21.TabIndex = 115
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(216, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 12)
        Me.Label22.TabIndex = 114
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(216, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 12)
        Me.Label23.TabIndex = 113
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(11, 227)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 12)
        Me.Label19.TabIndex = 112
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(11, 199)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 12)
        Me.Label18.TabIndex = 111
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(11, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 12)
        Me.Label17.TabIndex = 110
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(11, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 12)
        Me.Label16.TabIndex = 109
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(11, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 12)
        Me.Label15.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(11, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 12)
        Me.Label14.TabIndex = 107
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(11, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 12)
        Me.Label13.TabIndex = 106
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(82, 133)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(115, 21)
        Me.txtExt.TabIndex = 33
        '
        'txtWP2
        '
        Me.txtWP2.Location = New System.Drawing.Point(140, 161)
        Me.txtWP2.Name = "txtWP2"
        Me.txtWP2.Size = New System.Drawing.Size(56, 21)
        Me.txtWP2.TabIndex = 35
        '
        'txtWP1
        '
        Me.txtWP1.Location = New System.Drawing.Point(81, 161)
        Me.txtWP1.Name = "txtWP1"
        Me.txtWP1.Size = New System.Drawing.Size(56, 21)
        Me.txtWP1.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "주소"
        '
        'DPDate2
        '
        Me.DPDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate2.Location = New System.Drawing.Point(277, 248)
        Me.DPDate2.Name = "DPDate2"
        Me.DPDate2.Size = New System.Drawing.Size(115, 21)
        Me.DPDate2.TabIndex = 41
        Me.DPDate2.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'chkRetire
        '
        Me.chkRetire.Font = New System.Drawing.Font("굴림", 8.99!)
        Me.chkRetire.Location = New System.Drawing.Point(211, 253)
        Me.chkRetire.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkRetire.Name = "chkRetire"
        Me.chkRetire.Size = New System.Drawing.Size(60, 16)
        Me.chkRetire.TabIndex = 40
        Me.chkRetire.Text = "퇴사일"
        Me.chkRetire.UseVisualStyleBackColor = True
        '
        'DPDate1
        '
        Me.DPDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate1.Location = New System.Drawing.Point(81, 248)
        Me.DPDate1.Name = "DPDate1"
        Me.DPDate1.Size = New System.Drawing.Size(115, 21)
        Me.DPDate1.TabIndex = 39
        Me.DPDate1.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "입사일"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(81, 219)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(313, 21)
        Me.txtEmail.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "이메일"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(81, 190)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(313, 21)
        Me.txtAddress.TabIndex = 37
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(277, 104)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(115, 21)
        Me.txtHP.TabIndex = 32
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(81, 104)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(115, 21)
        Me.txtTel.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "전화번호"
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(277, 76)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(115, 20)
        Me.cboPosition.TabIndex = 30
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(277, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(115, 21)
        Me.txtName.TabIndex = 26
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(81, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(115, 21)
        Me.txtId.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "사원번호"
        '
        'FRM_SAWON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(906, 686)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_SAWON"
        Me.Text = "사원 등록"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DPDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtHP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtExt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DPDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkRetire As System.Windows.Forms.CheckBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cboTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnZipCode As System.Windows.Forms.Button
    Friend WithEvents COM_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEAM_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USER_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COM_CD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
