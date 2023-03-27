using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;
using DocumentFormat.OpenXml;

namespace AppGraficar
{
    public partial class Form1 : Form
    {
        bool maximizado;
        OpenFileDialog dialogo = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            string x = "";
            int y = 0;
            while ((renglon = dr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');
                if (x != datos[0] && x != "")
                {
                    chart1.Series[0].Points.AddXY(x, y);
                    y = 0;
                    //x = datos[0];
                    //continue;
                }
                x = datos[0];
                y++;
            }
            chart1.Series[0].Points.AddXY(x, y);
            dr.Close();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
        private void BntTree_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmTr frm = new FrmTr();
            frm.Show();
        }
        private void chart1_Click(object sender, EventArgs e)
        {
            if (maximizado)
            {
                chart1.Location = new Point(436, 12);
                chart1.Height = this.Height; chart1.Width = this.Width;
            }
            else
            {
                chart1.Location = new Point(0, 0);
                chart1.Height = this.Height; chart1.Width = this.Width;
            }
            maximizado = !maximizado;
        }
        private void BtnLSV_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLv frm = new FrmLv();
            frm.Show();
        }
    }
}
