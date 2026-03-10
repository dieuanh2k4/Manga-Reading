using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;

namespace backend.src.Models
{
    public class History
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MangaId { get; set; }
        public int LastChapterId { get; set; }
        public int LastPageId { get; set; }
        public Boolean IsCompleted { get; set; } = false;
        public TimeOnly UpdateAt { get; set; }

        public Users? Users { get; set; }
        public Manga? Manga { get; set; }
        public Chapters? Chapter { get; set; }
    }
}