﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine(contaDaGabriela.agencia);
            Console.WriteLine(contaDaGabriela.numero);
            Console.WriteLine(contaDaGabriela.saldo);


            Console.ReadLine();

        }
    }
}
