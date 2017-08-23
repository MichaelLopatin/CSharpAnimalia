using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class MammaliaException : Exception
    {
        private int errorCode; // Код ошибки

        public MammaliaException(string errMessage) : base(errMessage) //Вызываем конструктор базового класса
        {
        }

        //Принимает сообщение с описание ошибки, и код ошибки
        public MammaliaException(string errMessage, int errorCode) : base(errMessage) //Вызываем конструктор базового класса
        {
            this.errorCode = errorCode;
        }

        //Возвращает код ошибки
        public int ErrorCode
        {
            get
            {
                return errorCode;
            }
        }
    }
}
