﻿namespace Biblioteca
{
    partial class F_Novousuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.nm_nivel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(71, 49);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(196, 23);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(71, 133);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(133, 23);
            this.tb_senha.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(273, 49);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(176, 23);
            this.tb_username.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(210, 131);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(131, 23);
            this.cb_status.TabIndex = 6;
            // 
            // nm_nivel
            // 
            this.nm_nivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nm_nivel.Location = new System.Drawing.Point(347, 132);
            this.nm_nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nm_nivel.Name = "nm_nivel";
            this.nm_nivel.Size = new System.Drawing.Size(120, 23);
            this.nm_nivel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nivel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "A=Ativo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "B=Bloqueado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "D=Desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 35);
            this.panel1.TabIndex = 13;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(447, 5);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(192, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(98, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(3, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // F_Novousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nm_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Novousuario";
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.nm_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_nome;
        private Label label2;
        private TextBox tb_senha;
        private TextBox tb_username;
        private Label label3;
        private ComboBox cb_status;
        private NumericUpDown nm_nivel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_cancelar;
        private Button btn_salvar;
        private Button btn_novo;
    }
}