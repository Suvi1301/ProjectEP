Imports System.Net.Mail
'IMPORTant- Imports the email
Imports Word = Microsoft.Office.Interop.Word
'IMPORTant - Adding word library as a namespace
Public Class frmReviewOrder
    Dim drag As Boolean 'To drag the form by clicking on the form
    Dim mousex As Integer 'x position of the cursor
    Dim mousey As Integer 'y position of the cursor
    Private Sub frmReviewOrder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'When clicking down on the form
        drag = True
        'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        'Sets variable mousey
    End Sub
    Private Sub frmReviewOrder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'When moving mouse
        If drag Then
            'If clicking down on the form
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            'Move form according to cursor position
        End If
    End Sub
    Private Sub frmReviewOrder_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub
    Private Sub frmReviewOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When the Review Order form loads
        btnPrint.Enabled = False
        'Disable the Print Invoice button
        btnDONE.Enabled = False
        'Disable the DONE button
        maxOrderNumber += 1
        lblCarType.Text = frmMainMenu.cmbNewOrderChooseClass.Text
        lblCarMake.Text = frmMainMenu.orderCarMake
        lblCarModel.Text = frmMainMenu.orderCarModel
        lblColour.Text = frmMainMenu.orderColour
        lblCarREG.Text = frmMainMenu.orderCarReg
        lblDateFrom.Text = frmMainMenu.dbxNewOrderHireFrom.Text
        lblDateTo.Text = frmMainMenu.dbxNewOrderHireTill.Text
        lblOrderNumber.Text = maxOrderNumber.ToString
        lblOrderDate.Text = Now.ToLongDateString
        lblCustID.Text = customerdata(frmMainMenu.NewOrderfoundCust).custID
        lblName.Text = customerdata(frmMainMenu.NewOrderfoundCust).Firstname & " " & customerdata(frmMainMenu.NewOrderfoundCust).Surname
        lblLicenseNumber.Text = customerdata(frmMainMenu.NewOrderfoundCust).licenseNo
        lblTotalNOVAT.Text = "£ " & Format(frmMainMenu.orderPriceNOVAT, "0.00")
        lblTotalINCVAT.Text = "£ " & Format(frmMainMenu.orderPriceINCVAT, "0.00")
        'Display all the order details entered in 'New Order' panel on Main Menu form to the labels
        If frmMainMenu.chkNewOrderInsurance.Checked = True Then
            'If the Insurance check box is checked
            lblInsuranceTAken.Text = "YES"
            'Display "YES" on insurance taken
        Else
            'If insurance check box is not checked
            lblInsuranceTAken.Text = "NO"
        End If
    End Sub
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        ComingFromReview = True
        'Edit button is clicked
        Me.Close()
        'Close the Review Order form
        frmMainMenu.Show()
        'Display Main Menu with New Order panel again
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Dim answer = MsgBoxYESNO("Confirm Order?")
        If answer = True Then
            'when Confirm Order button is clicked
            LoadOrderData()
            'Load all order data
            Dim Returned As String = "True"
            Dim collected As String = "False"
            If frmMainMenu.dbxNewOrderHireFrom.Text = Now.Date Then
                cardata(frmMainMenu.NewOrderfoundCar).Hired = "True"
                Returned = "False"
                collected = "True"
            End If
            'change the status of the car to hired int the car data file
            SaveCarDetails()
            'Update the car data file
            orderRecNo += 1
            'New Order record
            maxOrderNumber += 1
            orderdata(orderRecNo).orderEMPNo = employeedata(empUserNo).empID
            orderdata(orderRecNo).OrderNumber = maxOrderNumber
            orderdata(orderRecNo).CarClass = frmMainMenu.cmbNewOrderChooseClass.Text
            orderdata(orderRecNo).CarMake = frmMainMenu.orderCarMake
            orderdata(orderRecNo).CarModel = frmMainMenu.orderCarModel
            orderdata(orderRecNo).CarColour = frmMainMenu.orderColour
            orderdata(orderRecNo).CarREG = frmMainMenu.orderCarReg
            orderdata(orderRecNo).orderFROM = frmMainMenu.dbxNewOrderHireFrom.Text
            orderdata(orderRecNo).orderTO = frmMainMenu.dbxNewOrderHireTill.Text
            orderdata(orderRecNo).custID = customerdata(frmMainMenu.NewOrderfoundCust).custID
            orderdata(orderRecNo).custFname = customerdata(frmMainMenu.NewOrderfoundCust).Firstname
            orderdata(orderRecNo).custSname = customerdata(frmMainMenu.NewOrderfoundCust).Surname
            orderdata(orderRecNo).custLicense = customerdata(frmMainMenu.NewOrderfoundCust).licenseNo
            orderdata(orderRecNo).orderDATE = Now.ToLongDateString
            orderdata(orderRecNo).orderTIME = Now.ToShortTimeString
            orderdata(orderRecNo).PriceTotal = frmMainMenu.orderPriceINCVAT.ToString
            orderdata(orderRecNo).Returned = Returned
            orderdata(orderRecNo).Collected = collected
            'Store all the order details in the array
            If frmMainMenu.chkNewOrderInsurance.Checked = True Then
                'If insurance is taken
                orderdata(orderRecNo).insurance = "YES"
            Else
                'If insurance is not taken
                orderdata(orderRecNo).insurance = "NO"
                'Save NO for the insuranc e taken field
            End If
            SaveOrderDetails()
            'Save the new order to the text file
            customMsgBox("ORDER COMPLETE")
            'Display message box to say Order is complete
            btnConfirm.Enabled = False
            btnEdit.Enabled = False
            'Disable the Confirm order and Edit button
            btnPrint.Enabled = True
            btnDONE.Enabled = True
            'Enable the Print Invoice and Done button
            Dim emailsubject As String = "Order Confirmation - Order No. " & maxOrderNumber.ToString
            'The subject of the email
            Dim emailMessage As String = "Dear " & customerdata(frmMainMenu.NewOrderfoundCust).Firstname & " " & customerdata(frmMainMenu.NewOrderfoundCust).Surname & vbNewLine & "Your order has been placed successfully. The order details can be found below" & vbNewLine & "Order Number: " & maxOrderNumber.ToString & vbNewLine & "Order Date: " & Now.ToLongDateString & vbNewLine & "Hire From: " & frmMainMenu.dbxNewOrderHireFrom.Text & " to: " & frmMainMenu.dbxNewOrderHireTill.Text & vbNewLine & "Car Details: " & frmMainMenu.orderCarMake & " " & frmMainMenu.orderCarModel & " Colour: " & frmMainMenu.orderColour & " Car REG: " & frmMainMenu.orderCarReg & vbNewLine & "Thanks" & vbNewLine & "Enterprise Rent a Car"
            'The message that will be sent in the email
            Try
                'Try to send the email
                Dim Server As New SmtpClient  'The mail server
                Dim email As New MailMessage() 'New email message to be sent
                Server.UseDefaultCredentials = False
                Server.Credentials = New Net.NetworkCredential("enterprisecarrent@gmail.com", "Enterprise")
                'The email details of the company email. The sender email
                Server.Port = 587
                Server.EnableSsl = True
                Server.Host = "smtp.gmail.com"
                'Send using the gmail server
                email = New MailMessage()
                email.From = New MailAddress("enterprisecarrent@gmail.com")
                'The email address of the company. The sender email address
                email.To.Add(frmMainMenu.custemailaddress)
                'The destination email address
                email.Subject = emailsubject
                'The subject of the email
                email.IsBodyHtml = False
                email.Body = emailMessage
                'The actual message in the email
                Server.Send(email)
                'Send the email
                customMsgBox("Confirmation Email Sent")
                'Display a message box to confirm email is sent
            Catch error_t As Exception
                'If cant send email
                customMsgBox("Failed to send Email")
                'Display message box to say email failed to send
            End Try
        End If
        
    End Sub

    Private Sub btnDONE_Click(sender As System.Object, e As System.EventArgs) Handles btnDONE.Click
        'When the DONE button is clicked
        Me.Close()
        'Close the Review Order form
        frmMainMenu.Show()
        'Show the Main Menu form again
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'When Print Invoice button is clicked
        Dim oApp As Word.Application = New Word.Application()
        'Create a new word document
        oApp.Documents.Add(CurDir() & "\OrderInvoice.docx")
        'Use template from current directory
        Dim oDoc As Word.Document = oApp.ActiveDocument
        'Create a document on the open template
        oApp.Visible = True
        'Show the word file open
        oDoc.Bookmarks.Item("pdfOrderDate").Range.Text = "Order Number: " & lblOrderNumber.Text & vbNewLine & "Order Date: " & lblOrderDate.Text
        oDoc.Bookmarks.Item("pdfCustomerInfo").Range.Text = "Customer ID: " & lblCustID.Text & vbNewLine & "Name: " & lblName.Text & vbNewLine & "License No. " & lblLicenseNumber.Text
        oDoc.Bookmarks.Item("pdfOrderDetails").Range.Text = "Car Type " & lblCarType.Text & vbNewLine & "Car: " & lblCarMake.Text & " " & lblCarModel.Text & vbNewLine & "Car Registration: " & lblCarREG.Text & vbNewLine & "Colour: " & lblColour.Text & vbNewLine & "Hire From: " & lblDateFrom.Text & " to: " & lblDateTo.Text & vbNewLine & "Insurance Taken: " & lblInsuranceTAken.Text
        oDoc.Bookmarks.Item("pdfPriceDetails").Range.Text = "Total (exc. VAT): " & lblTotalNOVAT.Text & vbNewLine & "Total (inc. VAT): " & lblTotalINCVAT.Text & ContentAlignment.TopRight
        'Add the values from the system onto the bookmarks on the word template
        oDoc = oApp.ActiveDocument
        oApp.Visible = False
        oDoc.ExportAsFixedFormat(CurDir() & "\Report", Word.WdSaveFormat.wdFormatPDF)
        'Export the document to a PDF file and show on screen
        customMsgBox("Done! Please check program folder for report.")
        'Display message box
        'System.Diagnostics.Process.Start(CurDir() & "\Report.pdf")
        oApp.PrintOut()
        'Print the document invoice out
    End Sub

    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class