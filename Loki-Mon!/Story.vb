Public Class frmStory
    Dim IntTextNumber As Integer = 1
    Private Sub frmStory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Z Then

            IntTextNumber += 1
        End If
        If IntTextNumber = 1 Then
            lblText.Text = "I CAN'T STAND IT!!!"
        End If

        If IntTextNumber = 2 Then
            lblText.Text = "I...just don't understand..."
        End If

        If IntTextNumber = 3 Then
            lblText.Text = "Why do they hate me so?..."
        End If

        If IntTextNumber = 4 Then
            PicBlack.Hide()
            PicLoki.Show()
            lblText.Text = "Hi! I'm Loki. The paper Pokémon."
        End If

        If IntTextNumber = 5 Then
            lblText.Text = "Don't recognize me? Yeah... no surprise there..."
        End If

        If IntTextNumber = 6 Then
            lblText.Text = "Those Humans don't acknowledge us Lokis as real Pokémon, so we never made it in" & vbCrLf & "the offical Pokédex list..."
        End If

        If IntTextNumber = 7 Then
            PicLoki.Hide()
            PicDrawing.Show()
            lblText.Text = "Instead, they draw on our faces and make imitation airplanes out of us..."
        End If

        If IntTextNumber = 8 Then
            lblText.Text = "It's sad life being a Loki..."
        End If

        If IntTextNumber = 9 Then
            PicDrawing.Hide()
            PicSadLoki.Show()
            lblText.Text = "*Sob, Sob, Sob*"
        End If

        If IntTextNumber = 10 Then
            lblText.Text = "*Cries*"
        End If

        If IntTextNumber = 11 Then
            lblText.Text = "*Cries some more*"
        End If

        If IntTextNumber = 12 Then
            lblText.Text = "*Cries a whole lot more*"
        End If

        If IntTextNumber = 13 Then
            lblText.Text = "*Cries for hours and hours and hours and hours and hours*"
        End If

        If IntTextNumber = 14 Then
            PicLoki.Show()
            PicSadLoki.Hide()
            lblText.Text = "*Sniff, Sniff* Anyway..."
        End If

        If IntTextNumber = 15 Then
            lblText.Text = "I have to do something about this..."
        End If

        If IntTextNumber = 16 Then
            PicLoki.Hide()
            PicAngryLoki.Show()

            lblText.Text = "I MUST DO SOMETHING ABOUT THIS!!!"
        End If

        If IntTextNumber = 17 Then
            lblText.Text = "I will fight those other Pokémon until they acknoledge me as a SUPER Pokémon!!!"
        End If

        If IntTextNumber = 18 Then
            lblText.Text = "HA!"
        End If

        If IntTextNumber = 19 Then
            lblText.Text = "HAHA!"
        End If

        If IntTextNumber = 20 Then
            lblText.Text = "HAHAHAHAHAHAHAHA!"

        End If

        If IntTextNumber = 21 Then
            lblText.Text = "MUHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA!!!!"
        End If

        If IntTextNumber = 22 Then
            PicAngryLoki.Hide()
            PicBlack.Show()
            lblText.Text = "*And so, Loki's quest begun...*"
        End If

        If IntTextNumber = 23 Then
            Me.Hide()
            frmLokiVillage.Show()

        End If

    End Sub


    Private Sub frmStory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class