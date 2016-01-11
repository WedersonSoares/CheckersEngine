using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersSimulator
{
    public partial class Square : UserControl
    {
        PictureBox checker;

        public Square()
        {
            InitializeComponent();
        }

        public void ReceiveChecker(PictureBox checker)
        {
            this.checker = checker;

            CheckerContainer.Image = checker.Image;
            this.PerformLayout();
        }

        public PictureBox RemoveChecker()
        {
            var currentChecker = checker;
            checker = null;
            CheckerContainer.ImageLocation = null;
            return currentChecker;
        }
    }
}
