using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class frmAuthor : Form
    {
        Author autor=new Author();
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            autor.au_id = "999-72-3568";
            autor.au_lname = "SMITH";
            autor.au_fname = "Abraham";
            autor.phone = "415-658-9932";
            autor.address = "10 Mississippi";
            autor.city = "Berkeley";
            autor.state = "CA";
            autor.zip = "94705";
            autor.contract = true;

            int filasAfectadas=DacAuthor.Nuevo(autor);
            if (filasAfectadas > 0) MessageBox.Show("Los cambios se realizaron con exito!");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            autor.au_lname = "HUNTER";
            int filasAfectadas = DacAuthor.Modificar(autor);
            if (filasAfectadas > 0) MessageBox.Show("Los cambios se realizaron con exito!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idEliminar = txtEliminar.Text; 
            var autorEliminar = DacAuthor.TraerUno(idEliminar);
            int filasAfectadas=DacAuthor.Eliminar(autorEliminar);
            if (filasAfectadas > 0) MessageBox.Show("Los cambios se realizaron con exito !");
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            gridAuthor.DataSource = DacAuthor.Lista();
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            string idTraerUno = txtTraerUno.Text;
            Author authorDB = DacAuthor.TraerUno(idTraerUno);
            lstAuthor.Items.Add($"ID : {authorDB.au_id}");
            lstAuthor.Items.Add($"Nombre : {authorDB.au_fname}");
            lstAuthor.Items.Add($"Apellido : {authorDB.au_lname}");
            lstAuthor.Items.Add($"Telefono : {authorDB.phone}");
            lstAuthor.Items.Add($"Direccion : {authorDB.address}");
            lstAuthor.Items.Add($"Ciudad : {authorDB.city}");
            lstAuthor.Items.Add($"Estado : {authorDB.state}");
            lstAuthor.Items.Add($"Zip : {authorDB.zip}");
            lstAuthor.Items.Add($"Contrato : {authorDB.contract}");
        }
    }
}
