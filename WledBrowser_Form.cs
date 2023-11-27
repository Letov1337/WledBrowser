using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace brows_esp
{
    public partial class WledBrowser : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        string path_setting = string.Format("{0}\\{1}", Application.StartupPath, "setting.txt");
        string url_wled;
        const string NameProgramm = "WledBrowser";
        bool systemShutdown = false;
        public static func_wled func = new func_wled();

        public WledBrowser()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }
        public void InitializeChromium(string site)
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser(site);
            chromeBrowser.RequestContext = new RequestContext();
            this.panelBrowser.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }
        private async void WledBrowser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
            this.ShowInTaskbar = false;

            url_wled = await func.ReadSettingAsync(path_setting); 
            InitializeChromium($"http://{url_wled}:80/");

            bool isLedStripOn = await func.CheckLedStripStatusAsync(url_wled, 80);
            if(isLedStripOn == false)
            {
                await func.TurnOnLedStripAsync(url_wled, 80, true);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void WledBrowser_Resize(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Minimized:
                    this.Hide();
                    break;
                case FormWindowState.Normal:
                    this.ShowInTaskbar = true;
                    panelBrowser.Size = ClientSize;
                    break;
                case FormWindowState.Maximized:
                    panelBrowser.Size = ClientSize;
                    break;
            }
        }

        private async void WledBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isLedStripOn = false;
            if (systemShutdown)
            {
                systemShutdown = false;
                Task.Run(async () =>
                {
                    isLedStripOn = await func.CheckLedStripStatusAsync(url_wled, 80);
                }).Wait();
                if (isLedStripOn == true)
                {
                    await func.TurnOnLedStripAsync(url_wled, 80, false);
                }
            }
        }

        private async void WledBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool isLedStripOn = false;
            Task.Run(async () =>{isLedStripOn = await func.CheckLedStripStatusAsync(url_wled, 80);}).Wait();
            if (isLedStripOn == true)
            {
                await func.TurnOnLedStripAsync(url_wled, 80, false);
            }
        }

        private async void BacklightOnOff_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isLedStripOn = await func.CheckLedStripStatusAsync(url_wled, 80);
            switch(isLedStripOn)
            {
                case true:
                    await func.TurnOnLedStripAsync(url_wled, 80, false);
                    break;
                case false:
                    await func.TurnOnLedStripAsync(url_wled, 80, true);
                    break;
            }
        }

        private void CloseApplication_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutorunOn_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func.SetAutorunValue(true, NameProgramm);
        }

        private void AutorunOff_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            func.SetAutorunValue(false, NameProgramm);
        }
        private async void Brightness10_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            await func.BrightnessAdjustment(url_wled, 80, "40");
        }

        private async void Brightness50_toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            await func.BrightnessAdjustment(url_wled, 80,"128");
        }

        private async void Brightness100_toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            await func.BrightnessAdjustment(url_wled, 80, "255");
        }
    }
}
