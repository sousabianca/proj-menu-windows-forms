
namespace ProjMenu
{
    partial class frmAjuda
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
            this.lblSemAjuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSemAjuda
            // 
            this.lblSemAjuda.AutoSize = true;
            this.lblSemAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemAjuda.Location = new System.Drawing.Point(74, 126);
            this.lblSemAjuda.Name = "lblSemAjuda";
            this.lblSemAjuda.Size = new System.Drawing.Size(481, 24);
            this.lblSemAjuda.TabIndex = 0;
            this.lblSemAjuda.Text = "Entre em contato conosco via Whatsapp (12)99876-8778";
            this.lblSemAjuda.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 323);
            this.Controls.Add(this.lblSemAjuda);
            this.Name = "frmAjuda";
            this.Text = "Ajuda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAjuda_FormClosed);
            this.Load += new System.EventHandler(this.frmAjuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemAjuda;
    }
}