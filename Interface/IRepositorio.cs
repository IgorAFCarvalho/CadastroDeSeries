namespace CadastroDeSeries.Interface
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void insert (T entidade);
         void Exclui (int id);
         void Atualiza (int id, T entidade);
         int ProximoId();
    }
}