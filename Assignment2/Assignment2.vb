Public Class Assignment2
    Public Sub Zero()
        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 12 To 14
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub One()
        For i As Integer = 1 To 3
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 6 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 11 To 14
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 16 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 21 To 24
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Two()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label10.Visible = True
        Label16.Visible = True

        For i As Integer = 6 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
        For i As Integer = 17 To 20
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Three()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 12 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label20.Visible = True

        For i As Integer = 6 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 16 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        Label11.Visible = False
    End Sub

    Public Sub Four()
        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 5 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 1 To 11 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 2 To 4
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 21 To 24
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Five()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label20.Visible = True

        Label10.Visible = False
        Label16.Visible = False

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Six()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label20.Visible = True
        Label16.Visible = True

        Label10.Visible = False

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Seven()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 5 To 25 Step 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        Label6.Visible = True

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 11 To 14
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 16 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 21 To 24
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Eight()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label10.Visible = True
        Label20.Visible = True
        Label16.Visible = True

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Nine()
        For i As Integer = 1 To 5
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 11 To 15
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next

        For i As Integer = 21 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
        Label6.Visible = True
        Label10.Visible = True
        Label20.Visible = True
        Label16.Visible = False

        For i As Integer = 7 To 9
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next

        For i As Integer = 17 To 19
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = False
            End If
        Next
    End Sub

    Public Sub Reset()
        For i As Integer = 1 To 25
            Dim lbl = Panel1.Controls("Label" & i.ToString())
            If lbl IsNot Nothing Then
                lbl.Visible = True
            End If
        Next
    End Sub

    Sub delay(ByVal delay_ms As Integer)
        Dim tspan As New TimeSpan
        Dim tstart = Now
        While tspan.TotalMilliseconds < delay_ms
            tspan = Now - tstart
            Application.DoEvents()
        End While
    End Sub

    
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Zero()
        delay(1000)

        One()
        delay(1000)

        Two()
        delay(1000)

        Three()
        delay(1000)

        Four()
        delay(1000)

        Five()
        delay(1000)

        Six()
        delay(1000)

        Seven()
        delay(1000)

        Eight()
        delay(1000)

        Nine()
        delay(1000)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

End Class


