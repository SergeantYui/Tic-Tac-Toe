using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{

    public partial class Form1 : Form
    {
        Boolean pattern;
        Boolean checker;
        int score;
        int draw_counter;

        void Enable_False()
        {
            btntic1.Enabled = false;
            btntic2.Enabled = false;
            btntic3.Enabled = false;
            btntic4.Enabled = false;
            btntic5.Enabled = false;
            btntic6.Enabled = false;
            btntic7.Enabled = false;
            btntic8.Enabled = false;
            btntic9.Enabled = false;
        }
        void New_Game()
        {
            btntic1.Enabled = true;
            btntic2.Enabled = true;
            btntic3.Enabled = true;
            btntic4.Enabled = true;
            btntic5.Enabled = true;
            btntic6.Enabled = true;
            btntic7.Enabled = true;
            btntic8.Enabled = true;
            btntic9.Enabled = true;

            btntic1.Text = "";
            btntic2.Text = "";
            btntic3.Text = "";
            btntic4.Text = "";
            btntic5.Text = "";
            btntic6.Text = "";
            btntic7.Text = "";
            btntic8.Text = "";
            btntic9.Text = "";

            player_x_score.Text = "0";
            player_o_score.Text = "0";

            btntic1.BackColor = Color.Transparent;
            btntic2.BackColor = Color.Transparent;
            btntic3.BackColor = Color.Transparent;
            btntic4.BackColor = Color.Transparent;
            btntic5.BackColor = Color.Transparent;
            btntic6.BackColor = Color.Transparent;
            btntic7.BackColor = Color.Transparent;
            btntic8.BackColor = Color.Transparent;
            btntic9.BackColor = Color.Transparent;

            checker = false;

            win_message.Text = "";

            draw_counter = 0;

            pattern = false;
        }
        void Reset()
        {
            btntic1.Enabled = true;
            btntic2.Enabled = true;
            btntic3.Enabled = true;
            btntic4.Enabled = true;
            btntic5.Enabled = true;
            btntic6.Enabled = true;
            btntic7.Enabled = true;
            btntic8.Enabled = true;
            btntic9.Enabled = true;

            btntic1.Text = "";
            btntic2.Text = "";
            btntic3.Text = "";
            btntic4.Text = "";
            btntic5.Text = "";
            btntic6.Text = "";
            btntic7.Text = "";
            btntic8.Text = "";
            btntic9.Text = "";

            btntic1.BackColor = Color.Transparent;
            btntic2.BackColor = Color.Transparent;
            btntic3.BackColor = Color.Transparent;
            btntic4.BackColor = Color.Transparent;
            btntic5.BackColor = Color.Transparent;
            btntic6.BackColor = Color.Transparent;
            btntic7.BackColor = Color.Transparent;
            btntic8.BackColor = Color.Transparent;
            btntic9.BackColor = Color.Transparent;

            checker = false;

            win_message.Text = "";

            draw_counter = 0;

            pattern = false;

        }
        void Score()
        {
            //-----------------------------------------------X---------------------------------------
            //Horizontol pattern X
            if (btntic1.Text == "X" && btntic2.Text == "X" && btntic3.Text == "X" && pattern == false)
            {
                btntic1.BackColor = Color.Red;
                btntic2.BackColor = Color.Red;
                btntic3.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic4.Text == "X" && btntic5.Text == "X" && btntic6.Text == "X" && pattern == false)
            {
                btntic4.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic6.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic7.Text == "X" && btntic8.Text == "X" && btntic9.Text == "X" && pattern == false)
            {
                btntic7.BackColor = Color.Red;
                btntic8.BackColor = Color.Red;
                btntic9.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            //Vertical Pattern X
            if (btntic1.Text == "X" && btntic4.Text == "X" && btntic7.Text == "X" && pattern == false)
            {
                btntic1.BackColor = Color.Red;
                btntic4.BackColor = Color.Red;
                btntic7.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic2.Text == "X" && btntic5.Text == "X" && btntic8.Text == "X" && pattern == false)
            {
                btntic2.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic8.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic3.Text == "X" && btntic6.Text == "X" && btntic9.Text == "X" && pattern == false)
            {
                btntic3.BackColor = Color.Red;
                btntic6.BackColor = Color.Red;
                btntic9.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            //Diagonal Pattern X
            if (btntic1.Text == "X" && btntic5.Text == "X" && btntic9.Text == "X" && pattern == false)
            {
                btntic1.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic9.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic3.Text == "X" && btntic5.Text == "X" && btntic7.Text == "X" && pattern == false)
            {
                btntic3.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic7.BackColor = Color.Red;

                score = int.Parse(player_x_score.Text) + 1;
                player_x_score.Text = Convert.ToString(score);
                win_message.Text = "Player X got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;

            }

            //-----------------------------------------------O---------------------------------------
            //Horizontol pattern O
            if (btntic1.Text == "O" && btntic2.Text == "O" && btntic3.Text == "O" && pattern == false)
            {
                btntic1.BackColor = Color.Red;
                btntic2.BackColor = Color.Red;
                btntic3.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;

            }
            if (btntic4.Text == "O" && btntic5.Text == "O" && btntic6.Text == "O" && pattern == false)
            {
                btntic4.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic6.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;

            }
            if (btntic7.Text == "O" && btntic8.Text == "O" && btntic9.Text == "O" && pattern == false)
            {
                btntic7.BackColor = Color.Red;
                btntic8.BackColor = Color.Red;
                btntic9.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            //Vertical Pattern O
            if (btntic1.Text == "O" && btntic4.Text == "O" && btntic7.Text == "O" && pattern == false)
            {
                btntic1.BackColor = Color.Red;
                btntic4.BackColor = Color.Red;
                btntic7.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;

            }
            if (btntic2.Text == "O" && btntic5.Text == "O" && btntic8.Text == "O" && pattern == false)
            {
                btntic2.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic8.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic3.Text == "O" && btntic6.Text == "O" && btntic9.Text == "O" && pattern == false)
            {
                btntic3.BackColor = Color.Red;
                btntic6.BackColor = Color.Red;
                btntic9.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            //Diagonal Pattern O
            if (btntic1.Text == "O" && btntic5.Text == "O" && btntic9.Text == "O" && pattern == false)
            {
                btntic1.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic9.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (btntic3.Text == "O" && btntic5.Text == "O" && btntic7.Text == "O" && pattern == false)
            {
                btntic3.BackColor = Color.Red;
                btntic5.BackColor = Color.Red;
                btntic7.BackColor = Color.Red;

                score = int.Parse(player_o_score.Text) + 1;
                player_o_score.Text = Convert.ToString(score);
                win_message.Text = "Player O got a point!";
                Enable_False();
                draw_counter = 0;
                pattern = true;
            }
            if (draw_counter == 8 && pattern == false)
            {
                win_message.Text = "We got a Draw!";
            }
                
            
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void btntic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic1.Text = "X";
                checker = true;
            }
            else
            {
                btntic1.Text = "O";
                checker = false;
            }
            Score();
            btntic1.Enabled = false;
            draw_counter += 1;
        }

        private void btntic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic2.Text = "X";
                checker = true;
            }
            else
            {
                btntic2.Text = "O";
                checker = false;
            }
            Score();
            btntic2.Enabled = false;
            draw_counter += 1;

        }

        private void btntic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic3.Text = "X";
                checker = true;
            }
            else
            {
                btntic3.Text = "O";
                checker = false;
            }
            Score();
            btntic3.Enabled = false;
            draw_counter += 1;
        }

        private void btntic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic4.Text = "X";
                checker = true;
            }
            else
            {
                btntic4.Text = "O";
                checker = false;
            }
            Score();
            btntic4.Enabled = false;
            draw_counter += 1;
        }

        private void btntic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic5.Text = "X";
                checker = true;
            }
            else
            {
                btntic5.Text = "O";
                checker = false;
            }
            Score();
            btntic5.Enabled = false;
            draw_counter += 1;
        }

        private void btntic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic6.Text = "X";
                checker = true;
            }
            else
            {
                btntic6.Text = "O";
                checker = false;
            }
            Score();
            btntic6.Enabled = false;
            draw_counter += 1;
        }

        private void btntic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic7.Text = "X";
                checker = true;
            }
            else
            {
                btntic7.Text = "O";
                checker = false;
            }
            Score();
            btntic7.Enabled = false;
            draw_counter += 1;
        }

        private void btntic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic8.Text = "X";
                checker = true;
            }
            else
            {
                btntic8.Text = "O";
                checker = false;
            }
            Score();
            btntic8.Enabled = false;
            draw_counter += 1;
        }

        private void btntic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic9.Text = "X";
                checker = true;
            }
            else
            {
                btntic9.Text = "O";
                checker = false;
            }
            Score();
            btntic9.Enabled = false;
            draw_counter += 1;
        }

        private void new_game_btn_Click(object sender, EventArgs e)
        {
            New_Game();
        }
        private void reset_btn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult confirm;
            confirm = MessageBox.Show("Are you you want to Quit?", "Exit?", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        
    }
}
