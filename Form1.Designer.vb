<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtIP1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AxVideoChatReceiver1 = New AxVideoChatReceiverLib.AxVideoChatReceiver()
        Me.AxVideoChatSender1 = New AxVideoChatSenderLib.AxVideoChatSender()
        Me.AxVideoChatReceiver2 = New AxVideoChatReceiverLib.AxVideoChatReceiver()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoChatReceiver2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ip share camera"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(482, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(96, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(495, 35)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BIT COMMUNICATION SYSTEM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(54, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "COMPUTER"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SaveFileDialog2
        '
        '
        'TextBox1
        '
        Me.TextBox1.FormattingEnabled = True
        Me.TextBox1.Location = New System.Drawing.Point(164, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 21)
        Me.TextBox1.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(449, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Add New Contact"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Notifications:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(600, 97)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 23)
        Me.btnremove.TabIndex = 20
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Dr. P.S.BISNU", "Dr. KUNTAL MUKHERJEE", "Dr. SANJAY KUMAR", "Dr. B.K SHARMA", "Dr. N.P TIWARY", "Dr.(Mrs) VANDANA ", "Mrs. ONIMMA TIGGA"})
        Me.ListBox1.Location = New System.Drawing.Point(538, 137)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 121)
        Me.ListBox1.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(600, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "End call"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(353, 129)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 122)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(54, 327)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(553, 148)
        Me.TextBox2.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(538, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Send Message"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(54, 301)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(459, 20)
        Me.txtMessage.TabIndex = 26
        '
        'txtIP1
        '
        Me.txtIP1.Location = New System.Drawing.Point(538, 264)
        Me.txtIP1.Name = "txtIP1"
        Me.txtIP1.ReadOnly = True
        Me.txtIP1.Size = New System.Drawing.Size(138, 20)
        Me.txtIP1.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 28
        '
        'AxVideoChatReceiver1
        '
        Me.AxVideoChatReceiver1.Enabled = True
        Me.AxVideoChatReceiver1.Location = New System.Drawing.Point(353, 249)
        Me.AxVideoChatReceiver1.Name = "AxVideoChatReceiver1"
        Me.AxVideoChatReceiver1.OcxState = CType(resources.GetObject("AxVideoChatReceiver1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatReceiver1.Size = New System.Drawing.Size(160, 10)
        Me.AxVideoChatReceiver1.TabIndex = 10
        '
        'AxVideoChatSender1
        '
        Me.AxVideoChatSender1.Enabled = True
        Me.AxVideoChatSender1.Location = New System.Drawing.Point(54, 249)
        Me.AxVideoChatSender1.Name = "AxVideoChatSender1"
        Me.AxVideoChatSender1.OcxState = CType(resources.GetObject("AxVideoChatSender1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatSender1.Size = New System.Drawing.Size(160, 10)
        Me.AxVideoChatSender1.TabIndex = 9
        '
        'AxVideoChatReceiver2
        '
        Me.AxVideoChatReceiver2.Enabled = True
        Me.AxVideoChatReceiver2.Location = New System.Drawing.Point(102, 189)
        Me.AxVideoChatReceiver2.Name = "AxVideoChatReceiver2"
        Me.AxVideoChatReceiver2.OcxState = CType(resources.GetObject("AxVideoChatReceiver2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatReceiver2.Size = New System.Drawing.Size(100, 32)
        Me.AxVideoChatReceiver2.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "You Are Connected To:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(613, 425)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(79, 50)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Exit Application"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 491)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIP1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AxVideoChatReceiver1)
        Me.Controls.Add(Me.AxVideoChatSender1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxVideoChatReceiver2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "BIT COMMUNICATION SYSTEM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoChatReceiver2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AxVideoChatSender1 As AxVideoChatSenderLib.AxVideoChatSender
    Friend WithEvents AxVideoChatReceiver1 As AxVideoChatReceiverLib.AxVideoChatReceiver
    Friend WithEvents TextBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents AxVideoChatReceiver2 As AxVideoChatReceiverLib.AxVideoChatReceiver
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents txtIP1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
End Class
