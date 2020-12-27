using System;
using System.Collections.Generic;
using System.Linq;

namespace PassworGenerator
{
    class Program
    {
        static int length = 8;
        static bool _isNumeric = true;
        static bool _isSpecialCharacter = true;
        static bool _isUpperCase = true;

        static void Main(string[] args)
        {
            string retorno = CreatePasswordGenerator();
            Console.WriteLine("Senha final gerada: " + retorno);
            Console.ReadKey();
        }



        private static string CreatePasswordGenerator()
        {

            string senha = "";
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string lettersUpper = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            string numeric = "0123456789";
            string punctuation = "!@#$%^&*()_+~|:;?><,.-=";
            Random rnd = new Random();
            bool _newcaractere = true;
            while (senha.Length < length)
            {
                int nletters = rnd.Next(0, letters.Length);
                int nnumeric = rnd.Next(0, numeric.Length);
                int npunctuation = rnd.Next(0, punctuation.Length);
                int nlettersUpper = rnd.Next(0, lettersUpper.Length);

                senha += letters[nletters]; //Pega letra randomica

                if (senha.Length >= length) //Conta os caracteres para sair caso atinja o maximo
                    break;

                if (_isNumeric)
                    senha += numeric[nnumeric]; // Pega numero randomico

                if (senha.Length >= length) //Conta os caracteres para sair caso atinja o maximo
                    break;

                if (_isSpecialCharacter && _newcaractere)
                { senha += punctuation[npunctuation]; _newcaractere = false; } //Pega caractere especial e seta para NAO ter novo caractere especial
                else
                    _newcaractere = true; //Seta para ter novo caractere especial

                if (senha.Length >= length) //Conta os caracteres para sair caso atinja o maximo
                    break;

                if (_isUpperCase)
                    senha += lettersUpper[nlettersUpper]; //Pega letra maiuscula randomica


            }

            Console.WriteLine("Senha a gerar: " + senha);

            return MistrurarString(senha);
        }


        /// <summary>
        /// Funcao para misturar as letras da senha
        /// </summary>
        /// <param name="str">Senha a ser misturada</param>
        /// <returns>Retorna string</returns>
        private static string MistrurarString(string senha)
        {
            char[] array = senha.ToCharArray(); // Transformo num array de char
            Random rng = new Random();
            int tamanho = array.Length; // Pega o tamanho da senha
            while (tamanho > 1)
            {
                tamanho--; //Diminuo o tamanho da senha
                int NumeroRandomico = rng.Next(tamanho + 1); // Pego um numero randomico do maximo da senha
                var value = array[NumeroRandomico]; // Guardo na variavel o char que foi pego
                array[NumeroRandomico] = array[tamanho]; // Pego ultimo char da ultima posicao do tamanho atual e jogo ele no array com indice randomico
                array[tamanho] = value; // Jogo o valor da varial para a ultima posicao do tamanho atual
            }
            return new string(array);
        }

    }
}
