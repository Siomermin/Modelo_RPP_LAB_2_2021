
namespace UI_Electrodomesticos
{
    partial class FrmPrincipal
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
            this.rtbCatalogo = new System.Windows.Forms.RichTextBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.rtbOfertas = new System.Windows.Forms.RichTextBox();
            this.lblOfertas = new System.Windows.Forms.Label();
            this.btnOferta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbCatalogo
            // 
            this.rtbCatalogo.Location = new System.Drawing.Point(54, 65);
            this.rtbCatalogo.Name = "rtbCatalogo";
            this.rtbCatalogo.Size = new System.Drawing.Size(321, 361);
            this.rtbCatalogo.TabIndex = 0;
            this.rtbCatalogo.Text = "";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.BackColor = System.Drawing.Color.Black;
            this.lblCatalogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatalogo.ForeColor = System.Drawing.Color.Maroon;
            this.lblCatalogo.Location = new System.Drawing.Point(116, 37);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(101, 25);
            this.lblCatalogo.TabIndex = 1;
            this.lblCatalogo.Text = "CATALOGO";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Titulo.Location = new System.Drawing.Point(293, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(229, 25);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Electrodomesticos PEPOSO";
            // 
            // rtbOfertas
            // 
            this.rtbOfertas.Location = new System.Drawing.Point(445, 65);
            this.rtbOfertas.Name = "rtbOfertas";
            this.rtbOfertas.Size = new System.Drawing.Size(321, 224);
            this.rtbOfertas.TabIndex = 3;
            this.rtbOfertas.Text = "";
            // 
            // lblOfertas
            // 
            this.lblOfertas.AutoSize = true;
            this.lblOfertas.BackColor = System.Drawing.Color.Black;
            this.lblOfertas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOfertas.ForeColor = System.Drawing.Color.Maroon;
            this.lblOfertas.Location = new System.Drawing.Point(624, 37);
            this.lblOfertas.Name = "lblOfertas";
            this.lblOfertas.Size = new System.Drawing.Size(84, 25);
            this.lblOfertas.TabIndex = 4;
            this.lblOfertas.Text = "OFERTAS";
            // 
            // btnOferta
            // 
            this.btnOferta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOferta.ForeColor = System.Drawing.Color.Maroon;
            this.btnOferta.Location = new System.Drawing.Point(585, 318);
            this.btnOferta.Name = "btnOferta";
            this.btnOferta.Size = new System.Drawing.Size(180, 57);
            this.btnOferta.TabIndex = 5;
            this.btnOferta.Text = "Nueva oferta";
            this.btnOferta.UseVisualStyleBackColor = true;
            this.btnOferta.Click += new System.EventHandler(this.btnOferta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOferta);
            this.Controls.Add(this.lblOfertas);
            this.Controls.Add(this.rtbOfertas);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.rtbCatalogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Gonzalez Fermin";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCatalogo;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.RichTextBox rtbOfertas;
        private System.Windows.Forms.Label lblOfertas;
        private System.Windows.Forms.Button btnOferta;
    }
}

