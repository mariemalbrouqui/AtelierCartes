using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class Portefeuille
    {
        #region Attributs
        [JsonProperty]
        private ObservableCollection<CartePossedee>? positions { get; set; }
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        #endregion

        #region Methodes
        #endregion
    }
}
