Public Class frmChangePassword

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        'When confirm button is clicked
        If txtNewPassword.Text <> Nothing And txtReNewPassword.Text <> Nothing And txtPreviousPassword.Text <> Nothing Then
            'If all fields are filled in
            Dim answer = MsgBoxYESNO("Are you sure you want to change password?")
            If answer = True Then
                'If YES is chosen from message box
                LoadCustomerData()
                If txtPreviousPassword.Text = employeedata(empUserNo).Password Then
                    'The previous password field matches the password of the logged in employee
                    If txtNewPassword.Text = txtReNewPassword.Text Then
                        'if the two new passwords are same
                        employeedata(empUserNo).Password = txtNewPassword.Text
                        SaveEmployeeDetails()
                        'update the password and save in file
                        Me.Close()
                        frmMainMenu.Show()
                        customMsgBox("Password Updated")
                    Else
                        'If the two new password doesnt match in retype
                        txtReNewPassword.BackColor = Color.Firebrick
                        txtReNewPassword.Text = "Password does not match"
                        txtNewPassword.ResetText()
                    End If
                Else
                    'If the previous password doesnt match
                    customMsgBox("Incorrect Previous Password")
                    txtNewPassword.ResetText()
                    txtReNewPassword.ResetText()
                    txtPreviousPassword.ResetText()
                End If
            End If
        Else
            ErrorMsgBox("Please fill in all fields")
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        'When back button is clicked
        Me.Close()
        'Close the Password Change form
        frmMainMenu.Show()
        'Show Main Menu
    End Sub

    Private Sub txtReNewPassword_GotFocus(sender As Object, e As System.EventArgs) Handles txtReNewPassword.GotFocus
        txtReNewPassword.Clear()
        txtReNewPassword.BackColor = Color.FromArgb(52, 52, 52)
    End Sub

    Private Sub frmChangePassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNewPassword.ResetText()
        txtReNewPassword.ResetText()
        txtPreviousPassword.ResetText()

    End Sub

    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class