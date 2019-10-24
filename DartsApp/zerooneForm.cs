using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartsApp
{
    public partial class zerooneForm : Form
    {
        private string joinPlayerNum;
        private int gameCounter = 0;
        private int roundScoreCount = 0;
        private Label[] array_ScoreLabel = new Label[3];
        private Label[] array_RoundScoreLabel = new Label[12];

        public string SendData
        {
            set
            {
                joinPlayerNum = value;
                ScoreBox.Text = joinPlayerNum;
                Label[] array_ScoreLabel = { ScoreLabel1, ScoreLabel2, ScoreLabel3 };
                this.array_ScoreLabel = array_ScoreLabel;
                Label[] array_RoundScoreLabel = { RoundScore1, RoundScore2, RoundScore3, RoundScore4, RoundScore5, RoundScore6, RoundScore7, RoundScore8, RoundScore9, RoundScore10, RoundScore11, RoundScore12 };
                this.array_RoundScoreLabel = array_RoundScoreLabel;
            }
        }

        public zerooneForm()
        {
            InitializeComponent();
            
        }

        private void ScoreBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if(this.gameCounter >= 3)
                {
                    array_RoundScoreLabel[roundScoreCount].Text = (int.Parse(array_ScoreLabel[0].Text) + int.Parse(array_ScoreLabel[1].Text) + int.Parse(array_ScoreLabel[2].Text)).ToString();
                    PlayerScore.Text = (int.Parse(PlayerScore.Text) - int.Parse(array_RoundScoreLabel[roundScoreCount].Text)).ToString();

                    this.gameCounter = 0;
                    foreach(Label item in array_ScoreLabel) item.Text = "---";
                    this.roundScoreCount++;
                }
                else
                {
                    array_ScoreLabel[this.gameCounter].Text = ScoreBox.Text;
                    this.gameCounter++;
                }

            }

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void zerooneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
