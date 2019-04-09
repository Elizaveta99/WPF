using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_03_2018
{
    public partial class frmFridge : Form
    {
        private GameFridge gf = new GameFridge();
        public frmFridge()
        {
            InitializeComponent();
        }

        private void frmFridge_Load(object sender, EventArgs e)
        {
            dgvGame.RowCount = gf.SIZE;
            dgvGame.ColumnCount = gf.SIZE;
            for (int i = 0; i < gf.SIZE; i++)
            {
                dgvGame.Columns[i].Width = 60;
                dgvGame.Rows[i].Height = 60;
            }
            gf.startGame();
            showDGV();
        }

        private void showDGV()
        {
            for (int i = 0; i < gf.SIZE; i++)
                for (int j = 0; j < gf.SIZE; j++)
                {
                    if (gf.table[i, j])
                    {
                        dgvGame.Rows[i].Cells[j].Value = "Open";
                        dgvGame.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                        dgvGame.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dgvGame.Rows[i].Cells[j].Value = "Closed";
                        dgvGame.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        dgvGame.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                    dgvGame.Rows[i].Cells[j].Selected = false;
                }
               
        }

        private void dgvGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gf.replace(e.RowIndex, e.ColumnIndex);
            showDGV();
            if (gf.isOpen())
                MessageBox.Show("Холодильник открыт!");
        }
    }
}
