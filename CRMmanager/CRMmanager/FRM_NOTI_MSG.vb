Public NotInheritable Class FRM_NOTI_MSG

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Public Overloads Sub show(ByVal msg As String)
        Label1.Text = msg
        Me.Show()
    End Sub
End Class
