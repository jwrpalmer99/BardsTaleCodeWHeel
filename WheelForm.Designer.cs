namespace BardsTaleCodeWHeel
{
    partial class WheelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WheelForm));
            this.picA = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picA)).BeginInit();
            this.SuspendLayout();
            // 
            // picA
            // 
            this.picA.BackColor = System.Drawing.Color.Transparent;
            this.picA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picA.InitialImage = null;
            this.picA.Location = new System.Drawing.Point(0, 0);
            this.picA.Name = "picA";
            this.picA.Size = new System.Drawing.Size(852, 853);
            this.picA.TabIndex = 0;
            this.picA.TabStop = false;
            this.picA.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picA_MouseDown);
            this.picA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picA_MouseMove);
            this.picA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picA_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(703, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WheelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(852, 853);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picA);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(852, 853);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(852, 853);
            this.Name = "WheelForm";
            this.Text = "Bards Tale IV Code Wheel";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picA_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picA;
        private System.Windows.Forms.Button button1;
    }
}

