using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("islem tamam");
        }

        private void Test()
        {
            Message a = new Message();

            a.Msg = 43;
<<<<<<< Updated upstream
        
        }

        private void RemoteTest()
        {
          Message b;
=======
            
        }

        private void Test2()
        {
            return;
>>>>>>> Stashed changes
        }
    }
}
