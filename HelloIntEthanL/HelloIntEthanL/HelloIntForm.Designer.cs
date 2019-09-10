namespace HelloIntEthanL
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbGreetings = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radSwedish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.grbGreetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Indigo;
            this.lblGreeting.Location = new System.Drawing.Point(243, 92);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(288, 60);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.Label1_Click);
            // 
            // grbGreetings
            // 
            this.grbGreetings.Controls.Add(this.radFrench);
            this.grbGreetings.Controls.Add(this.radEnglish);
            this.grbGreetings.Controls.Add(this.radSwedish);
            this.grbGreetings.Controls.Add(this.radGerman);
            this.grbGreetings.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGreetings.ForeColor = System.Drawing.Color.Indigo;
            this.grbGreetings.Location = new System.Drawing.Point(131, 228);
            this.grbGreetings.Name = "grbGreetings";
            this.grbGreetings.Size = new System.Drawing.Size(559, 102);
            this.grbGreetings.TabIndex = 1;
            this.grbGreetings.TabStop = false;
            this.grbGreetings.Text = "Language Select";
            this.grbGreetings.Enter += new System.EventHandler(this.GrbGreetings_Enter);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(6, 49);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(120, 38);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGerman.Location = new System.Drawing.Point(129, 49);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(146, 38);
            this.radGerman.TabIndex = 2;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "Deutsche";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.RadGerman_CheckedChanged);
            // 
            // radSwedish
            // 
            this.radSwedish.AutoSize = true;
            this.radSwedish.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSwedish.Location = new System.Drawing.Point(281, 49);
            this.radSwedish.Name = "radSwedish";
            this.radSwedish.Size = new System.Drawing.Size(135, 38);
            this.radSwedish.TabIndex = 3;
            this.radSwedish.TabStop = true;
            this.radSwedish.Text = "Svenska";
            this.radSwedish.UseVisualStyleBackColor = true;
            this.radSwedish.CheckedChanged += new System.EventHandler(this.RadSwedish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrench.Location = new System.Drawing.Point(416, 49);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(137, 38);
            this.radFrench.TabIndex = 4;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbGreetings);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloInt";
            this.Text = "Hello, World! International by Ethan";
            this.grbGreetings.ResumeLayout(false);
            this.grbGreetings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbGreetings;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radSwedish;
        private System.Windows.Forms.RadioButton radGerman;
    }
}

