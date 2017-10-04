<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lineID = New System.Windows.Forms.PictureBox()
        Me.linePassword = New System.Windows.Forms.PictureBox()
        Me.lblLoginCompanyName = New System.Windows.Forms.Label()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        CType(Me.lineID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(13, 90)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(87, 23)
        Me.lblUserID.TabIndex = 130
        Me.lblUserID.Text = "USER ID:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(13, 155)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(123, 23)
        Me.lblPassword.TabIndex = 131
        Me.lblPassword.Text = "PASSWORD:"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.ForeColor = System.Drawing.Color.White
        Me.txtUserID.Location = New System.Drawing.Point(164, 84)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(269, 25)
        Me.txtUserID.TabIndex = 132
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(164, 149)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(269, 29)
        Me.txtPassword.TabIndex = 133
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(308, 193)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(125, 48)
        Me.btnLogin.TabIndex = 134
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lineID
        '
        Me.lineID.BackColor = System.Drawing.Color.White
        Me.lineID.Location = New System.Drawing.Point(164, 111)
        Me.lineID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineID.Name = "lineID"
        Me.lineID.Size = New System.Drawing.Size(271, 2)
        Me.lineID.TabIndex = 135
        Me.lineID.TabStop = False
        '
        'linePassword
        '
        Me.linePassword.BackColor = System.Drawing.Color.White
        Me.linePassword.Location = New System.Drawing.Point(164, 176)
        Me.linePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.linePassword.Name = "linePassword"
        Me.linePassword.Size = New System.Drawing.Size(271, 2)
        Me.linePassword.TabIndex = 136
        Me.linePassword.TabStop = False
        '
        'lblLoginCompanyName
        '
        Me.lblLoginCompanyName.AutoSize = True
        Me.lblLoginCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginCompanyName.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblLoginCompanyName.Location = New System.Drawing.Point(27, 32)
        Me.lblLoginCompanyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoginCompanyName.Name = "lblLoginCompanyName"
        Me.lblLoginCompanyName.Size = New System.Drawing.Size(391, 40)
        Me.lblLoginCompanyName.TabIndex = 137
        Me.lblLoginCompanyName.Text = "ENTERPRISE RENT-A-CAR"
        '
        'picClose
        '
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.ProjectEP.My.Resources.Resources.close32
        Me.picClose.Location = New System.Drawing.Point(430, 5)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(30, 30)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 159
        Me.picClose.TabStop = False
        '
        'picMinimise
        '
        Me.picMinimise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimise.Image = Global.ProjectEP.My.Resources.Resources.minus75
        Me.picMinimise.Location = New System.Drawing.Point(394, 5)
        Me.picMinimise.Name = "picMinimise"
        Me.picMinimise.Size = New System.Drawing.Size(30, 30)
        Me.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimise.TabIndex = 160
        Me.picMinimise.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 254)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.lblLoginCompanyName)
        Me.Controls.Add(Me.linePassword)
        Me.Controls.Add(Me.lineID)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.lineID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lineID As System.Windows.Forms.PictureBox
    Friend WithEvents linePassword As System.Windows.Forms.PictureBox
    Friend WithEvents lblLoginCompanyName As System.Windows.Forms.Label
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
End Class
