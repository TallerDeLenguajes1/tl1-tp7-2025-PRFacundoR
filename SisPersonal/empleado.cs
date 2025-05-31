using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace SisPersonal
{

    public enum Cargos
    {
        Auxiliar=500,
        Administrativo=501,
        Ingeniero=502,
        Especialista=503,
        Investigadora=504,


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
        public Cargos Cargos { get => cargos; set => cargos = value; }

        public Empleado(string apellido, string nombre, DateTime fechaDeNac, char estadoCivil, DateTime fechaDeIngreso, double sueldoB, Cargos cargos)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.FechaDeNac = fechaDeNac;
            this.EstadoCivil = estadoCivil;
            this.FechaDeIngreso = fechaDeIngreso;
            this.SueldoB1 = sueldoB;
            this.Cargos = cargos;
        }





        public int Antiguedad(DateTime añoActual)
        {
            int antigu = añoActual.Year - FechaDeIngreso.Year;
            if (añoActual.Month < FechaDeIngreso.Month || (añoActual.Month == FechaDeIngreso.Month && añoActual.Day < FechaDeIngreso.Day))
            {
                antigu--;
            }
            return antigu;
        }

        public int Edad(DateTime añoActual)
        {
            int edad = añoActual.Year - FechaDeNac.Year;
            if (añoActual.Month < FechaDeNac.Month || (añoActual.Month == FechaDeNac.Month && añoActual.Day < FechaDeNac.Day))
            {
                edad--;
            }
            return edad;
        }

        public int EdadfaltanteJubi(int edad)
        {
            int edadJubilacion = 65 - edad;
            return edadJubilacion;
        }

        private double Adicional(DateTime añoActual, double sueldoB,Cargos cargos, char estadoC)
        {
            double adicional=0;

            if (Antiguedad(añoActual) <= 20)
            {
                adicional +=  SueldoB * Antiguedad(añoActual) / 100;
            } else
            {
                adicional += SueldoB * 25 / 100;
            }

            if (cargos==Cargos.Ingeniero ||cargos==Cargos.Especialista)
            {
                adicional += SueldoB * 50 / 100;
            }

            if (estadoC == 'C' || estadoC == 'c')
            {
                adicional += 150000;
            }


            return adicional;

        }

        public double Salario(DateTime añoActual, double sueldoB,Cargos cargos, char estadoC) {
            double salario = SueldoB1 + Adicional( añoActual,  sueldoB, cargos,  estadoC);
            return salario;
         }

    }
}