Public Class frmTodaysOrders

    Dim drag As Boolean  'To drag the form by clicking on the form
    Dim mousex As Integer 'x position of the cursor
    Dim mousey As Integer 'y position of the cursor
    Private Sub frmTodaysOrders_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'When left click on form 
        drag = True
        'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        'Sets variable mousey
    End Sub
    Private Sub frmTodaysOrders_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'When moving the mouse
        If drag = True Then
            'If clicking down on the form
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            'move the form accordingly
        End If
    End Sub
    Private Sub frmTodaysOrders_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
        'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub TodaysOrders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnConfirmCarCollect.Enabled = False
        lstTodaysOrder.Columns.Clear()
        lstTodaysOrder.Items.Clear()
        'Clear the items in the list view
        lstTodaysOrder.Columns.Add("Order No.", 80, HorizontalAlignment.Left)
        lstTodaysOrder.Columns.Add("Customer Name", 150, HorizontalAlignment.Left)
        lstTodaysOrder.Columns.Add("License Number", 150, HorizontalAlignment.Left)
        lstTodaysOrder.Columns.Add("Car Details", 250, HorizontalAlignment.Left)
        lstTodaysOrder.Columns.Add("Return Date", 160, HorizontalAlignment.Left)


        'Add the columns and their formatting in the listview
        Dim columnItem(4) As String 'An aray for columns in the list view
        Dim fullRow As ListViewItem 'Full row containing the 5 columns
        For i As Integer = 1 To orderRecNo
            If orderdata(i).orderFROM = Now.Date Then
                With orderdata(i)
                    columnItem(0) = .OrderNumber
                    columnItem(1) = .custFname & " " & .custSname
                    columnItem(2) = .custLicense
                    columnItem(3) = .CarMake & "•" & .CarModel & "•" & .CarREG & "•" & .CarColour
                    columnItem(4) = .orderTO.ToString
                    'Add the data to appropriate columns on the listview
                    fullRow = New ListViewItem(columnItem)
                    'A full row consisting of all the fields
                    lstTodaysOrder.Items.Add(fullRow)
                End With
            End If
        Next

    End Sub
    Private Sub btnConfirmCarCollect_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmCarCollect.Click
        'When confirm collected is clicked
        Dim answer = MsgBoxYESNO("Confirm car collection?") 'Message box to confirm
        Dim REG As String = "" 'The REG to search
        Dim Model As String = "" 'The model to search
        If answer = True Then
            'If YES chosen
            For Each row As ListViewItem In lstTodaysOrder.SelectedItems
                'Go through each column in the selected item in listview
                Dim ordernum As Integer = lstTodaysOrder.Items(lstTodaysOrder.FocusedItem.Index).SubItems(0).Text 'The found order number
                For a As Integer = 1 To orderRecNo
                    'Go through all the order records
                    If orderdata(a).OrderNumber = ordernum Then
                        'If the order number is found
                        REG = orderdata(a).CarREG
                        Model = orderdata(a).CarModel
                        orderdata(a).Collected = "True"
                        orderdata(a).Returned = "False"
                        'Update the Collected and Returned status 
                        SaveOrderDetails()
                        Exit For
                    End If
                Next
                For b As Integer = 1 To carRecNo
                    'Go through all the car records
                    If cardata(b).CarReg = REG Then
                        'If the car REG is found
                        cardata(b).Hired = "True"
                        'Change the Hired status to True
                        SaveCarDetails()
                        Exit For
                    End If
                Next
                For c As Integer = 1 To StockRecNo
                    'Go through all te stock records
                    If carstockdata(c).CarModel = Model Then
                        'If the car model is found 
                        carstockdata(c).Stock -= 1
                        'Decrease stock number by one
                        SaveCarStockDetails()
                        Exit For
                    End If
                Next
                lstTodaysOrder.Items.Remove(row)
                'Remove record from listview
            Next

        End If
        customMsgBox("DONE!")
    End Sub
   
    Private Sub lstTodaysOrder_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstTodaysOrder.SelectedIndexChanged
        If lstTodaysOrder.SelectedItems.Count > 0 Then
            btnConfirmCarCollect.Enabled = True
        Else
            btnConfirmCarCollect.Enabled = False
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
End Class