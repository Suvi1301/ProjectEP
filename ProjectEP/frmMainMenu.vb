Option Explicit On
Imports Word = Microsoft.Office.Interop.Word
'This is IMPORTant. Adding word library as a namespace
Public Class frmMainMenu
    'Main menu Form
    Dim panelvisibilitycount As Integer = 0
    Dim EditEMPsearchflag As Boolean = False 'Flag for searching for Employee records
    Dim EditCUSTsearchflag As Boolean = False 'Flag for searching Customer records
    Dim ReturnCarfoundrec As Integer = 0 'Counter for searching Car records
    Dim ReturnCarfinddate As Integer = 0 'Flag for searching Car records
    Public NewOrderfoundCust As Integer = 0 'Counter for searching for customer when placing a new order
    Public NewOrderfoundCar As Integer = 0 'Counter for searching for Car when placing new order
    Dim PricePerDay As Double 'Price per day of chosen car when booking new Order
    Dim drag As Boolean  'To drag the form by clicking on the form
    Dim mousex As Integer 'x position of the cursor
    Dim mousey As Integer 'y position of the cursor
    Public chosencar As String = "" 'The car chosen to hire
    Public orderCarModel As String = "" 'The car model chosen to hire
    Public orderCarReg As String = "" 'The Reg number of the car for hire
    Public orderCarMake As String = "" 'The make of the car that they are hiring
    Public orderColour As String = ""   'The colour of the car being hired
    Public orderPriceNOVAT As Double 'The price excluding VAT of the order
    Public orderPriceINCVAT As Double 'The price including VAT of the order
    Public custemailaddress As String 'The email address of the customer booking the order
    Dim StockFoundRec As Integer 'The record number of the stock record that is searched for
    Dim managestockfound As Integer = 0 'to determine the record number of the searched record

    Private Sub frmMainMenu_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'When left click on form 
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top  'Sets variable mousey
    End Sub
    Private Sub frmMainMenu_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'When moving the mouse
        If drag = True Then
            'If clicking down on the form
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            'move the form accordingly
        End If
    End Sub
    Private Sub frmMainMenu_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
        'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Public Sub AddPanelToList()
        'Add all panels to the list
        PanelList.Add(pnlHomeScreen)
        PanelList.Add(pnlAddEmployee)
        PanelList.Add(pnlAddNewCar)
        PanelList.Add(pnlViewEmployee)
        PanelList.Add(pnlManagePrices)
        PanelList.Add(pnlAddCustomer)
        PanelList.Add(pnlViewCustomer)
        PanelList.Add(pnlNewOrder)
        PanelList.Add(pnlReturnCar)
        PanelList.Add(frmDataAnalysis.pnlDataAnalysisHome)
        PanelList.Add(frmDataAnalysis.pnlControlStockList)
        PanelList.Add(frmDataAnalysis.pnlControlDailySales)
        PanelList.Add(frmDataAnalysis.pnlControlCarClassPIE)
        PanelList.Add(pnlManageStock)

    End Sub
    Private Sub AddButtonsToList()
        'Add all buttons used for navigaton in a list
        NavButtonList.Add(btnNewOrder)
        NavButtonList.Add(btnAddCustomer)
        NavButtonList.Add(btnViewCustomer)
        NavButtonList.Add(btnReturnCar)
        NavButtonList.Add(btnAddEmployee)
        NavButtonList.Add(btnViewEmployee)
        NavButtonList.Add(btnAddNewCar)
        NavButtonList.Add(btnDataAnalysis)
        NavButtonList.Add(btnManagePrices)
        NavButtonList.Add(btnTodaysOrders)
        NavButtonList.Add(btnManageStock)
        NavButtonList.Add(btnOverdueOrders)
        NavButtonList.Add(btnLogOut)
        NavButtonList.Add(frmDataAnalysis.btnMonthlySales)
        NavButtonList.Add(frmDataAnalysis.btnStockList)
        NavButtonList.Add(frmDataAnalysis.btnTypeSales)
        NavButtonList.Add(frmDataAnalysis.btnDailySales)

    End Sub
    Private Sub frmMainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'When Main Menu form loads
        tmrClock.Start()
        'start timer to display clock
        LoadOrderData()
        'when the Main Menu form loads
        AddButtonsToList()
        'add all navigation buttons to the button list
        AddPanelToList()
        'add all panels to the panel list
        DisplayPanelMainMenu(pnlHomeScreen)
        'Display the Home Screen Panel
        dbxAddCustDOB.MinDate = DateTime.Now.AddYears(-100)
        dbxAddCustDOB.MaxDate = DateTime.Now.AddYears(-18)
        dbxEditDOBEMP.MinDate = DateTime.Now.AddYears(-100)
        dbxEditDOBEMP.MaxDate = DateTime.Now.AddYears(-18)
        dbxDOBAddEmployee.MinDate = DateTime.Now.AddYears(-100)
        dbxDOBAddEmployee.MaxDate = DateTime.Now.AddYears(-18)
        dbxNewOrderHireFrom.MinDate = DateTime.Now
        dbxNewOrderHireFrom.MaxDate = DateTime.Now.AddMonths(1)
        dbxNewOrderHireTill.MinDate = DateTime.Now.AddDays(1)
        dbxNewOrderHireTill.MaxDate = DateTime.Now.AddMonths(2)
        dbxViewCustDOB.MinDate = DateTime.Now.AddYears(-100)
        dbxViewCustDOB.MaxDate = DateTime.Now.AddYears(-18)
        'Setting all the ranges of the dates to display in date time pickers on the Main Menu form
        panelvisibilitycount += 1
    End Sub
    Private Sub btnReturnCar_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnCar.Click
        'if the 'Return Car' button is clicked
        HighlightButton(btnReturnCar)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlReturnCar)
        'display the Return Car Panel and hide all other panels
    End Sub
    Private Sub btnAddCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCustomer.Click
        'if the 'Add Customer' button is clicked
        HighlightButton(btnAddCustomer)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlAddCustomer)
        'Display the 'Add Customer' Panel and hide all other panels
    End Sub
    Private Sub btnViewCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnViewCustomer.Click
        'if the 'View Customer' button is clicked
        HighlightButton(btnViewCustomer)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlViewCustomer)
        'Display the 'View Customer' Panel and hide all other panels
    End Sub
    Private Sub btnAddEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEmployee.Click
        'if the 'Add Emloyee' button is clicked
        HighlightButton(btnAddEmployee)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlAddEmployee)
        'Display the 'Add Employee' Panel and hide all other panels
    End Sub
    Private Sub btnViewEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnViewEmployee.Click
        'if the 'View Emloyee' button is clicked
        HighlightButton(btnViewEmployee)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlViewEmployee)
        'Display the 'View Employee' Panel and hide all other panels
    End Sub
    Private Sub btnAddNewCar_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNewCar.Click
        'if the 'Add New Car' button is clicked
        HighlightButton(btnAddNewCar)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlAddNewCar)
        'Display the 'Add New Car' Panel and hide all other panels
    End Sub
    Private Sub btnManagePrices_Click(sender As System.Object, e As System.EventArgs) Handles btnManagePrices.Click
        'if the 'Manage Prices' button is clicked
        HighlightButton(btnManagePrices)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlManagePrices)
        'Display the 'Manage Prices' Panel and hide all other panels
    End Sub
    Private Sub btnNewOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnNewOrder.Click
        'if the 'New Order' button is clicked
        HighlightButton(btnNewOrder)
        'highlight the button green and make all other navigation buttons white
        DisplayPanelMainMenu(pnlNewOrder)
        'Display the 'New Order' Panel and hide all other panels
    End Sub
    Private Sub btnDataAnalysis_Click_1(sender As System.Object, e As System.EventArgs) Handles btnDataAnalysis.Click
        'if the 'Data Analysis' button is clicked
        HighlightButton(btnDataAnalysis)
        'highlight the button green and make all other navigation buttons white
        Me.Close()
        'Close the Main Menu form
        frmDataAnalysis.Show()
        'Open the Data Analysis form
    End Sub
    Private Sub picHome_Click(sender As System.Object, e As System.EventArgs) Handles picHome.Click
        'When Home 'ENTERPRISE' logo is clicked
        DisplayPanelMainMenu(pnlHomeScreen)
        'Display the Home Screen Panel
        HighlightButton(btnLogOut)
        'Highlight all the navigation buttons to white
    End Sub
    Private Sub btnTodaysOrders_Click(sender As System.Object, e As System.EventArgs) Handles btnTodaysOrders.Click
        'when Todays Orders button is clicked
        Me.Hide()
        'Hide Main Menu
        frmTodaysOrders.Show()
        'Show Todays Orders form
    End Sub
    Private Sub btnManageStock_Click(sender As System.Object, e As System.EventArgs) Handles btnManageStock.Click
        'When Manage Stock button is clicked
        DisplayPanelMainMenu(pnlManageStock)
        'Display the Manage Stock
        HighlightButton(btnManageStock)
    End Sub
    Private Sub btnOverdueOrders_Click(sender As System.Object, e As System.EventArgs) Handles btnOverdueOrders.Click
        'When overdue Orders button is clicked
        HighlightButton(btnOverdueOrders)
        Me.Hide()
        frmOverdueCars.Show()
    End Sub

    'PANEL ADD EMPLOYEE DETAILS'

    Private Sub btnSaveEmployeeDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveEmployeeDetails.Click
        Dim ValidateCheck As Boolean = True 'to check if everything is validated
        ttpMainMenu.RemoveAll()
        If ValidateOnlyString(txtFirstName.Text, txtFirstName, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtSurname.Text, txtSurname, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateEmail(txtEmail.Text, txtEmail, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePhoneNumber(txtPhone.Text, txtPhone, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePostcode(txtPostcode.Text, txtPostcode, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePassword(txtPassword.Text, txtPassword, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtCity.Text, txtCity, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtHouseNo.Text, txtHouseNo, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtStreet.Text, txtStreet, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        'Validate all fields
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
            customMsgBox("SAVED")
            'display message box 
            'reset the values in the text boxes and combo boxes
            txtFirstName.Enabled = False
            txtSurname.Enabled = False
            dbxDOBAddEmployee.Enabled = False
            txtPhone.Enabled = False
            txtEmail.Enabled = False
            txtHouseNo.Enabled = False
            txtStreet.Enabled = False
            txtCity.Enabled = False
            txtPostcode.Enabled = False
            txtPassword.Enabled = False
            btnSaveEmployeeDetails.Enabled = False
            btnStartAddEMP.Enabled = True
            'Disable the text boxes and combo boxes 
            For Each box As Control In pnlAddEmployee.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            'Reset all the textboxes
        End If
    End Sub
    Private Sub btnStartAddEMP_Click(sender As System.Object, e As System.EventArgs) Handles btnStartAddEMP.Click
        btnSaveEmployeeDetails.Enabled = True
        btnStartAddEMP.Enabled = False
        'When begin button is clicked
        empMax = empMax + 1
        'create a unique ID
        lblEmployeeID.Text = empMax.ToString
        'Display the generated ID
        txtFirstName.Enabled = True
        txtSurname.Enabled = True
        dbxDOBAddEmployee.Enabled = True
        txtPhone.Enabled = True
        txtEmail.Enabled = True
        txtHouseNo.Enabled = True
        txtStreet.Enabled = True
        txtCity.Enabled = True
        txtPostcode.Enabled = True
        txtPassword.Enabled = True
        'Enable all text boxes and combo boxes
    End Sub
    Private Sub pnlAddEmployee_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlAddEmployee.VisibleChanged
        'When the Add Employee Panel is shown
        If pnlAddEmployee.Visible = True Then
            txtFirstName.Enabled = False
            txtSurname.Enabled = False
            dbxDOBAddEmployee.Enabled = False
            txtPhone.Enabled = False
            txtEmail.Enabled = False
            txtHouseNo.Enabled = False
            txtStreet.Enabled = False
            txtCity.Enabled = False
            txtPostcode.Enabled = False
            txtPassword.Enabled = False
            btnSaveEmployeeDetails.Enabled = False
            btnStartAddEMP.Enabled = True
            'Disable all the text boxes and combo boxes
        ElseIf pnlAddEmployee.Visible = False Then
            If panelvisibilitycount <> 0 Then
                For Each box As Control In pnlAddEmployee.Controls
                    If TypeOf box Is TextBox Then
                        box.ResetText()
                    End If
                Next
                lblEmployeeID.ResetText()
            End If
        End If
    End Sub

    'PANEL VIEW/EDIT EMPLOYEE DETAILS'

    Private Sub btnEditFname_Click(sender As System.Object, e As System.EventArgs) Handles btnEditFname.Click
        'To edit the First Name
        txtEditFirstNameEMP.Enabled = True
        'Enable the first name text box
    End Sub
    Private Sub btnEditSurname_Click(sender As System.Object, e As System.EventArgs) Handles btnEditSurname.Click
        'To edit the Surname            
        txtEditSnameEMP.Enabled = True
        'Enable the Surname text box    
    End Sub
    Private Sub btnEditDOB_Click(sender As System.Object, e As System.EventArgs) Handles btnEditDOB.Click
        'To edit the Date of Birth  
        dbxEditDOBEMP.Enabled = True
        'Enable the date picker
    End Sub
    Private Sub btnEditEmail_Click(sender As System.Object, e As System.EventArgs) Handles btnEditEmail.Click
        'To Edit the email              
        txtEditEmailEMP.Enabled = True
        'Enable the email text box
    End Sub
    Private Sub btnEditPhone_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPhone.Click
        'To edit the contact number         
        txtEditContactEMP.Enabled = True
        'Enable the contact number text box
    End Sub
    Private Sub btnEditHouseNo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditHouseNo.Click
        'To edit the house number           
        txtEditHouseNoEMP.Enabled = True
        'Enable the House number text box   
    End Sub
    Private Sub btnEditStreet_Click(sender As System.Object, e As System.EventArgs) Handles btnEditStreet.Click
        'To edit the Street Name            
        txtEditStreetEMP.Enabled = True
        'Enable the Street Name text box    
    End Sub
    Private Sub btnEditCity_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCity.Click
        'To edit the City/Town          
        txtEditCityEMP.Enabled = True
        'Enable the City/Town text box
    End Sub
    Private Sub btnEditPostcode_Click(sender As System.Object, e As System.EventArgs) Handles btnEditPostcode.Click
        'To edit the postcode
        txtEditPostcodeEMP.Enabled = True
        'Enable the Postcode text box
    End Sub
    Private Sub btnUpdateEMP_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateEMP.Click
        'When Save Changes button is clicked
        Dim ValidateCheck As Boolean = True 'To check if all fields are validated
        ttpMainMenu.RemoveAll()
        If ValidateOnlyString(txtEditFirstNameEMP.Text, txtEditFirstNameEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtEditSnameEMP.Text, txtEditSnameEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateEmail(txtEditEmailEMP.Text, txtEditEmailEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePhoneNumber(txtEditContactEMP.Text, txtEditContactEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePostcode(txtEditPostcodeEMP.Text, txtEditPostcodeEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtEditCityEMP.Text, txtEditCityEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtEditHouseNoEMP.Text, txtEditHouseNoEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtEditStreetEMP.Text, txtEditStreetEMP, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        'Validate all the fields
        If ValidateCheck = True Then
            'If all data entered is valid
            With employeedata(empUserNo)
                .Firstname = txtEditFirstNameEMP.Text
                .Surname = txtEditSnameEMP.Text
                .dob = dbxEditDOBEMP.Text
                .email = txtEditEmailEMP.Text
                .phone = txtEditContactEMP.Text
                .HouseNo = txtEditHouseNoEMP.Text
                .Street = txtEditStreetEMP.Text
                .City = txtEditCityEMP.Text
                .postcode = txtEditPostcodeEMP.Text
                'Store the values of the text boxes/combo boxes in the structure
                SaveEmployeeDetails()
                'Save the data in the file
            End With
            'Reset the values in the text boxes and combo boxes
        End If
        customMsgBox("Record Updated")
        For Each box As Control In pnlViewEmployee.Controls
            If TypeOf box Is TextBox Then
                box.ResetText()
            End If
        Next
        btnUpdateEMP.Enabled = False
        btnDeleteEMP.Enabled = False
    End Sub
    Private Sub txtSearchEmp_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchEmp.TextChanged
        'When the text in the search bar is changed
        For Each box As Control In pnlViewEmployee.Controls
            If TypeOf box Is TextBox Then
                If box Is txtSearchEmp Then
                Else
                    box.ResetText()
                End If
            End If
        Next
        'Reset the values in the text boxes and combo boxes
    End Sub
    Private Sub pnlViewEmployee_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlViewEmployee.VisibleChanged
        'The visibility of the View Employee Panel is changed
        If pnlViewEmployee.Visible = True Then
            'when the View Employee panel is shown
            txtEditFirstNameEMP.Enabled = False
            txtEditSnameEMP.Enabled = False
            dbxEditDOBEMP.Enabled = False
            txtEditEmailEMP.Enabled = False
            txtEditContactEMP.Enabled = False
            txtEditHouseNoEMP.Enabled = False
            txtEditStreetEMP.Enabled = False
            txtEditCityEMP.Enabled = False
            txtEditPostcodeEMP.Enabled = False
            'Disable the text boxes and combo boxes
        ElseIf pnlViewEmployee.Visible = False Then
            If panelvisibilitycount <> 0 Then
                For Each box As Control In pnlViewEmployee.Controls
                    If TypeOf box Is TextBox Then
                        box.ResetText()
                    End If
                Next
            End If
            btnUpdateEMP.Enabled = False
            btnDeleteEMP.Enabled = False
        End If
    End Sub
    Private Sub btnDeleteEMP_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteEMP.Click
        'When Delete Record button is clicked
        Dim answer As Boolean = MsgBoxYESNO("Are you sure you want to delete this record?")
        'Display a message box with the message above
        If answer = True Then
            'if "YES" is chosen
            employeedata(empUserNo) = Nothing
            'delete the record
            SaveEmployeeDetails()
            'update the file
            customMsgBox("Record Deleted")
            For Each box As Control In pnlViewEmployee.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            btnUpdateEMP.Enabled = False
            btnDeleteEMP.Enabled = False
        End If

        'Reset the values in the text boxes and combo boxes
    End Sub
    Private Sub btnSearchEMPEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchEMPEdit.Click
        Dim ValidateCheck As Boolean = True 'To check if all fields are validated
        If ValidateID(txtSearchEmp.Text, txtSearchEmp, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateCheck = True Then
            'When the Search button is clicked
            empUserNo = 0
            'set the found record number to 0
            Dim searchid As Integer = Val(txtSearchEmp.Text)
            'the value from the text box as an integer
            For i As Integer = 1 To empRecNo
                'go through all records
                If searchid = employeedata(i).empID Then
                    'if the record with the ID searched for is found
                    empUserNo = i
                    'determines the record number of the found record
                    Exit For
                    'stop the search
                End If
            Next
            If empUserNo > 0 Then
                'if a record was found
                With employeedata(empUserNo)
                    txtEditFirstNameEMP.Text = .Firstname
                    txtEditSnameEMP.Text = .Surname
                    dbxEditDOBEMP.Text = .dob
                    txtEditEmailEMP.Text = .email
                    txtEditContactEMP.Text = .phone
                    txtEditHouseNoEMP.Text = .HouseNo
                    txtEditStreetEMP.Text = .Street
                    txtEditCityEMP.Text = .City
                    txtEditPostcodeEMP.Text = .postcode
                    'display the data of the found record in the text boxes and combo boxes
                End With
                btnUpdateEMP.Enabled = True
                btnDeleteEMP.Enabled = True
            Else
                'If no records was found
                customMsgBox("ID DOESN'T EXIST")
                'display message 
                btnUpdateEMP.Enabled = False
                btnDeleteEMP.Enabled = False
            End If
        End If
    End Sub

    'PANEL ADD NEW CAR'

    Private Sub btnSaveCarDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCarDetails.Click
        'When Save button is clicked
        Dim ValidateCheck As Boolean = True 'to check if all text boxes are validated
        Dim combovalidate As Boolean = True 'to check if all combo boxes are validated
        ttpMainMenu.RemoveAll()
        If ValidateREG(txtADDRegNumber.Text, txtADDRegNumber, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtADDCarName.Text, txtADDCarName, ttpMainMenu) = False Then
            ValidateCheck = False
        End If

        For Each ctrl In pnlAddNewCar.Controls
            If (ctrl.GetType() Is GetType(ComboBox)) Then
                Dim cbobx As ComboBox = CType(ctrl, ComboBox)
                If cbobx.SelectedIndex = -1 Then
                    combovalidate = False
                End If
            End If
        Next

        If ValidateCheck = True Then
            If combovalidate = True Then
                'If all data fields are valid
                LoadCarData()
                'to stop the loop
                carRecNo += 1
                'new record
                With cardata(carRecNo)
                    .CarMake = cmbADDCarMake.Text
                    .CarModel = txtADDCarName.Text
                    .CarReg = txtADDRegNumber.Text
                    .CarColour = cmbADDColour.Text
                    .EngineSize = cmbADDEngine.Text
                    .FuelType = cmbADDFuel.Text
                    .CarClass = cmbADDCarClass.Text
                    .CarSeat = cmbADDCarSeat.Text
                    .CarDoor = cmbADDCarDoor.Text
                    .Hired = "False"
                    'store the data in text/combo boxes in the structure
                End With
                SaveCarDetails()
                'Save the record in the file

                'to stop the loop after adding the record
                customMsgBox("SAVED")

                'Reset the values in the text/combo boxes

                CreateStockFile()
                'Update the car stock file
                For Each box In pnlAddNewCar.Controls
                    If (box.GetType() Is GetType(ComboBox)) Then
                        Dim combox As ComboBox = CType(box, ComboBox)
                        combox.SelectedIndex = -1
                    End If
                    If (box.GetType() Is GetType(TextBox)) Then
                        Dim tbox As TextBox = CType(box, TextBox)
                        tbox.ResetText()
                    End If
                Next
            Else
                ErrorMsgBox("All fields are mandatory")
            End If
        End If
    End Sub
    Private Sub pnlAddNewCar_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlAddNewCar.VisibleChanged
        'When visibility of the Add new car panel is changed
        If pnlAddNewCar.Visible = True Then
            'When it is shown
            cmbADDCarMake.SelectedIndex = -1
            cmbADDColour.SelectedIndex = -1
            cmbADDEngine.SelectedIndex = -1
            cmbADDFuel.SelectedIndex = -1
            cmbADDCarClass.SelectedIndex = -1
            cmbADDCarSeat.SelectedIndex = -1
            cmbADDCarDoor.SelectedIndex = -1
            txtADDCarName.ResetText()
            txtADDRegNumber.ResetText()
            'Reset all the text boxes adn combo boxes
        End If
    End Sub

    'PANEL MANAGE PRICES'

    Private Sub pnlManagePrices_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlManagePrices.VisibleChanged
        'When Manage Prices panel is shown
        For count As Integer = 1 To priceRecNo
            'Go through all records and add appropriate price to appropriate car class
            With pricesdata(count)
                If .type = "Class A / Mini" Then
                    txtA.Text = Format(.price, "0.00")
                ElseIf .type = "Class B / Economy" Then
                    txtB.Text = Format(.price, "0.00")
                ElseIf .type = "Class C / Small Compact" Then
                    txtC.Text = Format(.price, "0.00")
                ElseIf .type = "Class D / Large Compact" Then
                    txtD.Text = Format(.price, "0.00")
                ElseIf .type = "Class E / Intermediate" Then
                    txtE.Text = Format(.price, "0.00")
                ElseIf .type = "Class F / Standard" Then
                    txtF.Text = Format(.price, "0.00")
                ElseIf .type = "MPV" Then
                    txtMPV.Text = Format(.price, "0.00")
                ElseIf .type = "Small Premium" Then
                    txtSPrem.Text = Format(.price, "0.00")
                ElseIf .type = "Medium Premium" Then
                    txtMPrem.Text = Format(.price, "0.00")
                ElseIf .type = "Small 4X4" Then
                    txtS4x4.Text = Format(.price, "0.00")
                ElseIf .type = "Large 4X4" Then
                    txtL4x4.Text = Format(.price, "0.00")
                ElseIf .type = "Minibus 9 seats" Then
                    txtMinibus.Text = Format(.price, "0.00")
                ElseIf .type = "Mini Van" Then
                    txtMiniVan.Text = Format(.price, "0.00")
                ElseIf .type = "Medium Van" Then
                    txtMedVan.Text = Format(.price, "0.00")
                ElseIf .type = "Large Van" Then
                    txtLargeVan.Text = Format(.price, "0.00")
                ElseIf .type = "Fine" Then
                    txtFinePrice.Text = Format(.price, "0.00")
                End If
            End With
        Next
    End Sub
    Private Sub btnUpdatePrices_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdatePrices.Click
        Dim ValidateCheck As Boolean = True 'to determine if all data entered is validated
        For Each ctrl In pnlManagePrices.Controls
            'Look for each control on the panel
            If ctrl.GetType() Is GetType(TextBox) Then
                'If the control is a text box
                Dim txtbx As TextBox = CType(ctrl, TextBox)
                If ValidatePrice(txtbx.Text, txtbx, ttpMainMenu) = False Then
                    'If validation is failed
                    ValidateCheck = False
                End If
            End If
        Next
        If ValidateCheck = True Then
            'If all data is valid
            ClearPriceFile()
            'Empty the price file
            priceRecNo = 0
            'no records
            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtA.Text)
            pricesdata(priceRecNo).type = "Class A / Mini"
            'add record with new price
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtB.Text)
            pricesdata(priceRecNo).type = "Class B / Economy"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtC.Text)
            pricesdata(priceRecNo).type = "Class C / Small Compact"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtD.Text)
            pricesdata(priceRecNo).type = "Class D / Large Compact"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtE.Text)
            pricesdata(priceRecNo).type = "Class E / Intermediate"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtF.Text)
            pricesdata(priceRecNo).type = "Class F / Standard"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtMPV.Text)
            pricesdata(priceRecNo).type = "MPV"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtSPrem.Text)
            pricesdata(priceRecNo).type = "Small Premium"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtMPrem.Text)
            pricesdata(priceRecNo).type = "Medium Premium"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtS4x4.Text)
            pricesdata(priceRecNo).type = "Small 4X4"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtL4x4.Text)
            pricesdata(priceRecNo).type = "Large 4X4"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtMinibus.Text)
            pricesdata(priceRecNo).type = "Minibus 9 seats"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtMiniVan.Text)
            pricesdata(priceRecNo).type = "Mini Van"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtMedVan.Text)
            pricesdata(priceRecNo).type = "Medium Van"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtLargeVan.Text)
            pricesdata(priceRecNo).type = "Large Van"
            SavePricesDetails()

            priceRecNo += 1
            pricesdata(priceRecNo).price = Val(txtFinePrice.Text)
            pricesdata(priceRecNo).type = "Fine"
            SavePricesDetails()

            customMsgBox("Prices Updated")
            'add records with new prices in the text boxes for each type and save it into the file
        End If
    End Sub

    'PANEL ADD CUSTOMER DETAILS'

    Private Sub pnlAddCustomer_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlAddCustomer.VisibleChanged
        'When the visibility of the AddCustomer Panel is changed
        If pnlAddCustomer.Visible = True Then
            'if the panel is visible
            txtAddCustFirstName.Enabled = False
            txtAddCustSName.Enabled = False
            dbxAddCustDOB.Enabled = False
            txtAddCustLicense.Enabled = False
            txtAddCustEmail.Enabled = False
            txtAddCustContact.Enabled = False
            txtAddCustHouseNo.Enabled = False
            txtAddCustStreet.Enabled = False
            txtAddCustCity.Enabled = False
            txtAddCustPostcode.Enabled = False
            btnSaveCustomerDetails.Enabled = False
            'Disable text boxes and combo boxes
        ElseIf pnlAddCustomer.Visible = False Then
            For Each box As Control In pnlAddCustomer.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            lblCustomerID.ResetText()
        End If
    End Sub
    Private Sub btnStartAddNewCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnStartAddNewCustomer.Click
        'When Begin button is clicked
        btnSaveCustomerDetails.Enabled = True
        btnStartAddNewCustomer.Enabled = False
        custMax = custMax + 1
        'New unique customer ID 
        lblCustomerID.Text = custMax.ToString
        'display the generated ID
        txtAddCustFirstName.Enabled = True
        txtAddCustSName.Enabled = True
        dbxAddCustDOB.Enabled = True
        txtAddCustLicense.Enabled = True
        txtAddCustEmail.Enabled = True
        txtAddCustContact.Enabled = True
        txtAddCustHouseNo.Enabled = True
        txtAddCustStreet.Enabled = True
        txtAddCustCity.Enabled = True
        txtAddCustPostcode.Enabled = True
        'Enable all text boxes/combo boxes
    End Sub
    Private Sub btnSaveCustomerDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCustomerDetails.Click
        'When Save button is clicked
        Dim ValidateCheck As Boolean = True 'to determine if the data entered is valid
        ttpMainMenu.RemoveAll()
        If ValidateOnlyString(txtAddCustFirstName.Text, txtAddCustFirstName, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtAddCustSName.Text, txtAddCustSName, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateEmail(txtAddCustEmail.Text, txtAddCustEmail, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePhoneNumber(txtAddCustContact.Text, txtAddCustContact, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtAddCustHouseNo.Text, txtAddCustHouseNo, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtAddCustStreet.Text, txtAddCustStreet, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtAddCustCity.Text, txtAddCustCity, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePostcode(txtAddCustPostcode.Text, txtAddCustPostcode, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateLicense(txtAddCustLicense.Text, txtAddCustLicense, ttpMainMenu) = False Then
            ValidateCheck = False
        End If

        If ValidateCheck = True Then
            'If all data entered is valid
            Dim enddo As Boolean = False
            'To stop the loop
            Do
                custRecNo += 1
                'new record
                With customerdata(custRecNo)
                    .custID = custMax
                    .Firstname = txtAddCustFirstName.Text
                    .Surname = txtAddCustSName.Text
                    .dob = dbxAddCustDOB.Text
                    .email = txtAddCustEmail.Text
                    .phone = txtAddCustContact.Text
                    .HouseNo = txtAddCustHouseNo.Text
                    .Street = txtAddCustStreet.Text
                    .City = txtAddCustCity.Text
                    .postcode = txtAddCustPostcode.Text
                    .licenseNo = txtAddCustLicense.Text
                    'store the values from the text boxes/combo boxes in the structure
                End With
                SaveCustomerDetails()
                'Save the new customer in file
                customMsgBox("SAVED")
                'Display Message box
                enddo = True
            Loop Until enddo = True
            'Reset the values of the 
            txtAddCustFirstName.Enabled = False
            txtAddCustSName.Enabled = False
            dbxAddCustDOB.Enabled = False
            txtAddCustLicense.Enabled = False
            txtAddCustEmail.Enabled = False
            txtAddCustContact.Enabled = False
            txtAddCustHouseNo.Enabled = False
            txtAddCustStreet.Enabled = False
            txtAddCustCity.Enabled = False
            txtAddCustPostcode.Enabled = False
            btnStartAddNewCustomer.Enabled = True
            btnSaveCustomerDetails.Enabled = False
            For Each box As Control In pnlAddCustomer.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            'disable all text boxes/combo boxes
        End If
    End Sub

    'PANEL VIEW/EDIT CUSTOMER DETAILS'

    Private Sub pnlViewCustomer_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlViewCustomer.VisibleChanged
        'When visibility of the View Customer Panel is changes
        If pnlViewCustomer.Visible = True Then
            txtEditcustFirstName.Enabled = False
            txtEditCustSurname.Enabled = False
            dbxViewCustDOB.Enabled = False
            txtEditCustEmail.Enabled = False
            txtEditCustContact.Enabled = False
            txtEditCustHouseNo.Enabled = False
            txtEditCustStreet.Enabled = False
            txtEditCustCity.Enabled = False
            txtEditCustPostcode.Enabled = False
            txtEditCustLicense.Enabled = False
            'If panel is visible then disable the text boxes/combo boxes
        ElseIf pnlAddCustomer.Visible = False Then
            For Each box As Control In pnlAddCustomer.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            btnUpdateCustDetails.Enabled = False
            btnDeleteCust.Enabled = False
        End If
    End Sub
    Private Sub btnUpdateCustDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdateCustDetails.Click
        'When Save Changes button is clicked
        Dim ValidateCheck As Boolean = True 'to determine if all data entered is validated
        ttpMainMenu.RemoveAll()
        If ValidateOnlyString(txtEditcustFirstName.Text, txtEditcustFirstName, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtEditCustSurname.Text, txtEditCustSurname, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateEmail(txtEditCustEmail.Text, txtEditCustEmail, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePhoneNumber(txtEditCustContact.Text, txtEditCustContact, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtEditCustHouseNo.Text, txtEditCustHouseNo, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateNoSymbols(txtEditCustStreet.Text, txtEditCustStreet, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateOnlyString(txtEditCustCity.Text, txtEditCustCity, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidatePostcode(txtEditCustPostcode.Text, txtEditCustPostcode, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateLicense(txtEditCustLicense.Text, txtEditCustLicense, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateCheck = True Then
            'If all data entered is valid
            With customerdata(custUserNo)
                .Firstname = txtEditcustFirstName.Text
                .Surname = txtEditCustSurname.Text
                .dob = dbxViewCustDOB.Text
                .email = txtEditCustEmail.Text
                .phone = txtEditCustContact.Text
                .HouseNo = txtEditCustHouseNo.Text
                .Street = txtEditCustStreet.Text
                .City = txtEditCustCity.Text
                .postcode = txtEditCustPostcode.Text
                .licenseNo = txtEditCustLicense.Text
                'store the values of the text/combo boxes in the structure
                SaveCustomerDetails()
                'Save the updated record in the file
            End With
            txtEditcustFirstName.Enabled = False
            txtEditCustSurname.Enabled = False
            dbxViewCustDOB.Enabled = False
            txtEditCustEmail.Enabled = False
            txtEditCustContact.Enabled = False
            txtEditCustHouseNo.Enabled = False
            txtEditCustStreet.Enabled = False
            txtEditCustCity.Enabled = False
            txtEditCustPostcode.Enabled = False
            txtEditCustLicense.Enabled = False
            For Each box As Control In pnlViewCustomer.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            'Reset values in the text/combo boxes
            customMsgBox("Record updated")
            btnUpdateCustDetails.Enabled = False
            btnDeleteCust.Enabled = False
        End If
    End Sub
    Private Sub btnViewCustSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnViewCustSearch.Click
        'When Search button is clicked
        Dim ValidateCheck As Boolean = True 'to determine if all data entered is validated
        If ValidateID(txtViewSearchCustID.Text, txtViewSearchCustID, ttpMainMenu) = False Then
            ValidateCheck = False
        End If
        If ValidateCheck = True Then
            'If all data entered is valid
            custUserNo = 0
            Dim searchid As Integer = Val(txtViewSearchCustID.Text)
            'To search for the value of the text enetered in the text box
            For i As Integer = 1 To custRecNo
                'go through all records
                If searchid = customerdata(i).custID Then
                    'if the record searched for is found
                    custUserNo = i
                    'store the record number of the searched record
                    Exit For
                    'Stop the search
                End If
            Next
            If custUserNo > 0 Then
                'If a record was found
                With customerdata(custUserNo)
                    txtEditcustFirstName.Text = .Firstname
                    txtEditCustSurname.Text = .Surname
                    dbxViewCustDOB.Text = .dob
                    txtEditCustEmail.Text = .email
                    txtEditCustContact.Text = .phone
                    txtEditCustHouseNo.Text = .HouseNo
                    txtEditCustStreet.Text = .Street
                    txtEditCustCity.Text = .City
                    txtEditCustPostcode.Text = .postcode
                    txtEditCustLicense.Text = .licenseNo
                    'display all the fields in the appropriate text boxes
                End With
                btnUpdateCustDetails.Enabled = True
                btnDeleteCust.Enabled = True
            Else
                'If record not found
                customMsgBox("ID DOESN'T EXIST")
                'Display Message Box
                btnUpdateCustDetails.Enabled = False
                btnDeleteCust.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnDeleteCust_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteCust.Click
        'when the Delete Record button is clicked
        Dim answer As Boolean = MsgBoxYESNO("Are you sure you want to delete this record?")
        'Display a Yes No confirm delete Message box
        If answer = True Then
            'If YES is clicked
            customerdata(custUserNo) = Nothing
            'Delete the record
            SaveCustomerDetails()
            'Update the file
            For Each box As Control In pnlViewCustomer.Controls
                If TypeOf box Is TextBox Then
                    box.ResetText()
                End If
            Next
            btnUpdateCustDetails.Enabled = False
            btnDeleteCust.Enabled = False
        End If
    End Sub
    Private Sub txtViewSearchCustID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtViewSearchCustID.TextChanged
        'When the text in the search bar is changed
        For Each box As Control In pnlAddCustomer.Controls
            If TypeOf box Is TextBox Then
                If box Is txtViewSearchCustID Then
                Else
                    box.ResetText()
                End If
            End If
        Next
        'Reset the values in the text/combo boxes
    End Sub

    Private Sub btnEditCustFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustFirstName.Click
        'To edit the first name
        txtEditcustFirstName.Enabled = True
        'Enable the text box for first name
    End Sub
    Private Sub btnEditCustSurname_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustSurname.Click
        'To edit the Surname
        txtEditCustSurname.Enabled = True
        'Enable the text box for surname
    End Sub
    Private Sub btnEditCustDOB_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustDOB.Click
        'To edit the Date of birth      
        dbxViewCustDOB.Enabled = True
        'Enable the date picker
    End Sub
    Private Sub btnEditCustEmail_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustEmail.Click
        'To edit the Email                  
        txtEditCustEmail.Enabled = True
        'Enable the email text box  
    End Sub
    Private Sub btnEditCustContact_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustContact.Click
        'To edit the Contact number
        txtEditCustContact.Enabled = True
        'Enable the Contact number text box
    End Sub
    Private Sub btnEditCustHouseNo_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustHouseNo.Click
        'To edit the house number               
        txtEditCustHouseNo.Enabled = True
        'Enable the House No text box
    End Sub
    Private Sub btnEditCustStreet_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustStreet.Click
        'To edit the Street Name                
        txtEditCustStreet.Enabled = True
        'Enable the Street Name text box        
    End Sub
    Private Sub btnEditCustCity_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustCity.Click
        'To edit the City/Town              
        txtEditCustCity.Enabled = True
        'Enable the City/Town text box
    End Sub
    Private Sub btnEditCustPostcode_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustPostcode.Click
        'To edit the postcode
        txtEditCustPostcode.Enabled = True
        'Enable the Postcode text box
    End Sub
    Private Sub btnEditCustLicense_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustLicense.Click
        'To edit the license number
        txtEditCustLicense.Enabled = True
        'Enable the License number text box
    End Sub

    'PANEL NEW ORDER'

    Private Sub pnlNewOrder_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlNewOrder.VisibleChanged
        'When the visibility of the New Order Panel is changed
        If pnlNewOrder.Visible = True Then
            If ComingFromReview = True Then
                ComingFromReview = False
            Else
                ComingFromReview = False
                'If panel is visible
                LoadPriceData()
                'load all the price data
                cmbNewOrderChooseCar.Enabled = False
                cmbNewOrderChooseCar.SelectedIndex = -1
                cmbNewOrderChooseClass.SelectedIndex = -1
                txtNewOrderCarInfo.ResetText()
                txtNewOrderCustomerInfo.ResetText()
                txtNewOrderSearchID.ResetText()
                'Disable the date pickers and combo box to choose car
            End If

        End If
    End Sub
    Private Function ClassModelSearch(ByVal selectedclass As String)
        'Function to search for all cars of a particular class
        Dim listcar As New List(Of String)
        'A list of all the cars of that particular class
        For count As Integer = 1 To StockRecNo
            'Look through all the stock records
            If carstockdata(count).CarClass = selectedclass Then
                'if a car with the chosen class is found
                listcar.Add(carstockdata(count).CarModel)
                'Add the found car to the list
                'MsgBox("YES")
            End If
        Next
        Return listcar.ToArray
        'Return the list of cars found as an array
    End Function
    Private Sub cmbNewOrderChooseClass_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNewOrderChooseClass.SelectedIndexChanged
        'When the chosen class on the Choose Class combo box is changed
        cmbNewOrderChooseCar.Items.Clear()
        cmbNewOrderChooseCar.SelectedIndex = -1
        'Clear the items in the Choose Car combo box and reset it
        Dim selectedClass As String = cmbNewOrderChooseClass.Text
        'the class chosen from the Choose Class combo box as a variable
        cmbNewOrderChooseCar.Enabled = True
        dbxNewOrderHireFrom.Enabled = True
        dbxNewOrderHireTill.Enabled = True
        'Enable the date pickers
        Dim array = ClassModelSearch(selectedClass)
        cmbNewOrderChooseCar.Items.AddRange(array)
        'Add the found cars from the function into the combo box for Choose Car
        CalculatePrice()
        'Calculate the price of that car
    End Sub
    Private Sub btnNewOrderSearchCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnNewOrderSearchCustomer.Click
        Dim validatecheck As Boolean = True
        If ValidateID(txtNewOrderSearchID.Text, txtNewOrderSearchID, ttpMainMenu) = False Then
            validatecheck = False
        End If
        If validatecheck = True Then
            'When the search button is clicked
            Dim searchID As String = txtNewOrderSearchID.Text
            'The value of the customer ID entered in the search box
            NewOrderfoundCust = 0
            'to determine the record number of the found record
            txtNewOrderCustomerInfo.Clear()
            'Clear the customer info text box
            For counter As Integer = 1 To custRecNo
                'Look through all the records
                If searchID = customerdata(counter).custID Then
                    'Id the searched ID is found
                    NewOrderfoundCust = counter
                    'Store the record number of the found record
                    Exit For
                    'stop the search
                End If
            Next
            If NewOrderfoundCust > 0 Then
                'if a record was found
                txtNewOrderCustomerInfo.Text = "ID: " & customerdata(NewOrderfoundCust).custID & "   " & customerdata(NewOrderfoundCust).Firstname & "  " & customerdata(NewOrderfoundCust).Surname
                'display the customer's information in the text box
                custemailaddress = customerdata(NewOrderfoundCust).email
                'store their email address in the variable to send email confirmation later
            Else
                'If no record was found
                ErrorMsgBox("Customer doesnt exist")
                'Display message box
            End If
        End If
    End Sub
    Private Sub btnNewOrderAvailability_Click(sender As System.Object, e As System.EventArgs) Handles btnNewOrderAvailability.Click
        'When Check Availability of the car is clicked
        txtNewOrderCarInfo.Clear()
        'Clear the car information from the text box
        Dim availRecNo = CheckAvailaility(cmbNewOrderChooseCar.Text, CDate(dbxNewOrderHireFrom.Text), CDate(dbxNewOrderHireTill.Text))
        'Load the car data
        If availRecNo > 0 Then
            orderCarMake = cardata(availRecNo).CarMake
            orderCarReg = cardata(availRecNo).CarReg
            orderCarModel = cardata(availRecNo).CarModel
            orderColour = cardata(availRecNo).CarColour
            'Store the values of Car Make, Colour, Model and REG in variables
            txtNewOrderCarInfo.Text = "REG No. " & orderCarReg & "  " & orderCarMake & "  " & orderCarModel & "  " & orderColour
        Else
            customMsgBox("No " & cmbNewOrderChooseCar.Text & " Available")
        End If

    End Sub
    Sub CalculatePrice()
        LoadPriceData()
        'To calculate the price of the order
        Dim searchtype As String = cmbNewOrderChooseClass.Text
        'Store the value of the chosen class from combo box
        Dim findType As Integer = 0
        'Determine the record number of the found record
        For counter As Integer = 1 To priceRecNo
            'Look through the price file
            If searchtype = pricesdata(counter).type Then
                'If a record with the class chosen is found
                findType = counter
                'Store the record number of the found record
                Exit For
                'stop search
            End If
        Next
        PricePerDay = pricesdata(findType).price
        'The price per day of the class found
        Dim d1 As Date = Convert.ToDateTime(dbxNewOrderHireFrom.Text)
        'Hire from date from date picker converted to type Date
        Dim d2 As Date = Convert.ToDateTime(dbxNewOrderHireTill.Text)
        'Hire till date from date picker converted to type Date
        Dim duration As TimeSpan = d2.Subtract(d1)
        'Find the number of days the customer is wanting to hire
        If chkNewOrderInsurance.Checked = True Then
            'If they have chosen to buy insurance
            orderPriceNOVAT = PricePerDay * Convert.ToInt32(duration.Days) + 15
            'find the price of the order without VAT and add £15 of insurance
        Else
            'if insurance not picked
            orderPriceNOVAT = PricePerDay * Convert.ToInt32(duration.Days)
            'calculate the price of the order without VAT
        End If
        orderPriceINCVAT = orderPriceNOVAT + (VAT * orderPriceNOVAT)
        'calculate the total price including the VAT
        lblNewOrderPriceNOVAT.Text = "£ " & Format(orderPriceNOVAT, "0.00") & " (exc. VAT)"
        lblNewOrderPriceINCVAT.Text = "£ " & Format(orderPriceINCVAT, "0.00")
        'Display the price totals with and without VAT on labels in the format "£0.00"
    End Sub
    Private Sub chkNewOrderInsurance_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNewOrderInsurance.CheckedChanged
        'If the the insurance check box is checked or unchecked
        CalculatePrice()
        'recalculate the price
    End Sub
    Private Sub dbxNewOrderHireFrom_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dbxNewOrderHireFrom.ValueChanged
        'If the Hire from date is changed in the date picker
        CalculatePrice()
        'recalculate the order price
    End Sub
    Private Sub dbxNewOrderHireTill_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dbxNewOrderHireTill.ValueChanged
        'If the Hire till date is changed from the date picker
        CalculatePrice()
        'recalculate price
    End Sub
    Private Sub btnNewOrderReview_Click(sender As System.Object, e As System.EventArgs) Handles btnNewOrderReview.Click
        'If Review Order Button on New Order Panel is clicked
        Dim flag As Boolean = False
        If cmbNewOrderChooseClass.SelectedIndex <> -1 Then
            If cmbNewOrderChooseCar.SelectedIndex <> -1 Then
                If txtNewOrderCarInfo.Text <> "" Then
                    If txtNewOrderCustomerInfo.Text <> "" Then
                        flag = True
                    End If
                End If
            End If
        End If
        If flag = True Then
            frmReviewOrder.Show()
            'Show the Review order form
            Me.Hide()
            'Hide the Main Menu form
        Else
            ErrorMsgBox("Please fill in all details")
        End If

    End Sub
    Private Sub btnCancelOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelOrder.Click
        Me.Hide()
        frmCancelOrder.Show()
    End Sub

    'HOME SCREEN PANEL'

    Private Sub pnlHomeScreen_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlHomeScreen.VisibleChanged
        'When the visibility of the the Home Screen panel us changed
        lblLoggedInEmp.Text = employeedata(empUserNo).Firstname & " " & employeedata(empUserNo).Surname & " (ID: " & employeedata(empUserNo).empID & ")"
        'Display welcome message with the logged in employee details
    End Sub
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnNavLOGOUT.Click
        'When the log out button is clicked
        Dim answer = MsgBoxYESNO("Are you sure you want to log out?")
        If answer = True Then
            Me.Close()
            'Close the Main menu form
            frmLogin.Show()
            'Show the login form
        Else
        End If
    End Sub
    Private Sub lblChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles lblChangePassword.Click
        Me.Close()
        frmChangePassword.Show()
    End Sub

    'PANEL RETURN CAR'

    Private Sub pnlReturnCar_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlReturnCar.VisibleChanged
        'If the visibility of the return Return Car panel is changed
        If pnlReturnCar.Visible = True Then
            'If the panel is visible
            LoadOrderData()
            LoadCarData()
            'Load all car data and order data
            btnReturn.Enabled = False
            'Disable the Return Car button
            lblCarinfo.Visible = False
            lblCarReg.Visible = False
            lblHired.Visible = False
            lblHiredFrom.Visible = False
            lblHiredTo.Visible = False
            lblTO.Visible = False
            lblFROM.Visible = False
            lblHiredsbttl.Visible = False
            lblReturnCarREG.Visible = False
            lblReturnCarCAR.Visible = False
            txtSearchREG.ResetText()
            'Hide all the labels
        End If
    End Sub
    Private Sub txtSearchREG_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchREG.TextChanged
        'If the text in the search box is changed
        btnReturn.Enabled = False
        lblCarinfo.Visible = False
        lblCarReg.Visible = False
        lblHired.Visible = False
        lblHiredFrom.Visible = False
        lblHiredTo.Visible = False
        lblTO.Visible = False
        lblFROM.Visible = False
        lblHiredsbttl.Visible = False
        lblReturnCarREG.Visible = False
        lblReturnCarCAR.Visible = False
        'Hide all the labels
        lblCarinfo.ResetText()
        lblCarReg.ResetText()
        lblHired.ResetText()
        lblHiredFrom.ResetText()
        lblHiredTo.ResetText()
        'Reset the label values
    End Sub
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim returnModel As String = ""
        ReturnCarfoundrec = 0
        'Determine the record number of the Car found
        ReturnCarfinddate = 0
        'Determine the record number of the car found for date
        StockFoundRec = 0
        For i As Integer = 1 To carRecNo
            'Look through all car data
            If txtSearchREG.Text = cardata(i).CarReg Then
                'If the searched REG number is found
                returnModel = cardata(i).CarModel
                ReturnCarfoundrec = i
                'Store the record number of the 
                Exit For
                'stop search
            End If
        Next
        If ReturnCarfoundrec > 0 Then
            'If a car is found 
            lblCarinfo.Visible = True
            lblCarReg.Visible = True
            lblHired.Visible = True
            lblHiredsbttl.Visible = True
            lblReturnCarREG.Visible = True
            lblReturnCarCAR.Visible = True
            'Show the labels
            lblCarinfo.Text = cardata(ReturnCarfoundrec).CarMake & " " & cardata(ReturnCarfoundrec).CarModel
            'Display the Car Make and name in the label
            lblCarReg.Text = cardata(ReturnCarfoundrec).CarReg
            'Display the Car Reg in the label
            If cardata(ReturnCarfoundrec).Hired = "True" Then
                'If the car searched for is hired
                lblHired.Text = "YES"
                'Display 'YES'
            Else
                lblHired.Text = "NO"
            End If
        Else
            'If no record was found
            ErrorMsgBox("Invalid Registration number")
            'Display message box
        End If
        If cardata(ReturnCarfoundrec).Hired = "True" Then
            'If the car is Hired already 
            For count As Integer = 1 To orderRecNo
                'Look through all Order data
                If txtSearchREG.Text = orderdata(count).CarREG AndAlso orderdata(count).Returned = "False" Then
                    'If the registration number matches and the the car is not being returned
                    ReturnCarfinddate = count
                    'Store the record number of that order
                    Exit For
                    'stop search
                End If
            Next
            If ReturnCarfinddate > 0 Then
                'If a order is found
                lblHiredFrom.Visible = True
                lblHiredTo.Visible = True
                lblTO.Visible = True
                lblFROM.Visible = True
                'Display the labels with hire dates
                lblHiredFrom.Text = orderdata(ReturnCarfinddate).orderFROM
                lblHiredTo.Text = orderdata(ReturnCarfinddate).orderTO
                btnReturn.Enabled = True
                'display the Hired from and Hired till dates and enable the 'Confirm Return' button
            End If
        End If

        For a As Integer = 1 To StockRecNo
            If carstockdata(a).CarModel = returnModel Then
                StockFoundRec = a
                Exit For
            End If
        Next
    End Sub
    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        'When Confirm Return button is clicked
        Dim answer As Boolean = MsgBoxYESNO("Confirm Return")
        'Display a YES NO messahe box to confirm the return
        If answer = True Then
            'If YES is chosen
            cardata(ReturnCarfoundrec).Hired = "False"
            'update 'HIRED' field of the record to false, the car is not hired
            orderdata(ReturnCarfinddate).Returned = "True"
            'Update the 'RETURNED' field in order file. The car is returned 
            carstockdata(StockFoundRec).Stock += 1
            SaveOrderDetails()
            SaveCarDetails()
            SaveCarStockDetails()
            'Save both order and car details to file.
        Else
            'If NO is chosen
            customMsgBox("OK")
        End If
        LoadOrderData()
        LoadCarData()
        'Reload the updated data
        lblCarinfo.ResetText()
        lblCarReg.ResetText()
        lblHired.ResetText()
        lblHiredFrom.ResetText()
        lblHiredTo.ResetText()
        'Reset the text in the labels
        btnReturn.Enabled = False
        'Disable the Return button
        lblCarinfo.Visible = False
        lblCarReg.Visible = False
        lblHired.Visible = False
        lblHiredFrom.Visible = False
        lblHiredTo.Visible = False
        lblTO.Visible = False
        lblFROM.Visible = False
        lblHiredsbttl.Visible = False
        lblReturnCarREG.Visible = False
        lblReturnCarCAR.Visible = False
        'Hide all the labels
    End Sub

    'X and - buttons'
    Private Sub picClose_Click(sender As System.Object, e As System.EventArgs) Handles picClose.Click
        'The 'X' button to close the main menu
        Dim answer As Boolean = MsgBoxYESNO("You will be logged out" & vbNewLine & "LOG OUT?")
        'Display a YES NO message box to confirm log out
        If answer = True Then
            'If YES is chosen
            Me.Close()
            'Close the Main Menu form
            frmLogin.Show()
            'Open the Login form
        End If
    End Sub
    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click
        'Log Out button on Home Screen
        Dim answer = MsgBoxYESNO("Are you sure you want to log out?")
        If answer = True Then
            Me.Close()
            'Close the Main Menu form
            frmLogin.Show()
            'Open the login form
        End If

    End Sub
    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'PANEL MANAGE STOCK'

    Private Sub btnManageStockRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnManageStockRemove.Click
        'When the Remove button is clicked
        Dim answer = MsgBoxYESNO("Are you sure you want to remove this car from the database?")
        If answer = True Then
            'If YES is chosen on message box
            cardata(managestockfound).CarClass = Nothing
            cardata(managestockfound).CarMake = Nothing
            cardata(managestockfound).CarModel = Nothing
            cardata(managestockfound).CarColour = Nothing
            cardata(managestockfound).CarDoor = Nothing
            cardata(managestockfound).CarReg = Nothing
            cardata(managestockfound).CarSeat = Nothing
            cardata(managestockfound).EngineSize = Nothing
            cardata(managestockfound).FuelType = Nothing
            cardata(managestockfound).Hired = Nothing
            'Remove al fields of that record
            SaveCarDetails()
            'Update the file
            CreateStockFile()
            'Update stockfile
            txtManageStockSearchREG.ResetText()
            lblMngStockCar.Visible = False
            lblMngStockColour.Visible = False
            lblMngStockREG.Visible = False
            lblManageStockCarName.Visible = False
            lblManageStockCarREG.Visible = False
            lblManageStockCOlour.Visible = False
            customMsgBox("Car Removed")
        End If
    End Sub
    Private Sub btnManageStockSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnManageStockSearch.Click
        'When search button is clicked
        LoadCarData()
        managestockfound = 0
        For count As Integer = 1 To carRecNo
            'go through all car records
            If cardata(count).CarReg = txtManageStockSearchREG.Text Then
                'If the car with the searched REG is found
                managestockfound = count
                'store its record number
                Exit For
            End If
        Next
        If managestockfound > 0 Then
            'If a record was found then
            lblManageStockCarName.Text = cardata(managestockfound).CarMake & " " & cardata(managestockfound).CarModel
            lblManageStockCarREG.Text = cardata(managestockfound).CarReg
            lblManageStockCOlour.Text = cardata(managestockfound).CarColour
            btnManageStockRemove.Enabled = True
            lblManageStockCarName.Visible = True
            lblManageStockCarREG.Visible = True
            lblManageStockCOlour.Visible = True
            lblMngStockColour.Visible = True
            lblMngStockREG.Visible = True
            lblMngStockCar.Visible = True
        Else
            customMsgBox("Car doesnt exist")
        End If

    End Sub
    Private Sub pnlManageStock_VisibleChanged(sender As Object, e As System.EventArgs) Handles pnlManageStock.VisibleChanged
        'When the visibility of the Manage Stock Panel is changed
        btnManageStockRemove.Enabled = False
        lblManageStockCarName.Visible = False
        lblManageStockCarREG.Visible = False
        lblManageStockCOlour.Visible = False
        lblMngStockColour.Visible = False
        lblMngStockREG.Visible = False
        lblMngStockCar.Visible = False
        txtManageStockSearchREG.ResetText()
        'Hide all labels
    End Sub

    Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClock.Tick
        'When timer starts
        lblTime.Text = TimeOfDay & "                      |           " & Now.ToLongDateString
        'Display todays date and time
    End Sub
    
End Class

