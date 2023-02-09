namespace SpringFieldNuclear
{
    partial class Form1
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
            this.labeltop = new System.Windows.Forms.Label();
            this.Reactoer1 = new System.Windows.Forms.Label();
            this.Reactoer2 = new System.Windows.Forms.Label();
            this.Reactoer1green = new System.Windows.Forms.Label();
            this.Reactoer2green = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltop
            // 
            this.labeltop.AutoSize = true;
            this.labeltop.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltop.ForeColor = System.Drawing.Color.Fuchsia;
            this.labeltop.Location = new System.Drawing.Point(130, 9);
            this.labeltop.Name = "labeltop";
            this.labeltop.Size = new System.Drawing.Size(447, 26);
            this.labeltop.TabIndex = 0;
            this.labeltop.Text = "Nuclear reactor control";
            this.labeltop.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reactoer1
            // 
            this.Reactoer1.AutoSize = true;
            this.Reactoer1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactoer1.Location = new System.Drawing.Point(129, 85);
            this.Reactoer1.Name = "Reactoer1";
            this.Reactoer1.Size = new System.Drawing.Size(142, 34);
            this.Reactoer1.TabIndex = 1;
            this.Reactoer1.Text = "Reactoer 1";
            this.Reactoer1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reactoer2
            // 
            this.Reactoer2.AutoSize = true;
            this.Reactoer2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactoer2.Location = new System.Drawing.Point(435, 85);
            this.Reactoer2.Name = "Reactoer2";
            this.Reactoer2.Size = new System.Drawing.Size(146, 34);
            this.Reactoer2.TabIndex = 3;
            this.Reactoer2.Text = "Reactoer 2";
            this.Reactoer2.Click += new System.EventHandler(this.label4_Click);
            // 
            // Reactoer1green
            // 
            this.Reactoer1green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Reactoer1green.Location = new System.Drawing.Point(132, 146);
            this.Reactoer1green.Name = "Reactoer1green";
            this.Reactoer1green.Size = new System.Drawing.Size(136, 65);
            this.Reactoer1green.TabIndex = 4;
            // 
            // Reactoer2green
            // 
            this.Reactoer2green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Reactoer2green.Location = new System.Drawing.Point(441, 146);
            this.Reactoer2green.Name = "Reactoer2green";
            this.Reactoer2green.Size = new System.Drawing.Size(136, 65);
            this.Reactoer2green.TabIndex = 5;
            this.Reactoer2green.Click += new System.EventHandler(this.Reactoer2green_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(263, 214);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(188, 23);
            this.Startbutton.TabIndex = 6;
            this.Startbutton.Text = "Start Reactor";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OutputLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.OutputLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(132, 272);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(445, 46);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.Text = "Reactor Stable";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(686, 327);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Reactoer2green);
            this.Controls.Add(this.Reactoer1green);
            this.Controls.Add(this.Reactoer2);
            this.Controls.Add(this.Reactoer1);
            this.Controls.Add(this.labeltop);
            this.Name = "Form1";
            this.Text = "Springfield Nuclear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltop;
        private System.Windows.Forms.Label Reactoer1;
        private System.Windows.Forms.Label Reactoer2;
        private System.Windows.Forms.Label Reactoer1green;
        private System.Windows.Forms.Label Reactoer2green;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

