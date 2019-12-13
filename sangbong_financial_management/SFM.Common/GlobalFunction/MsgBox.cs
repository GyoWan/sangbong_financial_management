using System;
using System.Windows.Forms;

namespace sangbong_financial_management.SFM.Common.GlobalFunction
{
    public static class MsgBox
    {
        public static void Error(string message)
        {
            MessageBox.Show(message.Replace("\\n", Environment.NewLine), "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Info(string message)
        {
            MessageBox.Show(message.Replace("\\n", Environment.NewLine), "도움말", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void Warning(string message)
        {
            MessageBox.Show(message.Replace("\\n", Environment.NewLine), "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Ask(string message)
        {
            return MessageBox.Show(message.Replace("\\n", Environment.NewLine), "응답", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
