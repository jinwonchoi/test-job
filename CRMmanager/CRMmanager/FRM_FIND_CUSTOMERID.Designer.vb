<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FIND_CUSTOMERID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FIND_CUSTOMERID))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.S_START_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_END_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnCmSelect44 = New System.Windows.Forms.Button
        Me.txtCMName44 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.btnClose44 = New System.Windows.Forms.Button
        Me.txtCustomerId55 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCustomerNm55 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_START_TIME, Me.S_END_TIME, Me.Column1, Me.S_TITLE})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(13, 43)
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
        Me.DataGridView1.Size = New System.Drawing.Size(404, 143)
        Me.DataGridView1.TabIndex = 243
        '
        'S_START_TIME
        '
        Me.S_START_TIME.DataPropertyName = "CUSTOMER_NM"
        Me.S_START_TIME.HeaderText = "고객"
        Me.S_START_TIME.Name = "S_START_TIME"
        Me.S_START_TIME.ReadOnly = True
        '
        'S_END_TIME
        '
        Me.S_END_TIME.DataPropertyName = "TEL_NO"
        Me.S_END_TIME.HeaderText = "전화번호"
        Me.S_END_TIME.Name = "S_END_TIME"
        Me.S_END_TIME.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "핸드폰번호"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'S_TITLE
        '
        Me.S_TITLE.DataPropertyName = "CUSTOMER_ID"
        Me.S_TITLE.HeaderText = "고객아이디"
        Me.S_TITLE.Name = "S_TITLE"
        Me.S_TITLE.ReadOnly = True
        '
        'btnCmSelect44
        '
        Me.btnCmSelect44.Location = New System.Drawing.Point(372, 12)
        Me.btnCmSelect44.Name = "btnCmSelect44"
        Me.btnCmSelect44.Size = New System.Drawing.Size(45, 25)
        Me.btnCmSelect44.TabIndex = 242
        Me.btnCmSelect44.Text = "조회"
        Me.btnCmSelect44.UseVisualStyleBackColor = True
        '
        'txtCMName44
        '
        Me.txtCMName44.BackColor = System.Drawing.Color.Yellow
        Me.txtCMName44.Location = New System.Drawing.Point(64, 16)
        Me.txtCMName44.Name = "txtCMName44"
        Me.txtCMName44.Size = New System.Drawing.Size(115, 21)
        Me.txtCMName44.TabIndex = 240
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(21, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 12)
        Me.Label24.TabIndex = 239
        Me.Label24.Text = "고객명"
        '
        'btnClose44
        '
        Me.btnClose44.Location = New System.Drawing.Point(188, 242)
        Me.btnClose44.Name = "btnClose44"
        Me.btnClose44.Size = New System.Drawing.Size(45, 25)
        Me.btnClose44.TabIndex = 245
        Me.btnClose44.Text = "확인"
        Me.btnClose44.UseVisualStyleBackColor = True
        '
        'txtCustomerId55
        '
        Me.txtCustomerId55.BackColor = System.Drawing.Color.White
        Me.txtCustomerId55.Location = New System.Drawing.Point(88, 206)
        Me.txtCustomerId55.Name = "txtCustomerId55"
        Me.txtCustomerId55.ReadOnly = True
        Me.txtCustomerId55.Size = New System.Drawing.Size(115, 21)
        Me.txtCustomerId55.TabIndex = 247
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 246
        Me.Label2.Text = "고객아이디"
        '
        'txtCustomerNm55
        '
        Me.txtCustomerNm55.BackColor = System.Drawing.Color.White
        Me.txtCustomerNm55.Location = New System.Drawing.Point(263, 206)
        Me.txtCustomerNm55.Name = "txtCustomerNm55"
        Me.txtCustomerNm55.ReadOnly = True
        Me.txtCustomerNm55.Size = New System.Drawing.Size(115, 21)
        Me.txtCustomerNm55.TabIndex = 250
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 249
        Me.Label4.Text = "고객명"
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(210, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 12)
        Me.Label3.TabIndex = 251
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(11, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 248
        '
        'Label32
        '
        Me.Label32.Image = CType(resources.GetObject("Label32.Image"), System.Drawing.Image)
        Me.Label32.Location = New System.Drawing.Point(11, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 12)
        Me.Label32.TabIndex = 241
        '
        'FRM_FIND_CUSTOMERID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 279)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustomerNm55)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustomerId55)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose44)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCmSelect44)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtCMName44)
        Me.Controls.Add(Me.Label24)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FIND_CUSTOMERID"
        Me.ShowIcon = False
        Me.Text = "고객아이디 찾기"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents S_START_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_END_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TITLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCmSelect44 As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCMName44 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnClose44 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerId55 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNm55 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
