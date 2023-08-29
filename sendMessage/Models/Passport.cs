using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sendMessage.Models
{
    public class Passport
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime ExpiryDate { get; set; }
        // Navigation property to Person
        [Required]
        [ForeignKey("PersonId")]
        [InverseProperty("Passport")]
        public Person Person { get; set; }
        // Foreign key property to Person
        public int PersonId { get; set; }
    }
}