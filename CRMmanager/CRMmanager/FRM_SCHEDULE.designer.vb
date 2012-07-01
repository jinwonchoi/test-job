<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_SCHEDULE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_SCHEDULE))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.S_START_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_END_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SHARING = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SHARING_TYPE2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REGISTRANT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SHARING_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_COMPANY_COWORKER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_WORKOUT_REASON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_WORKOUT_LOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.drpUser = New System.Windows.Forms.ComboBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.btnRemove2 = New System.Windows.Forms.Button
        Me.btnAdd2 = New System.Windows.Forms.Button
        Me.drpWReason = New System.Windows.Forms.ComboBox
        Me.txtWLoc = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.drpGubun = New System.Windows.Forms.ComboBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.drpTeam = New System.Windows.Forms.ComboBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.chkSharing = New System.Windows.Forms.CheckBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.UserLB2 = New System.Windows.Forms.ListBox
        Me.UserLB1 = New System.Windows.Forms.ListBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.txtSchedule = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.drpMin2 = New System.Windows.Forms.ComboBox
        Me.drpHour2 = New System.Windows.Forms.ComboBox
        Me.DPDate2 = New System.Windows.Forms.DateTimePicker
        Me.Label69 = New System.Windows.Forms.Label
        Me.drpMin1 = New System.Windows.Forms.ComboBox
        Me.drpHour1 = New System.Windows.Forms.ComboBox
        Me.DPDate1 = New System.Windows.Forms.DateTimePicker
        Me.Label70 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.UserLB3 = New System.Windows.Forms.ListBox
        Me.DPYear = New System.Windows.Forms.DateTimePicker
        Me.DPMonth = New System.Windows.Forms.DateTimePicker
        Me.btn_today = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label18)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label19)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label22)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label23)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label25)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label26)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label28)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label29)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label30)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label31)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label32)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label33)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label35)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label36)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label37)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label38)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label39)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label40)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label42)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label20)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label27)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label34)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label41)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(22, 50)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(458, 284)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(458, 35)
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(1, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(64, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(66, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(64, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(131, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(64, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(196, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5)
        Me.Label4.Size = New System.Drawing.Size(64, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(261, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(64, 40)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label6.Location = New System.Drawing.Point(326, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(64, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(391, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(64, 40)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label8.Location = New System.Drawing.Point(1, 77)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5)
        Me.Label8.Size = New System.Drawing.Size(64, 40)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label9.Location = New System.Drawing.Point(66, 77)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5)
        Me.Label9.Size = New System.Drawing.Size(64, 40)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label10.Location = New System.Drawing.Point(131, 77)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(5)
        Me.Label10.Size = New System.Drawing.Size(64, 40)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(196, 77)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(5)
        Me.Label11.Size = New System.Drawing.Size(64, 40)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label12.Location = New System.Drawing.Point(261, 77)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(5)
        Me.Label12.Size = New System.Drawing.Size(64, 40)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "1"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.Location = New System.Drawing.Point(326, 77)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(5)
        Me.Label13.Size = New System.Drawing.Size(64, 40)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "1"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label14.Location = New System.Drawing.Point(391, 77)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(5)
        Me.Label14.Size = New System.Drawing.Size(64, 40)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "1"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label15.Location = New System.Drawing.Point(1, 118)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New System.Windows.Forms.Padding(5)
        Me.Label15.Size = New System.Drawing.Size(64, 40)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label16.Location = New System.Drawing.Point(66, 118)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(5)
        Me.Label16.Size = New System.Drawing.Size(64, 40)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "1"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label17.Location = New System.Drawing.Point(131, 118)
        Me.Label17.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(5)
        Me.Label17.Size = New System.Drawing.Size(64, 40)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "1"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label18.Location = New System.Drawing.Point(196, 118)
        Me.Label18.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(5)
        Me.Label18.Size = New System.Drawing.Size(64, 40)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "1"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label19.Location = New System.Drawing.Point(261, 118)
        Me.Label19.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New System.Windows.Forms.Padding(5)
        Me.Label19.Size = New System.Drawing.Size(64, 40)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "1"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label21.Location = New System.Drawing.Point(326, 118)
        Me.Label21.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(5)
        Me.Label21.Size = New System.Drawing.Size(64, 40)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "1"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label22.Location = New System.Drawing.Point(391, 118)
        Me.Label22.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Padding = New System.Windows.Forms.Padding(5)
        Me.Label22.Size = New System.Drawing.Size(64, 40)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "1"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label23.Location = New System.Drawing.Point(1, 159)
        Me.Label23.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Padding = New System.Windows.Forms.Padding(5)
        Me.Label23.Size = New System.Drawing.Size(64, 40)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "1"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label24.Location = New System.Drawing.Point(66, 159)
        Me.Label24.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Padding = New System.Windows.Forms.Padding(5)
        Me.Label24.Size = New System.Drawing.Size(64, 40)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "1"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label25.Location = New System.Drawing.Point(131, 159)
        Me.Label25.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Padding = New System.Windows.Forms.Padding(5)
        Me.Label25.Size = New System.Drawing.Size(64, 40)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "1"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label26.Location = New System.Drawing.Point(196, 159)
        Me.Label26.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Padding = New System.Windows.Forms.Padding(5)
        Me.Label26.Size = New System.Drawing.Size(64, 40)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "1"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label28.Location = New System.Drawing.Point(261, 159)
        Me.Label28.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Padding = New System.Windows.Forms.Padding(5)
        Me.Label28.Size = New System.Drawing.Size(64, 40)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "1"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label29.Location = New System.Drawing.Point(326, 159)
        Me.Label29.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New System.Windows.Forms.Padding(5)
        Me.Label29.Size = New System.Drawing.Size(64, 40)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "1"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label30.Location = New System.Drawing.Point(391, 159)
        Me.Label30.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Padding = New System.Windows.Forms.Padding(5)
        Me.Label30.Size = New System.Drawing.Size(64, 40)
        Me.Label30.TabIndex = 29
        Me.Label30.Text = "1"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label31.Location = New System.Drawing.Point(1, 200)
        Me.Label31.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Padding = New System.Windows.Forms.Padding(5)
        Me.Label31.Size = New System.Drawing.Size(64, 40)
        Me.Label31.TabIndex = 30
        Me.Label31.Text = "1"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label32.Location = New System.Drawing.Point(66, 200)
        Me.Label32.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Padding = New System.Windows.Forms.Padding(5)
        Me.Label32.Size = New System.Drawing.Size(64, 40)
        Me.Label32.TabIndex = 31
        Me.Label32.Text = "1"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label33.Location = New System.Drawing.Point(131, 200)
        Me.Label33.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Padding = New System.Windows.Forms.Padding(5)
        Me.Label33.Size = New System.Drawing.Size(64, 40)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "1"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label35.Location = New System.Drawing.Point(196, 200)
        Me.Label35.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Padding = New System.Windows.Forms.Padding(5)
        Me.Label35.Size = New System.Drawing.Size(64, 40)
        Me.Label35.TabIndex = 34
        Me.Label35.Text = "1"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label36.Location = New System.Drawing.Point(261, 200)
        Me.Label36.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Padding = New System.Windows.Forms.Padding(5)
        Me.Label36.Size = New System.Drawing.Size(64, 40)
        Me.Label36.TabIndex = 35
        Me.Label36.Text = "1"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label37.Location = New System.Drawing.Point(326, 200)
        Me.Label37.Margin = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Padding = New System.Windows.Forms.Padding(5)
        Me.Label37.Size = New System.Drawing.Size(64, 40)
        Me.Label37.TabIndex = 36
        Me.Label37.Text = "1"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label38.Location = New System.Drawing.Point(391, 200)
        Me.Label38.Margin = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Padding = New System.Windows.Forms.Padding(5)
        Me.Label38.Size = New System.Drawing.Size(64, 40)
        Me.Label38.TabIndex = 37
        Me.Label38.Text = "1"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.White
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label39.Location = New System.Drawing.Point(1, 241)
        Me.Label39.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Label39.Name = "Label39"
        Me.Label39.Padding = New System.Windows.Forms.Padding(5)
        Me.Label39.Size = New System.Drawing.Size(64, 40)
        Me.Label39.TabIndex = 38
        Me.Label39.Text = "1"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label40.Location = New System.Drawing.Point(66, 241)
        Me.Label40.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Label40.Name = "Label40"
        Me.Label40.Padding = New System.Windows.Forms.Padding(5)
        Me.Label40.Size = New System.Drawing.Size(64, 40)
        Me.Label40.TabIndex = 39
        Me.Label40.Text = "1"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label42.Location = New System.Drawing.Point(131, 241)
        Me.Label42.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Label42.Name = "Label42"
        Me.Label42.Padding = New System.Windows.Forms.Padding(5)
        Me.Label42.Size = New System.Drawing.Size(64, 40)
        Me.Label42.TabIndex = 41
        Me.Label42.Text = "1"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label20.Location = New System.Drawing.Point(196, 241)
        Me.Label20.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(5)
        Me.Label20.Size = New System.Drawing.Size(64, 40)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "1"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label27.Location = New System.Drawing.Point(261, 241)
        Me.Label27.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Label27.Name = "Label27"
        Me.Label27.Padding = New System.Windows.Forms.Padding(5)
        Me.Label27.Size = New System.Drawing.Size(64, 40)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "1"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label34.Location = New System.Drawing.Point(326, 241)
        Me.Label34.Margin = New System.Windows.Forms.Padding(1, 1, 0, 1)
        Me.Label34.Name = "Label34"
        Me.Label34.Padding = New System.Windows.Forms.Padding(5)
        Me.Label34.Size = New System.Drawing.Size(64, 40)
        Me.Label34.TabIndex = 33
        Me.Label34.Text = "1"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label41.Location = New System.Drawing.Point(391, 241)
        Me.Label41.Margin = New System.Windows.Forms.Padding(1)
        Me.Label41.Name = "Label41"
        Me.Label41.Padding = New System.Windows.Forms.Padding(5)
        Me.Label41.Size = New System.Drawing.Size(64, 40)
        Me.Label41.TabIndex = 40
        Me.Label41.Text = "1"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 350)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 240)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "일정 리스트"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_START_TIME, Me.S_END_TIME, Me.SHARING, Me.SHARING_TYPE2, Me.REGISTRANT, Me.S_TITLE, Me.SHARING_TYPE, Me.S_DESC, Me.S_COMPANY_COWORKER, Me.S_WORKOUT_REASON, Me.S_WORKOUT_LOC})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(8, 17)
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
        Me.DataGridView1.Size = New System.Drawing.Size(452, 215)
        Me.DataGridView1.TabIndex = 1
        '
        'S_START_TIME
        '
        Me.S_START_TIME.DataPropertyName = "S_START_TIME"
        Me.S_START_TIME.HeaderText = "시작일시"
        Me.S_START_TIME.Name = "S_START_TIME"
        Me.S_START_TIME.ReadOnly = True
        '
        'S_END_TIME
        '
        Me.S_END_TIME.DataPropertyName = "S_END_TIME"
        Me.S_END_TIME.HeaderText = "종료일시"
        Me.S_END_TIME.Name = "S_END_TIME"
        Me.S_END_TIME.ReadOnly = True
        '
        'SHARING
        '
        Me.SHARING.DataPropertyName = "SHARING"
        Me.SHARING.HeaderText = "공유"
        Me.SHARING.Name = "SHARING"
        Me.SHARING.ReadOnly = True
        Me.SHARING.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SHARING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SHARING.Visible = False
        Me.SHARING.Width = 50
        '
        'SHARING_TYPE2
        '
        Me.SHARING_TYPE2.DataPropertyName = "SHARING_TYPE2"
        Me.SHARING_TYPE2.HeaderText = "구분"
        Me.SHARING_TYPE2.Name = "SHARING_TYPE2"
        Me.SHARING_TYPE2.ReadOnly = True
        Me.SHARING_TYPE2.Width = 70
        '
        'REGISTRANT
        '
        Me.REGISTRANT.DataPropertyName = "REGISTRANT"
        Me.REGISTRANT.HeaderText = "등록자"
        Me.REGISTRANT.Name = "REGISTRANT"
        Me.REGISTRANT.ReadOnly = True
        Me.REGISTRANT.Width = 80
        '
        'S_TITLE
        '
        Me.S_TITLE.DataPropertyName = "S_TITLE"
        Me.S_TITLE.HeaderText = "제목"
        Me.S_TITLE.Name = "S_TITLE"
        Me.S_TITLE.ReadOnly = True
        '
        'SHARING_TYPE
        '
        Me.SHARING_TYPE.DataPropertyName = "SHARING_TYPE"
        Me.SHARING_TYPE.HeaderText = "공유타입"
        Me.SHARING_TYPE.Name = "SHARING_TYPE"
        Me.SHARING_TYPE.ReadOnly = True
        Me.SHARING_TYPE.Visible = False
        '
        'S_DESC
        '
        Me.S_DESC.DataPropertyName = "S_DESC"
        Me.S_DESC.HeaderText = "내용"
        Me.S_DESC.Name = "S_DESC"
        Me.S_DESC.ReadOnly = True
        Me.S_DESC.Visible = False
        '
        'S_COMPANY_COWORKER
        '
        Me.S_COMPANY_COWORKER.DataPropertyName = "S_COMPANY_COWORKER"
        Me.S_COMPANY_COWORKER.HeaderText = "참석자"
        Me.S_COMPANY_COWORKER.Name = "S_COMPANY_COWORKER"
        Me.S_COMPANY_COWORKER.ReadOnly = True
        Me.S_COMPANY_COWORKER.Visible = False
        '
        'S_WORKOUT_REASON
        '
        Me.S_WORKOUT_REASON.DataPropertyName = "S_WORKOUT_REASON"
        Me.S_WORKOUT_REASON.HeaderText = "외근사유코드"
        Me.S_WORKOUT_REASON.Name = "S_WORKOUT_REASON"
        Me.S_WORKOUT_REASON.ReadOnly = True
        Me.S_WORKOUT_REASON.Visible = False
        '
        'S_WORKOUT_LOC
        '
        Me.S_WORKOUT_LOC.DataPropertyName = "S_WORKOUT_LOC"
        Me.S_WORKOUT_LOC.HeaderText = "외근지"
        Me.S_WORKOUT_LOC.Name = "S_WORKOUT_LOC"
        Me.S_WORKOUT_LOC.ReadOnly = True
        Me.S_WORKOUT_LOC.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.drpUser)
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.btnRemove2)
        Me.GroupBox2.Controls.Add(Me.btnAdd2)
        Me.GroupBox2.Controls.Add(Me.drpWReason)
        Me.GroupBox2.Controls.Add(Me.txtWLoc)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.drpGubun)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.drpTeam)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.chkSharing)
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.UserLB2)
        Me.GroupBox2.Controls.Add(Me.UserLB1)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.txtSchedule)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.drpMin2)
        Me.GroupBox2.Controls.Add(Me.drpHour2)
        Me.GroupBox2.Controls.Add(Me.DPDate2)
        Me.GroupBox2.Controls.Add(Me.Label69)
        Me.GroupBox2.Controls.Add(Me.drpMin1)
        Me.GroupBox2.Controls.Add(Me.drpHour1)
        Me.GroupBox2.Controls.Add(Me.DPDate1)
        Me.GroupBox2.Controls.Add(Me.Label70)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.Label71)
        Me.GroupBox2.Controls.Add(Me.UserLB3)
        Me.GroupBox2.Location = New System.Drawing.Point(499, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 597)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "일정 상세내용"
        '
        'drpUser
        '
        Me.drpUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpUser.Enabled = False
        Me.drpUser.FormattingEnabled = True
        Me.drpUser.Location = New System.Drawing.Point(82, 431)
        Me.drpUser.Name = "drpUser"
        Me.drpUser.Size = New System.Drawing.Size(200, 20)
        Me.drpUser.TabIndex = 157
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(23, 433)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(41, 12)
        Me.Label47.TabIndex = 156
        Me.Label47.Text = "외근자"
        '
        'btnRemove2
        '
        Me.btnRemove2.BackColor = System.Drawing.SystemColors.Control
        Me.btnRemove2.BackgroundImage = CType(resources.GetObject("btnRemove2.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnRemove2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemove2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRemove2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnRemove2.Location = New System.Drawing.Point(206, 375)
        Me.btnRemove2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemove2.Name = "btnRemove2"
        Me.btnRemove2.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove2.TabIndex = 155
        Me.btnRemove2.UseVisualStyleBackColor = False
        '
        'btnAdd2
        '
        Me.btnAdd2.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd2.BackgroundImage = CType(resources.GetObject("btnAdd2.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAdd2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd2.ImageIndex = 1
        Me.btnAdd2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnAdd2.Location = New System.Drawing.Point(206, 285)
        Me.btnAdd2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(25, 25)
        Me.btnAdd2.TabIndex = 154
        Me.btnAdd2.UseVisualStyleBackColor = False
        '
        'drpWReason
        '
        Me.drpWReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpWReason.Enabled = False
        Me.drpWReason.FormattingEnabled = True
        Me.drpWReason.Location = New System.Drawing.Point(82, 460)
        Me.drpWReason.Name = "drpWReason"
        Me.drpWReason.Size = New System.Drawing.Size(200, 20)
        Me.drpWReason.TabIndex = 153
        '
        'txtWLoc
        '
        Me.txtWLoc.Enabled = False
        Me.txtWLoc.Location = New System.Drawing.Point(82, 489)
        Me.txtWLoc.Name = "txtWLoc"
        Me.txtWLoc.Size = New System.Drawing.Size(275, 21)
        Me.txtWLoc.TabIndex = 151
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(23, 493)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(41, 12)
        Me.Label46.TabIndex = 150
        Me.Label46.Text = "외근지"
        '
        'drpGubun
        '
        Me.drpGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpGubun.FormattingEnabled = True
        Me.drpGubun.Location = New System.Drawing.Point(277, 50)
        Me.drpGubun.Name = "drpGubun"
        Me.drpGubun.Size = New System.Drawing.Size(80, 20)
        Me.drpGubun.TabIndex = 149
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(23, 463)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(53, 12)
        Me.Label45.TabIndex = 147
        Me.Label45.Text = "외근사유"
        '
        'drpTeam
        '
        Me.drpTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpTeam.FormattingEnabled = True
        Me.drpTeam.Location = New System.Drawing.Point(81, 237)
        Me.drpTeam.Name = "drpTeam"
        Me.drpTeam.Size = New System.Drawing.Size(115, 20)
        Me.drpTeam.TabIndex = 145
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(23, 240)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 12)
        Me.Label44.TabIndex = 144
        Me.Label44.Text = "팀명"
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.Control
        Me.btnDel.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDel.Location = New System.Drawing.Point(212, 529)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(45, 25)
        Me.btnDel.TabIndex = 141
        Me.btnDel.Text = "삭제"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(135, 529)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 25)
        Me.btnSave.TabIndex = 140
        Me.btnSave.Text = "저장"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkSharing
        '
        Me.chkSharing.Font = New System.Drawing.Font("굴림", 8.9!)
        Me.chkSharing.Location = New System.Drawing.Point(286, 78)
        Me.chkSharing.Name = "chkSharing"
        Me.chkSharing.Size = New System.Drawing.Size(55, 16)
        Me.chkSharing.TabIndex = 139
        Me.chkSharing.Text = "공유"
        Me.chkSharing.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.Control
        Me.btnRemove.BackgroundImage = CType(resources.GetObject("btnRemove.BackgroundImage"), System.Drawing.Image)
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRemove.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnRemove.Location = New System.Drawing.Point(206, 345)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove.TabIndex = 138
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd.ImageIndex = 1
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnAdd.Location = New System.Drawing.Point(206, 315)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(25, 25)
        Me.btnAdd.TabIndex = 137
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'UserLB2
        '
        Me.UserLB2.FormattingEnabled = True
        Me.UserLB2.ItemHeight = 12
        Me.UserLB2.Location = New System.Drawing.Point(240, 265)
        Me.UserLB2.Name = "UserLB2"
        Me.UserLB2.Size = New System.Drawing.Size(115, 160)
        Me.UserLB2.TabIndex = 136
        '
        'UserLB1
        '
        Me.UserLB1.FormattingEnabled = True
        Me.UserLB1.ItemHeight = 12
        Me.UserLB1.Location = New System.Drawing.Point(82, 265)
        Me.UserLB1.Name = "UserLB1"
        Me.UserLB1.Size = New System.Drawing.Size(115, 160)
        Me.UserLB1.TabIndex = 135
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(23, 268)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(41, 12)
        Me.Label67.TabIndex = 134
        Me.Label67.Text = "참석자"
        '
        'txtSchedule
        '
        Me.txtSchedule.Location = New System.Drawing.Point(81, 105)
        Me.txtSchedule.Multiline = True
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(273, 125)
        Me.txtSchedule.TabIndex = 133
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(22, 107)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(29, 12)
        Me.Label68.TabIndex = 132
        Me.Label68.Text = "내용"
        '
        'drpMin2
        '
        Me.drpMin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpMin2.FormattingEnabled = True
        Me.drpMin2.Location = New System.Drawing.Point(222, 77)
        Me.drpMin2.Name = "drpMin2"
        Me.drpMin2.Size = New System.Drawing.Size(40, 20)
        Me.drpMin2.TabIndex = 131
        '
        'drpHour2
        '
        Me.drpHour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpHour2.FormattingEnabled = True
        Me.drpHour2.Location = New System.Drawing.Point(176, 77)
        Me.drpHour2.Name = "drpHour2"
        Me.drpHour2.Size = New System.Drawing.Size(40, 20)
        Me.drpHour2.TabIndex = 130
        '
        'DPDate2
        '
        Me.DPDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate2.Location = New System.Drawing.Point(81, 77)
        Me.DPDate2.Name = "DPDate2"
        Me.DPDate2.Size = New System.Drawing.Size(90, 21)
        Me.DPDate2.TabIndex = 129
        Me.DPDate2.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(22, 81)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(53, 12)
        Me.Label69.TabIndex = 128
        Me.Label69.Text = "종료일시"
        '
        'drpMin1
        '
        Me.drpMin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpMin1.FormattingEnabled = True
        Me.drpMin1.Location = New System.Drawing.Point(222, 50)
        Me.drpMin1.Name = "drpMin1"
        Me.drpMin1.Size = New System.Drawing.Size(40, 20)
        Me.drpMin1.TabIndex = 127
        '
        'drpHour1
        '
        Me.drpHour1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpHour1.FormattingEnabled = True
        Me.drpHour1.Location = New System.Drawing.Point(176, 50)
        Me.drpHour1.Name = "drpHour1"
        Me.drpHour1.Size = New System.Drawing.Size(40, 20)
        Me.drpHour1.TabIndex = 126
        '
        'DPDate1
        '
        Me.DPDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate1.Location = New System.Drawing.Point(81, 50)
        Me.DPDate1.Name = "DPDate1"
        Me.DPDate1.Size = New System.Drawing.Size(90, 21)
        Me.DPDate1.TabIndex = 125
        Me.DPDate1.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(22, 54)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(53, 12)
        Me.Label70.TabIndex = 124
        Me.Label70.Text = "시작일시"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(81, 22)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(275, 21)
        Me.txtTitle.TabIndex = 123
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(22, 26)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(29, 12)
        Me.Label71.TabIndex = 122
        Me.Label71.Text = "제목"
        '
        'UserLB3
        '
        Me.UserLB3.FormattingEnabled = True
        Me.UserLB3.ItemHeight = 12
        Me.UserLB3.Location = New System.Drawing.Point(19, 531)
        Me.UserLB3.Name = "UserLB3"
        Me.UserLB3.Size = New System.Drawing.Size(100, 40)
        Me.UserLB3.TabIndex = 146
        Me.UserLB3.Visible = False
        '
        'DPYear
        '
        Me.DPYear.CustomFormat = "yyyy"
        Me.DPYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPYear.Location = New System.Drawing.Point(159, 9)
        Me.DPYear.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
        Me.DPYear.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.DPYear.Name = "DPYear"
        Me.DPYear.ShowUpDown = True
        Me.DPYear.Size = New System.Drawing.Size(70, 21)
        Me.DPYear.TabIndex = 126
        Me.DPYear.Value = New Date(2011, 8, 1, 0, 0, 0, 0)
        '
        'DPMonth
        '
        Me.DPMonth.CustomFormat = "MM"
        Me.DPMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPMonth.Location = New System.Drawing.Point(243, 9)
        Me.DPMonth.MaxDate = New Date(2500, 12, 31, 0, 0, 0, 0)
        Me.DPMonth.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.DPMonth.Name = "DPMonth"
        Me.DPMonth.ShowUpDown = True
        Me.DPMonth.Size = New System.Drawing.Size(70, 21)
        Me.DPMonth.TabIndex = 127
        Me.DPMonth.Value = New Date(2011, 8, 31, 0, 0, 0, 0)
        '
        'btn_today
        '
        Me.btn_today.Location = New System.Drawing.Point(337, 7)
        Me.btn_today.Name = "btn_today"
        Me.btn_today.Size = New System.Drawing.Size(45, 25)
        Me.btn_today.TabIndex = 128
        Me.btn_today.Text = "오늘"
        Me.btn_today.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(57, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.TabIndex = 130
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'FRM_SCHEDULE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_today)
        Me.Controls.Add(Me.DPMonth)
        Me.Controls.Add(Me.DPYear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_SCHEDULE"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "일정관리"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents UserLB2 As System.Windows.Forms.ListBox
    Friend WithEvents UserLB1 As System.Windows.Forms.ListBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtSchedule As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents drpMin2 As System.Windows.Forms.ComboBox
    Friend WithEvents drpHour2 As System.Windows.Forms.ComboBox
    Friend WithEvents DPDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents drpMin1 As System.Windows.Forms.ComboBox
    Friend WithEvents drpHour1 As System.Windows.Forms.ComboBox
    Friend WithEvents DPDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents chkSharing As System.Windows.Forms.CheckBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DPYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_today As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents drpTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents UserLB3 As System.Windows.Forms.ListBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents drpGubun As System.Windows.Forms.ComboBox
    Friend WithEvents txtWLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents drpWReason As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemove2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents drpUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents S_START_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_END_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHARING As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SHARING_TYPE2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGISTRANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TITLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHARING_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_COMPANY_COWORKER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_WORKOUT_REASON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_WORKOUT_LOC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
