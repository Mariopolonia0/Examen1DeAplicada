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
        public Articulos articulo = new Articulos();
        public rRegistro()
        {
            InitializeComponent();
            this.DataContext = articulo;   
        }

        private void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            this.articulo = new Articulos();
            this.DataContext = articulo;
            
            
        }
        public bool validar()
        {
            if (Convert.ToInt32(productoIdTextBox.Text) == 0  )
            {
                MessageBox.Show("El Campo Articulo ID Esta Vacio O Tiene Numero", "Error Campo Incompleto");
                return  false;
            }
            else if (descripcionTextBox.Text.Length == 0)
            {
                MessageBox.Show("El Campo Descripcion Esta vacio", "Error Campo Incompleto");
                return  false;
            }
            else if (Convert.ToInt32(existenciaTextBox.Text) == 0)
            {
                MessageBox.Show("El Campo Existencia Esta vacio", "Error Campo Incompleto");
                return  false;
            }
            else if (Convert.ToInt32(costoTextBox.Text) == 0)
            {
                MessageBox.Show("El Campo Costo Esta vacio", "Error Campo Incompleto");
                return  false;
            }
            articulo.valorInventario = rArticulos.Inventario(articulo);
            return  true;
        }
  

        private void existenciaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //articulo.valorInventario = rArticulos.Inventario(articulo);
            valorinventarioTextBox.Text = rArticulos.Inventario(articulo).ToString();
        }


        private void costoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            valorinventarioTextBox.Text = rArticulos.Inventario(articulo).ToString();
        }

        private void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            if (!validar())
                return;
            articulo.valorInventario = rArticulos.Inventario(articulo);
            var paso = rArticulos.Guardar(articulo) ;

            if (paso)
            {
                valorinventarioTextBox.Text = rArticulos.Inventario(articulo).ToString();
                MessageBox.Show("Transaccione exitosa!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);


        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {

            if (rArticulos.Eliminar(Convert.ToInt32(productoIdTextBox.Text)))
            {
                limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo");
           
        }
    }
}
