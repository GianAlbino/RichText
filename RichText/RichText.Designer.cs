
namespace RichText
{
    partial class RichText
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
            this.btn_negrito = new System.Windows.Forms.Button();
            this.btn_italico = new System.Windows.Forms.Button();
            this.btn_sublinhado = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cb_font = new System.Windows.Forms.ComboBox();
            this.cb_numero = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_riscado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_negrito
            // 
            this.btn_negrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_negrito.Location = new System.Drawing.Point(327, 14);
            this.btn_negrito.Name = "btn_negrito";
            this.btn_negrito.Size = new System.Drawing.Size(30, 23);
            this.btn_negrito.TabIndex = 1;
            this.btn_negrito.Text = "N";
            this.btn_negrito.UseVisualStyleBackColor = true;
            this.btn_negrito.Click += new System.EventHandler(this.Btn_negrito_Click);
            // 
            // btn_italico
            // 
            this.btn_italico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_italico.Location = new System.Drawing.Point(363, 14);
            this.btn_italico.Name = "btn_italico";
            this.btn_italico.Size = new System.Drawing.Size(30, 23);
            this.btn_italico.TabIndex = 2;
            this.btn_italico.Text = "I";
            this.btn_italico.UseVisualStyleBackColor = true;
            this.btn_italico.Click += new System.EventHandler(this.Btn_italico_Click);
            // 
            // btn_sublinhado
            // 
            this.btn_sublinhado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btn_sublinhado.Location = new System.Drawing.Point(399, 14);
            this.btn_sublinhado.Name = "btn_sublinhado";
            this.btn_sublinhado.Size = new System.Drawing.Size(30, 23);
            this.btn_sublinhado.TabIndex = 3;
            this.btn_sublinhado.Text = "S";
            this.btn_sublinhado.UseVisualStyleBackColor = true;
            this.btn_sublinhado.Click += new System.EventHandler(this.Btn_sublinhado_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(453, 124);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // cb_font
            // 
            this.cb_font.FormattingEnabled = true;
            this.cb_font.Location = new System.Drawing.Point(13, 14);
            this.cb_font.Name = "cb_font";
            this.cb_font.Size = new System.Drawing.Size(121, 23);
            this.cb_font.TabIndex = 5;
            // 
            // cb_numero
            // 
            this.cb_numero.FormattingEnabled = true;
            this.cb_numero.Location = new System.Drawing.Point(140, 14);
            this.cb_numero.Name = "cb_numero";
            this.cb_numero.Size = new System.Drawing.Size(121, 23);
            this.cb_numero.TabIndex = 6;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(267, 14);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(54, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // btn_riscado
            // 
            this.btn_riscado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.btn_riscado.Location = new System.Drawing.Point(435, 14);
            this.btn_riscado.Name = "btn_riscado";
            this.btn_riscado.Size = new System.Drawing.Size(30, 23);
            this.btn_riscado.TabIndex = 8;
            this.btn_riscado.Text = "R";
            this.btn_riscado.UseVisualStyleBackColor = true;
            this.btn_riscado.Click += new System.EventHandler(this.Btn_riscado_Click);
            // 
            // RichText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 179);
            this.Controls.Add(this.btn_riscado);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cb_numero);
            this.Controls.Add(this.cb_font);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_sublinhado);
            this.Controls.Add(this.btn_italico);
            this.Controls.Add(this.btn_negrito);
            this.Name = "RichText";
            this.Text = "Rich Text";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_negrito;
        private System.Windows.Forms.Button btn_italico;
        private System.Windows.Forms.Button btn_sublinhado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cb_font;
        private System.Windows.Forms.ComboBox cb_numero;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_riscado;
    }
}

