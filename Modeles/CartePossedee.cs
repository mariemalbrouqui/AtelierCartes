using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class CartePossedee
    {
        #region Attributs
        [JsonProperty]
        private string id { get; set; } = "";

        [JsonProperty]
        private Cartes? card { get; set; } = new Cartes();

        [JsonProperty]
        private double currentValue { get; set; } = 0;
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        #endregion

        #region Methodes
        #endregion
    }
}
