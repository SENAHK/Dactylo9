using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dactylo9
{
    public partial class scoresFrm : Form
    {
        private SqlConnector db;
        public scoresFrm()
        {
            InitializeComponent();
            this.db = new SqlConnector();
        }

        private void scoresFrm_Load(object sender, EventArgs e)
        {
            dgvScores.DataSource = db.GetScores().Tables[0];
        }

        private void dgvScores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 40;
            foreach (DataGridViewRow dr in dgvScores.Rows)
            {
                height += dr.Height;
            }

            dgvScores.Height = height;
            this.Size = new Size(dgvScores.Size.Width, dgvScores.Size.Height);
        }
    }
}
