using CsAddition.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testCalcVb
{
    
    
    /// <summary>
    ///Classe de test pour ResourcesTest, destinée à contenir tous
    ///les tests unitaires ResourcesTest
    ///</summary>
    [TestClass()]
    public class ResourcesTest
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
        ///Test pour Constructeur Resources
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void ResourcesConstructorTest()
        {
            // Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. " +
                    "Régénérez le projet contenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour Culture
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void CultureTest()
        {
            // Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. " +
                    "Régénérez le projet contenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour ResourceManager
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void ResourceManagerTest()
        {
            // Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Resources. " +
                    "Régénérez le projet contenant ou exécutez Publicize.exe manuellement.");
        }
    }
}
