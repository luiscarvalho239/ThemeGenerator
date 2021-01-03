
namespace ThemeGenerator
{
    partial class FormTheme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurFramework = new System.Windows.Forms.Label();
            this.cbFrameworks = new System.Windows.Forms.ComboBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddJSLink = new System.Windows.Forms.Button();
            this.tbAddJSLink = new System.Windows.Forms.TextBox();
            this.btnRenderToWebBrowser = new System.Windows.Forms.Button();
            this.btnSaveTemp = new System.Windows.Forms.Button();
            this.lbCSSLinks = new System.Windows.Forms.ListBox();
            this.lbJSLinks = new System.Windows.Forms.ListBox();
            this.lblCSS = new System.Windows.Forms.Label();
            this.lblJS = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbActivateWebServer = new System.Windows.Forms.CheckBox();
            this.chbShowSourceCode = new System.Windows.Forms.CheckBox();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTempDemo2 = new System.Windows.Forms.Button();
            this.btnDefTemp = new System.Windows.Forms.Button();
            this.btnTempDemo1 = new System.Windows.Forms.Button();
            this.chbInsLinksCJSCode = new System.Windows.Forms.CheckBox();
            this.chbAutoChange = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tbAddCSSLink = new System.Windows.Forms.TextBox();
            this.btnAddCSSLink = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGo = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefNavigation = new System.Windows.Forms.Button();
            this.btnForwardNavigation = new System.Windows.Forms.Button();
            this.btnBackNavigation = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tbCode = new System.Windows.Forms.RichTextBox();
            this.gbOptions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurFramework
            // 
            this.lblCurFramework.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurFramework.AutoSize = true;
            this.lblCurFramework.Location = new System.Drawing.Point(3, 8);
            this.lblCurFramework.Name = "lblCurFramework";
            this.lblCurFramework.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurFramework.Size = new System.Drawing.Size(100, 13);
            this.lblCurFramework.TabIndex = 2;
            this.lblCurFramework.Text = "Current Framework:";
            // 
            // cbFrameworks
            // 
            this.cbFrameworks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFrameworks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrameworks.FormattingEnabled = true;
            this.cbFrameworks.Location = new System.Drawing.Point(109, 4);
            this.cbFrameworks.Name = "cbFrameworks";
            this.cbFrameworks.Size = new System.Drawing.Size(420, 21);
            this.cbFrameworks.TabIndex = 3;
            this.cbFrameworks.SelectedIndexChanged += new System.EventHandler(this.cbFrameworks_SelectedIndexChanged);
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gbOptions, 2);
            this.gbOptions.Controls.Add(this.tableLayoutPanel3);
            this.gbOptions.Location = new System.Drawing.Point(3, 424);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(1090, 281);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnRenderToWebBrowser, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveTemp, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbCSSLinks, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbJSLinks, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCSS, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblJS, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.69388F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.387755F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1078, 245);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btnAddJSLink, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbAddJSLink, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(272, 202);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(263, 40);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // btnAddJSLink
            // 
            this.btnAddJSLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJSLink.Location = new System.Drawing.Point(213, 3);
            this.btnAddJSLink.Name = "btnAddJSLink";
            this.btnAddJSLink.Size = new System.Drawing.Size(47, 34);
            this.btnAddJSLink.TabIndex = 2;
            this.btnAddJSLink.Text = "Add";
            this.btnAddJSLink.UseVisualStyleBackColor = true;
            this.btnAddJSLink.Click += new System.EventHandler(this.btnAddJSLink_Click);
            // 
            // tbAddJSLink
            // 
            this.tbAddJSLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddJSLink.Location = new System.Drawing.Point(3, 10);
            this.tbAddJSLink.Name = "tbAddJSLink";
            this.tbAddJSLink.Size = new System.Drawing.Size(204, 20);
            this.tbAddJSLink.TabIndex = 1;
            this.tbAddJSLink.TextChanged += new System.EventHandler(this.tbAddJSLink_TextChanged);
            // 
            // btnRenderToWebBrowser
            // 
            this.btnRenderToWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenderToWebBrowser.Location = new System.Drawing.Point(810, 3);
            this.btnRenderToWebBrowser.Name = "btnRenderToWebBrowser";
            this.btnRenderToWebBrowser.Size = new System.Drawing.Size(265, 30);
            this.btnRenderToWebBrowser.TabIndex = 5;
            this.btnRenderToWebBrowser.Text = "Preview";
            this.btnRenderToWebBrowser.UseVisualStyleBackColor = true;
            this.btnRenderToWebBrowser.Click += new System.EventHandler(this.btnRenderToWebBrowser_Click);
            // 
            // btnSaveTemp
            // 
            this.btnSaveTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTemp.Location = new System.Drawing.Point(541, 3);
            this.btnSaveTemp.Name = "btnSaveTemp";
            this.btnSaveTemp.Size = new System.Drawing.Size(263, 30);
            this.btnSaveTemp.TabIndex = 6;
            this.btnSaveTemp.Text = "Save";
            this.btnSaveTemp.UseVisualStyleBackColor = true;
            this.btnSaveTemp.Click += new System.EventHandler(this.btnSaveTemp_Click);
            // 
            // lbCSSLinks
            // 
            this.lbCSSLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCSSLinks.FormattingEnabled = true;
            this.lbCSSLinks.HorizontalScrollbar = true;
            this.lbCSSLinks.Location = new System.Drawing.Point(3, 62);
            this.lbCSSLinks.Name = "lbCSSLinks";
            this.lbCSSLinks.ScrollAlwaysVisible = true;
            this.lbCSSLinks.Size = new System.Drawing.Size(263, 134);
            this.lbCSSLinks.TabIndex = 9;
            this.lbCSSLinks.SelectedIndexChanged += new System.EventHandler(this.lbCSSLinks_SelectedIndexChanged);
            // 
            // lbJSLinks
            // 
            this.lbJSLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJSLinks.FormattingEnabled = true;
            this.lbJSLinks.HorizontalScrollbar = true;
            this.lbJSLinks.Location = new System.Drawing.Point(272, 62);
            this.lbJSLinks.Name = "lbJSLinks";
            this.lbJSLinks.ScrollAlwaysVisible = true;
            this.lbJSLinks.Size = new System.Drawing.Size(263, 134);
            this.lbJSLinks.TabIndex = 11;
            this.lbJSLinks.SelectedIndexChanged += new System.EventHandler(this.lbJSLinks_SelectedIndexChanged);
            // 
            // lblCSS
            // 
            this.lblCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCSS.AutoSize = true;
            this.lblCSS.Location = new System.Drawing.Point(3, 41);
            this.lblCSS.Name = "lblCSS";
            this.lblCSS.Size = new System.Drawing.Size(263, 13);
            this.lblCSS.TabIndex = 8;
            this.lblCSS.Text = "CSS";
            this.lblCSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJS
            // 
            this.lblJS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJS.AutoSize = true;
            this.lblJS.Location = new System.Drawing.Point(272, 41);
            this.lblJS.Name = "lblJS";
            this.lblJS.Size = new System.Drawing.Size(263, 13);
            this.lblJS.TabIndex = 10;
            this.lblJS.Text = "JS";
            this.lblJS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Controls.Add(this.lblCurFramework, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbFrameworks, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(532, 30);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.chbActivateWebServer);
            this.panel1.Controls.Add(this.chbShowSourceCode);
            this.panel1.Controls.Add(this.btnOpenBrowser);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chbInsLinksCJSCode);
            this.panel1.Controls.Add(this.chbAutoChange);
            this.panel1.Location = new System.Drawing.Point(541, 39);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel3.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(534, 203);
            this.panel1.TabIndex = 13;
            // 
            // chbActivateWebServer
            // 
            this.chbActivateWebServer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbActivateWebServer.AutoSize = true;
            this.chbActivateWebServer.Location = new System.Drawing.Point(378, 77);
            this.chbActivateWebServer.Name = "chbActivateWebServer";
            this.chbActivateWebServer.Size = new System.Drawing.Size(138, 17);
            this.chbActivateWebServer.TabIndex = 14;
            this.chbActivateWebServer.Text = "Activate the web server";
            this.chbActivateWebServer.UseVisualStyleBackColor = true;
            this.chbActivateWebServer.CheckedChanged += new System.EventHandler(this.chbActivateWebServer_CheckedChanged);
            // 
            // chbShowSourceCode
            // 
            this.chbShowSourceCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chbShowSourceCode.AutoSize = true;
            this.chbShowSourceCode.Location = new System.Drawing.Point(21, 77);
            this.chbShowSourceCode.Name = "chbShowSourceCode";
            this.chbShowSourceCode.Size = new System.Drawing.Size(166, 17);
            this.chbShowSourceCode.TabIndex = 13;
            this.chbShowSourceCode.Text = "Show source code of website";
            this.chbShowSourceCode.UseVisualStyleBackColor = true;
            this.chbShowSourceCode.CheckedChanged += new System.EventHandler(this.chbShowSourceCode_CheckedChanged);
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBrowser.Location = new System.Drawing.Point(291, 19);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(225, 36);
            this.btnOpenBrowser.TabIndex = 12;
            this.btnOpenBrowser.Text = "Open page in browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTempDemo2);
            this.groupBox1.Controls.Add(this.btnDefTemp);
            this.groupBox1.Controls.Add(this.btnTempDemo1);
            this.groupBox1.Location = new System.Drawing.Point(11, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Templates";
            // 
            // btnTempDemo2
            // 
            this.btnTempDemo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTempDemo2.Location = new System.Drawing.Point(312, 19);
            this.btnTempDemo2.Name = "btnTempDemo2";
            this.btnTempDemo2.Size = new System.Drawing.Size(194, 41);
            this.btnTempDemo2.TabIndex = 11;
            this.btnTempDemo2.Text = "Material Design Lite Demo";
            this.btnTempDemo2.UseVisualStyleBackColor = true;
            this.btnTempDemo2.Click += new System.EventHandler(this.btnTempDemo2_Click);
            // 
            // btnDefTemp
            // 
            this.btnDefTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefTemp.Location = new System.Drawing.Point(8, 19);
            this.btnDefTemp.Name = "btnDefTemp";
            this.btnDefTemp.Size = new System.Drawing.Size(184, 41);
            this.btnDefTemp.TabIndex = 10;
            this.btnDefTemp.Text = "Default Template";
            this.btnDefTemp.UseVisualStyleBackColor = true;
            this.btnDefTemp.Click += new System.EventHandler(this.btnDefTemp_Click);
            // 
            // btnTempDemo1
            // 
            this.btnTempDemo1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTempDemo1.Location = new System.Drawing.Point(198, 19);
            this.btnTempDemo1.Name = "btnTempDemo1";
            this.btnTempDemo1.Size = new System.Drawing.Size(108, 41);
            this.btnTempDemo1.TabIndex = 9;
            this.btnTempDemo1.Text = "Bootstrap Demo";
            this.btnTempDemo1.UseVisualStyleBackColor = true;
            this.btnTempDemo1.Click += new System.EventHandler(this.btnTempDemo1_Click);
            // 
            // chbInsLinksCJSCode
            // 
            this.chbInsLinksCJSCode.AutoSize = true;
            this.chbInsLinksCJSCode.Location = new System.Drawing.Point(21, 39);
            this.chbInsLinksCJSCode.Name = "chbInsLinksCJSCode";
            this.chbInsLinksCJSCode.Size = new System.Drawing.Size(234, 17);
            this.chbInsLinksCJSCode.TabIndex = 8;
            this.chbInsLinksCJSCode.Text = "Insert automatic links of css and js into code";
            this.chbInsLinksCJSCode.UseVisualStyleBackColor = true;
            this.chbInsLinksCJSCode.CheckedChanged += new System.EventHandler(this.chbInsLinksCJSCode_CheckedChanged);
            // 
            // chbAutoChange
            // 
            this.chbAutoChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAutoChange.AutoSize = true;
            this.chbAutoChange.Location = new System.Drawing.Point(21, 16);
            this.chbAutoChange.Name = "chbAutoChange";
            this.chbAutoChange.Size = new System.Drawing.Size(88, 17);
            this.chbAutoChange.TabIndex = 7;
            this.chbAutoChange.Text = "Auto Change";
            this.chbAutoChange.UseVisualStyleBackColor = true;
            this.chbAutoChange.CheckedChanged += new System.EventHandler(this.chbAutoChange_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.tbAddCSSLink, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAddCSSLink, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(263, 40);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // tbAddCSSLink
            // 
            this.tbAddCSSLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddCSSLink.Location = new System.Drawing.Point(3, 10);
            this.tbAddCSSLink.Name = "tbAddCSSLink";
            this.tbAddCSSLink.Size = new System.Drawing.Size(204, 20);
            this.tbAddCSSLink.TabIndex = 0;
            this.tbAddCSSLink.TextChanged += new System.EventHandler(this.tbAddCSSLink_TextChanged);
            // 
            // btnAddCSSLink
            // 
            this.btnAddCSSLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCSSLink.Location = new System.Drawing.Point(213, 3);
            this.btnAddCSSLink.Name = "btnAddCSSLink";
            this.btnAddCSSLink.Size = new System.Drawing.Size(47, 34);
            this.btnAddCSSLink.TabIndex = 1;
            this.btnAddCSSLink.Text = "Add";
            this.btnAddCSSLink.UseVisualStyleBackColor = true;
            this.btnAddCSSLink.Click += new System.EventHandler(this.btnAddCSSLink_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(166, 9);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(866, 20);
            this.tbUrl.TabIndex = 6;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbOptions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.webView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCode, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.355932F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.10735F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.50848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 708);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.tbUrl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1090, 39);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1038, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(49, 33);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.btnRefNavigation, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnForwardNavigation, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnBackNavigation, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(157, 33);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // btnRefNavigation
            // 
            this.btnRefNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefNavigation.Image = global::ThemeGenerator.Properties.Resources.ref_icon_usmall;
            this.btnRefNavigation.Location = new System.Drawing.Point(107, 3);
            this.btnRefNavigation.Name = "btnRefNavigation";
            this.btnRefNavigation.Size = new System.Drawing.Size(47, 27);
            this.btnRefNavigation.TabIndex = 11;
            this.btnRefNavigation.UseVisualStyleBackColor = true;
            this.btnRefNavigation.Click += new System.EventHandler(this.btnRefNavigation_Click);
            // 
            // btnForwardNavigation
            // 
            this.btnForwardNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForwardNavigation.Location = new System.Drawing.Point(55, 3);
            this.btnForwardNavigation.Name = "btnForwardNavigation";
            this.btnForwardNavigation.Size = new System.Drawing.Size(46, 27);
            this.btnForwardNavigation.TabIndex = 10;
            this.btnForwardNavigation.Text = ">";
            this.btnForwardNavigation.UseVisualStyleBackColor = true;
            this.btnForwardNavigation.Click += new System.EventHandler(this.btnForwardNavigation_Click);
            // 
            // btnBackNavigation
            // 
            this.btnBackNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackNavigation.Location = new System.Drawing.Point(3, 3);
            this.btnBackNavigation.Name = "btnBackNavigation";
            this.btnBackNavigation.Size = new System.Drawing.Size(46, 27);
            this.btnBackNavigation.TabIndex = 9;
            this.btnBackNavigation.Text = "<";
            this.btnBackNavigation.UseVisualStyleBackColor = true;
            this.btnBackNavigation.Click += new System.EventHandler(this.btnBackNavigation_Click);
            // 
            // webView
            // 
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.Location = new System.Drawing.Point(551, 48);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(542, 370);
            this.webView.TabIndex = 9;
            this.webView.Text = "webView";
            this.webView.ZoomFactor = 1D;
            // 
            // tbCode
            // 
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.DetectUrls = false;
            this.tbCode.Location = new System.Drawing.Point(3, 48);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(542, 370);
            this.tbCode.TabIndex = 10;
            this.tbCode.Text = "";
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // FormTheme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1120, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTheme";
            this.Text = "Theme Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTheme_FormClosing);
            this.Load += new System.EventHandler(this.FormTheme_Load);
            this.Resize += new System.EventHandler(this.FormTheme_Resize);
            this.gbOptions.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCurFramework;
        private System.Windows.Forms.ComboBox cbFrameworks;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnRenderToWebBrowser;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnSaveTemp;
        private System.Windows.Forms.CheckBox chbAutoChange;
        private System.Windows.Forms.ListBox lbJSLinks;
        private System.Windows.Forms.Label lblJS;
        private System.Windows.Forms.ListBox lbCSSLinks;
        private System.Windows.Forms.Label lblCSS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbInsLinksCJSCode;
        private System.Windows.Forms.RichTextBox tbCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox tbAddJSLink;
        private System.Windows.Forms.TextBox tbAddCSSLink;
        private System.Windows.Forms.Button btnAddJSLink;
        private System.Windows.Forms.Button btnAddCSSLink;
        private System.Windows.Forms.Button btnTempDemo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDefTemp;
        private System.Windows.Forms.Button btnTempDemo2;
        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.CheckBox chbShowSourceCode;
        private System.Windows.Forms.CheckBox chbActivateWebServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnBackNavigation;
        private System.Windows.Forms.Button btnRefNavigation;
        private System.Windows.Forms.Button btnForwardNavigation;
    }
}

