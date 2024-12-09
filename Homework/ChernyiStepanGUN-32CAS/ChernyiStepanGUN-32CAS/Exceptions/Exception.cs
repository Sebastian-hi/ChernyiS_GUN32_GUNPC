using System;

namespace ChernyiStepanGUN_32CAS.Exceptions
{
    public class WrongDiceNumberException : Exception
    {
        public WrongDiceNumberException(int number, int min, int max) 
            : base($"Неправильное значение: {number}. Должно быть между {min} и {max}.") {}
    }
}
