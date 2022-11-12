using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppNorthwind.Models;

namespace WindowsAppNorthwind
{
    public partial class Form1 : Form
    {
        //Creamos instancia de EF DbContext
        private NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //creamos objeto con datos
            Shipper shopper = new Shipper() { CompanyName = "Express SRL", Phone = "(503) 555-9801" };

            //DBset
            context.Shippers.Add(shopper);

            //Guardamos en la base
            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0) MessageBox.Show("OK");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //buscar shipper
            int id = 4;
            Shipper shipperDb=context.Shippers.Find(id);

            if (shipperDb != null)
            {
                shipperDb.CompanyName = "Express Latam SRL";
                shipperDb.Phone = "(503) 555-9801";
            }

            //Guardar en DB
            int filasAfectadas = context.SaveChanges();
            if (true) MessageBox.Show("OK");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            //Buscamos en la DB
            var shipperDb=context.Shippers.Find(id);

            //si es distinto de null procedemos a eliminar.
            if (shipperDb != null) context.Shippers.Remove(shipperDb);

            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas>0) MessageBox.Show("OK");

        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Shipper> shippers = context.Shippers.ToList(); //El tolist de conecta con la db

            gridShippers.DataSource = shippers;
        }
    }
}
