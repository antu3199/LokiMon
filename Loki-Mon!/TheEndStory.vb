Public Class frmTheEndStory
    Dim IntTextNumber As Integer = 1
    Dim IntDelay As Integer = 0
    Private Sub frmTheEndStory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Z And intdelay > 5 Then
            IntTextNumber += 1
        End If
        If IntTextNumber = 2 Then
            lblLokiText.Text = "A few moments later..."
        End If
        If IntTextNumber = 3 Then
            lblBlackscreen.Hide()
            lblLokiText.Text = "Bob the Trainer: Everybody!!!"
        End If
        If IntTextNumber = 4 Then

            lblLokiText.Text = "Bob the Trainer: I found this really powerful Pokémon!..."
        End If
        If IntTextNumber = 5 Then
            lblBlackscreen.Show()
            lblLokiText.Text = "A few days later..."
        End If

        If IntTextNumber = 5 Then
            Me.Hide()
            frmTheEnd.Show()
        End If


    End Sub

    Private Sub tmrDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        intdelay += 1
    End Sub
End Class