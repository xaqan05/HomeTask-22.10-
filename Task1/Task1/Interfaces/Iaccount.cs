﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    internal interface Iaccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
