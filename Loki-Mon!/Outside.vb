Public Class frmOutside
    Public IntCharacterX As Integer
    Public IntCharacterY As Integer
    Public BlnHitwall As Boolean = False
    Public IntStepsTillBattle As Integer
    Public EnableBattle As Boolean = False
    Public IntTimeUntilBattle As Integer
    Public IntPokeNumber As Integer
    Public BlnPlayBattle As Boolean = False
    Public BlnOutside As Boolean = False
    Public blnPlay As Integer = False
    Dim IntPlayerText As Integer = True


    Private Sub frmOutside_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        BlnOutside = True
    End Sub


    Private Sub frmOutside_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        BlnOutside = True
        If e.KeyCode = Keys.Down Then

            PicLokiBack.Hide()
            PicLokiLeft.Hide()
            PicLokiRight.Hide()

            PicLokiFront.Show()
            If BlnHitwall = False Then
                IntCharacterY += 10
                If PicLokiFront.Right > PicEncounterBox.Left And PicLokiFront.Left < PicEncounterBox.Right And PicLokiFront.Top < PicEncounterBox.Bottom And PicLokiFront.Bottom > PicEncounterBox.Top Then
                    Randomize()
                    IntStepsTillBattle = Int((19 + 1) * Rnd() + 1)
                End If
              
            End If


        End If

        If e.KeyCode = Keys.Up Then
            PicLokiLeft.Hide()
            PicLokiRight.Hide()
            PicLokiFront.Hide()

            PicLokiBack.Show()
            If BlnHitwall = False Then
                IntCharacterY -= 10
                If PicLokiFront.Right > PicEncounterBox.Left And PicLokiFront.Left < PicEncounterBox.Right And PicLokiFront.Top < PicEncounterBox.Bottom And PicLokiFront.Bottom > PicEncounterBox.Top Then
                    Randomize()
                    IntStepsTillBattle = Int((19 + 1) * Rnd() + 1)
                End If
                
            End If

        End If

        If e.KeyCode = Keys.Left Then
            PicLokiFront.Hide()
            PicLokiBack.Hide()
            PicLokiRight.Hide()

            PicLokiLeft.Show()
            If BlnHitwall = False Then
                IntCharacterX -= 10
                If PicLokiFront.Right > PicEncounterBox.Left And PicLokiFront.Left < PicEncounterBox.Right And PicLokiFront.Top < PicEncounterBox.Bottom And PicLokiFront.Bottom > PicEncounterBox.Top Then
                    Randomize()
                    IntStepsTillBattle = Int((19 - 1) * Rnd() + 1)
                End If
              
            End If

        End If

        If e.KeyCode = Keys.Right Then
            PicLokiLeft.Hide()
            PicLokiFront.Hide()
            PicLokiBack.Hide()

            PicLokiRight.Show()
            If BlnHitwall = False Then
                IntCharacterX += 10
                If PicLokiFront.Right > PicEncounterBox.Left And PicLokiFront.Left < PicEncounterBox.Right And PicLokiFront.Top < PicEncounterBox.Bottom And PicLokiFront.Bottom > PicEncounterBox.Top Then
                    Randomize()
                    IntStepsTillBattle = Int((19 + 1) * Rnd() + 1)
                End If
             
            End If

        End If

        If IntStepsTillBattle = 20 Then
            EnableBattle = True
        End If

        If EnableBattle = True Then
            PicPokeBall.Show()
            lblLokiName.Hide()
            lblNameBack.Hide()
            lblInfo.Hide()
            PrgLokiHP.Hide()
            tmrPokeballRoll.Enabled = True
            BlnHitwall = True
        Else
            PicPokeBall.Hide()
            tmrPokeballRoll.Enabled = False
            lblLokiName.Show()
            lblNameBack.Show()
            PrgLokiHP.Show()
        End If


        lblInfo.Text = "Level: " & frmBattle.IntLevel & " EXP:" & frmBattle.IntEXP & "/" & frmBattle.IntMaxEXP

        If PicLokiFront.Right > PicTalk.Left And PicLokiFront.Left < PicTalk.Right And PicLokiFront.Top < PicTalk.Bottom And PicLokiFront.Bottom > PicTalk.Top Then
            lblBorder.Show()
            lblLokiText.Show()
            lblLokiText.Text = "Press Z Talk with Trainer. (You will not be able to return from this point)"
        ElseIf PicLokiFront.Right > PicNogoingback.Left And PicLokiFront.Left < PicNogoingback.Right And PicLokiFront.Top < PicNogoingback.Bottom And PicLokiFront.Bottom > PicNogoingback.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "No going back now!"
        ElseIf PicLokiFront.Right > PicBackLokiVillage.Left And PicLokiFront.Left < PicBackLokiVillage.Right And PicLokiFront.Top < PicBackLokiVillage.Bottom And PicLokiFront.Bottom > PicBackLokiVillage.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "That way leads back to Loki Village!"
        Else
            lblBorder.Hide()
            lblLokiText.Hide()

        End If
        If e.KeyCode = Keys.Z And PicLokiFront.Right > PicTalk.Left And PicLokiFront.Left < PicTalk.Right And PicLokiFront.Top < PicTalk.Bottom And PicLokiFront.Bottom > PicTalk.Top Then
            BlnHitwall = True
            BlnPlayBattle = True
        End If

        If BlnPlayBattle = True Then
            IntStepsTillBattle = 0
            BlnHitwall = True
            IntPokeNumber = 5
            BlnPlayBattle = True


            If e.KeyCode = Keys.Z Then
                IntPlayerText += 1
                IntPokeNumber = 5
            End If
            If IntPlayerText = 1 Then
                lblLokiText.Text = "???: What's this?"
            End If

            If IntPlayerText = 2 Then
                lblLokiText.Text = "???: An unknown Pokémon?"
            End If
            If IntPlayerText = 3 Then
                lblLokiText.Text = "???: Hmmph... Looks weak...Should be an easy catch."
            End If
            If IntPlayerText >= 4 Then
                lblLokiText.Text = "Bob the Trainer: NOBODY CAN DEFEAT ME AND MY BULBASAUR, FOR I AM BOB THE TRAINER!!!"
                IntPokeNumber = 5

                EnableBattle = True

            End If

        End If

        'Walls
        'Walls
        'Wall 1
        If PicLokiFront.Right > PicWall1.Left And PicLokiFront.Left < PicWall1.Right And PicLokiFront.Top < PicWall1.Bottom And PicLokiFront.Bottom > PicWall1.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall1.Bottom And PicLokiFront.Top > PicWall1.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall1.Top And PicLokiFront.Bottom < PicWall1.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall1.Left And PicLokiFront.Right < PicWall1.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Left < PicWall1.Right And PicLokiFront.Left > PicWall1.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 2

        If PicLokiFront.Right > PicWall2.Left And PicLokiFront.Left < PicWall2.Right And PicLokiFront.Top < PicWall2.Bottom And PicLokiFront.Bottom > PicWall2.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall2.Bottom And PicLokiFront.Top > PicWall2.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall2.Top And PicLokiFront.Bottom < PicWall2.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall2.Left And PicLokiFront.Right < PicWall2.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall2.Right And PicLokiFront.Left > PicWall2.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 3

        If PicLokiFront.Right > PicWall3.Left And PicLokiFront.Left < PicWall3.Right And PicLokiFront.Top < PicWall3.Bottom And PicLokiFront.Bottom > PicWall3.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall3.Bottom And PicLokiFront.Top > PicWall3.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall3.Top And PicLokiFront.Bottom < PicWall3.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall3.Left And PicLokiFront.Right < PicWall3.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall3.Right And PicLokiFront.Left > PicWall3.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 4

        If PicLokiFront.Right > PicWall4.Left And PicLokiFront.Left < PicWall4.Right And PicLokiFront.Top < PicWall4.Bottom And PicLokiFront.Bottom > PicWall4.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall4.Bottom And PicLokiFront.Top > PicWall4.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall4.Top And PicLokiFront.Bottom < PicWall4.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall4.Left And PicLokiFront.Right < PicWall4.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall4.Right And PicLokiFront.Left > PicWall4.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 5
        If PicLokiFront.Right > PicWall5.Left And PicLokiFront.Left < PicWall5.Right And PicLokiFront.Top < PicWall5.Bottom And PicLokiFront.Bottom > PicWall5.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall5.Bottom And PicLokiFront.Top > PicWall5.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall5.Top And PicLokiFront.Bottom < PicWall5.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall5.Left And PicLokiFront.Right < PicWall5.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall5.Right And PicLokiFront.Left > PicWall5.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 6
        If PicLokiFront.Right > PicWall6.Left And PicLokiFront.Left < PicWall6.Right And PicLokiFront.Top < PicWall6.Bottom And PicLokiFront.Bottom > PicWall6.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall6.Bottom And PicLokiFront.Top > PicWall6.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall6.Top And PicLokiFront.Bottom < PicWall6.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall6.Left And PicLokiFront.Right < PicWall6.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall6.Right And PicLokiFront.Left > PicWall6.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 7
        If PicLokiFront.Right > PicWall7.Left And PicLokiFront.Left < PicWall7.Right And PicLokiFront.Top < PicWall7.Bottom And PicLokiFront.Bottom > PicWall7.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall7.Bottom And PicLokiFront.Top > PicWall7.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall7.Top And PicLokiFront.Bottom < PicWall7.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall7.Left And PicLokiFront.Right < PicWall7.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall7.Right And PicLokiFront.Left > PicWall7.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 8
        If PicLokiFront.Right > PicWall8.Left And PicLokiFront.Left < PicWall8.Right And PicLokiFront.Top < PicWall8.Bottom And PicLokiFront.Bottom > PicWall8.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall8.Bottom And PicLokiFront.Top > PicWall8.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall8.Top And PicLokiFront.Bottom < PicWall8.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall8.Left And PicLokiFront.Right < PicWall8.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall8.Right And PicLokiFront.Left > PicWall8.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        ' Wall 9
        If PicLokiFront.Right > PicWall9.Left And PicLokiFront.Left < PicWall9.Right And PicLokiFront.Top < PicWall9.Bottom And PicLokiFront.Bottom > PicWall9.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall9.Bottom And PicLokiFront.Top > PicWall9.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall9.Top And PicLokiFront.Bottom < PicWall9.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall9.Left And PicLokiFront.Right < PicWall9.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall9.Right And PicLokiFront.Left > PicWall9.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 10
        If PicLokiFront.Right > PicWall10.Left And PicLokiFront.Left < PicWall10.Right And PicLokiFront.Top < PicWall10.Bottom And PicLokiFront.Bottom > PicWall10.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall10.Bottom And PicLokiFront.Top > PicWall10.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall10.Top And PicLokiFront.Bottom < PicWall10.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall10.Left And PicLokiFront.Right < PicWall10.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall10.Right And PicLokiFront.Left > PicWall10.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        PicLokiFront.Left = IntCharacterX
        PicLokiFront.Top = IntCharacterY
        PicLokiBack.Left = IntCharacterX
        PicLokiBack.Top = IntCharacterY
        PicLokiLeft.Left = IntCharacterX
        PicLokiLeft.Top = IntCharacterY
        PicLokiRight.Left = IntCharacterX
        PicLokiRight.Top = IntCharacterY

    End Sub

   

    Private Sub tmrRefreshScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefreshScreen.Tick
        DoubleBuffered = True
        BlnOutside = True
        PrgLokiHP.Value = frmBattle.IntLokiHP
        PrgLokiHP.Value = frmBattle.IntLokiMaxHP
        If EnableBattle = True Then
            PicPokeBall.Show()
            lblLokiName.Hide()
            lblNameBack.Hide()
            lblInfo.Hide()
            PrgLokiHP.Hide()
            tmrPokeballRoll.Enabled = True
            BlnHitwall = True

            If BlnPlayBattle = True Then
                IntPokeNumber = 5
            End If
        Else
            PicPokeBall.Hide()
            tmrPokeballRoll.Enabled = False
            lblLokiName.Show()
            lblNameBack.Show()
            PrgLokiHP.Show()
            lblInfo.Show()
        End If


        lblInfo.Text = "Level: " & frmBattle.IntLevel & " EXP:" & frmBattle.IntEXP & "/" & frmBattle.IntMaxEXP

    End Sub

    Private Sub frmOutside_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IntCharacterX = 157
        IntCharacterY = 239
        PicPokeBall.Left = 200
        lblLokiName.Show()
        lblNameBack.Show()
        PrgLokiHP.Show()
        lblInfo.Show()
        My.Computer.Audio.Play(My.Resources.Outside, AudioPlayMode.BackgroundLoop)
    End Sub


    Private Sub tmrPokeballRoll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPokeballRoll.Tick
        If EnableBattle = True Then


            If blnPlay = False Then
                My.Computer.Audio.Play(My.Resources.BattleMusic, AudioPlayMode.BackgroundLoop)
                blnPlay = True
            End If

            BlnHitwall = True
            IntTimeUntilBattle += 1


            If IntTimeUntilBattle > 15 Then

                If BlnPlayBattle = False Then
                    IntPokeNumber = Int((4 - 3 + 1) * Rnd() + 3)
                End If
                If BlnPlayBattle = True Then
                    IntPokeNumber = 5
                    frmBattle.IntPokeNumber = 5
                    BlnPlayBattle = True
                End If

                EnableBattle = False
                IntTimeUntilBattle = 0

                Me.Hide()

                frmBattle.Show()
                frmBattle.WindowState = FormWindowState.Normal


            End If

        End If
    End Sub


End Class