using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_MVVM.Services.Messages
{
    public class MessageService : IMessageService
    {
        public DialogResult AskForConfirmation(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowInfo(string message)
        {
            return MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowWarning(string message)
        {
            return MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}