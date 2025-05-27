using System.Reflection;

namespace proyecto1
{
   public class Calculadora
    {
        //private float a, b;//campos =atributos privados, atributos son variables declaradas, metodos publicos
        private double resultado=0;
        

        public double Resultado
        {
            get => resultado;//leer un dato set es tomar un dato
        }

        public void Sumar(double termino)
        {
           resultado = termino + resultado;
            
            
        }
        public void Restar(double termino)
        {
            resultado -= termino;
        }
        public void Multiplicar(double termino)
        {
            resultado *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                resultado /= termino;
            }
            else
            {
                Console.WriteLine("NO se puede dividir en cero");
            }
        
        }
        public void Limpiar()
        {
             resultado = 0;
        }

    }
}