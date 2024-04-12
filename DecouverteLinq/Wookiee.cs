using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecouverteLinq
{
    internal class Planete
    {
        public string Label { get; set; } = string.Empty;
    }

    internal class Wookiee
    {
        public void Save()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public int Age { get; set; } = 120;

        public int NbPoils { get; set; } = 12000;

        [Required]
        [MinLength(3)]
        public string Prenom { get; set; } = string.Empty;

        [NotMapped]
        public Planete? Planete { get; set; }
    }
}
