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
            textBoxUnicode.TextChanged += TextBoxUnicode_TextChanged;
        }

        private void TextBoxUnicode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUnicode.Focused)
            {
                textBoxChar.Text = UniToChar(textBoxUnicode.Text);
            }
        }

        private void TextBoxChar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxChar.Focused)
            {
                textBoxUnicode.Text = CharToUnicode(textBoxChar.Text);
            }
        }
        private string UniToChar(string text)
        {
            string result = "";
            string wd = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\r' || text[i] == '\n' || text[i] == ' ' || text[i] == '\t')
                {
                    result += PString(wd);
                    wd = "";
                    result += text[i];
                }
                else
                {
                    wd += text[i];
                    if (i == text.Length - 1)
                    {
                        result += PString(wd);
                    }
                }

            }
            return result;
        }

        private string PString(string wd)
        {
            string result = "";
            string[] vs = wd.Split(new string[] { textBoxPrefix.Text }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in vs)
            {
                try
                {
                    result += char.ConvertFromUtf32(int.Parse(item, System.Globalization.NumberStyles.HexNumber));
                }
                catch (Exception)
                {
                    result += item;
                }
            }
            return result;
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
