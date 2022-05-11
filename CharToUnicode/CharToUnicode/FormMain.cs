using System;
using System.Windows.Forms;

namespace CharToUnicode
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxChar.TextChanged += TextBoxChar_TextChanged;
            checkBoxReturn.CheckedChanged += TextBoxChar_TextChanged;
            checkBoxSpace.CheckedChanged += TextBoxChar_TextChanged;
            checkBoxTab.CheckedChanged += TextBoxChar_TextChanged;
            checkBoxUppercase.CheckedChanged += TextBoxChar_TextChanged;
            textBoxPrefix.TextChanged += TextBoxChar_TextChanged;
        }

        private void TextBoxChar_TextChanged(object sender, EventArgs e)
        {
            textBoxUnicode.Text = CharToUnicode(textBoxChar.Text);
        }

        private string CharToUnicode(string text)
        {
            string result = "";
            System.Globalization.TextElementEnumerator t = System.Globalization.StringInfo.GetTextElementEnumerator(text);
            while (t.MoveNext())
            {
                string s = t.GetTextElement();
                if ((checkBoxReturn.Checked && (s == "\r" || s == "\n")) || (checkBoxSpace.Checked && s == " ") || (checkBoxTab.Checked && s == "\t"))
                {
                    result += s;
                }
                else
                {
                    uint unicode = s.Length == 1 ? s[0] : 0x10000 + ((s[0] & 0x3ffu) << 10) + (s[1] & 0x3ffu);
                    string hex = Convert.ToString(unicode, 16);
                    result += checkBoxUppercase.Checked ? textBoxPrefix.Text + hex.ToUpper() : textBoxPrefix.Text + hex;
                }
            }
            return result;
        }
    }
}
