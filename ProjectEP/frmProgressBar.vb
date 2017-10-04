
Public Class frmProgressBar
    Dim counterTimer As Integer 'The timer interval
    Private Sub CreateCircle(rect As Rectangle, circleFillColor As Color, circlebackColor As Color, percent As Integer)
        'To draw a circle loading progress bar which takes a set amount of time to get to 100%
        Dim g As Graphics = Me.CreateGraphics() 'the graphic to draw the circle
        g.Clear(Me.BackColor)
        'Clear the current graphics.

        Dim loadedSection = CInt(3.6 * percent) 'The angle of the arc covered by perecentage.
        Dim UnloadedSection = 360 - loadedSection  'The arc that is not yet filled in

        Using coloredPen As New Pen(circleFillColor, 10), greyPen As New Pen(circlebackColor, 10)
            'draw the circle with the specified colours and  border width of 10
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.DrawArc(coloredPen, rect, -90, loadedSection)
            g.DrawArc(greyPen, rect, loadedSection - 90, UnloadedSection)
            Dim strtformat As New StringFormat 'The percentage value displayed on screen
            strtformat.Alignment = StringAlignment.Center
            'Align the % value in the middle of the circle
            strtformat.LineAlignment = StringAlignment.Center
            'Align the % value in the middle of the circle
            g.DrawString(percent & "%", New Font("Century Gothic", 24, FontStyle.Regular), Brushes.White, 350, 200, strtformat)
            'Display the percentage with the formatting
        End Using
    End Sub
    Private Sub reDraw(sender As Object, e As EventArgs) Handles tmrProgressBar.Tick
        'Draw the circle each time the timer ticks
        counterTimer += 5 'The interval of the timer each time
        If counterTimer <= 100 Then
            'If the timer is less than 100 - So fill the circle till its 100%
            CreateCircle(New Rectangle(250, 100, 200, 200), Color.FromArgb(0, 166, 100), Color.GhostWhite, counterTimer)
        Else
            'Once its 100% stop drawing the circle
            tmrProgressBar.Stop()
            'stop the timer
            counterTimer = 0
            Me.Close()
            'close the form
        End If
    End Sub
    Private Sub frmProgressBar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'when the progress bar form loads
        tmrProgressBar.Start()
        'start the timer
    End Sub
End Class