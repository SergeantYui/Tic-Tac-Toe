
namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
        private System.Windows.Forms.Button btntic3;
        private System.Windows.Forms.Button btntic2;
        private System.Windows.Forms.Button btntic5;
        private System.Windows.Forms.Button btntic6;
        private System.Windows.Forms.Button btntic4;
        private System.Windows.Forms.Button btntic8;
        private System.Windows.Forms.Button btntic9;
        private System.Windows.Forms.Button btntic7;
        private System.Windows.Forms.Label player_x_score;
        private System.Windows.Forms.Label player_o_score;
        private System.Windows.Forms.Button btntic1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button new_game_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label win_message;
    }
}

