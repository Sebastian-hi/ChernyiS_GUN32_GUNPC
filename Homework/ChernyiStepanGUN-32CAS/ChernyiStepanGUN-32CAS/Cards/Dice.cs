using ChernyiStepanGUN_32CAS.Exceptions;

namespace ChernyiStepanGUN_32CAS.Cards
{
    public struct Dice
    {
        private readonly int _min;
        private readonly int _max;

        Random random = new Random();

        public readonly int Number
        {
            get 
            { 
                return random.Next(_min, _max + 1); 
            }
        }

        public Dice (int min, int max)
        {

            if (min <1 || min>max)
            {
                throw new WrongDiceNumberException(min, 1, int.MaxValue);
            }

            _min = min;
            _max = max;
        }
    }
    
}
