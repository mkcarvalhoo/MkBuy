
using System.Collections.Generic;
using System.Linq;

namespace MkBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validade();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
