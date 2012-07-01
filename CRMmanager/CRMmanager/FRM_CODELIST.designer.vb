<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CODELIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CODELIST))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.drpMod = New System.Windows.Forms.ComboBox
        Me.txtScodenm = New System.Windows.Forms.TextBox
        Me.txtScode = New System.Windows.Forms.TextBox
        Me.txtLcodenm = New System.Windows.Forms.TextBox
        Me.txtLcode = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.TreeView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 615)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[ 코드 리스트 ]"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(310, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(265, 320)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label44)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label45)
        Me.TabPage1.Controls.Add(Me.Label46)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.drpMod)
        Me.TabPage1.Controls.Add(Me.txtScodenm)
        Me.TabPage1.Controls.Add(Me.txtScode)
        Me.TabPage1.Controls.Add(Me.txtLcodenm)
        Me.TabPage1.Controls.Add(Me.txtLcode)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label43)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(257, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "코드 정보"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(24, 123)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(81, 12)
        Me.Label44.TabIndex = 134
        Me.Label44.Text = "소분류 코드명"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(24, 55)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 12)
        Me.Label27.TabIndex = 120
        Me.Label27.Text = "대분류 코드명"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(24, 157)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(57, 12)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "수정 가능"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(24, 89)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(69, 12)
        Me.Label45.TabIndex = 28
        Me.Label45.Text = "소분류 코드"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(24, 21)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(69, 12)
        Me.Label46.TabIndex = 24
        Me.Label46.Text = "대분류 코드"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnSave.Location = New System.Drawing.Point(76, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 25)
        Me.btnSave.TabIndex = 146
        Me.btnSave.Text = "저장"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnDelete.Location = New System.Drawing.Point(142, 227)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 25)
        Me.btnDelete.TabIndex = 145
        Me.btnDelete.Text = "삭제"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'drpMod
        '
        Me.drpMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpMod.FormattingEnabled = True
        Me.drpMod.Items.AddRange(New Object() {"Y", "N"})
        Me.drpMod.Location = New System.Drawing.Point(116, 150)
        Me.drpMod.Name = "drpMod"
        Me.drpMod.Size = New System.Drawing.Size(60, 20)
        Me.drpMod.TabIndex = 141
        '
        'txtScodenm
        '
        Me.txtScodenm.Location = New System.Drawing.Point(116, 117)
        Me.txtScodenm.Name = "txtScodenm"
        Me.txtScodenm.Size = New System.Drawing.Size(115, 21)
        Me.txtScodenm.TabIndex = 140
        '
        'txtScode
        '
        Me.txtScode.Location = New System.Drawing.Point(116, 84)
        Me.txtScode.Name = "txtScode"
        Me.txtScode.Size = New System.Drawing.Size(115, 21)
        Me.txtScode.TabIndex = 139
        '
        'txtLcodenm
        '
        Me.txtLcodenm.Location = New System.Drawing.Point(116, 51)
        Me.txtLcodenm.Name = "txtLcodenm"
        Me.txtLcodenm.Size = New System.Drawing.Size(115, 21)
        Me.txtLcodenm.TabIndex = 138
        '
        'txtLcode
        '
        Me.txtLcode.Location = New System.Drawing.Point(116, 18)
        Me.txtLcode.Name = "txtLcode"
        Me.txtLcode.Size = New System.Drawing.Size(115, 21)
        Me.txtLcode.TabIndex = 137
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(11, 61)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 12)
        Me.Label26.TabIndex = 122
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(216, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 12)
        Me.Label24.TabIndex = 119
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
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(11, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 12)
        Me.Label13.TabIndex = 106
        '
        'Label43
        '
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.Location = New System.Drawing.Point(11, 123)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(13, 12)
        Me.Label43.TabIndex = 136
        '
        'Label32
        '
        Me.Label32.Image = CType(resources.GetObject("Label32.Image"), System.Drawing.Image)
        Me.Label32.Location = New System.Drawing.Point(11, 89)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 12)
        Me.Label32.TabIndex = 125
        '
        'Label29
        '
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.Location = New System.Drawing.Point(11, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 12)
        Me.Label29.TabIndex = 123
        '
        'Label31
        '
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.Location = New System.Drawing.Point(11, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 12)
        Me.Label31.TabIndex = 124
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(11, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 12)
        Me.Label14.TabIndex = 107
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(11, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 12)
        Me.Label15.TabIndex = 108
        '
        'Label33
        '
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.Location = New System.Drawing.Point(11, 157)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 12)
        Me.Label33.TabIndex = 126
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(17, 22)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(279, 510)
        Me.TreeView1.TabIndex = 35
        '
        'FRM_CODELIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_CODELIST"
        Me.Text = "코드관리"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents drpMod As System.Windows.Forms.ComboBox
    Friend WithEvents txtScodenm As System.Windows.Forms.TextBox
    Friend WithEvents txtScode As System.Windows.Forms.TextBox
    Friend WithEvents txtLcodenm As System.Windows.Forms.TextBox
    Friend WithEvents txtLcode As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
