﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderReceiptRepository OrderReceipts { get; }
        int Complete();
    }
}
