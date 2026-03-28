using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    internal class Pokemon
    {

        string Nome;
        string Tipo;
        int Nivel;
        int Vida;
        int Dano;

        //Criação da função de inicialização padrão do meu objeto


        /// <summary>
        /// Inicializa o construtor da minha classe padrão de Pokemon
        /// <paramref name="nivelPokemon"/>, <paramref name="nomePokemon"/>, <paramref name="tipoPokemon"/>
        /// 
        /// <list type="bullet">
        /// <item>nomePokemon: Variavel para saber o NOME</item>
        /// <item>tipoPokemon: Variavel para saber o TIPO</item>
        /// <item>nivelPokemon: Variavel para saber o NÍVEL</item>
        /// </list>
        /// </summary>
        /// <returns>
        /// A Class Pokemon retorna um objeto com todas as funções que tem relações.
        /// </returns>
        /// <param name="nomePokemon">Faz referência ao nome <c>Pokemoon</c></param>
        /// <param name="tipoPokemon">Menciona a habilidade do <c>Pokemon</c></param>
        /// <param name="nivelPokemon">Relaciona qual o nível da habilidade do <c>Pokemon</c></param>










        /// <summary>
        /// Inicializa o construtor da minha classe padrão de Pokemon
        /// <list type="bullet">
        /// <paramref name="nivelPokemon"/>, <paramref name="nomePokemon"/>, <paramref name="tipoPokemon"/>
        /// <item>nomePokemon: Variavel para o Nome</item>
        /// <item>tipoPokemon: Variavel para o Tipo</item>
        /// <item>nivelPokemon: Variavel para o Nível</item>
        /// </list>
        /// <value>Aqui aparece a propriedade de valor</value>
        /// </summary>
        /// <param name="nomePokemon">Faz referência ao nome <c>Pokemoon</c></param>
        /// <param name="tipoPokemon">Menciona a habilidade do <c>Pokemon</c></param>
        /// <param name="nivelPokemon">Relaciona qual o nível da habilidade do <c>Pokemon</c></param>


        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {

              Random r = new Random();
            r.Next();


            // Nome = "Pikachu";
            //Tipo = "Elétrico";
            //Nivel = 5;

            Nome = nomePokemon  ;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;
            Vida = 100;
            Dano = 20;
        }

        // public posso usar da função em qualquer espaço do meu projeto
        // private posso usar a função somente no meu arquivo original
        /// <returns>
        /// A função <see cref="fnDescricao"/> fnDescrição() não retorna nada.
        /// </returns>
        public void fnDescricao()
        {
            MessageBox.Show($"pokemon: {Nome}, Tipo: {Tipo}, " +
                $"Nivel: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon

    }
}
