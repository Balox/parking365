using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Facturacion.Electronica
{
   static class Variables
    {
        private static string _Usuario;
        public static string Usuario
        {
            get { return Variables._Usuario; }
            set { Variables._Usuario = value; }
        }

        private static int _iCveUsuario;
        public static int iCveUsuario
        {
            get { return Variables._iCveUsuario; }
            set { Variables._iCveUsuario = value; }
        }

        private static Byte _iCveUsuarioAdministrador;
        public static Byte iCveUsuarioAdministrador
        {
            get { return Variables._iCveUsuarioAdministrador; }
            set { Variables._iCveUsuarioAdministrador = value; }
        }


        private static string _NombreEmpresa;
        public static string NombreEmpresa
        {
            get { return Variables._NombreEmpresa; }
            set { Variables._NombreEmpresa = value; }
        }


        private static DataTable _dtVenta;
        public static DataTable dtVenta
        {
            get { return Variables._dtVenta; }
            set { Variables._dtVenta = value; }
        }

        // SELECT Impresora, RazonSocial, RFC, Domicilio, Ciudad, Estado, Telefono, Email, Saludo, Logo FROM Configuracion;
        private static DataTable _dtConfiguracion;
        public static DataTable dtConfiguracion
        {
            get { return Variables._dtConfiguracion; }
            set { Variables._dtConfiguracion = value; }
        }


        private static string _PassEncriptacion;
        public static string PassEncriptacion
        {
            get { return Variables._PassEncriptacion; }
            set { Variables._PassEncriptacion = value; }
        }


        private static int _FolioDetalles;
        public static int FolioDetalles
        {
            get { return Variables._FolioDetalles; }
            set { Variables._FolioDetalles = value; }
        }


        private static DataTable _dtMembresiaDetalle;
        public static DataTable dtMembresiaDetalle
        {
            get { return Variables._dtMembresiaDetalle; }
            set { Variables._dtMembresiaDetalle = value; }
        }


        private static int _TamañoGrid;
        public static int TamañoGrid
        {
            get { return Variables._TamañoGrid; }
            set { Variables._TamañoGrid = value; }
        }


        private static string _Auxiliar;
        public static string Auxiliar
        {
            get { return Variables._Auxiliar; }
            set { Variables._Auxiliar = value; }
        }

        private static string _UsuarioTAE;
        public static string UsuarioTAE
        {
            get { return Variables._UsuarioTAE; }
            set { Variables._UsuarioTAE = value; }
        }

        private static string _ContraseñaTAE;
        public static string ContraseñaTAE
        {
            get { return Variables._ContraseñaTAE; }
            set { Variables._ContraseñaTAE = value; }
        }
        private static string _GastoComentario;
        public static string GastoComentario
        {
            get { return Variables._GastoComentario; }
            set { Variables._GastoComentario = value; }
        }

        private static string _GastoImporte;
        public static string GastoImporte
        {
            get { return Variables._GastoImporte; }
            set { Variables._GastoImporte = value; }
        }

    }
}
