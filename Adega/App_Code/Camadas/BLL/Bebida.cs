using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega.Camadas.BLL
{
    public class Bebida
    {
        public List<MODEL.Bebida> Select()
        {
            DAL.Bebida dalbebida = new DAL.Bebida();
            return dalbebida.Select();
        }
        public List<MODEL.Bebida> SelectById(int id)
        {
            DAL.Bebida dalBebida = new DAL.Bebida();
            return dalBebida.SelectById(id);
        }

        public List<MODEL.Bebida> SelectByNome(string nome)
        {
            DAL.Bebida dalBebida = new DAL.Bebida();
            return dalBebida.SelectByNome(nome);
        }


        public void Insert(MODEL.Bebida bebida)
        {
            DAL.Bebida dalBebida = new DAL.Bebida();
            dalBebida.Insert(bebida);
        }

        public void Update(MODEL.Bebida bebida)
        {
            DAL.Bebida dalBebida = new DAL.Bebida();
            dalBebida.Update(bebida);
        }
        public void Delete(MODEL.Bebida bebida)
        {
            DAL.Bebida dalBebida = new DAL.Bebida();
            dalBebida.Delete(bebida);
        }
    }
}
