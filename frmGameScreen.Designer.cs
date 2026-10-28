namespace defence_line_form
{
    partial class frmGameScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.waveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wavedisplay = new System.Windows.Forms.Label();
            this.healthdisplay = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.moneydisplay = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 36);
            // 
            // waveToolStripMenuItem
            // 
            this.waveToolStripMenuItem.Name = "waveToolStripMenuItem";
            this.waveToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.waveToolStripMenuItem.Text = "Wave:";
            // 
            // wavedisplay
            // 
            this.wavedisplay.AutoSize = true;
            this.wavedisplay.BackColor = System.Drawing.Color.Transparent;
            this.wavedisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.wavedisplay.Location = new System.Drawing.Point(1051, 23);
            this.wavedisplay.Name = "wavedisplay";
            this.wavedisplay.Size = new System.Drawing.Size(132, 37);
            this.wavedisplay.TabIndex = 1;
            this.wavedisplay.Text = "Wave: 1";
            // 
            // healthdisplay
            // 
            this.healthdisplay.AutoSize = true;
            this.healthdisplay.BackColor = System.Drawing.Color.Transparent;
            this.healthdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.healthdisplay.Location = new System.Drawing.Point(1051, 80);
            this.healthdisplay.Name = "healthdisplay";
            this.healthdisplay.Size = new System.Drawing.Size(145, 37);
            this.healthdisplay.TabIndex = 2;
            this.healthdisplay.Text = "Health: 0";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(990, 616);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(206, 62);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // moneydisplay
            // 
            this.moneydisplay.AutoSize = true;
            this.moneydisplay.BackColor = System.Drawing.Color.Transparent;
            this.moneydisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.moneydisplay.Location = new System.Drawing.Point(1015, 134);
            this.moneydisplay.Name = "moneydisplay";
            this.moneydisplay.Size = new System.Drawing.Size(156, 37);
            this.moneydisplay.TabIndex = 5;
            this.moneydisplay.Text = "Money : 0";
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::defence_line_form.Properties.Resources.untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.moneydisplay);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.healthdisplay);
            this.Controls.Add(this.wavedisplay);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmGameScreen";
            this.Text = "frmGameScreen";
            this.Load += new System.EventHandler(this.frmGameScreen__Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem waveToolStripMenuItem;
        private System.Windows.Forms.Label wavedisplay;
        private System.Windows.Forms.Label healthdisplay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label moneydisplay;
    }
}