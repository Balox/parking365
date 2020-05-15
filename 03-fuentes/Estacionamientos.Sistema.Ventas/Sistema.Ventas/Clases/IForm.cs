using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema.Ventas.Clases
{
    //public interface iFormDetalles
    //{
    //    void CargaCierre(int Folio);
    //}

    public interface iFormClientes
    {
        void SeleccionaCliente(int iCve);
    }

    public interface iFormClientesLoad
    {
        void CargaClientes();
    }

    public interface iFormActualizaInventario
    {
        void CargaGrid();
    }

    public interface iFormAsignaProducto
    {
        void AsingaProducto(string iCve);
    }

    public interface iFormCargaCatalogoGastos
    {
        void CargaGastos();
    }
    


}
