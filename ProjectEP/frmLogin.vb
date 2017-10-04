
Public Class frmLogin
    Dim drag As Boolean   'To drag the form by clicking on the form
    Dim mousex As Integer 'x position of the cursor
    Dim mousey As Integer 'y position of the cursor
    Sub LogginIn()
        'To check the login details entered and allow access accordingly
        LoadEmployeeData()
        'Load all employee data
        Dim EnterID As String = txtUserID.Text
        'The ID entered by the user to login
        Dim enterPword As String = txtPassword.Text
        'The password entered by the user to login
        Dim foundflag As Boolean = False
        'Flag to stop the search 
        empUserNo = 0 'To determinde the position of the record found
        If EnterID = "" Then
            'If ID field is left blank
            ErrorMsgBox("Please enter the User ID")
            'Display error message box
        Else
            'If not empty
            Do
                empUserNo += 1
                'Check the first record
                With employeedata(empUserNo)
                    If EnterID = .empID.ToString Then
                        'If the ID entered matched the ID of the record
                        If enterPword = .Password Then
                            'And the password entered matches the password of the same record
                            foundflag = True
                            'the record is found
                            Exit Do
                            'Stop the search
                        End If
                    End If
                End With
            Loop While empUserNo <= empRecNo
            'Keep checking until all records are checked
            If foundflag = True Then
                'If a record is found
                frmMainMenu.Show()
                frmProgressBar.Show() 'Show a loading screen
                'Login to the Main Menu
                Me.Hide()
                'Hide the login Menu
            Else : ErrorMsgBox("The Username or Password entered is incorrect")
                'If the details entered dont match a record then display an error message box
                txtUserID.Clear()
                txtPassword.Clear()
                'clear the text boxes for ID and Password
            End If
        End If
        txtUserID.Clear()
        txtPassword.Clear()
        'Clear ID and password text boxes
    End Sub
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'When the login button is clicked
        LogginIn()
        'check details to login n
    End Sub
    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When the system first starts, when login form loads
        Dim flag As Boolean = False
        Try
            LoadEmployeeData()
        Catch ex As Exception
            SaveCarDetails()
            SaveCarStockDetails()
            SaveCustomerDetails()
            SaveEmployeeDetails()
            SaveOrderDetails()
            SavePricesDetails()
            flag = True
            Me.Hide()
            frmInitialLogin.Show()
        End Try
        LoadEmployeeData()
        If empRecNo <= 0 Then
            Me.Hide()
            frmInitialLogin.Show()

        Else
            LoadCustomerData()
            LoadCarData()
            LoadStockData()
            LoadOrderData()
            'Load all data from all files
            For CheckMaxEmp As Integer = 1 To empRecNo
                'Go through all records
                If empMax < employeedata(CheckMaxEmp).empID Then
                    empMax = employeedata(CheckMaxEmp).empID
                    'Find the maximum value of employee ID to generate unique ID later
                Else : Exit For
                End If
            Next

            For CheckMaxCust As Integer = 1 To custRecNo
                'Go through all the customer records
                If custMax < customerdata(CheckMaxCust).custID Then
                    custMax = customerdata(CheckMaxCust).custID
                    'Find the maximum value of customer ID to generate unique ID later
                Else : Exit For
                End If
            Next

            For checkMaxOrder As Integer = 1 To orderRecNo
                'Go through all the order records
                If maxOrderNumber < orderdata(checkMaxOrder).OrderNumber Then
                    maxOrderNumber = orderdata(checkMaxOrder).OrderNumber
                    'Find the maximum value of Order Number to generate unique order number later
                Else : Exit For
                End If
            Next
        End If

    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        'When Enter key is pressed on the password text box click the login button
        If e.KeyCode = Keys.Return Then
            LogginIn()
        End If
    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'When clicking down on the form
        drag = True
        'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        'Sets variable mousey
    End Sub
    Private Sub frmLogin_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'When moving mouse
        If drag Then
            'If clicking down on the form
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            'Move form according to cursor position
        End If
    End Sub
    Private Sub frmLogin_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub picClose_Click(sender As System.Object, e As System.EventArgs) Handles picClose.Click
        'If the 'X' close button is clicked
        Me.Close()
        'Close the system
    End Sub

    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class