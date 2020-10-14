using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProjetCoreData.Models
{
    public class Utilisateur
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
    }
}
