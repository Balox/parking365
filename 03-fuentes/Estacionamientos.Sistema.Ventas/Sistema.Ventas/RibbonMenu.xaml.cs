using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;
using Sistema.Ventas.Catalogos;

namespace Sistema.Ventas
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class RibbonMenu : UserControl
    {
        public RibbonMenu()
        {
            InitializeComponent();
        }

        public void AsignaSesion(string Sesion)
        {
            MenuSesion.Label = Sesion;
            GrupoVentas.IsSelected = true;
        }

        private void ModuloVentas_Click(object sender, RoutedEventArgs e)
        {
            GrupoVentas.Visibility = System.Windows.Visibility.Visible;
            GrupoVentas.IsSelected = true;

            //GrupoCatalogos.Visibility = System.Windows.Visibility.Hidden;
            //GrupoCatalogos.IsSelected = false;
        }


        private void ModuloCatalogos_Click(object sender, RoutedEventArgs e)
        {
            GrupoCatalogos.Visibility = System.Windows.Visibility.Visible;
            GrupoCatalogos.IsSelected = true;

            //GrupoVentas.Visibility = System.Windows.Visibility.Hidden;
            //GrupoVentas.IsSelected = false;

        }

        private void MenuSesion_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().Cerrar();
        }



        private void CatalogosPersonal_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoPersonal();
        }

        private void Ventas_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirVentas();
        }

        private void Ventas_Cierre_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCierre();
        }

        private void CatalogosClientes_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoClientes();
        }

        private void CatalogosProductos_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoProductos();
        }

        private void CatalogosCitas_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoCitas();
        }

        private void CatalogosUnidades_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoUnidades();
        }

        private void CatalogosCategorias_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoCategorias();
        }

        private void CatalogosProveedores_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoProveedores();
        }

        private void CatalogosConfiguracion_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoConfiguracion();
        }

        private void CatalogosNiveles_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCatalogoNiveles();
        }


        private void Membresias_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirMembresias();
        }

        private void Paquetes_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirPaquetes();
        }

        private void Inventario_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirInventario();
        }

        private void CuentasPorPagar_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCuentasPorPagar();
        }


        private void CuentasPorCobrar_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirCuentasPorCobrar();
        }

        private void GastosCobrar_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirGastos();
        }

        private void Estacionamiento_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirEstacionamiento();
        }


        private void CatalogosMarcas_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirMarcas();
        }

        private void CatalogosModelos_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirModelo();
        }


        private void CatalogosColores_Click(object sender, RoutedEventArgs e)
        {
            new MDIMenu().AbrirColores();
        }

        
        
        
 





        private void RibbonOpciones_ContextMenuClosing_1(object sender, ContextMenuEventArgs e)
        {
            try
            {
                Ribbon control = new Ribbon();
                control = ((Ribbon)sender);

                if (control.IsMinimized == true)
                {
                    new MDIMenu().AjustarRibbonAbrir();
                }
                else
                {
                    new MDIMenu().AjustarRibbonCerrar();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RibbonOpciones_ContextMenuOpening_1(object sender, ContextMenuEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }

            Ribbon control = new Ribbon();

            control = ((Ribbon)sender);

            if (control.IsMinimized == true)
            {
                new MDIMenu().AjustarRibbonAbrir();
            }
            else
            {
                new MDIMenu().AjustarRibbonCerrar();
            }
        }


    }
}
