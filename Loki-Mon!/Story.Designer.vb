<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStory))
        Me.PicBlack = New System.Windows.Forms.PictureBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.PicLoki = New System.Windows.Forms.PictureBox()
        Me.PicDrawing = New System.Windows.Forms.PictureBox()
        Me.PicSadLoki = New System.Windows.Forms.PictureBox()
        Me.PicAngryLoki = New System.Windows.Forms.PictureBox()
        Me.lblPressZ = New System.Windows.Forms.Label()
        Me.PicArrow = New System.Windows.Forms.PictureBox()
        CType(Me.PicBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLoki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSadLoki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAngryLoki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBlack
        '
        Me.PicBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicBlack.Image = CType(resources.GetObject("PicBlack.Image"), System.Drawing.Image)
        Me.PicBlack.Location = New System.Drawing.Point(-16, -4)
        Me.PicBlack.Name = "PicBlack"
        Me.PicBlack.Size = New System.Drawing.Size(839, 369)
        Me.PicBlack.TabIndex = 1
        Me.PicBlack.TabStop = False
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(40, 393)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(688, 55)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "I CAN'T STAND IT!!!"
        '
        'PicLoki
        '
        Me.PicLoki.BackColor = System.Drawing.Color.Transparent
        Me.PicLoki.Image = CType(resources.GetObject("PicLoki.Image"), System.Drawing.Image)
        Me.PicLoki.Location = New System.Drawing.Point(212, 22)
        Me.PicLoki.Name = "PicLoki"
        Me.PicLoki.Size = New System.Drawing.Size(455, 302)
        Me.PicLoki.TabIndex = 3
        Me.PicLoki.TabStop = False
        Me.PicLoki.Visible = False
        '
        'PicDrawing
        '
        Me.PicDrawing.Image = CType(resources.GetObject("PicDrawing.Image"), System.Drawing.Image)
        Me.PicDrawing.Location = New System.Drawing.Point(-3, -4)
        Me.PicDrawing.Name = "PicDrawing"
        Me.PicDrawing.Size = New System.Drawing.Size(788, 369)
        Me.PicDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDrawing.TabIndex = 4
        Me.PicDrawing.TabStop = False
        Me.PicDrawing.Visible = False
        '
        'PicSadLoki
        '
        Me.PicSadLoki.Image = CType(resources.GetObject("PicSadLoki.Image"), System.Drawing.Image)
        Me.PicSadLoki.Location = New System.Drawing.Point(212, 22)
        Me.PicSadLoki.Name = "PicSadLoki"
        Me.PicSadLoki.Size = New System.Drawing.Size(455, 302)
        Me.PicSadLoki.TabIndex = 5
        Me.PicSadLoki.TabStop = False
        Me.PicSadLoki.Visible = False
        '
        'PicAngryLoki
        '
        Me.PicAngryLoki.BackColor = System.Drawing.Color.Transparent
        Me.PicAngryLoki.Image = CType(resources.GetObject("PicAngryLoki.Image"), System.Drawing.Image)
        Me.PicAngryLoki.Location = New System.Drawing.Point(212, 22)
        Me.PicAngryLoki.Name = "PicAngryLoki"
        Me.PicAngryLoki.Size = New System.Drawing.Size(455, 302)
        Me.PicAngryLoki.TabIndex = 6
        Me.PicAngryLoki.TabStop = False
        Me.PicAngryLoki.Visible = False
        '
        'lblPressZ
        '
        Me.lblPressZ.AutoSize = True
        Me.lblPressZ.BackColor = System.Drawing.Color.Transparent
        Me.lblPressZ.Location = New System.Drawing.Point(628, 420)
        Me.lblPressZ.Name = "lblPressZ"
        Me.lblPressZ.Size = New System.Drawing.Size(100, 13)
        Me.lblPressZ.TabIndex = 7
        Me.lblPressZ.Text = "Press Z to advance"
        '
        'PicArrow
        '
        Me.PicArrow.BackColor = System.Drawing.Color.Transparent
        Me.PicArrow.Image = CType(resources.GetObject("PicArrow.Image"), System.Drawing.Image)
        Me.PicArrow.Location = New System.Drawing.Point(734, 420)
        Me.PicArrow.Name = "PicArrow"
        Me.PicArrow.Size = New System.Drawing.Size(23, 13)
        Me.PicArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicArrow.TabIndex = 8
        Me.PicArrow.TabStop = False
        '
        'frmStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 442)
        Me.Controls.Add(Me.PicArrow)
        Me.Controls.Add(Me.lblPressZ)
        Me.Controls.Add(Me.PicBlack)
        Me.Controls.Add(Me.PicAngryLoki)
        Me.Controls.Add(Me.PicSadLoki)
        Me.Controls.Add(Me.PicLoki)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.PicDrawing)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStory"
        Me.Text = "Loki-Mon!"
        CType(Me.PicBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLoki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSadLoki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAngryLoki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBlack As System.Windows.Forms.PictureBox
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents PicLoki As System.Windows.Forms.PictureBox
    Friend WithEvents PicDrawing As System.Windows.Forms.PictureBox
    Friend WithEvents PicSadLoki As System.Windows.Forms.PictureBox
    Friend WithEvents PicAngryLoki As System.Windows.Forms.PictureBox
    Friend WithEvents lblPressZ As System.Windows.Forms.Label
    Friend WithEvents PicArrow As System.Windows.Forms.PictureBox
End Class
