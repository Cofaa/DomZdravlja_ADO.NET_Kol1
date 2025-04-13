using DomZdravlja.Shared;
using DomZdravlja.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomZdravlha.Shared;

namespace DomZdravlja.Business
{
    public class IzvestajManager
    {
        private IzvestajDAL _dal = new IzvestajDAL();

        public List<IzvestajDTO> GetBySluzbaID(int sluzbaID)
        {
            return _dal.GetIzvestajBySluzba(sluzbaID);
        }

        public void Insert(IzvestajDTO dto)
        {
            // Ovde možete da odradite validaciju parametara 
            // pre slanja u DAL.
            _dal.InsertIzvestaj(dto);
        }

        public void Update(IzvestajDTO dto)
        {
            _dal.UpdateIzvestaj(dto);
        }

        public void Delete(int izvestajID)
        {
            _dal.DeleteIzvestaj(izvestajID);
        }
    }
}

