Public Class frmMsgBoxYesNo

    Private Sub ClickYESNO(sender As Object, e As EventArgs) Handles btnYes.Click, btnNo.Click
        MsgBoxANSWERYES = False
        ' Add each of the buttons click event after the Handles.
        ' All these "events" are dealt with by this subrountine.

        Dim clickedButton As Button = DirectCast(sender, Button)
        ' Convert the sendXer (the thing that got clicked, or touched up) to clickedButton.
        If clickedButton Is btnYes Then
            MsgBoxANSWERYES = True
            Me.Close()
        ElseIf clickedButton Is btnNo Then
            MsgBoxANSWERYES = False
            Me.Close()
      
        End If
    End Sub

End Class