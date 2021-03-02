using System.Collections.Generic;

namespace ProjetoCadastroDeSeries.Interfaces
{
    /// <summary>
    /// Interface para armazenar a lista de series
    /// Este é um padrao de projeto(Design Pattern) muito utilizado
    /// </summary>
    public interface IRepositorio<T> //(T é um tipo genérico)
    {
        List<T> Lista(); //metodo lista retorna uma lista de T

        T RetornaPorId(int id); //retorna um T ao passar um id por parametro 

        void Insere(T objetoSerie); //metodo p inserir

        void exclui(int id); //metodo para excluir

        void Atualiza(int id, T objetoSerie); //metodo para atualizar

        int ProximoId(); //retorna o proximo id
    }
}