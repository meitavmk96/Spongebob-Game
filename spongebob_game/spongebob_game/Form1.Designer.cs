namespace spongebob_game
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.lbl_health = new System.Windows.Forms.Label();
            this.pb_health = new System.Windows.Forms.ProgressBar();
            this.spongebob = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_points = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spongebob)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_health
            // 
            this.lbl_health.AutoSize = true;
            this.lbl_health.BackColor = System.Drawing.Color.Transparent;
            this.lbl_health.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_health.Location = new System.Drawing.Point(430, 26);
            this.lbl_health.Name = "lbl_health";
            this.lbl_health.Size = new System.Drawing.Size(81, 25);
            this.lbl_health.TabIndex = 2;
            this.lbl_health.Text = "Health:";
            // 
            // pb_health
            // 
            this.pb_health.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_health.Location = new System.Drawing.Point(517, 31);
            this.pb_health.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_health.Name = "pb_health";
            this.pb_health.Size = new System.Drawing.Size(196, 20);
            this.pb_health.TabIndex = 3;
            this.pb_health.Value = 100;
            this.pb_health.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_health_MouseClick);
            this.pb_health.MouseHover += new System.EventHandler(this.pb_health_MouseHover);
            // 
            // spongebob
            // 
            this.spongebob.BackColor = System.Drawing.Color.Transparent;
            this.spongebob.Image = global::spongebob_game.Properties.Resources.spongebob;
            this.spongebob.Location = new System.Drawing.Point(1, 336);
            this.spongebob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spongebob.Name = "spongebob";
            this.spongebob.Size = new System.Drawing.Size(105, 134);
            this.spongebob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spongebob.TabIndex = 5;
            this.spongebob.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.BackColor = System.Drawing.Color.Transparent;
            this.lbl_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_points.Location = new System.Drawing.Point(29, 26);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(77, 25);
            this.lbl_points.TabIndex = 10;
            this.lbl_points.Text = "points:";
            // 
            // cbo
            // 
            this.cbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "flowers background",
            "krusty krab background",
            "nigboorhood background"});
            this.cbo.Location = new System.Drawing.Point(867, 23);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(296, 28);
            this.cbo.TabIndex = 11;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::spongebob_game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 471);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.spongebob);
            this.Controls.Add(this.pb_health);
            this.Controls.Add(this.lbl_health);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "spongebob game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.spongebob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_health;
        private System.Windows.Forms.ProgressBar pb_health;
        private System.Windows.Forms.PictureBox spongebob;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.ComboBox cbo;
    }
}

