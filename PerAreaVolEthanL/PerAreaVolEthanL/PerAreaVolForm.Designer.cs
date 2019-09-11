﻿namespace PerAreaVolEthanL
{
    partial class frmPerAreaVol
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
            this.btnQPerimeter = new System.Windows.Forms.Button();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.btnQArea = new System.Windows.Forms.Button();
            this.btnQVolume = new System.Windows.Forms.Button();
            this.lblAArea = new System.Windows.Forms.Label();
            this.lblAVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQPerimeter
            // 
            this.btnQPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQPerimeter.Location = new System.Drawing.Point(12, 12);
            this.btnQPerimeter.Name = "btnQPerimeter";
            this.btnQPerimeter.Size = new System.Drawing.Size(277, 94);
            this.btnQPerimeter.TabIndex = 0;
            this.btnQPerimeter.Text = "Calculate the perimeter of a rectangle with a length of 8cm and a width of 5cm";
            this.btnQPerimeter.UseVisualStyleBackColor = true;
            this.btnQPerimeter.Click += new System.EventHandler(this.BtnQPerimeter_Click);
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPerimeter.Location = new System.Drawing.Point(327, 47);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(40, 24);
            this.lblAPerimeter.TabIndex = 1;
            this.lblAPerimeter.Text = "???";
            this.lblAPerimeter.Click += new System.EventHandler(this.LblAPerimeter_Click);
            // 
            // btnQArea
            // 
            this.btnQArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQArea.Location = new System.Drawing.Point(12, 138);
            this.btnQArea.Name = "btnQArea";
            this.btnQArea.Size = new System.Drawing.Size(277, 92);
            this.btnQArea.TabIndex = 2;
            this.btnQArea.Text = "Calculate the area of a circle with radius of 7cm ";
            this.btnQArea.UseVisualStyleBackColor = true;
            this.btnQArea.Click += new System.EventHandler(this.BtnQArea_Click);
            // 
            // btnQVolume
            // 
            this.btnQVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQVolume.Location = new System.Drawing.Point(12, 269);
            this.btnQVolume.Name = "btnQVolume";
            this.btnQVolume.Size = new System.Drawing.Size(277, 97);
            this.btnQVolume.TabIndex = 3;
            this.btnQVolume.Text = "Calculate the volume of a sphere with radius 4cm";
            this.btnQVolume.UseVisualStyleBackColor = true;
            this.btnQVolume.Click += new System.EventHandler(this.BtnQVolume_Click);
            // 
            // lblAArea
            // 
            this.lblAArea.AutoSize = true;
            this.lblAArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAArea.Location = new System.Drawing.Point(327, 172);
            this.lblAArea.Name = "lblAArea";
            this.lblAArea.Size = new System.Drawing.Size(40, 24);
            this.lblAArea.TabIndex = 4;
            this.lblAArea.Text = "???";
            this.lblAArea.Click += new System.EventHandler(this.LblAArea_Click);
            // 
            // lblAVolume
            // 
            this.lblAVolume.AutoSize = true;
            this.lblAVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVolume.Location = new System.Drawing.Point(327, 305);
            this.lblAVolume.Name = "lblAVolume";
            this.lblAVolume.Size = new System.Drawing.Size(40, 24);
            this.lblAVolume.TabIndex = 5;
            this.lblAVolume.Text = "???";
            this.lblAVolume.Click += new System.EventHandler(this.LblAVolume_Click);
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAVolume);
            this.Controls.Add(this.lblAArea);
            this.Controls.Add(this.btnQVolume);
            this.Controls.Add(this.btnQArea);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.btnQPerimeter);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Ethan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQPerimeter;
        private System.Windows.Forms.Label lblAPerimeter;
        private System.Windows.Forms.Button btnQArea;
        private System.Windows.Forms.Button btnQVolume;
        private System.Windows.Forms.Label lblAArea;
        private System.Windows.Forms.Label lblAVolume;
    }
}

