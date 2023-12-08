
namespace examencines.Vista
{
    partial class Frmsala
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
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfilsala = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(23, 109);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(755, 232);
            this.dgvempleados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ciudad";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(275, 74);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(155, 20);
            this.txtciudad.TabIndex = 11;
            this.txtciudad.TextChanged += new System.EventHandler(this.txtciudad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cine";
            // 
            // txtfilnombre
            // 
            this.txtfilnombre.Location = new System.Drawing.Point(61, 74);
            this.txtfilnombre.Name = "txtfilnombre";
            this.txtfilnombre.Size = new System.Drawing.Size(135, 20);
            this.txtfilnombre.TabIndex = 9;
            this.txtfilnombre.TextChanged += new System.EventHandler(this.txtfilnombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "sala";
            // 
            // txtfilsala
            // 
            this.txtfilsala.Location = new System.Drawing.Point(513, 74);
            this.txtfilsala.Name = "txtfilsala";
            this.txtfilsala.Size = new System.Drawing.Size(155, 20);
            this.txtfilsala.TabIndex = 13;
            this.txtfilsala.TextChanged += new System.EventHandler(this.txtfilsala_TextChanged);
            // 
            // Frmsala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfilsala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfilnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvempleados);
            this.Name = "Frmsala";
            this.Text = "SALAS";
            this.Load += new System.EventHandler(this.Frmsala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfilnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfilsala;
    }
}