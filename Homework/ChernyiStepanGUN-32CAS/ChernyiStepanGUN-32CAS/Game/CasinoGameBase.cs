using System;

namespace ChernyiStepanGUN_32CAS.Game
{
    public abstract class CasinoGameBase
    {
        public abstract void PlayGame();

        public delegate void MethodContainer(string message);

        private event MethodContainer? OnWin;
        private event MethodContainer? OnLoose;
        private event MethodContainer? OnDraw;

        protected void OnWinInvoke()
        {
            OnWin?.Invoke("Поздравляем. Победа!");
        }
        protected void OnLooseInvoke()
        {
            OnLoose?.Invoke("Ну, что ж. Повезёт в другой раз. Написать о вреде азартных игр?");
        }
        protected void OnDrawInvoke()
        {
            OnDraw?.Invoke("Вот это да! Ничья. Победила дружба.");
        }


        private abstract protected void FactoryMethod();
    }
}
