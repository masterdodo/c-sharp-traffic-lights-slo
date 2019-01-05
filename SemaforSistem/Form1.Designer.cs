namespace SemaforSistem
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
            this.components = new System.ComponentModel.Container();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.startbutton = new System.Windows.Forms.Button();
            this.redlightfoot = new System.Windows.Forms.PictureBox();
            this.greenlightfoot = new System.Windows.Forms.PictureBox();
            this.greenlightcar = new System.Windows.Forms.PictureBox();
            this.orangelightcar = new System.Windows.Forms.PictureBox();
            this.redlightcar = new System.Windows.Forms.PictureBox();
            this.stopbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redlightfoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlightfoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlightcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangelightcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redlightcar)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbutton
            // 
            this.cancelbutton.FlatAppearance.BorderSize = 0;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Location = new System.Drawing.Point(682, 2);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(38, 23);
            this.cancelbutton.TabIndex = 0;
            this.cancelbutton.Text = "x";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // minimizebutton
            // 
            this.minimizebutton.FlatAppearance.BorderSize = 0;
            this.minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebutton.Location = new System.Drawing.Point(638, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(38, 23);
            this.minimizebutton.TabIndex = 1;
            this.minimizebutton.Text = "_";
            this.minimizebutton.UseVisualStyleBackColor = true;
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(638, 31);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 54);
            this.startbutton.TabIndex = 5;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // redlightfoot
            // 
            this.redlightfoot.Image = global::SemaforSistem.Properties.Resources.redlight_stoplight1;
            this.redlightfoot.Location = new System.Drawing.Point(387, 27);
            this.redlightfoot.Name = "redlightfoot";
            this.redlightfoot.Size = new System.Drawing.Size(245, 417);
            this.redlightfoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redlightfoot.TabIndex = 7;
            this.redlightfoot.TabStop = false;
            // 
            // greenlightfoot
            // 
            this.greenlightfoot.Image = global::SemaforSistem.Properties.Resources.greenlight_stoplight1;
            this.greenlightfoot.Location = new System.Drawing.Point(387, 27);
            this.greenlightfoot.Name = "greenlightfoot";
            this.greenlightfoot.Size = new System.Drawing.Size(245, 417);
            this.greenlightfoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenlightfoot.TabIndex = 6;
            this.greenlightfoot.TabStop = false;
            // 
            // greenlightcar
            // 
            this.greenlightcar.Image = global::SemaforSistem.Properties.Resources.greenlight_stoplight;
            this.greenlightcar.Location = new System.Drawing.Point(78, 27);
            this.greenlightcar.Name = "greenlightcar";
            this.greenlightcar.Size = new System.Drawing.Size(245, 417);
            this.greenlightcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenlightcar.TabIndex = 4;
            this.greenlightcar.TabStop = false;
            // 
            // orangelightcar
            // 
            this.orangelightcar.Image = global::SemaforSistem.Properties.Resources.orangelight_stoplight;
            this.orangelightcar.Location = new System.Drawing.Point(78, 27);
            this.orangelightcar.Name = "orangelightcar";
            this.orangelightcar.Size = new System.Drawing.Size(245, 417);
            this.orangelightcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orangelightcar.TabIndex = 3;
            this.orangelightcar.TabStop = false;
            // 
            // redlightcar
            // 
            this.redlightcar.Image = global::SemaforSistem.Properties.Resources.redlight_stoplight;
            this.redlightcar.Location = new System.Drawing.Point(78, 27);
            this.redlightcar.Name = "redlightcar";
            this.redlightcar.Size = new System.Drawing.Size(245, 417);
            this.redlightcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redlightcar.TabIndex = 2;
            this.redlightcar.TabStop = false;
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(638, 91);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 54);
            this.stopbutton.TabIndex = 8;
            this.stopbutton.Text = "STOP";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.redlightfoot);
            this.Controls.Add(this.greenlightfoot);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.greenlightcar);
            this.Controls.Add(this.orangelightcar);
            this.Controls.Add(this.redlightcar);
            this.Controls.Add(this.minimizebutton);
            this.Controls.Add(this.cancelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redlightfoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlightfoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlightcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangelightcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redlightcar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button minimizebutton;
        private System.Windows.Forms.PictureBox redlightcar;
        private System.Windows.Forms.PictureBox orangelightcar;
        private System.Windows.Forms.PictureBox greenlightcar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.PictureBox greenlightfoot;
        private System.Windows.Forms.PictureBox redlightfoot;
        private System.Windows.Forms.Button stopbutton;
    }
}

