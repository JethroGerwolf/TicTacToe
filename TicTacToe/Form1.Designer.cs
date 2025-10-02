namespace TicTacToe
{
    partial class FormGame
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
            MainHeader = new Label();
            menuStrip1 = new MenuStrip();
            optionToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            saveGameToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            TopLeft = new Button();
            TopCenter = new Button();
            TopRight = new Button();
            MidLeft = new Button();
            Center = new Button();
            MidRight = new Button();
            BotLeft = new Button();
            BotCenter = new Button();
            BotRight = new Button();
            saveFile = new SaveFileDialog();
            openFile = new OpenFileDialog();
            NewGameButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainHeader
            // 
            MainHeader.AutoSize = true;
            MainHeader.Font = new Font("Stencil", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MainHeader.ForeColor = SystemColors.Highlight;
            MainHeader.Location = new Point(271, 38);
            MainHeader.Name = "MainHeader";
            MainHeader.Size = new Size(470, 42);
            MainHeader.TabIndex = 0;
            MainHeader.Text = "The Game of Tic Tac Toe";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, saveGameToolStripMenuItem, historyToolStripMenuItem, exitToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "Option";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // saveGameToolStripMenuItem
            // 
            saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            saveGameToolStripMenuItem.Size = new Size(180, 22);
            saveGameToolStripMenuItem.Text = "Save Game";
            saveGameToolStripMenuItem.Click += saveGameToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(180, 22);
            historyToolStripMenuItem.Text = "Load Game";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // TopLeft
            // 
            TopLeft.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            TopLeft.Location = new Point(331, 171);
            TopLeft.Name = "TopLeft";
            TopLeft.Size = new Size(94, 82);
            TopLeft.TabIndex = 2;
            TopLeft.UseVisualStyleBackColor = true;
            TopLeft.Click += Button_Click;
            // 
            // TopCenter
            // 
            TopCenter.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            TopCenter.Location = new Point(454, 171);
            TopCenter.Name = "TopCenter";
            TopCenter.Size = new Size(94, 82);
            TopCenter.TabIndex = 3;
            TopCenter.UseVisualStyleBackColor = true;
            TopCenter.Click += Button_Click;
            // 
            // TopRight
            // 
            TopRight.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            TopRight.Location = new Point(576, 171);
            TopRight.Name = "TopRight";
            TopRight.Size = new Size(94, 82);
            TopRight.TabIndex = 4;
            TopRight.UseVisualStyleBackColor = true;
            TopRight.Click += Button_Click;
            // 
            // MidLeft
            // 
            MidLeft.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            MidLeft.Location = new Point(331, 281);
            MidLeft.Name = "MidLeft";
            MidLeft.Size = new Size(94, 82);
            MidLeft.TabIndex = 5;
            MidLeft.UseVisualStyleBackColor = true;
            MidLeft.Click += Button_Click;
            // 
            // Center
            // 
            Center.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            Center.Location = new Point(454, 281);
            Center.Name = "Center";
            Center.Size = new Size(94, 82);
            Center.TabIndex = 6;
            Center.UseVisualStyleBackColor = true;
            Center.Click += Button_Click;
            // 
            // MidRight
            // 
            MidRight.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            MidRight.Location = new Point(576, 281);
            MidRight.Name = "MidRight";
            MidRight.Size = new Size(94, 82);
            MidRight.TabIndex = 7;
            MidRight.UseVisualStyleBackColor = true;
            MidRight.Click += Button_Click;
            // 
            // BotLeft
            // 
            BotLeft.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            BotLeft.Location = new Point(331, 392);
            BotLeft.Name = "BotLeft";
            BotLeft.Size = new Size(94, 82);
            BotLeft.TabIndex = 8;
            BotLeft.UseVisualStyleBackColor = true;
            BotLeft.Click += Button_Click;
            // 
            // BotCenter
            // 
            BotCenter.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            BotCenter.Location = new Point(454, 392);
            BotCenter.Name = "BotCenter";
            BotCenter.Size = new Size(94, 82);
            BotCenter.TabIndex = 9;
            BotCenter.UseVisualStyleBackColor = true;
            BotCenter.Click += Button_Click;
            // 
            // BotRight
            // 
            BotRight.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold);
            BotRight.Location = new Point(576, 392);
            BotRight.Name = "BotRight";
            BotRight.Size = new Size(94, 82);
            BotRight.TabIndex = 10;
            BotRight.UseVisualStyleBackColor = true;
            BotRight.Click += Button_Click;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            // 
            // NewGameButton
            // 
            NewGameButton.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewGameButton.ForeColor = SystemColors.Highlight;
            NewGameButton.Location = new Point(421, 502);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(156, 48);
            NewGameButton.TabIndex = 11;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1076, 645);
            Controls.Add(NewGameButton);
            Controls.Add(BotRight);
            Controls.Add(BotCenter);
            Controls.Add(BotLeft);
            Controls.Add(MidRight);
            Controls.Add(Center);
            Controls.Add(MidLeft);
            Controls.Add(TopRight);
            Controls.Add(TopCenter);
            Controls.Add(TopLeft);
            Controls.Add(MainHeader);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormGame";
            Text = "Tic Tac Toe ";
            Load += Form1_Load;
            Click += Button_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainHeader;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button TopLeft;
        private Button TopCenter;
        private Button TopRight;
        private Button MidLeft;
        private Button Center;
        private Button MidRight;
        private Button BotLeft;
        private Button BotCenter;
        private Button BotRight;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private SaveFileDialog saveFile;
        private OpenFileDialog openFile;
        private Button NewGameButton;
    }
}