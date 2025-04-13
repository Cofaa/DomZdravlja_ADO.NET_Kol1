using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZdravlja.Shared
{
    public class SluzbaDTO
    {
        public int SluzbaID {  get; set; }
        public string NazivSluzbe {  get; set; }
        public string OpisSluzbe { get; set; }
        public DateTime DatumOsnivanja { get; set; }
    }
}
