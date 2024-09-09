namespace Xochilt
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Setup = new System.Windows.Forms.TabPage();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Player2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Player1 = new System.Windows.Forms.TextBox();
            this.tab_Play = new System.Windows.Forms.TabPage();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_Setup.SuspendLayout();
            this.tab_Play.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Setup);
            this.tabControl.Controls.Add(this.tab_Play);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 300);
            this.tabControl.TabIndex = 11;
            // 
            // tab_Setup
            // 
            this.tab_Setup.Controls.Add(this.btn_Start);
            this.tab_Setup.Controls.Add(this.label3);
            this.tab_Setup.Controls.Add(this.txb_Player2);
            this.tab_Setup.Controls.Add(this.label2);
            this.tab_Setup.Controls.Add(this.label1);
            this.tab_Setup.Controls.Add(this.txb_Player1);
            this.tab_Setup.ForeColor = System.Drawing.Color.DarkOrange;
            this.tab_Setup.Location = new System.Drawing.Point(4, 38);
            this.tab_Setup.Name = "tab_Setup";
            this.tab_Setup.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Setup.Size = new System.Drawing.Size(342, 258);
            this.tab_Setup.TabIndex = 0;
            this.tab_Setup.Text = "Setup Play";
            this.tab_Setup.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Start.Location = new System.Drawing.Point(101, 201);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(127, 39);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start Play";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(87, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 2";
            // 
            // txb_Player2
            // 
            this.txb_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Player2.Location = new System.Drawing.Point(193, 142);
            this.txb_Player2.Name = "txb_Player2";
            this.txb_Player2.Size = new System.Drawing.Size(53, 35);
            this.txb_Player2.TabIndex = 3;
            this.txb_Player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(87, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please indicate which character you want to use";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Player1
            // 
            this.txb_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Player1.Location = new System.Drawing.Point(193, 101);
            this.txb_Player1.Name = "txb_Player1";
            this.txb_Player1.Size = new System.Drawing.Size(53, 35);
            this.txb_Player1.TabIndex = 0;
            this.txb_Player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab_Play
            // 
            this.tab_Play.Controls.Add(this.btn_Reset);
            this.tab_Play.Controls.Add(this.btn_nine);
            this.tab_Play.Controls.Add(this.btn_eight);
            this.tab_Play.Controls.Add(this.btn_seven);
            this.tab_Play.Controls.Add(this.btn_six);
            this.tab_Play.Controls.Add(this.btn_five);
            this.tab_Play.Controls.Add(this.btn_four);
            this.tab_Play.Controls.Add(this.btn_three);
            this.tab_Play.Controls.Add(this.btn_two);
            this.tab_Play.Controls.Add(this.btn_one);
            this.tab_Play.Location = new System.Drawing.Point(4, 38);
            this.tab_Play.Name = "tab_Play";
            this.tab_Play.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Play.Size = new System.Drawing.Size(342, 258);
            this.tab_Play.TabIndex = 1;
            this.tab_Play.Text = "Start Play";
            this.tab_Play.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Location = new System.Drawing.Point(120, 215);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(95, 35);
            this.btn_Reset.TabIndex = 20;
            this.btn_Reset.Text = "New Game";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.Location = new System.Drawing.Point(206, 150);
            this.btn_nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(58, 52);
            this.btn_nine.TabIndex = 19;
            this.btn_nine.UseVisualStyleBackColor = false;
            this.btn_nine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.Location = new System.Drawing.Point(140, 150);
            this.btn_eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(58, 52);
            this.btn_eight.TabIndex = 18;
            this.btn_eight.UseVisualStyleBackColor = false;
            this.btn_eight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.Location = new System.Drawing.Point(74, 150);
            this.btn_seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(58, 52);
            this.btn_seven.TabIndex = 17;
            this.btn_seven.UseVisualStyleBackColor = false;
            this.btn_seven.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_six
            // 
            this.btn_six.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.Location = new System.Drawing.Point(206, 88);
            this.btn_six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(58, 52);
            this.btn_six.TabIndex = 16;
            this.btn_six.UseVisualStyleBackColor = false;
            this.btn_six.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.Location = new System.Drawing.Point(140, 88);
            this.btn_five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(58, 52);
            this.btn_five.TabIndex = 15;
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_four
            // 
            this.btn_four.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.Location = new System.Drawing.Point(74, 88);
            this.btn_four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(58, 52);
            this.btn_four.TabIndex = 14;
            this.btn_four.UseVisualStyleBackColor = false;
            this.btn_four.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_three
            // 
            this.btn_three.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.Location = new System.Drawing.Point(206, 26);
            this.btn_three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(58, 52);
            this.btn_three.TabIndex = 13;
            this.btn_three.UseVisualStyleBackColor = false;
            this.btn_three.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_two
            // 
            this.btn_two.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.Location = new System.Drawing.Point(140, 26);
            this.btn_two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(58, 52);
            this.btn_two.TabIndex = 12;
            this.btn_two.UseVisualStyleBackColor = false;
            this.btn_two.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.Location = new System.Drawing.Point(74, 26);
            this.btn_one.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(58, 52);
            this.btn_one.TabIndex = 11;
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(373, 324);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "TicTacToe game";
            this.tabControl.ResumeLayout(false);
            this.tab_Setup.ResumeLayout(false);
            this.tab_Setup.PerformLayout();
            this.tab_Play.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Setup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Player1;
        private System.Windows.Forms.TabPage tab_Play;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Player2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Start;
    }
}

