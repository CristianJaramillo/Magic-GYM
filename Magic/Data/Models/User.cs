using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Data.Models
{
    [Table("users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("second_last_name")]
        public string SecondLastName { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
