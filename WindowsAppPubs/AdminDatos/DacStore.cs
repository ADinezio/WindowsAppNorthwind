using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacStore
    {
        static private PubsContext context = new PubsContext();
        public static List<Store> Lista()
        {
            List<Store> lista = context.Stores.ToList();
            return lista;
        }
        public static Store TraerUno(string id)
        {
            Store storeDB = context.Stores.Find(id);
            return storeDB;
        }

        public static int Nuevo(Store store)
        {
            context.Stores.Add(store);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public static int Modificar(Store store)
        {
            var dato =context.Stores.Find(store.stor_id);
            if (dato != null)
            {
                dato.stor_name = store.stor_name;
                dato.stor_address = store.stor_address;
                dato.city = store.city;
                dato.state = store.state;
                dato.zip = store.zip;
            }
            int filasAfectadas = context.SaveChanges();
            
            return filasAfectadas;
        }

        public static int Eliminar(Store store)
        {
            var dato=context.Stores.Find(store.stor_id);
            if (dato != null) context.Stores.Remove(dato);

            int filasAfectadas=context.SaveChanges();

            return filasAfectadas;
        }
    }
}
