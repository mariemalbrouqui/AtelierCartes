using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class ReponseConnexion
    {
        #region Attributs
        private string jetonAcces = "";

        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("accessToken")]
        public string JetonAcces { get => jetonAcces; set => jetonAcces = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
