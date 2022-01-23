Public Class loginAttempts
    Dim timercount As Integer = 10 'The number of seconds 

    Private Sub LoginAttempts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True

    End Sub

    Private Sub TmrCountDown_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblOutput.Text = timercount.ToString() 'show the countdown in the label
        If timercount = 0 Then 'Check to see if it has reached 0, if yes then stop timer and display done
            Me.Close()
            Login.Show()
            timercount = 10
        Else 'If timercount is higher then 0 then subtract one from it
            timercount -= 1
        End If
    End Sub
End Class