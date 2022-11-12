using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppPubs.Models;

namespace WindowsAppPubs.AdminDatos
{
    public static class DacAuthor
    {
        public static PubsContext context = new PubsContext();
        public static List<Author> Lista()
        {
            List<Author> autores = context.Authors.ToList();
            return autores;
        }
        public static Author TraerUno(string id)
        {
            Author autor = context.Authors.Find(id);
            return autor;
        }
        public static int Nuevo(Author autor)
        {
            int filasAfectadas = 0;
            context.Authors.Add(autor);
            filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public static int Modificar(Author autor)
        {
            int filasAfectadas = 0;

            Author autorDB=context.Authors.Find(autor.au_id);
            if(autorDB != null)
            {
                autorDB.au_lname=autor.au_lname;
                autorDB.au_fname = autor.au_fname;
                autorDB.phone = autor.phone;
                autorDB.address = autor.address;
                autorDB.city = autor.city;
                autorDB.state = autor.state;
                autorDB.zip = autor.zip;
                autorDB.contract = autor.contract;
            }
            filasAfectadas=context.SaveChanges();
            return filasAfectadas;
        }

        public static int Eliminar(Author autor)
        {
            int filasAfectadas = 0;
            Author autorDB = context.Authors.Find(autor.au_id);
            if(autorDB != null)
            {
                context.Authors.Remove(autorDB);
                filasAfectadas=context.SaveChanges();
            }
            return filasAfectadas;
        }

    }
}
