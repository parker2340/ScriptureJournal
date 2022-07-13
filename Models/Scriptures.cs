using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Scriptures 
    {
        public Scriptures()
        {
            DateAdded = DateTime.Now;
        }
        public int ID { get; set; }
        public string Book { get; set; } = string.Empty;
        public int Chaper { get; set; }
        public int Verse { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}