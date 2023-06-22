Public Class EasyWiz

    'Easy Wiz 1.0
    'Provided for non-commercial use. Please refer to Github Repo for more information. 
    'Contact: Sherman_tan@outlook.com
    '(C) Tan Wei Qiang Sherman.

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        TextBoxComputerName.Text = Environment.MachineName
        TextBoxOSVersion.Text = System.Environment.OSVersion.ToString
        TextBoxOSFullName.Text = My.Computer.Info.OSFullName
        TextBoxCurrentUser.Text = System.Environment.UserName
        TextBox64Bit.Text = System.Environment.Is64BitOperatingSystem
        TextBoxSystemDirectory.Text = System.Environment.SystemDirectory
        TextBoxDomain.Text = System.Environment.UserDomainName
    End Sub
End Class
