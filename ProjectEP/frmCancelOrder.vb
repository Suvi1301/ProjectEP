Public Class frmCancelOrder

    Private Sub picClose_Click(sender As System.Object, e As System.EventArgs) Handles picClose.Click
        'When the X button is clicked
        Me.Close()
        'Close the Cancel order form
        frmMainMenu.Show()
        'Show the main menu form
    End Sub
    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        'When the '-' is clicked 
        Me.WindowState = FormWindowState.Minimized
        'Minimise the form
    End Sub

    Private Sub btnSearchOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOrder.Click
        'When the Search button is clicked
        Dim answer = ValidateID(txtOrderSearch.Text, txtOrderSearch, TTCancel) 'Validate the search field
        Dim foundflag As Integer = 0 'flag to check if record is found
        If answer = True Then
            'If the order number is valid
            For x As Integer = 1 To orderRecNo
                'Go through the order records
                If orderdata(x).OrderNumber = txtOrderSearch.Text AndAlso orderdata(x).Collected = "True" Then
                    'If the searched order number is found
                    foundflag = x
                    'store it's record number
                    Exit For
                    'exit loop
                End If
            Next
            If foundflag > 0 Then
                'If a record was found
                lblCarDetails.Visible = True
                lblCustName.Visible = True
                lblHireDetails.Visible = True
                lblOrderNoTitle.Visible = True
                lblOrdernum.Visible = True
                lblHireDetTitle.Visible = True
                lblCarDetTitle.Visible = True
                lblCustNameTitel.Visible = True
                'Show all the labels
                With orderdata(foundflag)
                    lblOrdernum.Text = .OrderNumber
                    lblCarDetails.Text = .CarMake & " " & .CarModel & " " & .CarColour & " " & .CarREG
                    lblCustName.Text = .custFname & " " & .custSname & " (ID: " & .custID & ")"
                    lblHireDetails.Text = "From: " & .orderFROM & " TO: " & .orderTO
                    'Populate labels with the order details
                End With
            Else
                'If record wasnt found
                ErrorMsgBox("No Order found. Either Order number is incorrect or Order is collected already")
            End If
        End If

    End Sub
    Private Sub btnCancelOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelOrder.Click
        'When the Cancel order button is clicked
        Dim answer = MsgBoxYESNO("Are you sure you want to cancel the Order?")
        'Ask confirmation to cancel
        If answer = True Then
            'If YES
            Dim carREG As String = ""
            For y As Integer = 1 To orderRecNo
                'Go through all the order records
                If orderdata(y).OrderNumber = lblOrdernum.Text Then
                    'If a record with the searched order number is found
                    With orderdata(y)
                        carREG = .CarREG
                        .OrderNumber = Nothing
                        .CarClass = Nothing
                        .CarMake = Nothing
                        .CarModel = Nothing
                        .CarColour = Nothing
                        .CarREG = Nothing
                        .orderFROM = Nothing
                        .orderTO = Nothing
                        .custID = Nothing
                        .custFname = Nothing
                        .custSname = Nothing
                        .custLicense = Nothing
                        .orderDATE = Nothing
                        .PriceTotal = Nothing
                        .insurance = Nothing
                        .Returned = Nothing
                        .orderEMPNo = Nothing
                        .orderTIME = Nothing
                        .Collected = Nothing
                        'Empty the record fields
                    End With
                    Exit For
                    'exit loop
                End If
            Next
            For x As Integer = 1 To carRecNo
                'Go through all the car records
                If cardata(x).CarReg = carREG Then
                    'If a car record with the REG from the cancelled order is found
                    cardata(x).Hired = "False"
                    'Change Hired status to False
                    Exit For
                    'End loop
                End If
            Next
            SaveOrderDetails()
            SaveCarDetails()
            CreateStockFile()
            'Update files
            lblCarDetails.Visible = False
            lblCustName.Visible = False
            lblHireDetails.Visible = False
            lblOrderNoTitle.Visible = False
            lblOrdernum.Visible = False
            lblHireDetTitle.Visible = False
            lblCarDetTitle.Visible = False
            lblCustNameTitel.Visible = False
            'Hide all labels
        End If

    End Sub
    Private Sub frmCancelOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When form loads
        lblCarDetails.Visible = False
        lblCustName.Visible = False
        lblHireDetails.Visible = False
        lblOrderNoTitle.Visible = False
        lblOrdernum.Visible = False
        lblHireDetTitle.Visible = False
        lblCarDetTitle.Visible = False
        lblCustNameTitel.Visible = False
        'Hide information labels
    End Sub
    Private Sub txtOrderSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOrderSearch.TextChanged
        'When text in search box is changed
        lblCarDetails.Visible = False
        lblCustName.Visible = False
        lblHireDetails.Visible = False
        lblOrderNoTitle.Visible = False
        lblOrdernum.Visible = False
        lblHireDetTitle.Visible = False
        lblCarDetTitle.Visible = False
        lblCustNameTitel.Visible = False
        'Hide all the information labels
    End Sub
End Class