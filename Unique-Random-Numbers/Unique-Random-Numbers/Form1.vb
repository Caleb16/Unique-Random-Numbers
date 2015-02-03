Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNumber1 As Integer
        Dim intNumber2 As Integer
        Dim IntNumber3 As Integer
                 
        Randomize()
        intNumber1 = Int((9 - 1 + 1) * Rnd() + 1)

        Do
            Randomize()
            intNumber2 = Int((9 - 1 + 1) * Rnd() + 1)
        Loop Until intNumber2 <> intNumber1
        Do
            Randomize()
            intNumber3 = Int((9 - 1 + 1) * Rnd() + 1)
        Loop Until intNumber3 <> intNumber2 And intNumber3 <> intNumber2

        If (intNumber1 <> intNumber2) and (intNumber1 <> intNumber3) and (intNumber2 <> intNumber3)
            Me.lblResult.Text = "" & intNumber1 & intNumber2 & intNumber3 & ""
        End If
    End Sub
End Class
