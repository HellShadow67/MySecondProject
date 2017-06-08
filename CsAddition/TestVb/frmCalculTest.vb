Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports CsAddition



'''<summary>
'''Classe de test pour frmCalculTest, destinée à contenir tous
'''les tests unitaires frmCalculTest
'''</summary>
<TestClass()> _
Public Class frmCalculTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Obtient ou définit le contexte de test qui fournit
    '''des informations sur la série de tests active ainsi que ses fonctionnalités.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Attributs de tests supplémentaires"
    '
    'Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
    '
    'Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''Test pour Constructeur frmCalcul
    '''</summary>
    <TestMethod()> _
    Public Sub frmCalculConstructorTest()
        Dim target As frmCalcul = New frmCalcul()
        Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible")
    End Sub

    '''<summary>
    '''Test pour Dispose
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub DisposeTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim disposing As Boolean = False ' TODO: initialisez à une valeur appropriée
        target.Dispose(disposing)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour InitializeComponent
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub InitializeComponentTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        target.InitializeComponent()
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btn3val_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btn3val_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btn3val_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btn4val_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btn4val_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btn4val_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btnAdditionDblNewPar2_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btnAdditionDblNewPar2_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btnAdditionDblNewPar2_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btnAdditionDblNew_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btnAdditionDblNew_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btnAdditionDblNew_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btnAdditionDblPar2_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btnAdditionDblPar2_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btnAdditionDblPar2_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btnAdditionPar2_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btnAdditionPar2_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btnAdditionPar2_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour btnAddition_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub btnAddition_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.btnAddition_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour cmdAdditionDbl_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub cmdAdditionDbl_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.cmdAdditionDbl_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour cmdBonjour_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub cmdBonjour_ClickTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.cmdBonjour_Click(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour frmCalcul_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub frmCalcul_LoadTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.frmCalcul_Load(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub

    '''<summary>
    '''Test pour txtA_TextChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub txtA_TextChangedTest()
        Dim target As frmCalcul_Accessor = New frmCalcul_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim sender As Object = Nothing ' TODO: initialisez à une valeur appropriée
        Dim e As EventArgs = Nothing ' TODO: initialisez à une valeur appropriée
        target.txtA_TextChanged(sender, e)
        Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.")
    End Sub
End Class
