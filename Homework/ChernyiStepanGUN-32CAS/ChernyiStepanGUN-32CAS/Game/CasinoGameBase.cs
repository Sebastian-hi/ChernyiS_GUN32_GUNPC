using System;

namespace ChernyiStepanGUN_32CAS.Game
{
    public abstract class CasinoGameBase
    {
        public abstract void PlayGame();

        public delegate void MethodContainer();

        public event MethodContainer OnWin;
        public event MethodContainer OnLoose;
        public event MethodContainer OnDraw;

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


        abstract protected void FactoryMethod();


    }


}
