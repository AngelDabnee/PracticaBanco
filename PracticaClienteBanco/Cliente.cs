using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClienteBanco
{
    public class Cliente
    {
        //Definimos propiedades
        private string nombre;
        private string apellido;
        private string cuenta;
        private DateTime fechaNacimiento;
        private BancoEnum banco;
        //Haremos accesorios publicos para acceder a esas propiedades
        public string Nombre 
        {
            get { return this.nombre; }//Nos ayuda a retornar el valor de nombre que tenga. 
            set { this.nombre = value; }//Para que podamos cambiar el valor de nombre 
        }
        //Realizamos el encapsulamiento en las demás propiedades. 
        public string Apellido 
        { get => apellido; set => apellido = value; }
        public string Cuenta 
        { get => cuenta; set => cuenta = value; }
        public DateTime FechaNacimiento 
        { get => fechaNacimiento; set => fechaNacimiento = value; }
        public BancoEnum Banco 
        { get => banco; set => banco = value; }
        public int CalcularEdad //Modificamos el acceso del cliente, para que pueda ser "visto" por nuestra instancia y poder utilizarlo, al igual que los demás metodos
        {
            get { return this.calcularEdad(); }
        }
        public string RFC //Realizamos el encapsulamiento del metodo para hacerlo publico y podrlo utilizar. 
        {
            get { return this.calcularRFCTexto(); }
        }
        //Constructor defaul (es cuando no tenemos parametros)que le añadiremos
        /// <summary>
        /// Crea un nuevo cliente
        /// </summary>
        /// <param name="nombre">capturar todos los nombres del cliente</param>
        /// <param name="apellido">capturar los apellidos del cliente</param>
        /// <param name="cuenta">capturar el numero de cuenta del cliente</param>
        /// <param name="fechaNacimiento">capturar la fecha de nacimiento del cliente en formato AAAA-mm-dd</param>
        /// <param name="banco">de la selección de bancos de BancEnum</param>
        public Cliente(string nombre, string apellido, DateTime fechaNacimiento, BancoEnum banco) 
        {
            this.nombre = nombre;//Cuando agregamos this.nombre (en este caso), es que le agregamos el valor de los métdos al objeto
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.banco = banco;
        }
        //Se crea la sobrecarga del método ToString, para realizar la impresión del sujeto al capturar sus datos.
        public override string ToString()
        {
            return "Cliente " + this.nombre + " " + this.apellido + " usa el banco " + this.banco + " su fecha de nacimiento es: " + this.fechaNacimiento;
        }
        //Realizamos el método privado para calcular la edad, tomando encuenta el orden AAAA-mm-dd
        private int calcularEdad() 
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.Year > fechaNacimiento.Year)
            {
                if (DateTime.Now.Month >= fechaNacimiento.Month)
                {
                    if (DateTime.Now.Day > fechaNacimiento.Day)
                    {

                    }
                    else if (DateTime.Now.Day == fechaNacimiento.Day)
                    {
                    }
                    else if (DateTime.Now.Day < fechaNacimiento.Day) 
                    {
                    }
                }

            }
            return edad-1;
        }
        private string calcularRFCTexto() 
        {
            int idxEspacioBlanco = this.apellido.IndexOf(" ");//con esto, sacamos el espacio en blanco de la separación de apellidos
            //Realizamos el método el acomodo, según el orden de char que necesitamos para el rfc. 
            return this.apellido[0].ToString() + this.apellido[1].ToString() + this.apellido[idxEspacioBlanco + 1].ToString() + this.nombre[0] + "";
        }

    }
}
