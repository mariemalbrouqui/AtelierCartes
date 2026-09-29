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

        [JsonProperty]
        private string modele { get; set; } = "";

        [JsonProperty]
        private string variante { get; set; } = "";
        

        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("id")]
        public string Identifiant { get => identifiant; set => identifiant = value; }
        

        [JsonProperty("brand")]
        public string Marque { get => marque; set => marque = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
