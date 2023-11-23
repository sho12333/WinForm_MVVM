using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_MVVM.Services.Messages
{
    public interface IMessageService
    {
        DialogResult ShowError(string message);

        DialogResult ShowWarning(string message);

        DialogResult ShowInfo(string message);

        DialogResult AskForConfirmation(string message);
    }
}