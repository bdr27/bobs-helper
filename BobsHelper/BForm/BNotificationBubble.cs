using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BobsHelper.BForm
{
    public class BNotificationBubble
    {
        private string message;
        private Control form;
        private Control notificationControl;
        private NotificationForm notificationForm;

        public BNotificationBubble(string message, Control form, Control notificationControl)
        {
            this.message = message;
            this.form = form;
            this.notificationControl = notificationControl;
        }

        public void Show()
        {
            notificationForm = new NotificationForm(message, form, notificationControl);
            notificationForm.ShowDialog();
        }

        public void Close()
        {
            notificationForm.Close();
        }
    }
}
