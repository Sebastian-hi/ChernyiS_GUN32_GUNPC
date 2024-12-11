using System;

namespace ChernyiStepanGUN_32CAS.Game
{
    public abstract class CasinoGameBase
    {
        public abstract void PlayGame();

        public delegate void MethodContainer();

        private event MethodContainer OnWin;
        private event MethodContainer OnLoose;
        private event MethodContainer OnDraw;

        protected void OnWinInvoke()
        {
            OnWin();
        }
        protected void OnLooseInvoke()
        {
            OnLoose();
        }
        protected void OnDrawInvoke()
        {
            OnDraw();
        }


        private abstract protected void FactoryMethod();
    }
}
