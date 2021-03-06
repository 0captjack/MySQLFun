using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Models
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        
        public char? BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        [Required(ErrorMessage = "Please enter a 2 letter State abbreviation")]

        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }
        [Required(ErrorMessage = "Please enter a valid Phone Number")]
        public string BowlerPhoneNumber { get; set; }
        [Required]
        public int TeamID { get; set; }
        public Team Team { get; set; }
    }
}
