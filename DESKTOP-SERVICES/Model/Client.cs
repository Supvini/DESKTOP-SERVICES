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
    
    public partial class Client
    {
        public int Id { get; set; }
        public Nullable<int> FK_typeClientID { get; set; }
        public string RaisonSociale { get; set; }
        public string Logo { get; set; }
        public Nullable<System.DateTime> DateDeCreation { get; set; }
        public string Folder { get; set; }
        public Nullable<int> Actif { get; set; }
        public string EntiteJuridique { get; set; }
    }
}
