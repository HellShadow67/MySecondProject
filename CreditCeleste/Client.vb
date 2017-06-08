Public Class Client

    Private monIdentifiantClient As String
    Private monNomClient As String
    Private monPrenomClient As String

    Sub New()

    End Sub

    Sub New(ByVal id As String, ByVal nom As String, ByVal prenom As String)
        monIdentifiantClient = id
        monNomClient = nom
        monPrenomClient = prenom
    End Sub


    Public Property setmonIdentifiantClient(ByVal idClient As String)
        Get
            Return monIdentifiantClient
        End Get
        Set(value)
            monIdentifiantClient = idClient
        End Set
    End Property

    Sub setClient(ByVal id As String, ByVal nom As String, ByVal prenom As String)
        monIdentifiantClient = id
        monNomClient = nom
        monPrenomClient = prenom
    End Sub
    Sub setClientNomPrenom(ByVal nom As String, ByVal prenom As String)
        monIdentifiantClient = ""
        monNomClient = nom
        monPrenomClient = prenom
    End Sub

    Sub setIdClient(ByVal id As String)
        monIdentifiantClient = id
    End Sub

    Sub setNomClient(ByVal id As String)
        monNomClient = id
    End Sub

    Sub setPrenomClient(ByVal id As String)
        monPrenomClient = id
    End Sub

    Function getInfoClient() As String

        Return monIdentifiantClient + " " + monNomClient + " " + monPrenomClient

    End Function

    Function getNomPrenom() As String
        Return monNomClient + " " + monPrenomClient
    End Function
    Function getNom() As String
        Return monNomClient
    End Function
    Function getPrenom() As String
        Return monPrenomClient
    End Function

    Function getId() As String
        Return monIdentifiantClient
    End Function

End Class
