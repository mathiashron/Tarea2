using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static int option = 5;
        static int cuenta = 0;
        static int retirodinero = 0;
        static void depositar_dinero()
        {
            Console.WriteLine("Ingrese la cantidad de dinero a depositar");
            int ingreso = int.Parse(Console.ReadLine());
            Console.WriteLine("El saldo anterior es de =\t\t" + cuenta);
            cuenta += ingreso;
            Console.WriteLine("El nuevo saldo en su cuenta es=\t\t" + cuenta);
            Console.ReadLine();

        }

        static void retirar_dinero()
        {
            
            
            
            int retirado = retirodinero;
            
            
            if (retirodinero <= cuenta )
            {
                int contador20 = 0;
                int contador10 = 0;
                int contador5 = 0;
                int contador2 = 0;
                do
                {
                    if (retirodinero == 6000) {

                        retirodinero = 0;
                        contador2 = contador2 + 3;
                    }
                    if (retirodinero == 8000)
                    {

                        retirodinero = 0;
                        contador2 = contador2 + 4;
                    }
                    if (retirodinero == 9000)
                    {

                        retirodinero = 0;
                        contador2 = contador2 + 2;
                        contador5 = contador5 + 1;
                    }
                    if (retirodinero == 11000)
                    {

                        retirodinero = 0;
                        contador2 = contador2 + 3;
                        contador5 = contador5 + 1;
                    }
                    if (retirodinero == 13000)
                    {

                        retirodinero = 0;
                        contador2 = contador2 + 4;
                        contador5 = contador5 + 1;
                    }
                    if (retirodinero == 16000)
                    {

                        retirodinero = 0;
                        contador2 = contador2 + 3;
                        contador10 = contador10 + 1;
                    }
                    if (retirodinero == 18000)
                    {

                        retirodinero = 0;
                        contador10 = contador10 + 1;
                        contador2 = contador2 + 4;
                    }
                    if (retirodinero == 19000)
                    {

                        retirodinero = 0;
                        contador2 = contador2 + 2;
                        contador10 = contador10 + 1;
                        contador5 = contador5 + 1;

                    }
                    if (retirodinero == 21000)
                      {
                            retirodinero = 0;
                            contador10 = contador10 + 1;
                            contador5 = contador5 + 1;
                            contador2 = contador2 + 3;
                        }
                    if (retirodinero == 23000)
                    {

                        retirodinero = 0;
                        contador10 = contador10 + 1;
                        contador5 = contador5 + 1;
                        contador2 = contador2 + 4;
                    }
                    if (retirodinero == 26000)
                    {

                        retirodinero = 0;
                        contador20 = contador20 + 1;
                        contador2 = contador2 + 3;
                        
                    }
                    if (retirodinero == 28000)
                    {

                        retirodinero = 0;
                        contador20 = contador20 + 1;
                        
                        contador2 = contador2 + 4;
                    }
                   
                    

                  
                    if (retirodinero >= 20000)
                    {
                        retirodinero = retirodinero - 20000;
                        contador20++;

                    }
                    else
                    {
                        if (retirodinero >= 10000)
                        {
                            retirodinero = retirodinero - 10000;
                            contador10++;


                        }
                        else
                        {
                            if (retirodinero >= 5000)
                            {
                                retirodinero = retirodinero - 5000;
                                contador5++;
                            }
                            else
                            {
                                if (retirodinero >= 2000)
                                {
                                    retirodinero = retirodinero - 2000;
                                    contador2++;
                                }
                                
                            }
                        }
                    }
                }

                while (retirodinero > 0);


                Console.WriteLine("Denominacion\t\tCantidad\t\tTotal");
                if (contador20 > 0)
                    
            {
                Console.WriteLine("20.000\t\t\t" + contador20 +"\t\t\t"+(contador20*20000));
            }
            if (contador10 > 0)
            {
                Console.WriteLine("10.000\t\t\t" + contador10 + "\t\t\t" + (contador10 * 10000));
                }
            if (contador5 > 0)
            {
                Console.WriteLine(" 5.000\t\t\t" + contador5 + "\t\t\t" + (contador5 * 5000));
                }
            if (contador2 > 0)
            {
                Console.WriteLine(" 2.000\t\t\t" + contador2 + "\t\t\t" + (contador2 * 2000));
                }
            

            Console.WriteLine("Monto Retirado =" +retirado);
            cuenta = cuenta - retirado;
            Console.WriteLine("Saldo en su cuenta es =" +cuenta);
            }
            else
            {
                Console.WriteLine("No tiene suficiente dinero disponible en la cuenta para el retiro.");
                

            }

            Console.ReadKey();
        }






        static void recibir_monedas()
        {
            
            int total = 0;
            int totalgeneral = 0;
            int cantidad = 0;
            int salir = 1;
            
            Console.WriteLine("Ingrese la cantidad de monedas a depositar");
            int []monedasraid = new int[6];
            string [] nombremonedas = { "5", "10", "25", "50", "100", "500" };
           
            while(cantidad < 50 && salir == 1) {
                
                for (int i = 0; i <= 5; i++)
                {
                    
                    Console.WriteLine("Ingrese las monedas de=" + nombremonedas[i]);
                    monedasraid[i] = int.Parse(Console.ReadLine());
                    cantidad = cantidad + monedasraid[i];
                    
                    if (cantidad > 50)
                    {
                        cantidad = cantidad - monedasraid[i];
                        Console.WriteLine("Alcanzo el maximo permitido de 50 monedas no se puede ingresar mas .");
                        Console.WriteLine("Actualmente tiene un total de  " + cantidad + "  Solo puede ingresar un total de " + (50 - cantidad ));
                        i = i - 1;
                    }
                    
                   
                }
                Console.Clear();
                total =  monedasraid[0] * 5 + monedasraid[1] * 10 + monedasraid[2] * 25 + monedasraid[3] * 50 + monedasraid[4] * 100 + monedasraid[5] * 500;
                totalgeneral = totalgeneral + total;
                Console.WriteLine("Monedas de 5 =\t\t " + monedasraid[0] + "\t"+ monedasraid[0]*5+ "\nMonedas de 10 =\t\t " + monedasraid[1] + "\t" + monedasraid[1] * 10 + "\nMonedas de 25 =\t\t " + monedasraid[2] + "\t" + monedasraid[2] * 10 + "\nMonedas de 50 =\t\t " + monedasraid[3] + "\t" + monedasraid[3] * 50 + "\nMonedas de 100 =\t " + monedasraid[4] + "\t" + monedasraid[4] * 100 + "\nMonedas de 500 =\t " + monedasraid[5]+ "\t" + monedasraid[5] * 500 );
                Console.WriteLine("Cantidad de monedas ingresadas=" + (monedasraid[0]  + monedasraid[1]  + monedasraid[2] + monedasraid[3] + monedasraid[4] + monedasraid[5]));
                Console.WriteLine("Monto de esta transaccion es= " + total);
                Console.WriteLine("Desea ingresar mas monedas? \n0-No \n1-Si");
                salir = int.Parse(Console.ReadLine());

                
            }
            Console.WriteLine("El total general de dinero depositado fue de = " + totalgeneral);
            Console.WriteLine("Cantidad total de Monedas = " + cantidad);
            cuenta = cuenta + totalgeneral;
            Console.ReadKey();

                 }


        static void indicar_tipodecambio()
        {
            Console.Clear();
            Console.WriteLine("1.\tColones a Dolares.\n2.\tDolares a Colones.\n3.\tSu saldo a Dolares.");
            int cambio = int.Parse(Console.ReadLine());
            switch (cambio)
            {
                case 1:
                    Console.WriteLine("\t\t\t Colones a Dolares\n\n");
                    Console.WriteLine("Ingrese la cantidad de colones=");
                    double tipo = int.Parse(Console.ReadLine());
                    tipo = tipo / 540;
                    Console.WriteLine("El tipo de cambio de hoy 19-05-2016 es de 540 Colones");
                    //Console.WriteLine("El cambio a Dolares del monto ingresado es=\t", (tipo));
                    Console.Write("El cambio a Dolares es = \t");
                    Console.WriteLine(tipo.ToString("0.00"));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("\t\t\t Dolares a Colones");
                    Console.WriteLine("Ingrese la cantidad de Dolares=");
                    tipo = int.Parse(Console.ReadLine());
                    Console.WriteLine("El tipo de cambio de hoy 19-05-2016 es de 540 Colones");
                    Console.WriteLine("El cambio a Colones del monto ingresado es=\t " + (tipo * 540));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("El tipo de cambio de hoy 19-05-2016 es de 540 Colones");
                    Console.WriteLine("Su saldo en la cuenta de colones es =\t" + cuenta);
                    Console.Write("Su saldo en Dolares es =\t");
                    Console.WriteLine((cuenta/540).ToString("0.00"));
                    Console.ReadKey();
                    break;
            }

        }

        
        static void Main()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1.\tDepósito de dinero.\n2.\tRetiro de dinero.\n3.\tRecibo de monedas.\n4.\tConsulta tipo de cambio.\n5.\tSalir.");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        //codigo
                        depositar_dinero();
                        break;

                    case 2:
                        //codigo
                        if (cuenta > 0)
                        {
                            Console.WriteLine("La cantidad de Dinero disponible es=\t\t" + cuenta);
                            Console.Write("Ingrese la cantidad a retirar=");
                            
                            retirodinero = int.Parse(Console.ReadLine());
                            if(retirodinero == 1000 || retirodinero == 3000)
                            {
                                Console.WriteLine("No disponemos billetes de 1000, no podemos disponer del monto solicitado.");
                                Console.ReadKey();

                            }else
                            {
                                retirar_dinero();
                            }
                            //retirar_dinero();
                        }
                        else
                        {

                            Console.WriteLine("No tiene dinero disponible en la cuenta para el retiro.");
                            Console.ReadKey();

                        }


                        break;

                    case 3:
                        //Codigo
                        recibir_monedas();
                        break;

                    case 4:
                        //Codigo
                        indicar_tipodecambio();
                        break;

                    case 5:
                        //Salir
                        break;

                                            
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida..");
                            Console.ReadKey();
                            break;
                        }
                }

            }
            while (option != 5);


        }


    }
}

