namespace AppTracker
{
    partial class App_Tracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_Tracker));
            this.close_button = new System.Windows.Forms.Button();
            this.maximise_button = new System.Windows.Forms.Button();
            this.minimise_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.timer_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer_start_button = new System.Windows.Forms.Button();
            this.timer_label = new System.Windows.Forms.Label();
            this.background_app_tracker_button = new System.Windows.Forms.Button();
            this.cur_apps_recording_button = new System.Windows.Forms.Button();
            this.StopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackColor = System.Drawing.Color.Gray;
            this.close_button.BackgroundImage = global::AppTracker.Properties.Resources.cancel_26px1;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(770, 12);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(20, 20);
            this.close_button.TabIndex = 0;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // maximise_button
            // 
            this.maximise_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximise_button.BackColor = System.Drawing.Color.Gray;
            this.maximise_button.BackgroundImage = global::AppTracker.Properties.Resources.unchecked_checkbox_26px;
            this.maximise_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximise_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximise_button.FlatAppearance.BorderSize = 0;
            this.maximise_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.maximise_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.maximise_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximise_button.Location = new System.Drawing.Point(736, 11);
            this.maximise_button.Margin = new System.Windows.Forms.Padding(2);
            this.maximise_button.Name = "maximise_button";
            this.maximise_button.Size = new System.Drawing.Size(20, 20);
            this.maximise_button.TabIndex = 1;
            this.maximise_button.UseVisualStyleBackColor = false;
            this.maximise_button.Click += new System.EventHandler(this.maximise_button_Click);
            // 
            // minimise_button
            // 
            this.minimise_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimise_button.BackColor = System.Drawing.Color.Gray;
            this.minimise_button.BackgroundImage = global::AppTracker.Properties.Resources.cancel_48px1;
            this.minimise_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimise_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimise_button.FlatAppearance.BorderSize = 0;
            this.minimise_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.minimise_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimise_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimise_button.Location = new System.Drawing.Point(697, 11);
            this.minimise_button.Margin = new System.Windows.Forms.Padding(2);
            this.minimise_button.Name = "minimise_button";
            this.minimise_button.Size = new System.Drawing.Size(20, 20);
            this.minimise_button.TabIndex = 2;
            this.minimise_button.UseVisualStyleBackColor = false;
            this.minimise_button.Click += new System.EventHandler(this.minimise_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(11, 9);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(153, 31);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "App Tracker";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 10);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(70, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 87);
            this.panel2.TabIndex = 5;
            // 
            // settings_button
            // 
            this.settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_button.BackColor = System.Drawing.Color.Gray;
            this.settings_button.BackgroundImage = global::AppTracker.Properties.Resources.services_26px;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.settings_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Location = new System.Drawing.Point(12, 61);
            this.settings_button.Margin = new System.Windows.Forms.Padding(2);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(30, 30);
            this.settings_button.TabIndex = 5;
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // timer_button
            // 
            this.timer_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timer_button.BackColor = System.Drawing.Color.Gray;
            this.timer_button.BackgroundImage = global::AppTracker.Properties.Resources.clock_26px;
            this.timer_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timer_button.FlatAppearance.BorderSize = 0;
            this.timer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.timer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.timer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_button.Location = new System.Drawing.Point(759, 62);
            this.timer_button.Margin = new System.Windows.Forms.Padding(2);
            this.timer_button.Name = "timer_button";
            this.timer_button.Size = new System.Drawing.Size(30, 30);
            this.timer_button.TabIndex = 6;
            this.timer_button.UseVisualStyleBackColor = false;
            this.timer_button.Click += new System.EventHandler(this.timer_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.timer_start_button);
            this.panel3.Controls.Add(this.timer_label);
            this.panel3.Location = new System.Drawing.Point(11, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 383);
            this.panel3.TabIndex = 7;
            // 
            // timer_start_button
            // 
            this.timer_start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timer_start_button.BackColor = System.Drawing.Color.DarkGray;
            this.timer_start_button.BackgroundImage = global::AppTracker.Properties.Resources.play_24px;
            this.timer_start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timer_start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timer_start_button.FlatAppearance.BorderSize = 0;
            this.timer_start_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.timer_start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.timer_start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_start_button.Location = new System.Drawing.Point(418, 110);
            this.timer_start_button.Margin = new System.Windows.Forms.Padding(2);
            this.timer_start_button.Name = "timer_start_button";
            this.timer_start_button.Size = new System.Drawing.Size(30, 30);
            this.timer_start_button.TabIndex = 10;
            this.timer_start_button.UseVisualStyleBackColor = false;
            this.timer_start_button.Visible = false;
            this.timer_start_button.Click += new System.EventHandler(this.timer_start_button_Click);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Digital-7", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timer_label.Location = new System.Drawing.Point(212, 12);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(342, 96);
            this.timer_label.TabIndex = 0;
            this.timer_label.Text = "00:00:00";
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer_label.Visible = false;
            // 
            // background_app_tracker_button
            // 
            this.background_app_tracker_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.background_app_tracker_button.BackColor = System.Drawing.Color.Gray;
            this.background_app_tracker_button.BackgroundImage = global::AppTracker.Properties.Resources.schedule_26px;
            this.background_app_tracker_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_app_tracker_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.background_app_tracker_button.FlatAppearance.BorderSize = 0;
            this.background_app_tracker_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.background_app_tracker_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.background_app_tracker_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.background_app_tracker_button.Location = new System.Drawing.Point(691, 61);
            this.background_app_tracker_button.Margin = new System.Windows.Forms.Padding(2);
            this.background_app_tracker_button.Name = "background_app_tracker_button";
            this.background_app_tracker_button.Size = new System.Drawing.Size(30, 30);
            this.background_app_tracker_button.TabIndex = 8;
            this.background_app_tracker_button.UseVisualStyleBackColor = false;
            this.background_app_tracker_button.Click += new System.EventHandler(this.background_app_tracker_button_Click);
            // 
            // cur_apps_recording_button
            // 
            this.cur_apps_recording_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cur_apps_recording_button.BackColor = System.Drawing.Color.Gray;
            this.cur_apps_recording_button.BackgroundImage = global::AppTracker.Properties.Resources.task_50px1;
            this.cur_apps_recording_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cur_apps_recording_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cur_apps_recording_button.FlatAppearance.BorderSize = 0;
            this.cur_apps_recording_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cur_apps_recording_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cur_apps_recording_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cur_apps_recording_button.Location = new System.Drawing.Point(725, 61);
            this.cur_apps_recording_button.Margin = new System.Windows.Forms.Padding(2);
            this.cur_apps_recording_button.Name = "cur_apps_recording_button";
            this.cur_apps_recording_button.Size = new System.Drawing.Size(30, 30);
            this.cur_apps_recording_button.TabIndex = 9;
            this.cur_apps_recording_button.UseVisualStyleBackColor = false;
            this.cur_apps_recording_button.Click += new System.EventHandler(this.cur_apps_recording_button_Click);
            // 
            // StopWatchTimer
            // 
            this.StopWatchTimer.Interval = 1;
            this.StopWatchTimer.Tick += new System.EventHandler(this.StopWatchTimer_Tick);
            // 
            // App_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.cur_apps_recording_button);
            this.Controls.Add(this.background_app_tracker_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.timer_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.minimise_button);
            this.Controls.Add(this.maximise_button);
            this.Controls.Add(this.close_button);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "App_Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button close_button;
        private Button maximise_button;
        private Button minimise_button;
        private Label title_label;
        private Panel panel1;
        private Panel panel2;
        private Button settings_button;
        private Button timer_button;
        private Panel panel3;
        private Button background_app_tracker_button;
        private Button cur_apps_recording_button;
        private Label timer_label;
        private System.Windows.Forms.Timer StopWatchTimer;
        private Button timer_start_button;
    }
}