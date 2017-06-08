using CsAddition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testCalcVb
{
    
    
    /// <summary>
    ///Classe de test pour frmCalculTest, destinée à contenir tous
    ///les tests unitaires frmCalculTest
    ///</summary>
    [TestClass()]
    public class frmCalculTest
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
        ///Test pour Constructeur frmCalcul
        ///</summary>
        [TestMethod()]
        public void frmCalculConstructorTest()
        {
            frmCalcul target = new frmCalcul();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void DisposeTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            bool disposing = false; // TODO: initialisez à une valeur appropriée
            target.Dispose(disposing);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void InitializeComponentTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            target.InitializeComponent();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btn3val_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btn3val_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btn3val_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btn4val_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btn4val_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btn4val_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btnAdditionDblNewPar2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btnAdditionDblNewPar2_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btnAdditionDblNewPar2_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btnAdditionDblNew_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btnAdditionDblNew_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btnAdditionDblNew_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btnAdditionDblPar2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btnAdditionDblPar2_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btnAdditionDblPar2_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btnAdditionPar2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btnAdditionPar2_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btnAdditionPar2_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btnAddition_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void btnAddition_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btnAddition_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour cmdAdditionDbl_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void cmdAdditionDbl_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.cmdAdditionDbl_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour cmdBonjour_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void cmdBonjour_ClickTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.cmdBonjour_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour frmCalcul_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void frmCalcul_LoadTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.frmCalcul_Load(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour txtA_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("CsAddition.exe")]
        public void txtA_TextChangedTest()
        {
            frmCalcul_Accessor target = new frmCalcul_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.txtA_TextChanged(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
