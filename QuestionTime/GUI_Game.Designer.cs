namespace QuestionTime
{
    partial class GUI_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Game));
            this.question_text_txt = new System.Windows.Forms.Label();
            this.option_b = new System.Windows.Forms.Button();
            this.option_c = new System.Windows.Forms.Button();
            this.option_d = new System.Windows.Forms.Button();
            this.option_a = new System.Windows.Forms.Button();
            this.player_name_txt = new System.Windows.Forms.Label();
            this.player_score_txt = new System.Windows.Forms.Label();
            this.right_answer_pic = new System.Windows.Forms.PictureBox();
            this.wrong_answer_pic = new System.Windows.Forms.PictureBox();
            this.final_game_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.right_answer_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrong_answer_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // question_text_txt
            // 
            this.question_text_txt.AutoSize = true;
            this.question_text_txt.Font = new System.Drawing.Font("GOST Common", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_text_txt.Location = new System.Drawing.Point(390, 106);
            this.question_text_txt.Name = "question_text_txt";
            this.question_text_txt.Size = new System.Drawing.Size(0, 26);
            this.question_text_txt.TabIndex = 0;
            this.question_text_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option_b
            // 
            this.option_b.Font = new System.Drawing.Font("GOST Common", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_b.Location = new System.Drawing.Point(568, 324);
            this.option_b.Name = "option_b";
            this.option_b.Size = new System.Drawing.Size(75, 23);
            this.option_b.TabIndex = 2;
            this.option_b.UseVisualStyleBackColor = true;
            this.option_b.Click += new System.EventHandler(this.option_b_Click);
            // 
            // option_c
            // 
            this.option_c.Font = new System.Drawing.Font("GOST Common", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_c.Location = new System.Drawing.Point(153, 426);
            this.option_c.Name = "option_c";
            this.option_c.Size = new System.Drawing.Size(75, 23);
            this.option_c.TabIndex = 3;
            this.option_c.UseVisualStyleBackColor = true;
            this.option_c.Click += new System.EventHandler(this.option_c_Click);
            // 
            // option_d
            // 
            this.option_d.Font = new System.Drawing.Font("GOST Common", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_d.Location = new System.Drawing.Point(568, 426);
            this.option_d.Name = "option_d";
            this.option_d.Size = new System.Drawing.Size(75, 23);
            this.option_d.TabIndex = 4;
            this.option_d.UseVisualStyleBackColor = true;
            this.option_d.Click += new System.EventHandler(this.option_d_Click);
            // 
            // option_a
            // 
            this.option_a.Font = new System.Drawing.Font("GOST Common", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_a.Location = new System.Drawing.Point(153, 324);
            this.option_a.Name = "option_a";
            this.option_a.Size = new System.Drawing.Size(75, 23);
            this.option_a.TabIndex = 5;
            this.option_a.UseVisualStyleBackColor = true;
            this.option_a.Click += new System.EventHandler(this.option_a_Click);
            // 
            // player_name_txt
            // 
            this.player_name_txt.AutoSize = true;
            this.player_name_txt.Font = new System.Drawing.Font("GOST Common", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_name_txt.Location = new System.Drawing.Point(59, 19);
            this.player_name_txt.Name = "player_name_txt";
            this.player_name_txt.Size = new System.Drawing.Size(0, 26);
            this.player_name_txt.TabIndex = 6;
            this.player_name_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_score_txt
            // 
            this.player_score_txt.AutoSize = true;
            this.player_score_txt.Font = new System.Drawing.Font("GOST Common", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_score_txt.Location = new System.Drawing.Point(59, 75);
            this.player_score_txt.Name = "player_score_txt";
            this.player_score_txt.Size = new System.Drawing.Size(0, 26);
            this.player_score_txt.TabIndex = 7;
            this.player_score_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right_answer_pic
            // 
            this.right_answer_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_answer_pic.BackgroundImage")));
            this.right_answer_pic.Location = new System.Drawing.Point(0, 0);
            this.right_answer_pic.Name = "right_answer_pic";
            this.right_answer_pic.Size = new System.Drawing.Size(800, 600);
            this.right_answer_pic.TabIndex = 8;
            this.right_answer_pic.TabStop = false;
            this.right_answer_pic.Visible = false;
            this.right_answer_pic.Click += new System.EventHandler(this.right_answer_pic_Click);
            // 
            // wrong_answer_pic
            // 
            this.wrong_answer_pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrong_answer_pic.BackgroundImage")));
            this.wrong_answer_pic.Location = new System.Drawing.Point(0, 0);
            this.wrong_answer_pic.Name = "wrong_answer_pic";
            this.wrong_answer_pic.Size = new System.Drawing.Size(800, 600);
            this.wrong_answer_pic.TabIndex = 9;
            this.wrong_answer_pic.TabStop = false;
            this.wrong_answer_pic.Visible = false;
            this.wrong_answer_pic.Click += new System.EventHandler(this.wrong_answer_pic_Click);
            // 
            // final_game_txt
            // 
            this.final_game_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.final_game_txt.Font = new System.Drawing.Font("GOST Common", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final_game_txt.Location = new System.Drawing.Point(0, 0);
            this.final_game_txt.Name = "final_game_txt";
            this.final_game_txt.Size = new System.Drawing.Size(784, 561);
            this.final_game_txt.TabIndex = 10;
            this.final_game_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.final_game_txt.Visible = false;
            // 
            // GUI_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.final_game_txt);
            this.Controls.Add(this.wrong_answer_pic);
            this.Controls.Add(this.right_answer_pic);
            this.Controls.Add(this.player_score_txt);
            this.Controls.Add(this.player_name_txt);
            this.Controls.Add(this.option_a);
            this.Controls.Add(this.option_d);
            this.Controls.Add(this.option_c);
            this.Controls.Add(this.option_b);
            this.Controls.Add(this.question_text_txt);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "GUI_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Game";
            ((System.ComponentModel.ISupportInitialize)(this.right_answer_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrong_answer_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label question_text_txt;
        public System.Windows.Forms.Button option_b;
        public System.Windows.Forms.Button option_c;
        public System.Windows.Forms.Button option_d;
        public System.Windows.Forms.Button option_a;
        public System.Windows.Forms.Label player_name_txt;
        public System.Windows.Forms.Label player_score_txt;
        private System.Windows.Forms.PictureBox right_answer_pic;
        private System.Windows.Forms.PictureBox wrong_answer_pic;
        private System.Windows.Forms.Label final_game_txt;
    }
}