Public Class Vendeur

    Private monIdentifiantVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String

    Sub New()

    End Sub

    Sub New(ByVal id As String, ByVal nom As String, ByVal prenom As String)
        monIdentifiantVendeur = id
        monNomVendeur = nom
        monPrenomVendeur = prenom
    End Sub


    Public Property setmonIdentifiantVendeur(ByVal idVendeur As String)
        Get
            Return monIdentifiantVendeur
        End Get
        Set(value)
            monIdentifiantVendeur = idVendeur
        End Set
    End Property

    Sub setVendeur(ByVal id As String, ByVal nom As String, ByVal prenom As String)
        monIdentifiantVendeur = id
        monNomVendeur = nom
        monPrenomVendeur = prenom
    End Sub

    Sub setIdVendeur(ByVal id As String)
        monIdentifiantVendeur = id
    End Sub

    Sub setNomVendeur(ByVal id As String)
        monNomVendeur = id
    End Sub

    Sub setPrenomVendeur(ByVal id As String)
        monPrenomVendeur = id
    End Sub

    Function getInfoVendeur() As String

        Return monIdentifiantVendeur + " " + monNomVendeur + " " + monPrenomVendeur

    End Function


End Class
