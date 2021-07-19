Public Class frmTitleScreen
    Dim IntHandLoc As Integer = 1
    'Loki-Mon
    'January 2013
    'Anthony Tu
    'Is a game about the Pokemon world where Loki is an unknown Pokemon. The Pokemon battle system is simulated.
    'Note: There used to be music (working on these computers too), but then it had a last minute error so I commented it all out.

    Private Sub frmTitleScreen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            IntHandLoc += 1

        End If
        If e.KeyCode = Keys.Up Then
            IntHandLoc -= 1

        End If
        If IntHandLoc > 3 Then
            IntHandLoc = 3
        End If
        If IntHandLoc < 1 Then
            IntHandLoc = 1
        End If

        If IntHandLoc = 1 Then
            Pichand.Top = 200
        End If
        If IntHandLoc = 2 Then
            Pichand.Top = 260

        End If

        If IntHandLoc = 3 Then
            Pichand.Top = 320
        End If

        If IntHandLoc = 1 And e.KeyCode = Keys.Z Then

            Me.Hide()
            frmStory.Show()
            frmStory.WindowState = FormWindowState.Normal
        End If
        If IntHandLoc = 2 And e.KeyCode = Keys.Z Then
            Me.Hide()
            frmControls.Show()
            frmControls.WindowState = FormWindowState.Normal


        End If
        If IntHandLoc = 3 And e.KeyCode = Keys.Z Then
            Application.Exit()
        End If

    End Sub

    Private Sub frmTitleScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
        My.Computer.Audio.Play(My.Resources.SadSong, AudioPlayMode.BackgroundLoop)
      
    End Sub

End Class
