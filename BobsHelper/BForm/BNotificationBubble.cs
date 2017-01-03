using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BobsHelper.BForm
{
    public class BNotificationBubble
    {
        public void Show()
        {
            NotificationForm form = new NotificationForm();
            form.ShowDialog();
        }
    }
}
