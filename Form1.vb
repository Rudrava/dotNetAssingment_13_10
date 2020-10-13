Public Class Form1
    Dim arr(5) As Integer
    Dim arr2d(3, 3) As Integer
    Dim arrIndex1d As Integer
    Dim arrIndex2dI As Integer
    Dim arrIndex2dJ As Integer
    Dim inpBuffer As Integer
    Dim dimension2d As Boolean

    '1d subs
    Private Sub add1d()
        If IsNumeric(input.Text) Then

            inpBuffer = input.Text
            If arrIndex1d = 5 Then
                MsgBox("The Array Is full !!!", MsgBoxStyle.Information)
                addArrBtn.Enabled = False
                input.Clear()

                input.Enabled = False


            Else
                arrIndex1d += 1
                arr(arrIndex1d) = inpBuffer
                input.Focus()
                input.Clear()

            End If

        Else
            MsgBox("Enter Numeric values only please !!!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub show1d()
        Dim ittr As Integer
        arrOpLbl.Text = "Arr: "
        If arrIndex1d = -1 Then
            MsgBox("No Elements to show", MsgBoxStyle.Information)
        Else
            arrOpLbl.Visible = True
            For ittr = 0 To arrIndex1d

                arrOpLbl.Text += Convert.ToString(arr(ittr)) + ", "
            Next ittr
        End If
    End Sub

    Private Sub sum1d()
        Dim sum As Integer
        Dim ittr As Integer
        If arrIndex1d = -1 Then
            MsgBox("No Elements to show", MsgBoxStyle.Information)
        Else
            For ittr = 0 To arrIndex1d
                sum += arr(ittr)
            Next ittr
            SumOpLbl.Text = "Sum: "
            SumOpLbl.Visible = True
            SumOpLbl.Text += Convert.ToString(sum)
        End If
    End Sub

    '2d subs
    Private Sub add2d()
        If IsNumeric(input.Text) Then

            inpBuffer = input.Text
            If arrIndex2dI = 2 And arrIndex2dJ = 2 Then
                MsgBox("The Array Is full !!!", MsgBoxStyle.Information)

                input.Clear()
                addArrBtn.Enabled = False
                input.Enabled = False
            Else
                If arrIndex2dI = -1 And arrIndex2dJ = -1 Then
                    arrIndex2dI += 1
                    arrIndex2dJ += 1
                    MsgBox(arrIndex2dI & arrIndex2dJ, MsgBoxStyle.Information)
                End If
                If arrIndex2dJ = 3 Then
                    arrIndex2dI += 1
                    arrIndex2dJ = -1
                    MsgBox("changing i" & arrIndex2dI & arrIndex2dJ, MsgBoxStyle.Information)
                End If
                If arrIndex2dJ = -1 Then
                    arrIndex2dJ += 1
                    MsgBox("changing j" & arrIndex2dI & arrIndex2dJ, MsgBoxStyle.Information)
                End If

                arr2d(arrIndex2dI, arrIndex2dJ) = inpBuffer
                arrIndex2dJ += 1

                input.Focus()
                input.Clear()

            End If
        Else
            MsgBox("Enter Numeric values only please !!!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub show2d()
        Dim i As Integer
        Dim j As Integer

        arrOpLbl.Text = "Arr: "
        If arrIndex2dI = -1 And arrIndex2dJ = -1 Then
            MsgBox("No Elements to show", MsgBoxStyle.Information)
        Else
            arrOpLbl.Text += vbNewLine
            For i = 0 To 2
                For j = 0 To 2
                    If arr2d(i, j) < 0 Then
                        arrOpLbl.Text += "0"
                    Else
                        arrOpLbl.Text += Convert.ToString(arr2d(i, j)) + ", "
                    End If

                Next j
                arrOpLbl.Text += vbNewLine
            Next i
        End If
        arrOpLbl.Visible = True
    End Sub

    Private Sub sum2d()
        Dim i As Integer
        Dim j As Integer
        Dim sum As Integer

        SumOpLbl.Text = "Sum: "
        sum = 0
        If arrIndex2dI = -1 And arrIndex2dJ = -1 Then
            MsgBox("Enter at least 1 element", MsgBoxStyle.Information)
        Else
            For i = 0 To 3
                For j = 0 To 2
                    If arr2d(i, j) < 0 Then
                        sum += 0
                    Else
                        sum += arr2d(i, j)
                    End If

                Next j
            Next i
        End If
        SumOpLbl.Visible = True
        SumOpLbl.Text += Convert.ToString(sum)
    End Sub

    'call add arr as dimension
    Private Sub addArrBtn_Click(sender As Object, e As EventArgs) Handles addArrBtn.Click
        If Not dimension2d Then
            add1d()
        Else
            add2d()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrIndex1d = -1
        arrIndex2dI = -1
        arrIndex2dJ = -1

    End Sub

    Private Sub ShowArrBtn_Click(sender As Object, e As EventArgs) Handles ShowArrBtn.Click
        If Not dimension2d Then
            show1d()
        Else
            show2d()
        End If
    End Sub

    Private Sub SumBtn_Click(sender As Object, e As EventArgs) Handles SumBtn.Click
        If Not dimension2d Then
            sum1d()
        Else
            sum2d()
        End If
    End Sub


    Private Sub dimentionSwitch_Click_1(sender As Object, e As EventArgs) Handles dimentionSwitch.Click
        If arrIndex1d = -1 Then
            dimension2d = True
            dimentionSwitch.BackColor = Color.Crimson
            'MsgBox("Hey Dr Strange", MsgBoxStyle.Information)
        Else
            MsgBox("Cant travel to different dimensions", MsgBoxStyle.Information)
        End If
    End Sub
End Class
