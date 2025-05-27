using System.ComponentModel.DataAnnotations;

namespace SisPersonal
{

    enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        investigadora,


    }
    public class Empleado
    {
        private string apellido;
        private string nombre;
        private DateTime fechaDeNac;
        private char estadoCivil;

        private DateTime fechaDeIngreso;

        private double SueldoB;

        private Cargos cargos;



        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDeNac { get => fechaDeNac; set => fechaDeNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
        public double SueldoB1 { get => SueldoB; set => SueldoB = value; }

        

        public Empleado(string apellido, string nombre, DateTime fechaDeNac, char estadoCivil, DateTime fechaDeIngreso, double sueldoB)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.FechaDeNac = fechaDeNac;
            this.EstadoCivil = estadoCivil;
            this.FechaDeIngreso = fechaDeIngreso;
            SueldoB1 = sueldoB;

        }





        public TimeSpan Antiguedad(DateTime añoActual)
        {
            TimeSpan antigu = añoActual - FechaDeIngreso;
            return antigu;
        }

        public TimeSpan Edad(DateTime añoActual)
        {
            TimeSpan edad = añoActual - FechaDeNac;
            return edad;
        }

        public int EdadfaltanteJubi(int edad)
        {
            int edadJubilacion = 65 - edad;
            return edadJubilacion;
        }

        public double Salario(){
            double salario = SueldoB1;
        }

    }
}