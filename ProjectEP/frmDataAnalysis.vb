Imports System.Windows.Forms.DataVisualization.Charting
'IMPORTant - Imports the visualisaton of charts
Public Class frmDataAnalysis
    Dim drag As Boolean 'To drag the form by clicking on the form
    Dim mousex As Integer 'x position of the cursor
    Dim mousey As Integer 'y position of the cursor
    Dim countbtnclick As Integer = 1  'count to determine the number of times clicked on the 'Sales' button in nav bar
    Private Sub frmGraphs_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'When left click on form
        drag = True
        'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        'Sets variable mousey
    End Sub
    Private Sub frmGraphs_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'When moving the mouse
        If drag Then
            'If clicking down on the form
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            'move the form accordingly
        End If
    End Sub
    Private Sub frmGraphs_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
        'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub btnSales_Click(sender As System.Object, e As System.EventArgs) Handles btnSales.Click
        'When the Sales button is clicked
        If countbtnclick Mod 2 = 0 Then
            'If the button is clicked for a multiple of 2 time
            btnSales.BackColor = Color.White
            'Make the button  white
            btnMonthlySales.Visible = False
            btnTypeSales.Visible = False
            btnDailySales.Visible = False
            'Hide the sub buttons under 'Sales'
        Else
            'If clicked for not a multiple of 2 times
            btnSales.BackColor = Color.Chocolate
            'Make the button green
            btnMonthlySales.Visible = True
            btnTypeSales.Visible = True
            btnDailySales.Visible = True
            'Show the sub buttons under Sales button
        End If
        countbtnclick += 1
        'Count the number of times it is clicked
    End Sub
    Private Sub btnStockList_Click(sender As System.Object, e As System.EventArgs) Handles btnStockList.Click
        DisplayPanelGraphs(pnlControlStockList)
        HighlightButton(btnStockList)
        'When the Stock List button is clicked
        btnMonthlySales.Visible = False
        btnTypeSales.Visible = False
        btnDailySales.Visible = False
        'Hide the sub Sales buttons
        chrtDailySales.Hide()
        chrtMonthlySales.Hide()
        chrtCarClassPIE.Hide()
        'Hide all the charts
        lstStockData.Show()
        'Display the ListView box 
        pnlControlCarClassPIE.Hide()
        pnlDataAnalysisHome.Hide()
        'Hide the other Panels for chart control
        LoadStockData()
        'Load the stock data
        lstStockData.Items.Clear()
        lstStockData.Columns.Clear()
        'Clear the listView items
        lstStockData.Columns.Add("Car Class", 250, HorizontalAlignment.Left)
        lstStockData.Columns.Add("Car", 200, HorizontalAlignment.Left)
        lstStockData.Columns.Add("Stock", 60, HorizontalAlignment.Right)
        'Add the Columns for Car Class, Car Name and Stock 
        Dim ColumnItem(2) As String 'An array for the columns in the ListView box
        Dim FullRow As ListViewItem 'a full row containing 3 columns
        For i As Integer = 1 To StockRecNo
            'Look through all Stock Records
            With carstockdata(i)
                ColumnItem(0) = .CarClass
                ColumnItem(1) = .CarMake + " " + .CarModel
                ColumnItem(2) = .Stock.ToString
                'Add the data into the appropriate columns on the listview
                FullRow = New ListViewItem(ColumnItem)
                'A full row consists of the 3 fields
                lstStockData.Items.Add(FullRow)
                'Add the row to the listview
            End With
        Next
    End Sub
    Private Sub btnMonthlySales_Click(sender As System.Object, e As System.EventArgs) Handles btnMonthlySales.Click
        'When the Monthly Sales button is clicked
        HighlightButton(btnMonthlySales)
        pnlControlCarClassPIE.Hide()
        pnlControlDailySales.Hide()
        pnlControlStockList.Hide()
        pnlDataAnalysisHome.Hide()
        chrtMonthlySales.Show()
        'Show the monthly sales chart
        chrtCarClassPIE.Hide()
        lstStockData.Hide()
        chrtDailySales.Hide()
        'Hide other charts and listView
        findMonthlySales()
        'Find the values to plot from the text file
        Dim yValues As Double() = {Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec} 'The values retrieved form the file
        Dim xValues As String() = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"} 'Headings for x axis
        Dim y As Double() = {lJan, lFeb, lMar, lApr, lMay, lJun, lJul, lAug, lSep, lOct, lNov, lDec}
        Dim currentYear As String = Nothing
        Dim lastyear As String = Nothing
        chrtMonthlySales.Series.Clear()
        chrtMonthlySales.Titles.Clear()
        'Clear the chart series and Title
        currentYear = "CURRENT YEAR"
        lastyear = "LAST YEAR"
        'The series names
        chrtMonthlySales.Series.Add(currentYear)
        chrtMonthlySales.Series.Add(lastyear)
        'Add the series to the chart
        chrtMonthlySales.Series(currentYear).Points.DataBindXY(xValues, yValues)
        chrtMonthlySales.Series(lastyear).Points.DataBindXY(xValues, y)
        'Add the x and y values to the series of the chart
        chrtMonthlySales.ChartAreas("ChartArea1").AxisY.LineColor = Color.White
        chrtMonthlySales.ChartAreas("ChartArea1").AxisX.LineColor = Color.White
        'set the chart axis colour to white
        chrtMonthlySales.Series(currentYear).ChartType = SeriesChartType.Line
        chrtMonthlySales.Series(lastyear).ChartType = SeriesChartType.Line
        'set the chart to be a line chart
        chrtMonthlySales.ChartAreas("ChartArea1").BackColor = Color.FromArgb(52, 52, 52)
        'Set the back color of the chart to Dark Grey/black
        chrtMonthlySales.ChartAreas("ChartArea1").AxisX.LabelStyle.ForeColor = Color.FromArgb(0, 166, 100)
        chrtMonthlySales.ChartAreas("ChartArea1").AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 166, 100)
        'Set the axis label colours to green
        chrtMonthlySales.ChartAreas("ChartArea1").AxisX.LabelStyle.Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        chrtMonthlySales.ChartAreas("ChartArea1").AxisY.LabelStyle.Font = New Font("Century Gothic", 10.0F, FontStyle.Regular)
        'Font formatting of the axis labels
        chrtMonthlySales.Series(currentYear).BorderWidth = 3
        chrtMonthlySales.Series(lastyear).BorderWidth = 3
        'Set the line thickness of the chart
        Dim T As Title = chrtMonthlySales.Titles.Add("Sales")
        'The title of the chart - "Sales"
        With T
            'Format the Title
            .ForeColor = Color.White
            .BackColor = Color.FromArgb(0, 166, 100)
            .Font = New Font("Century Gothic", 12.0F, FontStyle.Regular)
            .BorderColor = Color.White
        End With

        chrtMonthlySales.Legends(0).Enabled = True
        'show Chart Legends
        chrtMonthlySales.Series(currentYear).IsValueShownAsLabel = True
        chrtMonthlySales.Series(lastyear).IsValueShownAsLabel = True
        'Show labels on the data points
        chrtMonthlySales.Series(currentYear).LabelForeColor = Color.Goldenrod
        chrtMonthlySales.Series(lastyear).LabelForeColor = Color.DodgerBlue
        chrtMonthlySales.Series(currentYear).Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        chrtMonthlySales.Series(lastyear).Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        'Format the color and fonts of the data point labels
        chrtMonthlySales.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.Gray
        chrtMonthlySales.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.Gray
        'The color of the grid lines on the chart
        chrtMonthlySales.ChartAreas("ChartArea1").AxisY.MajorTickMark.LineColor = Color.Gray
        chrtMonthlySales.ChartAreas("ChartArea1").AxisX.MajorTickMark.LineColor = Color.Gray
        'The color of the marks on the axis
        chrtMonthlySales.Legends(0).BackColor = Color.FromArgb(52, 52, 52)
        chrtMonthlySales.Legends(0).ForeColor = Color.White
        chrtMonthlySales.Legends(0).Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        'Format the colour and fonts of the legends of the chart
        chrtMonthlySales.Series(0).Color = Color.Goldenrod
        chrtMonthlySales.Series(1).Color = Color.DodgerBlue
        'Set the colours of both the lines on the chart

    End Sub
    Private Sub btnTypeSales_Click(sender As System.Object, e As System.EventArgs) Handles btnTypeSales.Click
        'When the Sales by Type is clicked
        DisplayPanelGraphs(pnlControlCarClassPIE)
        HighlightButton(btnTypeSales)
        chrtCarClassPIE.Hide()
        'Show the Pie Chart
        chrtMonthlySales.Hide()
        chrtDailySales.Hide()
        lstStockData.Hide()
        'Hide all other charts
       
    End Sub
    Private Sub frmGraphs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        countbtnclick = 1
        'count to determine how many times "Sales" button is clicked
        chrtCarClassPIE.Hide()
        chrtMonthlySales.Hide()
        chrtDailySales.Hide()
        lstStockData.Hide()
        'Hide all charts
        btnMonthlySales.Visible = False
        btnTypeSales.Visible = False
        btnDailySales.Visible = False
        'Hide the sub Sales buttons
        pnlDataAnalysisHome.Show()
        'Show the Data Analysis Home Panel
        pnlControlDailySales.Hide()
        'Hide all other control panels
        dbxCompareDATE.MaxDate = DateTime.Now.AddDays(-1)
        dbxCompareDATE.MinDate = DateTime.Now.AddMonths(-1)
        'Set the limits to the Date picker

    End Sub

    Private Sub btnDailySales_Click(sender As System.Object, e As System.EventArgs) Handles btnDailySales.Click
        'When the 'Sales by day' button is clicked
        DisplayPanelGraphs(pnlControlDailySales)
        'Display the panel of controls for daily sales and hide all other panels
        HighlightButton(btnDailySales)
        chrtMonthlySales.Hide()
        chrtDailySales.Hide()
        chrtCarClassPIE.Hide()
        lstStockData.Hide()
        'Show the Daily sales chart and hide all other charts
        pnlControlDailySales.Show()
        'Hide the Data Analysis Home panel
        lblChartEdit.Text = "SALES BY DAY"

    End Sub
    Private Sub btnGenerateGraphDaily_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerateGraphDaily.Click
        'To generate the the Sales by day graph
        chrtDailySales.Show()
        findDailySales()
        'Find the y calues of the Daily Sales
        Dim yToday As Double() = {t9, t10, t11, t12, t13, t14, t15, t16, t17, t18} 'y values of Today's sales
        Dim yCompare As Double() = {y9, y10, y11, y12, y13, y14, y15, y16, y17, y18} 'y values of the sales of a chosen date
        Dim xValues As String() = {"09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00"} 'Headings for x axis
        Dim SeriesToday As String = Nothing
        Dim SeriesCompareDay As String = Nothing
        chrtDailySales.Series.Clear()
        chrtDailySales.Titles.Clear()
        'clear the chart series
        SeriesToday = "Today"
        SeriesCompareDay = dbxCompareDATE.Text
        'Series name for the two chart
        chrtDailySales.Series.Add(SeriesToday)
        chrtDailySales.Series.Add(SeriesCompareDay)
        'Add the series to the chart
        chrtDailySales.Series(SeriesToday).Points.DataBindXY(xValues, yToday)
        chrtDailySales.Series(SeriesCompareDay).Points.DataBindXY(xValues, yCompare)
        'The x and y values of the chart that are to be plotted
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LineColor = Color.White
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LineColor = Color.White
        'The colour of the axis set to white
        chrtDailySales.Series(SeriesToday).ChartType = SeriesChartType.Column
        chrtDailySales.Series(SeriesCompareDay).ChartType = SeriesChartType.Column
        'Create a Column graph
        chrtDailySales.ChartAreas("ChartArea1").BackColor = Color.FromArgb(52, 52, 52)
        'Set the back colour of the chart to dark grey/black
        chrtDailySales.ChartAreas("ChartArea1").AxisX.Title = "Time of Day"
        chrtDailySales.ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Century Gothic", 10.0F, FontStyle.Regular)
        chrtDailySales.ChartAreas("ChartArea1").AxisY.Title = "No. of Sales"
        chrtDailySales.ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Century Gothic", 10.0F, FontStyle.Regular)
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LabelStyle.ForeColor = Color.FromArgb(0, 166, 100)
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 166, 100)
        'The color of the axis labels set to green
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LabelStyle.Font = New Font("Century Gothic", 8.0F, FontStyle.Bold)
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LabelStyle.Font = New Font("Century Gothic", 10.0F, FontStyle.Regular)
        'The font formatting of the axis labels
        chrtDailySales.Series(SeriesToday).BorderWidth = 3
        chrtDailySales.Series(SeriesCompareDay).BorderWidth = 3
        'The thickness of the graph columns
        Dim T As Title = chrtDailySales.Titles.Add("Daily Sales")
        'The title of the chart
        With T
            'Format the title
            .ForeColor = Color.White
            .BackColor = Color.FromArgb(0, 166, 100)
            .Font = New Font("Century Gothic", 12.0F, FontStyle.Regular)
            .BorderColor = Color.White
        End With
        chrtDailySales.Legends(0).Enabled = True
        'Enable chart legends
        chrtDailySales.Series(SeriesToday).IsValueShownAsLabel = True
        chrtDailySales.Series(SeriesCompareDay).IsValueShownAsLabel = True
        'Show the labels on the data points
        chrtDailySales.Series(SeriesToday).LabelForeColor = Color.Goldenrod
        chrtDailySales.Series(SeriesCompareDay).LabelForeColor = Color.DodgerBlue
        chrtDailySales.Series(SeriesToday).Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        chrtDailySales.Series(SeriesCompareDay).Font = New Font("Century Gothic", 10.0F, FontStyle.Bold)
        'Set the colors and fonts of the labels
        chrtDailySales.ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.Gray
        chrtDailySales.ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.Gray
        'The color of the grid lines to grey
        chrtDailySales.ChartAreas("ChartArea1").AxisY.MajorTickMark.LineColor = Color.Gray
        chrtDailySales.ChartAreas("ChartArea1").AxisX.MajorTickMark.LineColor = Color.Gray
        'the colors of the points on the axis to grey
        chrtDailySales.Legends(0).BackColor = Color.FromArgb(52, 52, 52)
        chrtDailySales.Legends(0).ForeColor = Color.White
        chrtDailySales.Legends(0).Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        'format the chart legends color and font
        chrtDailySales.Series(0).Color = Color.Goldenrod
        chrtDailySales.Series(1).Color = Color.DodgerBlue
        'The colors of the chart columns
        CalculateDailyIncome()
        'Calculate the total income for today and the date chosen to compare
        lblIncomeToday.Text = "£" & Format(TodayIncome, "0.00").ToString
        lblIncomeOther.Text = dbxCompareDATE.Text & "'s INCOME"
        lblIncomOther.Text = "£" & Format(CompareDayIncome, "0.00").ToString
        'Display the income in labels
    End Sub
    Private Sub btnPrintSalesChart_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintSalesChart.Click
        'To print the Sales by day chart
        chrtDailySales.BackColor = Color.White
        'Set the back colour to shite
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LineColor = Color.Black
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LineColor = Color.Black
        chrtDailySales.ChartAreas("ChartArea1").BackColor = Color.White
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LabelStyle.ForeColor = Color.Black
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LabelStyle.ForeColor = Color.Black
        chrtDailySales.Legends(0).BackColor = Color.White
        chrtDailySales.Legends(0).ForeColor = Color.Black
        'Format the colours of the chart
        printchart(chrtDailySales)
        'Print the chart
        chrtDailySales.BackColor = Color.FromArgb(52, 52, 52)
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LineColor = Color.White
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LineColor = Color.White
        chrtDailySales.ChartAreas("ChartArea1").BackColor = Color.FromArgb(52, 52, 52)
        chrtDailySales.ChartAreas("ChartArea1").AxisX.LabelStyle.ForeColor = Color.FromArgb(0, 166, 100)
        chrtDailySales.ChartAreas("ChartArea1").AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 166, 100)
        chrtDailySales.Legends(0).BackColor = Color.FromArgb(52, 52, 52)
        chrtDailySales.Legends(0).ForeColor = Color.White
        chrtMonthlySales.BackColor = Color.FromArgb(52, 52, 52)
        'Reset the colors back to normal
    End Sub
    Private Sub printchart(ByVal chartsent As Chart)
        'Printing a chart
        chartsent.Printing.PrintDocument.DefaultPageSettings.Landscape = True
        'Set the orientation of the page to Landscape
        chartsent.Printing.PrintPreview()
        'Open print preview dialogue
    End Sub
    Private Sub btnPrintStockList_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintStockList.Click
        'To print the Stock ListView
        lstStockData.Hide()
        'Hide the stock list
        lstStockData.BackColor = Color.White
        lstStockData.ForeColor = Color.Black
        'Change the back colour to white and the forecolor to black
        Dim prn As New Printing.PrintDocument
        prn.PrinterSettings.PrinterName.ToString()
        AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
        prn.Print()
        'Print the ListView
        RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
    End Sub
    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim lvwItem As ListViewItem
        Dim lvwSubItem As ListViewItem.ListViewSubItem
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        'Counter for display purposes
        Dim listviewcount As Integer = 1
        'Loop through our listview items
        For Each lvwItem In lstStockData.Items
            xPos = 0
            'Print the count
            'Debug.Print(listviewcount)
            'Print the subitems of this particular ListViewItem
            For Each lvwSubItem In lvwItem.SubItems
                xPos += 100
                yPos = 100 + (listviewcount * 15)
                args.Graphics.DrawString(lvwSubItem.Text(), New Font("Arial", 10, FontStyle.Bold), Brushes.Black, xPos, yPos)
            Next
            'Increment the count (for display purposes)
            listviewcount += 1
        Next
    End Sub
    Private Sub picClose_Click(sender As System.Object, e As System.EventArgs) Handles picClose.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub btnGeneratePIEChart_Click(sender As System.Object, e As System.EventArgs) Handles btnGeneratePIEChart.Click
        chrtCarClassPIE.Visible = True
        GetSomeClass()
        'find y values to plot the graph from the text file
        Dim yValues As Double() = {cA, cB, cC, cD, cE, cF, MPV, SP, MP, S4x4, L4x4, MBus, SVn, MVn, LVn} 'y values retrieved from the text file
        Dim xValues As String() = {"Class A", "Class B", "Class C", "Class D", "Class E", "Class F", "MPV", "Small Premium", "Medium Premium", "Small 4X4", "Large 4X4", "Minibus", "Mini Van", "Medium Van", "Large Van"} 'Headings for x axis
        Dim seriesName As String = Nothing
        chrtCarClassPIE.Series.Clear()
        chrtCarClassPIE.Titles.Clear()
        'Clear the chart series and title
        seriesName = "ClassSale"
        'The series name 
        chrtCarClassPIE.Series.Add(seriesName)
        'Add the series to the chart
        chrtCarClassPIE.Series(seriesName).Points.DataBindXY(xValues, yValues)
        'Plot the x and y values on the chart
        chrtCarClassPIE.Series(seriesName).LabelForeColor = Color.White
        chrtCarClassPIE.Series(seriesName).Font = New Font("Century Gothic", 14.0F, FontStyle.Bold)
        'Color and font formatting of the data labels on the chart
        chrtCarClassPIE.ChartAreas("ChartArea1").BackColor = Color.FromArgb(52, 52, 52)
        'Back Color of the chart
        chrtCarClassPIE.Series(seriesName).ChartType = SeriesChartType.Pie
        'make a Pie Chart
        chrtCarClassPIE.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        'Make the pie Chart 3D style
        Dim T As Title = chrtCarClassPIE.Titles.Add("Distribution of Car Type Hired")
        'The title of the chart - "Distribution of Cars by type"
        With T
            'Format the Title
            .ForeColor = Color.White
            .BackColor = Color.FromArgb(0, 166, 100)
            .Font = New System.Drawing.Font("Century Gothic", 12.0F, System.Drawing.FontStyle.Regular)
            .BorderColor = Color.White
        End With

        chrtCarClassPIE.Legends(0).Enabled = True
        'Enable chart legends
        chrtCarClassPIE.Legends(0).BackColor = Color.FromArgb(52, 52, 52)
        chrtCarClassPIE.Legends(0).ForeColor = Color.White
        chrtCarClassPIE.Legends(0).Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        'Format the chart legends
        chrtCarClassPIE.Series(seriesName).IsValueShownAsLabel = True
        'Show data labels on the chart
    End Sub
    Private Sub picMinimise_Click(sender As System.Object, e As System.EventArgs) Handles picMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class