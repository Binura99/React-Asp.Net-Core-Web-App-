using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class DCandidate
    {
        [Key]
        public int Id { get; set; }

        public string fullName { get; set; }

        public string mobile { get; set; }

        public string email { get; set; }

        public string age { get; set; }

        public string bloodGroup { get; set; }

        public string address { get; set; }
    }
}
