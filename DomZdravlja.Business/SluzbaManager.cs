using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomZdravlja.DataAccess;
using DomZdravlja.Shared;

namespace DomZdravlja.Business
{
    public class SluzbaManager
    {
        private SluzbaDAL _dal = new SluzbaDAL();

        public List<SluzbaDTO> GetAllSluzba()
        {
            return _dal.GetAllSluzba();
        }
    }
}
