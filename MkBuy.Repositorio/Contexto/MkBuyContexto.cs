using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MkBuy.Dominio.Entidades;
using MkBuy.Dominio.ObjetoDeValor;
using MkBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace MkBuy.Repositorio.Contexto
{
    public class MkBuyContexto : DbContext
    {   //"<Usuario>" é a entidade utilizada -Usuarios é o nome que o Entity irá atribuir para tabela
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public MkBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Referencia as classes de configuração/Mapeamento...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento()
            {
                Id = 1,
                Nome = "Boleto",
                Descricao = "Forma de Pagamento Boleto"
            },
            new FormaPagamento()
            {
                Id = 2,
                Nome = "Cartao de Credito",
                Descricao = "Forma de Pagamento Cartao de Credito"
            },
            new FormaPagamento()
            {
                Id = 3,
                Nome = "Deposito",
                Descricao = "Forma de Pagamento Deposito"
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
