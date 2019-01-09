using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Document : IStorable
    {
         void IStorable.Read()
        {
            System.Console.WriteLine("Read action");
        }

        public void Write(object obj)
        {
            System.Console.WriteLine("Write action");
        }

        public int Status { get; set; }

    }
}
