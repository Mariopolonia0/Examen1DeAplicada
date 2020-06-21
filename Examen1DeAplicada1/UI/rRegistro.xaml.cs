using Examen1DeAplicada1.Bll;
using Examen1DeAplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Examen1DeAplicada1.UI
{
    /// <summary>
    /// Interaction logic for rRegistro.xaml
    /// </summary>
    public partial class rRegistro : Window
    {
        private Articulos articulo = new Articulos();
        public rRegistro()
        {
            InitializeComponent();
            this.DataContext = articulo;
        }

        private void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            this.articulo = new Articulos();
            this.DataContext = articulo;
        }

        private void ValidarBoton_Click(object sender, RoutedEventArgs e)
        {
            
            if(validar())
                valorinventarioTextBox.Text = rArticulos.Inventario(articulo).ToString();
           
        }


        private bool validar()
        {
            if (productoIdTextBox.Text.Length == 0  )
            {
                MessageBox.Show("El Campo Articulo ID Esta Vacio O Tiene Numero", "Error Campo Incompleto");
                return  false;
            }
            else if (descripcionTextBox.Text.Length == 0)
            {
                MessageBox.Show("El Campo Descripcion Esta vacio", "Error Campo Incompleto");
                return  false;
            }
            else if (existenciaTextBox.Text.Length == 0)
            {
                MessageBox.Show("El Campo Existencia Esta vacio", "Error Campo Incompleto");
                return  false;
            }
            else if (costoTextBox.Text.Length == 0)
            {
                MessageBox.Show("El Campo Costo Esta vacio", "Error Campo Incompleto");
                return  false;
            }

            return  true;
        }
    }
}
