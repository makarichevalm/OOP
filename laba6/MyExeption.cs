using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    internal class MyException : InvalidCastException
    {
        public MyException(string message, DateTime date) :
            base("Ошибка из моего исключения со следующим текстом: " + message)
        {
            Date = date;
        }
        public DateTime Date { get; }
    }
}
