Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports CsAddition



'''<summary>
'''Classe de test pour operationTest, destinée à contenir tous
'''les tests unitaires operationTest
'''</summary>
<TestClass()> _
Public Class operationTest


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


    Private Sub Createoperation()
        'Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" & _
                "tenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest()
        'Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" & _
                "tenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest1()
        'Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" & _
                "tenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest2()
        'Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" & _
                "tenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest3()
        'Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" & _
                "tenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest4()
        'Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" & _
                "tenant ou exécutez Publicize.exe manuellement.")
    End Sub

    Friend Overridable Function Createoperation_Accessor() As operation_Accessor
        'TODO: instanciez une classe concrète appropriée.
        Dim target As operation_Accessor = Nothing
        Return target
    End Function

    '''<summary>
    '''Test pour disBonjour
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub disBonjourTest()
        Dim param0 As PrivateObject = Nothing ' TODO: initialisez à une valeur appropriée
        Dim target As operation_Accessor = New operation_Accessor(param0) ' TODO: initialisez à une valeur appropriée
        Dim expected As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim actual As String
        actual = target.disBonjour
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub
End Class
