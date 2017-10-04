Imports System.Net.Mail
'IMPORTant- Imports the email 
Public Class frmOverdueCars
    Dim drag As Boolean  'To drag the form by clicking on the form
    Dim mousex As Integer 'x position of the cursor
    Dim mousey As Integer 'y position of the cursor
    Dim extraprice As Double = 0 'the extra price that the customer pays for overdue
    Private Sub frmOverdueCars_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'When left click on form 
        drag = True
        'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        'Sets variable mousey
    End Sub
    Private Sub frmOverdueCars_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'When moving the mouse
        If drag = True Then
            'If clicking down on the form
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            'move the form accordingly
        End If
    End Sub
    Private Sub frmOverdueCars_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
        'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub frmOverdueCars_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When form loads
        LoadPriceData()
        LoadCustomerData()
        LoadOrderData()
        lstOverdueOrders.Items.Clear()
        lstOverdueOrders.Columns.Clear()
        'clear the listview items and columns
        lstOverdueOrders.Columns.Add("Order No.", 60, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Customer ID", 80, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Customer Name", 125, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Contact No.", 80, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Car Details", 200, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Return Date", 120, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Days Overdue", 80, HorizontalAlignment.Left)
        lstOverdueOrders.Columns.Add("Extra Cost", 80, HorizontalAlignment.Left)
        'Add the column headers to the listview
        extraprice = 0
        For b As Integer = 1 To priceRecNo
            'go through all the price records
            If pricesdata(b).type = "Fine" Then
                'find the fine price
                extraprice = pricesdata(b).price
                Exit For
            End If
        Next
        Dim columnItem(7) As String
        Dim fullrow As ListViewItem
        Dim custemail As String = ""
        Dim custname As String = ""
        For i As Integer = 1 To orderRecNo
            'Go through the order records
            If orderdata(i).Returned = False AndAlso orderdata(i).orderTO < Now.Date Then
                'If the order has not been returned AND is past the return date
                With orderdata(i)
                    Dim phone As String = "" 'temporary phone number
                    custemail = ""
                    custname = ""
                    For a As Integer = 1 To custRecNo
                        'go through all customer records
                        If customerdata(a).custID = orderdata(i).custID Then
                            'If the customer is found
                            phone = customerdata(a).phone
                            custemail = customerdata(a).email
                            custname = customerdata(a).Firstname & "  " & customerdata(a).Surname
                            'Store their phone, email and name
                            Exit For
                        End If
                    Next
                    Dim d1 As Date = Convert.ToDateTime(.orderTO) 'The actual return date
                    Dim d2 As Date = Convert.ToDateTime(Now) 'Todays date
                    Dim duration As TimeSpan = d2.Subtract(d1) 'Find no of days overdue
                    extraprice = extraprice * Convert.ToInt32(duration.Days) 'Calculate fine price
                    columnItem(0) = .OrderNumber
                    columnItem(1) = .custID
                    columnItem(2) = .custFname & " " & .custSname
                    columnItem(3) = phone
                    columnItem(4) = .CarMake & " " & .CarModel & " " & .CarColour & " REG: " & .CarREG
                    columnItem(5) = .orderTO
                    columnItem(6) = duration.Days
                    columnItem(7) = Format(extraprice, "£0.00")
                    fullrow = New ListViewItem(columnItem)
                    'Fill in the listview
                    lstOverdueOrders.Items.Add(fullrow)
                End With
            End If
        Next
    End Sub
    Private Sub btnConfirmCarReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmReturn.Click
        'When confirm return car is clicked
        Dim answer = MsgBoxYESNO("Make sure extra payment is taken. Confirm Return?")
        If answer = True Then
            'If YES chosen on message box
            For Each row As ListViewItem In lstOverdueOrders.SelectedItems
                'Go through each column in the selected listview item
                Dim cardetails As String = lstOverdueOrders.Items(lstOverdueOrders.FocusedItem.Index).SubItems(4).Text 'The car details column
                Dim words As String() = cardetails.Split(New Char() {" "}) 'Split each character in the text
                Dim word As String 'To find the REG
                Dim count As Integer = 0 'to count the word length
                Dim fulllinecount As Integer = 0
                For Each word In words
                    'look through each word in the car details.
                    count = word.Length + count + 1
                    'count up the number of characters
                    If word = "REG:" Then
                        'if the REG is found
                        Exit For
                        'stop loop
                    End If
                Next
                Dim REG As String = cardetails.Substring(count, cardetails.Length - count) 'The REG number of the chosen order
                Dim ordernumber As Integer = lstOverdueOrders.Items(lstOverdueOrders.FocusedItem.Index).SubItems(0).Text 'The order number of chosen order
                For a As Integer = 1 To orderRecNo
                    'Go through all order records
                    If orderdata(a).OrderNumber = ordernumber Then
                        'If the order number is found
                        orderdata(a).PriceTotal += extraprice
                        'Add the fine price to its total
                        orderdata(a).Returned = "True"
                        'Change Returned status to True
                        SaveOrderDetails()
                    End If
                Next
                For b As Integer = 1 To carRecNo
                    'Go through all the car records
                    If cardata(b).CarReg = REG Then
                        'If Car REG is found
                        cardata(b).Hired = "False"
                        'Change Hired status to False
                        SaveCarDetails()
                        CreateStockFile()
                        Exit For
                        'Stop loop
                    End If
                Next
                lstOverdueOrders.Items.Remove(row)
                'Remove the record from the listview
            Next
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub picClose_Click(sender As System.Object, e As System.EventArgs) Handles picClose.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSendEmailAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSendEmailAll.Click
        'When Send Email button is clicked
        LoadOrderData()
        Dim custemail As String = "" 'customer's email
        Dim custname As String = "" 'customer's name
        Dim emailsuccess As Integer = 0 'to check if all emails were sent successfully
        For x As Integer = 1 To orderRecNo
            'go through all the order records
            If orderdata(x).Returned = False AndAlso orderdata(x).orderTO < Now.Date Then
                'if Order is not returned and the Return date is past today's date
                For a As Integer = 1 To custRecNo
                    'Go through the customer records
                    If customerdata(a).custID = orderdata(x).custID Then
                        'If the customer is found
                        custname = customerdata(a).Firstname & "  " & customerdata(a).Surname 'Take the customer's name
                        custemail = customerdata(a).email 'Take the customer's email
                        Exit For
                        'stop loop
                    End If
                Next
                Dim emailsubject As String = "Order Overdue - Order No. " & maxOrderNumber.ToString
                'The subject of the email
                Dim emailMessage As String = "Dear " & custname & vbNewLine & "You order is overdue. The order details can be found below" & vbNewLine & "Order Number: " & orderdata(x).OrderNumber.ToString & vbNewLine & "Order Date: " & Now.ToLongDateString & vbNewLine & "Hire From: " & frmMainMenu.dbxNewOrderHireFrom.Text & " to: " & frmMainMenu.dbxNewOrderHireTill.Text & vbNewLine & "Car Details: " & orderdata(x).CarMake & " " & orderdata(x).CarModel & " Colour: " & orderdata(x).CarColour & " Car REG: " & orderdata(x).CarREG & vbNewLine & "Please return your car as soon as possible." & vbNewLine & "Thanks" & vbNewLine & "Enterprise Rent a Car"
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
                    email.To.Add(custemail)
                    'The destination email address
                    email.Subject = emailsubject
                    'The subject of the email
                    email.IsBodyHtml = False
                    email.Body = emailMessage
                    'The actual message in the email
                    Server.Send(email)
                    'Send the email
                Catch error_t As Exception
                    'If cant send email
                    emailsuccess += 1
                End Try
            End If
        Next
        If emailsuccess <> 0 Then
            customMsgBox("Note: Some emails might have not been sent due to an error")
        Else
            customMsgBox("Notice Emails Sent")
            'Display a message box to confirm email is sent
        End If
    End Sub
End Class