using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDato
{
   public class mdb_Persona
    {
        
            #region ATRIBUTOS
            private string idPersona;
            /// <summary>
            /// Especifica el Id de la persona, que será un char compuesto por: MACequipo-usuarioCreo-PER-000000001 - 17+1+7+1+3+9=38 CHAR DE 38 CARACTERES EN BD
            /// </summary>
            public string IdPersona
            {
                get { return idPersona; }
                set {
                    idPersona = value; }
            }
            /// <summary>
            /// Nombre de la persona
            /// </summary>
            private string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            /// <summary>
            /// Apellido 1
            /// </summary>
            private string apellido1;

            public string Apellido1
            {
                get { return apellido1; }
                set { apellido1 = value; }
            }
            /// <summary>
            /// Apellido 2
            /// </summary>
            private string apellido2;

            public string Apellido2
            {
                get { return apellido2; }
                set { apellido2 = value; }
            }
            /// <summary>
            /// Tipo de identificacion - DNI - NIF - PASAPORTE - OTRO, cargado de valorCodigo
            /// </summary>
            private int tipoIpf;

            public int TipoIpf
            {
                get { return tipoIpf; }
                set { tipoIpf = value; }
            }
            /// <summary>
            /// Identificacion de persona fisica
            /// </summary>
            private string ipf;

            public string Ipf
            {
                get { return ipf; }
                set { ipf = value; }
            }
            /// <summary>
            /// Fecha de nacimiento de la persona
            /// </summary>
            private DateTime fechaNacimiento;

            public DateTime FechaNacimiento
            {
                get { return fechaNacimiento; }
                set { fechaNacimiento = value; }
            }
            /// <summary>
            /// esHombre - true-hombre, false-mujer
            /// </summary>
            private bool esHombre;

            public bool EsHombre
            {
                get { return esHombre; }
                set { esHombre = value; }
            }
            /// <summary>
            /// Numero de afiliacion a la seguridad social - 12 caracteres
            /// </summary>
            private string naf;

            public string Naf
            {
                get { return naf; }
                set { naf = value; }
            }
            /// <summary>
            /// int cargado de valorCodigo de listado de nacionalidades
            /// </summary>
            private int nacionalidad;

            public int Nacionalidad
            {
                get { return nacionalidad; }
                set { nacionalidad = value; }
            }

            /// <summary>
            /// Porcentaje de discapacidad
            /// </summary>
            private decimal discapacidad;

            public decimal Discapacidad
            {
                get { return discapacidad; }
                set
                {
                    if (value>=0 && value<=100)
                        discapacidad = value;
                }
            }
            /// <summary>
            /// Foto de la persona
            /// </summary>
            //private byte foto;

            //public byte Foto
            //{
            //    get { return foto; }
            //    set { foto = value; }
            //}
            /// <summary>
            /// Si baja=true, esta de baja, si es false esta de alta. Campo que se cambiara con modificacion datos
            /// </summary>
            private bool baja;

            public bool Baja
            {
                get { return baja; }
                set { baja = value; }
            }
            /// <summary>
            /// Si es false no tiene datos de direccion insertada. Campo que se cambiara con modificacion datos
            /// </summary>
            private bool direccion;

            public bool Direccion
            {
                get { return direccion; }
                set { direccion = value; }
            }
            /// <summary>
            /// Si es false no tiene datos de contacto
            /// </summary>
            private bool contacto;

            public bool Contacto
            {
                get { return contacto; }
                set { contacto = value; }
            }
            /// <summary>
            /// Si es false no tiene datos de talla
            /// </summary>
            private bool talla;

            public bool Talla
            {
                get { return talla; }
                set { talla = value; }
            }
            /// <summary>
            /// Si es false no tiene datos de acceso
            /// </summary>
            private bool acceso;

            public bool Acceso
            {
                get { return acceso; }
                set { acceso = value; }
            }
        #endregion
        #region CONSTRUCTOR
        public mdb_Persona()
        {

        }
        public mdb_Persona(string idPersona, string nombre, string apellido1, string apellido2, int tipoIpf, string ipf,
        DateTime fechaNacimiento, bool esHombre, string naf, int nacionalidad, decimal discapacidad/*, byte[] foto */, bool baja, bool direccion,
        bool contacto, bool talla, bool acceso)
        {
            this.IdPersona = idPersona;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.TipoIpf = tipoIpf;
            this.Ipf = ipf;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.EsHombre = esHombre;
            this.Naf = naf;
            this.Nacionalidad = nacionalidad;
            this.Discapacidad = discapacidad;
            //this.Foto = Convert.ToByte(foto);
            this.Baja = baja;
            this.Direccion = direccion;
            this.Contacto = contacto;
            this.Talla = talla;
            this.Acceso = acceso;
            

        }
        #endregion
        #region METODOS/FUNCIONES
        /// <summary>
        /// Devolver apellidos y nombre de la persona
        /// </summary>
        /// <returns></returns>
        public String MostrarApellidosNombre()
        {
            return String.Format("{0} {1},{2}", Apellido1, Apellido2," "+Nombre);
        }

        #endregion
    }
}
