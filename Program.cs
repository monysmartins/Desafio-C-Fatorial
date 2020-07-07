﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Iniciando
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger fatorial = new BigInteger();


            Console.WriteLine("Digite um numero entre 0 e 2000:");
            int num = int.Parse(Console.ReadLine());
            
            //Cria referencia a SomaDigitosFatorial
            SomaDigitosFatorial soma = new SomaDigitosFatorial();
            Console.WriteLine(soma.Calcula(num));

            Console.ReadKey();

        }
    }

    public class SomaDigitosFatorial 
    {
        /**
         Calcula o Fatorial
         */
        public int Calcula(int numero)
        {
            int soma = 0;
            BigInteger fatorial = (BigInteger) 1;
            //BigInteger fatorial = new BigInteger("1");

            if (numero == 0)
            {
                fatorial = (BigInteger) 1;
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    fatorial = (BigInteger) fatorial * i;
                    //fatorial = fatorial.multiply(new BigInteger(Integer.toString(i)));
                }

            }

            /**
             Segunda parte do programa: Somatório dos digitos
             */
            //Transformando em String
            string digitos = Convert.ToString(fatorial);
            //Mostra na console
            Console.WriteLine("Fatorial: " + fatorial);
            //for (int i = 0; i < digitos.Length; i++)
            foreach (var item in digitos)
            {
                //Converte para String e depois em Inteiro cada digito
                soma += int.Parse(Convert.ToString(item));
            }
            return soma;
            //Console.Read();
        }

    }
}
