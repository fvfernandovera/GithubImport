Imports System.Net
Imports GithubImport.BPIWebService.BPI.Models


Public Class Controller_GithubImport

    Private _uri As String
    'Private Const _uri As String = "https://bpiodata.moravia.com/"

    Private creds As NetworkCredential
    Private servers As Collection

    Private _domain As String
    Private _user As String
    Private _password As String

    Public Event Notification(source As String, teamproject As String, msg As String)

    Sub New(apiURL As String, apiUser As String, apiPassword As String, domain As String, user As String, password As String)

        _uri = apiURL

        servers = New Collection
        creds = New NetworkCredential(apiUser, apiPassword)

        _domain = domain
        _user = user
        _password = password

    End Sub


    Public Function GetSources() As Collection

        GetSources = New Collection


        Dim contServ As New [Default].Container(New Uri(_uri)) With
         {.Credentials = creds}


        For Each p As PersonsExternalView In contServ.PersonsExternalView
            GetSources.Add(p)
        Next

        Return GetSources

    End Function

End Class
