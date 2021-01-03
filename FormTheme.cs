using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using ThemeGenerator.Classes;

namespace ThemeGenerator
{
    public partial class FormTheme : Form
    {
        public bool Autoch;

        public FormTheme()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private void FormTheme_Load(object sender, EventArgs e)
        {
            // tbUrl.ReadOnly = true;
            chbAutoChange.Checked = true;
            chbInsLinksCJSCode.Checked = false;
            chbShowSourceCode.Checked = false;
            chbActivateWebServer.Checked = true;

            if (chbShowSourceCode.Checked == false)
            {
                tbCode.Visible = false;
                tbCode.ReadOnly = true;
                tableLayoutPanel1.SetColumn(webView, 0);
                tableLayoutPanel1.SetColumnSpan(webView, 2);
            }
            else
            {
                tbCode.Visible = true;
                tbCode.ReadOnly = false;
                tableLayoutPanel1.SetColumn(webView, 1);
                tableLayoutPanel1.SetColumnSpan(webView, 1);
            }

            AddListFrameworks();
            CheckRenderWebButton();
            LoadContent();
        }

        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => console.log(event.data));");
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            
            if(!tbUrl.Text.StartsWith("file"))
            {
                tbUrl.Text = uri;
                LoadContent();
            }

            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

        private void cbFrameworks_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Frameworks> frms = Frameworks.GenDataFrameworks();
            var frms_item = frms[cbFrameworks.SelectedIndex];

            lbCSSLinks.Items.Clear();
            lbJSLinks.Items.Clear();

            if (cbFrameworks.Items.Count > 0)
            {
                if (lbCSSLinks.Items.Count == 0)
                {
                    for (var xlc = 0; xlc < frms_item.CSSUrl.Count; xlc++)
                    {
                        lbCSSLinks.Items.Add(frms_item.CSSUrl[xlc]);
                    }
                }
                
                if (lbJSLinks.Items.Count == 0)
                {
                    for (var xlj = 0; xlj < frms_item.JSUrl.Count; xlj++)
                    {
                        lbJSLinks.Items.Add(frms_item.JSUrl[xlj]);
                    }
                }
            }

