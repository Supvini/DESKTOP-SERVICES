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
    
    public partial class Conges_mail
    {
        public int Id { get; set; }
        public string FK_userNomComplet { get; set; }
        public Nullable<System.DateTime> DateDeCreation { get; set; }
        public Nullable<System.DateTime> DateDeDebut { get; set; }
        public Nullable<System.DateTime> DateDeFin { get; set; }
        public string FK_typeCongesLabel { get; set; }
        public string Description { get; set; }
        public string Commentaire { get; set; }
        public string Statut { get; set; }
        public string Destinataire { get; set; }
    }
}
