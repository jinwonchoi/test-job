<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ZIPCODE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ZIPCODE))
        Me.txtDong = New System.Windows.Forms.TextBox
        Me.LabAddr3 = New System.Windows.Forms.Label
        Me.LabAddr1 = New System.Windows.Forms.Label
        Me.LabAddr4 = New System.Windows.Forms.Label
        Me.ListAddr = New System.Windows.Forms.ListBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.LabAddr2 = New System.Windows.Forms.Label
        Me.txtAddr1 = New System.Windows.Forms.TextBox
        Me.LabAddr5 = New System.Windows.Forms.Label
        Me.txtAddr2 = New System.Windows.Forms.TextBox
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtDong
        '
        Me.txtDong.Location = New System.Drawing.Point(105, 50)
        Me.txtDong.Name = "txtDong"
        Me.txtDong.Size = New System.Drawing.Size(200, 21)
        Me.txtDong.TabIndex = 39
        '
        'LabAddr3
        '
        Me.LabAddr3.AutoSize = True
        Me.LabAddr3.Location = New System.Drawing.Point(15, 53)
        Me.LabAddr3.Name = "LabAddr3"
        Me.LabAddr3.Size = New System.Drawing.Size(85, 12)
        Me.LabAddr3.TabIndex = 38
        Me.LabAddr3.Text = "동(읍/면) 입력"
        '
        'LabAddr1
        '
        Me.LabAddr1.AutoSize = True
        Me.LabAddr1.Location = New System.Drawing.Point(15, 10)
        Me.LabAddr1.Name = "LabAddr1"
        Me.LabAddr1.Size = New System.Drawing.Size(369, 12)
        Me.LabAddr1.TabIndex = 45
        Me.LabAddr1.Text = "찾고자 하는 주소의 동(읍/면)을 입력하고 조회 버튼을 누르십시오. "
        '
        'LabAddr4
        '
        Me.LabAddr4.AutoSize = True
        Me.LabAddr4.Location = New System.Drawing.Point(15, 85)
        Me.LabAddr4.Name = "LabAddr4"
        Me.LabAddr4.Size = New System.Drawing.Size(353, 12)
        Me.LabAddr4.TabIndex = 111
        Me.LabAddr4.Text = "리스트 중 해당하는 주소를 선택하고 밑에 상세 주소를 쓰십시오."
        '
        'ListAddr
        '
        Me.ListAddr.FormattingEnabled = True
        Me.ListAddr.ItemHeight = 12
        Me.ListAddr.Location = New System.Drawing.Point(19, 102)
        Me.ListAddr.Name = "ListAddr"
        Me.ListAddr.Size = New System.Drawing.Size(380, 148)
        Me.ListAddr.TabIndex = 114
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(315, 49)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 182
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'LabAddr2
        '
        Me.LabAddr2.AutoSize = True
        Me.LabAddr2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabAddr2.Location = New System.Drawing.Point(15, 28)
        Me.LabAddr2.Name = "LabAddr2"
        Me.LabAddr2.Size = New System.Drawing.Size(170, 12)
        Me.LabAddr2.TabIndex = 183
        Me.LabAddr2.Text = "예) 논현동, 신동읍, 교동면 등 "
        '
        'txtAddr1
        '
        Me.txtAddr1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtAddr1.Location = New System.Drawing.Point(49, 262)
        Me.txtAddr1.Name = "txtAddr1"
        Me.txtAddr1.ReadOnly = True
        Me.txtAddr1.Size = New System.Drawing.Size(350, 21)
        Me.txtAddr1.TabIndex = 184
        '
        'LabAddr5
        '
        Me.LabAddr5.AutoSize = True
        Me.LabAddr5.Location = New System.Drawing.Point(15, 265)
        Me.LabAddr5.Name = "LabAddr5"
        Me.LabAddr5.Size = New System.Drawing.Size(29, 12)
        Me.LabAddr5.TabIndex = 185
        Me.LabAddr5.Text = "주소"
        '
        'txtAddr2
        '
        Me.txtAddr2.Location = New System.Drawing.Point(49, 290)
        Me.txtAddr2.Name = "txtAddr2"
        Me.txtAddr2.Size = New System.Drawing.Size(350, 21)
        Me.txtAddr2.TabIndex = 186
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(189, 325)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(45, 25)
        Me.btnConfirm.TabIndex = 187
        Me.btnConfirm.Text = "확인"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'FRM_ZIPCODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 363)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtAddr2)
        Me.Controls.Add(Me.LabAddr5)
        Me.Controls.Add(Me.txtAddr1)
        Me.Controls.Add(Me.LabAddr2)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.ListAddr)
        Me.Controls.Add(Me.LabAddr4)
        Me.Controls.Add(Me.LabAddr1)
        Me.Controls.Add(Me.txtDong)
        Me.Controls.Add(Me.LabAddr3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRM_ZIPCODE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "주소 찾기"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDong As System.Windows.Forms.TextBox
    Friend WithEvents LabAddr3 As System.Windows.Forms.Label
    Friend WithEvents LabAddr1 As System.Windows.Forms.Label
    Friend WithEvents LabAddr4 As System.Windows.Forms.Label
    Friend WithEvents ListAddr As System.Windows.Forms.ListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents LabAddr2 As System.Windows.Forms.Label
    Friend WithEvents txtAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents LabAddr5 As System.Windows.Forms.Label
    Friend WithEvents txtAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
End Class
