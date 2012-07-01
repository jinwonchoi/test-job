<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FIND_ID_BY_TELNO
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FIND_ID_BY_TELNO))
        Me.LabAddr5 = New System.Windows.Forms.Label
        Me.txtFindCmName1 = New System.Windows.Forms.TextBox
        Me.btnTelAdd1 = New System.Windows.Forms.Button
        Me.btnCmSelect1 = New System.Windows.Forms.Button
        Me.txtCMName1 = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.S_TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_START_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.S_END_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.txtEnteringNo = New System.Windows.Forms.TextBox
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabAddr5
        '
        Me.LabAddr5.AutoSize = True
        Me.LabAddr5.Location = New System.Drawing.Point(28, 157)
        Me.LabAddr5.Name = "LabAddr5"
        Me.LabAddr5.Size = New System.Drawing.Size(81, 12)
        Me.LabAddr5.TabIndex = 259
        Me.LabAddr5.Text = "선택한 고객명"
        '
        'txtFindCmName1
        '
        Me.txtFindCmName1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFindCmName1.Location = New System.Drawing.Point(115, 152)
        Me.txtFindCmName1.Name = "txtFindCmName1"
        Me.txtFindCmName1.ReadOnly = True
        Me.txtFindCmName1.Size = New System.Drawing.Size(160, 21)
        Me.txtFindCmName1.TabIndex = 258
        '
        'btnTelAdd1
        '
        Me.btnTelAdd1.Location = New System.Drawing.Point(281, 152)
        Me.btnTelAdd1.Name = "btnTelAdd1"
        Me.btnTelAdd1.Size = New System.Drawing.Size(96, 21)
        Me.btnTelAdd1.TabIndex = 257
        Me.btnTelAdd1.Text = "조회번호 추가"
        Me.btnTelAdd1.UseVisualStyleBackColor = True
        '
        'btnCmSelect1
        '
        Me.btnCmSelect1.Location = New System.Drawing.Point(215, 35)
        Me.btnCmSelect1.Name = "btnCmSelect1"
        Me.btnCmSelect1.Size = New System.Drawing.Size(45, 21)
        Me.btnCmSelect1.TabIndex = 256
        Me.btnCmSelect1.Text = "조회"
        Me.btnCmSelect1.UseVisualStyleBackColor = True
        '
        'txtCMName1
        '
        Me.txtCMName1.BackColor = System.Drawing.Color.White
        Me.txtCMName1.Location = New System.Drawing.Point(88, 35)
        Me.txtCMName1.Name = "txtCMName1"
        Me.txtCMName1.Size = New System.Drawing.Size(125, 21)
        Me.txtCMName1.TabIndex = 254
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(30, 41)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(41, 12)
        Me.Label58.TabIndex = 253
        Me.Label58.Text = "고객명"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle17.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_TITLE, Me.S_START_TIME, Me.S_END_TIME, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(22, 62)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(405, 86)
        Me.DataGridView1.TabIndex = 252
        '
        'S_TITLE
        '
        Me.S_TITLE.DataPropertyName = "CUSTOMER_ID"
        Me.S_TITLE.HeaderText = "고객아이디"
        Me.S_TITLE.Name = "S_TITLE"
        Me.S_TITLE.ReadOnly = True
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
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "핸드폰번호"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Label59
        '
        Me.Label59.Image = CType(resources.GetObject("Label59.Image"), System.Drawing.Image)
        Me.Label59.Location = New System.Drawing.Point(18, 157)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(13, 12)
        Me.Label59.TabIndex = 260
        '
        'Label57
        '
        Me.Label57.Image = CType(resources.GetObject("Label57.Image"), System.Drawing.Image)
        Me.Label57.Location = New System.Drawing.Point(20, 41)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(13, 12)
        Me.Label57.TabIndex = 255
        '
        'txtEnteringNo
        '
        Me.txtEnteringNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtEnteringNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEnteringNo.Location = New System.Drawing.Point(89, 12)
        Me.txtEnteringNo.Name = "txtEnteringNo"
        Me.txtEnteringNo.ReadOnly = True
        Me.txtEnteringNo.Size = New System.Drawing.Size(125, 14)
        Me.txtEnteringNo.TabIndex = 263
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(371, 203)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(56, 22)
        Me.btnConfirm.TabIndex = 264
        Me.btnConfirm.Text = "닫기"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 266
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "조회번호"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 12)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "조회번호를 선택한 고객정보에 추가합니다."
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(19, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 12)
        Me.Label4.TabIndex = 268
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 12)
        Me.Label5.TabIndex = 269
        Me.Label5.Text = "추가시 선택한 고객정보로 조회됩니다."
        '
        'FRM_FIND_ID_BY_TELNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 232)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtEnteringNo)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.LabAddr5)
        Me.Controls.Add(Me.txtFindCmName1)
        Me.Controls.Add(Me.btnTelAdd1)
        Me.Controls.Add(Me.btnCmSelect1)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.txtCMName1)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FRM_FIND_ID_BY_TELNO"
        Me.Text = "고객 ID 찾기"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents LabAddr5 As System.Windows.Forms.Label
    Friend WithEvents txtFindCmName1 As System.Windows.Forms.TextBox
    Friend WithEvents btnTelAdd1 As System.Windows.Forms.Button
    Friend WithEvents btnCmSelect1 As System.Windows.Forms.Button
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtCMName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtEnteringNo As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents S_TITLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_START_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents S_END_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
