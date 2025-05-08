using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho.classes
{
    public class Categoria
    {
        private int identificacao;
        private string descricao;

        public Categoria(int identificacao, string descricao) {
            this.identificacao = identificacao;
            this.descricao = descricao;
        }

        public int Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public override string ToString()
        {
            return $"[" +
                $"Identificação: {identificacao}, " +
                $"Descrição: {descricao}]";
        }
    }
}
