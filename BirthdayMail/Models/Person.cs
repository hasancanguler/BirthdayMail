using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail.Models
{
    [Table("PERSONELLER")]
    public class Person
    {
        [Key]
        [Column("Per_TcKimlikNo")]
        public string Id { get; set; }
        [Column("per_adi")]
        public string Name { get; set; }
        [Column("per_soyadi")]
        public string SurName { get; set; }
        [Column("Per_PersMailAddress")]
        public string Mail { get; set; }
        [Column("per_nuf_dogum_tarih")]
        public DateTime BirthDate { get; set; }
    }
}
