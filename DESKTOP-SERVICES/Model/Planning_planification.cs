//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DESKTOP_SERVICES.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planning_planification
    {
        public int Id { get; set; }
        public Nullable<int> Fk_tacheID { get; set; }
        public Nullable<int> Fk_clientID { get; set; }
        public Nullable<int> Fk_modeOperatoireID { get; set; }
        public Nullable<int> Fk_competenceID { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateDeCreation { get; set; }
        public Nullable<System.DateTime> DateDeModification { get; set; }
        public Nullable<int> Fk_creePar { get; set; }
        public Nullable<int> Fk_modifiePar { get; set; }
        public Nullable<System.DateTime> DateDeDebut { get; set; }
        public Nullable<System.DateTime> DateDeFin { get; set; }
        public string JourneeComplete { get; set; }
        public string Priorite { get; set; }
        public string Facturable { get; set; }
        public string Verouille { get; set; }
        public Nullable<int> FK_verouillePar { get; set; }
    }
}
