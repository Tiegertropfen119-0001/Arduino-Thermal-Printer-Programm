Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("1")
        MyCOMPort.Close()
        MyCOMPort.Open()
        MyCOMPort.Write(TextBox1.Text)
        MyCOMPort.Close()

        TextBox1.Text = ""
        Label1.Text += 0.5
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("2")

        MyCOMPort.Close()
        MyCOMPort.Open()
        MyCOMPort.Write(RichTextBox1.Text)
        MyCOMPort.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("3")

        MyCOMPort.Close()
        MyCOMPort.Open()
        MyCOMPort.Write(RichTextBox1.Text)
        MyCOMPort.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("4")

        MyCOMPort.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("5")

        MyCOMPort.Close()
        MyCOMPort.Open()
        MyCOMPort.Write(RichTextBox1.Text)
        MyCOMPort.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("6")

        MyCOMPort.Close()
        MyCOMPort.Open()
        MyCOMPort.Write(RichTextBox1.Text)
        MyCOMPort.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("7")

        MyCOMPort.Close()
        MyCOMPort.Open()
        MyCOMPort.Write(RichTextBox1.Text)
        MyCOMPort.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("98")

        MyCOMPort.Close()
        MsgBox("Please wait 3000ms")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim MyCOMPort As SerialPort
        MyCOMPort = New SerialPort()
        MyCOMPort.PortName = "COM3"
        MyCOMPort.BaudRate = 57600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.Open()
        MyCOMPort.Write("99")

        MyCOMPort.Close()
        MsgBox("Please wait 1500ms")
    End Sub
End Class
