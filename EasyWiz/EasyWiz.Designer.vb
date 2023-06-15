<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EasyWiz
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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxComputerName = New System.Windows.Forms.TextBox()
        Me.TextBoxOSVersion = New System.Windows.Forms.TextBox()
        Me.TextBoxOSFullName = New System.Windows.Forms.TextBox()
        Me.TextBoxCurrentUser = New System.Windows.Forms.TextBox()
        Me.TextBox64Bit = New System.Windows.Forms.TextBox()
        Me.TextBoxSystemDirectory = New System.Windows.Forms.TextBox()
        Me.TextBoxDomain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(12, 238)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(402, 23)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check Information"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Machine Name : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "OS Version : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Current User : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "64 Bits : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "System Directory: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Domain : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "OS Full Name : "
        '
        'TextBoxComputerName
        '
        Me.TextBoxComputerName.Location = New System.Drawing.Point(154, 28)
        Me.TextBoxComputerName.Name = "TextBoxComputerName"
        Me.TextBoxComputerName.Size = New System.Drawing.Size(260, 22)
        Me.TextBoxComputerName.TabIndex = 11
        Me.TextBoxComputerName.Text = "NaN"
        '
        'TextBoxOSVersion
        '
        Me.TextBoxOSVersion.Location = New System.Drawing.Point(154, 56)
        Me.TextBoxOSVersion.Name = "TextBoxOSVersion"
        Me.TextBoxOSVersion.Size = New System.Drawing.Size(260, 22)
        Me.TextBoxOSVersion.TabIndex = 12
        Me.TextBoxOSVersion.Text = "NaN"
        '
        'TextBoxOSFullName
        '
        Me.TextBoxOSFullName.Location = New System.Drawing.Point(154, 84)
        Me.TextBoxOSFullName.Name = "TextBoxOSFullName"
        Me.TextBoxOSFullName.Size = New System.Drawing.Size(260, 22)
        Me.TextBoxOSFullName.TabIndex = 13
        Me.TextBoxOSFullName.Text = "NaN"
        '
        'TextBoxCurrentUser
        '
        Me.TextBoxCurrentUser.Location = New System.Drawing.Point(154, 112)
        Me.TextBoxCurrentUser.Name = "TextBoxCurrentUser"
        Me.TextBoxCurrentUser.Size = New System.Drawing.Size(260, 22)
        Me.TextBoxCurrentUser.TabIndex = 14
        Me.TextBoxCurrentUser.Text = "NaN"
        '
        'TextBox64Bit
        '
        Me.TextBox64Bit.Location = New System.Drawing.Point(154, 140)
        Me.TextBox64Bit.Name = "TextBox64Bit"
        Me.TextBox64Bit.Size = New System.Drawing.Size(260, 22)
        Me.TextBox64Bit.TabIndex = 15
        Me.TextBox64Bit.Text = "NaN"
        '
        'TextBoxSystemDirectory
        '
        Me.TextBoxSystemDirectory.Location = New System.Drawing.Point(154, 168)
        Me.TextBoxSystemDirectory.Name = "TextBoxSystemDirectory"
        Me.TextBoxSystemDirectory.Size = New System.Drawing.Size(260, 22)
        Me.TextBoxSystemDirectory.TabIndex = 16
        Me.TextBoxSystemDirectory.Text = "NaN"
        '
        'TextBoxDomain
        '
        Me.TextBoxDomain.Location = New System.Drawing.Point(154, 196)
        Me.TextBoxDomain.Name = "TextBoxDomain"
        Me.TextBoxDomain.Size = New System.Drawing.Size(260, 22)
        Me.TextBoxDomain.TabIndex = 17
        Me.TextBoxDomain.Text = "NaN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 273)
        Me.Controls.Add(Me.TextBoxDomain)
        Me.Controls.Add(Me.TextBoxSystemDirectory)
        Me.Controls.Add(Me.TextBox64Bit)
        Me.Controls.Add(Me.TextBoxCurrentUser)
        Me.Controls.Add(Me.TextBoxOSFullName)
        Me.Controls.Add(Me.TextBoxOSVersion)
        Me.Controls.Add(Me.TextBoxComputerName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCheck)
        Me.Name = "Form1"
        Me.Text = "EasyWiz 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxComputerName As TextBox
    Friend WithEvents TextBoxOSVersion As TextBox
    Friend WithEvents TextBoxOSFullName As TextBox
    Friend WithEvents TextBoxCurrentUser As TextBox
    Friend WithEvents TextBox64Bit As TextBox
    Friend WithEvents TextBoxSystemDirectory As TextBox
    Friend WithEvents TextBoxDomain As TextBox
End Class
