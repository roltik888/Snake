namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            panelmenu = new Panel();
            BtnHards = new Button();
            BtnMediums = new Button();
            BtnEasys = new Button();
            btnStarts = new Button();
            btnStart = new Button();
            btnEasy = new Button();
            btnMedium = new Button();
            btnHard = new Button();
            panelmenu.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelmenu
            // 
            panelmenu.BackgroundImage = Properties.Resources.tl1o;
            panelmenu.Controls.Add(BtnHards);
            panelmenu.Controls.Add(BtnMediums);
            panelmenu.Controls.Add(BtnEasys);
            panelmenu.Controls.Add(btnStarts);
            panelmenu.Dock = DockStyle.Fill;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(784, 561);
            panelmenu.TabIndex = 0;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // BtnHards
            // 
            BtnHards.BackColor = Color.Transparent;
            BtnHards.Cursor = Cursors.Hand;
            BtnHards.FlatAppearance.BorderSize = 0;
            BtnHards.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnHards.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnHards.FlatStyle = FlatStyle.Flat;
            BtnHards.Location = new Point(566, 444);
            BtnHards.Name = "BtnHards";
            BtnHards.Size = new Size(206, 86);
            BtnHards.TabIndex = 3;
            BtnHards.UseVisualStyleBackColor = false;
            BtnHards.Click += BtnHards_Click;
            // 
            // BtnMediums
            // 
            BtnMediums.BackColor = Color.Transparent;
            BtnMediums.Cursor = Cursors.Hand;
            BtnMediums.FlatAppearance.BorderSize = 0;
            BtnMediums.FlatStyle = FlatStyle.Flat;
            BtnMediums.Location = new Point(345, 455);
            BtnMediums.Name = "BtnMediums";
            BtnMediums.Size = new Size(206, 75);
            BtnMediums.TabIndex = 2;
            BtnMediums.UseVisualStyleBackColor = false;
            BtnMediums.Click += BtnMediums_Click;
            // 
            // BtnEasys
            // 
            BtnEasys.BackColor = Color.Transparent;
            BtnEasys.Cursor = Cursors.Hand;
            BtnEasys.FlatAppearance.BorderSize = 0;
            BtnEasys.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnEasys.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnEasys.FlatStyle = FlatStyle.Flat;
            BtnEasys.Location = new Point(134, 455);
            BtnEasys.Name = "BtnEasys";
            BtnEasys.Size = new Size(186, 75);
            BtnEasys.TabIndex = 1;
            BtnEasys.UseVisualStyleBackColor = false;
            BtnEasys.Click += BtnEasys_Click;
            // 
            // btnStarts
            // 
            btnStarts.BackColor = Color.Transparent;
            btnStarts.Cursor = Cursors.Hand;
            btnStarts.FlatAppearance.BorderSize = 0;
            btnStarts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStarts.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStarts.FlatStyle = FlatStyle.Flat;
            btnStarts.Location = new Point(243, 309);
            btnStarts.Name = "btnStarts";
            btnStarts.Size = new Size(411, 117);
            btnStarts.TabIndex = 0;
            btnStarts.UseVisualStyleBackColor = false;
            btnStarts.Click += btnStarts_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.Transparent;
            btnEasy.Cursor = Cursors.Hand;
            btnEasy.FlatAppearance.BorderSize = 0;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Location = new Point(133, 446);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(191, 85);
            btnEasy.TabIndex = 4;
            btnEasy.UseVisualStyleBackColor = false;
            // 
            // btnMedium
            // 
            btnMedium.BackColor = Color.Transparent;
            btnMedium.Cursor = Cursors.Hand;
            btnMedium.FlatAppearance.BorderSize = 0;
            btnMedium.FlatStyle = FlatStyle.Flat;
            btnMedium.Location = new Point(345, 446);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(213, 85);
            btnMedium.TabIndex = 5;
            btnMedium.UseVisualStyleBackColor = false;
            // 
            // btnHard
            // 
            btnHard.BackColor = Color.Transparent;
            btnHard.Cursor = Cursors.Hand;
            btnHard.FlatAppearance.BorderSize = 0;
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.Location = new Point(571, 446);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(201, 85);
            btnHard.TabIndex = 6;
            btnHard.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(784, 561);
            Controls.Add(panelmenu);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            panelmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panelmenu;
        private Button btnStart;
        private Button btnHard;
        private Button btnMedium;
        private Button btnEasy;
        private Button btnStarts;
        private Button BtnHards;
        private Button BtnMediums;
        private Button BtnEasys;
    }
}
