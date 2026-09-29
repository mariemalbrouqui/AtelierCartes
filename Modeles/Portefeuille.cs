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
        
        private ObservableCollection<CartePossedee>? cartesPossedees;

        
        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty("positions")]
        public ObservableCollection<CartePossedee>? CartesPossedees { get => cartesPossedees; set => cartesPossedees = value; }

        #endregion

        #region Methodes
        #endregion
    }
}
