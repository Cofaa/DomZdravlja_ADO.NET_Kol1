using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomZdravlha.Shared
{
    public class IzvestajDTO
    {
        public int IzvestajID {  get; set; }
        public int SluzbaID { get; set; }
        public string NazivIzvestaja { get; set; }
        public int BrojPacijenata { get; set; }
        public DateTime DatumKreiranja { get; set; }
    }
}
