using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Offre
    {
        #region Attributs
        private string identifiant = "";
        
        private string identifiantExemplaire = "";

        private double prix = 0;

        private string statut = "";

        
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("id")]
        public string Identifiant { get => identifiant; set => identifiant = value; }
        

        [JsonProperty("copyId")]
        public string IdentifiantExemplaire { get => identifiantExemplaire; set => identifiantExemplaire = value; }
        

        [JsonProperty("price")]
        public double Prix { get => prix; set => prix = value; }
        

        [JsonProperty("status")]
        public string Statut { get => statut; set => statut = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
