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
    
    public partial class Deplacement
    {
        public int Id { get; set; }
        public System.DateTime date { get; set; }
        public string societe { get; set; }
        public string raison { get; set; }
        public string periode { get; set; }
        public int kilometrage_Id { get; set; }
        public int NotesDeFrais_mois_Id { get; set; }
    
        public virtual kilometrage kilometrage { get; set; }
        public virtual NotesDeFrais_mois NotesDeFrais_mois { get; set; }
    }
}
