namespace justinMedia {
    partial class Settings {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBalanaceAutoUpdate = new System.Windows.Forms.CheckBox();
            this.nudBalanceInterval = new System.Windows.Forms.NumericUpDown();
            this.txtAPIURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalanceInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(14, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(381, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSettings.ForeColor = System.Drawing.Color.Red;
            this.btnResetSettings.Location = new System.Drawing.Point(14, 161);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(381, 25);
            this.btnResetSettings.TabIndex = 5;
            this.btnResetSettings.Text = "Delete Saved Settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtAPIKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAPIKey.ForeColor = System.Drawing.Color.Red;
            this.txtAPIKey.Location = new System.Drawing.Point(80, 12);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(315, 23);
            this.txtAPIKey.TabIndex = 7;
            this.txtAPIKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "API Key:";
            // 
            // cbBalanaceAutoUpdate
            // 
            this.cbBalanaceAutoUpdate.AutoSize = true;
            this.cbBalanaceAutoUpdate.Location = new System.Drawing.Point(14, 71);
            this.cbBalanaceAutoUpdate.Name = "cbBalanaceAutoUpdate";
            this.cbBalanaceAutoUpdate.Size = new System.Drawing.Size(271, 19);
            this.cbBalanaceAutoUpdate.TabIndex = 8;
            this.cbBalanaceAutoUpdate.Text = "Auto-Update Balance | Interval (s):";
            this.cbBalanaceAutoUpdate.UseVisualStyleBackColor = true;
            // 
            // nudBalanceInterval
            // 
            this.nudBalanceInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.nudBalanceInterval.ForeColor = System.Drawing.Color.Red;
            this.nudBalanceInterval.Location = new System.Drawing.Point(291, 70);
            this.nudBalanceInterval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudBalanceInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBalanceInterval.Name = "nudBalanceInterval";
            this.nudBalanceInterval.Size = new System.Drawing.Size(104, 23);
            this.nudBalanceInterval.TabIndex = 9;
            this.nudBalanceInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBalanceInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // txtAPIURL
            // 
            this.txtAPIURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.txtAPIURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAPIURL.ForeColor = System.Drawing.Color.Red;
            this.txtAPIURL.Location = new System.Drawing.Point(80, 41);
            this.txtAPIURL.Name = "txtAPIURL";
            this.txtAPIURL.Size = new System.Drawing.Size(315, 23);
            this.txtAPIURL.TabIndex = 11;
            this.txtAPIURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "API URL:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(407, 198);
            this.Controls.Add(this.txtAPIURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBalanceInterval);
            this.Controls.Add(this.cbBalanaceAutoUpdate);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "justinMedia - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBalanceInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbBalanaceAutoUpdate;
        private System.Windows.Forms.NumericUpDown nudBalanceInterval;
        private System.Windows.Forms.TextBox txtAPIURL;
        private System.Windows.Forms.Label label1;
    }
}