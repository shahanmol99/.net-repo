using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToeLib;

namespace TicTacToeFormApp
{
    class TicTacToeGameForm : Form
    {
        Button[] buttons = new Button[9];
        Label playerName;
        Game game;
        public TicTacToeGameForm(string player1Name, string player2Name)
        {
            //initializing game
            var board = new Board(3);
            game = new Game(board);
            game.AddPlayers(new Player(player1Name, Mark.X));
            game.AddPlayers(new Player(player2Name, Mark.O));

            this.Size = new Size(500, 500);

            //Label
            playerName = new Label();
            playerName.Text = game.GetCurrentPlayer().GetName() + "'s Turn";
            playerName.BackColor = Color.FromArgb(40, 40, 40);
            playerName.ForeColor = Color.FromArgb(20, 200, 20);
            playerName.Location = new Point(0, 0);
            playerName.Size = new Size(500, 75);
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            playerName.Font = new Font("Times New Roman", 50,FontStyle.Bold);

            //TitlePanel
            var titlePanel = new Panel();
            titlePanel.Location = new Point(0, 0);
            titlePanel.Size = new Size(500, 75);
            titlePanel.Controls.Add(playerName);
            Controls.Add(titlePanel);

            //buttonPanel
            var buttonPanel = new Panel();
            buttonPanel.BackColor = Color.FromArgb(150,150,150);
            buttonPanel.Location = new Point(0, 75);
            buttonPanel.Size = new Size(500, 425);
            Controls.Add(buttonPanel);

            int x = 0;
            int y = 0;
            for (int i=0;i<9;i++)
            {
                if(x==3)
                {
                    x = 0;
                    y++;
                }
                buttons[i] = new Button();
                buttons[i].Text = i.ToString();
                buttons[i].Size = new Size(160, 140);
                buttons[i].Location = new Point(160 * x, 140 * y);
                x++;
                buttons[i].Font = new Font("Times New Roman", 50, FontStyle.Bold);
                buttons[i].Click += BoardHandler;
                buttonPanel.Controls.Add(buttons[i]);
            }
        }

        private void BoardHandler(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Enabled = false;

            int cellLoc = Convert.ToInt32(button.Text);

            if (game.GetCurrentPlayer().GetMark().Equals(Mark.X))
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            game.Play(cellLoc);

            playerName.Text = game.GetCurrentPlayer().GetName() + "'s Turn";

            SetResult();
        }

        private void SetResult()
        {
            if(game.GetGameStatus().Equals(Result.DRAW))
            {
                playerName.Text = "Game Draw";
            }
            else if(game.GetGameStatus().Equals(Result.WIN))
            {
                playerName.Text = game.GetNextPlayer().GetName() + " Wins";
            }


            if(!(game.GetGameStatus().Equals(Result.PROCESS)))
            {
                MessageBox.Show(playerName.Text);
                for (int i=0;i<9;i++)
                {
                    buttons[i].Enabled = false;
                }
            }
        }
    }
}