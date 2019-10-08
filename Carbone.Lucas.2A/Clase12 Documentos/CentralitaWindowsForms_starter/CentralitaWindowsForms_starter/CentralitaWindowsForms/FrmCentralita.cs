using System;
using System.Windows.Forms;
using CentralitaPolimorfismo;

namespace CentralitaWindowsForms
{
    public partial class FrmCentralita : Form
    {
        Centralita central;
        public FrmCentralita()
        {
            InitializeComponent();
            central = new Centralita();
            cboOrdenamiento.Items.Add("Ascendente");
            cboOrdenamiento.Items.Add("Descendente");
            cboOrdenamiento.SelectedItem = "Ascendente";
        }

        private void btnLlamadaLocal_Click(object sender, EventArgs e)
        {
            LlamadaLocal frmLocal = new LlamadaLocal();
            frmLocal.ShowDialog();
            if (frmLocal.DialogResult == DialogResult.OK)
            {
                central += frmLocal.GetLlamada;
                RefrescarLista();
            }
        }

        private void btnLlamadaProvincial_Click(object sender, EventArgs e)
        {
            LlamadaProvincial p = new LlamadaProvincial();
            p.ShowDialog();
            if (p.DialogResult == DialogResult.OK)
            {
                central += p.GetLlamada;
                RefrescarLista();
            }

        }
        private void RefrescarLista()
        {
            this.lstVisor.Items.Clear();
            if (this.cboOrdenamiento.SelectedItem.ToString() == "Ascendente")
            {
                central.OrdenarLlamadas(1);
            }
            else if (this.cboOrdenamiento.SelectedItem.ToString() == "Descendente")
            {

                central.OrdenarLlamadas(0);
            }

            foreach (CentralitaPolimorfismo.Llamada i in central.Llamadas)
            {
                this.lstVisor.Items.Add(i.ToString());
            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarLista();
        }
    }
}
