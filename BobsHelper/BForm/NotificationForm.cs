using System;
using System.Drawing;
using System.Windows.Forms;

namespace BobsHelper.BForm
{
    public partial class NotificationForm : Form
    {
        private string message;
        private Control form;
        private Control notificationControl;

        public NotificationForm(string message, Control form, Control notificationControl)
        {
            InitializeComponent();
            this.message = message;
            this.form = form;
            this.notificationControl = notificationControl;
            lblNotification.Text = message;
        }

        private void BubbleForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
            FormBorderStyle = FormBorderStyle.None;
            Size = lblNotification.Size;

            Point topLeftAbsoluteControl = new Point
            {
                X = form.Location.X + notificationControl.Location.X - (Width - notificationControl.Width),
                Y = form.Location.Y + notificationControl.Location.Y - Height - 1
            };
            Location = topLeftAbsoluteControl;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
