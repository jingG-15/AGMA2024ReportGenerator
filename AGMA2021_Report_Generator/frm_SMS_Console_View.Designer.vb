<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SMS_Console_View
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SMS_Console_View))
        Me.Rchtxt_Message_Stats = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.MetroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
        Me.Label_X = New DevComponents.DotNetBar.LabelItem()
        Me.Prog_Sig_1 = New DevComponents.DotNetBar.ProgressBarItem()
        Me.Prog_Sig_2 = New DevComponents.DotNetBar.ProgressBarItem()
        Me.Prog_Sig_3 = New DevComponents.DotNetBar.ProgressBarItem()
        Me.Prog_Sig_4 = New DevComponents.DotNetBar.ProgressBarItem()
        Me.btn_Start_Send = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Stop_Send = New DevComponents.DotNetBar.ButtonX()
        Me.btn_Connect = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'Rchtxt_Message_Stats
        '
        Me.Rchtxt_Message_Stats.BackColor = System.Drawing.Color.White
        Me.Rchtxt_Message_Stats.BackColorRichTextBox = System.Drawing.SystemColors.InactiveCaptionText
        '
        '
        '
        Me.Rchtxt_Message_Stats.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Rchtxt_Message_Stats.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Rchtxt_Message_Stats.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.0!)
        Me.Rchtxt_Message_Stats.ForeColor = System.Drawing.Color.Black
        Me.Rchtxt_Message_Stats.Location = New System.Drawing.Point(8, 33)
        Me.Rchtxt_Message_Stats.Name = "Rchtxt_Message_Stats"
        Me.Rchtxt_Message_Stats.ReadOnly = True
        Me.Rchtxt_Message_Stats.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang13321{\fonttbl{\f0\fnil\fcharset0" &
    " Bahnschrift SemiLight;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.19041}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\p" &
    "ard\f0\fs23\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Rchtxt_Message_Stats.Size = New System.Drawing.Size(486, 459)
        Me.Rchtxt_Message_Stats.TabIndex = 7
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 12)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(486, 15)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Status Info:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'MetroStatusBar1
        '
        Me.MetroStatusBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.MetroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroStatusBar1.ContainerControlProcessDialogKey = True
        Me.MetroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroStatusBar1.DragDropSupport = True
        Me.MetroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroStatusBar1.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Label_X, Me.Prog_Sig_1, Me.Prog_Sig_2, Me.Prog_Sig_3, Me.Prog_Sig_4})
        Me.MetroStatusBar1.Location = New System.Drawing.Point(0, 542)
        Me.MetroStatusBar1.Name = "MetroStatusBar1"
        Me.MetroStatusBar1.Size = New System.Drawing.Size(506, 25)
        Me.MetroStatusBar1.TabIndex = 8
        Me.MetroStatusBar1.Text = "MetroStatusBar1"
        '
        'Label_X
        '
        Me.Label_X.Font = New System.Drawing.Font("Bahnschrift SemiLight", 8.25!)
        Me.Label_X.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Label_X.Name = "Label_X"
        Me.Label_X.Text = "Broadband Signal Strength: "
        Me.Label_X.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Prog_Sig_1
        '
        '
        '
        '
        Me.Prog_Sig_1.BackStyle.BackColor = System.Drawing.Color.Red
        Me.Prog_Sig_1.BackStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Prog_Sig_1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Prog_Sig_1.ChunkGradientAngle = 0!
        Me.Prog_Sig_1.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.[Error]
        Me.Prog_Sig_1.Height = 15
        Me.Prog_Sig_1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Prog_Sig_1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.Prog_Sig_1.Name = "Prog_Sig_1"
        Me.Prog_Sig_1.RecentlyUsed = False
        Me.Prog_Sig_1.TextVisible = True
        Me.Prog_Sig_1.Value = 100
        Me.Prog_Sig_1.Width = 10
        '
        'Prog_Sig_2
        '
        '
        '
        '
        Me.Prog_Sig_2.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Prog_Sig_2.ChunkGradientAngle = 0!
        Me.Prog_Sig_2.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused
        Me.Prog_Sig_2.Height = 15
        Me.Prog_Sig_2.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Prog_Sig_2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.Prog_Sig_2.Name = "Prog_Sig_2"
        Me.Prog_Sig_2.RecentlyUsed = False
        Me.Prog_Sig_2.Value = 100
        Me.Prog_Sig_2.Width = 10
        '
        'Prog_Sig_3
        '
        '
        '
        '
        Me.Prog_Sig_3.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Prog_Sig_3.ChunkGradientAngle = 0!
        Me.Prog_Sig_3.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused
        Me.Prog_Sig_3.Height = 15
        Me.Prog_Sig_3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Prog_Sig_3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.Prog_Sig_3.Name = "Prog_Sig_3"
        Me.Prog_Sig_3.RecentlyUsed = False
        Me.Prog_Sig_3.Value = 100
        Me.Prog_Sig_3.Width = 10
        '
        'Prog_Sig_4
        '
        '
        '
        '
        Me.Prog_Sig_4.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Prog_Sig_4.ChunkGradientAngle = 0!
        Me.Prog_Sig_4.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused
        Me.Prog_Sig_4.Height = 15
        Me.Prog_Sig_4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.Prog_Sig_4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.Prog_Sig_4.Name = "Prog_Sig_4"
        Me.Prog_Sig_4.RecentlyUsed = False
        Me.Prog_Sig_4.Value = 100
        Me.Prog_Sig_4.Width = 10
        '
        'btn_Start_Send
        '
        Me.btn_Start_Send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Start_Send.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Start_Send.Enabled = False
        Me.btn_Start_Send.Location = New System.Drawing.Point(220, 498)
        Me.btn_Start_Send.Name = "btn_Start_Send"
        Me.btn_Start_Send.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Start_Send.Size = New System.Drawing.Size(134, 35)
        Me.btn_Start_Send.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Start_Send.TabIndex = 9
        Me.btn_Start_Send.Text = "Start Sending"
        '
        'btn_Stop_Send
        '
        Me.btn_Stop_Send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Stop_Send.Enabled = False
        Me.btn_Stop_Send.Location = New System.Drawing.Point(360, 498)
        Me.btn_Stop_Send.Name = "btn_Stop_Send"
        Me.btn_Stop_Send.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Stop_Send.Size = New System.Drawing.Size(134, 35)
        Me.btn_Stop_Send.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Stop_Send.TabIndex = 9
        Me.btn_Stop_Send.Text = "Stop Sending"
        '
        'btn_Connect
        '
        Me.btn_Connect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Connect.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Connect.Enabled = False
        Me.btn_Connect.Location = New System.Drawing.Point(12, 498)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Connect.Size = New System.Drawing.Size(134, 35)
        Me.btn_Connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Connect.TabIndex = 9
        Me.btn_Connect.Text = "Connect to Modem"
        '
        'frm_SMS_Console_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 567)
        Me.Controls.Add(Me.btn_Stop_Send)
        Me.Controls.Add(Me.btn_Connect)
        Me.Controls.Add(Me.btn_Start_Send)
        Me.Controls.Add(Me.MetroStatusBar1)
        Me.Controls.Add(Me.Rchtxt_Message_Stats)
        Me.Controls.Add(Me.LabelX4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_SMS_Console_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMS Sending Status View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rchtxt_Message_Stats As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents MetroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
    Friend WithEvents Label_X As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Prog_Sig_1 As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents Prog_Sig_2 As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents Prog_Sig_3 As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents Prog_Sig_4 As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents btn_Start_Send As ButtonX
    Friend WithEvents btn_Stop_Send As ButtonX
    Friend WithEvents btn_Connect As ButtonX
End Class
