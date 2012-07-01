Imports CRMmanager.CRMmanager

Public Class Form1

    Private ss As New CRMmanager.CRMmanager
    'Private WithEvents trans_call As New CRMmanager.CRMmanager

    Private WithEvents kk As New CRMmanager.CRMmanager

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ss.SetUserInfo("9997", "0001", "0001", "127.0.0.1", "8886", True)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ss.SetUserInfo("9997", "0005", "0005", "127.0.0.1", "8886", True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tm As String = Format(Now, "yyyyMMddHHmmss")

        ss.POPUP(TextBox1.Text.Trim, tm, "1")

    End Sub


    'Private Sub trans_call_Call_Trans(ByVal telno As String) Handles trans_call.Call_Trans
    '    MessageBox.Show("전달받은 전화번호는 : " & telno)
    'End Sub

    'Private Sub kk_Call_Trans(ByVal telno As String) Handles kk.Call_Trans
    '    MessageBox.Show("dll --> telno:" & telno)

    'End Sub

End Class
