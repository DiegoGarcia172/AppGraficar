using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;

namespace AppGraficar
{
    public partial class FrmLv : Form
    {
        OpenFileDialog dialogo = new OpenFileDialog();
        public FrmLv()
        {
            InitializeComponent();
            LSTV1.View = View.Details;
        }
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string rutaARCHIVO = dialogo.FileName;
            string renglon;
            StreamReader dr = new StreamReader(rutaARCHIVO, Encoding.GetEncoding(1252));
            string columnas = dr.ReadLine();
            string[] columna = columnas.Split('|');
            for (int i = 0; i < columna.Length; i++)
            {
                LSTV1.Columns.Add(columna[i]);
            }
            while ((renglon = dr.ReadLine()) !=null)
            {
                string[] datos = renglon.Split('|');
                ListViewItem item = new ListViewItem(datos[0]);
                for (int i = 0; i < datos.Length; i++)
                {
                    item.SubItems.Add(datos[i]);
                }
                LSTV1.Items.Add(item);
            }

        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Visible = true;
        }
    }
}
