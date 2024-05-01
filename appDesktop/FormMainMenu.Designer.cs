namespace appDesktop
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnSetting = new Button();
            btnNotifications = new Button();
            btnReporting = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnProduct = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnNotifications);
            panelMenu.Controls.Add(btnReporting);
            panelMenu.Controls.Add(btnCustomers);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnProduct);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 542);
            panelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.Gainsboro;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 380);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(12, 0, 0, 0);
            btnSetting.Size = new Size(220, 60);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "     Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Dock = DockStyle.Top;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNotifications.ForeColor = Color.Gainsboro;
            btnNotifications.Image = (Image)resources.GetObject("btnNotifications.Image");
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(0, 320);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Padding = new Padding(12, 0, 0, 0);
            btnNotifications.Size = new Size(220, 60);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "     Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnReporting
            // 
            btnReporting.Dock = DockStyle.Top;
            btnReporting.FlatAppearance.BorderSize = 0;
            btnReporting.FlatStyle = FlatStyle.Flat;
            btnReporting.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporting.ForeColor = Color.Gainsboro;
            btnReporting.Image = (Image)resources.GetObject("btnReporting.Image");
            btnReporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporting.Location = new Point(0, 260);
            btnReporting.Name = "btnReporting";
            btnReporting.Padding = new Padding(12, 0, 0, 0);
            btnReporting.Size = new Size(220, 60);
            btnReporting.TabIndex = 4;
            btnReporting.Text = "     Reporting";
            btnReporting.TextAlign = ContentAlignment.MiddleLeft;
            btnReporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporting.UseVisualStyleBackColor = true;
            btnReporting.Click += btnReporting_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.Gainsboro;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 200);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(12, 0, 0, 0);
            btnCustomers.Size = new Size(220, 60);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "     Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = Color.Gainsboro;
            btnOrders.Image = (Image)resources.GetObject("btnOrders.Image");
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 140);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(12, 0, 0, 0);
            btnOrders.Size = new Size(220, 60);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "     Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.Gainsboro;
            btnProduct.Image = Properties.Resources.shopping_cart__1_;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 80);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(12, 0, 0, 0);
            btnProduct.Size = new Size(220, 60);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "     Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Tacos El foraneo";
            label1.Click += label1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(803, 80);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(698, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 5;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(734, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(770, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = Properties.Resources.cross_out__2_;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(385, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(73, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.Click += HOME_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(803, 462);
            panelDesktopPane.TabIndex = 2;
            panelDesktopPane.Paint += panelDesktopPane_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoRecreado;
            pictureBox1.Location = new Point(115, -68);
            pictureBox1.MinimumSize = new Size(500, 500);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 626);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 542);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "Form1";
            Load += FormMainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnProduct;
        private Panel panelLogo;
        private Button btnSetting;
        private Button btnNotifications;
        private Button btnReporting;
        private Button btnCustomers;
        private Button btnOrders;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}
