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
    public partial class Form1 : Form
    {

        /// <summary>
        /// 0 初期値 1ゼロワン　2クリケット 3ドラゴン
        /// </summary>
        int gameFlg = 0;
        public int people_num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameBtn_Click(object sender, EventArgs e)
        {
            //ゼロワン
            gameFlg = 1;

            //ゲーム説明非表示
            gameLbl.Text = "";
            recordingLbl.Text = "";
            explanationLbl.Text = "";
            recordingTitleLbl.Text = "";

            //ゲームボタン無効可
            gameBtn.Enabled = false;
            cricketBtn.Enabled = false;
            dragonBtn.Enabled = false;

            //マーカーを付ける
            selectLbl.Visible = true;
            selectLbl.Location = new Point(12, 343);

            //キャンセルボタン表示
            cancelBtn.Visible = true;

            //人数ボタン表示
            player1Btn.Visible = true;
            player2Btn.Visible = true;
            player3Btn.Visible = true;
            player4Btn.Visible = true;
            player2vs2Btn.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameBtn_MouseEnter(object sender, EventArgs e)
        {
            gameLbl.Text = "01 GAME";
            recordingLbl.Text = "・501 GAME";
            recordingTitleLbl.Text = "収録ゲーム";
            explanationLbl.Text = "点数を減らしていき、決まったラウンド内に\r\nぴったり0点にするゲームをプレイできます。";
        }

        private void cricketBtn_Click(object sender, EventArgs e)
        { 
            //クリケットフラグ
            gameFlg = 2;

            //ゲーム説明非表示
            gameLbl.Text = "";
            recordingLbl.Text = "";
            explanationLbl.Text = "";
            recordingTitleLbl.Text = "";

            //ゲームボタン無効可
            gameBtn.Enabled = false;
            cricketBtn.Enabled = false;
            dragonBtn.Enabled = false;

            //マーカーを付ける
            selectLbl.Visible = true;
            selectLbl.Location = new Point(12, 478);

            //キャンセルボタン表示
            cancelBtn.Visible = true;

            //人数ボタン表示
            player1Btn.Visible = true;
            player2Btn.Visible = true;
            player3Btn.Visible = true;
            player4Btn.Visible = true;
            player2vs2Btn.Visible = true;
        }

        private void cricketBtn_MouseEnter(object sender, EventArgs e)
        {
            gameLbl.Text = "CRICKET";
            recordingLbl.Text = "・スタンダード";
            recordingTitleLbl.Text = "収録ゲーム";
            explanationLbl.Text = "クリケットゲームは陣取り合戦。相手より先に\r\nクリケットナンバーへ３本入れるゲームです。";
        }

        private void dragonBtn_MouseEnter(object sender, EventArgs e)
        {
            gameLbl.Text = "VS DRAGON";
            recordingLbl.Text = "・タイマン";
            recordingTitleLbl.Text = "収録ゲーム";
            explanationLbl.Text = "CT3ダーツ部のエース「岩田　龍」に501で挑戦。倒すと豪華景品をGET！";
        }

        private void dragonBtn_Click(object sender, EventArgs e)
        {
            //ドラゴンフラグ
            gameFlg = 3;

            //ゲーム説明非表示
            gameLbl.Text = "";
            recordingLbl.Text = "";
            explanationLbl.Text = "";
            recordingTitleLbl.Text = "";

            //ゲームボタン無効可
            gameBtn.Enabled = false;
            cricketBtn.Enabled = false;
            dragonBtn.Enabled = false;

            //マーカーを付ける
            selectLbl.Visible = true;
            selectLbl.Location = new Point(12, 595);

            //キャンセルボタン表示
            cancelBtn.Visible = true;

            //人数ボタン表示
            player1Btn.Visible = true;
            player2Btn.Visible = true;
            player3Btn.Visible = true;
            player4Btn.Visible = true;
            player2vs2Btn.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //マーカー非表示
            selectLbl.Visible = false;

            //キャンセルボタン消す
            cancelBtn.Visible = false;

            //ゲームボタン有効可
            gameBtn.Enabled = true;
            cricketBtn.Enabled = true;
            dragonBtn.Enabled = true;

            //人数ボタン非表示
            player1Btn.Visible = false;
            player2Btn.Visible = false;
            player3Btn.Visible = false;
            player4Btn.Visible = false;
            player2vs2Btn.Visible = false;

            //フラグ初期値へ
            gameFlg = 0;
        }

        private void peopleBtn_Click(object sender, EventArgs e)
        {
            string joinPlayer = ((Button)sender).Text;
            string joinNum ="";
            switch (joinPlayer)
            {
                case "1Player":
                    joinNum = "1";
                    break;
                case "2Player":
                    joinNum = "2";
                    break;
                case "3Player":
                    joinNum = "3";
                    break;
                case "4Player":
                    joinNum = "4";
                    break;
                case "2vs2":
                    joinNum = "5";
                    break;


            }
            //選択されたゲームにより開くフォーム分岐
            switch (gameFlg)
            {
                case 1:
                    zerooneForm zf = new zerooneForm();
                    
                    zf.SendData = joinNum;
                    //オーナーウィンドウにthisを指定する
                    zf.ShowDialog(this);
                    //フォームが必要なくなったところで、Disposeを呼び出す
                    zf.Dispose();


                    break;

                case 2:
                    cricketForm cf = new cricketForm();

                    cf.SendData = joinNum;
                    //オーナーウィンドウにthisを指定する
                    cf.ShowDialog(this);
                    //フォームが必要なくなったところで、Disposeを呼び出す
                    cf.Dispose();


                    break;

                case 3:

                    break;

            }
            //押されたボタンから人数をフォームに送信する
            
        }
    }
}
