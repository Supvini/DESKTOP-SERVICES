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
    
    public partial class Client_serveur
    {
        public int Id { get; set; }
        public Nullable<int> FK_clientID { get; set; }
        public string TypeServeur { get; set; }
        public string NomNetbios { get; set; }
        public string PN { get; set; }
        public string SN { get; set; }
        public string AdresseIP { get; set; }
        public string Processeur { get; set; }
        public string RAM { get; set; }
        public string DD { get; set; }
        public string VersionWindows { get; set; }
        public string CleWindows { get; set; }
        public string ServicePack { get; set; }
        public string Role { get; set; }
        public string TypeSauvegarde { get; set; }
    }
}
