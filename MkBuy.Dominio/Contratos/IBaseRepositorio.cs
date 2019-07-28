using System;
using System.Collections.Generic;
using System.Text;

namespace MkBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        //Definir o nome dos métodos de contratos que serão utilizados pela camada de repositório

        void Adicionar(TEntity entity);
        TEntity ObterPorID(int Id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);

    }
}
