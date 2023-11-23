using ClasTech.Teste.Data;
using ClasTech.Teste.Models;

namespace ClasTech.Teste.Service
{
    public class TesteService
    {
        public IList<PedidoViewModel> GetAll()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var list = (from t in db.teste
                                select new PedidoViewModel
                                {
                                    Id = t.id,
                                    Nome = t.nome,
                                    Ativo = t.ativo
                                }).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
