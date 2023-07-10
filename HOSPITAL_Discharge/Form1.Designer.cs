namespace HOSPITAL_Discharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button9 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Thistle;
            this.button9.Location = new System.Drawing.Point(626, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(257, 226);
            this.button9.TabIndex = 19;
            this.button9.Text = "ترخیص";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Thistle;
            this.button14.Location = new System.Drawing.Point(261, 166);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(257, 226);
            this.button14.TabIndex = 20;
            this.button14.Text = " خروج از برنامه";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
    }
}

