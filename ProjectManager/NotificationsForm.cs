using ProjectManagement.ClassFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class NotificationsForm : Form
    {

        static Notifications notifications = new Notifications();
        static int notificationID;
        public NotificationsForm()
        {
            InitializeComponent();
        }

        public static void SetNotification(string msg, int u_id)
        {

            notifications.Message = msg;
            notifications.UserID = u_id;
            notifications.SetNewNotification();
        }
        public static void SetNotificationID(int id)
        {
            notificationID = id;
        }
        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            notificationsView.DataSource = null;
            if (notifications.GetNotifications(notificationID) != null)
            {
                notificationsView.DataSource = notifications.GetNotifications(notificationID);
                notificationsView.ClearSelection();
            }

        }
    }
}
