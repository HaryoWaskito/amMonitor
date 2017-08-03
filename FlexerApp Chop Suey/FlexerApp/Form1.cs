using FlexerApp.Controllers;
using FlexerApp.Models;
using System;
using System.Windows.Forms;
using System.Device.Location;
using System.Net;
using System.Xml;

namespace FlexerApp
{
    public partial class FlexerApp : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FlexerApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public FlexerApp()
        {
            InitializeComponent();
        }

        private void LoginControl_Click(object sender, EventArgs e)
        {
            var controller = new Controller();
            var logger = new Logger();
            var login = new LoginModel();
            //var xmlDoc = new XmlDocument();
            //var _geoCoordinateService = new System.Device.Location.GeoCoordinate();
            GeoCoordinate _geoCoordinateService = null;

            if (EmailControl.Text == "haryoganteng")
            {
                login.Email = "karjo@gmail.com";// EmailControl.Text;
                login.Password = "tes123";//PasswordControl.Text; // Masa gara- gara isi password-nya test123 (ada "t"-nya returnnya syntax error)                
            }
            
            var ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            //xmlDoc.Load(string.Concat("http://www.freegeoip.net/xml/", ipAddress));

            login.LocationType = _geoCoordinateService != null ? "GPS" : "IP";
            login.IPAddress = ipAddress;
            login.City = string.Empty;// xmlDoc.GetElementsByTagName("City")[0].InnerText;
            login.Lat = _geoCoordinateService != null ? float.Parse(_geoCoordinateService.Latitude.ToString()) : float.Parse("0.0");
            login.Long = _geoCoordinateService != null ? float.Parse(_geoCoordinateService.Longitude.ToString()) : float.Parse("0.0");

            if (controller.LoginToServer(login))
            {
                SetAppToSytemTray();
                logger.BeginWatching();
            }
        }

        private void ExitControl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAppToSytemTray()
        {
            var contextMenu = new ContextMenu();
            var menuItemLogout = new MenuItem();
            var menuItemExit = new MenuItem();

            contextMenu.MenuItems.AddRange(new MenuItem[] { menuItemLogout, menuItemExit });
            menuItemLogout.Index = 0;
            menuItemLogout.Text = "Logout";
            menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);

            menuItemExit.Index = 1;
            menuItemExit.Text = "Exit";
            menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);

            notifyIconControl.Visible = true;
            notifyIconControl.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconControl.BalloonTipText = "All set! ready to go!";
            notifyIconControl.BalloonTipTitle = "FlexerApp";
            notifyIconControl.ContextMenu = contextMenu;
            notifyIconControl.ShowBalloonTip(500);
            this.Hide();
        }

        private void menuItemLogout_Click(object sender, EventArgs e)
        {
            notifyIconControl.Visible = false;
            this.Show();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
