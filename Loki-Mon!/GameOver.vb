Public Class frmGameOver

    Private Sub frmGameOver_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.GameOver, AudioPlayMode.BackgroundLoop)
    End Sub
End Class