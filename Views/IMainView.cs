﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPayModeView;
        event EventHandler PayProductView;
        event EventHandler ShowCustomerView; 
        //Los demas
    }
}