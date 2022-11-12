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

namespace WindowsFrmStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Store store = new Store() {stor_id="6381", stor_name="PANCHITO",stor_address="Alvarado",city="Mar del Plata",state="BA",zip="11112" };
            DacStore.Nuevo(store);
        }
    }
}
