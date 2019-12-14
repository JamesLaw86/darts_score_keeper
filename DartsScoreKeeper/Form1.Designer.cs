namespace DartsScoreKeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textScore1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textScore2 = new System.Windows.Forms.TextBox();
            this.textCurrentScore = new System.Windows.Forms.TextBox();
            this.radioPlayer2 = new System.Windows.Forms.RadioButton();
            this.radioPlayer1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.dartP1 = new System.Windows.Forms.PictureBox();
            this.dartP2 = new System.Windows.Forms.PictureBox();
            this.btn301 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dartP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dartP2)).BeginInit();
            this.SuspendLayout();
            // 
            // textScore1
            // 
            this.textScore1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore1.Location = new System.Drawing.Point(80, 83);
            this.textScore1.Name = "textScore1";
            this.textScore1.ReadOnly = true;
            this.textScore1.Size = new System.Drawing.Size(194, 74);
            this.textScore1.TabIndex = 0;
            this.textScore1.Text = "501";
            this.textScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1 Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2 Score";
            // 
            // textScore2
            // 
            this.textScore2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore2.Location = new System.Drawing.Point(522, 83);
            this.textScore2.Name = "textScore2";
            this.textScore2.ReadOnly = true;
            this.textScore2.Size = new System.Drawing.Size(194, 74);
            this.textScore2.TabIndex = 2;
            this.textScore2.Text = "501";
            this.textScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCurrentScore
            // 
            this.textCurrentScore.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentScore.Location = new System.Drawing.Point(320, 265);
            this.textCurrentScore.Name = "textCurrentScore";
            this.textCurrentScore.Size = new System.Drawing.Size(152, 63);
            this.textCurrentScore.TabIndex = 0;
            this.textCurrentScore.Text = "180";
            this.textCurrentScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCurrentScore.TextChanged += new System.EventHandler(this.textCurrentScore_TextChanged);
            this.textCurrentScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCurrentScore_KeyPress);
            this.textCurrentScore.Leave += new System.EventHandler(this.textCurrentScore_Leave);
            // 
            // radioPlayer2
            // 
            this.radioPlayer2.AutoSize = true;
            this.radioPlayer2.Location = new System.Drawing.Point(489, 278);
            this.radioPlayer2.Name = "radioPlayer2";
            this.radioPlayer2.Size = new System.Drawing.Size(155, 24);
            this.radioPlayer2.TabIndex = 5;
            this.radioPlayer2.TabStop = true;
            this.radioPlayer2.Text = "Payer 2 Throwing";
            this.radioPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioPlayer2.UseVisualStyleBackColor = true;
            this.radioPlayer2.CheckedChanged += new System.EventHandler(this.radioPlayer2_CheckedChanged);
            // 
            // radioPlayer1
            // 
            this.radioPlayer1.AutoSize = true;
            this.radioPlayer1.Location = new System.Drawing.Point(143, 278);
            this.radioPlayer1.Name = "radioPlayer1";
            this.radioPlayer1.Size = new System.Drawing.Size(158, 24);
            this.radioPlayer1.TabIndex = 6;
            this.radioPlayer1.TabStop = true;
            this.radioPlayer1.Text = "Player 1 Throwing";
            this.radioPlayer1.UseVisualStyleBackColor = true;
            this.radioPlayer1.CheckedChanged += new System.EventHandler(this.radioPlayer1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Score";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(45, 453);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(113, 46);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // dartP1
            // 
            this.dartP1.Image = ((System.Drawing.Image)(resources.GetObject("dartP1.Image")));
            this.dartP1.Location = new System.Drawing.Point(22, 265);
            this.dartP1.Name = "dartP1";
            this.dartP1.Size = new System.Drawing.Size(100, 50);
            this.dartP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dartP1.TabIndex = 9;
            this.dartP1.TabStop = false;
            // 
            // dartP2
            // 
            this.dartP2.Image = ((System.Drawing.Image)(resources.GetObject("dartP2.Image")));
            this.dartP2.Location = new System.Drawing.Point(676, 265);
            this.dartP2.Name = "dartP2";
            this.dartP2.Size = new System.Drawing.Size(100, 50);
            this.dartP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dartP2.TabIndex = 8;
            this.dartP2.TabStop = false;
            // 
            // btn301
            // 
            this.btn301.Location = new System.Drawing.Point(188, 453);
            this.btn301.Name = "btn301";
            this.btn301.Size = new System.Drawing.Size(113, 46);
            this.btn301.TabIndex = 10;
            this.btn301.Text = "301";
            this.btn301.UseVisualStyleBackColor = true;
            this.btn301.Click += new System.EventHandler(this.btn301_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 526);
            this.Controls.Add(this.btn301);
            this.Controls.Add(this.dartP1);
            this.Controls.Add(this.dartP2);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioPlayer1);
            this.Controls.Add(this.radioPlayer2);
            this.Controls.Add(this.textCurrentScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textScore2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textScore1);
            this.Name = "Form1";
            this.Text = "Game On!";
            ((System.ComponentModel.ISupportInitialize)(this.dartP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dartP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textScore1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textScore2;
        private System.Windows.Forms.TextBox textCurrentScore;
        private System.Windows.Forms.RadioButton radioPlayer2;
        private System.Windows.Forms.RadioButton radioPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox dartP2;
        private System.Windows.Forms.PictureBox dartP1;
        private System.Windows.Forms.Button btn301;
    }
}

