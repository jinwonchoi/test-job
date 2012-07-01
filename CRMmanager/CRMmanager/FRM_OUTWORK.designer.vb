<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_OUTWORK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_OUTWORK))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.cboUser = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.cboWorkReason1 = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.dpt2 = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dpt1 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.dpt3 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWorkArea = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtWorkContents = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboWorkReason2 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.drpMin11 = New System.Windows.Forms.ComboBox
        Me.drpHour11 = New System.Windows.Forms.ComboBox
        Me.btnCloseForm = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.cboUser1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnExcel = New System.Windows.Forms.Button
        Me.CUSTOMER_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSTOMER_NM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_TELNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.H_TELNO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FAX_NO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.cboUser)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.cboWorkReason1)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.dpt2)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dpt1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 55)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(759, 20)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 214
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cboUser
        '
        Me.cboUser.BackColor = System.Drawing.Color.MintCream
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(368, 22)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(105, 20)
        Me.cboUser.TabIndex = 211
        '
        'Label27
        '
        Me.Label27.Image = CType(resources.GetObject("Label27.Image"), System.Drawing.Image)
        Me.Label27.Location = New System.Drawing.Point(314, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 12)
        Me.Label27.TabIndex = 210
        '
        'cboWorkReason1
        '
        Me.cboWorkReason1.BackColor = System.Drawing.Color.MintCream
        Me.cboWorkReason1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWorkReason1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboWorkReason1.FormattingEnabled = True
        Me.cboWorkReason1.Location = New System.Drawing.Point(543, 22)
        Me.cboWorkReason1.Name = "cboWorkReason1"
        Me.cboWorkReason1.Size = New System.Drawing.Size(183, 20)
        Me.cboWorkReason1.TabIndex = 50
        '
        'Label34
        '
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.Location = New System.Drawing.Point(479, 26)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 12)
        Me.Label34.TabIndex = 207
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "외근자"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(491, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 203
        Me.Label15.Text = "외근사유"
        '
        'dpt2
        '
        Me.dpt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt2.Location = New System.Drawing.Point(203, 22)
        Me.dpt2.Name = "dpt2"
        Me.dpt2.Size = New System.Drawing.Size(91, 21)
        Me.dpt2.TabIndex = 43
        Me.dpt2.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label24
        '
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(6, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 12)
        Me.Label24.TabIndex = 199
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(186, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 12)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "~"
        '
        'dpt1
        '
        Me.dpt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt1.Location = New System.Drawing.Point(89, 22)
        Me.dpt1.Name = "dpt1"
        Me.dpt1.Size = New System.Drawing.Size(91, 21)
        Me.dpt1.TabIndex = 42
        Me.dpt1.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "외근일자"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMER_ID, Me.CUSTOMER_NM, Me.C_TELNO, Me.H_TELNO, Me.FAX_NO})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(872, 400)
        Me.DataGridView1.TabIndex = 119
        '
        'dpt3
        '
        Me.dpt3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpt3.Location = New System.Drawing.Point(79, 23)
        Me.dpt3.Name = "dpt3"
        Me.dpt3.Size = New System.Drawing.Size(112, 21)
        Me.dpt3.TabIndex = 119
        Me.dpt3.Value = New Date(2011, 7, 12, 20, 59, 36, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "외근지"
        '
        'txtWorkArea
        '
        Me.txtWorkArea.Location = New System.Drawing.Point(79, 52)
        Me.txtWorkArea.Name = "txtWorkArea"
        Me.txtWorkArea.Size = New System.Drawing.Size(607, 21)
        Me.txtWorkArea.TabIndex = 123
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "세부사항"
        '
        'txtWorkContents
        '
        Me.txtWorkContents.Location = New System.Drawing.Point(79, 79)
        Me.txtWorkContents.Multiline = True
        Me.txtWorkContents.Name = "txtWorkContents"
        Me.txtWorkContents.Size = New System.Drawing.Size(607, 84)
        Me.txtWorkContents.TabIndex = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 200
        Me.Label7.Text = "외근일자"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(298, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 209
        Me.Label11.Text = "외근사유"
        '
        'cboWorkReason2
        '
        Me.cboWorkReason2.BackColor = System.Drawing.Color.MintCream
        Me.cboWorkReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWorkReason2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboWorkReason2.FormattingEnabled = True
        Me.cboWorkReason2.Location = New System.Drawing.Point(350, 23)
        Me.cboWorkReason2.Name = "cboWorkReason2"
        Me.cboWorkReason2.Size = New System.Drawing.Size(167, 20)
        Me.cboWorkReason2.TabIndex = 208
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.drpMin11)
        Me.GroupBox2.Controls.Add(Me.drpHour11)
        Me.GroupBox2.Controls.Add(Me.btnCloseForm)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.cboUser1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboWorkReason2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtWorkContents)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtWorkArea)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dpt3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 491)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(872, 176)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[ 외근사유 등록 ]"
        '
        'drpMin11
        '
        Me.drpMin11.FormattingEnabled = True
        Me.drpMin11.Location = New System.Drawing.Point(243, 23)
        Me.drpMin11.Name = "drpMin11"
        Me.drpMin11.Size = New System.Drawing.Size(40, 20)
        Me.drpMin11.TabIndex = 226
        '
        'drpHour11
        '
        Me.drpHour11.FormattingEnabled = True
        Me.drpHour11.Location = New System.Drawing.Point(197, 23)
        Me.drpHour11.Name = "drpHour11"
        Me.drpHour11.Size = New System.Drawing.Size(40, 20)
        Me.drpHour11.TabIndex = 225
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.SystemColors.Control
        Me.btnCloseForm.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCloseForm.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnCloseForm.Location = New System.Drawing.Point(812, 55)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(45, 25)
        Me.btnCloseForm.TabIndex = 224
        Me.btnCloseForm.Text = "닫기"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnSave.Location = New System.Drawing.Point(710, 55)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 25)
        Me.btnSave.TabIndex = 223
        Me.btnSave.Text = "저장"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(761, 55)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 25)
        Me.btnDelete.TabIndex = 222
        Me.btnDelete.Text = "삭제"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboUser1
        '
        Me.cboUser1.BackColor = System.Drawing.Color.MintCream
        Me.cboUser1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboUser1.FormattingEnabled = True
        Me.cboUser1.Location = New System.Drawing.Point(589, 23)
        Me.cboUser1.Name = "cboUser1"
        Me.cboUser1.Size = New System.Drawing.Size(97, 20)
        Me.cboUser1.TabIndex = 218
        '
        'Label6
        '
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(523, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 12)
        Me.Label6.TabIndex = 217
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(542, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 216
        Me.Label12.Text = "외근자"
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(6, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 212
        '
        'Label5
        '
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 12)
        Me.Label5.TabIndex = 211
        '
        'Label10
        '
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(286, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 12)
        Me.Label10.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 12)
        Me.Label3.TabIndex = 201
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(807, 20)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(45, 25)
        Me.btnExcel.TabIndex = 239
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'CUSTOMER_ID
        '
        Me.CUSTOMER_ID.HeaderText = "외근일시"
        Me.CUSTOMER_ID.Name = "CUSTOMER_ID"
        Me.CUSTOMER_ID.ReadOnly = True
        Me.CUSTOMER_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CUSTOMER_ID.Width = 120
        '
        'CUSTOMER_NM
        '
        Me.CUSTOMER_NM.HeaderText = "외근자"
        Me.CUSTOMER_NM.Name = "CUSTOMER_NM"
        Me.CUSTOMER_NM.ReadOnly = True
        '
        'C_TELNO
        '
        Me.C_TELNO.HeaderText = "외근사유"
        Me.C_TELNO.Name = "C_TELNO"
        Me.C_TELNO.ReadOnly = True
        Me.C_TELNO.Width = 150
        '
        'H_TELNO
        '
        Me.H_TELNO.HeaderText = "외근지"
        Me.H_TELNO.Name = "H_TELNO"
        Me.H_TELNO.ReadOnly = True
        Me.H_TELNO.Width = 200
        '
        'FAX_NO
        '
        Me.FAX_NO.HeaderText = "외근내용"
        Me.FAX_NO.Name = "FAX_NO"
        Me.FAX_NO.ReadOnly = True
        Me.FAX_NO.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FAX_NO.Width = 300
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "c"
        '
        'FRM_OUTWORK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_OUTWORK"
        Me.Text = "외근관리"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboWorkReason1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dpt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dpt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dpt3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWorkArea As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtWorkContents As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboWorkReason2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUser1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
    Friend WithEvents drpMin11 As System.Windows.Forms.ComboBox
    Friend WithEvents drpHour11 As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents CUSTOMER_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMER_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_TELNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents H_TELNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAX_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
