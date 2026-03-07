using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.src.Models
{
    public class Libraries
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MangaId { get; set; }

        public Users? Users { get; set; }
        public Manga? Manga { get; set; }
    }
}