Public MustInherit Class Pret

    Private monMontant As Double
    Private maDuree As Integer
    Private maMensualite As Double
    Private monTaux As Double
    Private _nom As String

    Sub New()
        
    End Sub

    Public Sub New(duree As Integer, mensualite As Double, taux As Double, montant As Double)
        maDuree = duree
        maMensualite = mensualite
        monTaux = taux
        monMontant = montant
    End Sub



    Public MustOverride Function getMontant(duree As Integer, mensualite As Double, taux As Double) As Double
    Public MustOverride Function getMensualite(duree As Integer, montant As Double, taux As Double) As Double


End Class
