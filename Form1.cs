namespace tictactoe
{
    public partial class Form1 : Form
    {

        private TicTacToe ticTacToe = new TicTacToe();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string currentPlayer = ticTacToe.xTurn ? "X" : "O";
            if (clickedButton.Text == "")
            {
                int index = int.Parse((string)clickedButton.Tag);
                ticTacToe.playMove(index);
                clickedButton.Text = ticTacToe.xTurn ? "X" : "O";

                if (ticTacToe.checkForWin())
                {
                    MessageBox.Show($"{currentPlayer} wins!!!!!");
                    
                    foreach(Control ctrl in this.Controls)
                    {
                        if (ctrl is Button)
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                else
                {
                    ticTacToe.switchPlayer();
                }
            }
        }
    }
}