using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Almost.Models
{
    public class Replie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public string replieComentary { get; set; }
        public Int64 idUser { get; set; }
        public Int64 commentId { get; set; }

    }
}
