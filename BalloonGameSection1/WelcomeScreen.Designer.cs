namespace BalloonGameSection1
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.txtBallPop = new System.Windows.Forms.Label();
            this.txtLetsPlay = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtBallPop
            // 
            this.txtBallPop.AutoSize = true;
            this.txtBallPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBallPop.ForeColor = System.Drawing.Color.Lime;
            this.txtBallPop.Location = new System.Drawing.Point(263, 132);
            this.txtBallPop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBallPop.Name = "txtBallPop";
            this.txtBallPop.Size = new System.Drawing.Size(222, 31);
            this.txtBallPop.TabIndex = 0;
            this.txtBallPop.Text = "BALLOON POP!!";
            // 
            // txtLetsPlay
            // 
            this.txtLetsPlay.AutoSize = true;
            this.txtLetsPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetsPlay.ForeColor = System.Drawing.Color.Lime;
            this.txtLetsPlay.Location = new System.Drawing.Point(537, 190);
            this.txtLetsPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtLetsPlay.Name = "txtLetsPlay";
            this.txtLetsPlay.Size = new System.Drawing.Size(187, 31);
            this.txtLetsPlay.TabIndex = 1;
            this.txtLetsPlay.Text = "LET\'S PLAY...";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(856, 110);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 46);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(974, 190);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 4;
            this.progressLabel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(856, 190);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 476);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtLetsPlay);
            this.Controls.Add(this.txtBallPop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtBallPop;
        private System.Windows.Forms.Label txtLetsPlay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

