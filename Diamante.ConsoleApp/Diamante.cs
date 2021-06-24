using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    public class Diamante
    {
        string letra;
        private Dictionary<int, string> DicionarioLetras = new Dictionary<int, string>()
        {
            {1, "A"}, 
            {2, "B"}, 
            {3, "C"},
            {4, "D"},
            {5, "E"},
            {6, "F"},
            {7, "G"},
            {8, "H"},
            {9, "I"},
            {10, "J"},
            {11, "K"},
            {12, "L"},
            {13, "M"},
            {14, "N"},
            {15, "O"},
            {16, "P"},
            {17, "Q"},
            {18, "R"},
            {19, "S"},
            {20, "T"},
            {21, "U"},
            {22, "V"},
            {23, "W"},
            {24, "X"},
            {25, "Y"},
            {26, "Z"}
        };

        public Diamante() 
        {
        }

        public void ObterLetra() 
        {
            do
            {
                Console.WriteLine("Digite uma letra para obter o diamante");
                letra = Console.ReadLine().ToUpper();
            }while(Validar() == "Invalido");
        }

        public void MostrarDiamante() 
        {
                int numeroLetra = 0;
                foreach (KeyValuePair<int, string> letraDicionario in DicionarioLetras)
                {

                    if (letra == letraDicionario.Value)
                        numeroLetra = letraDicionario.Key;
                }

                int QuantidadeEspacoDentro = -1;
                int QuantidadeEspacoFora = (numeroLetra - 1);

                //metade de cima do diamante
                for (int i = 1; i <= numeroLetra; i++)
                {
                    //FORA
                    for (int j = QuantidadeEspacoFora; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(DicionarioLetras[i]);

                    //DENTRO
                    for (int k = 0; k < QuantidadeEspacoDentro; k++)
                    {
                        Console.Write(" ");
                    }

                    if (DicionarioLetras[i] != "A")
                    {
                        Console.Write(DicionarioLetras[i]);
                    }
                    Console.WriteLine();

                    QuantidadeEspacoFora--;
                    QuantidadeEspacoDentro += 2;
                }

                QuantidadeEspacoFora = 1;
                QuantidadeEspacoDentro -= 4;

            if (numeroLetra == 1)
                Console.WriteLine("A");
            else
            {
                //metade de baixo do diamante
                for (int i = (numeroLetra - 1); i > 0; i--)
                {
                    //espaço de fora
                    for (int k = 0; k < QuantidadeEspacoFora; k++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(DicionarioLetras[i]);
                    //espaço de dentro
                    for (int j = QuantidadeEspacoDentro; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    if (DicionarioLetras[i] != "A")
                    {
                        Console.Write(DicionarioLetras[i]);
                    }
                    Console.WriteLine();
                    QuantidadeEspacoFora++;
                    QuantidadeEspacoDentro -= 2;
                }
            }

        }

        public string Validar()
        {
            foreach (KeyValuePair<int, string> letraDicionario in DicionarioLetras)
            {

                if (letra == letraDicionario.Value)

                    return "Valido";
            }
            Console.WriteLine("Valor inválido, digite novamente!");
            return "Invalido";
        }
    }
}
