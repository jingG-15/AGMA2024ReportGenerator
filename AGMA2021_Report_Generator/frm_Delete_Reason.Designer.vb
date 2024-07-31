<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Delete_Reason
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Delete_Reason))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btn_Confirm = New DevComponents.DotNetBar.ButtonX()
        Me.chk_inv_ID = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chk_inv_Sign = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(0, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(259, 20)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Select purpose of Delete"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btn_Confirm
        '
        Me.btn_Confirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_Confirm.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btn_Confirm.Location = New System.Drawing.Point(125, 127)
        Me.btn_Confirm.Name = "btn_Confirm"
        Me.btn_Confirm.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.btn_Confirm.Size = New System.Drawing.Size(134, 35)
        Me.btn_Confirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_Confirm.TabIndex = 4
        Me.btn_Confirm.Text = "Confirm"
        '
        'chk_inv_ID
        '
        Me.chk_inv_ID.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chk_inv_ID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chk_inv_ID.ForeColor = System.Drawing.Color.Black
        Me.chk_inv_ID.Location = New System.Drawing.Point(12, 48)
        Me.chk_inv_ID.Name = "chk_inv_ID"
        Me.chk_inv_ID.Size = New System.Drawing.Size(192, 23)
        Me.chk_inv_ID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chk_inv_ID.TabIndex = 15
        Me.chk_inv_ID.Text = "Invalid photo of ID Provided"
        '
        'chk_inv_Sign
        '
        Me.chk_inv_Sign.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chk_inv_Sign.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chk_inv_Sign.ForeColor = System.Drawing.Color.Black
        Me.chk_inv_Sign.Location = New System.Drawing.Point(12, 77)
        Me.chk_inv_Sign.Name = "chk_inv_Sign"
        Me.chk_inv_Sign.Size = New System.Drawing.Size(226, 23)
        Me.chk_inv_Sign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chk_inv_Sign.TabIndex = 15
        Me.chk_inv_Sign.Text = "Invalid Signature upon visual verification"
        '
        'frm_Delete_Reason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 174)
        Me.Controls.Add(Me.chk_inv_Sign)
        Me.Controls.Add(Me.chk_inv_ID)
        Me.Controls.Add(Me.btn_Confirm)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Delete_Reason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reason for Delete"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_Confirm As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_inv_ID As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_inv_Sign As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
