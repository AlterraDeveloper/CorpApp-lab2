using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpApp_lab2.DataTransferObjects
{
    public class MusicTrackDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string GenreName { get; set; }
    }
}
