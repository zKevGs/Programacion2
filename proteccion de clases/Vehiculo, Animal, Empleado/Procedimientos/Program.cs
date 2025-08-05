
using System;
using System.Runtime.InteropServices;

namespace Procedimientos
{
    internal class Program
    {

        //class Animal
        //{
        //    public string Nombre { get; set; }
        //    protected int Edad {  get; set; }

        //    private string _tipo;

        //    public Animal(string nombre, int edad, string tipo) { 
        //        Nombre = nombre;
        //        Edad = edad;
        //        _tipo = tipo;
        //    }
        //    public void MostrarInformacion()
        //    {
        //        Console.WriteLine($"Nombre: {Nombre}. Edad= {Edad}. Tipo: {_tipo}");
        //    }
        //}

        //class Perro : Animal { 
        //public string Raza { get; set; }
        //    public Perro(string nombre, int edad, string tipo, string raza) : base( nombre, edad, tipo)
        //    {
        //        Raza = raza;
        //    }
        //    public void MostrarInformacionPerro()
        //    {
        //        Console.WriteLine($"Nombre: {Nombre}. Edad= {Edad}.Raza: {Raza}");
        //    }
        //}

        //class Vehiculo
        //{
        //    public string Tipo{  get; set; }
        //    public string Marca { get; set; }

        //    public Vehiculo(string tipo, string marca) {
        //        Tipo = tipo;
        //        Marca = marca;
        //    }

        //    public void MostrarInformacion()
        //    {
        //        Console.WriteLine($"Tipo de vehiculo: {Tipo}. Marca: {Marca}");
        //    }
        //}

        //class Auto : Vehiculo { 
        
        //    private int _numeroPuertas {  get; set; }

        //    public Auto(string tipo, string marca, int numeroPuertas) : base (tipo, marca)
        //    {
        //        _numeroPuertas = numeroPuertas;
        //    }

        //    public void MostrarInformacionAuto()
        //    {
        //        Console.WriteLine($"Tipo de vehiculo: {Tipo}. Marca: {Marca}. Numero de puertas= {_numeroPuertas}");

        //    }
        //}

        //class Moto : Vehiculo
        //{
        //    public string Modelo { get; set; }

        //    public Moto(string tipo, string marca, string modelo) : base(tipo, marca)
        //    {
        //        Modelo = modelo;
        //    }

        //    public void MostrarInformacionMoto()
        //    {
        //        Console.WriteLine($"Tipo de vehiculo: {Tipo}. Marca: {Marca}. Modelo: {Modelo}");

        //    }
        //}

        class Empleado
        {
            private string _nombre = null;
            private decimal _salario;

            public string Nombre { get { return _nombre; } set { _nombre = value; } }
            public decimal Salario { get { return _salario; } set { if (value > 0) { _salario = value; } else { Console.WriteLine("Salario ingresado, invalido."); } } }

            public Empleado(string nombre, decimal salario)
            {
                Nombre = nombre;
                Salario = salario;
            }
            public void MostrarInformacionEmpleado()
            {
                Console.WriteLine("Nombre---Salario");
                Console.WriteLine($"{Nombre} - {Salario}");
            }
        }

        class Gerente : Empleado
        {
            private string _departamento;
            public string Departamento { get { return _departamento; } set { _departamento = value; } }

            public Gerente(string nombre, decimal salario, string departamento) : base(nombre, salario)
            {

                Departamento = departamento;

            }

            public void MostrarInformacionGerente()
            {
                Console.WriteLine("Nombre---Salario---Departamento");
                Console.WriteLine($"{Nombre} - {Salario} - {Departamento}");
            }
        }

        class Interno : Empleado
        {
            private string _ingreso;

            public string Ingreso { get { return _ingreso; } set { _ingreso = value; } }

            public Interno(string nombre, decimal salario, string ingreso) : base(nombre, salario)
            {
                Ingreso = ingreso;
            }

            public void MostrarInformacionInterno()
            {
                Console.WriteLine("Nombre---Salario---Ingreso");
                Console.WriteLine($"{Nombre} - {Salario} - {Ingreso}");
            }
        }

        static void Main(string[] args)
        {
            //Vehiculo Camion = new Vehiculo("Camion", "Chevrolet");
            //Auto Ford = new Auto("Toyota", "Corola", 4 );
            //Moto CientoDiez = new Moto("Wave", "Honda", "CientoDiez");

            //Camion.MostrarInformacion();
            //Ford.MostrarInformacionAuto();
            //CientoDiez.MostrarInformacionMoto();

            Empleado Ricardo = new Empleado("Ricardo", -10);
            Ricardo.MostrarInformacionEmpleado();

            Gerente Richard = new Gerente("Richard", 6000, "Marketing");
            Richard.MostrarInformacionGerente();

            Interno Jeronimo = new Interno("Jeronimo", 2000, "Octubre");
            Jeronimo.MostrarInformacionInterno();
        }

       

    }
}
