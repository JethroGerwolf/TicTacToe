namespace TicTacToe
{
    public partial class FormGame : Form
    {
        bool turn = true; // true = X turn; false = O turn
        int turn_count = 0;
        public FormGame()
        {
            InitializeComponent();
            AiTurn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
                turn = !turn;
                b.Enabled = false;
                turn_count++;
                CheckForWinner();
                AiTurn();
            }
        }
        private void AiTurn()
        {
            // Check if any button is enabled
            if (!TopLeft.Enabled && !TopCenter.Enabled && !TopRight.Enabled &&
                !MidLeft.Enabled && !Center.Enabled && !MidRight.Enabled &&
                !BotLeft.Enabled && !BotCenter.Enabled && !BotRight.Enabled)
            {
                return; // No moves left, stop recursion
            }

            Button b = new Button();
            Random rand = new Random();
            int num = rand.Next(1, 10);
            switch (num)
            {
                case 1:
                    b = TopLeft;
                    break;
                case 2:
                    b = TopCenter;
                    break;
                case 3:
                    b = TopRight;
                    break;
                case 4:
                    b = MidLeft;
                    break;
                case 5:
                    b = Center;
                    break;
                case 6:
                    b = MidRight;
                    break;
                case 7:
                    b = BotLeft;
                    break;
                case 8:
                    b = BotCenter;
                    break;
                case 9:
                    b = BotRight;
                    break;
            }
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
                turn = !turn;
                b.Enabled = false;
                turn_count++;
                CheckForWinner();
            }
            else
                AiTurn();
        }
        private void CheckForWinner()
        {
            bool there_is_a_winner = false;
            // horizontal checks
            if ((TopLeft.Text == TopCenter.Text) && (TopCenter.Text == TopRight.Text) && (!TopLeft.Enabled))
                there_is_a_winner = true;
            else if ((MidLeft.Text == Center.Text) && (Center.Text == MidRight.Text) && (!MidLeft.Enabled))
                there_is_a_winner = true;
            else if ((BotLeft.Text == BotCenter.Text) && (BotCenter.Text == BotRight.Text) && (!BotLeft.Enabled))
                there_is_a_winner = true;
            // vertical checks
            else if ((TopLeft.Text == MidLeft.Text) && (MidLeft.Text == BotLeft.Text) && (!TopLeft.Enabled))
                there_is_a_winner = true;
            else if ((TopCenter.Text == Center.Text) && (Center.Text == BotCenter.Text) && (!TopCenter.Enabled))
                there_is_a_winner = true;
            else if ((TopRight.Text == MidRight.Text) && (MidRight.Text == BotRight.Text) && (!TopRight.Enabled))
                there_is_a_winner = true;
            // diagonal checks
            else if ((TopLeft.Text == Center.Text) && (Center.Text == BotRight.Text) && (!TopLeft.Enabled))
                there_is_a_winner = true;
            else if ((TopRight.Text == Center.Text) && (Center.Text == BotLeft.Text) && (!TopRight.Enabled))
                there_is_a_winner = true;
            if (there_is_a_winner)
            {
                DisableButtons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else if (turn_count == 9)
            {
                DisableButtons();
                MessageBox.Show("Cats Game!", "Bummer!");
            }
        }
        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button b)
                    {
                        if (b != NewGameButton)
                        {
                            b.Enabled = false;
                        }
                        else
                        {
                            b.Enabled = true;
                        }
                    }
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            NewGameButton.Enabled = false;
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button b)
                    {
                        b.Enabled = true;
                        if (b != NewGameButton)
                        {
                            b.Text = "";
                        }
                    }
                }
            }
            catch { }
            AiTurn();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SaveGame(string filePath)
        {
            // Save the board state as a string (comma-separated)
            string[] board = new string[9];
            board[0] = TopLeft.Text;
            board[1] = TopCenter.Text;
            board[2] = TopRight.Text;
            board[3] = MidLeft.Text;
            board[4] = Center.Text;
            board[5] = MidRight.Text;
            board[6] = BotLeft.Text;
            board[7] = BotCenter.Text;
            board[8] = BotRight.Text;

            // Save the current player ("X" or "O")
            string currentPlayer = turn ? "X" : "O";

            // Combine board and player info
            string boardState = string.Join(",", board) + "," + currentPlayer;
            File.WriteAllText(filePath, boardState);
        }

        public void LoadGame(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Save file not found.", "Error");
                return;
            }

            string boardState = File.ReadAllText(filePath);
            string[] board = boardState.Split(',');

            if (board.Length != 10)
            {
                MessageBox.Show("Invalid save file.", "Error");
                return;
            }

            TopLeft.Text = board[0];
            TopCenter.Text = board[1];
            TopRight.Text = board[2];
            MidLeft.Text = board[3];
            Center.Text = board[4];
            MidRight.Text = board[5];
            BotLeft.Text = board[6];
            BotCenter.Text = board[7];
            BotRight.Text = board[8];

            // Restore the current player
            turn = board[9] == "X";

            // Enable/disable buttons based on loaded state
            Button[] buttons = { TopLeft, TopCenter, TopRight, MidLeft, Center, MidRight, BotLeft, BotCenter, BotRight };
            turn_count = 0;
            foreach (Button b in buttons)
            {
                if (string.IsNullOrEmpty(b.Text))
                {
                    b.Enabled = true;
                }
                else
                {
                    b.Enabled = false;
                    turn_count++;
                }
            }
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                SaveGame(saveFile.FileName);
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                LoadGame(saveFile.FileName);
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            NewGameButton.Enabled = false;
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button b && b != NewGameButton)
                    {
                        b.Enabled = true;
                        b.Text = "";
                    }
                }
            }
            catch { }
            AiTurn();
        }
    }
}
