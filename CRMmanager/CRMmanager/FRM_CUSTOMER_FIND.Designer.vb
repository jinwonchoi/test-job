<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CUSTOMER_FIND
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CUSTOMER_FIND))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnCmSelect = New System.Windows.Forms.Button
        Me.txtCMName = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.S_START_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_END_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtFindCmName = New System.Windows.Forms.TextBox
        Me.LabAddr5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnTelAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtTelNo = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCmSelect
        '
        Me.btnCmSelect.Location = New System.Drawing.Point(372, 8)
        Me.btnCmSelect.Name = "btnCmSelect"
        Me.btnCmSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnCmSelect.TabIndex = 230
        Me.btnCmSelect.Text = "조회"
        Me.btnCmSelect.UseVisualStyleBackColor = True
        '
        'txtCMName
        '
        Me.txtCMName.BackColor = System.Drawing.Color.Yellow
        Me.txtCMName.Location = New System.Drawing.Point(64, 12)
        Me.txtCMName.Name = "txtCMName"
        Me.txtCMName.Size = New System.Drawing.Size(115, 21)
        Me.txtCMName.TabIndex = 228
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(21, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 12)
        Me.Label24.TabIndex = 227
        Me.Label24.Text = "고객명"
        '
        'Label32
        '
        Me.Label32.Image = CType(resources.GetObject("Label32.Image"), System.Drawing.Image)
        Me.Label32.Location = New System.Drawing.Point(11, 15)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 12)
        Me.Label32.TabIndex = 229
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_START_TIME, Me.S_END_TIME, Me.Column1, Me.S_TITLE})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(13, 39)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(404, 143)
        Me.DataGridView1.TabIndex = 231
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
        'txtFindCmName
        '
        Me.txtFindCmName.Enabled = False
        Me.txtFindCmName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtFindCmName.Location = New System.Drawing.Point(109, 188)
        Me.txtFindCmName.Name = "txtFindCmName"
        Me.txtFindCmName.Size = New System.Drawing.Size(138, 21)
        Me.txtFindCmName.TabIndex = 232
        '
        'LabAddr5
        '
        Me.LabAddr5.AutoSize = True
        Me.LabAddr5.Location = New System.Drawing.Point(21, 191)
        Me.LabAddr5.Name = "LabAddr5"
        Me.LabAddr5.Size = New System.Drawing.Size(81, 12)
        Me.LabAddr5.TabIndex = 233
        Me.LabAddr5.Text = "선택한 고객명"
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(11, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 234
        '
        'btnTelAdd
        '
        Me.btnTelAdd.Location = New System.Drawing.Point(132, 215)
        Me.btnTelAdd.Name = "btnTelAdd"
        Me.btnTelAdd.Size = New System.Drawing.Size(85, 25)
        Me.btnTelAdd.TabIndex = 235
        Me.btnTelAdd.Text = "전화번호추가"
        Me.btnTelAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(223, 215)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 25)
        Me.btnClose.TabIndex = 236
        Me.btnClose.Text = "닫기"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Yellow
        Me.txtID.Location = New System.Drawing.Point(2, 219)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(70, 21)
        Me.txtID.TabIndex = 237
        '
        'txtTelNo
        '
        Me.txtTelNo.BackColor = System.Drawing.Color.White
        Me.txtTelNo.Enabled = False
        Me.txtTelNo.Location = New System.Drawing.Point(185, 12)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(83, 21)
        Me.txtTelNo.TabIndex = 238
        '
        'FRM_CUSTOMER_FIND
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 243)
        Me.Controls.Add(Me.txtTelNo)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnTelAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabAddr5)
        Me.Controls.Add(Me.txtFindCmName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCmSelect)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtCMName)
        Me.Controls.Add(Me.Label24)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRM_CUSTOMER_FIND"
        Me.Text = "고객검색 및 전화번호 추가"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCmSelect As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCMName As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFindCmName As System.Windows.Forms.TextBox
    Friend WithEvents LabAddr5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTelAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents S_START_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_END_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_TITLE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
