Public Class Voiture


    Private monNomVehicule As String ' Nom du nouveau véhicule
    Private monAgeVehicule As String ' Age du véhicule
    Private monAcienVehicule As String ' Nom de l'ancien véhicule

    Private PremiereDateImmatriculation As String
    Private anneeModele As String
    Private numeroImmatriculation As String
    Private numeroSerie As String
    Private puissance As String

    Sub New()

        ' Constructeur

    End Sub
    Function getAll() As String
        Dim all As String
        all = "Ancien véhicule: " + monAcienVehicule + Environment.NewLine + "Nouveau véhicule: " + monNomVehicule + Environment.NewLine + "Age: " + monAgeVehicule + Environment.NewLine + "Date de 1ère immatriculation: " + PremiereDateImmatriculation + Environment.NewLine + "Année du modèle:" + anneeModele + Environment.NewLine + "Numero d'immatriculation:" + numeroImmatriculation + Environment.NewLine + "Numero de serie: " + numeroSerie + Environment.NewLine + "Puissance: " + puissance
        Return all

    End Function

    Sub setPremiereDateImmatriculation(ByVal dateImm As String)

        PremiereDateImmatriculation = dateImm

    End Sub
    Function getPremiereDateImmatriculation() As String

        Return PremiereDateImmatriculation

    End Function

    Sub setAnneeModele(ByVal annMod As String)

        anneeModele = annMod

    End Sub
    Function getAnneeModele() As String

        Return anneeModele

    End Function
    Sub setNumeroImmatriculation(ByVal numImm As String)

        numeroImmatriculation = numImm

    End Sub
    Function getNumeroImmatriculation() As String
        Return numeroImmatriculation
    End Function
    Sub setNumeroSerie(ByVal NumSer As String)

        numeroSerie = NumSer

    End Sub
    Function getNumeroSerie() As String
        Return numeroSerie
    End Function
    Sub setPuissance(ByVal Puiss As String)

        puissance = Puiss

    End Sub
    Function getPuissance() As String
        Return puissance
    End Function

    Sub New(ByVal nom As String, ByVal age As String, ByVal ancien As String, ByVal dateImm As String, ByVal annMod As String, ByVal numImm As String, ByVal numSer As String, ByVal puiss As String)
        monNomVehicule = nom
        monAgeVehicule = age
        monAcienVehicule = ancien
        PremiereDateImmatriculation = dateImm
        anneeModele = annMod
        numeroImmatriculation = numImm
        numeroSerie = numSer
        puissance = puiss
    End Sub

    Sub setReste(ByVal dateImm As String, ByVal annMod As String, ByVal numImm As String, ByVal numSer As String, ByVal puiss As String)
        PremiereDateImmatriculation = dateImm
        anneeModele = annMod
        numeroImmatriculation = numImm
        numeroSerie = numSer
        puissance = puiss
    End Sub

    '

    Sub New(ByVal NouveauNomVehicule As String)

        monNomVehicule = NouveauNomVehicule

    End Sub

     


    Sub setNomVehicule(ByVal nomVeh As String)

        monNomVehicule = nomVeh

    End Sub
    Function getNomVehicule() As String
        Return monNomVehicule
    End Function
    Sub setMonAgeVehicule(ByVal age As String)

        monAgeVehicule = age

    End Sub
    Function getAgeVehicule() As String
        Return monAgeVehicule
    End Function
    Sub setMonAcienVehicule(ByVal anc As String)

        monAcienVehicule = anc

    End Sub
    Function getAncienVehicule() As String
        Return monAcienVehicule
    End Function



    ''
    '' reste les property 

End Class
