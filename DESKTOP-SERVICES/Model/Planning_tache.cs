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
    
    public partial class Planning_tache
    {
        public int Id { get; set; }
        public Nullable<int> Fk_typeTacheID { get; set; }
        public Nullable<int> Fk_clientID { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public Nullable<int> Fk_creePar { get; set; }
        public Nullable<int> Fk_affecteA { get; set; }
        public string Etat { get; set; }
        public Nullable<System.DateTime> DateDeCreation { get; set; }
        public Nullable<System.DateTime> DateDeCloture { get; set; }
        public Nullable<int> Fk_tacheParente { get; set; }
    }
}
