using System;
using System.Windows.Forms;

namespace CharToUnicode
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            string result = "";
            System.Globalization.TextElementEnumerator t = System.Globalization.StringInfo.GetTextElementEnumerator(textBoxChar.Text);
            while (t.MoveNext())
            {
                string s = t.GetTextElement();
                if ((!checkBoxReturn.Checked && (s == "\r" || s == "\n")) || (!checkBoxSpace.Checked && s == " ") || (!checkBoxTab.Checked && s == "\t"))
                {
                    result += s;
                }
                else
                {
                    uint unicode = s.Length == 1 ? s[0] : 0x10000 + ((s[0] & 0x3ffu) << 10) + (s[1] & 0x3ffu);
                    result += "u" + Convert.ToString(unicode, 16);
                }
            }
            textBoxUnicode.Text = result;
        }
    }
}
