Public Class Authorization
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If txtUsername.Text = "admin" AndAlso txtPassword.Text = "admin" Then
            Me.Close()
            VoidTransno.Show()
        Else
            txtUsername.Clear()
            txtPassword.Clear()
            MsgBox("Acces denied!", vbCritical)
        End If
    End Sub
End Class