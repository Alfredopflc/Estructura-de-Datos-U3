using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3RamirezGarciaJesus
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantJuegos = 0, juegogan = 0, juegoper = 0, CantCartas, opc; //Inicializar variables
            Console.OutputEncoding = Encoding.Unicode; //Es necesario para aceptar los simbolos
            bool Salir = false, Concluirjuego, Salirpart;

            do
            {
                CantJuegos++;
                CantCartas = 2;
                Salirpart = false;
                CargaCartas CC = new CargaCartas(); //Se crea un objeto de la clase CargaCartas

                CC.Carga();
                CC.SacarCarta(CantCartas);

                do
                {
                    if (CantCartas < 5) //Si tienes menos de 5 cartas, te pedira si quieres otra para continuar sumando
                    {
                        Console.Clear();
                        Console.WriteLine("\n ~~ Partida No.{0} ~~ \nPartida Ganada: {1} \n Partidas Perdidas: {2}", CantJuegos, juegogan, juegoper);
                        CC.MostrarMano();

                        Console.Write("\nDeseas otra carta? \n1 = Si \n2 = No \nR = ");
                        opc = int.Parse(Console.ReadLine());

                        if (opc == 1) //Si deseas sacar la carta, la suma sera regresada por el metodo SacarCartas de la clase CargaCarta
                        {
                            CantCartas++;
                            CC.SacarCarta(CantCartas);
                            Salirpart = CC.VerificarSuma(false);
                        }

                        else if (opc == 2) //Si no, el programa te dira que perdiste por no llegar al 21
                        {
                            Salirpart = true; //Saldras del programa y te preguntara si quieres volver empezar
                        }

                        else //Marcara un error si no elegiste 1 o 2
                        {
                            Console.WriteLine("ERROR");
                            Console.ReadKey();
                            Salirpart = false; 
                        }

                    }

                    else 
                    {
                        //En el caso de ya tener 5 cartas , El programa al tener una suma menor de 21, dira que perdiste 
                        //Si es igual a 21 ganaste,  Si te pasas del 21, habras perdido

                        Console.Clear();
                        Console.WriteLine("\n ~~ Partida No.{0} ~~ \nPartida Ganada: {1} \nPartidas Perdidas: {2}", CantJuegos, juegogan, juegoper);
                        CC.MostrarMano();
                        CC.VerificarSuma(false);
                        Salirpart = true; 
                    }

                } while (Salirpart == false); //Regresara si aun no has tomado 5 cartas y tu suma no ha pasado de 21

                Console.Clear();
                Console.WriteLine("\n ~~ Partida No.{0} ~~ \nPartida Ganada: {1} \nPartidas Perdidas: {2}", CantJuegos, juegogan, juegoper);

                CC.MostrarMano();
                Concluirjuego = CC.VerificarSuma(true);

                if (Concluirjuego == true) //Si sale 21 antes de las 5 cartas, habras ganado
                {
                    juegogan++;
                }
                else //De lo contrario, habras perdido
                {
                    juegoper++;
                }

                do
                {
                    Console.Clear();
                    Console.Write("\nDeseas otra carta? \n1 = Si \n2 = No \nR = "); //Te preguntara si quieres volver a jugar
                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1) //Si elijes 1, volveras a empezar
                    {
                        Salirpart = true;
                    }

                    else if (opc == 2) //Si no, saldras del programa
                    {
                        Salir = true;
                        Salirpart = true;
                    }

                    else
                    {
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                    }

                } while (Salirpart == false);
            } while (Salir == false); //Volveras a empezar 
        }
    }
}

