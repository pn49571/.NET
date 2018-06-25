using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace phoneWord
{
    interface IDialer
    {
        Task<bool> DialAsync(string number);
    }
}
