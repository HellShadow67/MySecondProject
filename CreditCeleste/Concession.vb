Public Class Concession

    Private monNomConcession As String  ' nom de la concession
    Private monAdresseConcession As String   ' Adresse de la concession
    '
    ' Une collection de Vendeur
    ''
    '
    Public LesVendeurs As New List(Of Vendeur)  ' Collection de vendeurs, collection fortement typé (que des objets Vendeur)
    Public LesVendeurs1 As List(Of Object)

    ' Une collection de client ????
    '

    '
    '
    '' constructeur
    '

    Sub New()

    End Sub

    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String)

        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession

    End Sub

    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String, ByVal lesVendeur As List(Of Vendeur))

        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession


    End Sub

    '
    '' constructeur, a créer selon le besoin
    '
    ' get et st // property
    '



End Class
