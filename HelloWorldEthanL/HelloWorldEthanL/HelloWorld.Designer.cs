namespace HelloWorldEthanL
{
    partial class frmHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.picClown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Firebrick;
            this.lblGreeting.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGreeting.Location = new System.Drawing.Point(259, 123);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(258, 51);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Impact", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.ForeColor = System.Drawing.Color.Green;
            this.lblSignature.Location = new System.Drawing.Point(262, 222);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(210, 34);
            this.lblSignature.TabIndex = 1;
            this.lblSignature.Text = "by Ethan LeGault";
            this.lblSignature.Click += new System.EventHandler(this.Label1_Click);
            // 
            // picClown
            // 
            this.picClown.Image = ((System.Drawing.Image)(resources.GetObject("picClown.Image")));
            this.picClown.Location = new System.Drawing.Point(224, 270);
            this.picClown.Name = "picClown";
            this.picClown.Size = new System.Drawing.Size(320, 168);
            this.picClown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClown.TabIndex = 2;
            this.picClown.TabStop = false;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picClown);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloWorld";
            this.Text = "Hello, World! by Ethan";
            ((System.ComponentModel.ISupportInitialize)(this.picClown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.PictureBox picClown;
    }
}

