using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class ErreurApi
    {
        #region Attributs
        private string message = "Erreur";

        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("message")]
        public string Message { get => message; set => message = value; }


        #endregion

        #region Methodes
        #endregion
    }
}
