Public Class frmControls

    Private Sub frmInstructions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.X Then
            Me.Hide()
            frmTitleScreen.Show()

        End If
    End Sub
End Class