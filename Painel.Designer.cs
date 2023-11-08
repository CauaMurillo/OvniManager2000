namespace OVNIManager2000
{
    partial class Painel
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnAddTri = new System.Windows.Forms.Button();
            this.btnRemTri = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabiduzir = new System.Windows.Forms.Button();
            this.btnRetornOrigem = new System.Windows.Forms.Button();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(33, 29);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(262, 177);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(6, 34);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(79, 21);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(6, 75);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(98, 21);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abiduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(6, 110);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(98, 21);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(33, 208);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(262, 46);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(33, 260);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(262, 41);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "DESLIGAR";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnAddTri
            // 
            this.btnAddTri.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTri.Location = new System.Drawing.Point(301, 29);
            this.btnAddTri.Name = "btnAddTri";
            this.btnAddTri.Size = new System.Drawing.Size(188, 43);
            this.btnAddTri.TabIndex = 3;
            this.btnAddTri.Text = "Adicionar Tripulante";
            this.btnAddTri.UseVisualStyleBackColor = true;
            this.btnAddTri.Click += new System.EventHandler(this.btnAddTri_Click);
            // 
            // btnRemTri
            // 
            this.btnRemTri.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemTri.Location = new System.Drawing.Point(301, 75);
            this.btnRemTri.Name = "btnRemTri";
            this.btnRemTri.Size = new System.Drawing.Size(188, 40);
            this.btnRemTri.TabIndex = 4;
            this.btnRemTri.Text = "Remover Tripulante";
            this.btnRemTri.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbduzir.Location = new System.Drawing.Point(301, 117);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(188, 43);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abdudzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabiduzir
            // 
            this.btnDesabiduzir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabiduzir.Location = new System.Drawing.Point(301, 165);
            this.btnDesabiduzir.Name = "btnDesabiduzir";
            this.btnDesabiduzir.Size = new System.Drawing.Size(188, 40);
            this.btnDesabiduzir.TabIndex = 6;
            this.btnDesabiduzir.Text = "Desabiduzir";
            this.btnDesabiduzir.UseVisualStyleBackColor = true;
            // 
            // btnRetornOrigem
            // 
            this.btnRetornOrigem.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornOrigem.Location = new System.Drawing.Point(301, 208);
            this.btnRetornOrigem.Name = "btnRetornOrigem";
            this.btnRetornOrigem.Size = new System.Drawing.Size(188, 42);
            this.btnRetornOrigem.TabIndex = 7;
            this.btnRetornOrigem.Text = "Retorna a Origem";
            this.btnRetornOrigem.UseVisualStyleBackColor = true;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(301, 258);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(121, 45);
            this.cmbPlaneta.TabIndex = 8;
            // 
            // btnMudar
            // 
            this.btnMudar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.Location = new System.Drawing.Point(428, 258);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(60, 44);
            this.btnMudar.TabIndex = 9;
            this.btnMudar.Text = "Mudar";
            this.btnMudar.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(10, 145);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(71, 21);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 307);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.btnRetornOrigem);
            this.Controls.Add(this.btnDesabiduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRemTri);
            this.Controls.Add(this.btnAddTri);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.grbDados);
            this.Name = "Painel";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnAddTri;
        private System.Windows.Forms.Button btnRemTri;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabiduzir;
        private System.Windows.Forms.Button btnRetornOrigem;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.Label lblPlaneta;
    }
}