<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodaysOrders
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
        Me.lstTodaysOrder = New System.Windows.Forms.ListView()
        Me.lblTodaysOrdersTitle = New System.Windows.Forms.Label()
        Me.btnConfirmCarCollect = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTodaysOrder
        '
        Me.lstTodaysOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lstTodaysOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTodaysOrder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTodaysOrder.ForeColor = System.Drawing.Color.White
        Me.lstTodaysOrder.FullRowSelect = True
        Me.lstTodaysOrder.Location = New System.Drawing.Point(-2, 68)
        Me.lstTodaysOrder.Name = "lstTodaysOrder"
        Me.lstTodaysOrder.Size = New System.Drawing.Size(1096, 459)
        Me.lstTodaysOrder.TabIndex = 72
        Me.lstTodaysOrder.UseCompatibleStateImageBehavior = False
        Me.lstTodaysOrder.View = System.Windows.Forms.View.Details
        '
        'lblTodaysOrdersTitle
        '
        Me.lblTodaysOrdersTitle.AutoSize = True
        Me.lblTodaysOrdersTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaysOrdersTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaysOrdersTitle.ForeColor = System.Drawing.Color.White
        Me.lblTodaysOrdersTitle.Location = New System.Drawing.Point(400, 9)
        Me.lblTodaysOrdersTitle.Name = "lblTodaysOrdersTitle"
        Me.lblTodaysOrdersTitle.Size = New System.Drawing.Size(345, 47)
        Me.lblTodaysOrdersTitle.TabIndex = 73
        Me.lblTodaysOrdersTitle.Text = "TODAY'S ORDERS"
        '
        'btnConfirmCarCollect
        '
        Me.btnConfirmCarCollect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnConfirmCarCollect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmCarCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmCarCollect.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmCarCollect.Location = New System.Drawing.Point(408, 540)
        Me.btnConfirmCarCollect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirmCarCollect.Name = "btnConfirmCarCollect"
        Me.btnConfirmCarCollect.Size = New System.Drawing.Size(311, 53)
        Me.btnConfirmCarCollect.TabIndex = 74
        Me.btnConfirmCarCollect.Text = "CONFIRM COLLECTED"
        Me.btnConfirmCarCollect.UseVisualStyleBackColor = False
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
        Me.btnBack.TabIndex = 75
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
        Me.picClose.TabIndex = 141
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
        'frmTodaysOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 606)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnConfirmCarCollect)
        Me.Controls.Add(Me.lblTodaysOrdersTitle)
        Me.Controls.Add(Me.lstTodaysOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTodaysOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TodaysOrders"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTodaysOrder As System.Windows.Forms.ListView
    Friend WithEvents lblTodaysOrdersTitle As System.Windows.Forms.Label
    Friend WithEvents btnConfirmCarCollect As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
End Class
