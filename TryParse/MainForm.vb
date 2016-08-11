Imports System.Collections.Specialized
Imports System.Text

Public Class MainForm

    Private _str As StringCollection
    Private _sw As New Stopwatch

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = "This application demonstrates the difference between <b><code>Parse</code></b> and <b><code>TryParse</code></b>" & _
            " for converting datatypes from strings. <code>TryParse</code> is new to .NET 2.0 and avoids throwing exceptions when converting. " & _
            "<p>Adjust the number of strings and the success rate, then click the Run button to begin."
    End Sub

    Private Sub BadDataFill()
        Dim successPercent As Integer = CInt(SuccessRateNumericUpDown.Text)
        If successPercent >= 100 Then Return

        Dim s As String = ""
        Dim r As New Random(Environment.TickCount)

        For i As Integer = 0 To _str.Count - 1
            If r.Next(1, 100) > successPercent Then
                For j As Integer = 1 To r.Next(4, 9)
                    s = s + Chr(r.Next(97, 123))
                Next
                _str(i) = s
            End If
        Next

    End Sub

    Private Sub NumberFill()
        Dim r As New Random(Environment.TickCount)
        _str = New StringCollection
        For i As Integer = 1 To CInt(StringCountNumericUpDown.Text)
            _str.Add(CStr(r.Next(1, 1000)))
        Next
        BadDataFill()
    End Sub

    Private Sub DateTimeFill()
        Dim r As New Random(Environment.TickCount)
        _str = New StringCollection
        For i As Integer = 1 To CInt(StringCountNumericUpDown.Text)
            _str.Add(DateTime.Now.ToString)
        Next
        BadDataFill()
    End Sub

    Private Function Int32ParseRoutine() As Long
        Dim i As Integer
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            Try
                i = Int32.Parse(s)
            Catch ex As Exception
            End Try
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function Int32TryParseRoutine() As Long
        Dim i As Integer
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            If Int32.TryParse(s, i) Then
            Else
            End If
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function DecimalParseRoutine() As Long
        Dim d As Decimal
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            Try
                d = Decimal.Parse(s)
            Catch ex As Exception
            End Try
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function DecimalTryParseRoutine() As Long
        Dim d As Decimal
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            If Decimal.TryParse(s, d) Then
            Else
            End If
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function DoubleParseRoutine() As Long
        Dim d As Double
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            Try
                d = Double.Parse(s)
            Catch ex As Exception
            End Try
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function DoubleTryParseRoutine() As Long
        Dim d As Double
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            If Double.TryParse(s, d) Then
            Else
            End If
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function DateTimeParseRoutine() As Long
        Dim d As DateTime
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            Try
                d = DateTime.Parse(s)
            Catch ex As Exception
            End Try
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Function DateTimeTryParseRoutine() As Long
        Dim d As DateTime
        _sw = Stopwatch.StartNew()
        For Each s As String In _str
            If DateTime.TryParse(s, d) Then
            Else
            End If
        Next
        _sw.Stop()
        Return _sw.ElapsedMilliseconds
    End Function

    Private Sub RunButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunButton.Click
        Cursor = Cursors.WaitCursor

        WebBrowser1.DocumentText = ""

        Dim sb As New System.Text.StringBuilder
        Dim parseTime As Long
        Dim tryParseTime As Long

        sb.Append("<table width='400px'>")
        sb.Append("<tr><td><b>Datatype</b><td><b>Parse</b><td><b>TryParse</b>")

        NumberFill()        
        sb.Append("<tr><td><code>Int32</code>")
        parseTime = Int32ParseRoutine()
        tryParseTime = Int32TryParseRoutine()
        sb.Append(TimeResult(parseTime, tryParseTime))

        NumberFill()        
        sb.Append("<tr><td><code>Decimal</code>")
        parseTime = DecimalParseRoutine()
        tryParseTime = DecimalTryParseRoutine()
        sb.Append(TimeResult(parseTime, tryParseTime))

        NumberFill()
        sb.Append("<tr><td><code>Double</code>")
        parseTime = DoubleParseRoutine()
        tryParseTime = DoubleTryParseRoutine()
        sb.Append(TimeResult(parseTime, tryParseTime))

        DateTimeFill()
        sb.Append("<tr><td><code>DateTime</code>")
        parseTime = DateTimeParseRoutine()
        tryParseTime = DateTimeTryParseRoutine()
        sb.Append(TimeResult(parseTime, tryParseTime))

        sb.Append("</table>")
        WebBrowser1.DocumentText = sb.ToString

        Cursor = Cursors.Arrow
    End Sub

    Private Function TimeResult(ByVal parseTime As Long, ByVal tryParseTime As Long) As String
        Return "<td><span style='color:red'>" & parseTime & " ms</span><td>" & tryParseTime & "ms"
    End Function

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

End Class