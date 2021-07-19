Public Class frmLokiVillage
    Public IntCharacterX As Integer = 325
    Public IntCharacterY As Integer = 85
    Public BlnHitwall As Boolean = False

    Sub PlayBackgroundSoundFile()
        ' My.Computer.Audio.Play("K:\ICS20\Loki-Mon!\Loki-Mon!\LokiVillage.wav",
        ' AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub frmMap_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Control
        If e.KeyCode = Keys.Down Then

            PicLokiBack.Hide()
            PicLokiLeft.Hide()
            PicLokiRight.Hide()

            PicLokiFront.Show()
            If BlnHitwall = False Then
                IntCharacterY += 10
             
            End If

        End If

        If e.KeyCode = Keys.Up Then
            PicLokiLeft.Hide()
            PicLokiRight.Hide()
            PicLokiFront.Hide()

            PicLokiBack.Show()
            If BlnHitwall = False Then
                IntCharacterY -= 10
                
            End If
        End If

        If e.KeyCode = Keys.Left Then
            PicLokiFront.Hide()
            PicLokiBack.Hide()
            PicLokiRight.Hide()

            PicLokiLeft.Show()
            If BlnHitwall = False Then
                IntCharacterX -= 10
               
            End If
        End If

        If e.KeyCode = Keys.Right Then
            PicLokiLeft.Hide()
            PicLokiFront.Hide()
            PicLokiBack.Hide()

            PicLokiRight.Show()
            If BlnHitwall = False Then
                IntCharacterX += 10
                '
            End If
        End If
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
        If PicLokiFront.Right > PicWall12.Left And PicLokiFront.Left < PicWall12.Right And PicLokiFront.Top < PicWall12.Bottom And PicLokiFront.Bottom > PicWall12.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall12.Bottom And PicLokiFront.Top > PicWall12.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall12.Top And PicLokiFront.Bottom < PicWall12.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall12.Left And PicLokiFront.Right < PicWall12.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall12.Right And PicLokiFront.Left > PicWall12.Right - 20 Then
                If e.KeyCode = Keys.Left Then
                    IntCharacterX += 10
                End If
                BlnHitwall = False
            End If
        End If

        'Wall 13
        If PicLokiFront.Right > PicWall13.Left And PicLokiFront.Left < PicWall13.Right And PicLokiFront.Top < PicWall13.Bottom And PicLokiFront.Bottom > PicWall13.Top Then
            BlnHitwall = True
            If PicLokiFront.Top < PicWall13.Bottom And PicLokiFront.Top > PicWall13.Bottom - 20 Then
                If e.KeyCode = Keys.Up Then
                    IntCharacterY += 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Bottom > PicWall13.Top And PicLokiFront.Bottom < PicWall13.Top + 20 Then
                If e.KeyCode = Keys.Down Then
                    IntCharacterY -= 10
                End If
                BlnHitwall = False
            End If
            If PicLokiFront.Right > PicWall13.Left And PicLokiFront.Right < PicWall13.Left + 20 Then
                If e.KeyCode = Keys.Right Then
                    IntCharacterX -= 10
                End If
                BlnHitwall = False

            End If
            If PicLokiFront.Left < PicWall13.Right And PicLokiFront.Left > PicWall13.Right - 20 Then
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

        'Texts
        If PicLokiFront.Right > PicTextArea1.Left And PicLokiFront.Left < PicTextArea1.Right And PicLokiFront.Top < PicTextArea1.Bottom And PicLokiFront.Bottom > PicTextArea1.Top Then
            lblLokiText.Show()
            PicLeftArrow.Show()
            PicLeftArrow2.Show()
            lblCave.Show()
            lblTHISISME.Show()
            lblBorder.Show()

            lblLokiText.Text = "Loki: This is Loki Village. There's nothing to fight except other Lokis here." & vbCrLf & " I better go find another place to prove my worth." & vbCrLf & "That cave over there seems to be the best place."
            'Text 2
        ElseIf PicLokiFront.Right > PicTextArea2.Left And PicLokiFront.Left < PicTextArea2.Right And PicLokiFront.Top < PicTextArea2.Bottom And PicLokiFront.Bottom > PicTextArea2.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "Bob: I heard you were going on an adventure. What a brave little fellow." & vbCrLf & "Sam: OH MY GOD! YOU'RE MY HERO! I LOVE YOU SO MUCH!!!♥~" & vbCrLf & "Loki: Uhh...Okay..."
            'Text 3
        ElseIf PicLokiFront.Right > PicTextArea3.Left And PicLokiFront.Left < PicTextArea3.Right And PicLokiFront.Top < PicTextArea3.Bottom And PicLokiFront.Bottom > PicTextArea3.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "The Loki Elder: Best of luck to you on your adventure, young Loki. Give" & vbCrLf & "those other Pokémon a name to remember!" & vbCrLf & "Loki: I will, Elder. Don't worry."
            'Text 4
        ElseIf PicLokiFront.Right > PicTextArea4.Left And PicLokiFront.Left < PicTextArea4.Right And PicLokiFront.Top < PicTextArea4.Bottom And PicLokiFront.Bottom > PicTextArea4.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "Charmander: What are you looking at? Do you want to burn to death? GO AWAY!!!"
            'Text 5
        ElseIf PicLokiFront.Right > PicTextArea5.Left And PicLokiFront.Left < PicTextArea5.Right And PicLokiFront.Top < PicTextArea5.Bottom And PicLokiFront.Bottom > PicTextArea5.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "Suspicious Loki: This is MY corner. Get out."
        ElseIf PicLokiFront.Right > PicTextArea6.Left And PicLokiFront.Left < PicTextArea6.Right And PicLokiFront.Top < PicTextArea6.Bottom And PicLokiFront.Bottom > PicTextArea6.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "Loki One: Good luck!" & vbCrLf & "Loki Two: But don't forget..." & vbCrLf & "Loki Three: To have fun!"
        ElseIf PicLokiFront.Right > PicTextArea7.Left And PicLokiFront.Left < PicTextArea7.Right And PicLokiFront.Top < PicTextArea7.Bottom And PicLokiFront.Bottom > PicTextArea7.Top Then
            lblLokiText.Show()
            lblBorder.Show()
            lblLokiText.Text = "Loki: Typical Snorlax..."
        Else
            lblLokiText.Text = Nothing
            PicLeftArrow.Hide()
            PicLeftArrow2.Hide()
            lblCave.Hide()
            lblTHISISME.Hide()
            lblBorder.Hide()
        End If


        'Cave Entrance
        If PicLokiFront.Right > PicCaveEntrance.Left And PicLokiFront.Left < PicCaveEntrance.Right And PicLokiFront.Top < PicCaveEntrance.Bottom And PicLokiFront.Bottom > PicCaveEntrance.Top Then

            IntCharacterX = 90
            IntCharacterY = 280
            My.Computer.Audio.Stop()
            Me.Hide()

            frmCave.Show()
            frmCave.WindowState = FormWindowState.Normal
        End If


        PicLokiFront.Left = IntCharacterX
        PicLokiFront.Top = IntCharacterY
        PicLokiBack.Left = IntCharacterX
        PicLokiBack.Top = IntCharacterY
        PicLokiLeft.Left = IntCharacterX
        PicLokiLeft.Top = IntCharacterY
        PicLokiRight.Left = IntCharacterX
        PicLokiRight.Top = IntCharacterY



        If lblLokiText.Text = Nothing Then
            lblLokiText.Hide()

        End If


    End Sub

    Private Sub frmMap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub



    Private Sub frmMap_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'zBlnHitwall = False
    End Sub


    Private Sub lblCave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCave.Click

    End Sub

    Private Sub PicWall13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicWall13.Click

    End Sub

    Private Sub frmMap_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If PicLokiFront.Right > PicTextArea1.Left And PicLokiFront.Left < PicTextArea1.Right And PicLokiFront.Top < PicTextArea1.Bottom And PicLokiFront.Bottom > PicTextArea1.Top Then
            lblLokiText.Show()
            PicLeftArrow.Show()
            PicLeftArrow2.Show()
            lblCave.Show()
            lblTHISISME.Show()
            lblBorder.Show()

            lblLokiText.Text = "Loki: This is Loki Village. There's nothing to fight except other Lokis here." & vbCrLf & " I better go find another place to prove my worth." & vbCrLf & "That cave over there seems to be the best place."
        End If
        My.Computer.Audio.Play(My.Resources.LokiVillage, AudioPlayMode.BackgroundLoop)


    End Sub
End Class