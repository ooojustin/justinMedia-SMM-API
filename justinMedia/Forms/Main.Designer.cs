namespace justinMedia {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.timerBalanceUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlInstagramLikes = new System.Windows.Forms.Panel();
            this.btnAddLikes = new System.Windows.Forms.Button();
            this.nudInstagramLikes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInstagramLikesPicture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.pnlInstagramFollowers = new System.Windows.Forms.Panel();
            this.btnInstagramAddFollowers = new System.Windows.Forms.Button();
            this.nudInstagramFollowers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstagramFollowersUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDummy = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.btnOpenOrder = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.pnlYoutubeLikes = new System.Windows.Forms.Panel();
            this.btnYoutubeLikes = new System.Windows.Forms.Button();
            this.nudYoutubeLikes = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYoutubeLikesVideoID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlYoutubeDislikes = new System.Windows.Forms.Panel();
            this.btnYoutubeDislikes = new System.Windows.Forms.Button();
            this.nudYoutubeDislikes = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYoutubeDislikesVideoID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlInstagramLikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstagramLikes)).BeginInit();
            this.pnlInstagramFollowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstagramFollowers)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.pnlYoutubeLikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYoutubeLikes)).BeginInit();
            this.pnlYoutubeDislikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYoutubeDislikes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Red;
            this.btnSettings.Location = new System.Drawing.Point(318, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(117, 27);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Edit Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(238, 18);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(42, 15);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "$0.00";
            // 
            // timerBalanceUpdate
            // 
            this.timerBalanceUpdate.Interval = 60000;
            this.timerBalanceUpdate.Tick += new System.EventHandler(this.timerBalanceUpdate_Tick);
            // 
            // pnlInstagramLikes
            // 
            this.pnlInstagramLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlInstagramLikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInstagramLikes.Controls.Add(this.btnAddLikes);
            this.pnlInstagramLikes.Controls.Add(this.nudInstagramLikes);
            this.pnlInstagramLikes.Controls.Add(this.label4);
            this.pnlInstagramLikes.Controls.Add(this.txtInstagramLikesPicture);
            this.pnlInstagramLikes.Controls.Add(this.label5);
            this.pnlInstagramLikes.Location = new System.Drawing.Point(6, 35);
            this.pnlInstagramLikes.Name = "pnlInstagramLikes";
            this.pnlInstagramLikes.Size = new System.Drawing.Size(396, 179);
            this.pnlInstagramLikes.TabIndex = 8;
            // 
            // btnAddLikes
            // 
            this.btnAddLikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLikes.ForeColor = System.Drawing.Color.Red;
            this.btnAddLikes.Location = new System.Drawing.Point(125, 105);
            this.btnAddLikes.Name = "btnAddLikes";
            this.btnAddLikes.Size = new System.Drawing.Size(235, 27);
            this.btnAddLikes.TabIndex = 16;
            this.btnAddLikes.Text = "Add Likes";
            this.btnAddLikes.UseVisualStyleBackColor = true;
            this.btnAddLikes.Click += new System.EventHandler(this.btnAddLikes_Click);
            // 
            // nudInstagramLikes
            // 
            this.nudInstagramLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.nudInstagramLikes.ForeColor = System.Drawing.Color.Red;
            this.nudInstagramLikes.Location = new System.Drawing.Point(125, 74);
            this.nudInstagramLikes.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudInstagramLikes.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudInstagramLikes.Name = "nudInstagramLikes";
            this.nudInstagramLikes.Size = new System.Drawing.Size(235, 23);
            this.nudInstagramLikes.TabIndex = 15;
            this.nudInstagramLikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInstagramLikes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Likes:";
            // 
            // txtInstagramLikesPicture
            // 
            this.txtInstagramLikesPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtInstagramLikesPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstagramLikesPicture.ForeColor = System.Drawing.Color.Red;
            this.txtInstagramLikesPicture.Location = new System.Drawing.Point(125, 45);
            this.txtInstagramLikesPicture.Name = "txtInstagramLikesPicture";
            this.txtInstagramLikesPicture.Size = new System.Drawing.Size(235, 23);
            this.txtInstagramLikesPicture.TabIndex = 13;
            this.txtInstagramLikesPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Picture ID:";
            // 
            // cmbService
            // 
            this.cmbService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.cmbService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbService.ForeColor = System.Drawing.Color.Red;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "Instagram Followers",
            "Instagram Followers w/ Refill",
            "Instagram Likes",
            "Youtube Likes",
            "Youtube Dislikes"});
            this.cmbService.Location = new System.Drawing.Point(6, 6);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(396, 24);
            this.cmbService.TabIndex = 9;
            this.cmbService.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbService_DrawItem);
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // pnlInstagramFollowers
            // 
            this.pnlInstagramFollowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlInstagramFollowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInstagramFollowers.Controls.Add(this.btnInstagramAddFollowers);
            this.pnlInstagramFollowers.Controls.Add(this.nudInstagramFollowers);
            this.pnlInstagramFollowers.Controls.Add(this.label3);
            this.pnlInstagramFollowers.Controls.Add(this.txtInstagramFollowersUsername);
            this.pnlInstagramFollowers.Controls.Add(this.label1);
            this.pnlInstagramFollowers.Location = new System.Drawing.Point(6, 35);
            this.pnlInstagramFollowers.Name = "pnlInstagramFollowers";
            this.pnlInstagramFollowers.Size = new System.Drawing.Size(396, 179);
            this.pnlInstagramFollowers.TabIndex = 9;
            // 
            // btnInstagramAddFollowers
            // 
            this.btnInstagramAddFollowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstagramAddFollowers.ForeColor = System.Drawing.Color.Red;
            this.btnInstagramAddFollowers.Location = new System.Drawing.Point(181, 105);
            this.btnInstagramAddFollowers.Name = "btnInstagramAddFollowers";
            this.btnInstagramAddFollowers.Size = new System.Drawing.Size(179, 27);
            this.btnInstagramAddFollowers.TabIndex = 11;
            this.btnInstagramAddFollowers.Text = "Add Followers";
            this.btnInstagramAddFollowers.UseVisualStyleBackColor = true;
            this.btnInstagramAddFollowers.Click += new System.EventHandler(this.btnInstagramAddFollowers_Click);
            // 
            // nudInstagramFollowers
            // 
            this.nudInstagramFollowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.nudInstagramFollowers.ForeColor = System.Drawing.Color.Red;
            this.nudInstagramFollowers.Location = new System.Drawing.Point(181, 74);
            this.nudInstagramFollowers.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudInstagramFollowers.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudInstagramFollowers.Name = "nudInstagramFollowers";
            this.nudInstagramFollowers.Size = new System.Drawing.Size(179, 23);
            this.nudInstagramFollowers.TabIndex = 10;
            this.nudInstagramFollowers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInstagramFollowers.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Followers:";
            // 
            // txtInstagramFollowersUsername
            // 
            this.txtInstagramFollowersUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtInstagramFollowersUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstagramFollowersUsername.ForeColor = System.Drawing.Color.Red;
            this.txtInstagramFollowersUsername.Location = new System.Drawing.Point(181, 45);
            this.txtInstagramFollowersUsername.Name = "txtInstagramFollowersUsername";
            this.txtInstagramFollowersUsername.Size = new System.Drawing.Size(179, 23);
            this.txtInstagramFollowersUsername.TabIndex = 8;
            this.txtInstagramFollowersUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Instagram Username:";
            // 
            // txtDummy
            // 
            this.txtDummy.Location = new System.Drawing.Point(-10, -10);
            this.txtDummy.Name = "txtDummy";
            this.txtDummy.ReadOnly = true;
            this.txtDummy.Size = new System.Drawing.Size(10, 23);
            this.txtDummy.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabOrders);
            this.tabControl1.Location = new System.Drawing.Point(19, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 248);
            this.tabControl1.TabIndex = 11;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.tabGeneral.Controls.Add(this.pnlYoutubeLikes);
            this.tabGeneral.Controls.Add(this.pnlYoutubeDislikes);
            this.tabGeneral.Controls.Add(this.pnlInstagramLikes);
            this.tabGeneral.Controls.Add(this.pnlInstagramFollowers);
            this.tabGeneral.Controls.Add(this.cmbService);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(408, 220);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            // 
            // tabOrders
            // 
            this.tabOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.tabOrders.Controls.Add(this.btnOpenOrder);
            this.tabOrders.Controls.Add(this.lbOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 24);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(408, 220);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenOrder.ForeColor = System.Drawing.Color.Red;
            this.btnOpenOrder.Location = new System.Drawing.Point(6, 181);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(396, 33);
            this.btnOpenOrder.TabIndex = 5;
            this.btnOpenOrder.Text = "Open Order Details";
            this.btnOpenOrder.UseVisualStyleBackColor = true;
            this.btnOpenOrder.Click += new System.EventHandler(this.btnOpenOrder_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrders.ForeColor = System.Drawing.Color.Red;
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 15;
            this.lbOrders.Location = new System.Drawing.Point(6, 6);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(396, 167);
            this.lbOrders.TabIndex = 0;
            this.lbOrders.DoubleClick += new System.EventHandler(this.lbOrders_DoubleClick);
            // 
            // pnlYoutubeLikes
            // 
            this.pnlYoutubeLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlYoutubeLikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYoutubeLikes.Controls.Add(this.btnYoutubeLikes);
            this.pnlYoutubeLikes.Controls.Add(this.nudYoutubeLikes);
            this.pnlYoutubeLikes.Controls.Add(this.label6);
            this.pnlYoutubeLikes.Controls.Add(this.txtYoutubeLikesVideoID);
            this.pnlYoutubeLikes.Controls.Add(this.label7);
            this.pnlYoutubeLikes.Location = new System.Drawing.Point(6, 35);
            this.pnlYoutubeLikes.Name = "pnlYoutubeLikes";
            this.pnlYoutubeLikes.Size = new System.Drawing.Size(396, 179);
            this.pnlYoutubeLikes.TabIndex = 17;
            // 
            // btnYoutubeLikes
            // 
            this.btnYoutubeLikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutubeLikes.ForeColor = System.Drawing.Color.Red;
            this.btnYoutubeLikes.Location = new System.Drawing.Point(118, 105);
            this.btnYoutubeLikes.Name = "btnYoutubeLikes";
            this.btnYoutubeLikes.Size = new System.Drawing.Size(235, 27);
            this.btnYoutubeLikes.TabIndex = 16;
            this.btnYoutubeLikes.Text = "Add Likes";
            this.btnYoutubeLikes.UseVisualStyleBackColor = true;
            this.btnYoutubeLikes.Click += new System.EventHandler(this.btnYoutubeLikes_Click);
            // 
            // nudYoutubeLikes
            // 
            this.nudYoutubeLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.nudYoutubeLikes.ForeColor = System.Drawing.Color.Red;
            this.nudYoutubeLikes.Location = new System.Drawing.Point(118, 74);
            this.nudYoutubeLikes.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudYoutubeLikes.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudYoutubeLikes.Name = "nudYoutubeLikes";
            this.nudYoutubeLikes.Size = new System.Drawing.Size(235, 23);
            this.nudYoutubeLikes.TabIndex = 15;
            this.nudYoutubeLikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYoutubeLikes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Likes:";
            // 
            // txtYoutubeLikesVideoID
            // 
            this.txtYoutubeLikesVideoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtYoutubeLikesVideoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYoutubeLikesVideoID.ForeColor = System.Drawing.Color.Red;
            this.txtYoutubeLikesVideoID.Location = new System.Drawing.Point(118, 45);
            this.txtYoutubeLikesVideoID.Name = "txtYoutubeLikesVideoID";
            this.txtYoutubeLikesVideoID.Size = new System.Drawing.Size(235, 23);
            this.txtYoutubeLikesVideoID.TabIndex = 13;
            this.txtYoutubeLikesVideoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Video ID:";
            // 
            // pnlYoutubeDislikes
            // 
            this.pnlYoutubeDislikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.pnlYoutubeDislikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYoutubeDislikes.Controls.Add(this.btnYoutubeDislikes);
            this.pnlYoutubeDislikes.Controls.Add(this.nudYoutubeDislikes);
            this.pnlYoutubeDislikes.Controls.Add(this.label8);
            this.pnlYoutubeDislikes.Controls.Add(this.txtYoutubeDislikesVideoID);
            this.pnlYoutubeDislikes.Controls.Add(this.label9);
            this.pnlYoutubeDislikes.Location = new System.Drawing.Point(6, 35);
            this.pnlYoutubeDislikes.Name = "pnlYoutubeDislikes";
            this.pnlYoutubeDislikes.Size = new System.Drawing.Size(396, 179);
            this.pnlYoutubeDislikes.TabIndex = 18;
            // 
            // btnYoutubeDislikes
            // 
            this.btnYoutubeDislikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutubeDislikes.ForeColor = System.Drawing.Color.Red;
            this.btnYoutubeDislikes.Location = new System.Drawing.Point(118, 105);
            this.btnYoutubeDislikes.Name = "btnYoutubeDislikes";
            this.btnYoutubeDislikes.Size = new System.Drawing.Size(235, 27);
            this.btnYoutubeDislikes.TabIndex = 16;
            this.btnYoutubeDislikes.Text = "Add Dislikes";
            this.btnYoutubeDislikes.UseVisualStyleBackColor = true;
            this.btnYoutubeDislikes.Click += new System.EventHandler(this.btnYoutubeDislikes_Click);
            // 
            // nudYoutubeDislikes
            // 
            this.nudYoutubeDislikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.nudYoutubeDislikes.ForeColor = System.Drawing.Color.Red;
            this.nudYoutubeDislikes.Location = new System.Drawing.Point(118, 74);
            this.nudYoutubeDislikes.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudYoutubeDislikes.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudYoutubeDislikes.Name = "nudYoutubeDislikes";
            this.nudYoutubeDislikes.Size = new System.Drawing.Size(235, 23);
            this.nudYoutubeDislikes.TabIndex = 15;
            this.nudYoutubeDislikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYoutubeDislikes.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dislikes:";
            // 
            // txtYoutubeDislikesVideoID
            // 
            this.txtYoutubeDislikesVideoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtYoutubeDislikesVideoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYoutubeDislikesVideoID.ForeColor = System.Drawing.Color.Red;
            this.txtYoutubeDislikesVideoID.Location = new System.Drawing.Point(118, 45);
            this.txtYoutubeDislikesVideoID.Name = "txtYoutubeDislikesVideoID";
            this.txtYoutubeDislikesVideoID.Size = new System.Drawing.Size(235, 23);
            this.txtYoutubeDislikesVideoID.TabIndex = 13;
            this.txtYoutubeDislikesVideoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Video ID:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(450, 283);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtDummy);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "justinMedia - by ju$tin";
            this.pnlInstagramLikes.ResumeLayout(false);
            this.pnlInstagramLikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstagramLikes)).EndInit();
            this.pnlInstagramFollowers.ResumeLayout(false);
            this.pnlInstagramFollowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInstagramFollowers)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.pnlYoutubeLikes.ResumeLayout(false);
            this.pnlYoutubeLikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYoutubeLikes)).EndInit();
            this.pnlYoutubeDislikes.ResumeLayout(false);
            this.pnlYoutubeDislikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYoutubeDislikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Timer timerBalanceUpdate;
        private System.Windows.Forms.Panel pnlInstagramLikes;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Panel pnlInstagramFollowers;
        private System.Windows.Forms.TextBox txtDummy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInstagramFollowersUsername;
        private System.Windows.Forms.NumericUpDown nudInstagramFollowers;
        private System.Windows.Forms.Button btnInstagramAddFollowers;
        private System.Windows.Forms.Button btnAddLikes;
        private System.Windows.Forms.NumericUpDown nudInstagramLikes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInstagramLikesPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Button btnOpenOrder;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Panel pnlYoutubeLikes;
        private System.Windows.Forms.Button btnYoutubeLikes;
        private System.Windows.Forms.NumericUpDown nudYoutubeLikes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYoutubeLikesVideoID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlYoutubeDislikes;
        private System.Windows.Forms.Button btnYoutubeDislikes;
        private System.Windows.Forms.NumericUpDown nudYoutubeDislikes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYoutubeDislikesVideoID;
        private System.Windows.Forms.Label label9;
    }
}

