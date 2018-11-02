namespace Editor
{
    partial class Form_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Info));
            this.LBL_Info1 = new System.Windows.Forms.Label();
            this.LBL_Info2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Info1
            // 
            this.LBL_Info1.AutoSize = true;
            this.LBL_Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Info1.Location = new System.Drawing.Point(38, 28);
            this.LBL_Info1.Name = "LBL_Info1";
            this.LBL_Info1.Size = new System.Drawing.Size(230, 26);
            this.LBL_Info1.TabIndex = 0;
            this.LBL_Info1.Text = "(c) 2018 by Chaos Inc.";
            // 
            // LBL_Info2
            // 
            this.LBL_Info2.AutoSize = true;
            this.LBL_Info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LBL_Info2.Location = new System.Drawing.Point(-1, 75);
            this.LBL_Info2.Name = "LBL_Info2";
            this.LBL_Info2.Size = new System.Drawing.Size(303, 17);
            this.LBL_Info2.TabIndex = 1;
            this.LBL_Info2.Text = "Written by Alexander Jung for an schoolproject";
            // 
            // Form_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 153);
            this.Controls.Add(this.LBL_Info2);
            this.Controls.Add(this.LBL_Info1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Info1;
        private System.Windows.Forms.Label LBL_Info2;
    }
}