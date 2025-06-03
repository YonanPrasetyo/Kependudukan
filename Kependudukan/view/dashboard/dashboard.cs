using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kependudukan.view.wilayah.provinsi;
using Kependudukan.view.wilayah.kabupaten;
using Kependudukan.view.wilayah.kecamatan;
using Kependudukan.view.wilayah.desa;
using Kependudukan.view.kependudukan.penduduk;
using Kependudukan.view.kependudukan.keluarga;
using Kependudukan.view.kependudukan.ekonomi;
using Kependudukan.view.auth;


namespace Kependudukan.view
{
    public partial class dashboard: Form
    {

        private Form currentForm = null;

        public dashboard()
        {
            InitializeComponent();
        }

        private void OpenNewForm(Form newForm, String title)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = newForm;
            currentForm.TopLevel = false;
            mainPanel.Controls.Add(currentForm);
            titleLabel.Text = title;
            currentForm.Show();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ProvinsiPanel(), "Provinsi");
        }

        private void btnRegency_Click(object sender, EventArgs e)
        {
            OpenNewForm(new KabupatenPanel(), "Kabupaten");
        }

        private void btnDistrict_Click(object sender, EventArgs e)
        {
            OpenNewForm(new KecamatanPanel(), "Kecamatan");

        }

        private void btnVillage_Click(object sender, EventArgs e)
        {
            OpenNewForm(new DesaPanel(), "Desa");
        }

        private void btnPopulation_Click(object sender, EventArgs e)
        {
            OpenNewForm(new PendudukPanel(), "Penduduk");
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            OpenNewForm(new KeluargaPanel(), "Keluarga");
        }

        private void btnEconomy_Click(object sender, EventArgs e)
        {
            OpenNewForm(new EkonomiPanel(), "Ekonomi");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ChangePassword(), "Ganti Password");

        }
    }
}
