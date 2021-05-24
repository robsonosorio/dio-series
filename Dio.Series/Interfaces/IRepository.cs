using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    public interface IRepository<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Inserir(T entidade);
         void Excluir(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();
    }
}