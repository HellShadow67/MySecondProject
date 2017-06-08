Imports CsClient

Public Class ClientVoit
    Inherits Class1

    Public saVoiture As New Voiture

    Public Sub Class1(numCli As Integer, nomCli As String, prenomCli As String, adresseCli As String, identCli As String)
        MyBase.setAll(numCli, nomCli, prenomCli, adresseCli, identCli)
    End Sub

    Public Sub setNomClientVoit(nomCli As String)
        MyBase.setNomClient(nomCli)
    End Sub


    Public Sub setPrenomClientVoit(prenomCli As String)
        MyBase.setPrenomClient(prenomCli)
    End Sub
    Public Function getNomClientVoit() As String
        Return MyBase.getNomClient()
    End Function


    Public Function getPrenomClientVoit() As String
        Return MyBase.getPrenomClient()
    End Function
End Class
