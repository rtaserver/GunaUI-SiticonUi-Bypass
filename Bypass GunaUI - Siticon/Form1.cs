using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bypass_GunaUI___Siticon
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        bool enabled;
        public enum LogType
        {
            Message,
            Warning,
            Error
        }

        public void LogMessage(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Message:
                    Log.Text = ($"Status -> {message}");
                    break;
                case LogType.Warning:
                    Log.Text = ($"Warning -> {message}");
                    break;
                case LogType.Error:
                    Log.Text = ($"Error -> {message}");
                    break;
            }
        }

        void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        public void Toggle()
        {
            enabled = !enabled;
            if (enabled)
            {
                LogMessage(LogType.Message, "Detection Started!");
                DetectWindow();
            }
            else
            {
                LogMessage(LogType.Message, "Detection Stopped!");
            }
        }

        private void DetectWindow()
        {
            new Thread(() =>
            {
                while (enabled)
                {
                    foreach (var proccess in Process.GetProcesses())
                    {
                        if (proccess.MainWindowTitle.ToLower().Contains("guna ui") && proccess.ProcessName.Contains("devenv") || proccess.ProcessName.Contains("rider64"))
                        {
                            HideWindow(proccess.MainWindowHandle, false);
                            LogMessage(LogType.Message, "Patched Guna UI");
                        }

                        if (proccess.MainWindowTitle.ToLower().Contains("siticone") && proccess.ProcessName.Contains("devenv") || proccess.ProcessName.Contains("rider64"))
                        {
                            HideWindow(proccess.MainWindowHandle, false);
                            LogMessage(LogType.Message, "Patched Siticone");
                        }
                    }
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        public void HideWindow(IntPtr windowHandle, bool show)
        {
            if (show) ShowWindow(windowHandle, 5); else ShowWindow(windowHandle, 0);
        }

        private void EventHandler(object sender, EventArgs eventArgs)
        {
            var control = sender as Control;
            switch (control.Name)
            {
                case "logTextBox":
                    ActiveControl = null;
                    break;
                case "startButton":
                    Toggle();
                    if (enabled)
                    {
                        startButton.Text = "Stop Bypass";
                    }
                    else
                    {
                        startButton.Text = "Start Bypass";
                    }
                    break;
                case "hideButton":
                    Hide();
                    mainNotifyIcon.Visible = true;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            startButton.Click += EventHandler;
            hideButton.Click += EventHandler;

            mainNotifyIcon.DoubleClick += MainNotifyIcon_MouseDoubleClick; ;
        }

        private void MainNotifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            Show();
            mainNotifyIcon.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogMessage(LogType.Message, "Bypass Ready Now !");
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                Toggle();
                Application.Exit();
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://t.me/rtacode_team",
                UseShellExecute = true
            });
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://saweria.co/rizkikotet",
                UseShellExecute = true
            });
        }
    }
}
