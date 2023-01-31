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
        private int edad;
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
        public int Edad { get => edad; set => edad = value; }

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
        private int calcularEdad(DateTime fecha2) 
        {
            DateTime res = DateTime.Now;
            if (this.fechaNacimiento.)
            {

            }
            return res;
        }

    }
}
