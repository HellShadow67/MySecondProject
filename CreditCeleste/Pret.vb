Public Class Pret

    Private monMontant As Double ' montant financé
    Private monDuree As Integer ' durée du prêt
    Private monMensualité As Double ' mensualité
    Private monTaux As Double ' taux du prêt

    Sub New()

    End Sub

    Sub New(ByVal montant As Decimal, ByVal duree As Integer, ByVal mensualite As Decimal, ByVal taux As Decimal)
        monMontant = montant
        monDuree = duree
        monMensualité = mensualite
        monTaux = taux  ''4 donées, possible?
    End Sub

    Sub New(ByVal duree As Integer, ByVal mensualite As Decimal, ByVal taux As Decimal)
        monDuree = duree
        monMensualité = mensualite
        monTaux = taux

        '' ? monMontant = 0; // dans ce cas, le montant à financer sera calculée
    End Sub


    Sub New(montant, duree, taux)
        monMontant = montant
        monDuree = duree
        ''monMensualité = ?? '' dans ce cas, la mensualité sera calculée
        monTaux = taux
    End Sub

    Function getMensualités() As Double
        Return monMensualité ''// retourne le montant calculé
    End Function

    ''Function getMensualités() As Double
    '' Return monMensualité ''// retourne une mensualité déjà calculée
    '' End Function

    Function getMensualités(montant, durée, taux) As Double
        ' taux --> proportionnel // en déduit qu’il faut la calculer, vu que les montants sont transmis
        Return monMensualité
    End Function

End Class
