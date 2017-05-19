Public MustInherit Class Pret

    Protected monMontant As Double
    Protected maDuree As Integer
    Protected maMensualite As Double
    Protected monTaux As Double

    ' => en private 

    Sub New()

    End Sub

    '=> vide, seulement plan!!!!

    Sub New(montant As Double, duree As Integer, mensualite As Double, taux As Double)
        monMontant = montant
        maDuree = duree
        maMensualite = mensualite
        monTaux = taux
    End Sub

    Sub New(duree As Integer, mensualite As Double, taux As Double)
        maDuree = duree
        maMensualite = mensualite
        monTaux = taux
        monMontant = (maMensualite * (1 - (1 + monTaux) ^ maDuree * 12) / monTaux)
    End Sub

    Sub New(montant As Double, duree As Integer, taux As Double)
        monMontant = montant
        maDuree = duree
        monTaux = taux
        maMensualite = (montant * ((taux / 100) / 12)) / (1 - (1 + (taux / 100) / 12) ^ -duree)
    End Sub


    Function getMensualites() As Double
        Return maMensualite
    End Function

    Overridable Function getMontant(duree As Integer, mensualite As Double, taux As Double) As Double
        taux = taux / 100

        monMontant = (mensualite * (1 - (1 + (taux / 12)) ^ -duree)) / (taux / 12)
        Return monMontant
    End Function

    Overridable Function getMensualites(montant As Double, duree As Integer, taux As Double) As Double
        taux = taux / 100

        maMensualite = (montant * taux) / (1 - Math.Pow((1 + taux), -duree))
        Return maMensualite
    End Function

End Class
