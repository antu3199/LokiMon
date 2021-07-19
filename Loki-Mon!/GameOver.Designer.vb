<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameOver))
        Me.lblBlackscreen = New System.Windows.Forms.Label()
        Me.PicLokiDie = New System.Windows.Forms.PictureBox()
        Me.lblLokiText = New System.Windows.Forms.Label()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.lblGameOver = New System.Windows.Forms.Label()
        CType(Me.PicLokiDie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBlackscreen
        '
        Me.lblBlackscreen.BackColor = System.Drawing.Color.Black
        Me.lblBlackscreen.Location = New System.Drawing.Point(-3, 1)
        Me.lblBlackscreen.Name = "lblBlackscreen"
        Me.lblBlackscreen.Size = New System.Drawing.Size(788, 444)
        Me.lblBlackscreen.TabIndex = 0
        Me.lblBlackscreen.Text = "Label1"
        '
        'PicLokiDie
        '
        Me.PicLokiDie.BackColor = System.Drawing.Color.Black
        Me.PicLokiDie.Image = CType(resources.GetObject("PicLokiDie.Image"), System.Drawing.Image)
        Me.PicLokiDie.Location = New System.Drawing.Point(270, 137)
        Me.PicLokiDie.Name = "PicLokiDie"
        Me.PicLokiDie.Size = New System.Drawing.Size(204, 190)
        Me.PicLokiDie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLokiDie.TabIndex = 1
        Me.PicLokiDie.TabStop = False
        '
        'lblLokiText
        '
        Me.lblLokiText.BackColor = System.Drawing.Color.Silver
        Me.lblLokiText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokiText.Location = New System.Drawing.Point(67, 372)
        Me.lblLokiText.Name = "lblLokiText"
        Me.lblLokiText.Size = New System.Drawing.Size(666, 61)
        Me.lblLokiText.TabIndex = 51
        Me.lblLokiText.Text = "And so, the Lokis were forever left unknown...."
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBorder.Location = New System.Drawing.Point(45, 357)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(699, 84)
        Me.lblBorder.TabIndex = 50
        '
        'lblGameOver
        '
        Me.lblGameOver.BackColor = System.Drawing.Color.Black
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Red
        Me.lblGameOver.Location = New System.Drawing.Point(53, 20)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(646, 101)
        Me.lblGameOver.TabIndex = 52
        Me.lblGameOver.Text = "GAME OVER"
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblLokiText)
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.PicLokiDie)
        Me.Controls.Add(Me.lblBlackscreen)
        Me.Name = "frmGameOver"
        Me.Text = "GameOver"
        CType(Me.PicLokiDie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBlackscreen As System.Windows.Forms.Label
    Friend WithEvents PicLokiDie As System.Windows.Forms.PictureBox
    Friend WithEvents lblLokiText As System.Windows.Forms.Label
    Friend WithEvents lblBorder As System.Windows.Forms.Label
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
End Class
