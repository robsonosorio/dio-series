using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series.Classes
{
    public class SerieRepository : IRepository<Series>
    {
        private List<Series> listaSeries = new List<Series>();

        public void Atualizar(int id, Series entidade)
        {
            listaSeries[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSeries[id].Exclui();
        }

        public void Inserir(Series entidade)
        {
            listaSeries.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}