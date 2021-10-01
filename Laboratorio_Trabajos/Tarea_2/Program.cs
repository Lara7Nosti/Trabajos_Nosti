using System;
using System.Collections.Generic;

//Lara Nosti 5º10º
namespace Tarea_2
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNaciemiento;
        public string Nombre //Registrar nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public string Apellido //Registrar apellido
        {
            set
            {
                this.apellido = value;
            }
            get
            {
                return this.apellido;
            }
        }

        public DateTime FechaDeNacimiento //Registro de la fecha
        {
            set
            {
                this.fechaDeNaciemiento = value;
            }
            get
            {
                return this.fechaDeNaciemiento;
            }
        }

        public int CantidadDeAnios //Registro de la edad
        {
            get
            {
                return cantidadDeAnios();
            }
        }

        private int cantidadDeAnios() //Transformar fecha a edad
        {
            return DateTime.Today.AddTicks(-fechaDeNaciemiento.Ticks).Year - 1;
        }

        public Persona(string nombre, string apellido, DateTime f) //Registro por persona
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNaciemiento = f;
        }

        public Persona()
        {
        }
    }

    class Program
    {
        static List<Persona> listaDePersonas = new List<Persona>();
        private static int cantidad;
        
        static void Main(string[] args)
        {
            Persona per1;

            //Personas pre-registradas
            per1 = new Persona("Brelos", "Vicotra", new DateTime(1973, 12, 15));
            listaDePersonas.Add(per1);

            per1 = new Persona("Dariel", "Mupoat", new DateTime(1969, 9, 11));
            listaDePersonas.Add(per1);

            per1 = new Persona("Naya", "Supode", new DateTime(1982, 6, 10));
            listaDePersonas.Add(per1);

            per1 = new Persona("Mike", "Mupoin", new DateTime(2006, 3, 25));
            listaDePersonas.Add(per1);

            Console.WriteLine("Personas registradas:");
            foreach (Persona persona in listaDePersonas) //Mostrar registros de personas
            {
                Console.WriteLine("{0} {1} tiene {2} años", persona.Nombre, persona.Apellido, persona.CantidadDeAnios);
            }

            Int32 suma = 0;
            int t = 0;
            String s = null;
            String x = null;
            do
            {
                Console.WriteLine("\nElige una opcion:" +
                "\n1 -Ingreso de nueva persona" +
                "\n2 -Modificación de una persona" +
                "\n3 -Eliminación de una persona" +
                "\n4 -Informe el promedio de edad" +
                "\n5 -Listado completo" +
                "\n(Presione el numero correspondiente a la opcion)\n");

                t = Convert.ToInt16(Console.ReadLine());

                switch (t)
                {
                    case 1:
                        per1 = new Persona(); //Registro de persona nueva
                        Console.Write("Ingrese un nombre: ");
                        per1.Nombre = Console.ReadLine();
                        Console.Write("Ingrese un apellido: ");
                        per1.Apellido = Console.ReadLine();
                        Console.Write("Ingrese una fecha (día/mes/año): ");
                        per1.FechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
                        listaDePersonas.Add(per1);
                        break;
                    case 2:
                        Console.Write("Ingrese un apellido para modificar a la persona del registro: ");
                        x = Console.ReadLine();
                        foreach (Persona persona in listaDePersonas)
                        {
                            if (persona.Apellido == x) //Modificacion de la persona correspondiente
                            {
                                listaDePersonas.Remove(persona);
                                per1 = new Persona(); //Modificacion
                                Console.Write("Ingrese un nombre: ");
                                per1.Nombre = Console.ReadLine();
                                Console.Write("Ingrese un apellido: ");
                                per1.Apellido = Console.ReadLine();
                                Console.Write("Ingrese una fecha (día/mes/año): ");
                                per1.FechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
                                listaDePersonas.Add(per1);
                                break;
                            }
                        }
                        Console.WriteLine("No hay nadie con ese apellido");
                        break;
                    case 3:
                        Console.Write("Ingrese un apellido para eliminar a la persona del registro: ");
                        x = Console.ReadLine();
                        foreach (Persona persona in listaDePersonas)
                        {
                            if(persona.Apellido == x) //Eliminar persona correspondiente
                            {
                                listaDePersonas.Remove(persona);
                                break;
                            }
                        }
                        Console.WriteLine("No hay nadie con ese apellido");
                        break;
                    case 4:
                        foreach (Persona item in listaDePersonas) //Promedio de edades
                        {
                            suma = suma + item.CantidadDeAnios;
                            cantidad++;
                        }
                        Console.WriteLine("El promedio de edad es {0}", (float)suma / cantidad);
                        break;
                    case 5:
                        foreach (Persona persona in listaDePersonas) //Mostrar registros de personas
                        {
                            Console.WriteLine("{0} {1} tiene {2} años", persona.Nombre, persona.Apellido, persona.CantidadDeAnios);
                        }
                        break;
                    default:
                        Console.WriteLine("nada");
                        break;
                }

                Console.WriteLine("¿Quiere continuar? (presione s o S)");

                s = Console.ReadLine();
            } while (s == "S" || s == "s");

            Console.ReadKey();
        }
    }
}
