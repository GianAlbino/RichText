using System;
using System.Drawing;
using System.Windows.Forms;

namespace RichText
{
    public partial class RichText : Form
    {
        public RichText()
        {
            InitializeComponent();

            cb_font.Items.Add("Segoe UI");
            cb_font.Items.Add("Arial");
            cb_font.Items.Add("Arial Black");
            cb_font.Items.Add("Calibri");

            cb_numero.Items.Add(8);
            cb_numero.Items.Add(9);
            cb_numero.Items.Add(10);
            cb_numero.Items.Add(11);
            cb_numero.Items.Add(12);
            cb_numero.Items.Add(13);
            cb_numero.Items.Add(14);
            cb_numero.Items.Add(15);

            cb_font.Text = cb_font.Items[0].ToString();
            cb_numero.Text = cb_numero.Items[0].ToString();

            cb_font.SelectedIndexChanged += new EventHandler(Cb_font_SelectedIndexChanged);
            cb_numero.SelectedIndexChanged += new EventHandler(Cb_numero_SelectedIndexChanged);
        }

        private void Btn_negrito_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Bold);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Bold);
            }
        }

        private void Btn_italico_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Italic);
            }
        }

        private void Btn_sublinhado_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Underline);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Underline);
            }
        }

        private void Btn_riscado_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Strikeout);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Strikeout);
            }
        }

        private void Cb_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    richTextBox1.SelectionFont.Style);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    richTextBox1.Font.Style);
            }
        }

        private void Cb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    richTextBox1.SelectionFont.Style);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    richTextBox1.Font.Style);
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Regular);
            }
            else
            {
                richTextBox1.Font =
                    new Font(cb_font.Text.ToString(),
                    Convert.ToInt32(cb_numero.Text.ToString()),
                    FontStyle.Regular);
            }
        }
    }
}
