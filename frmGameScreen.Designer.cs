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
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::defence_line_form.Properties.Resources.untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmGameScreen";
            this.Text = "frmGameScreen";
            this.Load += new System.EventHandler(this.frmGameScreen__Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}