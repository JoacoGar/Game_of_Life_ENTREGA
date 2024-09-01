<<<<<<< Updated upstream
﻿using System;
=======
﻿//La clase Program contiene el método Main, cumplen con el principio de  responsabilidad única, es el
//punto de entrada del programa.
using System;
using System.Threading;
>>>>>>> Stashed changes

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
<<<<<<< Updated upstream
        static void Main(string[] args)
=======
        FileReader lectorArchivo = new FileReader(); 
        bool[,] estadoInicial = lectorArchivo.LeerBlocDeNotas("board.txt");
        Board tablero = new Board(estadoInicial);
        Logic logicaJuego = new Logic();
        PrintBoard impresoraTablero = new PrintBoard();
        while (true)
>>>>>>> Stashed changes
        {
            Console.WriteLine("Hello World!");
        }
    }
}
