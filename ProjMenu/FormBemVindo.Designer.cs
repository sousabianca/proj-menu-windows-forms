
namespace ProjMenu
{
    partial class FormBemVindo
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.grbInsert = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpAtualizar = new System.Windows.Forms.GroupBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbID = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grbRemover = new System.Windows.Forms.GroupBox();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grbInsert.SuspendLayout();
            this.grpAtualizar.SuspendLayout();
            this.grbID.SuspendLayout();
            this.grbRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(333, 26);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(372, 24);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem vindo(a) à área do funcionário!";
            // 
            // grbInsert
            // 
            this.grbInsert.Controls.Add(this.btnAdicionar);
            this.grbInsert.Controls.Add(this.txbDesc);
            this.grbInsert.Controls.Add(this.txbNum);
            this.grbInsert.Controls.Add(this.txbNome);
            this.grbInsert.Controls.Add(this.lblDesc);
            this.grbInsert.Controls.Add(this.lblNum);
            this.grbInsert.Controls.Add(this.lblNome);
            this.grbInsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInsert.Location = new System.Drawing.Point(12, 87);
            this.grbInsert.Name = "grbInsert";
            this.grbInsert.Size = new System.Drawing.Size(300, 291);
            this.grbInsert.TabIndex = 1;
            this.grbInsert.TabStop = false;
            this.grbInsert.Text = "Adicionar Quarto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(89, 247);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(21, 209);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(181, 22);
            this.txbDesc.TabIndex = 5;
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(21, 137);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(76, 22);
            this.txbNum.TabIndex = 4;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(21, 67);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(181, 22);
            this.txbNome.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(18, 174);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(70, 16);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descrição";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(18, 106);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 16);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Número";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // grpAtualizar
            // 
            this.grpAtualizar.Controls.Add(this.txbID);
            this.grpAtualizar.Controls.Add(this.label4);
            this.grpAtualizar.Controls.Add(this.btnAtualizar);
            this.grpAtualizar.Controls.Add(this.textBox1);
            this.grpAtualizar.Controls.Add(this.textBox2);
            this.grpAtualizar.Controls.Add(this.textBox3);
            this.grpAtualizar.Controls.Add(this.label1);
            this.grpAtualizar.Controls.Add(this.label2);
            this.grpAtualizar.Controls.Add(this.label3);
            this.grpAtualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAtualizar.Location = new System.Drawing.Point(12, 412);
            this.grpAtualizar.Name = "grpAtualizar";
            this.grpAtualizar.Size = new System.Drawing.Size(300, 336);
            this.grpAtualizar.TabIndex = 2;
            this.grpAtualizar.TabStop = false;
            this.grpAtualizar.Text = "Atualizar Quarto";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(21, 274);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(67, 22);
            this.txbID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID do quarto";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(89, 302);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(88, 23);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Adicionar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // grbID
            // 
            this.grbID.Controls.Add(this.btnRemover);
            this.grbID.Controls.Add(this.txbDelete);
            this.grbID.Controls.Add(this.lblID);
            this.grbID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbID.Location = new System.Drawing.Point(456, 87);
            this.grbID.Name = "grbID";
            this.grbID.Size = new System.Drawing.Size(300, 176);
            this.grbID.TabIndex = 3;
            this.grbID.TabStop = false;
            this.grbID.Text = "Remover Quarto";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(108, 121);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(88, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(108, 67);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(88, 22);
            this.txbDelete.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(119, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Quarto";
            // 
            // grbRemover
            // 
            this.grbRemover.Controls.Add(this.dgvSelect);
            this.grbRemover.Controls.Add(this.btnSelect);
            this.grbRemover.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRemover.Location = new System.Drawing.Point(456, 311);
            this.grbRemover.Name = "grbRemover";
            this.grbRemover.Size = new System.Drawing.Size(446, 378);
            this.grbRemover.TabIndex = 4;
            this.grbRemover.TabStop = false;
            this.grbRemover.Text = "Visualizar Quarto";
            // 
            // dgvSelect
            // 
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Location = new System.Drawing.Point(27, 39);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.Size = new System.Drawing.Size(401, 275);
            this.dgvSelect.TabIndex = 7;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(197, 331);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Visualizar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FormBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.grbRemover);
            this.Controls.Add(this.grbID);
            this.Controls.Add(this.grpAtualizar);
            this.Controls.Add(this.grbInsert);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "FormBemVindo";
            this.Text = "Bem Vindo(a)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBemVindo_FormClosed);
            this.Load += new System.EventHandler(this.FormBemVindo_Load);
            this.grbInsert.ResumeLayout(false);
            this.grbInsert.PerformLayout();
            this.grpAtualizar.ResumeLayout(false);
            this.grpAtualizar.PerformLayout();
            this.grbID.ResumeLayout(false);
            this.grbID.PerformLayout();
            this.grbRemover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.GroupBox grbInsert;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpAtualizar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbID;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grbRemover;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button btnSelect;
    }
}