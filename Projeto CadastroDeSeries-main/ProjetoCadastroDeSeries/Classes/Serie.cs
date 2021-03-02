using System;
using ProjetoCadastroDeSeries.Classes;

namespace ProjetoCadastroDeSeries
{
    public class Serie : EntidadeBase
    {
        //--- atributos
        private Genero Genero { get; set; }
        private String Titulo { get; set; }
        private String Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; } //indica se registro esta excluido ou não

        //--construtor da classe serie 
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        //--- overrite do metodo tostring para retorno de string formatada com os dados
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine; //environment new line gera nova linha independente de sistems operacional !
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano + Environment.NewLine;
            retorno += "Excluído: " + Excluido + Environment.NewLine;
            return retorno;
        }

        //--- metodos de retorno dos dados titulo / id(herdados da classe base) / exclui / retorna status excluido
        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }
    }
}
