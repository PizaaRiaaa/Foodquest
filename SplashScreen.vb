Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MetroProgressBar1.Increment(1)
        If MetroProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Close()
            cashier_form.Show()
        End If
    End Sub
End Class