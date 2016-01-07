﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPCConsoleClient
{
  

    public interface ServerClass
    {
        bool LogOn(string username, string password);
        DateTime GetServerTime();
        void OutRandom(out int value);

        Data Return(Data ins);
        int RecComputer(int i);
        float RecComputer2(float i);

        void SendAll(string msg);
        int Add(int a, int b);

        void TestOutAndRef(out int a, ref int b);

        string[] array(string[] z);
    }
}
