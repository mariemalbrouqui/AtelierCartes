using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Cartes
    {
        #region Attributs
        
        private string identifiant = "";
        private string marque = "";
        private string modele = "";
        private string variante = "";
        
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("id")]
        public string Identifiant { get => identifiant; set => identifiant = value; }
        

        [JsonProperty("brand")]
        public string Marque { get => marque; set => marque = value; }
        

        [JsonProperty("model")]
        public string Modele { get => modele; set => modele = value; }
        

        [JsonProperty("variant")]
        public string Variante { get => variante; set => variante = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
