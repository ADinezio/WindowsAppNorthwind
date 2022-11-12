using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {
        private PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Publisher pub = new Publisher() {pub_id="1322",pub_name="Lux",city="Los Angeles",state="LA",country="USA"};
            context.Publishers.Add(pub);
            int filasModificadas = context.SaveChanges();
            if (filasModificadas > 0) MessageBox.Show("OK");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //buscar pub
            string id = "1322";
            Publisher pub = context.Publishers.Find(id);

            if (pub != null)
            {
                pub.pub_name = "Lux Inc";
                pub.city = "Los Angeles";
                pub.pub_id = "1322";
                pub.state = "LA";
                pub.country = "USA";
            }

            //Guardar en DB
            int filasAfectadas = context.SaveChanges();
            if (true) MessageBox.Show("OK");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            //Buscamos en la DB
            var pub = context.Publishers.Find(id);

            //si es distinto de null procedemos a eliminar.
            if (pub != null) context.Publishers.Remove(pub);

            int filasAfectadas = context.SaveChanges();

            if (filasAfectadas > 0) MessageBox.Show("OK");
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Publisher> pub = context.Publishers.ToList(); //El tolist de conecta con la db

            gridPub.DataSource = pub;
        }
    }
}
