using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using datagridview_y_lista_de_objetos.BLL;
namespace datagridview_y_lista_de_objetos
{
     public class Listaclas
    {


       
        
            private List<Producto> productos;
            public Listaclas()
            {
            productos = new List<Producto>

            {
                new Producto { Nombre = "Laptop", Precio = 450000 },
                new Producto { Nombre = "Mouse", Precio = 8500 },
                new Producto { Nombre = "Teclado", Precio = 15000 },
                new Producto { Nombre = "Monitor", Precio = 120000 }
            };
            }

            public List<Producto> ObtenerProductos()
            {
                return productos;
            }

        }

    }

         
             
          


         
            
        
    


