namespace PDAClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.miOptions = new System.Windows.Forms.MenuItem();
            this.miChangePassword = new System.Windows.Forms.MenuItem();
            this.miUpdate = new System.Windows.Forms.MenuItem();
            this.miReset = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.miClose = new System.Windows.Forms.MenuItem();
            this.sbMain = new System.Windows.Forms.StatusBar();
            this.btnScanCheckBarCode = new System.Windows.Forms.Button();
            this.btnScanShipBarCode = new System.Windows.Forms.Button();
            this.btnScanAssemblyBarCode = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItem4);
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.miOptions);
            this.menuItem4.MenuItems.Add(this.miChangePassword);
            this.menuItem4.MenuItems.Add(this.miUpdate);
            this.menuItem4.MenuItems.Add(this.miReset);
            this.menuItem4.MenuItems.Add(this.menuItem7);
            this.menuItem4.MenuItems.Add(this.miClose);
            this.menuItem4.Text = "系统";
            // 
            // miOptions
            // 
            this.miOptions.Text = "选项设置";
            this.miOptions.Click += new System.EventHandler(this.miOptions_Click);
            // 
            // miChangePassword
            // 
            this.miChangePassword.Text = "修改密码";
            this.miChangePassword.Click += new System.EventHandler(this.miChangePassword_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Text = "检查版本";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // miReset
            // 
            this.miReset.Text = "注销";
            this.miReset.Click += new System.EventHandler(this.miReset_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "-";
            // 
            // miClose
            // 
            this.miClose.Text = "关闭";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // sbMain
            // 
            this.sbMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.sbMain.Location = new System.Drawing.Point(0, 273);
            this.sbMain.Name = "sbMain";
            this.sbMain.Size = new System.Drawing.Size(318, 22);
            // 
            // btnScanCheckBarCode
            // 
            this.btnScanCheckBarCode.Location = new System.Drawing.Point(94, 158);
            this.btnScanCheckBarCode.Name = "btnScanCheckBarCode";
            this.btnScanCheckBarCode.Size = new System.Drawing.Size(130, 27);
            this.btnScanCheckBarCode.TabIndex = 2;
            this.btnScanCheckBarCode.Text = "盘点扫描(F3)";
            this.btnScanCheckBarCode.Click += new System.EventHandler(this.btnScanCheckBarCode_Click);
            // 
            // btnScanShipBarCode
            // 
            this.btnScanShipBarCode.Location = new System.Drawing.Point(94, 101);
            this.btnScanShipBarCode.Name = "btnScanShipBarCode";
            this.btnScanShipBarCode.Size = new System.Drawing.Size(130, 27);
            this.btnScanShipBarCode.TabIndex = 1;
            this.btnScanShipBarCode.Text = "出库扫描(F2)";
            this.btnScanShipBarCode.Click += new System.EventHandler(this.btnScanShipBarCode_Click);
            // 
            // btnScanAssemblyBarCode
            // 
            this.btnScanAssemblyBarCode.Location = new System.Drawing.Point(94, 43);
            this.btnScanAssemblyBarCode.Name = "btnScanAssemblyBarCode";
            this.btnScanAssemblyBarCode.Size = new System.Drawing.Size(130, 27);
            this.btnScanAssemblyBarCode.TabIndex = 0;
            this.btnScanAssemblyBarCode.Text = "入库扫描(F1)";
            this.btnScanAssemblyBarCode.Click += new System.EventHandler(this.btnScanAssemblyBarCode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.sbMain);
            this.Controls.Add(this.btnScanCheckBarCode);
            this.Controls.Add(this.btnScanShipBarCode);
            this.Controls.Add(this.btnScanAssemblyBarCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "条码管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScanAssemblyBarCode;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem miChangePassword;
        private System.Windows.Forms.MenuItem miReset;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem miClose;
        private System.Windows.Forms.Button btnScanShipBarCode;
        private System.Windows.Forms.MenuItem miOptions;
        private System.Windows.Forms.Button btnScanCheckBarCode;
        private System.Windows.Forms.StatusBar sbMain;
        private System.Windows.Forms.MenuItem miUpdate;
        private System.Windows.Forms.Timer timer1;
    }
}