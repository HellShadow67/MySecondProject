Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports CsAddition.Properties



'''<summary>
'''Classe de test pour ResourcesTest, destinée à contenir tous
'''les tests unitaires ResourcesTest
'''</summary>
<TestClass()> _
Public Class ResourcesTest


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
    '''Test pour Constructeur Resources
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub ResourcesConstructorTest()
        'Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. " & _
                "Régénérez le projet contenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour Culture
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub CultureTest()
        'Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. " & _
                "Régénérez le projet contenant ou exécutez Publicize.exe manuellement.")
    End Sub

    '''<summary>
    '''Test pour ResourceManager
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub ResourceManagerTest()
        'Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
        Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. " & _
                "Régénérez le projet contenant ou exécutez Publicize.exe manuellement.")
    End Sub
End Class
