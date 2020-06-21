using Examen1DeAplicada1.Bll;
using Examen1DeAplicada1.DAL;
using Examen1DeAplicada1.Entidades;
using Examen1DeAplicada1.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen1DeAplicada1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Articulos articulo = new Articulos();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = articulo;
        }

        private void ventana_Click(object sender, RoutedEventArgs e)
        {
            rRegistro ventana = new rRegistro();
            ventana.Show();
        }

        private void Informacion_Click(object sender, RoutedEventArgs e)
        {
            Info informacion = new Info();
            informacion.Show();
        }


        /*
                private void NuevoBoton_Click(object sender, RoutedEventArgs e)
                {
                    this.articulo = new Articulos();
                    this.DataContext = articulo;
                }

                private void GuardarBoton_Click(object sender, RoutedEventArgs e)
                {
                    if (productoIdTextBox.Text.Length == 0 | descripcionTextBox.Text.Length == 0 |  costoTextBox.Text.Length == 0 | valorinventarioTextBox.Text.Length ==0 )
                        MessageBox.Show("Hay Campo Vacio");
                    else
                    {
                        rArticulos.Guardar(articulo);
                        MessageBox.Show(existenciaComboBox.Text);
                    }
                }

                private void EliminarBoton_Click(object sender, RoutedEventArgs e)
                {
                    rArticulos.Eliminar(articulo.productoId);
                }

                private void BuscarBoton_Click(object sender, RoutedEventArgs e)
                {
                    rArticulos.buscar(articulo.productoId);
                }*/
    }
}
