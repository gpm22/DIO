using System.Collections.Generic;

namespace PokeRegistration
{
    public interface Repositorio<T>
    {
         List<T> Lista();

         T RetornaPorId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int ind, T entidade);
         
         int ProximoId();
    }
}