using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    public class ReponseOffres
    {
        #region Attributs
        private ObservableCollection<Offre> offres;


        #endregion

        #region Constructeur
        #endregion

        #region Getter et Setter
        [JsonProperty]
        public ObservableCollection<Offre> Offres { get => offres; set => offres = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
