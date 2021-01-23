using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace UI
{
    public partial class Form1 : Form
    {
        Blockchain chain = new Blockchain();
        List<Blockchain> nodos = new List<Blockchain>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompleteDataGridView();
            this.listBoxNODOS.Items.Add("Primer nodo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Block new_block = new Block();
            new_block = chain.Mine();
            if (new_block != null)
                MessageBox.Show("Nuevo bloque minado");
            else
                MessageBox.Show("No existen transacciones");

            CompleteDataGridView();
        }

        private void CompleteDataGridView()
        {
            var chain_ = chain.GetFullChain();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = chain_;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CompleteDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = -1;
            if(!int.TryParse(this.maskedTextBox3.Text,out id))
                MessageBox.Show("Por favor complete los campos correctamente");

            if (!String.IsNullOrEmpty(this.maskedTextBox1.Text) && !String.IsNullOrEmpty(this.maskedTextBox2.Text) && !String.IsNullOrEmpty(this.maskedTextBox3.Text))
            {
                id = chain.CreateTransaction(this.maskedTextBox1.Text, this.maskedTextBox2.Text, int.Parse(this.maskedTextBox3.Text));
                if (id > 0)
                    MessageBox.Show("Transacción agregada como pendiente");
                else
                    MessageBox.Show("Error al crear transaccion");
            }
                
            else
                MessageBox.Show("Por favor complete los campos correctamente");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.maskedTextBox4.Text))
            {
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = chain.GetBlockTransactions(int.Parse(this.maskedTextBox4.Text));
            }
            else
                MessageBox.Show("Por favor complete el campo correctamente");

        }

        private void buttonNODOS_Click(object sender, EventArgs e)
        {
            Blockchain chain2 = new Blockchain();
            nodos.Add(chain2);
            MessageBox.Show("Nuevo nodo creado");
            this.listBoxNODOS.Items.Add("Otro nodo");
        }

        private void buttonCONCENSO_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chain.Consensus(nodos));
        }
    }
}
