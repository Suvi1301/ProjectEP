<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelOrder
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
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lblNewOrderTitle = New System.Windows.Forms.Label()
        Me.btnSearchOrder = New System.Windows.Forms.Button()
        Me.lblNewOrderSearch = New System.Windows.Forms.Label()
        Me.lineNewOrderSearch = New System.Windows.Forms.PictureBox()
        Me.txtOrderSearch = New System.Windows.Forms.TextBox()
        Me.lblCarDetTitle = New System.Windows.Forms.Label()
        Me.lblCarDetails = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblCustNameTitel = New System.Windows.Forms.Label()
        Me.lblHireDetTitle = New System.Windows.Forms.Label()
        Me.lblHireDetails = New System.Windows.Forms.Label()
        Me.TTCancel = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.lblOrderNoTitle = New System.Windows.Forms.Label()
        Me.lblOrdernum = New System.Windows.Forms.Label()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineNewOrderSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMinimise
        '
        Me.picMinimise.Image = Global.ProjectEP.My.Resources.Resources.minus75
        Me.picMinimise.Location = New System.Drawing.Point(682, 9)
        Me.picMinimise.Name = "picMinimise"
        Me.picMinimise.Size = New System.Drawing.Size(30, 30)
        Me.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimise.TabIndex = 161
        Me.picMinimise.TabStop = False
        '
        'picClose
        '
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.ProjectEP.My.Resources.Resources.close32
        Me.picClose.Location = New System.Drawing.Point(716, 9)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(30, 30)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 160
        Me.picClose.TabStop = False
        '
        'lblNewOrderTitle
        '
        Me.lblNewOrderTitle.AutoSize = True
        Me.lblNewOrderTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblNewOrderTitle.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewOrderTitle.ForeColor = System.Drawing.Color.White
        Me.lblNewOrderTitle.Location = New System.Drawing.Point(178, 9)
        Me.lblNewOrderTitle.Name = "lblNewOrderTitle"
        Me.lblNewOrderTitle.Size = New System.Drawing.Size(321, 39)
        Me.lblNewOrderTitle.TabIndex = 162
        Me.lblNewOrderTitle.Text = "CANCEL AN ORDER"
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnSearchOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchOrder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchOrder.Location = New System.Drawing.Point(464, 74)
        Me.btnSearchOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.Size = New System.Drawing.Size(125, 45)
        Me.btnSearchOrder.TabIndex = 165
        Me.btnSearchOrder.Text = "SEARCH"
        Me.btnSearchOrder.UseVisualStyleBackColor = False
        '
        'lblNewOrderSearch
        '
        Me.lblNewOrderSearch.AutoSize = True
        Me.lblNewOrderSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblNewOrderSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewOrderSearch.ForeColor = System.Drawing.Color.White
        Me.lblNewOrderSearch.Location = New System.Drawing.Point(34, 93)
        Me.lblNewOrderSearch.Name = "lblNewOrderSearch"
        Me.lblNewOrderSearch.Size = New System.Drawing.Size(192, 23)
        Me.lblNewOrderSearch.TabIndex = 164
        Me.lblNewOrderSearch.Text = "SEARCH ORDER ID:"
        '
        'lineNewOrderSearch
        '
        Me.lineNewOrderSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineNewOrderSearch.Location = New System.Drawing.Point(260, 117)
        Me.lineNewOrderSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineNewOrderSearch.Name = "lineNewOrderSearch"
        Me.lineNewOrderSearch.Size = New System.Drawing.Size(163, 2)
        Me.lineNewOrderSearch.TabIndex = 167
        Me.lineNewOrderSearch.TabStop = False
        '
        'txtOrderSearch
        '
        Me.txtOrderSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtOrderSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOrderSearch.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderSearch.ForeColor = System.Drawing.Color.White
        Me.txtOrderSearch.Location = New System.Drawing.Point(260, 95)
        Me.txtOrderSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrderSearch.Name = "txtOrderSearch"
        Me.txtOrderSearch.Size = New System.Drawing.Size(163, 21)
        Me.txtOrderSearch.TabIndex = 166
        '
        'lblCarDetTitle
        '
        Me.lblCarDetTitle.AutoSize = True
        Me.lblCarDetTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCarDetTitle.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarDetTitle.ForeColor = System.Drawing.Color.White
        Me.lblCarDetTitle.Location = New System.Drawing.Point(32, 254)
        Me.lblCarDetTitle.Name = "lblCarDetTitle"
        Me.lblCarDetTitle.Size = New System.Drawing.Size(192, 34)
        Me.lblCarDetTitle.TabIndex = 171
        Me.lblCarDetTitle.Text = "CAR DETAILS:"
        '
        'lblCarDetails
        '
        Me.lblCarDetails.AutoSize = True
        Me.lblCarDetails.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarDetails.ForeColor = System.Drawing.Color.White
        Me.lblCarDetails.Location = New System.Drawing.Point(256, 265)
        Me.lblCarDetails.Name = "lblCarDetails"
        Me.lblCarDetails.Size = New System.Drawing.Size(77, 23)
        Me.lblCarDetails.TabIndex = 170
        Me.lblCarDetails.Text = "cardet"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.ForeColor = System.Drawing.Color.White
        Me.lblCustName.Location = New System.Drawing.Point(319, 220)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(108, 23)
        Me.lblCustName.TabIndex = 169
        Me.lblCustName.Text = "custname"
        '
        'lblCustNameTitel
        '
        Me.lblCustNameTitel.AutoSize = True
        Me.lblCustNameTitel.BackColor = System.Drawing.Color.Transparent
        Me.lblCustNameTitel.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustNameTitel.ForeColor = System.Drawing.Color.White
        Me.lblCustNameTitel.Location = New System.Drawing.Point(32, 211)
        Me.lblCustNameTitel.Name = "lblCustNameTitel"
        Me.lblCustNameTitel.Size = New System.Drawing.Size(258, 34)
        Me.lblCustNameTitel.TabIndex = 168
        Me.lblCustNameTitel.Text = "CUSTOMER NAME:"
        '
        'lblHireDetTitle
        '
        Me.lblHireDetTitle.AutoSize = True
        Me.lblHireDetTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHireDetTitle.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHireDetTitle.ForeColor = System.Drawing.Color.White
        Me.lblHireDetTitle.Location = New System.Drawing.Point(34, 299)
        Me.lblHireDetTitle.Name = "lblHireDetTitle"
        Me.lblHireDetTitle.Size = New System.Drawing.Size(188, 34)
        Me.lblHireDetTitle.TabIndex = 172
        Me.lblHireDetTitle.Text = "HIRE DETAILS:"
        '
        'lblHireDetails
        '
        Me.lblHireDetails.AutoSize = True
        Me.lblHireDetails.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHireDetails.ForeColor = System.Drawing.Color.White
        Me.lblHireDetails.Location = New System.Drawing.Point(256, 308)
        Me.lblHireDetails.Name = "lblHireDetails"
        Me.lblHireDetails.Size = New System.Drawing.Size(78, 23)
        Me.lblHireDetails.TabIndex = 173
        Me.lblHireDetails.Text = "hiredet"
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelOrder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(260, 402)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(207, 45)
        Me.btnCancelOrder.TabIndex = 174
        Me.btnCancelOrder.Text = "CANCEL ORDER"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'lblOrderNoTitle
        '
        Me.lblOrderNoTitle.AutoSize = True
        Me.lblOrderNoTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderNoTitle.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNoTitle.ForeColor = System.Drawing.Color.White
        Me.lblOrderNoTitle.Location = New System.Drawing.Point(34, 166)
        Me.lblOrderNoTitle.Name = "lblOrderNoTitle"
        Me.lblOrderNoTitle.Size = New System.Drawing.Size(235, 34)
        Me.lblOrderNoTitle.TabIndex = 175
        Me.lblOrderNoTitle.Text = "ORDER NUMBER:"
        '
        'lblOrdernum
        '
        Me.lblOrdernum.AutoSize = True
        Me.lblOrdernum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdernum.ForeColor = System.Drawing.Color.White
        Me.lblOrdernum.Location = New System.Drawing.Point(315, 177)
        Me.lblOrdernum.Name = "lblOrdernum"
        Me.lblOrdernum.Size = New System.Drawing.Size(105, 23)
        Me.lblOrdernum.TabIndex = 176
        Me.lblOrdernum.Text = "ordernum"
        '
        'frmCancelOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 483)
        Me.Controls.Add(Me.lblOrdernum)
        Me.Controls.Add(Me.lblOrderNoTitle)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.lblHireDetails)
        Me.Controls.Add(Me.lblHireDetTitle)
        Me.Controls.Add(Me.lblCarDetTitle)
        Me.Controls.Add(Me.lblCarDetails)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.lblCustNameTitel)
        Me.Controls.Add(Me.lineNewOrderSearch)
        Me.Controls.Add(Me.txtOrderSearch)
        Me.Controls.Add(Me.btnSearchOrder)
        Me.Controls.Add(Me.lblNewOrderSearch)
        Me.Controls.Add(Me.lblNewOrderTitle)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.picClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCancelOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCancelOrder"
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineNewOrderSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblNewOrderTitle As System.Windows.Forms.Label
    Friend WithEvents btnSearchOrder As System.Windows.Forms.Button
    Friend WithEvents lblNewOrderSearch As System.Windows.Forms.Label
    Friend WithEvents lineNewOrderSearch As System.Windows.Forms.PictureBox
    Friend WithEvents txtOrderSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblCarDetTitle As System.Windows.Forms.Label
    Friend WithEvents lblCarDetails As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblCustNameTitel As System.Windows.Forms.Label
    Friend WithEvents lblHireDetTitle As System.Windows.Forms.Label
    Friend WithEvents lblHireDetails As System.Windows.Forms.Label
    Friend WithEvents TTCancel As System.Windows.Forms.ToolTip
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents lblOrderNoTitle As System.Windows.Forms.Label
    Friend WithEvents lblOrdernum As System.Windows.Forms.Label
End Class
