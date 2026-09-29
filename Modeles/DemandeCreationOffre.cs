using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class DemandeCreationOffre
    {
        #region Attributs
        private string identifiantExemplaire = "";
        private double prix = 0;

        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("copyId")]
        public string IdentifiantExemplaire { get => identifiantExemplaire; set => identifiantExemplaire = value; }

        [JsonProperty("price")]
        public double Prix { get => prix; set => prix = value; }

        #endregion

        #region Methode
        #endregion

    }
}
