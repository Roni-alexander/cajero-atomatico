using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajero_automatico_5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int monto, cien, dociento, quiniento, mil;// dosmil;
            int  tarjeta;
            int pin=112233;
            double balance = 100000;
            string s1 = null;
            int retiro = 1;
            




            Console.WriteLine("BIENVENIDO@ al cajero de Roni alexander");
            

                Console.WriteLine();
               // Console.SetCursorPosition(5, 5);
                Console.Write("ingrese el numero de tarjeta.......");
                tarjeta =int.Parse(Console.ReadLine());

          

            do
            {
                if (tarjeta !=12345689)
                {
                    Console.WriteLine("ingrese l pin de seguridad");
                    pin = int.Parse(Console.ReadLine());

                    if (pin != 112233)
                    {


                        Console.WriteLine("que accion desea realizar, 1=retiro, 2=balace");
                        retiro = int.Parse(Console.ReadLine());

                        if (retiro == 1)
                        {
                            Console.WriteLine("ingrse el monto");
                            monto = int.Parse(Console.ReadLine());


                            if (monto <= balance)
                            {
                                balance = balance - monto;
                                Console.WriteLine("su balance es:" + balance);


                                if (monto % 100 == 0)
                                {
                                    // dosmil = monto / 2000;
                                    //  monto = monto % 2000;
                                    mil = monto / 1000;
                                    monto = monto % 1000;
                                    quiniento = monto / 500;
                                    monto = monto % 500;
                                    dociento = monto / 200;
                                    monto = monto % 200;
                                    cien = monto / 100;
                                    monto = monto % 100;


                                    //  Console.WriteLine("el monto en billete de (2000) es ...." + dosmil);


                                    Console.WriteLine("el monto en billete de (1000) es ...." + mil);


                                    Console.WriteLine("el monto en billete de (500) es ...." + quiniento);


                                    Console.WriteLine("el monto en billete de (200) es ...." + dociento);


                                    Console.WriteLine("el monto en billete de (100) es ...." + cien);




                                }
                                else
                                {
                                    Console.SetCursorPosition(25, 20);
                                    Console.Write("¡¡¡monto no valido ¡¡¡");
                                }

                            }
                            if (monto > balance)
                            {
                                Console.WriteLine("sorry el monto ingresado pasa el limite del balance");
                            }


                        }



                    }

                    if (retiro == 2)
                    {
                        Console.WriteLine("Su numero de tarjeta es :"+tarjeta);
                        Console.WriteLine("su pin de seguridad es:"+pin);
                        Console.WriteLine("Su nombre es : Roni Alexander Rosario");
                        Console.WriteLine("su balance es de :" + balance);
                    }





                }
                else
                {
                    Console.WriteLine("este numero de tarjeta no es valido");
                }
                Console.WriteLine("desea continual el retiro : S=SI : N=NO");
                s1 = Console.ReadLine();








             }while(s1=="S"||s1=="s") ;   
        } 
    }
}
