﻿namespace Global.IO.Contracts
{
    using System.Collections.Generic;

    public interface IReader 
    {
        IList<string> Read();
    }
}