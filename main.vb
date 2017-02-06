Imports System.Net.Mail
Public Class Form1

    Dim Myusername As String
    Dim Mypassword As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendingEmail()

    End Sub

    Private Function SendingEmail()
        Myusername = From.Text()
        Mypassword = Password.Text()
        'acquiring message information'
        Dim EMAIL As New MailMessage
        EMAIL.Subject() = Subject.Text()
        EMAIL.To.Add(Toperson.Text())
        EMAIL.From = New MailAddress(Myusername)
        EMAIL.Body = Message.Text()

        'creating SMTP protocol'
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials() = New System.Net.NetworkCredential(Myusername, Mypassword)
        SMTP.Port = "587"
        SMTP.Send(EMAIL)

    End Function
End Class
