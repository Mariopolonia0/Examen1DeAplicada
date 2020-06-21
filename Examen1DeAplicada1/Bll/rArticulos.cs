using Examen1DeAplicada1.DAL;
using Examen1DeAplicada1.Entidades;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Examen1DeAplicada1.Bll
{
    public class rArticulos
    {
        public static void Guardar(Articulos articulo)
        {
			Contexto contexto = new Contexto();

			try
			{
				contexto.Articulos.Add(articulo);
				contexto.SaveChanges();
			}

			catch (Exception)
			{
				throw;
			}

			finally
			{
				contexto.Dispose();
			}
			
        } 

		public static void Eliminar(int Id)
		{
			Contexto contexto = new Contexto();
			try
			{
				Articulos articulos = contexto.Articulos.Find(Id);
				if (articulos != null)
				{
					contexto.Articulos.Remove(articulos);
					contexto.SaveChanges();
				}

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				contexto.Dispose();
			}
		}

		public static void buscar(int Id)
		{
			Contexto contexto = new Contexto();
			Articulos articulos;

			try
			{
				articulos = contexto.Articulos.Find(Id);
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				contexto.Dispose();
			}	
		}

		public static double Inventario(Articulos articulo)
		{
			return articulo.costo * articulo.existencia; 
				
		}

	}
}
