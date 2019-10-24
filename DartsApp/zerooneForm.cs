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
        private Label[] array_Player1ScoreLabel = new Label[3];
        private Label[] array_Player1RoundScoreLabel = new Label[12];
        private Label[] array_Player2ScoreLabel = new Label[3];
        private Label[] array_Player2RoundScoreLabel = new Label[12];
        private bool finishFlag = true;

        public string SendData
        {
            set
            {
                joinPlayerNum = value;
                Label[] array_Player1ScoreLabel = { Player1_ScoreLabel1, Player1_ScoreLabel2, Player1_ScoreLabel3 };
                this.array_Player1ScoreLabel = array_Player1ScoreLabel;
                Label[] array_Player1RoundScoreLabel = { Player1_RoundScore1, Player1_RoundScore2, Player1_RoundScore3, Player1_RoundScore4, Player1_RoundScore5, Player1_RoundScore6, Player1_RoundScore7, Player1_RoundScore8, Player1_RoundScore9, Player1_RoundScore10, Player1_RoundScore11, Player1_RoundScore12 };
                this.array_Player1RoundScoreLabel = array_Player1RoundScoreLabel;

                Label[] array_Player2ScoreLabel = { Player2_ScoreLabel1, Player2_ScoreLabel2, Player2_ScoreLabel3 };
                this.array_Player2ScoreLabel = array_Player2ScoreLabel;
                Label[] array_Player2RoundScoreLabel = { Player2_RoundScore1, Player2_RoundScore2, Player2_RoundScore3, Player2_RoundScore4, Player2_RoundScore5, Player2_RoundScore6, Player2_RoundScore7, Player2_RoundScore8, Player2_RoundScore9, Player2_RoundScore10, Player2_RoundScore11, Player2_RoundScore12 };
                this.array_Player2RoundScoreLabel = array_Player2RoundScoreLabel;
            }
        }

        public zerooneForm()
        {
            InitializeComponent();
            
        }

        private void ScoreBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            if (e.KeyData == Keys.Enter && int.TryParse(ScoreBox1.Text, out i) && int.Parse(ScoreBox1.Text) <= 60)
            {
                array_Player1ScoreLabel[this.gameCounter].Text = ScoreBox1.Text;
                ScoreBox1.Text = "";
                this.gameCounter++;

                if (this.gameCounter >= 3)
                {
                    ScoreBox1.Enabled = false;
                    ScoreBox2.Enabled = true;

                    array_Player1RoundScoreLabel[roundScoreCount].Text = (int.Parse(array_Player1ScoreLabel[0].Text) + int.Parse(array_Player1ScoreLabel[1].Text) + int.Parse(array_Player1ScoreLabel[2].Text)).ToString();
                    Player1Score.Text = (int.Parse(Player1Score.Text) - int.Parse(array_Player1RoundScoreLabel[roundScoreCount].Text)).ToString();
                    this.gameCounter = 0;
                    foreach (Label item in array_Player2ScoreLabel) item.Text = "---";
                    ScoreBox1.Text = "";
                }
            }
        }

        private void ScoreBox2_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            if (e.KeyData == Keys.Enter && int.TryParse(ScoreBox2.Text, out i) && int.Parse(ScoreBox2.Text) <= 60)
            {
                array_Player2ScoreLabel[this.gameCounter].Text = ScoreBox2.Text;
                ScoreBox2.Text = "";
                this.gameCounter++;

                if (this.gameCounter >= 3)
                { 
                    ScoreBox2.Enabled = false;
                    ScoreBox1.Enabled = true;

                    array_Player2RoundScoreLabel[roundScoreCount].Text = (int.Parse(array_Player2ScoreLabel[0].Text) + int.Parse(array_Player2ScoreLabel[1].Text) + int.Parse(array_Player2ScoreLabel[2].Text)).ToString();
                    Player2Score.Text = (int.Parse(Player2Score.Text) - int.Parse(array_Player2RoundScoreLabel[roundScoreCount].Text)).ToString();

                    this.gameCounter = 0;
                    foreach (Label item in array_Player1ScoreLabel) item.Text = "---";
                    ScoreBox2.Text = "";
                    this.roundScoreCount++;

                    if (this.roundScoreCount >= 12)
                    {
                        MessageBox.Show("引き分けです");
                        ScoreBox1.Enabled = false;
                        ScoreBox2.Enabled = false;
                    }
                }
            }
        }

        private void PlayerScore_TextChanged(object sender, EventArgs e)
        {
            if (finishFlag)
            { 
                if(Player1Score.Text != "" && int.Parse(Player1Score.Text) <= 0)
                {
                    MessageBox.Show("Player1の勝利！！");
                    ScoreBox1.Enabled = false;
                    ScoreBox2.Enabled = false;
                    finishFlag = false;
                    Player1Score.Text = "0";
                }
                else if(Player2Score.Text != "" && int.Parse(Player2Score.Text) <= 0)
                {
                    MessageBox.Show("Player2の勝利！！");
                    ScoreBox1.Enabled = false;
                    ScoreBox2.Enabled = false;
                    finishFlag = false;
                    Player2Score.Text = "0";
                }
            }
        }
    }
}
