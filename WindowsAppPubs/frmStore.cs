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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Store store = new Store() { stor_id = "6381", stor_name = "PANCHITO", stor_address = "Alvarado", city = "Mar del Plata", state = "BA", zip = "11112" };
            DacStore.Nuevo(store);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Store store = new Store() { stor_id = "6381", stor_name = "ANTARES", stor_address = "Alvarado", city = "Mar del Plata", state = "BA", zip = "11112" };
            DacStore.Modificar(store);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Store store = new Store() { stor_id = "6381", stor_name = "ANTARES", stor_address = "Alvarado", city = "Mar del Plata", state = "BA", zip = "11112" };
            DacStore.Eliminar(store);
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            List<Store> store=DacStore.Lista();
            gridStore.DataSource = store;
        }

        private void btnTraerUno_Click(object sender, EventArgs e)
        {
            Store store = DacStore.TraerUno("6380");

            lstTraeUno.Items.Add(store.stor_id);
            lstTraeUno.Items.Add(store.stor_name);
            lstTraeUno.Items.Add(store.stor_address);
            lstTraeUno.Items.Add(store.city);
            lstTraeUno.Items.Add(store.state);
            lstTraeUno.Items.Add(store.zip);
        }
    }
}
