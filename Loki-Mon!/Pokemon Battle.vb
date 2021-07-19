Public Class frmBattle
    Public IntLevel As Integer = 1
    Public IntLStrength As Integer = 5
    Public IntLDefence As Integer = 10
    Public IntEXP As Integer = 0
    Public IntMaxEXP As Integer = 50
    Public IntLevelEXP As Integer = 100
    Public IntLokiHP As Integer = 100
    Public IntLokiMaxHP As Integer = 100
    Public IntOpponentHP As Integer = 50
    Public IntPokeNumber As Integer = 0
    Dim IntOpponentAttack As Integer = 0
    Dim IntOpponentDefence As Integer = 0
    Dim IntOpponentChooseAttack As Integer = 0
    Dim IntHandSelection As Integer = 1
    Dim BlnBattleMode As Boolean = False
    Dim IntTurn As Integer = 1
    Dim IntBattleText As Integer = 0
    Dim BlnAtkPaperCut As Boolean = False
    Dim IntDelay As Integer = 0
    Dim IntOpponentFlash As Integer = 0
    Dim IntLokiFlash As Integer = 0
    Dim IntOpponentHit As Boolean = False
    Dim IntAttackAct As Integer = 0
    Dim IntLDamage As Integer = 0
    Dim IntODamage As Integer = 0
    Dim BlnZubatScreech As Boolean = False
    Dim WinGame As Boolean = False
    Dim IntGainedEXP As Integer = 0
    Dim IntWinningText As Integer = 0
    Public BlnTransferWin As Boolean = False
    Dim BlnAtkPaperPunch As Boolean = False
    Dim IntPaperPunchStop As Integer = 0
    Dim BlnLokiHit As Boolean = False
    Dim BlnAtkWiggle As Boolean = False
    Dim BlnAtkHyperBeam As Boolean = False
    Dim BlnRockThrow As Boolean = False
    Dim BlnOppHit As Boolean = False
    Dim blnGust As Boolean = False
    Dim blnString As Boolean = False
    Dim blnItemMode As Boolean = False
    Dim IntPotions As Integer = 5
    Dim blnRunMode As Boolean = False
    Dim IntRunNumber As Integer = 0
    Dim blnLeaf As Boolean = False
    Dim BlnLose As Boolean
    Dim IntLosingText As Integer = 0
    Dim BlnActivate As Boolean = False
    Dim BlnPotionUse As Boolean = False



    Private Sub Restart()
        PicCursor.Left = 100
        PicCursor.Top = 340
        If frmOutside.BlnOutside = False Then
            IntPokeNumber = frmCave.IntPokeNumber
        End If
        If frmOutside.BlnOutside = True Then
            IntPokeNumber = frmOutside.IntPokeNumber
        End If

        PrgLokiHP.Maximum = IntLokiMaxHP
        PrgLokiHP.Value = IntLokiHP
        If IntPokeNumber = 1 Then
            lblOpponentName.Text = "Zubat"
            IntOpponentHP = 50
            prgOHealth.Maximum = IntOpponentHP
            IntOpponentAttack = 5
            IntOpponentDefence = 10
            PicZubat.Show()
            PicGeodude.Hide()
            PicPidgey.Hide()
            PicCaterpie.Hide()
        End If
        If IntPokeNumber = 2 Then
            lblOpponentName.Text = "Geodude"
            IntOpponentHP = 75

            prgOHealth.Maximum = IntOpponentHP
            IntOpponentAttack = 20
            IntOpponentDefence = 20
            PicGeodude.Show()
            PicZubat.Hide()
            PicPidgey.Hide()
            PicCaterpie.Hide()

        End If

        If IntPokeNumber = 3 Then
            lblOpponentName.Text = "Pidgey"
            IntOpponentHP = 75
            prgOHealth.Maximum = IntOpponentHP
            IntOpponentAttack = 50
            IntOpponentDefence = 30
            PicPidgey.Show()
            PicGeodude.Hide()
            PicZubat.Hide()
            PicCaterpie.Hide()
        End If

        If IntPokeNumber = 4 Then
            lblOpponentName.Text = "Caterpie"
            IntOpponentHP = 75
            prgOHealth.Maximum = IntOpponentHP
            IntOpponentAttack = 10
            IntOpponentDefence = 60
            PicCaterpie.Show()
            PicPidgey.Hide()
            PicGeodude.Hide()
            PicZubat.Hide()
        End If

        If IntPokeNumber = 5 Then
            lblOpponentName.Text = "Bob's Bulbasaur"
            IntOpponentHP = 100
            prgOHealth.Maximum = IntOpponentHP
            IntOpponentAttack = 50
            IntOpponentDefence = 75
            PicBulb.Show()
            PicCaterpie.Hide()
            PicPidgey.Hide()
            PicGeodude.Hide()
            PicZubat.Hide()

        End If

        lblButton1.Show()
        lblButton2.Show()
        lblButton3.Show()
        lblButton4.Show()
        lblButton1.Text = "Fight!"
        lblButton2.Text = "Bag"
        lblButton4.Text = "Run!"
        lblButton3.Text = "Pokémon"
        PicPaperCut.Left = -70
        IntBattleText = 0
        IntWinningText = 0
        IntTurn = 1
        IntAttackAct = 0
        IntHandSelection = 1
        PicCursor.Left = 100
        PicCursor.Top = 340
        PicCursor.Show()
        IntHandSelection = 1

        BlnBattleMode = False
        lblBattleText.Hide()
        IntWinningText = 0
        BlnAtkPaperCut = False
        PicPaperCut.Left = -70
        tmrPaperCut.Enabled = False
        tmrPaperPunch.Enabled = False
        tmrPaperPunch2.Enabled = False
        tmrPaperPunch3.Enabled = False
        tmrPaperPunch4.Enabled = False
        BlnAtkPaperPunch = False
        BlnRockThrow = False
        BlnLokiHit = False
        blnRunMode = False
        blnItemMode = False




    End Sub


    Private Sub frmBattle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        If IntTurn = 1 And WinGame = False And BlnLose = False Then
            If IntHandSelection = 1 And e.KeyCode = Keys.Right Then
                IntHandSelection = 2
            End If

            If IntHandSelection = 1 And e.KeyCode = Keys.Down Then
                IntHandSelection = 4
            End If

            If IntHandSelection = 2 And e.KeyCode = Keys.Down Then
                IntHandSelection = 3
            End If

            If IntHandSelection = 2 And e.KeyCode = Keys.Left Then
                IntHandSelection = 1
            End If

            If IntHandSelection = 3 And e.KeyCode = Keys.Up Then
                IntHandSelection = 2
            End If

            If IntHandSelection = 3 And e.KeyCode = Keys.Left Then
                IntHandSelection = 4
            End If

            If IntHandSelection = 4 And e.KeyCode = Keys.Up Then
                IntHandSelection = 1
            End If
            If IntHandSelection = 4 And e.KeyCode = Keys.Right Then
                IntHandSelection = 3
            End If

            If IntHandSelection = 1 Then
                PicCursor.Left = 100
                PicCursor.Top = 340
            End If

            If IntHandSelection = 2 Then
                PicCursor.Left = 445
                PicCursor.Top = 340
            End If

            If IntHandSelection = 3 Then
                PicCursor.Left = 445
                PicCursor.Top = 395
            End If


            If IntHandSelection = 4 Then
                PicCursor.Left = 100
                PicCursor.Top = 395
            End If

            If IntHandSelection = 1 And e.KeyCode = Keys.Z And BlnBattleMode = False And blnItemMode = False And blnRunMode = False And IntDelay > 5 Then
                BlnBattleMode = True
                IntDelay = 0
                IntAttackAct = 0
            End If
            If IntHandSelection = 2 And e.KeyCode = Keys.Z And BlnBattleMode = False And blnItemMode = False And blnRunMode = False And IntDelay > 5 Then
                blnItemMode = True
                IntDelay = 0
            End If

            If IntHandSelection = 3 And BlnBattleMode = False And blnItemMode = False And blnRunMode = False Then
                lblPokemon.Show()
                lblPokemon.Text = "Loki: I'm the only Pokémon here!"
                IntDelay = 0
            Else
                lblPokemon.Hide()
            End If

            If IntHandSelection = 4 And e.KeyCode = Keys.Z And BlnBattleMode = False And blnItemMode = False And blnRunMode = False And IntDelay > 5 Then
                blnRunMode = True
                IntDelay = 0
            End If


            If BlnBattleMode = True Then
                lblButton1.Text = "Paper Cut!"
                lblButton2.Text = "Paper Punch!"
                lblButton4.Text = "Wiggle!"
                lblButton3.Text = "HYPER BEAM!!!"

                If IntHandSelection = 1 And e.KeyCode = Keys.Z And IntDelay > 5 Then
                    BlnAtkPaperCut = True
                    IntDelay = 0
                End If

                If IntHandSelection = 2 And e.KeyCode = Keys.Z And IntDelay > 5 Then
                    BlnAtkPaperPunch = True
                    IntDelay = 0
                End If

                If IntHandSelection = 3 And e.KeyCode = Keys.Z And IntDelay > 5 Then
                    BlnAtkHyperBeam = True
                    IntDelay = 0
                End If


                If IntHandSelection = 4 And e.KeyCode = Keys.Z And IntDelay > 5 Then

                    BlnAtkWiggle = True
                    IntDelay = 0
                End If

                'Deselection
                If e.KeyCode = Keys.X And IntDelay > 5 Then
                    BlnBattleMode = False
                    IntDelay = 0
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"


                End If

            End If


            'Paper Cut Attack!
            If BlnAtkPaperCut = True Then
                If IntAttackAct = 0 Then
                    tmrPaperCut.Enabled = True
                End If
                PicCursor.Hide()

                lblButton1.Text = Nothing
                lblButton2.Text = Nothing
                lblButton4.Text = Nothing
                lblButton3.Text = Nothing
                PicPaperCut.Show()

                lblBattleText.Show()

                If e.KeyCode = Keys.Z Then
                    IntBattleText += 1
                End If

                If IntBattleText = 1 Then
                    lblBattleText.Text = "Loki used Paper Cut!"
                    PicLokiBack.Hide()
                End If
                If IntBattleText = 2 And IntAttackAct = 1 Then
                    Randomize()


                    If BlnLokiHit = False Then
                        '  IntLDamage = 50
                        IntLDamage = (Int((100 - 2 + 1) * Rnd() + 2) + (IntLStrength) + 10) - IntOpponentDefence

                        If IntLDamage < 0 Then
                            IntLDamage = 0
                        End If

                        IntOpponentHP -= IntLDamage
                        BlnLokiHit = True
                    End If
                    lblBattleText.Text = "Loki dealt: " & IntLDamage & " damage!"
                    PicLokiBack.Show()

                End If

                If IntBattleText >= 2 And IntAttackAct = 0 Then
                    IntBattleText = 1
                End If
                If IntBattleText >= 3 Then
                    BlnLokiHit = False
                    IntTurn = 2
                    IntBattleText = 0
                    IntAttackAct = 0
                    BlnAtkPaperCut = False
                    PicPaperCut.Left = -70
                    tmrOppFlash.Enabled = False
                    If IntPokeNumber = 1 Then
                        PicZubat.Show()
                    End If
                    If IntPokeNumber = 2 Then
                        PicGeodude.Show()
                    End If
                    If IntPokeNumber = 3 Then
                        PicPidgey.Show()
                    End If
                    If IntPokeNumber = 4 Then
                        PicCaterpie.Show()
                    End If
                    If IntPokeNumber = 5 Then
                        PicBulb.Show()
                    End If

                    IntOpponentFlash = 0
                    IntOpponentHit = False
                    PicPaperCut.Hide()
                    PicLokiBack.Show()
                    BlnOppHit = False
                    BlnLokiHit = False
                End If
            End If


            'Paper Punch


            If BlnAtkPaperPunch = True Then


                If IntAttackAct = 0 And PicLokiBack.Left > 55 Then
                    tmrPaperPunch.Enabled = True
                Else
                    tmrPaperPunch.Enabled = False
                End If
                lblButton1.Text = Nothing
                lblButton2.Text = Nothing
                lblButton4.Text = Nothing
                lblButton3.Text = Nothing


                lblBattleText.Show()

                If e.KeyCode = Keys.Z And IntAttackAct = 4 Then
                    IntBattleText += 1
                    IntDelay = 0
                End If


                If IntBattleText = 0 Then
                    lblBattleText.Text = "Loki used Paper Punch!"

                End If

                If IntBattleText = 1 Then
                    Randomize()


                    If BlnLokiHit = False Then
                        'IntLDamage = 20

                        IntLDamage = (Int((10 - 1 + 1) * Rnd() + 1) + (IntLStrength) + 55) - IntOpponentDefence
                        If IntLDamage < 0 Then
                            IntLDamage = 0
                        End If

                        IntOpponentHP -= IntLDamage
                        BlnLokiHit = True
                    End If
                    lblBattleText.Text = "Loki dealt: " & IntLDamage & " damage!"
                End If

                If IntBattleText >= 2 And BlnAtkPaperPunch = True Then

                    IntTurn = 2
                    IntBattleText = 0
                    IntAttackAct = 0
                    BlnAtkPaperPunch = False
                    PicLokiBack.Left = 139
                    PicLokiBack.Show()
                    tmrOppFlash.Enabled = False
                    If IntPokeNumber = 1 Then
                        PicZubat.Show()
                    End If
                    If IntPokeNumber = 2 Then
                        PicGeodude.Show()
                    End If
                    If IntPokeNumber = 3 Then
                        PicPidgey.Show()
                    End If
                    If IntPokeNumber = 4 Then
                        PicCaterpie.Show()
                    End If

                    If IntPokeNumber = 5 Then
                        PicBulb.Show()
                    End If
                    IntOpponentFlash = 0
                    IntOpponentHit = False

                    PicPaperPunch.Hide()
                    BlnOppHit = False
                    BlnLokiHit = False
                End If


            End If
            'Wiggle Attack!
            If BlnAtkWiggle = True Then
                lblButton1.Text = Nothing
                lblButton2.Text = Nothing
                lblButton4.Text = Nothing
                lblButton3.Text = Nothing


                lblBattleText.Show()

                If e.KeyCode = Keys.Z Then
                    IntBattleText += 1
                    IntDelay = 0
                End If

                If IntBattleText = 1 Then
                    lblBattleText.Text = "Loki used Wiggle!"
                    PicLokiBack.Hide()
                    PicLokiWiggle.Show()

                End If

                If IntBattleText = 2 Then
                    IntOpponentAttack -= 10
                    IntOpponentDefence -= 10
                    lblBattleText.Text = "The opponent's attack and defence decreased by 10!"

                End If


                If IntBattleText >= 3 Then
                    IntTurn = 2
                    PicLokiBack.Show()
                    PicLokiWiggle.Hide()
                    BlnAtkWiggle = False
                    IntBattleText = 0
                    IntAttackAct = 0
                    If IntPokeNumber = 1 Then
                        PicZubat.Show()
                    End If
                    If IntPokeNumber = 2 Then
                        PicGeodude.Show()
                    End If
                    If IntPokeNumber = 3 Then
                        PicPidgey.Show()
                    End If
                    If IntPokeNumber = 4 Then
                        PicCaterpie.Show()
                    End If
                    If IntPokeNumber = 5 Then
                        PicBulb.Show()
                    End If


                End If


            End If

            'HYPER BEAM!!!
            If BlnAtkHyperBeam = True Then
                lblButton1.Text = Nothing
                lblButton2.Text = Nothing
                lblButton4.Text = Nothing
                lblButton3.Text = Nothing


                lblBattleText.Show()

                If e.KeyCode = Keys.Z Then
                    IntBattleText += 1
                    IntDelay = 0
                End If

                If IntBattleText = 1 Then
                    lblBattleText.Text = "LOKI USED HYPER BEAM!!!!!!!!!"
                End If

                If IntBattleText = 2 Then
                    lblBattleText.Text = "The enemy prepares to be obliterated..."

                End If
                If IntBattleText = 3 Then
                    lblBattleText.Text = "..."
                End If


                If IntBattleText = 4 Then
                    lblBattleText.Text = "...But Loki doesn't know how to use Hyper Beam!"
                End If

                If IntBattleText = 5 Then
                    lblBattleText.Text = "Too Bad!"
                End If

                If IntBattleText >= 6 Then
                    IntTurn = 2
                    BlnAtkHyperBeam = False
                    IntBattleText = 0
                    IntAttackAct = 0
                    If IntPokeNumber = 1 Then
                        PicZubat.Show()
                    End If
                    If IntPokeNumber = 2 Then
                        PicGeodude.Show()
                    End If
                    If IntPokeNumber = 3 Then
                        PicPidgey.Show()
                    End If
                    If IntPokeNumber = 4 Then
                        PicCaterpie.Show()
                    End If

                    If IntPokeNumber = 5 Then
                        PicBulb.Show()
                    End If

                    PicLokiBack.Show()
                End If


            End If

            'Items
            If blnItemMode = True Then


                lblButton1.Text = "Potion: " & IntPotions
                lblButton2.Text = Nothing
                lblButton4.Text = Nothing
                lblButton3.Text = Nothing

                IntHandSelection = 1
                PicCursor.Left = 100
                PicCursor.Top = 340

                If e.KeyCode = Keys.Z And IntDelay > 5 And IntPotions > 0 Then
                    IntBattleText += 1
                    IntDelay = 0
                    lblPokemon.Hide()
                ElseIf IntPotions <= 0 Then
                    lblPokemon.Show()
                    lblPokemon.Text = "You have no more Potions!"

                End If

                If IntBattleText = 1 Then
                    lblButton1.Text = Nothing
                    lblButton2.Text = Nothing
                    lblButton4.Text = Nothing
                    lblButton3.Text = Nothing
                    lblBattleText.Show()

                    lblBattleText.Text = "Loki healed 100 HP!"
                    If BlnPotionUse = False Then
                        IntLokiHP += 1000
                        IntPotions -= 1
                        BlnPotionUse = True
                        If IntPotions <= 0 Then
                            IntBattleText = 2
                        End If

                    End If
                End If
                If IntBattleText = 2 Then
                    BlnPotionUse = False
                    IntTurn = 2
                    IntBattleText = 0
                    IntAttackAct = 0
                    blnItemMode = False

                End If
                If e.KeyCode = Keys.X And IntDelay > 5 Then
                    blnItemMode = False
                    IntDelay = 0
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"


                End If

            End If

            'Run!!
            If blnRunMode = True Then
                If e.KeyCode = Keys.Z And IntDelay > 5 Then
                    IntBattleText += 1
                    IntDelay = 0
                End If

                lblButton1.Text = Nothing
                lblButton2.Text = Nothing
                lblButton4.Text = Nothing
                lblButton3.Text = Nothing
                lblBattleText.Show()
                If IntBattleText = 0 Then
                    lblBattleText.Text = "Attempting to run away..."
                End If

                If IntBattleText = 1 Then
                    Randomize()
                    IntRunNumber = Int(2 - 1 + 1) * Rnd() + 1
                    blnRunMode = False
                    blnItemMode = False
                    If IntRunNumber = 2 And IntPokeNumber <> 5 Then
                        lblBattleText.Text = "You have successfully ran away!"
                        BlnTransferWin = True
                        WinGame = False
                        BlnActivate = False

                        If frmOutside.BlnOutside = False Then
                            frmCave.IntTimeUntilBattle = 0
                            frmCave.IntStepsTillBattle = 0
                            frmCave.EnableBattle = False
                            frmCave.PicPokeBall.Hide()
                            frmCave.BlnHitwall = False
                            frmCave.lblLokiName.Show()
                            frmCave.lblNameBack.Show()
                            frmCave.PrgLokiHP.Show()
                            frmCave.lblInfo.Text = "Level: " & IntLevel & " EXP:" & IntEXP & "/" & IntMaxEXP
                            frmCave.lblInfo.Show()
                            frmCave.blnPlay = False

                            My.Computer.Audio.Play(My.Resources.PokeCave, AudioPlayMode.BackgroundLoop)
                        Else
                            frmOutside.BlnOutside = True
                            frmOutside.IntTimeUntilBattle = 0
                            frmOutside.IntStepsTillBattle = 0
                            frmOutside.EnableBattle = False
                            frmOutside.PicPokeBall.Hide()
                            frmOutside.BlnHitwall = False
                            frmOutside.lblLokiName.Show()
                            frmOutside.lblNameBack.Show()
                            frmOutside.PrgLokiHP.Show()
                            frmOutside.lblInfo.Text = "Level: " & IntLevel & " EXP:" & IntEXP & "/" & IntMaxEXP
                            frmOutside.lblInfo.Show()
                            frmOutside.blnPlay = False

                            My.Computer.Audio.Play(My.Resources.Outside, AudioPlayMode.BackgroundLoop)
                        End If

                        Call Restart()
                        Me.Hide()
                        If frmOutside.BlnOutside = False Then
                            frmCave.Show()
                            frmCave.WindowState = FormWindowState.Normal
                        End If
                        If frmOutside.BlnOutside = True Then
                            frmOutside.Show()
                            frmOutside.WindowState = FormWindowState.Normal
                        End If

                    Else
                        IntBattleText = 2

                    End If
                End If

                If IntBattleText = 2 Then
                    lblBattleText.Text = "You have failed!"


                End If
                If IntBattleText = 3 Then
                    IntTurn = 2
                    IntBattleText = 0
                    IntAttackAct = 0
                    IntDelay = 0
                    blnRunMode = False
                End If

            End If

        End If


        'Opponent's turn

        If IntTurn = 2 And WinGame = False And BlnLose = False Then
            If e.KeyCode = Keys.Z And IntDelay > 3 Then
                IntBattleText += 1
                IntDelay = 0
            End If
            If IntBattleText = 1 Then
                lblBattleText.Text = "It is the opponent's turn!"
            End If

            'Zubat
            If IntPokeNumber = 1 Then
                If IntBattleText = 2 Then
                    Randomize()
                    IntOpponentChooseAttack = Int(4 - 1 + 1) * Rnd() + 1
                    If IntOpponentChooseAttack = 1 Or IntOpponentChooseAttack = 2 Or IntOpponentChooseAttack = 3 Or IntOpponentChooseAttack = 4 Then
                        BlnZubatScreech = True
                    End If
                    If BlnZubatScreech = True Then
                        PicScreech.Show()
                        lblBattleText.Text = "Zubat used Screech!"
                    End If

                End If


                If IntBattleText = 3 Then
                    BlnZubatScreech = False
                    PicScreech.Hide()

                    lblBattleText.Text = "..."
                End If

                If IntBattleText = 4 Then
                    lblBattleText.Text = "...But Loki doesn't have ears!"
                End If

                If IntBattleText = 5 Then
                    lblBattleText.Text = "It is now Loki's turn!"

                End If

                If IntBattleText = 6 Then
                    IntTurn = 1
                    IntAttackAct = 0
                    IntHandSelection = 1
                    PicCursor.Left = 100
                    PicCursor.Top = 340
                    IntBattleText = 0
                    BlnBattleMode = False
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"
                    PicCursor.Show()
                    BlnOppHit = False
                    BlnLokiHit = False
                End If
            End If

            'Geodude
            If IntPokeNumber = 2 Then
                If PicRock.Top < 170 Then
                    IntBattleText = 2
                End If



                If IntBattleText = 2 Then
                    Randomize()
                    IntOpponentChooseAttack = Int(4 - 1 + 1) * Rnd() + 1
                    If IntOpponentChooseAttack = 1 Or IntOpponentChooseAttack = 2 Or IntOpponentChooseAttack = 3 Or IntOpponentChooseAttack = 4 Then
                        BlnRockThrow = True

                    End If
                    If BlnRockThrow = True Then
                        PicRock.Show()
                        IntAttackAct = 1
                        lblBattleText.Text = "Geodude used Rock throw!"
                        tmrThrow.Enabled = True
                    End If

                End If

                If IntBattleText = 3 Then
                    Randomize()

                    If BlnOppHit = False Then
                        '  IntLDamage = 50
                        IntODamage = (Int((10 - 1 + 1) * Rnd() + 1) + (IntOpponentAttack + 15) - IntLDefence)
                        If IntODamage < 0 Then
                            IntODamage = 0
                        End If
                        IntLokiHP -= IntODamage

                        BlnOppHit = True
                    End If

                    lblBattleText.Text = "Geodude dealt: " & IntODamage & " damage!"
                    PicLokiBack.Show()

                End If
                If IntBattleText = 4 Then
                    lblBattleText.Text = "It is now Loki's turn!"
                End If

                If IntBattleText = 5 Then
                    IntTurn = 1
                    IntAttackAct = 0
                    IntHandSelection = 1
                    PicCursor.Left = 100
                    PicCursor.Top = 340
                    IntBattleText = 0
                    PicRock.Hide()
                    PicRock.Left = 347
                    PicRock.Top = 107
                    PicGust.Left = 347
                    PicGust.Top = 107
                    PicGust.Hide()
                    tmrThrow.Enabled = False
                    BlnRockThrow = False
                    BlnBattleMode = False
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"
                    PicCursor.Show()
                    BlnOppHit = False
                    BlnLokiHit = False

                End If
            End If

            'Pidgey

            If IntPokeNumber = 3 Then
                If PicGust.Top < 170 Then
                    IntBattleText = 2
                End If

                If IntBattleText = 2 Then
                    Randomize()
                    IntOpponentChooseAttack = Int(4 - 1 + 1) * Rnd() + 1
                    If IntOpponentChooseAttack = 1 Or IntOpponentChooseAttack = 2 Or IntOpponentChooseAttack = 3 Or IntOpponentChooseAttack = 4 Then
                        blnGust = True

                    End If
                    If blnGust = True Then
                        PicGust.Show()
                        IntAttackAct = 1
                        lblBattleText.Text = "Pidgey used Gust!"
                        tmrThrow.Enabled = True
                    End If

                End If

                If IntBattleText = 3 Then
                    Randomize()

                    If BlnOppHit = False Then
                        '  IntLDamage = 50
                        IntODamage = (Int((10 - 1 + 1) * Rnd() + 1) + (IntOpponentAttack + 20) - IntLDefence)
                        If IntODamage < 0 Then
                            IntODamage = 0
                        End If
                        IntLokiHP -= IntODamage

                        BlnOppHit = True
                    End If

                    lblBattleText.Text = "Pidgey dealt: " & IntODamage & " damage!"
                    PicLokiBack.Show()

                End If
                If IntBattleText = 4 Then
                    lblBattleText.Text = "It is now Loki's turn!"
                End If

                If IntBattleText = 5 Then
                    IntTurn = 1
                    IntAttackAct = 0
                    IntHandSelection = 1
                    PicCursor.Left = 100
                    PicCursor.Top = 340
                    IntBattleText = 0
                    PicRock.Hide()

                    PicGust.Left = 347
                    PicGust.Top = 107
                    PicGust.Hide()
                    tmrThrow.Enabled = False
                    BlnRockThrow = False
                    BlnBattleMode = False
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"
                    PicCursor.Show()
                    BlnOppHit = False
                    BlnLokiHit = False

                End If

            End If

            'Caterpie

            If IntPokeNumber = 4 Then
                If PicString.Top < 170 Then
                    IntBattleText = 2
                End If

                If IntBattleText = 2 Then
                    Randomize()
                    IntOpponentChooseAttack = Int(4 - 1 + 1) * Rnd() + 1
                    If IntOpponentChooseAttack = 1 Or IntOpponentChooseAttack = 2 Or IntOpponentChooseAttack = 3 Or IntOpponentChooseAttack = 4 Then
                        blnString = True

                    End If
                    If blnString = True Then
                        PicString.Show()
                        IntAttackAct = 1
                        lblBattleText.Text = "Caterpie used String Shot!"
                        tmrThrow.Enabled = True
                    End If

                End If

                If IntBattleText = 3 Then
                    Randomize()

                    If BlnOppHit = False Then
                        '  IntLDamage = 50

                        IntODamage = (Int((10 - 1 + 1) * Rnd() + 1) + (IntOpponentAttack + 10) - IntLDefence)
                        If IntODamage < 0 Then
                            IntODamage = 0
                        End If
                        IntLokiHP -= IntODamage
                        BlnOppHit = True

                    End If

                    lblBattleText.Text = "Caterpie dealt: " & IntODamage & " damage!"
                    PicLokiBack.Show()

                End If
                If IntBattleText = 4 Then
                    lblBattleText.Text = "It is now Loki's turn!"
                End If

                If IntBattleText = 5 Then
                    IntTurn = 1
                    IntAttackAct = 0
                    IntHandSelection = 1
                    PicCursor.Left = 100
                    PicCursor.Top = 340
                    IntBattleText = 0
                    PicString.Left = 347
                    PicString.Top = 107
                    PicString.Hide()
                    tmrThrow.Enabled = False
                    blnString = False

                    BlnBattleMode = False
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"
                    PicCursor.Show()
                    BlnOppHit = False
                    BlnLokiHit = False

                End If

            End If

            'Bulbasaur
            If IntPokeNumber = 5 Then
                If PicLeaf.Top < 170 Then
                    IntBattleText = 2
                End If

                If IntBattleText = 2 Then
                    Randomize()
                    IntOpponentChooseAttack = Int(4 - 1 + 1) * Rnd() + 1
                    If IntOpponentChooseAttack = 1 Or IntOpponentChooseAttack = 2 Or IntOpponentChooseAttack = 3 Or IntOpponentChooseAttack = 4 Then
                        blnLeaf = True

                    End If
                    If blnLeaf = True Then
                        PicLeaf.Show()
                        IntAttackAct = 1
                        lblBattleText.Text = "Bulbasaur used Razor Leaf!"
                        tmrThrow.Enabled = True
                    End If

                End If

                If IntBattleText = 3 Then
                    Randomize()

                    If BlnOppHit = False Then
                        '  IntLDamage = 50
                        IntODamage = (Int((10 - 1 + 1) * Rnd() + 1) + (IntOpponentAttack + 20) - IntLDefence)
                        If IntODamage < 0 Then
                            IntODamage = 0
                        End If
                        IntLokiHP -= IntODamage
                        BlnOppHit = True

                    End If

                    lblBattleText.Text = "Bulbasaur dealt: " & IntODamage & " damage!"
                    PicLokiBack.Show()

                End If
                If IntBattleText = 4 Then
                    lblBattleText.Text = "It is now Loki's turn!"
                End If

                If IntBattleText = 5 Then
                    IntTurn = 1
                    IntAttackAct = 0
                    IntHandSelection = 1
                    PicCursor.Left = 100
                    PicCursor.Top = 340
                    IntBattleText = 0
                    PicLeaf.Left = 347
                    PicLeaf.Top = 107
                    PicLeaf.Hide()
                    blnLeaf = False
                    tmrThrow.Enabled = False
                    blnString = False

                    BlnBattleMode = False
                    lblBattleText.Hide()
                    lblButton1.Show()
                    lblButton2.Show()
                    lblButton3.Show()
                    lblButton4.Show()
                    lblButton1.Text = "Fight!"
                    lblButton2.Text = "Bag"
                    lblButton4.Text = "Run!"
                    lblButton3.Text = "Pokémon"
                    PicCursor.Show()
                    BlnOppHit = False
                    BlnLokiHit = False

                End If

            End If



        End If

        If WinGame = True Then

            lblButton1.Text = Nothing
            lblButton2.Text = Nothing
            lblButton4.Text = Nothing
            lblButton3.Text = Nothing
            If IntPokeNumber = 1 Then
                PicZubat.Hide()

            End If
            If IntPokeNumber = 2 Then
                PicGeodude.Hide()
            End If
            If IntPokeNumber = 3 Then
                PicPidgey.Hide()
            End If
            If IntPokeNumber = 4 Then
                PicCaterpie.Hide()

            End If
            If IntPokeNumber = 5 Then
                PicBulb.Hide()

            End If
            lblBattleText.Show()
            If e.KeyCode = Keys.Z Then
                IntWinningText += 1
                IntDelay = 0
            End If
            If IntWinningText = 1 Then

                My.Computer.Audio.Play(My.Resources.Victory, AudioPlayMode.BackgroundLoop)
                lblBattleText.Text = "You have won!"
            End If
            If IntWinningText = 2 Then
                Randomize()
                If IntPokeNumber = 1 Then
                    IntGainedEXP = Int((50 - 30 + 1) * Rnd() + 30)
                End If
                If IntPokeNumber = 2 Then
                    IntGainedEXP = Int((100 - 50 + 1) * Rnd() + 50)
                End If
                If IntPokeNumber = 3 Then
                    IntGainedEXP = Int((100 - 50 + 1) * Rnd() + 50)
                End If
                If IntPokeNumber = 4 Then
                    IntGainedEXP = Int((100 - 50 + 1) * Rnd() + 50)

                End If
                If IntPokeNumber = 5 Then
                    IntGainedEXP = Int((1000 - 50 + 1) * Rnd() + 50)

                End If


                IntWinningText = 3

                IntEXP += IntGainedEXP

            End If
            If IntWinningText = 3 Then

                lblBattleText.Text = "You have gained: " & IntGainedEXP & " EXP points"
            End If


            If IntWinningText = 4 And IntEXP < IntMaxEXP Then

                BlnTransferWin = True
                WinGame = False
                BlnActivate = False
                If frmOutside.BlnOutside = False Then
                    frmCave.IntTimeUntilBattle = 0
                    frmCave.IntStepsTillBattle = 0
                    frmCave.EnableBattle = False
                    frmCave.PicPokeBall.Hide()
                    frmCave.BlnHitwall = False
                    frmCave.lblLokiName.Show()
                    frmCave.lblNameBack.Show()
                    frmCave.PrgLokiHP.Show()
                    frmCave.lblInfo.Text = "Level: " & IntLevel & " EXP:" & IntEXP & "/" & IntMaxEXP
                    frmCave.lblInfo.Show()
                    frmCave.blnPlay = False

                    My.Computer.Audio.Play(My.Resources.PokeCave, AudioPlayMode.BackgroundLoop)
                Else
                    frmOutside.BlnOutside = True
                    frmOutside.IntTimeUntilBattle = 0
                    frmOutside.IntStepsTillBattle = 0
                    frmOutside.EnableBattle = False
                    frmOutside.PicPokeBall.Hide()
                    frmOutside.BlnHitwall = False
                    frmOutside.lblLokiName.Show()
                    frmOutside.lblNameBack.Show()
                    frmOutside.PrgLokiHP.Show()
                    frmOutside.lblInfo.Text = "Level: " & IntLevel & " EXP:" & IntEXP & "/" & IntMaxEXP
                    frmOutside.lblInfo.Show()
                    frmOutside.blnPlay = False

                    My.Computer.Audio.Play(My.Resources.Outside, AudioPlayMode.BackgroundLoop)
                End If
                If IntPokeNumber <> 5 Then
                    Call Restart()
                    Me.Hide()
                    If frmOutside.BlnOutside = False Then
                        frmCave.Show()
                        frmCave.WindowState = FormWindowState.Normal
                    End If
                    If frmOutside.BlnOutside = True Then
                        frmOutside.Show()
                        frmOutside.WindowState = FormWindowState.Normal
                    End If

                    Call Restart()
                End If

                If IntPokeNumber = 5 Then

                    My.Computer.Audio.Play(My.Resources.Fame, AudioPlayMode.BackgroundLoop)
                    Me.Hide()
                    frmTheEndStory.Show()
                End If

            End If

            If IntWinningText = 4 And IntEXP > IntMaxEXP Then
                IntLevel += 1
                IntLStrength += 10
                IntLDefence += 10
                IntLokiHP += 100
                IntEXP = 0
                IntMaxEXP *= 2
                lblBattleText.Text = "You are now level: " & IntLevel & "!!!" & vbCrLf & " Strength: " & IntLStrength & " Defence: " & IntLDefence


            End If



            If IntWinningText = 5 Then
                BlnTransferWin = True
                BlnActivate = False
                WinGame = False
                If frmOutside.BlnOutside = False Then
                    frmCave.IntTimeUntilBattle = 0
                    frmCave.IntStepsTillBattle = 0
                    frmCave.EnableBattle = False
                    frmCave.PicPokeBall.Hide()
                    frmCave.BlnHitwall = False
                    frmCave.lblLokiName.Show()
                    frmCave.lblNameBack.Show()
                    frmCave.PrgLokiHP.Show()
                    frmCave.lblInfo.Text = "Level: " & IntLevel & " EXP:" & IntEXP & "/" & IntMaxEXP
                    frmCave.lblInfo.Show()
                    frmCave.blnPlay = False

                    My.Computer.Audio.Play(My.Resources.PokeCave, AudioPlayMode.BackgroundLoop)
                Else
                    frmOutside.BlnOutside = True
                    frmOutside.IntTimeUntilBattle = 0
                    frmOutside.IntStepsTillBattle = 0
                    frmOutside.EnableBattle = False
                    frmOutside.PicPokeBall.Hide()
                    frmOutside.BlnHitwall = False
                    frmOutside.lblLokiName.Show()
                    frmOutside.lblNameBack.Show()
                    frmOutside.PrgLokiHP.Show()
                    frmOutside.lblInfo.Text = "Level: " & IntLevel & " EXP:" & IntEXP & "/" & IntMaxEXP
                    frmOutside.lblInfo.Show()
                    frmOutside.blnPlay = False

                    My.Computer.Audio.Play(My.Resources.Outside, AudioPlayMode.BackgroundLoop)
                End If
                If IntPokeNumber <> 5 Then

                    Call Restart()
                    Me.Hide()
                    If frmOutside.BlnOutside = False Then
                        frmCave.Show()
                        frmCave.WindowState = FormWindowState.Normal
                    End If
                    If frmOutside.BlnOutside = True Then
                        frmOutside.Show()
                        frmOutside.WindowState = FormWindowState.Normal
                    End If
                    Call Restart()
                End If

                If IntPokeNumber = 5 Then

                    My.Computer.Audio.Play(My.Resources.Fame, AudioPlayMode.BackgroundLoop)
                    Me.Hide()
                    frmTheEndStory.Show()
                End If



            End If

        End If
        'Lose
        If BlnLose = True Then
            lblButton1.Text = Nothing
            lblButton2.Text = Nothing
            lblButton4.Text = Nothing
            lblButton3.Text = Nothing
            PicLokiBack.Hide()
            lblBattleText.Show()


            If e.KeyCode = Keys.Z Then
                IntLosingText += 1
                IntDelay = 0
            End If

            If IntLosingText = 1 Then
                lblBattleText.Text = "Loki has fainted!"
            End If
            If IntLosingText = 2 Then
                Me.Hide()
                frmGameOver.Show()
            End If

        End If


    End Sub

    Private Sub frmBattle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Restart()
        If frmOutside.IntPokeNumber = 5 Then
            IntPokeNumber = 5
        End If
        If IntPokeNumber = 5 Then
            lblOpponentName.Text = "Bob's Bulbasaur"
            IntOpponentHP = 100
            prgOHealth.Maximum = IntOpponentHP
            IntOpponentAttack = 25
            IntOpponentDefence = 25
            PicBulb.Show()
            PicCaterpie.Hide()
            PicPidgey.Hide()
            PicGeodude.Hide()
            PicZubat.Hide()

        End If


    End Sub

    Private Sub tmrRefreshTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefreshTimer.Tick
        If BlnActivate = False And frmOutside.BlnPlayBattle Then
            Call Restart()
            BlnActivate = True
        End If

        If IntOpponentHP < 0 Then
            IntOpponentHP = 0
        End If
        If IntLokiHP < 0 Then
            IntLokiHP = 0
        End If
        If IntLokiHP > 100 Then
            IntLokiHP = 100
        End If

        prgOHealth.Value = IntOpponentHP
        PrgLokiHP.Value = IntLokiHP
        PrgLokiHP.Maximum = IntLokiMaxHP



        If PicPaperCut.Left > PicZubat.Left Then
            IntOpponentHit = True

        End If
        If IntOpponentHit = True Then
            tmrOppFlash.Enabled = True
        End If
        If PicPaperCut.Left > 820 Then
            PicPaperCut.Left = -70
        End If

        If IntOpponentHP = 0 Then
            WinGame = True
        End If
        If IntLokiHP = 0 Then
            BlnLose = True
        End If

        DoubleBuffered = True

    End Sub

    Private Sub tmrPaperCut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaperCut.Tick
        If BlnAtkPaperCut = True And IntAttackAct = 0 Then
            PicPaperCut.Left += 30
        End If
    End Sub

    Private Sub tmrDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        IntDelay += 1
    End Sub



    Private Sub tmrPaperPunch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaperPunch.Tick
        PicLokiBack.Left -= 2
        If IntAttackAct = 0 And PicLokiBack.Left > 125 Then
            tmrPaperPunch.Enabled = True
        Else
            IntAttackAct = 1
            tmrPaperPunch.Enabled = False
            tmrPaperPunch2.Enabled = True

        End If
    End Sub

    Private Sub tmrPaperPunch2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaperPunch2.Tick
        If IntAttackAct = 1 And PicLokiBack.Left < 275 Then
            PicLokiBack.Left += 20
        Else
            IntAttackAct = 2
            tmrPaperPunch2.Enabled = False
            tmrPaperPunch3.Enabled = True
            PicPaperPunch.Show()

        End If
    End Sub

    Private Sub tmrPaperPunch3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaperPunch3.Tick
        IntPaperPunchStop += 1
        If IntPaperPunchStop >= 1 Then
            PicPaperPunch.Hide()
            tmrOppFlash.Enabled = True
            IntAttackAct = 3
            tmrPaperPunch3.Enabled = False
            tmrPaperPunch4.Enabled = True
        End If
    End Sub

    Private Sub tmrPaperPunch4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPaperPunch4.Tick
        If PicLokiBack.Left > 140 And IntAttackAct = 3 Then
            PicLokiBack.Left -= 10

        Else
            IntAttackAct = 4
            tmrPaperPunch.Enabled = False
            tmrPaperPunch2.Enabled = False
            tmrPaperPunch3.Enabled = False
            tmrPaperPunch4.Enabled = False
            PicLokiBack.Left = 139

        End If
    End Sub

    Private Sub PicRock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicRock.Click

    End Sub

    Private Sub tmrThrow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrThrow.Tick
        If IntPokeNumber = 2 Then
            PicRock.Left -= 20
            PicRock.Top += 10
            PicGeodude.Show()


            If PicRock.Top > 170 Then
                IntAttackAct = 2
                PicRock.Hide()
                tmrLFlash.Enabled = True
            End If
        End If

        If IntPokeNumber = 3 Then
            PicGust.Left -= 20
            PicGust.Top += 10
            PicPidgey.Show()


            If PicGust.Top > 170 Then
                IntAttackAct = 2
                PicGust.Hide()
                tmrLFlash.Enabled = True
            End If
        End If

        If IntPokeNumber = 4 Then
            PicString.Left -= 20
            PicString.Top += 10
            PicCaterpie.Show()
            If PicString.Top > 170 Then
                IntAttackAct = 2
                PicString.Hide()
                tmrLFlash.Enabled = True
            End If

        End If

        If IntPokeNumber = 5 Then
            PicLeaf.Left -= 20
            PicLeaf.Top += 10
            PicBulb.Show()
            If PicLeaf.Top > 170 Then
                IntAttackAct = 2
                PicLeaf.Hide()
                tmrLFlash.Enabled = True
            End If
        End If

    End Sub

    Private Sub tmrLFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLFlash.Tick
        IntLokiFlash += 1
        If IntLokiFlash < 5 Then
            PicLokiBack.Hide()

        End If


        If IntLokiFlash > 5 Or PicRock.Top > 280 Or IntTurn = 1 Or PicGust.Top > 280 Or PicString.Top > 280 Or PicLeaf.Top > 280 Then

            tmrLFlash.Enabled = False
            PicLokiBack.Show()
            IntLokiFlash = 0

        End If
    End Sub
    Private Sub tmrOppFlash_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrOppFlash.Tick
        IntOpponentFlash += 1
        If IntOpponentFlash < 5 Then
            If IntPokeNumber = 1 Then
                PicZubat.Hide()
            End If
            If IntPokeNumber = 2 Then
                PicGeodude.Hide()

            End If
            If IntPokeNumber = 3 Then
                PicPidgey.Hide()

            End If
            If IntPokeNumber = 4 Then
                PicCaterpie.Hide()

            End If
            If IntPokeNumber = 5 Then
                PicBulb.Hide()

            End If

        End If


        If IntOpponentFlash > 5 Or PicPaperCut.Left > 810 Or (BlnAtkPaperPunch = True And PicLokiBack.Left <= 140) Then

            tmrOppFlash.Enabled = False
            If IntPokeNumber = 1 Then
                PicZubat.Show()
            End If
            If IntPokeNumber = 2 Then
                PicGeodude.Show()
            End If
            If IntPokeNumber = 3 Then
                PicPidgey.Show()

            End If
            If IntPokeNumber = 4 Then
                PicCaterpie.Show()

            End If
            If IntPokeNumber = 5 Then
                PicBulb.Show()

            End If
            IntOpponentFlash = 0
            IntOpponentHit = False
            If BlnAtkPaperCut = True Then
                PicPaperCut.Hide()
                IntAttackAct = 1
            End If

        End If

    End Sub
End Class
