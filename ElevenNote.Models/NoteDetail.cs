using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    class NoteDetail
    {
        [Display(Name="Created")]
        public int NoteId { get; set; }
        [Display(Name="Modified")]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }
        public override string ToString() => $"[{NoteId}] {Title}";
    }
}
