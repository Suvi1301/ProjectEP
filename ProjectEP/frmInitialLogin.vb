Public Class frmInitialLogin

    Private Sub frmInitialLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        empMax = empMax + 1
        'create a unique ID
        lblEmployeeID.Text = empMax.ToString
    End Sub

    Private Sub btnSaveEmployeeDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveEmployeeDetails.Click
        Dim ValidateCheck As Boolean = True 'to check if everything is validated
        ttpInitialLogin.RemoveAll()
        If ValidateOnlyString(txtFirstName.Text, txtFirstName, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtSurname.Text, txtSurname, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidateEmail(txtEmail.Text, txtEmail, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidatePhoneNumber(txtPhone.Text, txtPhone, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidatePostcode(txtPostcode.Text, txtPostcode, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidatePassword(txtPassword.Text, txtPassword, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtCity.Text, txtCity, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtHouseNo.Text, txtHouseNo, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtStreet.Text, txtStreet, ttpInitialLogin) = False Then
            ValidateCheck = False
        End If
        If ValidateCheck = True Then
            'If all data entered is valid
            empRecNo += 1
            'new Record
            With employeedata(empRecNo)
                .empID = empMax
                .Firstname = txtFirstName.Text
                .Surname = txtSurname.Text
                .dob = dbxDOBAddEmployee.Text
                .email = txtEmail.Text
                .phone = txtPhone.Text
                .HouseNo = txtHouseNo.Text
                .Street = txtStreet.Text
                .City = txtCity.Text
                .postcode = txtPostcode.Text
                .Password = txtPassword.Text
                'Store the text from the text boxes/combo boxes in structure
            End With
            SaveEmployeeDetails()
            'Save the data to file
            customMsgBox("Admin account added! The system is ready to use. Click OK to login")
            'display message box 
            Me.Close()
            frmLogin.Show()
        End If

    End Sub

    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class