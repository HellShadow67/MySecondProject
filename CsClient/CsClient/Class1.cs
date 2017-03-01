using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsClient
{
    public class Class1
    {

        private int numeroClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;

        private string identClient;


        public Class1()
        {
            numeroClient = 0;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
            identClient = "";
        }


        public Class1(int numCli, string nomCli, string prenomCli, string adresseCli,string identCli)
            {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = adresseCli;
            identClient = identCli;

        }

        public int getNumeroClient()
            {
                return numeroClient;
        }

        public void setNumeroClient(int numCli)
            {
                numeroClient = numCli;
        }

        public string getNomClient()
            {
                return nomClient;
        }

        public void setNomClient(string nomCli)
            {
                nomClient = nomCli;
        }

        public string getPrenomClient()
            {
                return prenomClient;
        }

        public void setPrenomClient(string prenomCli)
            {
                prenomClient = prenomCli;
        }

        public string getAdresseClient()
            {
                return adresseClient;
        }

        public void setAdresseClient(string adresseCli)
            {
                adresseClient = adresseCli;
        }

        public string AffClient()
        {
            return numeroClient + " " + nomClient + " " + prenomClient + " " + adresseClient;
        }
        public string getIdentClient()
        {
            return identClient;
        }
        public void setIdentClient(string id)
        {
            identClient = id;
        }
     
    }
}
