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
    public partial class cricketForm : Form
    {
        string joinPlayerNum;
        public string SendData
        {
            set
            {
                joinPlayerNum = value;
               

            }
        }
        public cricketForm()
        {
            InitializeComponent();   
        }

        private void cricketForm_Load(object sender, EventArgs e)
        {
            switch (joinPlayerNum)
            {
                case "1":
                    //座標移動
                    player1p1Lbl.Location = new Point(504, 789);
                    player1p1ScoreLbl.Location = new Point(1046, 789);

                    //プレイヤー１ネーム表示
                    player1p1Lbl.Visible = true;

                    //プレイヤー１スコア表示
                    player1p1ScoreLbl.Visible = true;
                    break;
                case "2":

                    //プレイヤー１座標移動
                    player2p1Lbl.Location = new Point(255, 842);
                    player2p1ScoreLbl.Location = new Point(635, 812);

                    //プレイヤー１ネーム表示
                    player2p1Lbl.Visible = true;

                    //プレイヤー１スコア表示
                    player2p1ScoreLbl.Visible = true;

                    //プレイヤー２座標移動
                    player2p2Lbl.Location = new Point(1396, 835);
                    player2p2ScoreLbl.Location = new Point(992, 812);

                    //プレイヤー２ネーム表示
                    player2p2Lbl.Visible = true;

                    //プレイヤー２スコア表示
                    player2p2ScoreLbl.Visible = true;

                    //仕切りの表示
                    sikiriCenterLbl.Visible = true;
                    break;
                case "3":
                    //プレイヤー１座標移動
                    player3p1Lbl.Location = new Point(254, 767);
                    player3p1ScoreLbl.Location = new Point(233, 885);

                    player3p1Lbl.Visible = true;
                    player3p1ScoreLbl.Visible = true;

                    //プレイヤー２座標移動
                    player3p2Lbl.Location = new Point(821, 767);
                    player3p2ScoreLbl.Location = new Point(800, 885);
                    player3p2Lbl.Visible = true;
                    player3p2ScoreLbl.Visible = true;

                    //プレイヤー３座標移動
                    player3p3Lbl.Location = new Point(1444, 767);
                    player3p3ScoreLbl.Location = new Point(1423, 885);
                    player3p3Lbl.Visible = true;
                    player3p3ScoreLbl.Visible = true;


                    //仕切りの表示
                    sikiriPlayer3LeftLbl.Visible = true;
                    sikiriPlayer3RightLbl.Visible = true;
                    break;
                case "4":
                case "5":
                    //プレイヤー１ネーム表示
                    player4p1Lbl.Visible = true;

                    //プレイヤー１スコア表示
                    player4p1ScoreLbl.Visible = true;

                    //プレイヤー２ネーム表示
                    player4p2Lbl.Visible = true;

                    //プレイヤー２スコア表示
                    player4p2ScoreLbl.Visible = true;

                    //プレイヤー３ネーム表示
                    player4p3Lbl.Visible = true;

                    //プレイヤー３スコア表示
                    player4p3ScoreLbl.Visible = true;

                    //プレイヤー４ネーム表示
                    player4p4Lbl.Visible = true;

                    //プレイヤー４スコア表示
                    player4p4ScoreLbl.Visible = true;

                    //仕切りの表示
                    sikiriCenterLbl.Visible = true;
                    sikiriLeftLbl.Visible = true;
                    sikiriRightLbl.Visible = true;
                
                    break;

            }
            
        }
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
