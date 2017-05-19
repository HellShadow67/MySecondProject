Imports System.Data.SqlClient

Public Class Credit
    Inherits Pret

    Sub New()

    End Sub

    Sub New(montant As Double, duree As Integer, mensualite As Double, taux As Double)
        MyBase.New(montant, duree, mensualite, taux)
    End Sub

    Sub New(duree As Integer, mensualite As Double, taux As Double)
        MyBase.New(duree, mensualite, taux)
    End Sub

    Sub New(montant As Double, duree As Integer, taux As Double)
        MyBase.New(montant, duree, taux)
    End Sub


    Sub setMontantFinance(ByVal montant As Double)
        monMontant = montant
    End Sub

    Function getMontantFinance()
        Return monMontant
    End Function

    Sub setTauxAnnuel(ByVal taux As Double)
        monTaux = taux
    End Sub

    Function getTauxAnnuel()
        Return monTaux
    End Function

    Sub setNbreMensualites(ByVal nbreMensualites As Integer)
        maDuree = nbreMensualites
    End Sub

    Function getNbreMensualites()
        Return maDuree
    End Function

    Sub setMontantMensualite(ByVal montantMensualite As Double)
        maMensualite = montantMensualite
    End Sub

    Function getMontantMensualite()
        Return maMensualite
    End Function


    Public Overrides Function getMontant(duree As Integer, mensualite As Double, taux As Double) As Double
        Return MyBase.getMontant(duree, mensualite, taux)
    End Function

    Public Overrides Function getMensualites(montant As Double, duree As Integer, taux As Double) As Double
        Return MyBase.getMensualites(montant, duree, taux)
    End Function

    Public Function enregistreBDD()
        Dim strConn As String
        strConn = "Server=DESKTOP-R0IJ4CS\SQLEXPRESS; Initial Catalog=CreditCeleste;Trusted_Connection=Yes"

        Dim sql = "INSERT INTO Credit(MontantFinance, NombreMensualites, MontantMensualites, TauxAnnuel) VALUES("
        sql &= Str(monMontant) & ", " & Str(maDuree) & ", " & Str(maMensualite) & ", " & Str(monTaux) & ")"

        Dim retMessage As String = "Mise à jour impossible"

        Dim oConnexion As New SqlConnection(strConn)
        Dim oCommand As New SqlCommand(sql, oConnexion)

        Try
            oConnexion.Open()
            oCommand.ExecuteNonQuery()
            oConnexion.Close()
            MsgBox("Crédit enregistré !")
        Catch ex As Exception
            MsgBox(retMessage)
        End Try
    End Function

End Class
