<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.lblChangePasswordTitle = New System.Windows.Forms.Label()
        Me.lineNewPassword = New System.Windows.Forms.PictureBox()
        Me.linePreviousPassword = New System.Windows.Forms.PictureBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtPreviousPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblPreviousPassword = New System.Windows.Forms.Label()
        Me.lblReEnterPassword = New System.Windows.Forms.Label()
        Me.lineReEnterPassword = New System.Windows.Forms.PictureBox()
        Me.txtReNewPassword = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        CType(Me.lineNewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linePreviousPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineReEnterPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChangePasswordTitle
        '
        Me.lblChangePasswordTitle.AutoSize = True
        Me.lblChangePasswordTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblChangePasswordTitle.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePasswordTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblChangePasswordTitle.Location = New System.Drawing.Point(143, 35)
        Me.lblChangePasswordTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChangePasswordTitle.Name = "lblChangePasswordTitle"
        Me.lblChangePasswordTitle.Size = New System.Drawing.Size(349, 40)
        Me.lblChangePasswordTitle.TabIndex = 140
        Me.lblChangePasswordTitle.Text = "CHANGE PASSWORD"
        '
        'lineNewPassword
        '
        Me.lineNewPassword.BackColor = System.Drawing.Color.White
        Me.lineNewPassword.Location = New System.Drawing.Point(323, 234)
        Me.lineNewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineNewPassword.Name = "lineNewPassword"
        Me.lineNewPassword.Size = New System.Drawing.Size(271, 2)
        Me.lineNewPassword.TabIndex = 146
        Me.lineNewPassword.TabStop = False
        '
        'linePreviousPassword
        '
        Me.linePreviousPassword.BackColor = System.Drawing.Color.White
        Me.linePreviousPassword.Location = New System.Drawing.Point(323, 170)
        Me.linePreviousPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.linePreviousPassword.Name = "linePreviousPassword"
        Me.linePreviousPassword.Size = New System.Drawing.Size(271, 2)
        Me.linePreviousPassword.TabIndex = 145
        Me.linePreviousPassword.TabStop = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.White
        Me.txtNewPassword.Location = New System.Drawing.Point(323, 207)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPassword.Size = New System.Drawing.Size(269, 29)
        Me.txtNewPassword.TabIndex = 144
        '
        'txtPreviousPassword
        '
        Me.txtPreviousPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPreviousPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPreviousPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousPassword.ForeColor = System.Drawing.Color.White
        Me.txtPreviousPassword.Location = New System.Drawing.Point(323, 143)
        Me.txtPreviousPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPreviousPassword.Name = "txtPreviousPassword"
        Me.txtPreviousPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPreviousPassword.Size = New System.Drawing.Size(269, 25)
        Me.txtPreviousPassword.TabIndex = 143
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblNewPassword.Location = New System.Drawing.Point(14, 210)
        Me.lblNewPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(172, 23)
        Me.lblNewPassword.TabIndex = 142
        Me.lblNewPassword.Text = "NEW PASSWORD:"
        '
        'lblPreviousPassword
        '
        Me.lblPreviousPassword.AutoSize = True
        Me.lblPreviousPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPreviousPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousPassword.ForeColor = System.Drawing.Color.White
        Me.lblPreviousPassword.Location = New System.Drawing.Point(14, 145)
        Me.lblPreviousPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreviousPassword.Name = "lblPreviousPassword"
        Me.lblPreviousPassword.Size = New System.Drawing.Size(224, 23)
        Me.lblPreviousPassword.TabIndex = 141
        Me.lblPreviousPassword.Text = "PREVIOUS PASSWORD:"
        '
        'lblReEnterPassword
        '
        Me.lblReEnterPassword.AutoSize = True
        Me.lblReEnterPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblReEnterPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReEnterPassword.ForeColor = System.Drawing.Color.White
        Me.lblReEnterPassword.Location = New System.Drawing.Point(14, 274)
        Me.lblReEnterPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReEnterPassword.Name = "lblReEnterPassword"
        Me.lblReEnterPassword.Size = New System.Drawing.Size(265, 23)
        Me.lblReEnterPassword.TabIndex = 147
        Me.lblReEnterPassword.Text = "RE-ENTER NEW PASSWORD:"
        '
        'lineReEnterPassword
        '
        Me.lineReEnterPassword.BackColor = System.Drawing.Color.White
        Me.lineReEnterPassword.Location = New System.Drawing.Point(325, 298)
        Me.lineReEnterPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineReEnterPassword.Name = "lineReEnterPassword"
        Me.lineReEnterPassword.Size = New System.Drawing.Size(271, 2)
        Me.lineReEnterPassword.TabIndex = 149
        Me.lineReEnterPassword.TabStop = False
        '
        'txtReNewPassword
        '
        Me.txtReNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtReNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReNewPassword.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReNewPassword.ForeColor = System.Drawing.Color.White
        Me.txtReNewPassword.Location = New System.Drawing.Point(325, 271)
        Me.txtReNewPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReNewPassword.Name = "txtReNewPassword"
        Me.txtReNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtReNewPassword.Size = New System.Drawing.Size(269, 29)
        Me.txtReNewPassword.TabIndex = 148
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(228, 368)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(190, 48)
        Me.btnConfirm.TabIndex = 150
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(33, 368)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 48)
        Me.btnBack.TabIndex = 151
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'picMinimise
        '
        Me.picMinimise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimise.Image = Global.ProjectEP.My.Resources.Resources.minus75
        Me.picMinimise.Location = New System.Drawing.Point(578, 12)
        Me.picMinimise.Name = "picMinimise"
        Me.picMinimise.Size = New System.Drawing.Size(30, 30)
        Me.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimise.TabIndex = 160
        Me.picMinimise.TabStop = False
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 451)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lineReEnterPassword)
        Me.Controls.Add(Me.txtReNewPassword)
        Me.Controls.Add(Me.lblReEnterPassword)
        Me.Controls.Add(Me.lineNewPassword)
        Me.Controls.Add(Me.linePreviousPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtPreviousPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.lblPreviousPassword)
        Me.Controls.Add(Me.lblChangePasswordTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangePassword"
        CType(Me.lineNewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linePreviousPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineReEnterPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChangePasswordTitle As System.Windows.Forms.Label
    Friend WithEvents lineNewPassword As System.Windows.Forms.PictureBox
    Friend WithEvents linePreviousPassword As System.Windows.Forms.PictureBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPreviousPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents lblPreviousPassword As System.Windows.Forms.Label
    Friend WithEvents lblReEnterPassword As System.Windows.Forms.Label
    Friend WithEvents lineReEnterPassword As System.Windows.Forms.PictureBox
    Friend WithEvents txtReNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
End Class
