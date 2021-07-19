<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheEnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTheEnd))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTheEnd = New System.Windows.Forms.Label()
        Me.lblFewDaysLater = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(197, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(471, 203)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(268, 40)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "No099 LOKI"
        '
        'lblTheEnd
        '
        Me.lblTheEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblTheEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTheEnd.Location = New System.Drawing.Point(52, 319)
        Me.lblTheEnd.Name = "lblTheEnd"
        Me.lblTheEnd.Size = New System.Drawing.Size(705, 132)
        Me.lblTheEnd.TabIndex = 2
        Me.lblTheEnd.Text = "THE END!"
        '
        'lblFewDaysLater
        '
        Me.lblFewDaysLater.BackColor = System.Drawing.Color.Yellow
        Me.lblFewDaysLater.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFewDaysLater.Location = New System.Drawing.Point(-1, -1)
        Me.lblFewDaysLater.Name = "lblFewDaysLater"
        Me.lblFewDaysLater.Size = New System.Drawing.Size(320, 41)
        Me.lblFewDaysLater.TabIndex = 3
        Me.lblFewDaysLater.Text = "A few days later..."
        '
        'frmTheEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 446)
        Me.Controls.Add(Me.lblFewDaysLater)
        Me.Controls.Add(Me.lblTheEnd)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmTheEnd"
        Me.Text = "The End!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblTheEnd As System.Windows.Forms.Label
    Friend WithEvents lblFewDaysLater As System.Windows.Forms.Label
End Class
