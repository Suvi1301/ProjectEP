<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitialLogin
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSaveEmployeeDetails = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lineAddEmpPasssword = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpPostcode = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpCity = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpStreet = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpEmail = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpHouseNo = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpContact = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpSname = New System.Windows.Forms.PictureBox()
        Me.lineAddEmpFname = New System.Windows.Forms.PictureBox()
        Me.lblAddEmpPassword = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.lblAddEmpID = New System.Windows.Forms.Label()
        Me.dbxDOBAddEmployee = New System.Windows.Forms.DateTimePicker()
        Me.lblAddEmpPostcode = New System.Windows.Forms.Label()
        Me.lblAddEmpCity = New System.Windows.Forms.Label()
        Me.lblAddEmpStreet = New System.Windows.Forms.Label()
        Me.lblAddEmpHouseNo = New System.Windows.Forms.Label()
        Me.lblAddEmpEmail = New System.Windows.Forms.Label()
        Me.lblAddEmpContact = New System.Windows.Forms.Label()
        Me.lblAddEmpDOB = New System.Windows.Forms.Label()
        Me.lblAddEmpSname = New System.Windows.Forms.Label()
        Me.lblAddEmpFname = New System.Windows.Forms.Label()
        Me.ttpInitialLogin = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        CType(Me.lineAddEmpPasssword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpPostcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpStreet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpHouseNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpSname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineAddEmpFname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(127, 20)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(429, 40)
        Me.lblTitle.TabIndex = 141
        Me.lblTitle.Text = "CREATE ADMIN ACCOUNT"
        '
        'btnSaveEmployeeDetails
        '
        Me.btnSaveEmployeeDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnSaveEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEmployeeDetails.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEmployeeDetails.Location = New System.Drawing.Point(507, 512)
        Me.btnSaveEmployeeDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveEmployeeDetails.Name = "btnSaveEmployeeDetails"
        Me.btnSaveEmployeeDetails.Size = New System.Drawing.Size(131, 73)
        Me.btnSaveEmployeeDetails.TabIndex = 103
        Me.btnSaveEmployeeDetails.Text = "CREATE ACCOUNT"
        Me.btnSaveEmployeeDetails.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(217, 553)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(188, 21)
        Me.txtPassword.TabIndex = 164
        '
        'txtPostcode
        '
        Me.txtPostcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPostcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPostcode.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostcode.ForeColor = System.Drawing.Color.White
        Me.txtPostcode.Location = New System.Drawing.Point(217, 512)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(187, 21)
        Me.txtPostcode.TabIndex = 159
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCity.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.White
        Me.txtCity.Location = New System.Drawing.Point(217, 462)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(421, 21)
        Me.txtCity.TabIndex = 158
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStreet.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.ForeColor = System.Drawing.Color.White
        Me.txtStreet.Location = New System.Drawing.Point(217, 418)
        Me.txtStreet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(421, 21)
        Me.txtStreet.TabIndex = 157
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHouseNo.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.ForeColor = System.Drawing.Color.White
        Me.txtHouseNo.Location = New System.Drawing.Point(217, 373)
        Me.txtHouseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(421, 21)
        Me.txtHouseNo.TabIndex = 156
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(217, 329)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(421, 21)
        Me.txtEmail.TabIndex = 155
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.White
        Me.txtPhone.Location = New System.Drawing.Point(217, 283)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(421, 21)
        Me.txtPhone.TabIndex = 154
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.ForeColor = System.Drawing.Color.White
        Me.txtSurname.Location = New System.Drawing.Point(217, 187)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(421, 21)
        Me.txtSurname.TabIndex = 153
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.Location = New System.Drawing.Point(217, 141)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(421, 21)
        Me.txtFirstName.TabIndex = 152
        '
        'lineAddEmpPasssword
        '
        Me.lineAddEmpPasssword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpPasssword.Location = New System.Drawing.Point(217, 576)
        Me.lineAddEmpPasssword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpPasssword.Name = "lineAddEmpPasssword"
        Me.lineAddEmpPasssword.Size = New System.Drawing.Size(187, 2)
        Me.lineAddEmpPasssword.TabIndex = 173
        Me.lineAddEmpPasssword.TabStop = False
        '
        'lineAddEmpPostcode
        '
        Me.lineAddEmpPostcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpPostcode.Location = New System.Drawing.Point(217, 533)
        Me.lineAddEmpPostcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpPostcode.Name = "lineAddEmpPostcode"
        Me.lineAddEmpPostcode.Size = New System.Drawing.Size(187, 2)
        Me.lineAddEmpPostcode.TabIndex = 172
        Me.lineAddEmpPostcode.TabStop = False
        '
        'lineAddEmpCity
        '
        Me.lineAddEmpCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpCity.Location = New System.Drawing.Point(217, 485)
        Me.lineAddEmpCity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpCity.Name = "lineAddEmpCity"
        Me.lineAddEmpCity.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpCity.TabIndex = 171
        Me.lineAddEmpCity.TabStop = False
        '
        'lineAddEmpStreet
        '
        Me.lineAddEmpStreet.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpStreet.Location = New System.Drawing.Point(217, 440)
        Me.lineAddEmpStreet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpStreet.Name = "lineAddEmpStreet"
        Me.lineAddEmpStreet.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpStreet.TabIndex = 170
        Me.lineAddEmpStreet.TabStop = False
        '
        'lineAddEmpEmail
        '
        Me.lineAddEmpEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpEmail.Location = New System.Drawing.Point(217, 352)
        Me.lineAddEmpEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpEmail.Name = "lineAddEmpEmail"
        Me.lineAddEmpEmail.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpEmail.TabIndex = 169
        Me.lineAddEmpEmail.TabStop = False
        '
        'lineAddEmpHouseNo
        '
        Me.lineAddEmpHouseNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpHouseNo.Location = New System.Drawing.Point(217, 393)
        Me.lineAddEmpHouseNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpHouseNo.Name = "lineAddEmpHouseNo"
        Me.lineAddEmpHouseNo.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpHouseNo.TabIndex = 168
        Me.lineAddEmpHouseNo.TabStop = False
        '
        'lineAddEmpContact
        '
        Me.lineAddEmpContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpContact.Location = New System.Drawing.Point(217, 305)
        Me.lineAddEmpContact.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpContact.Name = "lineAddEmpContact"
        Me.lineAddEmpContact.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpContact.TabIndex = 167
        Me.lineAddEmpContact.TabStop = False
        '
        'lineAddEmpSname
        '
        Me.lineAddEmpSname.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpSname.Location = New System.Drawing.Point(217, 209)
        Me.lineAddEmpSname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpSname.Name = "lineAddEmpSname"
        Me.lineAddEmpSname.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpSname.TabIndex = 166
        Me.lineAddEmpSname.TabStop = False
        '
        'lineAddEmpFname
        '
        Me.lineAddEmpFname.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lineAddEmpFname.Location = New System.Drawing.Point(217, 165)
        Me.lineAddEmpFname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lineAddEmpFname.Name = "lineAddEmpFname"
        Me.lineAddEmpFname.Size = New System.Drawing.Size(421, 2)
        Me.lineAddEmpFname.TabIndex = 165
        Me.lineAddEmpFname.TabStop = False
        '
        'lblAddEmpPassword
        '
        Me.lblAddEmpPassword.AutoSize = True
        Me.lblAddEmpPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpPassword.Enabled = False
        Me.lblAddEmpPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpPassword.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpPassword.Location = New System.Drawing.Point(50, 555)
        Me.lblAddEmpPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpPassword.Name = "lblAddEmpPassword"
        Me.lblAddEmpPassword.Size = New System.Drawing.Size(123, 23)
        Me.lblAddEmpPassword.TabIndex = 163
        Me.lblAddEmpPassword.Text = "PASSWORD:"
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeID.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeID.Location = New System.Drawing.Point(212, 94)
        Me.lblEmployeeID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(36, 28)
        Me.lblEmployeeID.TabIndex = 162
        Me.lblEmployeeID.Text = "ID"
        '
        'lblAddEmpID
        '
        Me.lblAddEmpID.AutoSize = True
        Me.lblAddEmpID.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpID.Enabled = False
        Me.lblAddEmpID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAddEmpID.Location = New System.Drawing.Point(50, 94)
        Me.lblAddEmpID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpID.Name = "lblAddEmpID"
        Me.lblAddEmpID.Size = New System.Drawing.Size(108, 23)
        Me.lblAddEmpID.TabIndex = 161
        Me.lblAddEmpID.Text = "ADMIN ID:"
        '
        'dbxDOBAddEmployee
        '
        Me.dbxDOBAddEmployee.CalendarForeColor = System.Drawing.Color.Black
        Me.dbxDOBAddEmployee.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dbxDOBAddEmployee.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dbxDOBAddEmployee.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dbxDOBAddEmployee.CalendarTrailingForeColor = System.Drawing.Color.Red
        Me.dbxDOBAddEmployee.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbxDOBAddEmployee.Location = New System.Drawing.Point(217, 233)
        Me.dbxDOBAddEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.dbxDOBAddEmployee.Name = "dbxDOBAddEmployee"
        Me.dbxDOBAddEmployee.Size = New System.Drawing.Size(223, 28)
        Me.dbxDOBAddEmployee.TabIndex = 160
        '
        'lblAddEmpPostcode
        '
        Me.lblAddEmpPostcode.AutoSize = True
        Me.lblAddEmpPostcode.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpPostcode.Enabled = False
        Me.lblAddEmpPostcode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpPostcode.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpPostcode.Location = New System.Drawing.Point(49, 512)
        Me.lblAddEmpPostcode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpPostcode.Name = "lblAddEmpPostcode"
        Me.lblAddEmpPostcode.Size = New System.Drawing.Size(116, 23)
        Me.lblAddEmpPostcode.TabIndex = 151
        Me.lblAddEmpPostcode.Text = "POSTCODE"
        '
        'lblAddEmpCity
        '
        Me.lblAddEmpCity.AutoSize = True
        Me.lblAddEmpCity.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpCity.Enabled = False
        Me.lblAddEmpCity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpCity.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpCity.Location = New System.Drawing.Point(50, 464)
        Me.lblAddEmpCity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpCity.Name = "lblAddEmpCity"
        Me.lblAddEmpCity.Size = New System.Drawing.Size(118, 23)
        Me.lblAddEmpCity.TabIndex = 150
        Me.lblAddEmpCity.Text = "CITY/TOWN"
        '
        'lblAddEmpStreet
        '
        Me.lblAddEmpStreet.AutoSize = True
        Me.lblAddEmpStreet.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpStreet.Enabled = False
        Me.lblAddEmpStreet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpStreet.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpStreet.Location = New System.Drawing.Point(49, 419)
        Me.lblAddEmpStreet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpStreet.Name = "lblAddEmpStreet"
        Me.lblAddEmpStreet.Size = New System.Drawing.Size(139, 23)
        Me.lblAddEmpStreet.TabIndex = 149
        Me.lblAddEmpStreet.Text = "STREET NAME:"
        '
        'lblAddEmpHouseNo
        '
        Me.lblAddEmpHouseNo.AutoSize = True
        Me.lblAddEmpHouseNo.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpHouseNo.Enabled = False
        Me.lblAddEmpHouseNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpHouseNo.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpHouseNo.Location = New System.Drawing.Point(49, 373)
        Me.lblAddEmpHouseNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpHouseNo.Name = "lblAddEmpHouseNo"
        Me.lblAddEmpHouseNo.Size = New System.Drawing.Size(118, 23)
        Me.lblAddEmpHouseNo.TabIndex = 148
        Me.lblAddEmpHouseNo.Text = "HOUSE NO."
        '
        'lblAddEmpEmail
        '
        Me.lblAddEmpEmail.AutoSize = True
        Me.lblAddEmpEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpEmail.Enabled = False
        Me.lblAddEmpEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpEmail.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpEmail.Location = New System.Drawing.Point(49, 329)
        Me.lblAddEmpEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpEmail.Name = "lblAddEmpEmail"
        Me.lblAddEmpEmail.Size = New System.Drawing.Size(72, 23)
        Me.lblAddEmpEmail.TabIndex = 147
        Me.lblAddEmpEmail.Text = "EMAIL:"
        '
        'lblAddEmpContact
        '
        Me.lblAddEmpContact.AutoSize = True
        Me.lblAddEmpContact.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpContact.Enabled = False
        Me.lblAddEmpContact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpContact.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpContact.Location = New System.Drawing.Point(49, 284)
        Me.lblAddEmpContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpContact.Name = "lblAddEmpContact"
        Me.lblAddEmpContact.Size = New System.Drawing.Size(148, 23)
        Me.lblAddEmpContact.TabIndex = 146
        Me.lblAddEmpContact.Text = "CONTACT NO."
        '
        'lblAddEmpDOB
        '
        Me.lblAddEmpDOB.AutoSize = True
        Me.lblAddEmpDOB.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpDOB.Enabled = False
        Me.lblAddEmpDOB.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpDOB.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpDOB.Location = New System.Drawing.Point(49, 238)
        Me.lblAddEmpDOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpDOB.Name = "lblAddEmpDOB"
        Me.lblAddEmpDOB.Size = New System.Drawing.Size(68, 23)
        Me.lblAddEmpDOB.TabIndex = 145
        Me.lblAddEmpDOB.Text = "D.O.B:"
        '
        'lblAddEmpSname
        '
        Me.lblAddEmpSname.AutoSize = True
        Me.lblAddEmpSname.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpSname.Enabled = False
        Me.lblAddEmpSname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpSname.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpSname.Location = New System.Drawing.Point(49, 188)
        Me.lblAddEmpSname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpSname.Name = "lblAddEmpSname"
        Me.lblAddEmpSname.Size = New System.Drawing.Size(108, 23)
        Me.lblAddEmpSname.TabIndex = 144
        Me.lblAddEmpSname.Text = "SURNAME:"
        '
        'lblAddEmpFname
        '
        Me.lblAddEmpFname.AutoSize = True
        Me.lblAddEmpFname.BackColor = System.Drawing.Color.Transparent
        Me.lblAddEmpFname.Enabled = False
        Me.lblAddEmpFname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEmpFname.ForeColor = System.Drawing.Color.White
        Me.lblAddEmpFname.Location = New System.Drawing.Point(49, 142)
        Me.lblAddEmpFname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddEmpFname.Name = "lblAddEmpFname"
        Me.lblAddEmpFname.Size = New System.Drawing.Size(124, 23)
        Me.lblAddEmpFname.TabIndex = 143
        Me.lblAddEmpFname.Text = "FIRST NAME:"
        '
        'ttpInitialLogin
        '
        Me.ttpInitialLogin.AutoPopDelay = 50000
        Me.ttpInitialLogin.InitialDelay = 0
        Me.ttpInitialLogin.ReshowDelay = 100
        Me.ttpInitialLogin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'picMinimise
        '
        Me.picMinimise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimise.Image = Global.ProjectEP.My.Resources.Resources.minus75
        Me.picMinimise.Location = New System.Drawing.Point(633, 12)
        Me.picMinimise.Name = "picMinimise"
        Me.picMinimise.Size = New System.Drawing.Size(30, 30)
        Me.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimise.TabIndex = 174
        Me.picMinimise.TabStop = False
        '
        'frmInitialLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(675, 625)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.btnSaveEmployeeDetails)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtHouseNo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lineAddEmpPasssword)
        Me.Controls.Add(Me.lineAddEmpPostcode)
        Me.Controls.Add(Me.lineAddEmpCity)
        Me.Controls.Add(Me.lineAddEmpStreet)
        Me.Controls.Add(Me.lineAddEmpEmail)
        Me.Controls.Add(Me.lineAddEmpHouseNo)
        Me.Controls.Add(Me.lineAddEmpContact)
        Me.Controls.Add(Me.lineAddEmpSname)
        Me.Controls.Add(Me.lineAddEmpFname)
        Me.Controls.Add(Me.lblAddEmpPassword)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.lblAddEmpID)
        Me.Controls.Add(Me.dbxDOBAddEmployee)
        Me.Controls.Add(Me.lblAddEmpPostcode)
        Me.Controls.Add(Me.lblAddEmpCity)
        Me.Controls.Add(Me.lblAddEmpStreet)
        Me.Controls.Add(Me.lblAddEmpHouseNo)
        Me.Controls.Add(Me.lblAddEmpEmail)
        Me.Controls.Add(Me.lblAddEmpContact)
        Me.Controls.Add(Me.lblAddEmpDOB)
        Me.Controls.Add(Me.lblAddEmpSname)
        Me.Controls.Add(Me.lblAddEmpFname)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInitialLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make admin account"
        CType(Me.lineAddEmpPasssword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpPostcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpStreet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpHouseNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpSname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineAddEmpFname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnSaveEmployeeDetails As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lineAddEmpPasssword As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpPostcode As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpCity As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpStreet As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpEmail As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpHouseNo As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpContact As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpSname As System.Windows.Forms.PictureBox
    Friend WithEvents lineAddEmpFname As System.Windows.Forms.PictureBox
    Friend WithEvents lblAddEmpPassword As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpID As System.Windows.Forms.Label
    Friend WithEvents dbxDOBAddEmployee As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAddEmpPostcode As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpCity As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpStreet As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpHouseNo As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpEmail As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpContact As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpDOB As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpSname As System.Windows.Forms.Label
    Friend WithEvents lblAddEmpFname As System.Windows.Forms.Label
    Friend WithEvents ttpInitialLogin As System.Windows.Forms.ToolTip
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
End Class
