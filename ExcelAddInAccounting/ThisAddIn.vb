Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup

        '
        ' Load Template Combo box
        '


        Dim FormPurshase As New FormPurchase()
        FormPurshase.Show()


    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
