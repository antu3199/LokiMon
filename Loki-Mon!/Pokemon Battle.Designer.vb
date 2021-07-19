<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBattle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBattle))
        Me.PicLokiBack = New System.Windows.Forms.PictureBox()
        Me.PicCursor = New System.Windows.Forms.PictureBox()
        Me.lblButton1 = New System.Windows.Forms.Label()
        Me.lblButton4 = New System.Windows.Forms.Label()
        Me.lblButton2 = New System.Windows.Forms.Label()
        Me.lblButton3 = New System.Windows.Forms.Label()
        Me.prgOHealth = New System.Windows.Forms.ProgressBar()
        Me.tmrRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblOpponentName = New System.Windows.Forms.Label()
        Me.PicZubat = New System.Windows.Forms.PictureBox()
        Me.PicPaperCut = New System.Windows.Forms.PictureBox()
        Me.tmrPaperCut = New System.Windows.Forms.Timer(Me.components)
        Me.lblBattleText = New System.Windows.Forms.Label()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOppFlash = New System.Windows.Forms.Timer(Me.components)
        Me.PicScreech = New System.Windows.Forms.PictureBox()
        Me.lblLokiName = New System.Windows.Forms.Label()
        Me.lblNameBack = New System.Windows.Forms.Label()
        Me.PrgLokiHP = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrPaperPunch = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPaperPunch2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPaperPunch3 = New System.Windows.Forms.Timer(Me.components)
        Me.PicPaperPunch = New System.Windows.Forms.PictureBox()
        Me.tmrPaperPunch4 = New System.Windows.Forms.Timer(Me.components)
        Me.PicLokiWiggle = New System.Windows.Forms.PictureBox()
        Me.PicGeodude = New System.Windows.Forms.PictureBox()
        Me.PicRock = New System.Windows.Forms.PictureBox()
        Me.tmrThrow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLFlash = New System.Windows.Forms.Timer(Me.components)
        Me.PicPidgey = New System.Windows.Forms.PictureBox()
        Me.PicGust = New System.Windows.Forms.PictureBox()
        Me.PicCaterpie = New System.Windows.Forms.PictureBox()
        Me.PicString = New System.Windows.Forms.PictureBox()
        Me.lblPokemon = New System.Windows.Forms.Label()
        Me.PicBulb = New System.Windows.Forms.PictureBox()
        Me.PicLeaf = New System.Windows.Forms.PictureBox()
        CType(Me.PicLokiBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicZubat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPaperCut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicScreech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPaperPunch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLokiWiggle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGeodude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPidgey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCaterpie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBulb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLeaf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLokiBack
        '
        Me.PicLokiBack.BackColor = System.Drawing.Color.Transparent
        Me.PicLokiBack.Image = CType(resources.GetObject("PicLokiBack.Image"), System.Drawing.Image)
        Me.PicLokiBack.Location = New System.Drawing.Point(139, 206)
        Me.PicLokiBack.Name = "PicLokiBack"
        Me.PicLokiBack.Size = New System.Drawing.Size(95, 101)
        Me.PicLokiBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLokiBack.TabIndex = 0
        Me.PicLokiBack.TabStop = False
        '
        'PicCursor
        '
        Me.PicCursor.BackColor = System.Drawing.Color.Transparent
        Me.PicCursor.Image = CType(resources.GetObject("PicCursor.Image"), System.Drawing.Image)
        Me.PicCursor.Location = New System.Drawing.Point(99, 339)
        Me.PicCursor.Name = "PicCursor"
        Me.PicCursor.Size = New System.Drawing.Size(35, 28)
        Me.PicCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCursor.TabIndex = 4
        Me.PicCursor.TabStop = False
        '
        'lblButton1
        '
        Me.lblButton1.BackColor = System.Drawing.Color.Transparent
        Me.lblButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton1.Location = New System.Drawing.Point(153, 339)
        Me.lblButton1.Name = "lblButton1"
        Me.lblButton1.Size = New System.Drawing.Size(219, 33)
        Me.lblButton1.TabIndex = 5
        Me.lblButton1.Text = "Fight!"
        Me.lblButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblButton4
        '
        Me.lblButton4.BackColor = System.Drawing.Color.Transparent
        Me.lblButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton4.Location = New System.Drawing.Point(153, 392)
        Me.lblButton4.Name = "lblButton4"
        Me.lblButton4.Size = New System.Drawing.Size(141, 33)
        Me.lblButton4.TabIndex = 6
        Me.lblButton4.Text = "Pokémon"
        Me.lblButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblButton2
        '
        Me.lblButton2.BackColor = System.Drawing.Color.Transparent
        Me.lblButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton2.Location = New System.Drawing.Point(495, 339)
        Me.lblButton2.Name = "lblButton2"
        Me.lblButton2.Size = New System.Drawing.Size(234, 33)
        Me.lblButton2.TabIndex = 7
        Me.lblButton2.Text = "Bag"
        Me.lblButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblButton3
        '
        Me.lblButton3.BackColor = System.Drawing.Color.Transparent
        Me.lblButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton3.Location = New System.Drawing.Point(495, 392)
        Me.lblButton3.Name = "lblButton3"
        Me.lblButton3.Size = New System.Drawing.Size(258, 33)
        Me.lblButton3.TabIndex = 8
        Me.lblButton3.Text = "Run!"
        Me.lblButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prgOHealth
        '
        Me.prgOHealth.Location = New System.Drawing.Point(99, 82)
        Me.prgOHealth.Name = "prgOHealth"
        Me.prgOHealth.Size = New System.Drawing.Size(233, 20)
        Me.prgOHealth.TabIndex = 9
        Me.prgOHealth.Value = 50
        '
        'tmrRefreshTimer
        '
        Me.tmrRefreshTimer.Enabled = True
        '
        'lblOpponentName
        '
        Me.lblOpponentName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblOpponentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpponentName.Location = New System.Drawing.Point(95, 56)
        Me.lblOpponentName.Name = "lblOpponentName"
        Me.lblOpponentName.Size = New System.Drawing.Size(176, 23)
        Me.lblOpponentName.TabIndex = 10
        Me.lblOpponentName.Text = "Label1"
        '
        'PicZubat
        '
        Me.PicZubat.BackColor = System.Drawing.Color.Transparent
        Me.PicZubat.Image = CType(resources.GetObject("PicZubat.Image"), System.Drawing.Image)
        Me.PicZubat.Location = New System.Drawing.Point(515, 56)
        Me.PicZubat.Name = "PicZubat"
        Me.PicZubat.Size = New System.Drawing.Size(151, 125)
        Me.PicZubat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicZubat.TabIndex = 11
        Me.PicZubat.TabStop = False
        Me.PicZubat.Visible = False
        '
        'PicPaperCut
        '
        Me.PicPaperCut.BackColor = System.Drawing.Color.Transparent
        Me.PicPaperCut.Image = CType(resources.GetObject("PicPaperCut.Image"), System.Drawing.Image)
        Me.PicPaperCut.Location = New System.Drawing.Point(-5, 107)
        Me.PicPaperCut.Name = "PicPaperCut"
        Me.PicPaperCut.Size = New System.Drawing.Size(59, 60)
        Me.PicPaperCut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPaperCut.TabIndex = 12
        Me.PicPaperCut.TabStop = False
        '
        'tmrPaperCut
        '
        Me.tmrPaperCut.Interval = 50
        '
        'lblBattleText
        '
        Me.lblBattleText.BackColor = System.Drawing.Color.Transparent
        Me.lblBattleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBattleText.Location = New System.Drawing.Point(48, 339)
        Me.lblBattleText.Name = "lblBattleText"
        Me.lblBattleText.Size = New System.Drawing.Size(658, 84)
        Me.lblBattleText.TabIndex = 13
        Me.lblBattleText.Visible = False
        '
        'tmrDelay
        '
        Me.tmrDelay.Enabled = True
        '
        'tmrOppFlash
        '
        '
        'PicScreech
        '
        Me.PicScreech.BackColor = System.Drawing.Color.Transparent
        Me.PicScreech.Image = CType(resources.GetObject("PicScreech.Image"), System.Drawing.Image)
        Me.PicScreech.Location = New System.Drawing.Point(284, 153)
        Me.PicScreech.Name = "PicScreech"
        Me.PicScreech.Size = New System.Drawing.Size(173, 115)
        Me.PicScreech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicScreech.TabIndex = 16
        Me.PicScreech.TabStop = False
        Me.PicScreech.Visible = False
        '
        'lblLokiName
        '
        Me.lblLokiName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblLokiName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokiName.Location = New System.Drawing.Point(511, 245)
        Me.lblLokiName.Name = "lblLokiName"
        Me.lblLokiName.Size = New System.Drawing.Size(179, 23)
        Me.lblLokiName.TabIndex = 17
        Me.lblLokiName.Text = "Loki"
        '
        'lblNameBack
        '
        Me.lblNameBack.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblNameBack.Location = New System.Drawing.Point(472, 245)
        Me.lblNameBack.Name = "lblNameBack"
        Me.lblNameBack.Size = New System.Drawing.Size(281, 49)
        Me.lblNameBack.TabIndex = 18
        '
        'PrgLokiHP
        '
        Me.PrgLokiHP.Location = New System.Drawing.Point(520, 271)
        Me.PrgLokiHP.Name = "PrgLokiHP"
        Me.PrgLokiHP.Size = New System.Drawing.Size(233, 23)
        Me.PrgLokiHP.TabIndex = 19
        Me.PrgLokiHP.Value = 100
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label4.Location = New System.Drawing.Point(51, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 49)
        Me.Label4.TabIndex = 20
        '
        'tmrPaperPunch
        '
        '
        'tmrPaperPunch2
        '
        '
        'tmrPaperPunch3
        '
        Me.tmrPaperPunch3.Interval = 1000
        '
        'PicPaperPunch
        '
        Me.PicPaperPunch.BackColor = System.Drawing.Color.Transparent
        Me.PicPaperPunch.Image = CType(resources.GetObject("PicPaperPunch.Image"), System.Drawing.Image)
        Me.PicPaperPunch.Location = New System.Drawing.Point(477, 30)
        Me.PicPaperPunch.Name = "PicPaperPunch"
        Me.PicPaperPunch.Size = New System.Drawing.Size(229, 212)
        Me.PicPaperPunch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPaperPunch.TabIndex = 21
        Me.PicPaperPunch.TabStop = False
        Me.PicPaperPunch.Visible = False
        '
        'tmrPaperPunch4
        '
        '
        'PicLokiWiggle
        '
        Me.PicLokiWiggle.BackColor = System.Drawing.Color.Transparent
        Me.PicLokiWiggle.Image = CType(resources.GetObject("PicLokiWiggle.Image"), System.Drawing.Image)
        Me.PicLokiWiggle.Location = New System.Drawing.Point(114, 179)
        Me.PicLokiWiggle.Name = "PicLokiWiggle"
        Me.PicLokiWiggle.Size = New System.Drawing.Size(150, 128)
        Me.PicLokiWiggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLokiWiggle.TabIndex = 22
        Me.PicLokiWiggle.TabStop = False
        Me.PicLokiWiggle.Visible = False
        '
        'PicGeodude
        '
        Me.PicGeodude.BackColor = System.Drawing.Color.Transparent
        Me.PicGeodude.Image = CType(resources.GetObject("PicGeodude.Image"), System.Drawing.Image)
        Me.PicGeodude.Location = New System.Drawing.Point(501, 85)
        Me.PicGeodude.Name = "PicGeodude"
        Me.PicGeodude.Size = New System.Drawing.Size(170, 96)
        Me.PicGeodude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGeodude.TabIndex = 23
        Me.PicGeodude.TabStop = False
        Me.PicGeodude.Visible = False
        '
        'PicRock
        '
        Me.PicRock.BackColor = System.Drawing.Color.Transparent
        Me.PicRock.Image = CType(resources.GetObject("PicRock.Image"), System.Drawing.Image)
        Me.PicRock.Location = New System.Drawing.Point(347, 107)
        Me.PicRock.Name = "PicRock"
        Me.PicRock.Size = New System.Drawing.Size(138, 116)
        Me.PicRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRock.TabIndex = 24
        Me.PicRock.TabStop = False
        Me.PicRock.Visible = False
        '
        'tmrThrow
        '
        '
        'tmrLFlash
        '
        '
        'PicPidgey
        '
        Me.PicPidgey.BackColor = System.Drawing.Color.Transparent
        Me.PicPidgey.Image = CType(resources.GetObject("PicPidgey.Image"), System.Drawing.Image)
        Me.PicPidgey.Location = New System.Drawing.Point(535, 70)
        Me.PicPidgey.Name = "PicPidgey"
        Me.PicPidgey.Size = New System.Drawing.Size(131, 128)
        Me.PicPidgey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPidgey.TabIndex = 25
        Me.PicPidgey.TabStop = False
        Me.PicPidgey.Visible = False
        '
        'PicGust
        '
        Me.PicGust.BackColor = System.Drawing.Color.Transparent
        Me.PicGust.Image = CType(resources.GetObject("PicGust.Image"), System.Drawing.Image)
        Me.PicGust.Location = New System.Drawing.Point(347, 107)
        Me.PicGust.Name = "PicGust"
        Me.PicGust.Size = New System.Drawing.Size(138, 116)
        Me.PicGust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGust.TabIndex = 26
        Me.PicGust.TabStop = False
        Me.PicGust.Visible = False
        '
        'PicCaterpie
        '
        Me.PicCaterpie.BackColor = System.Drawing.Color.Transparent
        Me.PicCaterpie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PicCaterpie.Image = CType(resources.GetObject("PicCaterpie.Image"), System.Drawing.Image)
        Me.PicCaterpie.Location = New System.Drawing.Point(520, 70)
        Me.PicCaterpie.Name = "PicCaterpie"
        Me.PicCaterpie.Size = New System.Drawing.Size(129, 128)
        Me.PicCaterpie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCaterpie.TabIndex = 27
        Me.PicCaterpie.TabStop = False
        '
        'PicString
        '
        Me.PicString.BackColor = System.Drawing.Color.Transparent
        Me.PicString.Image = CType(resources.GetObject("PicString.Image"), System.Drawing.Image)
        Me.PicString.Location = New System.Drawing.Point(347, 107)
        Me.PicString.Name = "PicString"
        Me.PicString.Size = New System.Drawing.Size(138, 116)
        Me.PicString.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicString.TabIndex = 28
        Me.PicString.TabStop = False
        Me.PicString.Visible = False
        '
        'lblPokemon
        '
        Me.lblPokemon.BackColor = System.Drawing.Color.Transparent
        Me.lblPokemon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPokemon.Location = New System.Drawing.Point(99, 131)
        Me.lblPokemon.Name = "lblPokemon"
        Me.lblPokemon.Size = New System.Drawing.Size(165, 45)
        Me.lblPokemon.TabIndex = 29
        Me.lblPokemon.Text = "Loki: I'm the only Pokemon here!"
        Me.lblPokemon.Visible = False
        '
        'PicBulb
        '
        Me.PicBulb.BackColor = System.Drawing.Color.Transparent
        Me.PicBulb.Image = CType(resources.GetObject("PicBulb.Image"), System.Drawing.Image)
        Me.PicBulb.Location = New System.Drawing.Point(503, 53)
        Me.PicBulb.Name = "PicBulb"
        Me.PicBulb.Size = New System.Drawing.Size(168, 142)
        Me.PicBulb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBulb.TabIndex = 30
        Me.PicBulb.TabStop = False
        Me.PicBulb.Visible = False
        '
        'PicLeaf
        '
        Me.PicLeaf.BackColor = System.Drawing.Color.Transparent
        Me.PicLeaf.Image = CType(resources.GetObject("PicLeaf.Image"), System.Drawing.Image)
        Me.PicLeaf.Location = New System.Drawing.Point(347, 107)
        Me.PicLeaf.Name = "PicLeaf"
        Me.PicLeaf.Size = New System.Drawing.Size(138, 116)
        Me.PicLeaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLeaf.TabIndex = 31
        Me.PicLeaf.TabStop = False
        Me.PicLeaf.Visible = False
        '
        'frmBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 446)
        Me.Controls.Add(Me.PicLeaf)
        Me.Controls.Add(Me.lblPokemon)
        Me.Controls.Add(Me.PicString)
        Me.Controls.Add(Me.PicGust)
        Me.Controls.Add(Me.PicRock)
        Me.Controls.Add(Me.PicLokiWiggle)
        Me.Controls.Add(Me.PicPaperPunch)
        Me.Controls.Add(Me.PrgLokiHP)
        Me.Controls.Add(Me.lblLokiName)
        Me.Controls.Add(Me.lblNameBack)
        Me.Controls.Add(Me.PicScreech)
        Me.Controls.Add(Me.lblBattleText)
        Me.Controls.Add(Me.PicPaperCut)
        Me.Controls.Add(Me.PicZubat)
        Me.Controls.Add(Me.lblOpponentName)
        Me.Controls.Add(Me.prgOHealth)
        Me.Controls.Add(Me.lblButton3)
        Me.Controls.Add(Me.lblButton2)
        Me.Controls.Add(Me.lblButton4)
        Me.Controls.Add(Me.lblButton1)
        Me.Controls.Add(Me.PicCursor)
        Me.Controls.Add(Me.PicLokiBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PicGeodude)
        Me.Controls.Add(Me.PicPidgey)
        Me.Controls.Add(Me.PicCaterpie)
        Me.Controls.Add(Me.PicBulb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBattle"
        Me.Text = "Pokemon Battle"
        CType(Me.PicLokiBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicZubat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPaperCut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicScreech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPaperPunch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLokiWiggle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGeodude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPidgey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCaterpie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBulb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLeaf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicLokiBack As System.Windows.Forms.PictureBox
    Friend WithEvents PicCursor As System.Windows.Forms.PictureBox
    Friend WithEvents lblButton1 As System.Windows.Forms.Label
    Friend WithEvents lblButton4 As System.Windows.Forms.Label
    Friend WithEvents lblButton2 As System.Windows.Forms.Label
    Friend WithEvents lblButton3 As System.Windows.Forms.Label
    Friend WithEvents prgOHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrRefreshTimer As System.Windows.Forms.Timer
    Friend WithEvents lblOpponentName As System.Windows.Forms.Label
    Friend WithEvents PicZubat As System.Windows.Forms.PictureBox
    Friend WithEvents PicPaperCut As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPaperCut As System.Windows.Forms.Timer
    Friend WithEvents lblBattleText As System.Windows.Forms.Label
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer
    Friend WithEvents tmrOppFlash As System.Windows.Forms.Timer
    Friend WithEvents PicScreech As System.Windows.Forms.PictureBox
    Friend WithEvents lblLokiName As System.Windows.Forms.Label
    Friend WithEvents lblNameBack As System.Windows.Forms.Label
    Friend WithEvents PrgLokiHP As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tmrPaperPunch As System.Windows.Forms.Timer
    Friend WithEvents tmrPaperPunch2 As System.Windows.Forms.Timer
    Friend WithEvents tmrPaperPunch3 As System.Windows.Forms.Timer
    Friend WithEvents PicPaperPunch As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPaperPunch4 As System.Windows.Forms.Timer
    Friend WithEvents PicLokiWiggle As System.Windows.Forms.PictureBox
    Friend WithEvents PicGeodude As System.Windows.Forms.PictureBox
    Friend WithEvents PicRock As System.Windows.Forms.PictureBox
    Friend WithEvents tmrThrow As System.Windows.Forms.Timer
    Friend WithEvents tmrLFlash As System.Windows.Forms.Timer
    Friend WithEvents PicPidgey As System.Windows.Forms.PictureBox
    Friend WithEvents PicGust As System.Windows.Forms.PictureBox
    Friend WithEvents PicCaterpie As System.Windows.Forms.PictureBox
    Friend WithEvents PicString As System.Windows.Forms.PictureBox
    Friend WithEvents lblPokemon As System.Windows.Forms.Label
    Friend WithEvents PicBulb As System.Windows.Forms.PictureBox
    Friend WithEvents PicLeaf As System.Windows.Forms.PictureBox
End Class
