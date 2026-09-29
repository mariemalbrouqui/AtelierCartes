using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class DemandeConnexion
    {
        #region Attributs
        private string identifiant = "";
        private string motDePasse = "" ;

        
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter 
        [JsonProperty("username")]
        public string Identifiant { get => identifiant; set => identifiant = value; }
        

        [JsonProperty("password")]
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }

        #endregion

        #region Methode
        #endregion
    }
}
