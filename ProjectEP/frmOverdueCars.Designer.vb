<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverdueCars
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
        Me.lblOverdueOrdersTitle = New System.Windows.Forms.Label()
        Me.lstOverdueOrders = New System.Windows.Forms.ListView()
        Me.btnConfirmReturn = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        Me.btnSendEmailAll = New System.Windows.Forms.Button()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOverdueOrdersTitle
        '
        Me.lblOverdueOrdersTitle.AutoSize = True
        Me.lblOverdueOrdersTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblOverdueOrdersTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdueOrdersTitle.ForeColor = System.Drawing.Color.White
        Me.lblOverdueOrdersTitle.Location = New System.Drawing.Point(363, 9)
        Me.lblOverdueOrdersTitle.Name = "lblOverdueOrdersTitle"
        Me.lblOverdueOrdersTitle.Size = New System.Drawing.Size(362, 47)
        Me.lblOverdueOrdersTitle.TabIndex = 74
        Me.lblOverdueOrdersTitle.Text = "OVERDUE ORDERS"
        '
        'lstOverdueOrders
        '
        Me.lstOverdueOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lstOverdueOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstOverdueOrders.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOverdueOrders.ForeColor = System.Drawing.Color.White
        Me.lstOverdueOrders.FullRowSelect = True
        Me.lstOverdueOrders.Location = New System.Drawing.Point(0, 72)
        Me.lstOverdueOrders.Name = "lstOverdueOrders"
        Me.lstOverdueOrders.Size = New System.Drawing.Size(1096, 459)
        Me.lstOverdueOrders.TabIndex = 75
        Me.lstOverdueOrders.UseCompatibleStateImageBehavior = False
        Me.lstOverdueOrders.View = System.Windows.Forms.View.Details
        '
        'btnConfirmReturn
        '
        Me.btnConfirmReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnConfirmReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmReturn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmReturn.Location = New System.Drawing.Point(371, 540)
        Me.btnConfirmReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmReturn.Name = "btnConfirmReturn"
        Me.btnConfirmReturn.Size = New System.Drawing.Size(311, 53)
        Me.btnConfirmReturn.TabIndex = 76
        Me.btnConfirmReturn.Text = "CONFIRM RETURNED"
        Me.btnConfirmReturn.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(13, 540)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 53)
        Me.btnBack.TabIndex = 77
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'picClose
        '
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.ProjectEP.My.Resources.Resources.close32
        Me.picClose.Location = New System.Drawing.Point(1050, 5)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(40, 40)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 142
        Me.picClose.TabStop = False
        '
        'picMinimise
        '
        Me.picMinimise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimise.Image = Global.ProjectEP.My.Resources.Resources.minus75
        Me.picMinimise.Location = New System.Drawing.Point(1004, 5)
        Me.picMinimise.Name = "picMinimise"
        Me.picMinimise.Size = New System.Drawing.Size(40, 40)
        Me.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimise.TabIndex = 160
        Me.picMinimise.TabStop = False
        '
        'btnSendEmailAll
        '
        Me.btnSendEmailAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnSendEmailAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendEmailAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendEmailAll.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendEmailAll.Location = New System.Drawing.Point(744, 540)
        Me.btnSendEmailAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSendEmailAll.Name = "btnSendEmailAll"
        Me.btnSendEmailAll.Size = New System.Drawing.Size(243, 53)
        Me.btnSendEmailAll.TabIndex = 161
        Me.btnSendEmailAll.Text = "SEND EMAIL NOTICE"
        Me.btnSendEmailAll.UseVisualStyleBackColor = False
        '
        'frmOverdueCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 606)
        Me.Controls.Add(Me.btnSendEmailAll)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirmReturn)
        Me.Controls.Add(Me.lstOverdueOrders)
        Me.Controls.Add(Me.lblOverdueOrdersTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOverdueCars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOverdueCars"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOverdueOrdersTitle As System.Windows.Forms.Label
    Friend WithEvents lstOverdueOrders As System.Windows.Forms.ListView
    Friend WithEvents btnConfirmReturn As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
    Friend WithEvents btnSendEmailAll As System.Windows.Forms.Button
End Class
