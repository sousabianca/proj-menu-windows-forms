
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
            this.lblFunc = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.grbInsert = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grbDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.grbSelect = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbInsert.SuspendLayout();
            this.grbUpdate.SuspendLayout();
            this.grbDelete.SuspendLayout();
            this.grbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(47, 149);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(0, 31);
            this.lblBemVindo.TabIndex = 0;
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.Location = new System.Drawing.Point(252, 25);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(348, 22);
            this.lblFunc.TabIndex = 1;
            this.lblFunc.Text = "Bem-Vindo(a) à área do Funcionário!";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(9, 65);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(180, 22);
            this.txbNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(6, 100);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(123, 16);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Número do quarto";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(9, 133);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(123, 22);
            this.txbNum.TabIndex = 6;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 172);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(9, 207);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(180, 22);
            this.txbDesc.TabIndex = 8;
            // 
            // grbInsert
            // 
            this.grbInsert.Controls.Add(this.btnAdicionar);
            this.grbInsert.Controls.Add(this.lblNome);
            this.grbInsert.Controls.Add(this.txbDesc);
            this.grbInsert.Controls.Add(this.txbNome);
            this.grbInsert.Controls.Add(this.lblDescricao);
            this.grbInsert.Controls.Add(this.lblNum);
            this.grbInsert.Controls.Add(this.txbNum);
            this.grbInsert.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInsert.Location = new System.Drawing.Point(21, 73);
            this.grbInsert.Name = "grbInsert";
            this.grbInsert.Size = new System.Drawing.Size(278, 297);
            this.grbInsert.TabIndex = 9;
            this.grbInsert.TabStop = false;
            this.grbInsert.Text = "Adicionar Quarto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(71, 250);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grbUpdate
            // 
            this.grbUpdate.Controls.Add(this.textBox4);
            this.grbUpdate.Controls.Add(this.label4);
            this.grbUpdate.Controls.Add(this.btnUpdate);
            this.grbUpdate.Controls.Add(this.label1);
            this.grbUpdate.Controls.Add(this.textBox1);
            this.grbUpdate.Controls.Add(this.textBox2);
            this.grbUpdate.Controls.Add(this.label2);
            this.grbUpdate.Controls.Add(this.label3);
            this.grbUpdate.Controls.Add(this.textBox3);
            this.grbUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUpdate.Location = new System.Drawing.Point(21, 405);
            this.grbUpdate.Name = "grbUpdate";
            this.grbUpdate.Size = new System.Drawing.Size(278, 332);
            this.grbUpdate.TabIndex = 10;
            this.grbUpdate.TabStop = false;
            this.grbUpdate.Text = "Atualizar Quarto";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(71, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número do quarto";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Informe o ID do quarto ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 275);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 22);
            this.textBox4.TabIndex = 11;
            // 
            // grbDelete
            // 
            this.grbDelete.Controls.Add(this.btnDelete);
            this.grbDelete.Controls.Add(this.label5);
            this.grbDelete.Controls.Add(this.textBox6);
            this.grbDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDelete.Location = new System.Drawing.Point(377, 85);
            this.grbDelete.Name = "grbDelete";
            this.grbDelete.Size = new System.Drawing.Size(278, 188);
            this.grbDelete.TabIndex = 11;
            this.grbDelete.TabStop = false;
            this.grbDelete.Text = "Remover Quarto";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(82, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selecione o ID do quarto";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(82, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 22);
            this.textBox6.TabIndex = 3;
            // 
            // grbSelect
            // 
            this.grbSelect.Controls.Add(this.dataGridView1);
            this.grbSelect.Controls.Add(this.button1);
            this.grbSelect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelect.Location = new System.Drawing.Point(377, 304);
            this.grbSelect.Name = "grbSelect";
            this.grbSelect.Size = new System.Drawing.Size(393, 367);
            this.grbSelect.TabIndex = 12;
            this.grbSelect.TabStop = false;
            this.grbSelect.Text = "Visualizar Quartos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 268);
            this.dataGridView1.TabIndex = 10;
            // 
            // FormBemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 749);
            this.Controls.Add(this.grbSelect);
            this.Controls.Add(this.grbDelete);
            this.Controls.Add(this.grbUpdate);
            this.Controls.Add(this.grbInsert);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.lblBemVindo);
            this.Name = "FormBemVindo";
            this.Text = "Bem-Vindo(a)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBemVindo_FormClosed);
            this.grbInsert.ResumeLayout(false);
            this.grbInsert.PerformLayout();
            this.grbUpdate.ResumeLayout(false);
            this.grbUpdate.PerformLayout();
            this.grbDelete.ResumeLayout(false);
            this.grbDelete.PerformLayout();
            this.grbSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.GroupBox grbInsert;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox grbSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}