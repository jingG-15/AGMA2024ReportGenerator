<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Photo_Viewer
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Photo_Viewer))
        Me.NoScrollPanel1 = New AGMA2024_Report_Generator.NoScrollPanel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pic_fit_to_screen = New System.Windows.Forms.PictureBox()
        Me.pic_zoom_out = New System.Windows.Forms.PictureBox()
        Me.pic_zoom_in = New System.Windows.Forms.PictureBox()
        Me.NoScrollPanel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_fit_to_screen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_zoom_out, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_zoom_in, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoScrollPanel1
        '
        Me.NoScrollPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.NoScrollPanel1.Controls.Add(Me.pb1)
        Me.NoScrollPanel1.ForeColor = System.Drawing.Color.Black
        Me.NoScrollPanel1.Location = New System.Drawing.Point(348, 80)
        Me.NoScrollPanel1.Name = "NoScrollPanel1"
        Me.NoScrollPanel1.Size = New System.Drawing.Size(395, 351)
        Me.NoScrollPanel1.TabIndex = 9
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb1.ForeColor = System.Drawing.Color.Black
        Me.pb1.Location = New System.Drawing.Point(45, 54)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(264, 212)
        Me.pb1.TabIndex = 0
        Me.pb1.TabStop = False
        '
        'pic_fit_to_screen
        '
        Me.pic_fit_to_screen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pic_fit_to_screen.ForeColor = System.Drawing.Color.Black
        Me.pic_fit_to_screen.Image = Global.AGMA2024_Report_Generator.My.Resources.Resources.fullscr
        Me.pic_fit_to_screen.Location = New System.Drawing.Point(281, 159)
        Me.pic_fit_to_screen.Name = "pic_fit_to_screen"
        Me.pic_fit_to_screen.Size = New System.Drawing.Size(40, 40)
        Me.pic_fit_to_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_fit_to_screen.TabIndex = 10
        Me.pic_fit_to_screen.TabStop = False
        '
        'pic_zoom_out
        '
        Me.pic_zoom_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pic_zoom_out.ForeColor = System.Drawing.Color.Black
        Me.pic_zoom_out.Image = Global.AGMA2024_Report_Generator.My.Resources.Resources.zoom_in
        Me.pic_zoom_out.Location = New System.Drawing.Point(242, 263)
        Me.pic_zoom_out.Name = "pic_zoom_out"
        Me.pic_zoom_out.Size = New System.Drawing.Size(40, 40)
        Me.pic_zoom_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_zoom_out.TabIndex = 10
        Me.pic_zoom_out.TabStop = False
        '
        'pic_zoom_in
        '
        Me.pic_zoom_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pic_zoom_in.ForeColor = System.Drawing.Color.Black
        Me.pic_zoom_in.Image = Global.AGMA2024_Report_Generator.My.Resources.Resources.zoom_out
        Me.pic_zoom_in.Location = New System.Drawing.Point(328, 382)
        Me.pic_zoom_in.Name = "pic_zoom_in"
        Me.pic_zoom_in.Size = New System.Drawing.Size(40, 40)
        Me.pic_zoom_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_zoom_in.TabIndex = 10
        Me.pic_zoom_in.TabStop = False
        '
        'frm_Photo_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 554)
        Me.Controls.Add(Me.pic_fit_to_screen)
        Me.Controls.Add(Me.pic_zoom_out)
        Me.Controls.Add(Me.pic_zoom_in)
        Me.Controls.Add(Me.NoScrollPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Photo_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photo Viewer"
        Me.NoScrollPanel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_fit_to_screen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_zoom_out, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_zoom_in, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NoScrollPanel1 As AGMA2024_Report_Generator.NoScrollPanel
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_zoom_in As System.Windows.Forms.PictureBox
    Friend WithEvents pic_zoom_out As System.Windows.Forms.PictureBox
    Friend WithEvents pic_fit_to_screen As System.Windows.Forms.PictureBox
End Class
