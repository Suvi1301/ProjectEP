<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataAnalysis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chrtCarClassPIE = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrtMonthlySales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnStockList = New System.Windows.Forms.Button()
        Me.lstStockData = New System.Windows.Forms.ListView()
        Me.btnMonthlySales = New System.Windows.Forms.Button()
        Me.btnTypeSales = New System.Windows.Forms.Button()
        Me.chrtDailySales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnDailySales = New System.Windows.Forms.Button()
        Me.dbxCompareDATE = New System.Windows.Forms.DateTimePicker()
        Me.picDATAANALYSIS = New System.Windows.Forms.PictureBox()
        Me.pnlDataAnalysisHome = New System.Windows.Forms.Panel()
        Me.lblHomeDataAnalysis = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.picCompanyLogo = New System.Windows.Forms.PictureBox()
        Me.lblChartEdit = New System.Windows.Forms.Label()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        Me.pnlControlDailySales = New System.Windows.Forms.Panel()
        Me.btnGenerateGraphDaily = New System.Windows.Forms.Button()
        Me.lblIncomOther = New System.Windows.Forms.Label()
        Me.lblIncomeToday = New System.Windows.Forms.Label()
        Me.lblIncomeOther = New System.Windows.Forms.Label()
        Me.lblTodaysIncome = New System.Windows.Forms.Label()
        Me.btnPrintSalesChart = New System.Windows.Forms.Button()
        Me.pnlControlCarClassPIE = New System.Windows.Forms.Panel()
        Me.lblPIEendDate = New System.Windows.Forms.Label()
        Me.dbxPIEEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnGeneratePIEChart = New System.Windows.Forms.Button()
        Me.lblPIEstartDate = New System.Windows.Forms.Label()
        Me.dbxPIEStartDate = New System.Windows.Forms.DateTimePicker()
        Me.pnlControlStockList = New System.Windows.Forms.Panel()
        Me.btnPrintStockList = New System.Windows.Forms.Button()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picMinimise = New System.Windows.Forms.PictureBox()
        CType(Me.chrtCarClassPIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtMonthlySales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtDailySales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDATAANALYSIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDataAnalysisHome.SuspendLayout()
        CType(Me.picCompanyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlDailySales.SuspendLayout()
        Me.pnlControlCarClassPIE.SuspendLayout()
        Me.pnlControlStockList.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chrtCarClassPIE
        '
        Me.chrtCarClassPIE.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        ChartArea7.Name = "ChartArea1"
        Me.chrtCarClassPIE.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.chrtCarClassPIE.Legends.Add(Legend7)
        Me.chrtCarClassPIE.Location = New System.Drawing.Point(256, -1)
        Me.chrtCarClassPIE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chrtCarClassPIE.Name = "chrtCarClassPIE"
        Me.chrtCarClassPIE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Me.chrtCarClassPIE.Series.Add(Series7)
        Me.chrtCarClassPIE.Size = New System.Drawing.Size(923, 618)
        Me.chrtCarClassPIE.TabIndex = 0
        '
        'chrtMonthlySales
        '
        Me.chrtMonthlySales.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        ChartArea8.Name = "ChartArea1"
        Me.chrtMonthlySales.ChartAreas.Add(ChartArea8)
        Me.chrtMonthlySales.IsSoftShadows = False
        Legend8.Name = "Legend1"
        Me.chrtMonthlySales.Legends.Add(Legend8)
        Me.chrtMonthlySales.Location = New System.Drawing.Point(256, 0)
        Me.chrtMonthlySales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chrtMonthlySales.Name = "chrtMonthlySales"
        Me.chrtMonthlySales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        Me.chrtMonthlySales.Series.Add(Series8)
        Me.chrtMonthlySales.Size = New System.Drawing.Size(921, 622)
        Me.chrtMonthlySales.TabIndex = 2
        Me.chrtMonthlySales.Text = "ChartSales"
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.White
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.Black
        Me.btnSales.Location = New System.Drawing.Point(0, 155)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(251, 41)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "SALES"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnStockList
        '
        Me.btnStockList.BackColor = System.Drawing.Color.White
        Me.btnStockList.FlatAppearance.BorderSize = 0
        Me.btnStockList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btnStockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockList.ForeColor = System.Drawing.Color.Black
        Me.btnStockList.Location = New System.Drawing.Point(0, 114)
        Me.btnStockList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStockList.Name = "btnStockList"
        Me.btnStockList.Size = New System.Drawing.Size(251, 41)
        Me.btnStockList.TabIndex = 4
        Me.btnStockList.Text = "STOCK LIST"
        Me.btnStockList.UseVisualStyleBackColor = False
        '
        'lstStockData
        '
        Me.lstStockData.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lstStockData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstStockData.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStockData.ForeColor = System.Drawing.Color.White
        Me.lstStockData.FullRowSelect = True
        Me.lstStockData.GridLines = True
        Me.lstStockData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstStockData.HoverSelection = True
        Me.lstStockData.Location = New System.Drawing.Point(256, 0)
        Me.lstStockData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstStockData.Name = "lstStockData"
        Me.lstStockData.Size = New System.Drawing.Size(921, 622)
        Me.lstStockData.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstStockData.TabIndex = 6
        Me.lstStockData.UseCompatibleStateImageBehavior = False
        Me.lstStockData.View = System.Windows.Forms.View.Details
        '
        'btnMonthlySales
        '
        Me.btnMonthlySales.BackColor = System.Drawing.Color.White
        Me.btnMonthlySales.FlatAppearance.BorderSize = 0
        Me.btnMonthlySales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btnMonthlySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthlySales.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthlySales.ForeColor = System.Drawing.Color.Black
        Me.btnMonthlySales.Location = New System.Drawing.Point(0, 194)
        Me.btnMonthlySales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMonthlySales.Name = "btnMonthlySales"
        Me.btnMonthlySales.Size = New System.Drawing.Size(251, 41)
        Me.btnMonthlySales.TabIndex = 9
        Me.btnMonthlySales.Text = "MONTHLY SALES"
        Me.btnMonthlySales.UseVisualStyleBackColor = False
        '
        'btnTypeSales
        '
        Me.btnTypeSales.BackColor = System.Drawing.Color.White
        Me.btnTypeSales.FlatAppearance.BorderSize = 0
        Me.btnTypeSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btnTypeSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTypeSales.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTypeSales.ForeColor = System.Drawing.Color.Black
        Me.btnTypeSales.Location = New System.Drawing.Point(0, 235)
        Me.btnTypeSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTypeSales.Name = "btnTypeSales"
        Me.btnTypeSales.Size = New System.Drawing.Size(251, 41)
        Me.btnTypeSales.TabIndex = 10
        Me.btnTypeSales.Text = "SALES BY TYPE"
        Me.btnTypeSales.UseVisualStyleBackColor = False
        '
        'chrtDailySales
        '
        Me.chrtDailySales.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        ChartArea9.Name = "ChartArea1"
        Me.chrtDailySales.ChartAreas.Add(ChartArea9)
        Me.chrtDailySales.IsSoftShadows = False
        Legend9.Name = "Legend1"
        Me.chrtDailySales.Legends.Add(Legend9)
        Me.chrtDailySales.Location = New System.Drawing.Point(255, 0)
        Me.chrtDailySales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chrtDailySales.Name = "chrtDailySales"
        Me.chrtDailySales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.chrtDailySales.Series.Add(Series9)
        Me.chrtDailySales.Size = New System.Drawing.Size(923, 617)
        Me.chrtDailySales.TabIndex = 11
        Me.chrtDailySales.Text = "ChartSales"
        '
        'btnDailySales
        '
        Me.btnDailySales.BackColor = System.Drawing.Color.White
        Me.btnDailySales.FlatAppearance.BorderSize = 0
        Me.btnDailySales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDailySales.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDailySales.ForeColor = System.Drawing.Color.Black
        Me.btnDailySales.Location = New System.Drawing.Point(0, 276)
        Me.btnDailySales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDailySales.Name = "btnDailySales"
        Me.btnDailySales.Size = New System.Drawing.Size(251, 41)
        Me.btnDailySales.TabIndex = 12
        Me.btnDailySales.Text = "SALES BY DAY"
        Me.btnDailySales.UseVisualStyleBackColor = False
        '
        'dbxCompareDATE
        '
        Me.dbxCompareDATE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbxCompareDATE.Location = New System.Drawing.Point(11, 103)
        Me.dbxCompareDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dbxCompareDATE.Name = "dbxCompareDATE"
        Me.dbxCompareDATE.Size = New System.Drawing.Size(239, 32)
        Me.dbxCompareDATE.TabIndex = 13
        '
        'picDATAANALYSIS
        '
        Me.picDATAANALYSIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDATAANALYSIS.Image = Global.ProjectEP.My.Resources.Resources.DATA_ANALYSIS_TITLE
        Me.picDATAANALYSIS.Location = New System.Drawing.Point(0, 0)
        Me.picDATAANALYSIS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picDATAANALYSIS.Name = "picDATAANALYSIS"
        Me.picDATAANALYSIS.Size = New System.Drawing.Size(250, 116)
        Me.picDATAANALYSIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDATAANALYSIS.TabIndex = 7
        Me.picDATAANALYSIS.TabStop = False
        '
        'pnlDataAnalysisHome
        '
        Me.pnlDataAnalysisHome.Controls.Add(Me.lblHomeDataAnalysis)
        Me.pnlDataAnalysisHome.Controls.Add(Me.lblCompanyName)
        Me.pnlDataAnalysisHome.Controls.Add(Me.picCompanyLogo)
        Me.pnlDataAnalysisHome.Location = New System.Drawing.Point(245, 0)
        Me.pnlDataAnalysisHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDataAnalysisHome.Name = "pnlDataAnalysisHome"
        Me.pnlDataAnalysisHome.Size = New System.Drawing.Size(936, 617)
        Me.pnlDataAnalysisHome.TabIndex = 14
        '
        'lblHomeDataAnalysis
        '
        Me.lblHomeDataAnalysis.AutoSize = True
        Me.lblHomeDataAnalysis.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeDataAnalysis.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeDataAnalysis.ForeColor = System.Drawing.Color.White
        Me.lblHomeDataAnalysis.Location = New System.Drawing.Point(341, 402)
        Me.lblHomeDataAnalysis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHomeDataAnalysis.Name = "lblHomeDataAnalysis"
        Me.lblHomeDataAnalysis.Size = New System.Drawing.Size(255, 40)
        Me.lblHomeDataAnalysis.TabIndex = 141
        Me.lblHomeDataAnalysis.Text = "DATA ANALYSIS"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCompanyName.Location = New System.Drawing.Point(263, 331)
        Me.lblCompanyName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(391, 40)
        Me.lblCompanyName.TabIndex = 140
        Me.lblCompanyName.Text = "ENTERPRISE RENT-A-CAR"
        '
        'picCompanyLogo
        '
        Me.picCompanyLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.picCompanyLogo.Image = Global.ProjectEP.My.Resources.Resources.Logo
        Me.picCompanyLogo.Location = New System.Drawing.Point(3, 0)
        Me.picCompanyLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picCompanyLogo.Name = "picCompanyLogo"
        Me.picCompanyLogo.Size = New System.Drawing.Size(931, 382)
        Me.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCompanyLogo.TabIndex = 1
        Me.picCompanyLogo.TabStop = False
        '
        'lblChartEdit
        '
        Me.lblChartEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblChartEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartEdit.ForeColor = System.Drawing.Color.White
        Me.lblChartEdit.Location = New System.Drawing.Point(1183, 0)
        Me.lblChartEdit.Name = "lblChartEdit"
        Me.lblChartEdit.Size = New System.Drawing.Size(263, 58)
        Me.lblChartEdit.TabIndex = 15
        Me.lblChartEdit.Text = "WELCOME"
        Me.lblChartEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectDate
        '
        Me.lblSelectDate.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDate.ForeColor = System.Drawing.Color.White
        Me.lblSelectDate.Location = New System.Drawing.Point(7, 41)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(251, 54)
        Me.lblSelectDate.TabIndex = 16
        Me.lblSelectDate.Text = "Select Date to compare Sales"
        '
        'pnlControlDailySales
        '
        Me.pnlControlDailySales.Controls.Add(Me.btnGenerateGraphDaily)
        Me.pnlControlDailySales.Controls.Add(Me.lblIncomOther)
        Me.pnlControlDailySales.Controls.Add(Me.lblIncomeToday)
        Me.pnlControlDailySales.Controls.Add(Me.lblIncomeOther)
        Me.pnlControlDailySales.Controls.Add(Me.lblTodaysIncome)
        Me.pnlControlDailySales.Controls.Add(Me.btnPrintSalesChart)
        Me.pnlControlDailySales.Controls.Add(Me.lblSelectDate)
        Me.pnlControlDailySales.Controls.Add(Me.dbxCompareDATE)
        Me.pnlControlDailySales.Location = New System.Drawing.Point(1183, 62)
        Me.pnlControlDailySales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControlDailySales.Name = "pnlControlDailySales"
        Me.pnlControlDailySales.Size = New System.Drawing.Size(263, 555)
        Me.pnlControlDailySales.TabIndex = 17
        '
        'btnGenerateGraphDaily
        '
        Me.btnGenerateGraphDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnGenerateGraphDaily.FlatAppearance.BorderSize = 0
        Me.btnGenerateGraphDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateGraphDaily.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateGraphDaily.ForeColor = System.Drawing.Color.Black
        Me.btnGenerateGraphDaily.Location = New System.Drawing.Point(99, 140)
        Me.btnGenerateGraphDaily.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerateGraphDaily.Name = "btnGenerateGraphDaily"
        Me.btnGenerateGraphDaily.Size = New System.Drawing.Size(76, 41)
        Me.btnGenerateGraphDaily.TabIndex = 23
        Me.btnGenerateGraphDaily.Text = "GO"
        Me.btnGenerateGraphDaily.UseVisualStyleBackColor = False
        '
        'lblIncomOther
        '
        Me.lblIncomOther.AutoSize = True
        Me.lblIncomOther.BackColor = System.Drawing.Color.Transparent
        Me.lblIncomOther.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomOther.ForeColor = System.Drawing.Color.White
        Me.lblIncomOther.Location = New System.Drawing.Point(155, 322)
        Me.lblIncomOther.Name = "lblIncomOther"
        Me.lblIncomOther.Size = New System.Drawing.Size(21, 23)
        Me.lblIncomOther.TabIndex = 22
        Me.lblIncomOther.Text = "£"
        '
        'lblIncomeToday
        '
        Me.lblIncomeToday.AutoSize = True
        Me.lblIncomeToday.BackColor = System.Drawing.Color.Transparent
        Me.lblIncomeToday.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeToday.ForeColor = System.Drawing.Color.White
        Me.lblIncomeToday.Location = New System.Drawing.Point(155, 233)
        Me.lblIncomeToday.Name = "lblIncomeToday"
        Me.lblIncomeToday.Size = New System.Drawing.Size(21, 23)
        Me.lblIncomeToday.TabIndex = 21
        Me.lblIncomeToday.Text = "£"
        '
        'lblIncomeOther
        '
        Me.lblIncomeOther.BackColor = System.Drawing.Color.Transparent
        Me.lblIncomeOther.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncomeOther.ForeColor = System.Drawing.Color.White
        Me.lblIncomeOther.Location = New System.Drawing.Point(7, 302)
        Me.lblIncomeOther.Name = "lblIncomeOther"
        Me.lblIncomeOther.Size = New System.Drawing.Size(141, 123)
        Me.lblIncomeOther.TabIndex = 20
        Me.lblIncomeOther.Text = "OTHER INCOME:"
        '
        'lblTodaysIncome
        '
        Me.lblTodaysIncome.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaysIncome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaysIncome.ForeColor = System.Drawing.Color.White
        Me.lblTodaysIncome.Location = New System.Drawing.Point(3, 215)
        Me.lblTodaysIncome.Name = "lblTodaysIncome"
        Me.lblTodaysIncome.Size = New System.Drawing.Size(116, 62)
        Me.lblTodaysIncome.TabIndex = 19
        Me.lblTodaysIncome.Text = "TODAY'S INCOME:"
        '
        'btnPrintSalesChart
        '
        Me.btnPrintSalesChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnPrintSalesChart.FlatAppearance.BorderSize = 0
        Me.btnPrintSalesChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintSalesChart.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintSalesChart.ForeColor = System.Drawing.Color.Black
        Me.btnPrintSalesChart.Location = New System.Drawing.Point(35, 478)
        Me.btnPrintSalesChart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrintSalesChart.Name = "btnPrintSalesChart"
        Me.btnPrintSalesChart.Size = New System.Drawing.Size(205, 41)
        Me.btnPrintSalesChart.TabIndex = 18
        Me.btnPrintSalesChart.Text = "PRINT GRAPH"
        Me.btnPrintSalesChart.UseVisualStyleBackColor = False
        '
        'pnlControlCarClassPIE
        '
        Me.pnlControlCarClassPIE.Controls.Add(Me.lblPIEendDate)
        Me.pnlControlCarClassPIE.Controls.Add(Me.dbxPIEEndDate)
        Me.pnlControlCarClassPIE.Controls.Add(Me.btnGeneratePIEChart)
        Me.pnlControlCarClassPIE.Controls.Add(Me.lblPIEstartDate)
        Me.pnlControlCarClassPIE.Controls.Add(Me.dbxPIEStartDate)
        Me.pnlControlCarClassPIE.Location = New System.Drawing.Point(1183, 62)
        Me.pnlControlCarClassPIE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControlCarClassPIE.Name = "pnlControlCarClassPIE"
        Me.pnlControlCarClassPIE.Size = New System.Drawing.Size(263, 555)
        Me.pnlControlCarClassPIE.TabIndex = 19
        '
        'lblPIEendDate
        '
        Me.lblPIEendDate.BackColor = System.Drawing.Color.Transparent
        Me.lblPIEendDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIEendDate.ForeColor = System.Drawing.Color.White
        Me.lblPIEendDate.Location = New System.Drawing.Point(8, 156)
        Me.lblPIEendDate.Name = "lblPIEendDate"
        Me.lblPIEendDate.Size = New System.Drawing.Size(251, 25)
        Me.lblPIEendDate.TabIndex = 31
        Me.lblPIEendDate.Text = "Select end date:"
        '
        'dbxPIEEndDate
        '
        Me.dbxPIEEndDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbxPIEEndDate.Location = New System.Drawing.Point(12, 199)
        Me.dbxPIEEndDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dbxPIEEndDate.Name = "dbxPIEEndDate"
        Me.dbxPIEEndDate.Size = New System.Drawing.Size(239, 32)
        Me.dbxPIEEndDate.TabIndex = 30
        '
        'btnGeneratePIEChart
        '
        Me.btnGeneratePIEChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnGeneratePIEChart.FlatAppearance.BorderSize = 0
        Me.btnGeneratePIEChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneratePIEChart.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneratePIEChart.ForeColor = System.Drawing.Color.Black
        Me.btnGeneratePIEChart.Location = New System.Drawing.Point(100, 259)
        Me.btnGeneratePIEChart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGeneratePIEChart.Name = "btnGeneratePIEChart"
        Me.btnGeneratePIEChart.Size = New System.Drawing.Size(76, 41)
        Me.btnGeneratePIEChart.TabIndex = 29
        Me.btnGeneratePIEChart.Text = "GO"
        Me.btnGeneratePIEChart.UseVisualStyleBackColor = False
        '
        'lblPIEstartDate
        '
        Me.lblPIEstartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblPIEstartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIEstartDate.ForeColor = System.Drawing.Color.White
        Me.lblPIEstartDate.Location = New System.Drawing.Point(7, 41)
        Me.lblPIEstartDate.Name = "lblPIEstartDate"
        Me.lblPIEstartDate.Size = New System.Drawing.Size(251, 25)
        Me.lblPIEstartDate.TabIndex = 17
        Me.lblPIEstartDate.Text = "Select starting date:"
        '
        'dbxPIEStartDate
        '
        Me.dbxPIEStartDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbxPIEStartDate.Location = New System.Drawing.Point(11, 74)
        Me.dbxPIEStartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dbxPIEStartDate.Name = "dbxPIEStartDate"
        Me.dbxPIEStartDate.Size = New System.Drawing.Size(239, 32)
        Me.dbxPIEStartDate.TabIndex = 14
        '
        'pnlControlStockList
        '
        Me.pnlControlStockList.Controls.Add(Me.btnPrintStockList)
        Me.pnlControlStockList.Location = New System.Drawing.Point(1182, 456)
        Me.pnlControlStockList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlControlStockList.Name = "pnlControlStockList"
        Me.pnlControlStockList.Size = New System.Drawing.Size(263, 161)
        Me.pnlControlStockList.TabIndex = 18
        '
        'btnPrintStockList
        '
        Me.btnPrintStockList.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnPrintStockList.FlatAppearance.BorderSize = 0
        Me.btnPrintStockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintStockList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintStockList.ForeColor = System.Drawing.Color.Black
        Me.btnPrintStockList.Location = New System.Drawing.Point(43, 60)
        Me.btnPrintStockList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrintStockList.Name = "btnPrintStockList"
        Me.btnPrintStockList.Size = New System.Drawing.Size(179, 41)
        Me.btnPrintStockList.TabIndex = 19
        Me.btnPrintStockList.Text = "PRINT LIST"
        Me.btnPrintStockList.UseVisualStyleBackColor = False
        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Image = Global.ProjectEP.My.Resources.Resources.close32
        Me.picClose.Location = New System.Drawing.Point(1400, 2)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(40, 40)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClose.TabIndex = 160
        Me.picClose.TabStop = False
        '
        'picMinimise
        '
        Me.picMinimise.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.picMinimise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimise.Image = Global.ProjectEP.My.Resources.Resources.minus75
        Me.picMinimise.Location = New System.Drawing.Point(1187, 2)
        Me.picMinimise.Name = "picMinimise"
        Me.picMinimise.Size = New System.Drawing.Size(40, 40)
        Me.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMinimise.TabIndex = 161
        Me.picMinimise.TabStop = False
        '
        'frmDataAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1445, 617)
        Me.Controls.Add(Me.picMinimise)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.pnlControlDailySales)
        Me.Controls.Add(Me.pnlControlStockList)
        Me.Controls.Add(Me.pnlControlCarClassPIE)
        Me.Controls.Add(Me.lblChartEdit)
        Me.Controls.Add(Me.pnlDataAnalysisHome)
        Me.Controls.Add(Me.chrtDailySales)
        Me.Controls.Add(Me.chrtMonthlySales)
        Me.Controls.Add(Me.chrtCarClassPIE)
        Me.Controls.Add(Me.lstStockData)
        Me.Controls.Add(Me.picDATAANALYSIS)
        Me.Controls.Add(Me.btnStockList)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnMonthlySales)
        Me.Controls.Add(Me.btnTypeSales)
        Me.Controls.Add(Me.btnDailySales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDataAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGraphs"
        CType(Me.chrtCarClassPIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtMonthlySales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtDailySales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDATAANALYSIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDataAnalysisHome.ResumeLayout(False)
        Me.pnlDataAnalysisHome.PerformLayout()
        CType(Me.picCompanyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlDailySales.ResumeLayout(False)
        Me.pnlControlDailySales.PerformLayout()
        Me.pnlControlCarClassPIE.ResumeLayout(False)
        Me.pnlControlStockList.ResumeLayout(False)
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chrtCarClassPIE As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chrtMonthlySales As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnStockList As System.Windows.Forms.Button
    Friend WithEvents lstStockData As System.Windows.Forms.ListView
    Friend WithEvents picDATAANALYSIS As System.Windows.Forms.PictureBox
    Friend WithEvents btnMonthlySales As System.Windows.Forms.Button
    Friend WithEvents btnTypeSales As System.Windows.Forms.Button
    Friend WithEvents chrtDailySales As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnDailySales As System.Windows.Forms.Button
    Friend WithEvents dbxCompareDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlDataAnalysisHome As System.Windows.Forms.Panel
    Friend WithEvents lblChartEdit As System.Windows.Forms.Label
    Friend WithEvents lblSelectDate As System.Windows.Forms.Label
    Friend WithEvents pnlControlDailySales As System.Windows.Forms.Panel
    Friend WithEvents btnPrintSalesChart As System.Windows.Forms.Button
    Friend WithEvents lblIncomeOther As System.Windows.Forms.Label
    Friend WithEvents lblIncomOther As System.Windows.Forms.Label
    Friend WithEvents lblIncomeToday As System.Windows.Forms.Label
    Friend WithEvents lblTodaysIncome As System.Windows.Forms.Label
    Friend WithEvents btnGenerateGraphDaily As System.Windows.Forms.Button
    Friend WithEvents pnlControlStockList As System.Windows.Forms.Panel
    Friend WithEvents btnPrintStockList As System.Windows.Forms.Button
    Friend WithEvents picCompanyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblHomeDataAnalysis As System.Windows.Forms.Label
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents pnlControlCarClassPIE As System.Windows.Forms.Panel
    Friend WithEvents lblPIEstartDate As System.Windows.Forms.Label
    Friend WithEvents dbxPIEStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents picClose As System.Windows.Forms.PictureBox
    Friend WithEvents btnGeneratePIEChart As System.Windows.Forms.Button
    Friend WithEvents dbxPIEEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPIEendDate As System.Windows.Forms.Label
    Friend WithEvents picMinimise As System.Windows.Forms.PictureBox
End Class
