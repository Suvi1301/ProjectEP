Imports System.Text.RegularExpressions
'IMPORTant - Adding Regular Expressions for Validation
Module modGlobal
    Public ComingFromReview As Boolean
    Public PanelList As New List(Of Panel)  'List of all panels on the forms
    Public MsgBoxANSWERYES As Boolean 'True False for Message box response
    Public cA, cB, cC, cD, cE, cF, SP, MP, S4x4, L4x4, MPV, SVn, MVn, LVn, MBus As Integer 'The y variables for the Pie Chart
    Public Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec As Integer 'The y values for the sales chart
    Public lJan, lFeb, lMar, lApr, lMay, lJun, lJul, lAug, lSep, lOct, lNov, lDec As Integer
    Public t9, t10, t11, t12, t13, t14, t15, t16, t17, t18 As Integer 'the y values (no. of sales) for Today per hour chart
    Public y9, y10, y11, y12, y13, y14, y15, y16, y17, y18 As Integer 'the y values (no. of sales) for a date chosen by user for chart
    Public NavButtonList As New List(Of Button) 'List of all the Navigation buttons
    Public TodayIncome As Double 'Todays income total
    Public CompareDayIncome As Double 'Income for the date chosen by user when comparing on chart
    Public Const VAT As Double = 0.2 'The value of the VAT as a percentage (20%)



    Public Sub ErrorMsgBox(errormessage As String)
        'To use a message text and display in a custom message box
        frmErrorMsgBox.Show()
        'show the message box form
        Dim words As String() = errormessage.Split(New Char() {" "})
        'Split the words words in the message 
        Dim word As String
        'The find each word in the whole message
        Dim count As Integer = 0
        'To count the number of characters in the message
        For Each word In words
            'Each word in the message
            count = word.Length + count + 1
            'count the number of characters and add them up
            Dim tempcount As Integer
            'the number of characters in the complete words (no half split words)
            If count <= 40 Then
                'if characters are less than 40
                tempcount = count
                'the count of characters with full words(no half split words)
            End If

            If count <= 40 Then
                'If the message has less than 40 characters
                frmErrorMsgBox.lblMessage.Text = errormessage
                'display the message in one line
            Else
                'if the message contains more than 40 characters
                frmErrorMsgBox.lblMessage.Text = errormessage.Substring(0, tempcount) & vbNewLine & errormessage.Substring(tempcount, errormessage.Length - tempcount)
                'Split the message and display in 2 lines
            End If
        Next
    End Sub
    Public Sub customMsgBox(message As String)
        'Custom message box to display a notification with OK button
        frmMsgBox.Show()
        'Show the Message box
        Dim words As String() = message.Split(New Char() {" "})
        'Split the words words in the message 
        Dim word As String
        'The find each word in the whole message
        Dim count As Integer = 0
        'To count the number of characters in the message
        For Each word In words
            'Each word in the message
            count = word.Length + count + 1
            'count the number of characters and add them up
            Dim tempcount As Integer
            'the number of characters in the complete words (no half split words)
            If count <= 40 Then
                'if characters are less than 40 
                tempcount = count
                'the count of characters with full words (no half split)
            End If
            If count <= 40 Then
                'If the message contains less than 40 characters
                frmMsgBox.lblMessage.Text = message
                'display the message in 1 line
            Else
                'If the message contains more than 40 characters
                frmMsgBox.lblMessage.Text = message.Substring(0, tempcount) & vbNewLine & message.Substring(tempcount, message.Length - tempcount)
                'Split the message and display in 2 lines
            End If
        Next

    End Sub
    Public Function MsgBoxYESNO(messageYESNO As String)
        'a custom message box with a YES NO option to pick from
        Dim words As String() = messageYESNO.Split(New Char() {" "})
        'Split the words in the whole message
        Dim word As String
        'to find each word in the whole message
        Dim count As Integer = 0
        'to count the number of characters in the message
        For Each word In words
            'Each word in the message
            count = word.Length + count + 1
            'count the number of characters and add them up
            Dim tempcount As Integer
            'the number of characters with full words (no half split)
            If count <= 40 Then
                'If the characters are less than 40
                tempcount = count
                'the count of the characters wit full words (no half split)
            End If
            If count <= 40 Then
                'If the message contains less than 40 characters
                frmMsgBoxYesNo.lblMessage.Text = messageYESNO
                'Display the message in 1 line
            Else
                'If the message contains more than 40 characters
                frmMsgBoxYesNo.lblMessage.Text = messageYESNO.Substring(0, tempcount) & vbNewLine & messageYESNO.Substring(tempcount, messageYESNO.Length - tempcount)
                'Split the message and display in 2 lines
            End If
        Next
        frmMsgBoxYesNo.ShowDialog()
        'Show the message box as a dialogue box
        Dim answer As String = MsgBoxANSWERYES
        'the button clicked by the user. YES or NO
        Return answer
        'Return the chosen button YES or NO
    End Function
    Public Sub DisplayPanelMainMenu(ByVal TheChosenPanel As Panel)
        'To display one chosen panel and hide all others on the Main Menu form
        For Each box As Panel In PanelList
            box.Hide()
            'hide all the panels in the list
        Next
        Dim WantedPanel As Panel = DirectCast(TheChosenPanel, Panel)
        'The panel to be made visible
        WantedPanel.Location = New Point(184, 27)
        'Set the location of the panel on the form
        WantedPanel.Show()
        'show the panel that is wanted to be shown
    End Sub
    Public Sub DisplayPanelGraphs(ByVal TheChosenPanel As Panel)
        'Display one chosen panel and hide all others on the Data Analysis form
        For Each box As Panel In PanelList
            box.Hide()
            'hide all the panels in the list
        Next
        Dim WantedPanel As Panel = DirectCast(TheChosenPanel, Panel)
        'the panel that is wanted to be shown
        WantedPanel.Location = New Point(887, 50)
        'the location to show the panel
        WantedPanel.Show()
        'show the panel
    End Sub

    Public Sub HighlightButton(ByVal TheChosenButton As Button)
        'To change the colour of the selected button on the navigation bar
        For Each navbtn As Button In NavButtonList
            navbtn.BackColor = Color.White
            'Make all the buttons white
        Next
        frmMainMenu.btnLogOut.BackColor = Color.FromArgb(0, 166, 100)
        Dim SelectedNavButton As Button = DirectCast(TheChosenButton, Button)
        'The button that is clicked on and needs to be green
        SelectedNavButton.BackColor = Color.FromArgb(0, 166, 100)
        'Change the colour of the button to green
    End Sub

    Public Structure Prices
        'Record structure for all the prices of the cars
        Dim price As Double 'Price of the car in pounds
        Dim type As String 'The Class of the car e.g Class A
    End Structure
    Public pricesdata(100) As Prices   'Array for the prices of the cars
    Public priceRecNo As Integer 'The number of records in the file
    Public PriceFile As String = CurDir() + "\Prices.txt" 'The name of the file stored in the current directory

    Public Structure EmployeeInfo
        'Record structure for the Employee data
        Dim empID As Integer 'The unique ID number of each employee
        Dim Firstname As String 'The Firstname of the Employee
        Dim Street As String 'Street Name of the employee's address
        Dim City As String 'City/town of the employee's address
        Dim postcode As String 'Postcode of employee's address
        Dim email As String 'Employee's email address
        Dim dob As String 'Date of Birth of the employee
        Dim phone As String 'contact number of the employee
        Dim Surname As String 'Surname of the employee
        Dim HouseNo As String 'House number of the employee's address
        Dim Password As String 'Password for employee to login to the system
    End Structure
    Public employeedata(1000) As EmployeeInfo 'Array for employee details
    Public empRecNo As Integer 'The number of employee records in the file
    Public empUserNo As Integer = 0 'To store the position of the record that is searched for in procedures
    Public empMax As Integer = 0 'The maximum value of the employee ID used to generate a unique ID for new employee
    Public EmployeeFile As String = CurDir() + "\EmployeeDetails.txt" 'The name of the employee details file saved in the current directory


    Public Structure Customerinfo
        'Record structure for Customer Details
        Dim custID As Integer 'Unique ID of each customer registered
        Dim Firstname As String 'Firstname of the customer
        Dim Surname As String 'Surnaame of the customer
        Dim HouseNo As String 'House number of the customer's address
        Dim Street As String 'Street name of the customer's address
        Dim City As String 'City/Town of the customer's address 
        Dim postcode As String 'Postcode of the customer's address
        Dim email As String 'Customer's email address
        Dim dob As String 'Customer's date of birth
        Dim phone As String 'customer's contact number
        Dim licenseNo As String 'Customer's License number
    End Structure
    Public customerdata(1000) As Customerinfo 'Array for customer details
    Public custRecNo As Integer 'The number of records in the Customer data file
    Public custUserNo As Integer = 0 'To store the position of the record that is searched for in the procedures
    Public custMax As Integer = 0 'Maximum value of the customer ID in the file used to generate unique ID for new customer
    Public CustomerFile As String = CurDir() + "\CustomerDetails.txt" 'The name of the Customer file saved in the current directory


    Public Structure CarInfo
        'Record structure for all Car details
        Dim CarMake As String 'The Make of the car chosen from a fixed number of different options
        Dim CarModel As String 'The model/name of the car
        Dim CarReg As String 'The Registration number of the car
        Dim CarColour As String 'The colour of the car chosen from a fixed number of different options
        Dim EngineSize As String 'The size of the engine of the car chosen from given values
        Dim FuelType As String 'The fuel type of the car, either Petrol, Diesel or Electric
        Dim CarClass As String 'Class/Category of the car. To determine the size/price of that particular car
        Dim CarSeat As String 'The number of seats the car has
        Dim CarDoor As Integer 'The number of doors the car has
        Dim Hired As String 'The Hired status of the car to check if it is hired or not
    End Structure
    Public cardata(1000) As CarInfo 'Array for Car Details
    Public carRecNo As Integer 'The number of car records in the file
    Public carUserNo As Integer = 0 'To store the position of the record that is searched for in procedures
    Public CarFile As String = CurDir() + "\CarDetails.txt"    'The name of the car data file saved in the current directory


    Public Structure CarStock
        'Record structure for car stock details.
        Dim CarMake As String 'The Make of the car chosen from a fixed number of different options
        Dim CarModel As String 'The model/name of the car
        Dim Stock As Integer 'The stock number of the car. The number of each cars available 
        Dim CarClass As String 'Class/Category of the car. To determine the size/price of that particular car
    End Structure
    Public carstockdata(1000) As CarStock 'Array for the Car stock data
    Public StockRecNo As Integer 'The number of of Car Stock records in the file
    Public StockUserNo As Integer = 0 'To store the position of the record that is searched for
    Public StockFile As String = CurDir() + "\CarStockDetails.txt" 'The name of the Stock Data file saved in the current directory


    Public Structure Orders
        'Record structure for Order data
        Dim OrderNumber As Integer 'Unique order number for each order
        Dim CarMake As String 'The Make of the car chosen from a fixed number of different options
        Dim CarModel As String 'The model/name of the car
        Dim CarColour As String 'The colour of the car chosen from a fixed number of different options
        Dim CarREG As String 'The Registration number of the car
        Dim CarClass As String 'Class/Category of the car. To determine the size/price of that particular car
        Dim orderFROM As String 'The date when the hire begins
        Dim orderTO As String 'the date of return of car
        Dim custFname As String 'The first name of the customer
        Dim custSname As String 'The surname of the customer
        Dim custID As Integer 'The unique ID of the customer booking the order
        Dim custLicense As String 'The license number of the customer
        Dim orderDATE As Date 'The date the order was made on
        Dim orderTIME As Date 'The time of at which the order was completed
        Dim PriceTotal As Double 'Total final Price of the order including VAT
        Dim insurance As String 'If insurance was taken or not by the customer
        Dim Returned As String 'If the car has been returned yet
        Dim orderEMPNo As Integer 'The Employee's ID who completed the transaction
        Dim Collected As String
    End Structure
    Public orderdata(1000) As Orders 'Array for Order details
    Public orderRecNo As Integer 'The number of records in the order file
    Public orderUserNo As Integer = 0 'To store the position of the record searched for
    Public OrderFile As String = CurDir() + "/OrderDetails.txt" 'The name of the Order file saved in he current directory
    Public maxOrderNumber As Integer 'The max order number

    'SAVE TO FILE'
    Public Sub SaveOrderDetails()
        'To save Order details in a text file
        Dim transactionfile As String = "" 'One record
        Dim fieldseperator As String = "•" 'this seperates the different fields on the text file with • e.g ID•Name•Postcode
        Dim recordseperator As String = "¦" 'this puts a '¦' and adds a new line between two different records'
        For i As Integer = 1 To orderRecNo
            'go through all records in database'
            If ((orderdata(i)).OrderNumber <> False) Then
                transactionfile = transactionfile + orderdata(i).OrderNumber.ToString 'first field'
                transactionfile = transactionfile + fieldseperator + orderdata(i).CarClass
                transactionfile = transactionfile + fieldseperator + orderdata(i).CarMake
                transactionfile = transactionfile + fieldseperator + orderdata(i).CarModel
                transactionfile = transactionfile + fieldseperator + orderdata(i).CarColour
                transactionfile = transactionfile + fieldseperator + orderdata(i).CarREG
                transactionfile = transactionfile + fieldseperator + orderdata(i).orderFROM
                transactionfile = transactionfile + fieldseperator + orderdata(i).orderTO
                transactionfile = transactionfile + fieldseperator + orderdata(i).custID.ToString
                transactionfile = transactionfile + fieldseperator + orderdata(i).custFname
                transactionfile = transactionfile + fieldseperator + orderdata(i).custSname
                transactionfile = transactionfile + fieldseperator + orderdata(i).custLicense
                transactionfile = transactionfile + fieldseperator + orderdata(i).orderDATE.ToShortDateString
                transactionfile = transactionfile + fieldseperator + orderdata(i).PriceTotal.ToString
                transactionfile = transactionfile + fieldseperator + orderdata(i).insurance
                transactionfile = transactionfile + fieldseperator + orderdata(i).Returned
                transactionfile = transactionfile + fieldseperator + orderdata(i).orderEMPNo.ToString
                transactionfile = transactionfile + fieldseperator + orderdata(i).orderTIME.ToShortTimeString 'last field of the record
                transactionfile = transactionfile + fieldseperator + orderdata(i).Collected
                transactionfile = transactionfile + recordseperator 'add a ¦ and a new line at the end of each record to seperate them'
            End If
        Next
        My.Computer.FileSystem.WriteAllText(OrderFile, transactionfile, False)
        'Save it to file
    End Sub
    Public Sub SaveEmployeeDetails()
        'To save the Employee Details in a text file
        Dim transactionfile As String = "" 'One record
        Dim fieldseperator As String = "•" 'this seperates the different fields on the text file with • e.g ID•Name•Postcode
        Dim recordseperator As String = "¦" 'this puts a '¦' and adds a new line between two different records'
        For i As Integer = 1 To empRecNo 'go through all records in database'
            If ((employeedata(i).empID) <> False) Then
                transactionfile = transactionfile + employeedata(i).empID.ToString 'first field'
                transactionfile = transactionfile + fieldseperator + employeedata(i).Firstname
                transactionfile = transactionfile + fieldseperator + employeedata(i).Surname
                transactionfile = transactionfile + fieldseperator + employeedata(i).dob
                transactionfile = transactionfile + fieldseperator + employeedata(i).email
                transactionfile = transactionfile + fieldseperator + employeedata(i).phone
                transactionfile = transactionfile + fieldseperator + employeedata(i).HouseNo
                transactionfile = transactionfile + fieldseperator + employeedata(i).Street
                transactionfile = transactionfile + fieldseperator + employeedata(i).City
                transactionfile = transactionfile + fieldseperator + employeedata(i).postcode
                transactionfile = transactionfile + fieldseperator + employeedata(i).Password 'last field of the record
                transactionfile = transactionfile + recordseperator 'add a ¦ and a new line at the end of each record to seperate them'
            End If
        Next
        My.Computer.FileSystem.WriteAllText(EmployeeFile, transactionfile, False)
        'Save the data to file
    End Sub
    Public Sub SaveCustomerDetails()
        'To save the Customer Details in a text file
        Dim transactionfile As String = "" 'One record
        Dim fieldseperator As String = "•" 'this seperates the different fields on the text file with • e.g ID•Name•Postcode
        Dim recordseperator As String = "¦" 'this puts a '¦' and adds a new line between two different records
        For i As Integer = 1 To custRecNo 'go through all records in database
            If ((customerdata(i).custID) <> False) Then
                transactionfile = transactionfile + customerdata(i).custID.ToString 'first field
                transactionfile = transactionfile + fieldseperator + customerdata(i).Firstname
                transactionfile = transactionfile + fieldseperator + customerdata(i).Surname
                transactionfile = transactionfile + fieldseperator + customerdata(i).dob
                transactionfile = transactionfile + fieldseperator + customerdata(i).licenseNo
                transactionfile = transactionfile + fieldseperator + customerdata(i).email
                transactionfile = transactionfile + fieldseperator + customerdata(i).phone
                transactionfile = transactionfile + fieldseperator + customerdata(i).HouseNo
                transactionfile = transactionfile + fieldseperator + customerdata(i).Street
                transactionfile = transactionfile + fieldseperator + customerdata(i).City
                transactionfile = transactionfile + fieldseperator + customerdata(i).postcode 'last field of the record
                transactionfile = transactionfile + recordseperator 'add a ¦ and a new line at the end of each record to seperate them
            End If
        Next
        My.Computer.FileSystem.WriteAllText(CustomerFile, transactionfile, False)
        'Save the data to file
    End Sub
    Public Sub SaveCarDetails()
        'To save car details in a text file
        Dim transactionfile As String = "" 'One record
        Dim fieldseperator As String = "•" 'this seperates the different fields on the text file with • e.g ID•Name•Postcode
        Dim recordseperator As String = "¦"  'this puts a '¦' and adds a new line between two different records
        For i As Integer = 1 To carRecNo 'go through all records in database'
            If (cardata(i).CarDoor) <> False Then
                transactionfile = transactionfile + cardata(i).CarDoor.ToString 'first field'
                transactionfile = transactionfile + fieldseperator + cardata(i).CarMake
                transactionfile = transactionfile + fieldseperator + cardata(i).CarModel
                transactionfile = transactionfile + fieldseperator + cardata(i).CarReg
                transactionfile = transactionfile + fieldseperator + cardata(i).CarColour
                transactionfile = transactionfile + fieldseperator + cardata(i).EngineSize
                transactionfile = transactionfile + fieldseperator + cardata(i).FuelType
                transactionfile = transactionfile + fieldseperator + cardata(i).CarClass
                transactionfile = transactionfile + fieldseperator + cardata(i).CarSeat
                transactionfile = transactionfile + fieldseperator + cardata(i).Hired 'last field of the record
                transactionfile = transactionfile + recordseperator  'add a ¦ and a new line at the end of each record to seperate them'
            End If
        Next
        My.Computer.FileSystem.WriteAllText(CarFile, transactionfile, False)
        'Save the data to the car file
    End Sub
    Public Sub SaveCarStockDetails()
        'To save Car Stock Details in a text file
        Dim transactionfile As String = "" 'One record
        Dim fieldseperator As String = "•" 'this seperates the different fields on the text file with • e.g ID•Name•Postcode
        Dim recordseperator As String = "¦"  'this puts a '¦' and adds a new line between two different records
        For i As Integer = 1 To StockRecNo 'go through all records in database
            If ((carstockdata(i).Stock) <> False) Then
                transactionfile = transactionfile + carstockdata(i).CarClass 'first field'
                transactionfile = transactionfile + fieldseperator + carstockdata(i).CarMake
                transactionfile = transactionfile + fieldseperator + carstockdata(i).CarModel
                transactionfile = transactionfile + fieldseperator + carstockdata(i).Stock.ToString 'last field in the record
                transactionfile = transactionfile + recordseperator 'add a ¦ and a new line at the end of each record to seperate them'
            End If
        Next
        My.Computer.FileSystem.WriteAllText(StockFile, transactionfile, False)
        'Save the Car stock data in the stock file
    End Sub
    Public Sub SavePricesDetails()
        'To save the prices of cars in a text file
        Dim transactionfile As String = "" 'One record
        Dim fieldseperator As String = "•" 'this seperates the different fields on the text file with • e.g ID•Name•Postcode
        Dim recordseperator As String = "¦" 'this puts a '¦' and adds a new line between two different records
        For i As Integer = 1 To priceRecNo  'go through all records in database'
            If ((pricesdata(i)).price <> False) Then
                transactionfile = transactionfile + pricesdata(i).type 'first field'
                transactionfile = transactionfile + fieldseperator + pricesdata(i).price.ToString
                transactionfile = transactionfile + recordseperator 'add a ¦ and new line at the end of each record to seperate them'
            End If
        Next
        My.Computer.FileSystem.WriteAllText(PriceFile, transactionfile, False)
        'Save the Price data in the Price file
    End Sub

    'LOAD FROM FILE'
    Public Sub LoadCustomerData()
        'To load the Customer Data from the text file
        Dim fieldSeparator As String = "•" 'To separate the different fields using • e.g ID•Name•Postcode
        Dim recordSeparator As String = "¦" 'this separates the different records using ¦
        Dim contents As String = My.Computer.FileSystem.ReadAllText(CustomerFile) 'location and name of the file'
        Dim record() As String = contents.Split(recordSeparator) 'Split the contents of the file into records and fields
        For i As Integer = 0 To record.Length - 1
            'Go through all records
            If record(i).Trim <> String.Empty Then
                'This only reads the records that are not empty. so prevents from having records that are blank
                Dim field() As String = record(i).Split(fieldSeparator)
                'this seperates the records into fields'
                customerdata(i + 1).custID = field(0) 'first field'
                customerdata(i + 1).Firstname = field(1)
                customerdata(i + 1).Surname = field(2)
                customerdata(i + 1).dob = field(3)
                customerdata(i + 1).licenseNo = field(4)
                customerdata(i + 1).email = field(5)
                customerdata(i + 1).phone = field(6)
                customerdata(i + 1).HouseNo = field(7)
                customerdata(i + 1).Street = field(8)
                customerdata(i + 1).City = field(9)
                customerdata(i + 1).postcode = field(10) 'last field in the record
            End If
        Next
        custRecNo = record.Length - 1
        'store the number of records in the file in a variable
    End Sub
    Public Sub LoadCarData()
        'To load the Car Data from the text file
        Dim fieldSeparator As String = "•" 'To separate the different fields using • e.g ID•Name•Postcode
        Dim recordSeparator As String = "¦" 'this separates the different records using ¦
        Dim contents As String = My.Computer.FileSystem.ReadAllText(CarFile) 'location and name of the file
        Dim record() As String = contents.Split(recordSeparator) 'Split the contents of the file into records and fields
        For i As Integer = 0 To record.Length - 1
            'Go through all records
            If record(i).Trim <> String.Empty Then
                'This only reads the records that are not empty. so prevents from having records that are blank
                Dim field() As String = record(i).Split(fieldSeparator)
                'this seperates the records into fields
                cardata(i + 1).CarDoor = field(0) 'first field
                cardata(i + 1).CarMake = field(1)
                cardata(i + 1).CarModel = field(2)
                cardata(i + 1).CarReg = field(3)
                cardata(i + 1).CarColour = field(4)
                cardata(i + 1).EngineSize = field(5)
                cardata(i + 1).FuelType = field(6)
                cardata(i + 1).CarClass = field(7)
                cardata(i + 1).CarSeat = field(8)
                cardata(i + 1).Hired = field(9)
            End If
        Next
        carRecNo = record.Length - 1
        'store the number of records in the file in a variable
    End Sub
    Public Sub LoadEmployeeData()
        'To load the Employee Data from the text file
        Dim fieldSeparator As String = "•" 'To separate the different fields using • e.g ID•Name•Postcode
        Dim recordSeparator As String = "¦" 'this separates the different records using ¦
        Dim contents As String = My.Computer.FileSystem.ReadAllText(EmployeeFile) 'location and name of the file
        Dim record() As String = contents.Split(recordSeparator) 'Split the contents of the file into records and fields
        For i As Integer = 0 To record.Length - 1
            'Go through all records
            If record(i).Trim <> String.Empty Then
                'This only reads the records that are not empty. so prevents from having records that are blank
                Dim field() As String = record(i).Split(fieldSeparator)
                'this seperates the records into fields
                employeedata(i + 1).empID = field(0) 'first field
                employeedata(i + 1).Firstname = field(1)
                employeedata(i + 1).Surname = field(2)
                employeedata(i + 1).dob = field(3)
                employeedata(i + 1).email = field(4)
                employeedata(i + 1).phone = field(5)
                employeedata(i + 1).HouseNo = field(6)
                employeedata(i + 1).Street = field(7)
                employeedata(i + 1).City = field(8)
                employeedata(i + 1).postcode = field(9)
                employeedata(i + 1).Password = field(10)
            End If
        Next
        empRecNo = record.Length - 1
        'store the number of records in the file in a variable
    End Sub
    Public Sub LoadStockData()
        'To load the car stock data from the text file
        Dim fieldSeparator As String = "•" 'To separate the different fields using • e.g ID•Name•Postcode
        Dim recordSeparator As String = "¦" 'this separates the different records using ¦
        Dim contents As String = My.Computer.FileSystem.ReadAllText(StockFile) 'location and name of the file
        Dim record() As String = contents.Split(recordSeparator) 'Split the contents of the file into records and fields
        For i As Integer = 0 To record.Length - 1
            'Go through all records
            If record(i).Trim <> String.Empty Then
                'This only reads the records that are not empty. so prevents from having records that are blank
                Dim field() As String = record(i).Split(fieldSeparator)
                'this seperates the records into fields
                carstockdata(i + 1).CarClass = field(0) 'first field
                carstockdata(i + 1).CarMake = field(1)
                carstockdata(i + 1).CarModel = field(2)
                carstockdata(i + 1).Stock = field(3)
            End If
        Next
        StockRecNo = record.Length - 1
        'store the number of records in the file in a variable

    End Sub
    Public Sub LoadOrderData()
        'To load the Order data from the text file
        Dim fieldSeparator As String = "•" 'To separate the different fields using • e.g ID•Name•Postcode
        Dim recordSeparator As String = "¦"  'this separates the different records using ¦
        Dim contents As String = My.Computer.FileSystem.ReadAllText(OrderFile) 'location and name of the file
        Dim record() As String = contents.Split(recordSeparator) 'Split the contents of the file into records and fields
        For i As Integer = 0 To record.Length - 1
            'Go through all records
            If record(i).Trim <> String.Empty Then
                'This only reads the records that are not empty. so prevents from having records that are blank
                Dim field() As String = record(i).Split(fieldSeparator)
                'this seperates the records into fields
                orderdata(i + 1).OrderNumber = field(0) 'first field
                orderdata(i + 1).CarClass = field(1)
                orderdata(i + 1).CarMake = field(2)
                orderdata(i + 1).CarModel = field(3)
                orderdata(i + 1).CarColour = field(4)
                orderdata(i + 1).CarREG = field(5)
                orderdata(i + 1).orderFROM = field(6)
                orderdata(i + 1).orderTO = field(7)
                orderdata(i + 1).custID = field(8)
                orderdata(i + 1).custFname = field(9)
                orderdata(i + 1).custSname = field(10)
                orderdata(i + 1).custLicense = field(11)
                orderdata(i + 1).orderDATE = field(12)
                orderdata(i + 1).PriceTotal = field(13)
                orderdata(i + 1).insurance = field(14)
                orderdata(i + 1).Returned = field(15)
                orderdata(i + 1).orderEMPNo = field(16)
                orderdata(i + 1).orderTIME = field(17)
                orderdata(i + 1).Collected = field(18)
            End If
        Next
        orderRecNo = record.Length - 1
        'store the number of records in the file in a variable
    End Sub
    Public Sub LoadPriceData()
        'To load the price data from the text file
        Dim fieldSeparator As String = "•" 'To separate the different fields using • e.g ID•Name•Postcode
        Dim recordSeparator As String = "¦" 'this separates the different records using ¦
        Dim contents As String = My.Computer.FileSystem.ReadAllText(PriceFile) 'location and name of the file
        Dim record() As String = contents.Split(recordSeparator) 'Split the contents of the file into records and fields
        For i As Integer = 0 To record.Length - 1
            'Go through all records
            If record(i).Trim <> String.Empty Then
                'This only reads the records that are not empty. so prevents from having records that are blank
                Dim field() As String = record(i).Split(fieldSeparator)
                'this seperates the records into fields
                pricesdata(i + 1).type = field(0) 'first field
                pricesdata(i + 1).price = field(1)
            End If
        Next
        priceRecNo = record.Length - 1
        'store the number of records in the file in a variable

    End Sub

    'CHART DATA'
    Public Sub GetSomeClass()
        cA = 0 'count for Class A orders made
        cB = 0 'count for Class B orders made
        cC = 0 'count for Class C orders made
        cD = 0 'count for Class D orders made
        cE = 0 'count for Class E orders made
        cF = 0 'count for Class F orders made
        SP = 0 'count for Small Premium orders made
        MP = 0 'count for Medium Premium orders made
        S4x4 = 0 'count for Small 4X4 orders made
        L4x4 = 0 'count for Large 4X4 orders made
        MPV = 0 'count for MPV orders made
        SVn = 0 'count for Small Van orders made
        MVn = 0 'count for Medium Van orders made
        LVn = 0 'count for Large Van orders made
        MBus = 0 'count for MiniBus orders made
        'Set the values of all the y axis variables to zero
        LoadOrderData()
        'Load all order data
        For count As Integer = 1 To orderRecNo
            'Look through all order records
            If orderdata(count).orderDATE >= CDate(frmDataAnalysis.dbxPIEStartDate.Text) AndAlso orderdata(count).orderDATE <= CDate(frmDataAnalysis.dbxPIEEndDate.Text) Then
                If orderdata(count).CarClass = "Class A / Mini" Then
                    cA += 1
                ElseIf orderdata(count).CarClass = "Class B / Economy" Then
                    cB += 1
                ElseIf orderdata(count).CarClass = "Class C / Small Compact" Then
                    cC += 1
                ElseIf orderdata(count).CarClass = "Class D / Large Compact" Then
                    cD += 1
                ElseIf orderdata(count).CarClass = "Class E / Intermediate" Then
                    cE += 1
                ElseIf orderdata(count).CarClass = "Class F / Standard" Then
                    cF += 1
                ElseIf orderdata(count).CarClass = "MPV" Then
                    MPV += 1
                ElseIf orderdata(count).CarClass = "Small Premium" Then
                    SP += 1
                ElseIf orderdata(count).CarClass = "Medium Premium" Then
                    MP += 1
                ElseIf orderdata(count).CarClass = "Small 4X4" Then
                    S4x4 += 1
                ElseIf orderdata(count).CarClass = "Large 4X4" Then
                    L4x4 += 1
                ElseIf orderdata(count).CarClass = "Minibus 9 seats" Then
                    MBus += 1
                ElseIf orderdata(count).CarClass = "Mini Van" Then
                    SVn += 1
                ElseIf orderdata(count).CarClass = "Medium Van" Then
                    MVn += 1
                ElseIf orderdata(count).CarClass = "Large Van" Then
                    LVn += 1
                End If
                'Find record and increase the appropriate count variable
            End If
        Next

    End Sub
    Public Sub findMonthlySales()
        Jan = 0 'sales count for January current year
        Feb = 0 'sales count for February current year
        Mar = 0 'sales count for March current year
        Apr = 0 'sales count for April current year
        May = 0 'sales count for May current year
        Jun = 0 'Sales count for June current year
        Jul = 0 'Sales count for July current year
        Aug = 0 'sales count for August current year
        Sep = 0 'sales count for Sepetember current year
        Oct = 0 'sales count for October current year
        Nov = 0 'sales count for November current year
        Dec = 0  'sales count for December current year

        lJan = 0 'sales count for January last year
        lFeb = 0 'sales count for February last year
        lMar = 0 'sales count for March last year
        lApr = 0 'sales count for April last year
        lMay = 0 'sales count for May last year
        lJun = 0 'Sales count for June last year
        lJul = 0 'Sales count for July last year
        lAug = 0 'sales count for August last year
        lSep = 0 'sales count for Sepetember last year
        lOct = 0 'sales count for October last year
        lNov = 0 'sales count for November last year
        lDec = 0  'sales count for December last year
        LoadOrderData()
        'Load all Order data from file
        For counter As Integer = 1 To orderRecNo
            'Look through all Order records
            If orderdata(counter).orderDATE.Year = Now.Year Then
                'If the order was made in the current year
                With orderdata(counter).orderDATE
                    If .Month = 1 Then
                        Jan += 1
                    ElseIf .Month = 2 Then
                        Feb += 1
                    ElseIf .Month = 3 Then
                        Mar += 1
                    ElseIf .Month = 4 Then
                        Apr += 1
                    ElseIf .Month = 5 Then
                        May += 1
                    ElseIf .Month = 6 Then
                        Jun += 1
                    ElseIf .Month = 7 Then
                        Jul += 1
                    ElseIf .Month = 8 Then
                        Aug += 1
                    ElseIf .Month = 9 Then
                        Sep += 1
                    ElseIf .Month = 10 Then
                        Oct += 1
                    ElseIf .Month = 11 Then
                        Nov += 1
                    ElseIf .Month = 12 Then
                        Dec += 1
                    End If
                End With
                'Count the orders made each month in the current year
            ElseIf orderdata(counter).orderDATE.Year = Now.AddYears(-1).Year Then
                With orderdata(counter).orderDATE
                    If .Month = 1 Then
                        lJan += 1
                    ElseIf .Month = 2 Then
                        lFeb += 1
                    ElseIf .Month = 3 Then
                        lMar += 1
                    ElseIf .Month = 4 Then
                        lApr += 1
                    ElseIf .Month = 5 Then
                        lMay += 1
                    ElseIf .Month = 6 Then
                        lJun += 1
                    ElseIf .Month = 7 Then
                        lJul += 1
                    ElseIf .Month = 8 Then
                        lAug += 1
                    ElseIf .Month = 9 Then
                        lSep += 1
                    ElseIf .Month = 10 Then
                        lOct += 1
                    ElseIf .Month = 11 Then
                        lNov += 1
                    ElseIf .Month = 12 Then
                        lDec += 1
                    End If
                End With
            End If
        Next

    End Sub
    Public Sub findDailySales()
        t9 = 0 'count of orders made between 9am and 10pm for current day
        t10 = 0 'count of orders made between 10am and 11am for current day
        t11 = 0 'count of orders made between 11am and 12am for current day
        t12 = 0 'count of orders made between 12noon and 1pm for current day
        t13 = 0 'count of orders made between 1pm and 2pm for current day
        t14 = 0 'count of orders made between 2pm and 3pm for current day 
        t15 = 0 'count of orders made between 3pm and 4pm for current day
        t16 = 0 'count of orders made between 4pm and 5pm for current day
        t17 = 0 'count of order made between 5pm and 6pm for current day
        t18 = 0 'count of orders made between 6pm and 7pm for current day

        y9 = 0 'count of orders made between 9am and 10pm
        y10 = 0 'count of orders made between 10am and 11am
        y11 = 0 'count of orders made between 11am and 12am
        y12 = 0 'count of orders made between 12noon and 1pm
        y13 = 0 'count of orders made between 1pm and 2pm
        y14 = 0 'count of orders made between 2pm and 3pm
        y15 = 0 'count of orders made between 3pm and 4pm 
        y16 = 0 'count of orders made between 4pm and 5pm
        y17 = 0 'count of order made between 5pm and 6pm
        y18 = 0 'count of orders made between 6pm and 7pm
        LoadOrderData()
        'load all order data
        Dim comparedate As Date = CDate(frmDataAnalysis.dbxCompareDATE.Text) 'The date to chosen using date picker to compare today's sales with
        For counter As Integer = 1 To orderRecNo
            'look through all order records
            If orderdata(counter).orderDATE.Date = Now.Date Then
                'If the date of the record is today's date
                With orderdata(counter).orderTIME
                    If .Hour >= 9 And .Hour < 10 Then
                        t9 += 1
                    ElseIf .Hour >= 10 And .Hour < 11 Then
                        t10 += 1
                    ElseIf .Hour >= 11 And .Hour < 12 Then
                        t11 += 1
                    ElseIf .Hour >= 12 And .Hour < 13 Then
                        t12 += 1
                    ElseIf .Hour >= 13 And .Hour < 14 Then
                        t13 += 1
                    ElseIf .Hour >= 14 And .Hour < 15 Then
                        t14 += 1
                    ElseIf .Hour >= 15 And .Hour < 16 Then
                        t15 += 1
                    ElseIf .Hour >= 16 And .Hour < 17 Then
                        t16 += 1
                    ElseIf .Hour >= 17 And .Hour < 18 Then
                        t17 += 1
                    End If
                    'Count the orders made at different times and store in count variables accordingly
                End With

            ElseIf orderdata(counter).orderDATE.Date = comparedate.Date Then
                'if the order date of the order is the date chosen to compare the sales with
                With orderdata(counter).orderTIME
                    If .Hour >= 9 And .Hour < 10 Then
                        y9 += 1
                    ElseIf .Hour >= 10 And .Hour < 11 Then
                        y10 += 1
                    ElseIf .Hour >= 11 And .Hour < 12 Then
                        y11 += 1
                    ElseIf .Hour >= 12 And .Hour < 13 Then
                        y12 += 1
                    ElseIf .Hour >= 13 And .Hour < 14 Then
                        y13 += 1
                    ElseIf .Hour >= 14 And .Hour < 15 Then
                        y14 += 1
                    ElseIf .Hour >= 15 And .Hour < 16 Then
                        y15 += 1
                    ElseIf .Hour >= 16 And .Hour < 17 Then
                        y16 += 1
                    ElseIf .Hour >= 17 And .Hour < 18 Then
                        y17 += 1
                    End If
                    'count the sales at different times of that day and store them in the appropriate count variables
                End With
            End If
        Next
    End Sub
    Public Sub CalculateDailyIncome()
        'To calculate the daily income 
        LoadOrderData()
        'Load all order data
        TodayIncome = 0
        CompareDayIncome = 0
        'reset the income values
        Dim comparedate As Date = frmDataAnalysis.dbxCompareDATE.Text 'The date to compare the sales with
        For count As Integer = 1 To orderRecNo
            'Go through all the order records
            If orderdata(count).orderDATE = Now.Date Then
                'if the date of the order is today's date 
                TodayIncome += orderdata(count).PriceTotal
                'Add the order total price to today's income
            ElseIf orderdata(count).orderDATE = comparedate Then
                'if the date of the order is the other date to compare
                CompareDayIncome += orderdata(count).PriceTotal
                'add the order total price to that day's total income
            End If
        Next
    End Sub

    'REGEX VALIDATION'
    Function ValidateEmail(ByVal email As String, box As Control, TT As ToolTip)
        'To validate an email address entered by the user
        Static emailExp As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        'The Regular Expression for a valid email
        If emailExp.IsMatch(email) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter a valid email address")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return emailExp.IsMatch(email)
        'Returns a True or False value for validation
    End Function
    Public Function ValidatePhoneNumber(ByVal phone As String, box As Control, TT As ToolTip)
        'Validate a contact number entered by the user
        Static PhoneExp As New Regex("^0[0-9]{10}$")
        'The Regular Expression for a valid phone number
        If PhoneExp.IsMatch(phone) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter a valid phone number")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return PhoneExp.IsMatch(phone)
        'Returns a True or False value for validation
    End Function
    Function ValidateOnlyString(ByVal stringvalue As String, box As Control, TT As ToolTip)
        'Validate when only letters can be accepted
        Static OnlyStringExp As New Regex("^[A-Za-z\s]{1,}$")
        'The Regular Expression for just letters being entered
        If OnlyStringExp.IsMatch(stringvalue) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "You must only enter letters in this field")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return OnlyStringExp.IsMatch(stringvalue)
        'Returns a True or False value for validation
    End Function
    Function ValidatePostcode(ByVal postcode As String, box As Control, TT As ToolTip)
        'To validate a postcode entered by a user
        Static postcodeExp As New Regex("^([A-PR-UWYZ]([0-9]{1,2}|([A-HK-Y][0-9]|[A-HK-Y][0-9]([0-9]|[ABEHMNPRV-Y]))|[0-9][A-HJKS-UW])\ [0-9][ABD-HJLNP-UW-Z]{2}|(GIR\ 0AA)|(SAN\ TA1)|(BFPO\ (C\/O\ )?[0-9]{1,4})|((ASCN|BBND|[BFS]IQQ|PCRN|STHL|TDCU|TKCA)\ 1ZZ))$")
        'Regular Expression for a valid postcode
        If postcodeExp.IsMatch(postcode) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter a valid Postcode")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return postcodeExp.IsMatch(postcode)
        'Returns a True or False value for validation
    End Function
    Function ValidatePassword(ByVal password As String, box As Control, TT As ToolTip)
        'To validate a strong password is entered by the user
        Static passwordExp As New Regex("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+){8,}$")
        'Regular expression for a strong valid password
        If passwordExp.IsMatch(password) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Password must contain atleast 8 character including atleast 1 Upper Case, 1 Lower case and 1 number")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return passwordExp.IsMatch(password)
        'Returns a True or False value for validation
    End Function
    Function ValidateID(ByVal Id As String, box As Control, TT As ToolTip)
        'To validate ID of customer or employee
        Static IDExpression As New Regex("^[0-9]{1,}$")
        If IDExpression.IsMatch(Id) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "ID must contain number only")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return IDExpression.IsMatch(Id)
        'Returns a True or False value for validation
    End Function
    Function ValidateREG(ByVal REG As String, box As Control, TT As ToolTip)
        'To validate the car Registration number
        Static REGExpression As New Regex("^([A-Z]{3}\s?(\d{3}|\d{2}|d{1})\s?[A-Z])|([A-Z]\s?(\d{3}|\d{2}|\d{1})\s?[A-Z]{3})|(([A-HK-PRSVWY][A-HJ-PR-Y])\s?([0][2-9]|[1-9][0-9])\s?[A-HJ-PR-Z]{3})$")
        If REGExpression.IsMatch(REG) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter a valid Registration Number")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return REGExpression.IsMatch(REG)
        'Returns a True or False value for validation
    End Function
    Function ValidateNoSymbols(ByVal thetext As String, box As Control, TT As ToolTip)
        Static PresenceExpression As New Regex("^[a-zA-Z0-9\s]{1,}$")

        ' ^[\w\s]{1,}$
        If PresenceExpression.IsMatch(thetext) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter valid data")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return PresenceExpression.IsMatch(thetext)
        'Returns a True or False value for validation
    End Function
    Function ValidatePrice(ByVal price As String, box As Control, TT As ToolTip)
        'Validating the price entered in manage prices
        Static PresenceExpression As New Regex("^[0-9]{1,}.[0-9]{2}$")
        If PresenceExpression.IsMatch(price) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter price in form: 0.00")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return PresenceExpression.IsMatch(price)
        'Returns a True or False value for validation
    End Function
    Function ValidateLicense(ByVal license As String, box As Control, TT As ToolTip)
        'Validate License Number
        Static PresenceExpression As New Regex("^[A-Z0-9]{5}\d[0156]\d([0][1-9]|[12]\d|3[01])\d[A-Z0-9]{3}[A-Z]{2}$")
        If PresenceExpression.IsMatch(license) = False Then
            'If the field is not valid
            box.BackColor = Color.Firebrick
            'Change back colour to Red
            TT.SetToolTip(box, "Please enter a valid License number")
        Else
            TT.Hide(box)
            box.BackColor = Color.FromArgb(52, 52, 52)
        End If
        Return PresenceExpression.IsMatch(license)
        'Returns a True or False value for validation
    End Function

    Public Sub ClearStockFile()
        'To empty the stock file by deleting all the records
        My.Computer.FileSystem.WriteAllText(StockFile, "", False)
        'Overwrite the file with no records
    End Sub
    Public Sub ClearPriceFile()
        'To empty the price file by deleting all the records
        My.Computer.FileSystem.WriteAllText(PriceFile, "", False)
        'Overwrite the file with no records
    End Sub
    Sub CreateStockFile()
        Dim modelcount As Integer = 0
        'counter for number of cars of the same model
        Dim model As String = ""
        'To check the model of the car in file
        Dim flag As Boolean = False
        Dim checkmodel As New List(Of String)
        'Temporary list to add car models to
        LoadCarData()
        ClearStockFile()
        StockRecNo = 0
        For count As Integer = 1 To carRecNo
            'go through all car records
            flag = False
            modelcount = 0
            If model <> cardata(count).CarModel Then
                'If the car model is not yet been seen
                model = cardata(count).CarModel
                'Then make it equal to the 'model' variable
                For Each A As String In checkmodel
                    'Check through list
                    If model = A Then
                        'If model is found in the list
                        flag = True
                        Exit For
                    End If
                Next

                If flag = False Then
                    'If the model wasnt in the list
                    checkmodel.Add(model)
                    'Add the model to the list
                    For search As Integer = 1 To carRecNo
                        'go through all car records
                        If model = cardata(search).CarModel Then
                            'if a car with the same model is found
                            modelcount += 1
                            'increase the count by one
                        End If
                    Next
                    StockRecNo += 1
                    'New record
                    carstockdata(StockRecNo).CarClass = cardata(count).CarClass
                    carstockdata(StockRecNo).CarMake = cardata(count).CarMake
                    carstockdata(StockRecNo).CarModel = cardata(count).CarModel
                    carstockdata(StockRecNo).Stock = modelcount
                    'Add the new record to stock file
                    SaveCarStockDetails()
                End If
            End If
        Next
    End Sub
    Public Function CheckAvailaility(ByVal model As String, ByVal dateFrom As Date, ByVal DateTo As Date)
        'To check the availbaility of the desired car for hiring
        LoadOrderData()
        LoadCarData()
        Dim FoundAvailCar As Integer = 0
        'The record number of the found car
        Dim ListUnavailable As New List(Of String)
        'A list of unavailable cars
        For a As Integer = 1 To orderRecNo
            'go through all order records
            If model = orderdata(a).CarModel AndAlso orderdata(a).Returned = "False" Then
                'If the car model is found and it is not returned
                If (orderdata(a).orderFROM <= dateFrom.Date AndAlso orderdata(a).orderTO >= dateFrom) Or (orderdata(a).orderFROM >= DateTo AndAlso orderdata(a).orderTO <= DateTo) Then
                    'if the hiring date overlap
                    ListUnavailable.Add(orderdata(a).CarREG)
                    'add the car to the unavailble list
                End If
            End If
        Next
        For b As Integer = 1 To carRecNo
            ' MsgBox("model: " & model & "  infile: " & cardata(b).CarModel)
            'go through all car records
            If model = cardata(b).CarModel Then
                ' MsgBox("YES")
                'if car model is found
                FoundAvailCar = b
                For Each item As String In ListUnavailable
                    ' MsgBox("item: " & item & "  infile: " & cardata(b).CarReg)
                    'check through the unavailable list
                    If item = cardata(b).CarReg Then
                        'If list contains the found car's registration number
                        FoundAvailCar = 0
                        Exit For
                    Else
                        FoundAvailCar = b
                        'if not then store the record number of the found car
                    End If
                    'MsgBox("foundavail: " & FoundAvailCar)
                Next
                If FoundAvailCar <> 0 Then
                    Exit For
                End If
            End If
        Next
        Return FoundAvailCar
        'Returns the record number of a found car available to hire for desired dates
    End Function

End Module
