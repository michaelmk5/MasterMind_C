namespace MasterMind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnverifica = new System.Windows.Forms.Button();
            this.lb_pos = new System.Windows.Forms.Label();
            this.lb_col = new System.Windows.Forms.Label();
            this.col_cor = new System.Windows.Forms.Label();
            this.pos_cor = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_ris = new System.Windows.Forms.Label();
            this.lb_vite = new System.Windows.Forms.Label();
            this.vite_r = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(32, 29);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(138, 29);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(244, 29);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(350, 29);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnverifica
            // 
            this.btnverifica.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnverifica.Location = new System.Drawing.Point(38, 184);
            this.btnverifica.Name = "btnverifica";
            this.btnverifica.Size = new System.Drawing.Size(412, 44);
            this.btnverifica.TabIndex = 4;
            this.btnverifica.Text = "Verifica";
            this.btnverifica.UseVisualStyleBackColor = true;
            this.btnverifica.Click += new System.EventHandler(this.btnverifica_Click);
            // 
            // lb_pos
            // 
            this.lb_pos.AutoSize = true;
            this.lb_pos.Location = new System.Drawing.Point(53, 283);
            this.lb_pos.Name = "lb_pos";
            this.lb_pos.Size = new System.Drawing.Size(132, 20);
            this.lb_pos.TabIndex = 5;
            this.lb_pos.Text = "Posizioni Corrette: ";
            // 
            // lb_col
            // 
            this.lb_col.AutoSize = true;
            this.lb_col.Location = new System.Drawing.Point(316, 283);
            this.lb_col.Name = "lb_col";
            this.lb_col.Size = new System.Drawing.Size(106, 20);
            this.lb_col.TabIndex = 6;
            this.lb_col.Text = "Colori Corretti:";
            // 
            // col_cor
            // 
            this.col_cor.AutoSize = true;
            this.col_cor.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.col_cor.Location = new System.Drawing.Point(322, 317);
            this.col_cor.MinimumSize = new System.Drawing.Size(100, 100);
            this.col_cor.Name = "col_cor";
            this.col_cor.Size = new System.Drawing.Size(100, 100);
            this.col_cor.TabIndex = 7;
            // 
            // pos_cor
            // 
            this.pos_cor.AutoSize = true;
            this.pos_cor.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pos_cor.Location = new System.Drawing.Point(68, 317);
            this.pos_cor.MinimumSize = new System.Drawing.Size(100, 100);
            this.pos_cor.Name = "pos_cor";
            this.pos_cor.Size = new System.Drawing.Size(100, 100);
            this.pos_cor.TabIndex = 8;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(38, 401);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(412, 37);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_ris
            // 
            this.lb_ris.AutoSize = true;
            this.lb_ris.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ris.Location = new System.Drawing.Point(53, 272);
            this.lb_ris.Name = "lb_ris";
            this.lb_ris.Size = new System.Drawing.Size(0, 89);
            this.lb_ris.TabIndex = 10;
            this.lb_ris.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_ris.Visible = false;
            // 
            // lb_vite
            // 
            this.lb_vite.AutoSize = true;
            this.lb_vite.Location = new System.Drawing.Point(211, 283);
            this.lb_vite.Name = "lb_vite";
            this.lb_vite.Size = new System.Drawing.Size(35, 20);
            this.lb_vite.TabIndex = 11;
            this.lb_vite.Text = "Vite";
            // 
            // vite_r
            // 
            this.vite_r.AutoSize = true;
            this.vite_r.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vite_r.Location = new System.Drawing.Point(211, 308);
            this.vite_r.MinimumSize = new System.Drawing.Size(50, 50);
            this.vite_r.Name = "vite_r";
            this.vite_r.Size = new System.Drawing.Size(50, 50);
            this.vite_r.TabIndex = 12;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(111, 142);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(271, 28);
            this.lb_error.TabIndex = 13;
            this.lb_error.Text = " Devi selezionare tutti i colori!";
            this.lb_error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.vite_r);
            this.Controls.Add(this.lb_vite);
            this.Controls.Add(this.lb_ris);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pos_cor);
            this.Controls.Add(this.col_cor);
            this.Controls.Add(this.lb_col);
            this.Controls.Add(this.lb_pos);
            this.Controls.Add(this.btnverifica);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btnverifica;
        private Label lb_pos;
        private Label lb_col;
        private Label col_cor;
        private Label pos_cor;
        private Button btn_reset;
        private Label lb_ris;
        private Label lb_vite;
        private Label vite_r;
        private Label lb_error;
    }
}