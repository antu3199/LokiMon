Public Class frmCave
    Public IntCharacterX As Integer = 90
    Public IntCharacterY As Integer = 280
    Public BlnHitwall As Boolean = False
    Public IntStepsTillBattle As Integer = 0
    Public EnableBattle As Boolean = False
    Public IntTimeUntilBattle As Integer = 0
    Public IntPokeNumber As Integer
    Public BlnPlayBattle As Boolean = False
    Public blnPlay As Boolean = False
    Dim IntDelay As Integer = 0
    Private Sub frmCave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Randomize()
        If e.KeyCode = Keys.Down Then

            PicLokiBack.Hide()
            PicLokiLeft.Hide()
            PicLokiRight.Hide()

            PicLokiFront.Show()
            If BlnHitwall = False Then
                IntCharacterY += 10
                IntStepsTillBattle = Int((19 + 1) * Rnd() + 1)
             
            End If

        End If

        If e.KeyCode = Keys.Up Then
            PicLokiLeft.Hide()
            PicLokiRight.Hide()
            PicLokiFront.Hide()

            PicLokiBack.Show()
            If BlnHitwall = False Then
                IntCharacterY -= 10
                IntStepsTillBattle = Int((19 + 1) * Rnd() + 1)
                
            End If

        End If

        If e.KeyCode = Keys.Left Then
            PicLokiFront.Hide()
            PicLokiBack.Hide()
            PicLokiRight.Hide()

            PicLokiLeft.Show()
            If BlnHitwall = False Then
                IntCharacterX -= 10
                IntStepsTillBattle = Int((19 - 1) * Rnd() + 1)
              
            End If

        End If

        If e.KeyCode = Keys.Right Then
            PicLokiLeft.Hide()
            PicLokiFront.Hide()
            PicLokiBack.Hide()

            PicLokiRight.Show()
            If BlnHitwall = False Then
                IntCharacterX += 10
                IntStepsTillBattle = Int((19 + 1) * Rnd() + 1)
               
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


        'Go Outside
        If PicLokiFront.Right > PicOutside.Left And PicLokiFront.Left < PicOutside.Right And PicLokiFront.Top < PicOutside.Bottom And PicLokiFront.Bottom > PicOutside.Top Then

            IntCharacterX = 157
            IntCharacterY = 244
            ' My.Computer.Audio.Stop()
            Me.Hide()


            frmOutside.Show()
            frmOutside.WindowState = FormWindowState.Normal
        End If
        'Text Boxes
        If (PicLokiFront.Right > PicLadder.Left And PicLokiFront.Left < PicLadder.Right And PicLokiFront.Top < PicLadder.Bottom And PicLokiFront.Bottom > PicLadder.Top) Or (PicLokiFront.Right > PicLadder2.Left And PicLokiFront.Left < PicLadder2.Right And PicLokiFront.Top < PicLadder2.Bottom And PicLokiFront.Bottom > PicLadder2.Top) Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "Press Z to use the ladder."
        ElseIf PicLokiFront.Right > PicNoGoingBack.Left And PicLokiFront.Left < PicNoGoingBack.Right And PicLokiFront.Top < PicNoGoingBack.Bottom And PicLokiFront.Bottom > PicNoGoingBack.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "No going back now!"
        Else
            lblLokiText.Hide()
            lblBorder.Hide()
        End If
        If e.KeyCode = Keys.Z And PicLokiFront.Right > PicLadder.Left And PicLokiFront.Left < PicLadder.Right And PicLokiFront.Top < PicLadder.Bottom And PicLokiFront.Bottom > PicLadder.Top And IntDelay > 5 Then
            IntCharacterX = 300
            IntCharacterY = 310
            PicLokiFront.Show()
            IntDelay = 0
        End If
        If e.KeyCode = Keys.Z And PicLokiFront.Right > PicLadder2.Left And PicLokiFront.Left < PicLadder2.Right And PicLokiFront.Top < PicLadder2.Bottom And PicLokiFront.Bottom > PicLadder2.Top And IntDelay > 5 Then
            IntCharacterX = 620
            IntCharacterY = 110
            PicLokiFront.Show()
            IntDelay = 0
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
        If PicLokiFront.Right > Picwall6.Left And PicLokiFront.Left < Picwall6.Right And PicLokiFront.Top < Picwall6.Bottom And PicLokiFront.Bottom > Picwall6.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < Picwall6.Bottom And PicLokiFront.Top > Picwall6.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > Picwall6.Top And PicLokiFront.Bottom < Picwall6.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > Picwall6.Left And PicLokiFront.Right < Picwall6.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < Picwall6.Right And PicLokiFront.Left > Picwall6.Right - 20 Then
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

        'Wall 11
        If PicLokiFront.Right > PicWall11.Left And PicLokiFront.Left < PicWall11.Right And PicLokiFront.Top < PicWall11.Bottom And PicLokiFront.Bottom > PicWall11.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall11.Bottom And PicLokiFront.Top > PicWall11.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall11.Top And PicLokiFront.Bottom < PicWall11.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall11.Left And PicLokiFront.Right < PicWall11.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall11.Right And PicLokiFront.Left > PicWall11.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 12
        If PicLokiFront.Right > Picwall12.Left And PicLokiFront.Left < Picwall12.Right And PicLokiFront.Top < Picwall12.Bottom And PicLokiFront.Bottom > Picwall12.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < Picwall12.Bottom And PicLokiFront.Top > Picwall12.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > Picwall12.Top And PicLokiFront.Bottom < Picwall12.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > Picwall12.Left And PicLokiFront.Right < Picwall12.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < Picwall12.Right And PicLokiFront.Left > Picwall12.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 13
        If PicLokiFront.Right > Picwall13.Left And PicLokiFront.Left < Picwall13.Right And PicLokiFront.Top < Picwall13.Bottom And PicLokiFront.Bottom > Picwall13.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < Picwall13.Bottom And PicLokiFront.Top > Picwall13.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > Picwall13.Top And PicLokiFront.Bottom < Picwall13.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > Picwall13.Left And PicLokiFront.Right < Picwall13.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < Picwall13.Right And PicLokiFront.Left > Picwall13.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 14
        If PicLokiFront.Right > PicWall14.Left And PicLokiFront.Left < PicWall14.Right And PicLokiFront.Top < PicWall14.Bottom And PicLokiFront.Bottom > PicWall14.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall14.Bottom And PicLokiFront.Top > PicWall14.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall14.Top And PicLokiFront.Bottom < PicWall14.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall14.Left And PicLokiFront.Right < PicWall14.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall14.Right And PicLokiFront.Left > PicWall14.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 15
        If PicLokiFront.Right > PicWall15.Left And PicLokiFront.Left < PicWall15.Right And PicLokiFront.Top < PicWall15.Bottom And PicLokiFront.Bottom > PicWall15.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall15.Bottom And PicLokiFront.Top > PicWall15.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall15.Top And PicLokiFront.Bottom < PicWall15.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall15.Left And PicLokiFront.Right < PicWall15.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall15.Right And PicLokiFront.Left > PicWall15.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 16
        If PicLokiFront.Right > PicWall16.Left And PicLokiFront.Left < PicWall16.Right And PicLokiFront.Top < PicWall16.Bottom And PicLokiFront.Bottom > PicWall16.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall16.Bottom And PicLokiFront.Top > PicWall16.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall16.Top And PicLokiFront.Bottom < PicWall16.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall16.Left And PicLokiFront.Right < PicWall16.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall16.Right And PicLokiFront.Left > PicWall16.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 17
        If PicLokiFront.Right > PicWall17.Left And PicLokiFront.Left < PicWall17.Right And PicLokiFront.Top < PicWall17.Bottom And PicLokiFront.Bottom > PicWall17.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall17.Bottom And PicLokiFront.Top > PicWall17.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall17.Top And PicLokiFront.Bottom < PicWall17.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall17.Left And PicLokiFront.Right < PicWall17.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall17.Right And PicLokiFront.Left > PicWall17.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 18
        If PicLokiFront.Right > PicWall18.Left And PicLokiFront.Left < PicWall18.Right And PicLokiFront.Top < PicWall18.Bottom And PicLokiFront.Bottom > PicWall18.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall18.Bottom And PicLokiFront.Top > PicWall18.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall18.Top And PicLokiFront.Bottom < PicWall18.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall18.Left And PicLokiFront.Right < PicWall18.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall18.Right And PicLokiFront.Left > PicWall18.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If
        'Wall 19
        If PicLokiFront.Right > PicWall19.Left And PicLokiFront.Left < PicWall19.Right And PicLokiFront.Top < PicWall19.Bottom And PicLokiFront.Bottom > PicWall19.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall19.Bottom And PicLokiFront.Top > PicWall19.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall19.Top And PicLokiFront.Bottom < PicWall19.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall19.Left And PicLokiFront.Right < PicWall19.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall19.Right And PicLokiFront.Left > PicWall19.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 20
        If PicLokiFront.Right > PicWall20.Left And PicLokiFront.Left < PicWall20.Right And PicLokiFront.Top < PicWall20.Bottom And PicLokiFront.Bottom > PicWall20.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall20.Bottom And PicLokiFront.Top > PicWall20.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall20.Top And PicLokiFront.Bottom < PicWall20.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall20.Left And PicLokiFront.Right < PicWall20.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall20.Right And PicLokiFront.Left > PicWall20.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 21
        If PicLokiFront.Right > PicWall21.Left And PicLokiFront.Left < PicWall21.Right And PicLokiFront.Top < PicWall21.Bottom And PicLokiFront.Bottom > PicWall21.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall21.Bottom And PicLokiFront.Top > PicWall21.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall21.Top And PicLokiFront.Bottom < PicWall21.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall21.Left And PicLokiFront.Right < PicWall21.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall21.Right And PicLokiFront.Left > PicWall21.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 22

        If PicLokiFront.Right > PicWall22.Left And PicLokiFront.Left < PicWall22.Right And PicLokiFront.Top < PicWall22.Bottom And PicLokiFront.Bottom > PicWall22.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall22.Bottom And PicLokiFront.Top > PicWall22.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall22.Top And PicLokiFront.Bottom < PicWall22.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall22.Left And PicLokiFront.Right < PicWall22.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall22.Right And PicLokiFront.Left > PicWall22.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 23

        If PicLokiFront.Right > PicWall23.Left And PicLokiFront.Left < PicWall23.Right And PicLokiFront.Top < PicWall23.Bottom And PicLokiFront.Bottom > PicWall23.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall23.Bottom And PicLokiFront.Top > PicWall23.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall23.Top And PicLokiFront.Bottom < PicWall23.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall23.Left And PicLokiFront.Right < PicWall23.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall23.Right And PicLokiFront.Left > PicWall23.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 24

        If PicLokiFront.Right > PicWall24.Left And PicLokiFront.Left < PicWall24.Right And PicLokiFront.Top < PicWall24.Bottom And PicLokiFront.Bottom > PicWall24.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall24.Bottom And PicLokiFront.Top > PicWall24.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall24.Top And PicLokiFront.Bottom < PicWall24.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall24.Left And PicLokiFront.Right < PicWall24.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall24.Right And PicLokiFront.Left > PicWall24.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 25

        If PicLokiFront.Right > PicWall25.Left And PicLokiFront.Left < PicWall25.Right And PicLokiFront.Top < PicWall25.Bottom And PicLokiFront.Bottom > PicWall25.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall25.Bottom And PicLokiFront.Top > PicWall25.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall25.Top And PicLokiFront.Bottom < PicWall25.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall25.Left And PicLokiFront.Right < PicWall25.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall25.Right And PicLokiFront.Left > PicWall25.Right - 20 Then
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

    Private Sub tmrDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        IntDelay += 1
    End Sub

    Private Sub frmCave_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IntCharacterX = 90
        IntCharacterY = 280
        PicPokeBall.Left = 200
    
        My.Computer.Audio.Play(My.Resources.PokeCave, AudioPlayMode.BackgroundLoop)
        lblLokiName.Show()
        lblNameBack.Show()
        PrgLokiHP.Show()
        lblInfo.Show()
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
                IntPokeNumber = Int((2 - 1 + 1) * Rnd() + 1)

                EnableBattle = False
                IntTimeUntilBattle = 0

                Me.Hide()

                frmBattle.Show()
                frmBattle.WindowState = FormWindowState.Normal


            End If

        End If
    End Sub
End Class