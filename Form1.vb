Imports System.Net.Sockets
Imports System.Threading
Imports TouchlessLib
Imports System.Net
Imports System.Text
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Imports System.Net.Sockets.Socket
Imports System




Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim subscriber As New UdpClient()
    Dim publisher As New UdpClient()
    Dim mycomputername As String = Environment.MachineName
    Dim mycomputerIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(mycomputername)

    Dim Touchless As New TouchlessLib.TouchlessMgr
    Dim Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)
    Dim picsize As Size = New Size(160, 120)

    Public receivingUdpClient As UdpClient
    Public RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
    Public ThreadReceive As System.Threading.Thread

    Dim SocketNO As Integer
    Dim GLOIP As IPAddress
    Dim GLOINTPORT As Integer
    Dim bytCommand As Byte() = New Byte() {}
    Dim udpClient As New UdpClient

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        publisher.Client.Blocking = False
        subscriber.Client.ReceiveTimeout = 100
        subscriber.Client.Blocking = False
        subscriber.ExclusiveAddressUse = False
        publisher.ExclusiveAddressUse = False
        TextBox1.Text = ""

        Label3.Text = "This Computer Name: " & Environment.MachineName

        Touchless.CurrentCamera = Camera1
        Touchless.CurrentCamera.CaptureWidth = picsize.Width
        Touchless.CurrentCamera.CaptureHeight = picsize.Height


        AxVideoChatReceiver2.ReceiveAudioStream = True
        AxVideoChatReceiver2.ReceiveVideoStream = False

        AxVideoChatReceiver2.Listen(Convert.ToString(mycomputerIP), 1234)
        subscriber.Client.Bind(New Net.IPEndPoint(Net.IPAddress.Any, 2013))


    End Sub
    Public Sub ReceiveMessages()
        Try
            Dim receiveBytes As [Byte]() = receivingUdpClient.Receive(RemoteIpEndPoint)
            txtIP1.Text = RemoteIpEndPoint.Address.ToString
            Dim BitDet As BitArray
            BitDet = New BitArray(receiveBytes)

            Dim strReturnData As String = System.Text.Encoding.Unicode.GetString(receiveBytes)

            TextBox2.Text = TextBox2.Text + vbCrLf + "Recieved Message:"
            If (Encoding.ASCII.GetChars(receiveBytes) = "End call") Then


                MyBase.Close()
                Application.Restart()

            End If
            TextBox2.Text = TextBox2.Text & Encoding.ASCII.GetChars(receiveBytes) + ""
            TextBox2.Text = TextBox2.Text & vbCrLf

            TextBox2.Text = TextBox2.Text & vbCrLf
            NewInitialize()
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
    End Sub
    Public Sub NewInitialize()
        Console.WriteLine("Thread *Thread Receive* reinitialized")
        ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessages)
        ThreadReceive.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        Try

            Dim bitmapz As Bitmap = New Bitmap(picsize.Width, picsize.Height)
            bitmapz = Touchless.CurrentCamera.GetCurrentImage
            PictureBox1.Image = bitmapz

            Dim sendbytes() As Byte
            bytesfromimage(sendbytes, bitmapz)

            publisher.Send(sendbytes, sendbytes.Length)
        Catch ex As Exception
        End Try


        Try

            Dim ep As System.Net.IPEndPoint = New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)

            Dim rcvbytes() As Byte = subscriber.Receive(ep)
            Dim bitmapz As Bitmap = New Bitmap(picsize.Width, picsize.Height)
            imagefrombytes(rcvbytes, bitmapz)
            PictureBox2.Image = bitmapz

        Catch ex As Exception
        End Try

    End Sub



    Private Sub imagefrombytes(ByRef bytez() As Byte, ByRef piccolor As Bitmap)
        Dim rect As New Rectangle(0, 0, piccolor.Width, piccolor.Height)
        Dim bmpData As System.Drawing.Imaging.BitmapData = piccolor.LockBits(rect,
            Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format32bppRgb)
        Dim ptr As IntPtr = bmpData.Scan0
        Dim bytes As Integer = bmpData.Stride * piccolor.Height
        Dim rgbValues(bytes - 1) As Byte
        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

        Dim secondcounter As Integer
        Dim tempred As Integer
        Dim tempblue As Integer
        Dim tempgreen As Integer
        Dim tempalpha As Integer
        secondcounter = 0

        While secondcounter < rgbValues.Length
            tempblue = rgbValues(secondcounter)
            tempgreen = rgbValues(secondcounter + 1)
            tempred = rgbValues(secondcounter + 2)
            tempalpha = rgbValues(secondcounter + 3)
            tempalpha = 255

            tempred = bytez(((secondcounter * 0.25) * 3) + 0)
            tempgreen = bytez(((secondcounter * 0.25) * 3) + 1)
            tempblue = bytez(((secondcounter * 0.25) * 3) + 2)

            rgbValues(secondcounter) = tempblue
            rgbValues(secondcounter + 1) = tempgreen
            rgbValues(secondcounter + 2) = tempred
            rgbValues(secondcounter + 3) = tempalpha

            secondcounter = secondcounter + 4
        End While


        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes)

        piccolor.UnlockBits(bmpData)
        Label5.Text = "Connected...!"

    End Sub
    Private Sub bytesfromimage(ByRef bytez() As Byte, ByRef piccolor As Bitmap)
        Dim rect As New Rectangle(0, 0, piccolor.Width, piccolor.Height)
        Dim bmpData As System.Drawing.Imaging.BitmapData = piccolor.LockBits(rect,
            Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format32bppRgb)
        Dim ptr As IntPtr = bmpData.Scan0
        Dim bytes As Integer = bmpData.Stride * piccolor.Height
        Dim rgbValues(bytes - 1) As Byte
        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

        Dim secondcounter As Integer
        Dim tempred As Integer
        Dim tempblue As Integer
        Dim tempgreen As Integer
        Dim tempalpha As Integer
        secondcounter = 0
        Dim bytelist As List(Of Byte) = New List(Of Byte)

        While secondcounter < rgbValues.Length
            tempblue = rgbValues(secondcounter)
            tempgreen = rgbValues(secondcounter + 1)
            tempred = rgbValues(secondcounter + 2)
            tempalpha = rgbValues(secondcounter + 3)
            tempalpha = 255

            bytelist.Add(tempred)
            bytelist.Add(tempgreen)
            bytelist.Add(tempblue)

            rgbValues(secondcounter) = tempblue
            rgbValues(secondcounter + 1) = tempgreen
            rgbValues(secondcounter + 2) = tempred
            rgbValues(secondcounter + 3) = tempalpha

            secondcounter = secondcounter + 4
        End While


        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes)

        piccolor.UnlockBits(bmpData)

        Dim bytearray(bytelist.Count - 1) As Byte
        For i = 0 To bytelist.Count - 1
            bytearray(i) = bytelist(i)
        Next
        bytez = bytearray

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Try
            SocketNO = "11000"
            receivingUdpClient = New System.Net.Sockets.UdpClient(SocketNO)
            ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessages)
            ThreadReceive.Start()

        Catch x As Exception
            Console.WriteLine(x.Message)
            TextBox2.Text = TextBox2.Text & vbCrLf & x.Message
        End Try

        publisher.Connect(TextBox1.Text, 2013)

        AxVideoChatSender1.VideoDevice = 0
        AxVideoChatSender1.AudioDevice = 0
        AxVideoChatSender1.VideoFormat = 0
        AxVideoChatSender1.FrameRate = 15
        AxVideoChatSender1.VideoBitrate = 128000
        AxVideoChatSender1.AudioComplexity = 0
        AxVideoChatSender1.AudioQuality = 8
        AxVideoChatSender1.SendAudioStream = True
        AxVideoChatSender1.SendVideoStream = False

        AxVideoChatSender1.Connect(TextBox1.Text, 1234)

        AxVideoChatReceiver1.ReceiveAudioStream = True
        AxVideoChatReceiver1.ReceiveVideoStream = False

        AxVideoChatReceiver2.ReceiveAudioStream = True
        AxVideoChatReceiver2.ReceiveVideoStream = False

        AxVideoChatReceiver2.Listen(Convert.ToString(mycomputerIP), 1234)
        Label5.Text = "Waiting for " + ListBox1.SelectedItem + " to accept the call."


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        TextBox1.Text = " "
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedIndex = 0) Then
            TextBox1.Text = "169.254.65.100"
        End If
        If (ListBox1.SelectedIndex = 1) Then
            TextBox1.Text = "169.254.222.209"
        End If
        If (ListBox1.SelectedIndex = 2) Then
            TextBox1.Text = "169.254.193.89"
        End If
        If (ListBox1.SelectedIndex = 3) Then
            TextBox1.Text = "192.168.1.1"
        End If
        If (ListBox1.SelectedIndex = 4) Then
            TextBox1.Text = "192.0.0.1"
        End If
        If (ListBox1.SelectedIndex = 5) Then
            TextBox1.Text = "169.0.0.2"
        End If
        If (ListBox1.SelectedIndex = 6) Then
            TextBox1.Text = "This Index is Empty"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pRet As Integer

        Try
            GLOIP = IPAddress.Parse(TextBox1.Text)
            GLOINTPORT = "11000"
            udpClient.Connect(GLOIP, GLOINTPORT)
            bytCommand = Encoding.ASCII.GetBytes("End call")
            pRet = udpClient.Send(bytCommand, bytCommand.Length)

            Console.WriteLine(Encoding.ASCII.GetString(bytCommand))
            TextBox2.Text = TextBox2.Text + vbCrLf + "Sent Message: "
            TextBox2.Text = TextBox2.Text & Encoding.ASCII.GetChars(bytCommand) & ""

            TextBox2.Text = TextBox2.Text + vbCrLf
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            TextBox2.Text = TextBox2.Text & vbCrLf & ex.Message
        End Try
        Try
            ThreadReceive.Abort()
            receivingUdpClient.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        AxVideoChatSender1.Disconnect()
        AxVideoChatReceiver1.Disconnect()
        AxVideoChatReceiver2.Disconnect()


        publisher.Client.Close()
        subscriber.Client.Close()

        udpClient.Client.Close()

        Application.Restart()



    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pRet As Integer

        Try
            GLOIP = IPAddress.Parse(TextBox1.Text)
            GLOINTPORT = "11000"
            udpClient.Connect(GLOIP, GLOINTPORT)
            bytCommand = Encoding.ASCII.GetBytes(txtMessage.Text)
            pRet = udpClient.Send(bytCommand, bytCommand.Length)

            Console.WriteLine(Encoding.ASCII.GetString(bytCommand))
            TextBox2.Text = TextBox2.Text + vbCrLf + "Sent Message: "
            TextBox2.Text = TextBox2.Text & Encoding.ASCII.GetChars(bytCommand) & ""

            TextBox2.Text = TextBox2.Text + vbCrLf
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            TextBox2.Text = TextBox2.Text & vbCrLf & ex.Message
        End Try
        txtMessage.Text = ""
    End Sub

    

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.SelectionStart = TextBox2.TextLength
        TextBox2.ScrollToCaret()


    End Sub

   
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            ThreadReceive.Abort()
            receivingUdpClient.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        AxVideoChatSender1.Disconnect()
        AxVideoChatReceiver1.Disconnect()
        AxVideoChatReceiver2.Disconnect()


        publisher.Client.Close()
        subscriber.Client.Close()

        udpClient.Client.Close()
        Application.Restart()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ThreadReceive.Abort()
            receivingUdpClient.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        AxVideoChatSender1.Disconnect()
        AxVideoChatReceiver1.Disconnect()
        AxVideoChatReceiver2.Disconnect()


        publisher.Client.Close()
        subscriber.Client.Close()

        udpClient.Client.Close()
        Application.Exit()

    End Sub
End Class



