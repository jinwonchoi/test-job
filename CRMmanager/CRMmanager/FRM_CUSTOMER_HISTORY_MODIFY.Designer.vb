<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CUSTOMER_HISTORY_MODIFY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CUSTOMER_HISTORY_MODIFY))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCCId = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtSubCustomerName = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.cboCallType = New System.Windows.Forms.ComboBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtTongTime = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.cboConsultResult = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.cboConsultType = New System.Windows.Forms.ComboBox
        Me.txtTongUser = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTongEtcInfo = New System.Windows.Forms.TextBox
        Me.txtTongNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnCloseForm = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCCId)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.txtSubCustomerName)
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.txtDate)
        Me.GroupBox2.Controls.Add(Me.cboCallType)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.txtTongTime)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.cboConsultResult)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.cboConsultType)
        Me.GroupBox2.Controls.Add(Me.txtTongUser)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTongEtcInfo)
        Me.GroupBox2.Controls.Add(Me.txtTongNo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 148)
        Me.GroupBox2.TabIndex = 120
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[상담내용]"
        '
        'txtCCId
        '
        Me.txtCCId.Enabled = False
        Me.txtCCId.Location = New System.Drawing.Point(7, 117)
        Me.txtCCId.Name = "txtCCId"
        Me.txtCCId.Size = New System.Drawing.Size(48, 21)
        Me.txtCCId.TabIndex = 198
        Me.txtCCId.Visible = False
        '
        'Label46
        '
        Me.Label46.Image = CType(resources.GetObject("Label46.Image"), System.Drawing.Image)
        Me.Label46.Location = New System.Drawing.Point(582, 38)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(13, 12)
        Me.Label46.TabIndex = 197
        '
        'txtSubCustomerName
        '
        Me.txtSubCustomerName.Location = New System.Drawing.Point(642, 34)
        Me.txtSubCustomerName.Name = "txtSubCustomerName"
        Me.txtSubCustomerName.Size = New System.Drawing.Size(126, 21)
        Me.txtSubCustomerName.TabIndex = 196
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(592, 37)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(41, 12)
        Me.Label47.TabIndex = 195
        Me.Label47.Text = "고객명"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(88, 31)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(115, 21)
        Me.txtDate.TabIndex = 194
        '
        'cboCallType
        '
        Me.cboCallType.BackColor = System.Drawing.Color.MintCream
        Me.cboCallType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCallType.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboCallType.FormattingEnabled = True
        Me.cboCallType.Location = New System.Drawing.Point(463, 33)
        Me.cboCallType.Name = "cboCallType"
        Me.cboCallType.Size = New System.Drawing.Size(114, 20)
        Me.cboCallType.TabIndex = 193
        '
        'Label44
        '
        Me.Label44.Image = CType(resources.GetObject("Label44.Image"), System.Drawing.Image)
        Me.Label44.Location = New System.Drawing.Point(209, 37)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(13, 12)
        Me.Label44.TabIndex = 192
        '
        'txtTongTime
        '
        Me.txtTongTime.Enabled = False
        Me.txtTongTime.Location = New System.Drawing.Point(278, 31)
        Me.txtTongTime.Name = "txtTongTime"
        Me.txtTongTime.Size = New System.Drawing.Size(115, 21)
        Me.txtTongTime.TabIndex = 191
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(219, 37)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(53, 12)
        Me.Label45.TabIndex = 190
        Me.Label45.Text = "통화시간"
        '
        'Label42
        '
        Me.Label42.Image = CType(resources.GetObject("Label42.Image"), System.Drawing.Image)
        Me.Label42.Location = New System.Drawing.Point(400, 36)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(13, 12)
        Me.Label42.TabIndex = 189
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(411, 37)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(41, 12)
        Me.Label43.TabIndex = 188
        Me.Label43.Text = "콜타입"
        '
        'Label41
        '
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(18, 37)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 12)
        Me.Label41.TabIndex = 186
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(28, 38)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(53, 12)
        Me.Label40.TabIndex = 184
        Me.Label40.Text = "통화일자"
        '
        'Label39
        '
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(17, 84)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 12)
        Me.Label39.TabIndex = 183
        '
        'Label36
        '
        Me.Label36.Image = CType(resources.GetObject("Label36.Image"), System.Drawing.Image)
        Me.Label36.Location = New System.Drawing.Point(18, 61)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 12)
        Me.Label36.TabIndex = 182
        '
        'Label35
        '
        Me.Label35.Image = CType(resources.GetObject("Label35.Image"), System.Drawing.Image)
        Me.Label35.Location = New System.Drawing.Point(583, 62)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 12)
        Me.Label35.TabIndex = 181
        '
        'cboConsultResult
        '
        Me.cboConsultResult.BackColor = System.Drawing.Color.MintCream
        Me.cboConsultResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsultResult.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboConsultResult.FormattingEnabled = True
        Me.cboConsultResult.Location = New System.Drawing.Point(463, 59)
        Me.cboConsultResult.Name = "cboConsultResult"
        Me.cboConsultResult.Size = New System.Drawing.Size(114, 20)
        Me.cboConsultResult.TabIndex = 180
        '
        'Label34
        '
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.Location = New System.Drawing.Point(399, 62)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 12)
        Me.Label34.TabIndex = 179
        '
        'Label33
        '
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.Location = New System.Drawing.Point(209, 61)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 12)
        Me.Label33.TabIndex = 178
        '
        'cboConsultType
        '
        Me.cboConsultType.BackColor = System.Drawing.Color.MintCream
        Me.cboConsultType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsultType.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboConsultType.FormattingEnabled = True
        Me.cboConsultType.Location = New System.Drawing.Point(278, 58)
        Me.cboConsultType.Name = "cboConsultType"
        Me.cboConsultType.Size = New System.Drawing.Size(114, 20)
        Me.cboConsultType.TabIndex = 177
        '
        'txtTongUser
        '
        Me.txtTongUser.Enabled = False
        Me.txtTongUser.Location = New System.Drawing.Point(641, 58)
        Me.txtTongUser.Name = "txtTongUser"
        Me.txtTongUser.Size = New System.Drawing.Size(127, 21)
        Me.txtTongUser.TabIndex = 105
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(593, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 12)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "통화자"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(411, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "상담결과"
        '
        'txtTongEtcInfo
        '
        Me.txtTongEtcInfo.Location = New System.Drawing.Point(89, 85)
        Me.txtTongEtcInfo.Multiline = True
        Me.txtTongEtcInfo.Name = "txtTongEtcInfo"
        Me.txtTongEtcInfo.Size = New System.Drawing.Size(679, 53)
        Me.txtTongEtcInfo.TabIndex = 99
        '
        'txtTongNo
        '
        Me.txtTongNo.Location = New System.Drawing.Point(87, 58)
        Me.txtTongNo.Name = "txtTongNo"
        Me.txtTongNo.Size = New System.Drawing.Size(115, 21)
        Me.txtTongNo.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "전화번호"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "기타정보"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(219, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "상담유형"
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.SystemColors.Control
        Me.btnCloseForm.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCloseForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCloseForm.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnCloseForm.Location = New System.Drawing.Point(406, 169)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(45, 25)
        Me.btnCloseForm.TabIndex = 204
        Me.btnCloseForm.Text = "닫기"
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.btnSave.Location = New System.Drawing.Point(350, 169)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 25)
        Me.btnSave.TabIndex = 203
        Me.btnSave.Text = "저장"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'FRM_CUSTOMER_HISTORY_MODIFY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 204)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CUSTOMER_HISTORY_MODIFY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "상담이력수정"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtSubCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents cboCallType As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtTongTime As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cboConsultResult As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cboConsultType As System.Windows.Forms.ComboBox
    Friend WithEvents txtTongUser As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTongEtcInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtTongNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCCId As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
End Class