            LoadContent();
        }

        private void btnRenderToWebBrowser_Click(object sender, EventArgs e)
        {
            if(webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.NavigateToString(tbCode.Text);
            }
        }

        private void FormTheme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        async Task PausaComTaskDelay()
        {
            await Task.Delay(500);
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            if(Autoch == true)
            {
                if(tbCode.Text.Length > 0 && tbUrl.Text.StartsWith("file:///"))
                {
                    if (webView != null && webView.CoreWebView2 != null)
                    {
                        webView.CoreWebView2.NavigateToString(tbCode.Text);
                    }
                }
            }
        }

        private void btnSaveTemp_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "";

                url = tbUrl.Text.Replace("file:///", "");
                url = url.Replace("http://", "");
                url = url.Replace("https://", "");
                url = url.Replace("ftp://", "");

                if (tbUrl.Text.StartsWith("file:///"))
                {
                    WriteContent(url);
                } 
                else
                {
                    WriteWebContent(url);
                }

                MessageBox.Show("Save sucessfully content in file " + url);
            }
            catch (Exception ex)
            {
                tbCode.Text = " ";
                MessageBox.Show(ex.Message);
            }
        }

        private void chbAutoChange_CheckedChanged(object sender, EventArgs e)
        {
            if(chbAutoChange.Checked == true)
            {
                Autoch = true;
            }
            else
            {
                Autoch = false;
            }

            CheckRenderWebButton();
        }

        void AddListFrameworks()
        {
            if (cbFrameworks.Items.Count == 0)
            {
                List<Frameworks> frms = Frameworks.GenDataFrameworks();

                for (var x = 0; x < frms.Count; x++)
                {
                    cbFrameworks.Items.Add(frms[x].Title);
                }

                if (cbFrameworks.Items.Count > 0)
                {
                    cbFrameworks.SelectedIndex = 0;

                    if (lbCSSLinks.Items.Count == 0)
                    {
                        for (var xlc = 0; xlc < frms[cbFrameworks.SelectedIndex].CSSUrl.Count; xlc++)
                        {
                            lbCSSLinks.Items.Add(frms[cbFrameworks.SelectedIndex].CSSUrl[xlc]);
                        }
                    }

                    if (lbJSLinks.Items.Count == 0)
                    {
                        for (var xlj = 0; xlj < frms[cbFrameworks.SelectedIndex].JSUrl.Count; xlj++)
                        {
                            lbJSLinks.Items.Add(frms[cbFrameworks.SelectedIndex].JSUrl[xlj]);
                        }
                    }
                }
            }
        }

        void CheckRenderWebButton()
        {
            if (Autoch == true)
            {
                btnRenderToWebBrowser.Enabled = false;
                btnRenderToWebBrowser.Visible = false;
                btnSaveTemp.Location = new Point(604, 34);
                btnSaveTemp.Size = new Size(467, 41);
                tableLayoutPanel3.SetColumnSpan(btnSaveTemp, 2);
            }
            else
            {
                btnRenderToWebBrowser.Enabled = true;
                btnRenderToWebBrowser.Visible = true;
                btnSaveTemp.Location = new Point(604, 34);
                btnSaveTemp.Size = new Size(226, 41);
                tableLayoutPanel3.SetColumnSpan(btnSaveTemp, 1);
            }
        }

        void SetContentCSSandJS(bool action = false)
        {
            var csscontent = "";
            var jscontent = "";

            if (lbCSSLinks.Items.Count > 0)
            {
                for (var xcss = 0; xcss < lbCSSLinks.Items.Count; xcss++)
                {
                    csscontent += "<link rel='stylesheet' href='" + lbCSSLinks.Items[xcss] + "'>";
                }

                if(action == true)
                {
                    tbCode.Text = tbCode.Text.Replace("</head>", csscontent + "</head>");
                }
                else
                {
                    tbCode.Text = tbCode.Text.Replace(csscontent + "</head>", "</head>");
                }
            }

            if (lbJSLinks.Items.Count > 0)
            {
                for (var xjs = 0; xjs < lbJSLinks.Items.Count; xjs++)
                {
                    jscontent += "<script src='" + lbJSLinks.Items[xjs] + "'></script>";
                }

                if (action == true)
                {
                    tbCode.Text = tbCode.Text.Replace("</body>", jscontent + "</body>");
                }
                else
                {
                    tbCode.Text = tbCode.Text.Replace(jscontent + "</body>", "</body>");
                }
            }
        }

        void ReadContent(string pth)
        {
            pth = pth.Replace(@"file:///", "");
            using (StreamReader reader = new StreamReader(pth))
            {
                tbCode.Text = reader.ReadToEnd();
            }

            SetContentCSSandJS(chbInsLinksCJSCode.Checked);
        }

        void WriteContent(string pth)
        {
            pth = pth.Replace(@"file:///", "");
            using (StreamWriter writer = new StreamWriter(pth))
            {
                writer.Write(tbCode.Text);
            }
        }

        async void ReadWebContent(string url)
        {
            await PausaComTaskDelay();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = await content.ReadAsStringAsync();
                        tbCode.Text = result;
                    }
                }
            }
        }

        async void WriteWebContent(string url)
        {
            await PausaComTaskDelay();

            using (WebClient client = new WebClient())
            {
                client.Proxy = null;
                string htmlCode = client.DownloadString(url);
                string projdir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) + @"\assets\pages\"+url;
                File.WriteAllText(projdir, htmlCode);
            }
        }

        void LoadContent()
        {
            if(tbUrl.Text == "")
            {
                tbUrl.Text = "file:///" + Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) + @"\assets\pages\mytemplate.html";
            }

            try
            {
                if (tbUrl.Text.StartsWith("file"))
                {
                    tbCode.ReadOnly = false;
                    ReadContent(tbUrl.Text);
                }
                else
                {
                    tbCode.ReadOnly = true;
                    ReadWebContent(tbUrl.Text);
                    webView.Source = new Uri(tbUrl.Text);
                }
            }
            catch (Exception ex)
            {
                tbCode.Text = "" + ex.Message;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void FormTheme_Resize(object sender, EventArgs e)
        {
            ResizeGBOpts();
        }

        void ResizeGBOpts()
        {
            if (gbOptions.Visible == false)
            {
                //webView.Size = this.ClientSize - new Size(webView.Location);
                //btnGo.Left = this.ClientSize.Width - btnGo.Width;
                //tbUrl.Width = btnGo.Left - tbUrl.Left;
                tableLayoutPanel1.SetRowSpan(tbCode, 2);
                tableLayoutPanel1.SetRowSpan(webView, 2);
            }
            else
            {
                tableLayoutPanel1.SetRowSpan(tbCode, 1);
                tableLayoutPanel1.SetRowSpan(webView, 1);
            }
        }

        private void chbInsLinksCJSCode_CheckedChanged(object sender, EventArgs e)
        {
            SetContentCSSandJS(chbInsLinksCJSCode.Checked);
        }

        private void btnAddCSSLink_Click(object sender, EventArgs e)
        {
            if(!lbCSSLinks.Items.Contains(tbAddCSSLink.Text))
            {
                lbCSSLinks.Items.Add(tbAddCSSLink.Text);
                lbCSSLinks.ClearSelected();
                tbAddCSSLink.Text = "";
            }
            else
            {
                MessageBox.Show($"Already added link {tbAddCSSLink.Text} to CSS box");
            }
        }

        private void btnAddJSLink_Click(object sender, EventArgs e)
        {
            if(!lbJSLinks.Items.Contains(tbAddJSLink.Text))
            {
                lbJSLinks.Items.Add(tbAddJSLink.Text);
                lbJSLinks.ClearSelected();
                tbAddJSLink.Text = "";
            }
            else
            {
                MessageBox.Show($"Already added link {tbAddJSLink.Text} to JS box");
            }
        }

        private void btnTempDemo1_Click(object sender, EventArgs e)
        {
            string filedir = @"assets\pages\bootstrap\blog\index.html";
            string projdir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));

            if(chbActivateWebServer.Checked == true)
            {
                filedir = filedir.ToString().Replace(Path.DirectorySeparatorChar, '/');
                tbUrl.Text = @"https://localhost:5001/" + filedir;
            }
            else
            {
                tbUrl.Text = @"file:///" + projdir + @"\" + filedir;
            }

            LoadContent();
        }

        private void btnDefTemp_Click(object sender, EventArgs e)
        {
            string filedir = @"assets\pages\mytemplate.html";
            string projdir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));

            if (chbActivateWebServer.Checked == true)
            {
                filedir = filedir.ToString().Replace(Path.DirectorySeparatorChar, '/');
                tbUrl.Text = @"https://localhost:5001/" + filedir;
            }
            else
            {
                tbUrl.Text = @"file:///" + projdir + @"\" + filedir;
            }

            LoadContent();
        }

        private void btnTempDemo2_Click(object sender, EventArgs e)
        {
            string filedir = @"assets\pages\mdl\index.html";
            string projdir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));

            if (chbActivateWebServer.Checked == true)
            {
                filedir = filedir.ToString().Replace(Path.DirectorySeparatorChar, '/');
                tbUrl.Text = @"https://localhost:5001/" + filedir;
            }
            else
            {
                tbUrl.Text = @"file:///" + projdir + @"\" + filedir;
            }

            LoadContent();
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            var browsername = "chrome.exe";
            try
            {
                DialogResult ask_open_browser = MessageBox.Show("Do you want open page in your favourite browser?", "Opening page in browser", MessageBoxButtons.YesNo);

                if(ask_open_browser == DialogResult.Yes)
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.FileName = GetPathForExe(browsername);
                    //myProcess.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                    myProcess.StartInfo.Arguments = '"' + tbUrl.Text + '"' + " --new-window";
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to find your browser {browsername} installed.. \r\n Details: {ex.Message}", "Browser not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private const string keyBase = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths";
        private string GetPathForExe(string fileName)
        {
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey fileKey = localMachine.OpenSubKey(string.Format(@"{0}\{1}", keyBase, fileName));
            object result = null;
            if (fileKey != null)
            {
                result = fileKey.GetValue(string.Empty);
                fileKey.Close();
            }


            return (string)result;
        }

        private void lbCSSLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCSSLinks.SelectedIndex != -1)
            {
                tbAddCSSLink.Text = lbCSSLinks.Items[lbCSSLinks.SelectedIndex].ToString();
            }
        }

        private void lbJSLinks_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (lbJSLinks.SelectedIndex != -1)
           {
                tbAddJSLink.Text = lbJSLinks.Items[lbJSLinks.SelectedIndex].ToString();
           }
        }

        private void tbAddCSSLink_TextChanged(object sender, EventArgs e)
        {
            var ind = lbCSSLinks.SelectedIndex;
            
            if(ind != -1)
            {
                if (tbAddCSSLink.Text == "" || tbAddCSSLink.Text != lbCSSLinks.Items[ind].ToString())
                {
                    lbCSSLinks.ClearSelected();
                }
                else
                {
                    lbCSSLinks.SetSelected(lbCSSLinks.FindString(tbAddCSSLink.Text), true);
                }
            }
        }

        private void tbAddJSLink_TextChanged(object sender, EventArgs e)
        {
            var ind = lbJSLinks.SelectedIndex;
            
            if(ind != -1)
            {
                if (tbAddJSLink.Text == "" || tbAddJSLink.Text != lbJSLinks.Items[ind].ToString())
                {
                    lbJSLinks.ClearSelected();
                }
                else
                {
                    lbJSLinks.SetSelected(lbJSLinks.FindString(tbAddJSLink.Text), true);
                }
            }
        }

        private void chbShowSourceCode_CheckedChanged(object sender, EventArgs e)
        {
            if(chbShowSourceCode.Checked == false)
            {
                tbCode.Visible = false;
                tbCode.ReadOnly = true;
                tableLayoutPanel1.SetColumn(webView, 0);
                tableLayoutPanel1.SetColumnSpan(webView, 2);
            }
            else
            {
                tbCode.Visible = true;
                tbCode.ReadOnly = false;
                tableLayoutPanel1.SetColumn(webView, 1);
                tableLayoutPanel1.SetColumnSpan(webView, 1);
            }
        }

        private void chbActivateWebServer_CheckedChanged(object sender, EventArgs e)
        {
            var pathproj = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            Process[] processes = Process.GetProcessesByName("dotnet");

            if (chbActivateWebServer.Checked == true)
            {
                tbUrl.Text = "https://localhost:5001/assets/pages";

                if (processes.Length == 0)
                {
                    try
                    {
                        Process myprocess = new Process();
                        myprocess.StartInfo.FileName = "cmd.exe";
                        myprocess.StartInfo.UseShellExecute = true;
                        myprocess.StartInfo.CreateNoWindow = false;
                        myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                        myprocess.StartInfo.Arguments = @"/C cd C:\\Users\\Luis\\Documents\\Visual Studio 2019\\Projects\\ThemeGenerator\\ThemeGenLibrary && start dotnet run ThemeGenLibrary";
                        myprocess.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                tbUrl.Text = "file:///" + pathproj + @"\assets\pages\mytemplate.html";

                if (processes.Length >= 1)
                {
                    processes[0].Kill();
                }
            }

            LoadContent();
        }

        private void btnBackNavigation_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoBack();
                tbUrl.Text = webView.CoreWebView2.Source.ToString();
            }
        }

        private void btnForwardNavigation_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.GoForward();
                tbUrl.Text = webView.CoreWebView2.Source.ToString();
            }
        }

        private void btnRefNavigation_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.Source = new Uri(tbUrl.Text);
                webView.CoreWebView2.Reload();
            }
        }
    }
}
