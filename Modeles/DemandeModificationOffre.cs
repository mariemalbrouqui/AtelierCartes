using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class DemandeModificationOffre
    {
        #region Attributs
        private double prix = 0;


        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("price")]
        public double Prix { get => prix; set => prix = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
