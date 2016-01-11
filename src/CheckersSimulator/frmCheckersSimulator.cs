using System.Drawing;
using System.Windows.Forms;

namespace CheckersSimulator
{
    public partial class frmCheckersSimulator : Form
    {
        public frmCheckersSimulator()
        {
            InitializeComponent();
        }

        private void CheckersSimulator_Load(object sender, System.EventArgs e)
        {
            var referenceSquare = squareTemplate;

            int squareCount = 1;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    bool isWhite =  (i + j) % 2 == 0;
                    string squareLabel = "";

                    if (!isWhite)
                    {
                        squareLabel = squareCount.ToString();
                        squareCount++;
                    }
                    referenceSquare = CreateSquare(referenceSquare,  squareLabel, isWhite );
                }

                referenceSquare = squareTemplate;
                squareTemplate.Top += squareTemplate.Height;
            }

           
        }

        private Square CreateSquare(Square referenceSquare, string squareLabel,  bool whiteSquare = true)
        {
            Square newSquare = null;
            if (whiteSquare)
                newSquare = GetWhiteSquare();
            else
                newSquare = GetBlackSquare(squareLabel);
            SetPosition(referenceSquare, newSquare);
            this.Controls.Add(newSquare);
            return newSquare;
        }

        private Square GetBlackSquare(string label)
        {
            Square square = GetNewSquare();
            square.BackColor = Color.Black;
            square.Id.Text = label;
            square.Controls.Add(checker);

            return square;
        }
        private Square GetWhiteSquare()
        {
            Square newSquare = GetNewSquare();
            newSquare.BackColor = Color.White;


            return newSquare;
        }


        private Square GetNewSquare()
        {
            Square square = new Square();
            square.Size = squareTemplate.Size;
            square.BackColor = squareTemplate.BackColor;
            
            return square;
        }

        private void SetPosition(Square referenceSquare, Square newSquare)
        {
            newSquare.Top = referenceSquare.Top;
            newSquare.Left = referenceSquare.Left + referenceSquare.Size.Width;
        }

        private void squareTemplate_Load(object sender, System.EventArgs e)
        {

        }
    }
}