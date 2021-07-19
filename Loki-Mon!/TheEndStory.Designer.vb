<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheEndStory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheEndStory))
        Me.PicTrainer = New System.Windows.Forms.PictureBox()
        Me.lblLokiText = New System.Windows.Forms.Label()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.lblBlackscreen = New System.Windows.Forms.Label()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicTrainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicTrainer
        '
        Me.PicTrainer.BackColor = System.Drawing.Color.Transparent
        Me.PicTrainer.Image = CType(resources.GetObject("PicTrainer.Image"), System.Drawing.Image)
        Me.PicTrainer.Location = New System.Drawing.Point(396, 189)
        Me.PicTrainer.Name = "PicTrainer"
        Me.PicTrainer.Size = New System.Drawing.Size(38, 48)
        Me.PicTrainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTrainer.TabIndex = 0
        Me.PicTrainer.TabStop = False
        '
        'lblLokiText
        '
        Me.lblLokiText.BackColor = System.Drawing.Color.Silver
        Me.lblLokiText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokiText.Location = New System.Drawing.Point(67, 376)
        Me.lblLokiText.Name = "lblLokiText"
        Me.lblLokiText.Size = New System.Drawing.Size(666, 61)
        Me.lblLokiText.TabIndex = 52
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBorder.Location = New System.Drawing.Point(51, 368)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(699, 84)
        Me.lblBorder.TabIndex = 53
        '
        'lblBlackscreen
        '
        Me.lblBlackscreen.BackColor = System.Drawing.Color.Black
        Me.lblBlackscreen.Location = New System.Drawing.Point(-2, -3)
        Me.lblBlackscreen.Name = "lblBlackscreen"
        Me.lblBlackscreen.Size = New System.Drawing.Size(795, 455)
        Me.lblBlackscreen.TabIndex = 54
        Me.lblBlackscreen.Text = "Label1"
        '
        'tmrDelay
        '
        Me.tmrDelay.Enabled = True
        '
        'frmTheEndStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 446)
        Me.Controls.Add(Me.lblLokiText)
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.lblBlackscreen)
        Me.Controls.Add(Me.PicTrainer)
        Me.DoubleBuffered = True
        Me.Name = "frmTheEndStory"
        Me.Text = "TheEndStory"
        CType(Me.PicTrainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicTrainer As System.Windows.Forms.PictureBox
    Friend WithEvents lblLokiText As System.Windows.Forms.Label
    Friend WithEvents lblBorder As System.Windows.Forms.Label
    Friend WithEvents lblBlackscreen As System.Windows.Forms.Label
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer
End Class
