using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega.Camadas.BLL
{
    public class Fornecedor
    {
        public List<MODEL.Fornecedor> Select()
        {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            return dalFornecedor.Select();
        }
        public List<MODEL.Fornecedor> SelectById(int id)
        {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            return dalFornecedor.SelectById(id);
        }
        public List<MODEL.Fornecedor> SelectByNome(string nome)
        {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            return dalFornecedor.SelectByNome(nome);
        }
        public void Insert(MODEL.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            dalFornecedor.Insert(fornecedor);
        }

        public void Update(MODEL.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            dalFornecedor.Update(fornecedor);
        }
        public void Delete(MODEL.Fornecedor fornecedor)
        {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            dalFornecedor.Delete(fornecedor);
        }
    }
}
