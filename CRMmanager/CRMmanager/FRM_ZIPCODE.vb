Public Class FRM_ZIPCODE
    Private temp As String
    Private temp2 As String = ""
    Public ParentFrm As Windows.Forms.Form

    Private Sub FRM_ZIPCODE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Size = New System.Drawing.Size(430, 110)
            txtDong.MaxLength = 100
            txtDong.ImeMode = Windows.Forms.ImeMode.Hangul
            txtAddr2.ImeMode = Windows.Forms.ImeMode.Hangul
            txtDong.Focus()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Try
            Call Setting_ListAddr()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub txtDong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDong.KeyDown
        Try
            If e.KeyValue = Keys.Enter Then  'Keys.Enter : 13
                Call Setting_ListAddr()
            End If
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub Setting_ListAddr()
        Try
            ListAddr.DataSource = Nothing
            txtAddr1.Text = ""

            If txtDong.Text.Trim = "" Then Exit Try

            Me.Size = New System.Drawing.Size(430, 390)

            temp = "SELECT ZIPCODE, SEQ, Concat('[',ZIPCODE,'] ',Rtrim(SIDO), ' ', Rtrim(GUGUN), ' ', Rtrim(DONG), ' ', Rtrim(RI), ' ', RTRIM(BUNJI)) JUSO1 " & _
                   "From t_zipcode " & _
                   "Where DONG like '" & txtDong.Text.Trim() & "%' ORDER BY SEQ "
            ListAddr.BeginUpdate()
            'ListAddr.Items.Clear()
            CB_Set(gsConString, temp, ListAddr, "JUSO1", "SEQ", Nothing)
            Call WriteLog(" Setting_ListAddr : " & temp)
            ListAddr.EndUpdate()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Try
            ParentFrm.Tag = Setting_Address()
            Me.Close()
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Private Sub ListAddr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListAddr.SelectedIndexChanged
        Try
            txtAddr1.Text = ListAddr.Text
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        End Try
    End Sub

    Public Function Setting_Address() As String
        Dim addr As String = ""
        Try
            If txtAddr1.Text.Trim = "" Then Exit Try
            addr = txtAddr1.Text.Trim.Substring(1, 7).Trim & "^" & txtAddr1.Text.Trim.Substring(9).Trim & "^" & txtAddr2.Text.Trim           
        Catch ex As Exception
            Call WriteLog(Me.Name & " : " & ex.ToString)
        Finally
            Setting_Address = addr
        End Try
    End Function

    Private Sub txtDong_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDong.TextChanged

    End Sub
End Class