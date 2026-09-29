using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class CartePossedee
    {
        #region Attributs
        private string identifiant = "";
        private Cartes? carte = new Cartes();
        private double valeurActuelle= 0;

        
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("id")]
        public string Identifiant { get => identifiant; set => identifiant = value; }
       

        [JsonProperty("card")]
        public Cartes? Carte { get => carte; set => carte = value; }
        
        [JsonProperty("currentValue")]
        public double ValeurActuelle { get => valeurActuelle; set => valeurActuelle = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
