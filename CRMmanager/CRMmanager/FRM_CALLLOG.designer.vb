<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CALLLOG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CALLLOG))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.drpMin2 = New System.Windows.Forms.ComboBox
        Me.drpHour2 = New System.Windows.Forms.ComboBox
        Me.drpMin1 = New System.Windows.Forms.ComboBox
        Me.drpHour1 = New System.Windows.Forms.ComboBox
        Me.txtExtNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTongNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.drpCalltype = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DPDate2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DPDate1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.START_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.END_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DURATION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXTENSION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALL_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ANI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALL_RESULT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALL_TYPE2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALL_RESULT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.drpMin2)
        Me.GroupBox1.Controls.Add(Me.drpHour2)
        Me.GroupBox1.Controls.Add(Me.drpMin1)
        Me.GroupBox1.Controls.Add(Me.drpHour1)
        Me.GroupBox1.Controls.Add(Me.txtExtNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTongNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.drpCalltype)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DPDate2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DPDate1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 78)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(552, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 12)
        Me.Label8.TabIndex = 186
        '
        'Label7
        '
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(285, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 12)
        Me.Label7.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(15, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 12)
        Me.Label6.TabIndex = 184
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(343, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 12)
        Me.Label4.TabIndex = 183
        '
        'Label30
        '
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(15, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 182
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(816, 26)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 181
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'drpMin2
        '
        Me.drpMin2.BackColor = System.Drawing.Color.MintCream
        Me.drpMin2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpMin2.FormattingEnabled = True
        Me.drpMin2.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50", "59"})
        Me.drpMin2.Location = New System.Drawing.Point(565, 19)
        Me.drpMin2.Name = "drpMin2"
        Me.drpMin2.Size = New System.Drawing.Size(40, 20)
        Me.drpMin2.TabIndex = 101
        '
        'drpHour2
        '
        Me.drpHour2.BackColor = System.Drawing.Color.MintCream
        Me.drpHour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpHour2.FormattingEnabled = True
        Me.drpHour2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.drpHour2.Location = New System.Drawing.Point(519, 19)
        Me.drpHour2.Name = "drpHour2"
        Me.drpHour2.Size = New System.Drawing.Size(40, 20)
        Me.drpHour2.TabIndex = 100
        '
        'drpMin1
        '
        Me.drpMin1.BackColor = System.Drawing.Color.MintCream
        Me.drpMin1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpMin1.FormattingEnabled = True
        Me.drpMin1.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50", "59"})
        Me.drpMin1.Location = New System.Drawing.Point(460, 19)
        Me.drpMin1.Name = "drpMin1"
        Me.drpMin1.Size = New System.Drawing.Size(40, 20)
        Me.drpMin1.TabIndex = 99
        '
        'drpHour1
        '
        Me.drpHour1.BackColor = System.Drawing.Color.MintCream
        Me.drpHour1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpHour1.FormattingEnabled = True
        Me.drpHour1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.drpHour1.Location = New System.Drawing.Point(414, 19)
        Me.drpHour1.Name = "drpHour1"
        Me.drpHour1.Size = New System.Drawing.Size(40, 20)
        Me.drpHour1.TabIndex = 98
        '
        'txtExtNo
        '
        Me.txtExtNo.Location = New System.Drawing.Point(620, 50)
        Me.txtExtNo.Name = "txtExtNo"
        Me.txtExtNo.Size = New System.Drawing.Size(115, 21)
        Me.txtExtNo.TabIndex = 96
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(506, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 12)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "~"
        '
        'txtTongNo
        '
        Me.txtTongNo.Location = New System.Drawing.Point(84, 50)
        Me.txtTongNo.Name = "txtTongNo"
        Me.txtTongNo.Size = New System.Drawing.Size(115, 21)
        Me.txtTongNo.TabIndex = 90
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "전화번호"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(565, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "내선번호"
        '
        'drpCalltype
        '
        Me.drpCalltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpCalltype.FormattingEnabled = True
        Me.drpCalltype.Location = New System.Drawing.Point(342, 50)
        Me.drpCalltype.Name = "drpCalltype"
        Me.drpCalltype.Size = New System.Drawing.Size(115, 20)
        Me.drpCalltype.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(295, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 12)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "콜타입"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "통화시간"
        '
        'DPDate2
        '
        Me.DPDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate2.Location = New System.Drawing.Point(208, 19)
        Me.DPDate2.Name = "DPDate2"
        Me.DPDate2.Size = New System.Drawing.Size(112, 21)
        Me.DPDate2.TabIndex = 44
        Me.DPDate2.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 12)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "~"
        '
        'DPDate1
        '
        Me.DPDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPDate1.Location = New System.Drawing.Point(84, 19)
        Me.DPDate1.Name = "DPDate1"
        Me.DPDate1.Size = New System.Drawing.Size(112, 21)
        Me.DPDate1.TabIndex = 42
        Me.DPDate1.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "통화일자"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.START_TIME, Me.END_TIME, Me.DURATION, Me.EXTENSION, Me.CALL_TYPE, Me.ANI, Me.CALL_RESULT, Me.CALL_TYPE2, Me.CALL_RESULT2})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(12, 96)
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
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(872, 568)
        Me.DataGridView1.TabIndex = 88
        '
        'START_TIME
        '
        Me.START_TIME.DataPropertyName = "TONG_START_TIME"
        Me.START_TIME.HeaderText = "통화시작시간"
        Me.START_TIME.Name = "START_TIME"
        Me.START_TIME.ReadOnly = True
        Me.START_TIME.Width = 150
        '
        'END_TIME
        '
        Me.END_TIME.DataPropertyName = "TONG_END_TIME"
        Me.END_TIME.HeaderText = "통화종료시간"
        Me.END_TIME.Name = "END_TIME"
        Me.END_TIME.ReadOnly = True
        Me.END_TIME.Width = 150
        '
        'DURATION
        '
        Me.DURATION.DataPropertyName = "TONG_DURATION"
        Me.DURATION.HeaderText = "통화기간"
        Me.DURATION.Name = "DURATION"
        Me.DURATION.ReadOnly = True
        Me.DURATION.Width = 80
        '
        'EXTENSION
        '
        Me.EXTENSION.DataPropertyName = "EXTENSION_NO"
        Me.EXTENSION.HeaderText = "내선번호"
        Me.EXTENSION.Name = "EXTENSION"
        Me.EXTENSION.ReadOnly = True
        Me.EXTENSION.Width = 80
        '
        'CALL_TYPE
        '
        Me.CALL_TYPE.DataPropertyName = "CALL_TYPE_NAME"
        Me.CALL_TYPE.HeaderText = "콜타입"
        Me.CALL_TYPE.Name = "CALL_TYPE"
        Me.CALL_TYPE.ReadOnly = True
        '
        'ANI
        '
        Me.ANI.DataPropertyName = "ANI"
        Me.ANI.HeaderText = "전화번호"
        Me.ANI.Name = "ANI"
        Me.ANI.ReadOnly = True
        '
        'CALL_RESULT
        '
        Me.CALL_RESULT.DataPropertyName = "CALL_RESULT_NAME"
        Me.CALL_RESULT.HeaderText = "통화결과"
        Me.CALL_RESULT.Name = "CALL_RESULT"
        Me.CALL_RESULT.ReadOnly = True
        Me.CALL_RESULT.Width = 120
        '
        'CALL_TYPE2
        '
        Me.CALL_TYPE2.DataPropertyName = "CALL_TYPE"
        Me.CALL_TYPE2.HeaderText = "콜타입2"
        Me.CALL_TYPE2.Name = "CALL_TYPE2"
        Me.CALL_TYPE2.ReadOnly = True
        Me.CALL_TYPE2.Visible = False
        Me.CALL_TYPE2.Width = 60
        '
        'CALL_RESULT2
        '
        Me.CALL_RESULT2.DataPropertyName = "CALL_RESULT"
        Me.CALL_RESULT2.HeaderText = "통화결과2"
        Me.CALL_RESULT2.Name = "CALL_RESULT2"
        Me.CALL_RESULT2.ReadOnly = True
        Me.CALL_RESULT2.Visible = False
        Me.CALL_RESULT2.Width = 60
        '
        'FRM_CALLLOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_CALLLOG"
        Me.Text = "콜로그 조회"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTongNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents drpCalltype As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DPDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DPDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExtNo As System.Windows.Forms.TextBox
    Friend WithEvents drpMin2 As System.Windows.Forms.ComboBox
    Friend WithEvents drpHour2 As System.Windows.Forms.ComboBox
    Friend WithEvents drpMin1 As System.Windows.Forms.ComboBox
  Friend WithEvents drpHour1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents START_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents END_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DURATION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXTENSION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALL_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ANI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALL_RESULT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALL_TYPE2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALL_RESULT2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
