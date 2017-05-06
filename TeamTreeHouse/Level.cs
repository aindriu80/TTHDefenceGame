﻿namespace TeamTreeHouse
{
    public class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        // Returns true if player wins , false otherwise
        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    invader.Move();

                    if (invader.HasScored)
                    {
                        return false;
                    }

                    remainingInvaders++;
                }
            }
            return true;
        }

    }
}
