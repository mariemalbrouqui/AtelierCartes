using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Offre
    {
        #region Attributs
        [JsonProperty]
        private string id { get; set; } = "";

        [JsonProperty]
        private string copyId { get; set; } = "";

        [JsonProperty]
        private double price { get; set; } = 0;

        [JsonProperty]
        private string status { get; set; } = "";
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        #endregion

        #region Methodes
        #endregion
    }
}
