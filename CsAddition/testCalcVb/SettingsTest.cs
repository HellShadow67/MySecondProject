﻿using CsAddition.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testCalcVb
{
    
    
    /// <summary>
    ///Classe de test pour SettingsTest, destinée à contenir tous
    ///les tests unitaires SettingsTest
    ///</summary>
    [TestClass()]
    public class SettingsTest
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
        ///Test pour Constructeur Settings
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void SettingsConstructorTest()
        {
            // Impossible de trouver un accesseur private pour CsAddition.Properties.Settings. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Settings. R" +
                    "égénérez le projet contenant ou exécutez Publicize.exe manuellement.");
        }

        /// <summary>
        ///Test pour Default
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void DefaultTest()
        {
            // Impossible de trouver un accesseur private pour CsAddition.Properties.Settings. Régénérez le projet contenant ou exécutez Publicize.exe manuellement.
            Assert.Inconclusive("Impossible de trouver un accesseur private pour CsAddition.Properties.Settings. R" +
                    "égénérez le projet contenant ou exécutez Publicize.exe manuellement.");
        }
    }
}