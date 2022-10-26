using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produtos
    {
        public Produtos(int iD, string nome, string descrincao, float preco, int categoria)
        {
            ID = iD;
            Nome = nome;
            Descrincao = descrincao;
            Preco = preco;
            Categoria = categoria;
        }
        public Produtos() { }

        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Descrincao { get; set; }
        public float Preco { get; set; }
        public int Categoria { get; set; }
    }
}
