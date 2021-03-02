using ProjetoCadastroDeSeries.Interfaces;
using System.Collections.Generic;

namespace ProjetoCadastroDeSeries
{
    public class SerieRepositorio : IRepositorio<Serie> //classe repositorio implementa um repositorio da classe series
    {
        //implementacao da variavel lista que contem todas as series
        private List<Serie> listaSerie = new List<Serie>();

        //implementação dos metodos:
        public void Atualiza(int id, Serie objetoSerie)
        {
            listaSerie[id] = objetoSerie;
        }

        public void exclui(int id)
        {
            listaSerie[id].Excluir(); //apenas marca o id como excluido na lista de series(não exclui de fato)
        }

        public void Insere(Serie objetoSerie)
        {
            listaSerie.Add(objetoSerie);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}