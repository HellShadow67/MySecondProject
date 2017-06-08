Imports System.Data.SqlClient

Public Class Credit
    Inherits Pret

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(duree As Integer, mensualite As Double, taux As Double, montant As Double)
        MyBase.New(duree, mensualite, taux, montant)
    End Sub

    Public Overrides Function getMontant(duree As Integer, mensualite As Double, taux As Double) As Double
        Dim Resultat = mensualite * (1 - (1 + ((taux / 100) / 12)) ^ (-duree)) / ((taux / 100) / 12)
        Return Resultat
    End Function

    Public Overrides Function getMensualite(duree As Integer, montant As Double, taux As Double) As Double

        Dim Resultat = (montant * ((taux / 100) / 12) / (1 - (1 + (taux / 100) / 12) ^ (-duree)))

        Return Resultat
    End Function

End Class
