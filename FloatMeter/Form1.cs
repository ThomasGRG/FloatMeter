using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace FloatMeter
{
    public partial class Form1 : Form
    {
        bool shrink = false;
        bool menuOpen = false;
        bool mouseDown;
        Point lastLocation;

        // Selected network interface index
        int selIndex = 0;

        // Update interval
        int interval = 1000;

        long BytesSent = 0;
        long BytesReceived = 0;

        long uBytesSent;
        long uBytesReceived;
        long sentSpeed;
        long receiveSpeed;

        NetworkInterface[] nicArr;
        NetworkInterface nic;
        List<int> goodAdapters = new List<int>();

        // Current speed
        double upSpeed = 0;
        double downSpeed = 0;
        double dataSent = 0;
        double dataReceived = 0;

        // Current speed units
        string upUnit;
        string downUnit;
        string sentUnit;
        string receiveUnit;

        public Form1()
        {
            InitializeComponent();
            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
        }

        // Hide from Alt+Tab / Win+Tab switchers
        protected override CreateParams CreateParams
        {
            get
            {
                var Params = base.CreateParams;
                Params.ExStyle |= 0x80;

                return Params;
            }
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }

        public void ShowWindow()
        {
            winAPI.ShowToFront(this.Handle);
        }

        private void InitNetworkInterface()
        {
            goodAdapters.Clear();
            nicArr = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < nicArr.Length; i++)
            {
                if (nicArr[i].SupportsMulticast && nicArr[i].GetIPv4Statistics().UnicastPacketsReceived >= 1 && nicArr[i].OperationalStatus.ToString() == "Up")
                {
                    goodAdapters.Add(i);
                }
            }
        }

        private void InitNetworkMenu()
        {
            if (goodAdapters.Count != netComboBox.Items.Count && goodAdapters.Count != 0)
            {
                netComboBox.Items.Clear();
                foreach (int gadpt in goodAdapters)
                {
                    netComboBox.Items.Add(nicArr[gadpt].Name);
                }
                selIndex = goodAdapters[0];
                netComboBox.SelectedIndex = 0;
            }
            if (goodAdapters.Count == 0)
            {
                netComboBox.Items.Clear();
            }
        }

        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            if (e.IsAvailable)
            {
                InitNetworkInterface();
                if (goodAdapters.Count > 0)
                {
                    selIndex = goodAdapters[0];
                    nic = nicArr[selIndex];
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoShrink)
            {
                shrink = true;
                Size = new Size(622, 1);
            }
            Location = Properties.Settings.Default.Position;
            if (Properties.Settings.Default.TopMost)
            {
                TopMost = true;
                topmostMenu.Checked = true;
            }
            InitNetworkInterface();
            if (goodAdapters.Count > 0)
            {
                selIndex = goodAdapters[0];
                nic = nicArr[selIndex];
                backgroundWorker1.RunWorkerAsync();
            }
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk.GetValue("FloatMeter") != null)
            {
                bootMenu.Checked = true;
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (shrink)
            {
                Size = new Size(622, 34);
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (!menuOpen && shrink)
            {
                Size = new Size(622, 1);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bool err = false;
            while (!backgroundWorker1.CancellationPending)
            {
                try
                {
                    IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();
                    err = false;
                    uBytesSent = interfaceStats.BytesSent;
                    uBytesReceived = interfaceStats.BytesReceived;
                    sentSpeed = uBytesSent - BytesSent;
                    receiveSpeed = uBytesReceived - BytesReceived;

                    BytesSent = uBytesSent;
                    BytesReceived = uBytesReceived;

                    // Upload Speed
                    if (sentSpeed > 1024 && sentSpeed < 1048576)
                    {
                        upSpeed = sentSpeed / 1024.0;
                        upUnit = " KB/s";
                    }
                    else if (sentSpeed > 1048576)
                    {
                        upSpeed = sentSpeed / 1048576.0;
                        upUnit = " MB/s";
                    }
                    else
                    {
                        upSpeed = sentSpeed;
                        upUnit = " B/s";
                    }

                    // Download Speed
                    if (receiveSpeed > 1024 && receiveSpeed < 1048576)
                    {
                        downSpeed = receiveSpeed / 1024.0;
                        downUnit = " KB/s";
                    }
                    else if (receiveSpeed > 1048576)
                    {
                        downSpeed = receiveSpeed / 1048576.0;
                        downUnit = " MB/s";
                    }
                    else
                    {
                        downSpeed = receiveSpeed;
                        downUnit = " B/s";
                    }

                    // Session Upload
                    if (uBytesSent > 1024 && uBytesSent < 1048576)
                    {
                        dataSent = uBytesSent / 1024.0;
                        sentUnit = " KB";
                    }
                    else if (uBytesSent > 1048576 && uBytesSent < 1073741824)
                    {
                        dataSent = uBytesSent / 1048576.0;
                        sentUnit = " MB";
                    }
                    else if (uBytesSent > 1073741824)
                    {
                        dataSent = uBytesSent / 1073741824.0;
                        sentUnit = " GB";
                    }
                    else
                    {
                        dataSent = uBytesSent;
                        sentUnit = " B";
                    }

                    // Session Download
                    if (uBytesReceived > 1024 && uBytesReceived < 1048576)
                    {
                        dataReceived = uBytesReceived / 1024.0;
                        receiveUnit = " KB";
                    }
                    else if (uBytesReceived > 1048576 && uBytesReceived < 1073741824)
                    {
                        dataReceived = uBytesReceived / 1048576.0;
                        receiveUnit = " MB";
                    }
                    else if (uBytesReceived > 1073741824)
                    {
                        dataReceived = uBytesReceived / 1073741824.0;
                        receiveUnit = " GB";
                    }
                    else
                    {
                        dataReceived = uBytesReceived;
                        receiveUnit = " B";
                    }

                    backgroundWorker1.ReportProgress(1);
                }
                catch (Exception)
                {
                    if (!err)
                    {
                        err = true;
                    }
                }

                System.Threading.Thread.Sleep(interval);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            upSpeedLabel.Text = upSpeed.ToString("0.00") + " " + upUnit;
            downSpeedLabel.Text = downSpeed.ToString("0.00") + " " + downUnit;
            uploadLabel.Text = dataSent.ToString("0.00") + " " + sentUnit;
            downloadLabel.Text = dataReceived.ToString("0.00") + " " + receiveUnit;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, 0);
                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseDown = false;
                Properties.Settings.Default.Position = Location;
                Properties.Settings.Default.Save();
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tlPos_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
            Properties.Settings.Default.Position = Location;
            Properties.Settings.Default.Save();
        }

        private void tcPos_Click(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width/2) - (622/2), 0);
            Properties.Settings.Default.Position = Location;
            Properties.Settings.Default.Save();
        }

        private void trPos_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 622, 0);
            Properties.Settings.Default.Position = Location;
            Properties.Settings.Default.Save();
        }

        private void topmostMenu_Click(object sender, EventArgs e)
        {
            if (topmostMenu.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
            Properties.Settings.Default.TopMost = TopMost;
            Properties.Settings.Default.Save();
        }

        private void bootMenu_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (bootMenu.Checked)
            {
                rk.SetValue("FloatMeter", Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue("FloatMeter", false);
            }
        }

        private void netComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selIndex = goodAdapters[netComboBox.SelectedIndex];
            nic = nicArr[selIndex];
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menuOpen = true;
            InitNetworkMenu();
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            menuOpen = false;
            if (!this.ClientRectangle.Contains(PointToClient(Cursor.Position)))
            {
                Size = new Size(622, 1);
            }
        }

        private void shrinkMenu_Click(object sender, EventArgs e)
        {
            if (shrinkMenu.Checked)
            {
                shrink = true;
                Properties.Settings.Default.AutoShrink = true;
            }
            else
            {
                shrink = false;
                Properties.Settings.Default.AutoShrink = false;
            }
            Properties.Settings.Default.Save();
        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
            {
                e.Cancel = true;
            }
        }
    }
}
