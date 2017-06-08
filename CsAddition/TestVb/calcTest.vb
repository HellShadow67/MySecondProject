Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports CsAddition



'''<summary>
'''Classe de test pour calcTest, destinée à contenir tous
'''les tests unitaires calcTest
'''</summary>
<TestClass()> _
Public Class calcTest


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
    '''Test pour Constructeur calc
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub calcConstructorTest()
        Dim a As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim b As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim target As calc_Accessor = New calc_Accessor(a, b)
        Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible")
    End Sub

    '''<summary>
    '''Test pour Constructeur calc
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub calcConstructorTest1()
        Dim a As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim b As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim c As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim target As calc_Accessor = New calc_Accessor(a, b, c)
        Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible")
    End Sub

    '''<summary>
    '''Test pour Constructeur calc
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub calcConstructorTest2()
        Dim target As calc_Accessor = New calc_Accessor()
        Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest()
        Dim target As calc_Accessor = New calc_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim a As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim b As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim c As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim d As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim expected As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim actual As Double
        actual = target.addition(a, b, c, d)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest1()
        Dim target As calc_Accessor = New calc_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim expected As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim actual As Double
        actual = target.addition
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest2()
        Dim target As calc_Accessor = New calc_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim a As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim b As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim c As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim expected As Double = 0.0! ' TODO: initialisez à une valeur appropriée
        Dim actual As Double
        actual = target.addition(a, b, c)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest3()
        Dim target As calc_Accessor = New calc_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim a As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim b As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim expected As String = String.Empty ' TODO: initialisez à une valeur appropriée
        Dim actual As String
        actual = target.addition(a, b)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")
    End Sub

    '''<summary>
    '''Test pour addition
    '''</summary>
    <TestMethod(), _
     DeploymentItem("CsAddition.exe")> _
    Public Sub additionTest4()
        Dim target As calc_Accessor = New calc_Accessor() ' TODO: initialisez à une valeur appropriée
        Dim a As Double = 5.0! ' TODO: initialisez à une valeur appropriée
        Dim b As Double = 3.0! ' TODO: initialisez à une valeur appropriée
        Dim expected As Double = 9.0! ' TODO: initialisez à une valeur appropriée
        Dim actual As Double
        actual = target.addition(a, b)
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Vérifiez l'exactitude de cette méthode de test.")  // ne peut pas tirer de conclusion
    End Sub
End Class
