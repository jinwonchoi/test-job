<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PWD_CHANGE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PWD_CHANGE))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCloseForm = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.txtConfirmPwd = New System.Windows.Forms.TextBox
        Me.txtNewPwd = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOldPwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCloseForm)
        Me.GroupBox1.Controls.Add(Me.btnModify)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPwd)
        Me.GroupBox1.Controls.Add(Me.txtNewPwd)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOldPwd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(183, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 273)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.SystemColors.Control
        Me.btnCloseForm.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCloseForm.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnCloseForm.Location = New System.Drawing.Point(275, 188)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(45, 25)
        Me.btnCloseForm.TabIndex = 225
        Me.btnCloseForm.Text = "닫기"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(208, 188)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(45, 25)
        Me.btnModify.TabIndex = 187
        Me.btnModify.Text = "수정"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.Location = New System.Drawing.Point(247, 130)
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPwd.Size = New System.Drawing.Size(115, 21)
        Me.txtConfirmPwd.TabIndex = 128
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(247, 98)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(115, 21)
        Me.txtNewPwd.TabIndex = 127
        '
        'Label15
        '
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(143, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 12)
        Me.Label15.TabIndex = 126
        '
        'Label14
        '
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(143, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 12)
        Me.Label14.TabIndex = 125
        '
        'Label13
        '
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(143, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 12)
        Me.Label13.TabIndex = 124
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(162, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "비밀번호확인"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "신규비밀번호"
        '
        'txtOldPwd
        '
        Me.txtOldPwd.Location = New System.Drawing.Point(247, 67)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPwd.Size = New System.Drawing.Size(115, 21)
        Me.txtOldPwd.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "기존비밀번호"
        '
        'FRM_PWD_CHANGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_PWD_CHANGE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "비밀번호변경"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOldPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
End Class
