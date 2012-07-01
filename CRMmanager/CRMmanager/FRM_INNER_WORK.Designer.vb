<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INNER_WORK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_INNER_WORK))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboGubun = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnInit22 = New System.Windows.Forms.Button
        Me.btnClose22 = New System.Windows.Forms.Button
        Me.btnContentsSave = New System.Windows.Forms.Button
        Me.txtCHPerson = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DPDate22 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DPDate11 = New System.Windows.Forms.DateTimePicker
        Me.Label70 = New System.Windows.Forms.Label
        Me.btnSelect1 = New System.Windows.Forms.Button
        Me.Label30 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LabAddr2 = New System.Windows.Forms.Label
        Me.txtCName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCID = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtJupsuJa = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DPDate33 = New System.Windows.Forms.DateTimePicker
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtJupsuContents = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnExcel = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.cboGubun)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCHPerson)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DPDate22)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DPDate11)
        Me.GroupBox1.Controls.Add(Me.Label70)
        Me.GroupBox1.Controls.Add(Me.btnSelect1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(866, 54)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cboGubun
        '
        Me.cboGubun.FormattingEnabled = True
        Me.cboGubun.Items.AddRange(New Object() {"전체", "접수중/미처리", "처리"})
        Me.cboGubun.Location = New System.Drawing.Point(357, 20)
        Me.cboGubun.Name = "cboGubun"
        Me.cboGubun.Size = New System.Drawing.Size(103, 20)
        Me.cboGubun.TabIndex = 237
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 236
        Me.Label7.Text = "접수구분"
        '
        'Label8
        '
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(293, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 12)
        Me.Label8.TabIndex = 235
        '
        'btnInit22
        '
        Me.btnInit22.BackColor = System.Drawing.SystemColors.Control
        Me.btnInit22.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnInit22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInit22.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnInit22.Location = New System.Drawing.Point(757, 20)
        Me.btnInit22.Name = "btnInit22"
        Me.btnInit22.Size = New System.Drawing.Size(52, 25)
        Me.btnInit22.TabIndex = 234
        Me.btnInit22.Text = "초기화"
        Me.btnInit22.UseVisualStyleBackColor = False
        '
        'btnClose22
        '
        Me.btnClose22.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose22.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose22.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnClose22.Location = New System.Drawing.Point(809, 20)
        Me.btnClose22.Name = "btnClose22"
        Me.btnClose22.Size = New System.Drawing.Size(45, 25)
        Me.btnClose22.TabIndex = 233
        Me.btnClose22.Text = "닫기"
        Me.btnClose22.UseVisualStyleBackColor = False
        '
        'btnContentsSave
        '
        Me.btnContentsSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnContentsSave.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnContentsSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnContentsSave.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnContentsSave.Location = New System.Drawing.Point(712, 20)
        Me.btnContentsSave.Name = "btnContentsSave"
        Me.btnContentsSave.Size = New System.Drawing.Size(45, 25)
        Me.btnContentsSave.TabIndex = 227
        Me.btnContentsSave.Text = "저장"
        Me.btnContentsSave.UseVisualStyleBackColor = False
        '
        'txtCHPerson
        '
        Me.txtCHPerson.Location = New System.Drawing.Point(525, 20)
        Me.txtCHPerson.Name = "txtCHPerson"
        Me.txtCHPerson.Size = New System.Drawing.Size(115, 21)
        Me.txtCHPerson.TabIndex = 191
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "처리자"
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(466, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 12)
        Me.Label3.TabIndex = 189
        '
        'DPDate22
        '
        Me.DPDate22.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate22.Location = New System.Drawing.Point(191, 20)
        Me.DPDate22.Name = "DPDate22"
        Me.DPDate22.Size = New System.Drawing.Size(90, 21)
        Me.DPDate22.TabIndex = 186
        Me.DPDate22.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 12)
        Me.Label1.TabIndex = 185
        Me.Label1.Text = "~"
        '
        'DPDate11
        '
        Me.DPDate11.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate11.Location = New System.Drawing.Point(75, 20)
        Me.DPDate11.Name = "DPDate11"
        Me.DPDate11.Size = New System.Drawing.Size(90, 21)
        Me.DPDate11.TabIndex = 184
        Me.DPDate11.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(18, 24)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(53, 12)
        Me.Label70.TabIndex = 183
        Me.Label70.Text = "접수일자"
        '
        'btnSelect1
        '
        Me.btnSelect1.Location = New System.Drawing.Point(760, 18)
        Me.btnSelect1.Name = "btnSelect1"
        Me.btnSelect1.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect1.TabIndex = 182
        Me.btnSelect1.Text = "조회"
        Me.btnSelect1.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(6, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 106
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.Column3})
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView2.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(866, 445)
        Me.DataGridView2.TabIndex = 121
        '
        'Column1
        '
        Me.Column1.HeaderText = "접수번호"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "고객"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "처리결과"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "접수일자"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "접수자"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "접수내용"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "처리일자"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "처리자"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "처리내용"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "고객아이디"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabAddr2)
        Me.GroupBox2.Controls.Add(Me.txtCName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnInit22)
        Me.GroupBox2.Controls.Add(Me.txtCID)
        Me.GroupBox2.Controls.Add(Me.btnClose22)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnContentsSave)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtJupsuJa)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DPDate33)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.txtJupsuContents)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 527)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 134)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[접수이력등록]"
        '
        'LabAddr2
        '
        Me.LabAddr2.AutoSize = True
        Me.LabAddr2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabAddr2.Location = New System.Drawing.Point(444, 17)
        Me.LabAddr2.Name = "LabAddr2"
        Me.LabAddr2.Size = New System.Drawing.Size(221, 12)
        Me.LabAddr2.TabIndex = 234
        Me.LabAddr2.Text = "[ 고객 이름 입력후 엔터키를 누르세요 ]"
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(530, 33)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(129, 21)
        Me.txtCName.TabIndex = 230
        '
        'Label6
        '
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(398, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 12)
        Me.Label6.TabIndex = 233
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(446, 33)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(78, 21)
        Me.txtCID.TabIndex = 229
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(411, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 231
        Me.Label15.Text = "고객"
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(208, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 12)
        Me.Label4.TabIndex = 230
        '
        'txtJupsuJa
        '
        Me.txtJupsuJa.Location = New System.Drawing.Point(266, 33)
        Me.txtJupsuJa.Name = "txtJupsuJa"
        Me.txtJupsuJa.ReadOnly = True
        Me.txtJupsuJa.Size = New System.Drawing.Size(127, 21)
        Me.txtJupsuJa.TabIndex = 228
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "접수자"
        '
        'DPDate33
        '
        Me.DPDate33.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate33.Location = New System.Drawing.Point(87, 33)
        Me.DPDate33.Name = "DPDate33"
        Me.DPDate33.Size = New System.Drawing.Size(90, 21)
        Me.DPDate33.TabIndex = 227
        Me.DPDate33.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label44
        '
        Me.Label44.Image = CType(resources.GetObject("Label44.Image"), System.Drawing.Image)
        Me.Label44.Location = New System.Drawing.Point(18, 37)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(13, 12)
        Me.Label44.TabIndex = 192
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(28, 37)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(53, 12)
        Me.Label45.TabIndex = 190
        Me.Label45.Text = "접수일자"
        '
        'Label39
        '
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(17, 75)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 12)
        Me.Label39.TabIndex = 183
        '
        'txtJupsuContents
        '
        Me.txtJupsuContents.Location = New System.Drawing.Point(87, 62)
        Me.txtJupsuContents.Multiline = True
        Me.txtJupsuContents.Name = "txtJupsuContents"
        Me.txtJupsuContents.Size = New System.Drawing.Size(768, 55)
        Me.txtJupsuContents.TabIndex = 231
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "접수내용"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(808, 18)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(45, 25)
        Me.btnExcel.TabIndex = 238
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "c"
        '
        'FRM_INNER_WORK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_INNER_WORK"
        Me.Text = "직원업무일지"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelect1 As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DPDate22 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DPDate11 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCHPerson As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtJupsuContents As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DPDate33 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJupsuJa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose22 As System.Windows.Forms.Button
    Friend WithEvents btnContentsSave As System.Windows.Forms.Button
    Friend WithEvents txtCName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnInit22 As System.Windows.Forms.Button
    Friend WithEvents LabAddr2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboGubun As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
