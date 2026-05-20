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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            panelmenu = new Panel();
            NormBtn = new Button();
            CheatBtn = new Button();
            BtnMediums = new Button();
            BtnHards = new Button();
            BtnEasys = new Button();
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
            panelmenu.BackgroundImage = (Image)resources.GetObject("panelmenu.BackgroundImage");
            panelmenu.Controls.Add(NormBtn);
            panelmenu.Controls.Add(CheatBtn);
            panelmenu.Controls.Add(BtnMediums);
            panelmenu.Controls.Add(BtnHards);
            panelmenu.Controls.Add(BtnEasys);
            panelmenu.Dock = DockStyle.Fill;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(784, 561);
            panelmenu.TabIndex = 0;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // NormBtn
            // 
            NormBtn.BackColor = Color.Transparent;
            NormBtn.Cursor = Cursors.Hand;
            NormBtn.FlatAppearance.BorderSize = 0;
            NormBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            NormBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            NormBtn.FlatStyle = FlatStyle.Flat;
            NormBtn.Location = new Point(412, 384);
            NormBtn.Name = "NormBtn";
            NormBtn.Size = new Size(175, 108);
            NormBtn.TabIndex = 7;
            NormBtn.UseVisualStyleBackColor = false;
            NormBtn.Click += NormBtn_Click;
            // 
            // CheatBtn
            // 
            CheatBtn.BackColor = Color.Transparent;
            CheatBtn.Cursor = Cursors.Hand;
            CheatBtn.FlatAppearance.BorderSize = 0;
            CheatBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CheatBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CheatBtn.FlatStyle = FlatStyle.Flat;
            CheatBtn.Location = new Point(215, 384);
            CheatBtn.Name = "CheatBtn";
            CheatBtn.Size = new Size(175, 108);
            CheatBtn.TabIndex = 6;
            CheatBtn.UseVisualStyleBackColor = false;
            CheatBtn.Click += CheatBtn_Click;
            // 
            // BtnMediums
            // 
            BtnMediums.BackColor = Color.Transparent;
            BtnMediums.Cursor = Cursors.Hand;
            BtnMediums.FlatAppearance.BorderSize = 0;
            BtnMediums.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnMediums.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnMediums.FlatStyle = FlatStyle.Flat;
            BtnMediums.Location = new Point(323, 238);
            BtnMediums.Name = "BtnMediums";
            BtnMediums.Size = new Size(161, 108);
            BtnMediums.TabIndex = 5;
            BtnMediums.UseVisualStyleBackColor = false;
            BtnMediums.Click += BtnMediums_Click_1;
            // 
            // BtnHards
            // 
            BtnHards.BackColor = Color.Transparent;
            BtnHards.Cursor = Cursors.Hand;
            BtnHards.FlatAppearance.BorderSize = 0;
            BtnHards.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnHards.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnHards.FlatStyle = FlatStyle.Flat;
            BtnHards.Location = new Point(503, 238);
            BtnHards.Name = "BtnHards";
            BtnHards.Size = new Size(159, 108);
            BtnHards.TabIndex = 3;
            BtnHards.UseVisualStyleBackColor = false;
            BtnHards.Click += BtnHards_Click;
            // 
            // BtnEasys
            // 
            BtnEasys.BackColor = Color.Transparent;
            BtnEasys.Cursor = Cursors.Hand;
            BtnEasys.FlatAppearance.BorderSize = 0;
            BtnEasys.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnEasys.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnEasys.FlatStyle = FlatStyle.Flat;
            BtnEasys.Location = new Point(147, 238);
            BtnEasys.Name = "BtnEasys";
            BtnEasys.Size = new Size(160, 108);
            BtnEasys.TabIndex = 1;
            BtnEasys.UseVisualStyleBackColor = false;
            BtnEasys.Click += BtnEasys_Click;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
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
        private Button BtnHards;
        private Button BtnEasys;
        private Button BtnMediums;
        private Button NormBtn;
        private Button CheatBtn;
    }
}
