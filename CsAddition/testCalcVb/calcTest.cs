using CsAddition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testCalcVb
{
    
    
    /// <summary>
    ///Classe de test pour calcTest, destinée à contenir tous
    ///les tests unitaires calcTest
    ///</summary>
    [TestClass()]
    public class calcTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur calc
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void calcConstructorTest()
        {
            double a = 0F; // TODO: initialisez à une valeur appropriée
            double b = 0F; // TODO: initialisez à une valeur appropriée
            calc_Accessor target = new calc_Accessor(a, b);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur calc
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void calcConstructorTest1()
        {
            double a = 0F; // TODO: initialisez à une valeur appropriée
            double b = 0F; // TODO: initialisez à une valeur appropriée
            double c = 0F; // TODO: initialisez à une valeur appropriée
            calc_Accessor target = new calc_Accessor(a, b, c);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur calc
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void calcConstructorTest2()
        {
            calc_Accessor target = new calc_Accessor();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest()
        {
            calc_Accessor target = new calc_Accessor(); // TODO: initialisez à une valeur appropriée
            double a = 0F; // TODO: initialisez à une valeur appropriée
            double b = 0F; // TODO: initialisez à une valeur appropriée
            double c = 0F; // TODO: initialisez à une valeur appropriée
            double d = 0F; // TODO: initialisez à une valeur appropriée
            double expected = 0F; // TODO: initialisez à une valeur appropriée
            double actual;
            actual = target.addition(a, b, c, d);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest1()
        {
            calc_Accessor target = new calc_Accessor(); // TODO: initialisez à une valeur appropriée
            double expected = 0F; // TODO: initialisez à une valeur appropriée
            double actual;
            actual = target.addition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest2()
        {
            calc_Accessor target = new calc_Accessor(); // TODO: initialisez à une valeur appropriée
            double a = 0F; // TODO: initialisez à une valeur appropriée
            double b = 0F; // TODO: initialisez à une valeur appropriée
            double c = 0F; // TODO: initialisez à une valeur appropriée
            double expected = 0F; // TODO: initialisez à une valeur appropriée
            double actual;
            actual = target.addition(a, b, c);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest3()
        {
            calc_Accessor target = new calc_Accessor(); // TODO: initialisez à une valeur appropriée
            string a = string.Empty; // TODO: initialisez à une valeur appropriée
            string b = string.Empty; // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.addition(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest4()
        {
            calc_Accessor target = new calc_Accessor(); // TODO: initialisez à une valeur appropriée
            double a = 0F; // TODO: initialisez à une valeur appropriée
            double b = 0F; // TODO: initialisez à une valeur appropriée
            double expected = 0F; // TODO: initialisez à une valeur appropriée
            double actual;
            actual = target.addition(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
