<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitleScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTitleScreen))
        Me.lblLokiMon = New System.Windows.Forms.Label()
        Me.PicCursor = New System.Windows.Forms.PictureBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblEndGame = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMyNAme = New System.Windows.Forms.Label()
        Me.lblstartgame = New System.Windows.Forms.Label()
        Me.lblControls = New System.Windows.Forms.Label()
        Me.lblExitGame = New System.Windows.Forms.Label()
        Me.Pichand = New System.Windows.Forms.PictureBox()
        Me.lblAnthony = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPress = New System.Windows.Forms.Label()
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pichand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLokiMon
        '
        Me.lblLokiMon.BackColor = System.Drawing.Color.Transparent
        Me.lblLokiMon.Location = New System.Drawing.Point(27, 9)
        Me.lblLokiMon.Name = "lblLokiMon"
        Me.lblLokiMon.Size = New System.Drawing.Size(732, 137)
        Me.lblLokiMon.TabIndex = 0
        Me.lblLokiMon.Text = "Loki-Mon!"
        '
        'PicCursor
        '
        Me.PicCursor.BackColor = System.Drawing.Color.Transparent
        Me.PicCursor.Image = CType(resources.GetObject("PicCursor.Image"), System.Drawing.Image)
        Me.PicCursor.Location = New System.Drawing.Point(237, 200)
        Me.PicCursor.Name = "PicCursor"
        Me.PicCursor.Size = New System.Drawing.Size(63, 50)
        Me.PicCursor.TabIndex = 3
        Me.PicCursor.TabStop = False
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Location = New System.Drawing.Point(132, 211)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(546, 31)
        Me.lblStart.TabIndex = 4
        Me.lblStart.Text = "Start Game!"
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Location = New System.Drawing.Point(138, 265)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(540, 31)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Controls"
        '
        'lblEndGame
        '
        Me.lblEndGame.BackColor = System.Drawing.Color.Transparent
        Me.lblEndGame.Location = New System.Drawing.Point(128, 316)
        Me.lblEndGame.Name = "lblEndGame"
        Me.lblEndGame.Size = New System.Drawing.Size(550, 31)
        Me.lblEndGame.TabIndex = 6
        Me.lblEndGame.Text = "End Game"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(134, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Press Up/Down to choose option, Z to Select."
        '
        'lblMyNAme
        '
        Me.lblMyNAme.AutoSize = True
        Me.lblMyNAme.BackColor = System.Drawing.Color.Transparent
        Me.lblMyNAme.Location = New System.Drawing.Point(665, 424)
        Me.lblMyNAme.Name = "lblMyNAme"
        Me.lblMyNAme.Size = New System.Drawing.Size(94, 13)
        Me.lblMyNAme.TabIndex = 8
        Me.lblMyNAme.Text = "By: Anthony Tu"
        '
        'lblstartgame
        '
        Me.lblstartgame.AutoSize = True
        Me.lblstartgame.BackColor = System.Drawing.Color.Transparent
        Me.lblstartgame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstartgame.Location = New System.Drawing.Point(359, 222)
        Me.lblstartgame.Name = "lblstartgame"
        Me.lblstartgame.Size = New System.Drawing.Size(63, 25)
        Me.lblstartgame.TabIndex = 0
        Me.lblstartgame.Text = "Start!"
        '
        'lblControls
        '
        Me.lblControls.AutoSize = True
        Me.lblControls.BackColor = System.Drawing.Color.Transparent
        Me.lblControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControls.Location = New System.Drawing.Point(359, 275)
        Me.lblControls.Name = "lblControls"
        Me.lblControls.Size = New System.Drawing.Size(92, 25)
        Me.lblControls.TabIndex = 1
        Me.lblControls.Text = "Controls"
        '
        'lblExitGame
        '
        Me.lblExitGame.AutoSize = True
        Me.lblExitGame.BackColor = System.Drawing.Color.Transparent
        Me.lblExitGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExitGame.Location = New System.Drawing.Point(359, 330)
        Me.lblExitGame.Name = "lblExitGame"
        Me.lblExitGame.Size = New System.Drawing.Size(107, 25)
        Me.lblExitGame.TabIndex = 2
        Me.lblExitGame.Text = "Exit game"
        '
        'Pichand
        '
        Me.Pichand.BackColor = System.Drawing.Color.Transparent
        Me.Pichand.Image = CType(resources.GetObject("Pichand.Image"), System.Drawing.Image)
        Me.Pichand.Location = New System.Drawing.Point(263, 211)
        Me.Pichand.Name = "Pichand"
        Me.Pichand.Size = New System.Drawing.Size(66, 50)
        Me.Pichand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pichand.TabIndex = 3
        Me.Pichand.TabStop = False
        '
        'lblAnthony
        '
        Me.lblAnthony.AutoSize = True
        Me.lblAnthony.BackColor = System.Drawing.Color.Transparent
        Me.lblAnthony.Location = New System.Drawing.Point(587, 151)
        Me.lblAnthony.Name = "lblAnthony"
        Me.lblAnthony.Size = New System.Drawing.Size(80, 13)
        Me.lblAnthony.TabIndex = 4
        Me.lblAnthony.Text = "By: Anthony Tu"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(171, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(474, 108)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Loki-Mon!"
        '
        'lblPress
        '
        Me.lblPress.AutoSize = True
        Me.lblPress.BackColor = System.Drawing.Color.Transparent
        Me.lblPress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPress.Location = New System.Drawing.Point(246, 391)
        Me.lblPress.Name = "lblPress"
        Me.lblPress.Size = New System.Drawing.Size(344, 25)
        Me.lblPress.TabIndex = 6
        Me.lblPress.Text = "Press Up/Down and Z to select."
        '
        'frmTitleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(792, 446)
        Me.Controls.Add(Me.lblPress)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblAnthony)
        Me.Controls.Add(Me.Pichand)
        Me.Controls.Add(Me.lblExitGame)
        Me.Controls.Add(Me.lblControls)
        Me.Controls.Add(Me.lblstartgame)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTitleScreen"
        Me.Text = "Loki-Mon!"
        CType(Me.PicCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pichand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLokiMon As System.Windows.Forms.Label
    Friend WithEvents PicCursor As System.Windows.Forms.PictureBox
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblEndGame As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMyNAme As System.Windows.Forms.Label
    Friend WithEvents lblstartgame As System.Windows.Forms.Label
    Friend WithEvents lblControls As System.Windows.Forms.Label
    Friend WithEvents lblExitGame As System.Windows.Forms.Label
    Friend WithEvents Pichand As System.Windows.Forms.PictureBox
    Friend WithEvents lblAnthony As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPress As System.Windows.Forms.Label

End Class
