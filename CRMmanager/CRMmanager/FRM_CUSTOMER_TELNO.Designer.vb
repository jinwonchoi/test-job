<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CUSTOMER_TELNO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CUSTOMER_TELNO))
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.LabTelNo = New System.Windows.Forms.Label
        Me.txtFindTelNo = New System.Windows.Forms.TextBox
        Me.btnModify = New System.Windows.Forms.Button
        Me.txtCMName1 = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.S_END_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 12)
        Me.Label3.TabIndex = 284
        Me.Label3.Text = "기타 고객 연락처정보입니다."
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(157, 162)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(45, 21)
        Me.btnConfirm.TabIndex = 281
        Me.btnConfirm.Text = "닫기"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(108, 162)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 21)
        Me.btnDelete.TabIndex = 279
        Me.btnDelete.Text = "삭제"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'LabTelNo
        '
        Me.LabTelNo.AutoSize = True
        Me.LabTelNo.Location = New System.Drawing.Point(28, 137)
        Me.LabTelNo.Name = "LabTelNo"
        Me.LabTelNo.Size = New System.Drawing.Size(81, 12)
        Me.LabTelNo.TabIndex = 276
        Me.LabTelNo.Text = "선택 전화번호"
        '
        'txtFindTelNo
        '
        Me.txtFindTelNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFindTelNo.Location = New System.Drawing.Point(119, 132)
        Me.txtFindTelNo.Name = "txtFindTelNo"
        Me.txtFindTelNo.Size = New System.Drawing.Size(92, 21)
        Me.txtFindTelNo.TabIndex = 275
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(57, 162)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(45, 21)
        Me.btnModify.TabIndex = 274
        Me.btnModify.Text = "저장"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'txtCMName1
        '
        Me.txtCMName1.BackColor = System.Drawing.SystemColors.Control
        Me.txtCMName1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCMName1.Location = New System.Drawing.Point(74, 24)
        Me.txtCMName1.Name = "txtCMName1"
        Me.txtCMName1.ReadOnly = True
        Me.txtCMName1.Size = New System.Drawing.Size(138, 14)
        Me.txtCMName1.TabIndex = 271
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(30, 25)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(41, 12)
        Me.Label58.TabIndex = 270
        Me.Label58.Text = "고객명"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_END_TIME})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(22, 43)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
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
        Me.DataGridView1.Size = New System.Drawing.Size(190, 86)
        Me.DataGridView1.TabIndex = 269
        '
        'S_END_TIME
        '
        Me.S_END_TIME.DataPropertyName = "TEL_NO"
        Me.S_END_TIME.HeaderText = "전화번호"
        Me.S_END_TIME.Name = "S_END_TIME"
        Me.S_END_TIME.Width = 120
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(7, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 12)
        Me.Label4.TabIndex = 285
        '
        'Label59
        '
        Me.Label59.Image = CType(resources.GetObject("Label59.Image"), System.Drawing.Image)
        Me.Label59.Location = New System.Drawing.Point(18, 137)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(13, 12)
        Me.Label59.TabIndex = 277
        '
        'Label57
        '
        Me.Label57.Image = CType(resources.GetObject("Label57.Image"), System.Drawing.Image)
        Me.Label57.Location = New System.Drawing.Point(20, 25)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(13, 12)
        Me.Label57.TabIndex = 272
        '
        'FRM_CUSTOMER_TELNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 226)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.LabTelNo)
        Me.Controls.Add(Me.txtFindTelNo)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.txtCMName1)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRM_CUSTOMER_TELNO"
        Me.Text = "고객기타 전화번호 목록"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents LabTelNo As System.Windows.Forms.Label
    Friend WithEvents txtFindTelNo As System.Windows.Forms.TextBox
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtCMName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents S_END_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
