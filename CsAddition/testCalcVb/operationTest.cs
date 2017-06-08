using CsAddition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testCalcVb
{
    
    
    /// <summary>
    ///Classe de test pour operationTest, destinée à contenir tous
    ///les tests unitaires operationTest
    ///</summary>
    [TestClass()]
    public class operationTest
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


        private void Createoperation()
        {
            // Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" +
                    "tenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest()
        {
            // Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" +
                    "tenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest1()
        {
            // Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" +
                    "tenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest2()
        {
            // Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" +
                    "tenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest3()
        {
            // Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" +
                    "tenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour addition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void additionTest4()
        {
            // Impossible de trouver un accesseur private pour addition. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour addition. Régénérez le projet con" +
                    "tenant ou exécutez Publicize.exe manuellement.");
        }

        internal virtual operation_Accessor Createoperation_Accessor()
        {
            // TODO: instanciez une classe concrète appropriée.
            operation_Accessor target = null;
            return target;
        }

        /// <summary>
        ///Test pour disBonjour
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void disBonjourTest()
        {
            PrivateObject param0 = null; // TODO: initialisez à une valeur appropriée
            operation_Accessor target = new operation_Accessor(param0); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.disBonjour();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
