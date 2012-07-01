<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CALL_STATISTICS2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CALL_STATISTICS2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExcel = New System.Windows.Forms.Button
        Me.drpGubun = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.drpName = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DPDate2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DPDate1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Gubun = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Team = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.call_received = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Call_IB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Call_OB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Call_Ext = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consult_Complete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consult_Transfer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consult_Callback = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Call_Etc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sawon_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sawon_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consult_AS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Consult_Etc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.drpGubun)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.drpName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DPDate2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DPDate1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 50)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(814, 16)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(45, 25)
        Me.btnExcel.TabIndex = 189
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'drpGubun
        '
        Me.drpGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpGubun.FormattingEnabled = True
        Me.drpGubun.Items.AddRange(New Object() {"일자", "주", "월", "분기", "년"})
        Me.drpGubun.Location = New System.Drawing.Point(389, 19)
        Me.drpGubun.Name = "drpGubun"
        Me.drpGubun.Size = New System.Drawing.Size(90, 20)
        Me.drpGubun.TabIndex = 187
        '
        'Label7
        '
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(494, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 12)
        Me.Label7.TabIndex = 185
        '
        'Label4
        '
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(342, 24)
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
        Me.btnSelect.Location = New System.Drawing.Point(763, 16)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 25)
        Me.btnSelect.TabIndex = 181
        Me.btnSelect.Text = "조회"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'drpName
        '
        Me.drpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drpName.FormattingEnabled = True
        Me.drpName.Location = New System.Drawing.Point(551, 18)
        Me.drpName.Name = "drpName"
        Me.drpName.Size = New System.Drawing.Size(115, 20)
        Me.drpName.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(506, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 12)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "팀명"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "구분"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Gubun, Me.Team, Me.call_received, Me.Call_IB, Me.Call_OB, Me.Call_Ext, Me.Consult_Complete, Me.Consult_Transfer, Me.Consult_Callback, Me.Call_Etc, Me.Sawon_ID, Me.Sawon_Name, Me.Consult_AS, Me.Consult_Etc})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(12, 70)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(872, 594)
        Me.DataGridView1.TabIndex = 88
        '
        'SaveFileDialog1
        '
        '
        'Gubun
        '
        Me.Gubun.DataPropertyName = "Gubun"
        Me.Gubun.HeaderText = "구분"
        Me.Gubun.Name = "Gubun"
        Me.Gubun.ReadOnly = True
        Me.Gubun.Width = 80
        '
        'Team
        '
        Me.Team.DataPropertyName = "Team"
        Me.Team.FillWeight = 130.0!
        Me.Team.HeaderText = "팀명"
        Me.Team.Name = "Team"
        Me.Team.ReadOnly = True
        '
        'call_received
        '
        Me.call_received.DataPropertyName = "call_received"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.call_received.DefaultCellStyle = DataGridViewCellStyle3
        Me.call_received.HeaderText = "응대호"
        Me.call_received.Name = "call_received"
        Me.call_received.ReadOnly = True
        Me.call_received.Width = 80
        '
        'Call_IB
        '
        Me.Call_IB.DataPropertyName = "Call_IB"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Call_IB.DefaultCellStyle = DataGridViewCellStyle4
        Me.Call_IB.HeaderText = "인바운드"
        Me.Call_IB.Name = "Call_IB"
        Me.Call_IB.ReadOnly = True
        '
        'Call_OB
        '
        Me.Call_OB.DataPropertyName = "Call_OB"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Call_OB.DefaultCellStyle = DataGridViewCellStyle5
        Me.Call_OB.HeaderText = "아웃바운드"
        Me.Call_OB.Name = "Call_OB"
        Me.Call_OB.ReadOnly = True
        '
        'Call_Ext
        '
        Me.Call_Ext.DataPropertyName = "Call_Ext"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Call_Ext.DefaultCellStyle = DataGridViewCellStyle6
        Me.Call_Ext.HeaderText = "내선"
        Me.Call_Ext.Name = "Call_Ext"
        Me.Call_Ext.ReadOnly = True
        Me.Call_Ext.Width = 80
        '
        'Consult_Complete
        '
        Me.Consult_Complete.DataPropertyName = "Consult_Complete"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Consult_Complete.DefaultCellStyle = DataGridViewCellStyle7
        Me.Consult_Complete.HeaderText = "상담건수"
        Me.Consult_Complete.Name = "Consult_Complete"
        Me.Consult_Complete.ReadOnly = True
        Me.Consult_Complete.Width = 80
        '
        'Consult_Transfer
        '
        Me.Consult_Transfer.DataPropertyName = "Consult_Transfer"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Consult_Transfer.DefaultCellStyle = DataGridViewCellStyle8
        Me.Consult_Transfer.HeaderText = "이관건수"
        Me.Consult_Transfer.Name = "Consult_Transfer"
        Me.Consult_Transfer.ReadOnly = True
        Me.Consult_Transfer.Width = 80
        '
        'Consult_Callback
        '
        Me.Consult_Callback.DataPropertyName = "Consult_Callback"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Consult_Callback.DefaultCellStyle = DataGridViewCellStyle9
        Me.Consult_Callback.HeaderText = "콜백건수"
        Me.Consult_Callback.Name = "Consult_Callback"
        Me.Consult_Callback.ReadOnly = True
        Me.Consult_Callback.Width = 80
        '
        'Call_Etc
        '
        Me.Call_Etc.DataPropertyName = "Call_Etc"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Call_Etc.DefaultCellStyle = DataGridViewCellStyle10
        Me.Call_Etc.HeaderText = "기타"
        Me.Call_Etc.Name = "Call_Etc"
        Me.Call_Etc.ReadOnly = True
        Me.Call_Etc.Width = 80
        '
        'Sawon_ID
        '
        Me.Sawon_ID.DataPropertyName = "Sawon_ID"
        Me.Sawon_ID.HeaderText = "사원번호"
        Me.Sawon_ID.Name = "Sawon_ID"
        Me.Sawon_ID.ReadOnly = True
        Me.Sawon_ID.Visible = False
        Me.Sawon_ID.Width = 80
        '
        'Sawon_Name
        '
        Me.Sawon_Name.DataPropertyName = "Sawon_Name"
        Me.Sawon_Name.HeaderText = "사원명"
        Me.Sawon_Name.Name = "Sawon_Name"
        Me.Sawon_Name.ReadOnly = True
        Me.Sawon_Name.Visible = False
        '
        'Consult_AS
        '
        Me.Consult_AS.DataPropertyName = "Consult_AS"
        Me.Consult_AS.HeaderText = "상담-AS"
        Me.Consult_AS.Name = "Consult_AS"
        Me.Consult_AS.ReadOnly = True
        Me.Consult_AS.Visible = False
        '
        'Consult_Etc
        '
        Me.Consult_Etc.DataPropertyName = "Consult_Etc"
        Me.Consult_Etc.HeaderText = "상담-기타"
        Me.Consult_Etc.Name = "Consult_Etc"
        Me.Consult_Etc.ReadOnly = True
        Me.Consult_Etc.Visible = False
        '
        'FRM_CALL_STATISTICS2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 676)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_CALL_STATISTICS2"
        Me.Text = "팀통화건수"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents drpName As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DPDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DPDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents drpGubun As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Gubun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Team As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents call_received As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_IB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_OB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_Ext As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consult_Complete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consult_Transfer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consult_Callback As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_Etc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sawon_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sawon_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consult_AS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Consult_Etc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
