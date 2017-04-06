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
    public partial class insertPlayerFrm : Form
    {
        private Game game;
        private SqlConnector db;

        public insertPlayerFrm(Game score)
        {
            this.game = score;
            this.db = new SqlConnector();

            InitializeComponent();
        }

        private void btnSendScore_Click(object sender, EventArgs e)
        {
            string player = tbxPlayerName.Text;
           
            if (player != string.Empty && player.Length < 25)
            {
                this.game.AddPlayer(player);
                db.InsertGame(this.game.PlayerName, this.game.Mistakes, this.game.GameDuration);
            }
            else
            {
                MessageBox.Show("Veuillez ajouter un nom de maximum 25 caractères!");
            }
            this.Close();
        }

        private void insertPlayerFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }

        private void insertPlayerFrm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = String.Format("Bravo, vous avez terminé la partie avec {0} erreurs en {1} secondes !", this.game.Mistakes, this.game.GameDuration) + Environment.NewLine;

            lblMessage.Text += Environment.NewLine + "Vous pouvez ajouter votre partie aux scores en ajoutant votre nom.";


        }
    }
}
