using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppGraficar
{
    public partial class FrmTr : Form
    {
        public FrmTr()
        {
            InitializeComponent();
        }
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) { return; }
            filltree(ofd.FileName);
        }
        private void LlenarArbol(StreamReader sr)
        {
            string renglon;
            string x = "";
            TreeNode ciudad = new TreeNode();
            TreeNode estado = new TreeNode();
            TreeNode codigoPostal = new TreeNode();
            TreeNode colonia = new TreeNode();
            while ((renglon = sr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|');
                if (colonia.Text != datos[1] && x != "")
                {
                    if (codigoPostal.Text != datos[0] && ciudad.Text != "")
                    {
                        if (ciudad.Text != datos[5] && ciudad.Text != "")
                        {
                            if (estado.Text != datos[4] && estado.Text != "")
                            {
                                treeView1.Nodes.Add(estado.Text);
                                estado = new TreeNode();

                            }
                        }
                        estado.Text = datos[5];
                        estado.Nodes.Add(ciudad);
                        ciudad = new TreeNode();
                    }
                    ciudad.Text = datos[1];
                    codigoPostal.Nodes.Add(ciudad);
                    codigoPostal = new TreeNode();
                }
                codigoPostal.Text = datos[5];
                codigoPostal.Nodes.Add(codigoPostal);
                colonia.Text = datos[0];

            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Visible = true;
        }
        private void filltree(string filename)
        {
            Dictionary<string, List<string>> cpColonias = new Dictionary<string, List<string>>();
            string[] lineas = File.ReadAllLines(filename);
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split('|');
                string estado = campos[4];
                string ciudad = campos[5];
                string cp = campos[0];
                string colonia = campos[1];
                if (!cpColonias.ContainsKey(cp))
                {
                    cpColonias.Add(cp, new List<string>());
                }
                cpColonias[cp].Add(colonia);
                TreeNode estadoNode = null;
                foreach (TreeNode node in treeView1.Nodes)
                {
                    if (node.Text == estado)
                    {
                        estadoNode = node;
                        break;
                    }
                }
                if (estadoNode == null)
                {
                    estadoNode = new TreeNode(estado);
                    treeView1.Nodes.Add(estadoNode);
                }
                TreeNode ciudadNode = null;
                foreach (TreeNode node in estadoNode.Nodes)
                {
                    if (node.Text == ciudad)
                    {
                        ciudadNode = node;
                        break;
                    }
                }
                if (ciudadNode == null)
                {
                    ciudadNode = new TreeNode(ciudad);
                    estadoNode.Nodes.Add(ciudadNode);
                }
                TreeNode cpNode = null;
                foreach (TreeNode node in ciudadNode.Nodes)
                {
                    if (node.Text == cp)
                    {
                        cpNode = node;
                        break;
                    }
                }
                if (cpNode == null)
                {
                    cpNode = new TreeNode(cp);
                    ciudadNode.Nodes.Add(cpNode);
                }
                TreeNode coloniaNode = null;
                foreach (TreeNode node in cpNode.Nodes)
                {
                    if (node.Text == colonia)
                    {
                        coloniaNode = node;
                        break;
                    }
                }
                if (coloniaNode == null)
                {
                    coloniaNode = new TreeNode(colonia);
                    cpNode.Nodes.Add(coloniaNode);
                }
            }
        }
    }
}
