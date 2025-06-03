namespace Kependudukan.view.kependudukan.keluarga
{
    partial class FormKeluarga
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.txtNoKK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKepalaKeluarga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            // Main Container
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);

            // Form Panel
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.AutoScroll = true;

            // Input Fields - No KK
            this.label1.AutoSize = true;
            this.label1.Text = "Nomor KK";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Size = new System.Drawing.Size(150, 19);

            this.txtNoKK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoKK.Location = new System.Drawing.Point(30, 55);
            this.txtNoKK.Size = new System.Drawing.Size(350, 26);
            this.txtNoKK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoKK.BackColor = System.Drawing.Color.WhiteSmoke;

            // Dropdown - Kepala Keluarga
            this.label2.AutoSize = true;
            this.label2.Text = "Kepala Keluarga";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Size = new System.Drawing.Size(150, 19);

            this.cbKepalaKeluarga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKepalaKeluarga.Location = new System.Drawing.Point(30, 125);
            this.cbKepalaKeluarga.Size = new System.Drawing.Size(350, 25);
            this.cbKepalaKeluarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKepalaKeluarga.BackColor = System.Drawing.Color.WhiteSmoke;

            // TextArea - Alamat
            this.label3.AutoSize = true;
            this.label3.Text = "Alamat";
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Size = new System.Drawing.Size(150, 19);

            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAlamat.Location = new System.Drawing.Point(30, 195);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Size = new System.Drawing.Size(350, 100);
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Action Buttons
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelActions.Height = 70;
            this.panelActions.Padding = new System.Windows.Forms.Padding(20);

            // Save Button
            this.btnSave.Text = "Simpan";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;

            // Edit Button
            this.btnEdit.Text = "Edit";
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);

            // Delete Button
            this.btnDelete.Text = "Hapus";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);

            // Cancel Button
            this.btnCancel.Text = "Batal";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;

            // Header Panel
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.panelHeader.Height = 60;
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);

            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Data Keluarga";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Error Provider
            this.errorProvider.ContainerControl = this;

            // Build Control Hierarchy
            this.panelHeader.Controls.Add(this.lblTitle);

            this.panelActions.Controls.Add(this.btnSave);
            this.panelActions.Controls.Add(this.btnEdit);
            this.panelActions.Controls.Add(this.btnDelete);
            this.panelActions.Controls.Add(this.btnCancel);

            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.txtNoKK);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.cbKepalaKeluarga);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.txtAlamat);

            this.panelContainer.Controls.Add(this.panelForm);
            this.panelContainer.Controls.Add(this.panelActions);
            this.panelContainer.Controls.Add(this.panelHeader);

            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Text = "Form Keluarga";
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelContainer);
        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox txtNoKK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKepalaKeluarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}