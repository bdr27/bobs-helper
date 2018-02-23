using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BobsHelper.BForm
{
    public partial class TestForm : Form
    {
        private BNotificationBubble bubble;

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            bubble = new BNotificationBubble("This is a test", this, button1);
            bubble.Show();
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bubble.Close();
        }
    }
}
