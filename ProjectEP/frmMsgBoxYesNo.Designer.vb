<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBoxYesNo
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
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblChoiceToMake = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.White
        Me.btnYes.Location = New System.Drawing.Point(118, 183)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(125, 42)
        Me.btnYes.TabIndex = 143
        Me.btnYes.Text = "YES"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMessage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Black
        Me.lblMessage.Location = New System.Drawing.Point(22, 122)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMessage.Size = New System.Drawing.Size(76, 23)
        Me.lblMessage.TabIndex = 144
        Me.lblMessage.Text = "Label1"
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.Firebrick
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.Location = New System.Drawing.Point(249, 183)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(125, 42)
        Me.btnNo.TabIndex = 145
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblChoiceToMake
        '
        Me.lblChoiceToMake.AutoSize = True
        Me.lblChoiceToMake.BackColor = System.Drawing.Color.Transparent
        Me.lblChoiceToMake.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblChoiceToMake.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoiceToMake.ForeColor = System.Drawing.Color.White
        Me.lblChoiceToMake.Location = New System.Drawing.Point(122, 43)
        Me.lblChoiceToMake.Name = "lblChoiceToMake"
        Me.lblChoiceToMake.Size = New System.Drawing.Size(288, 34)
        Me.lblChoiceToMake.TabIndex = 147
        Me.lblChoiceToMake.Text = "A Choice to make..."
        '
        'picIcon
        '
        Me.picIcon.Image = Global.ProjectEP.My.Resources.Resources.questions2
        Me.picIcon.Location = New System.Drawing.Point(12, 12)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(90, 90)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 148
        Me.picIcon.TabStop = False
        '
        'frmMsgBoxYesNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 254)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblChoiceToMake)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnYes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMsgBoxYesNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsgBoxYesNo"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblChoiceToMake As System.Windows.Forms.Label
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
End Class
