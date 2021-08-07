using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace TicTacToeFormApp
{
    class TicTacToeWelcome : Form
    {
        TextBox player1Name, player2Name;
        public TicTacToeWelcome()
        {
            this.Size = new Size(500, 500);

            var titleLabel = new Label();
            titleLabel.Text = "Tic-Tac-Toe";
            titleLabel.BackColor = Color.FromArgb(40, 40, 40);
            titleLabel.ForeColor = Color.FromArgb(20, 200, 20);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Size = new Size(500, 75);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Font = new Font("Times New Roman", 50, FontStyle.Bold);

            var titlePanel = new Panel();
            titlePanel.Location = new Point(0, 0);
            titlePanel.Size = new Size(500, 75);
            titlePanel.Controls.Add(titleLabel);
            Controls.Add(titlePanel);

            player1Name = new TextBox();
            player1Name.Location = new Point(150, 100);
            player1Name.Size = new Size(200, 100);
            player1Name.Font = new Font("Times New Roman", 20);

            Label player1Label = new Label();
            player1Label.Text = "Player 1";
            player1Label.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            player1Label.Location = new Point(30, 100);
            player1Label.Size = new Size(200, 50);


            player2Name = new TextBox();
            player2Name.Location = new Point(150, 180);
            player2Name.Size = new Size(200, 100);
            player2Name.Font = new Font("Times New Roman", 20);

            Label player2Label = new Label();
            player2Label.Text = "Player 2";
            player2Label.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            player2Label.Location = new Point(30, 180);
            player2Label.Size = new Size(200, 50);

            var startGameButton = new Button();
            startGameButton.Text = "Start Game";
            startGameButton.Location = new Point(180, 250);
            startGameButton.Size = new Size(150, 60);
            startGameButton.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            startGameButton.Click += StartGame;

            Label developerLabel = new Label();
            developerLabel.Text = "developed by: " + ConfigurationManager.AppSettings["developerDetails"];
            developerLabel.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            developerLabel.Location = new Point(100, 350);
            developerLabel.Size = new Size(400, 50);

            Controls.Add(developerLabel);
            Controls.Add(player1Name);
            Controls.Add(player1Label);
            Controls.Add(player2Name);
            Controls.Add(player2Label);
            Controls.Add(startGameButton);
        }

        private void StartGame(object sender, EventArgs e)
        {
            this.Hide();

            if(player1Name.Text=="" && player2Name.Text=="")
            {
                player1Name.Text = "X";
                player2Name.Text = "O";
            }
            else if (player1Name.Text == "" && player2Name.Text != "")
            {
                player1Name.Text = "X";
            }
            else if (player1Name.Text != "" && player2Name.Text == "")
            {
                player2Name.Text = "O";
            }

            new TicTacToeGameForm(player1Name.Text, player2Name.Text).ShowDialog();
        }
    }
}
