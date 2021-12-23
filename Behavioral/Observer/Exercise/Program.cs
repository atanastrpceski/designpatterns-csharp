using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Game
    {
        public event EventHandler RatEnters, RatDies;
        public event EventHandler<Rat> NotifyRat;

        public void FireRatEnters(object sender)
        {
            RatEnters?.Invoke(sender, EventArgs.Empty);
        }

        public void FireRatDies(object sender)
        {
            RatDies?.Invoke(sender, EventArgs.Empty);
        }

        public void FireNotifyRat(object sender, Rat whichRat)
        {
            NotifyRat?.Invoke(sender, whichRat);
        }
    }

    public class Rat : IDisposable
    {
        private readonly Game game;
        public int Attack = 1;

        public Rat(Game game)
        {
            this.game = game;

            game.RatEnters += OnRatEnters;
            game.NotifyRat += OnGameOnNotifyRat;
            game.RatDies += OnGameOnRatDies;

            game.FireRatEnters(this);
        }

        private void OnRatEnters(object sender, EventArgs args)
        {
            if (sender == this)
                return;

            ++Attack;
            game.FireNotifyRat(this, (Rat)sender);
        }

        private void OnGameOnRatDies(object sender, EventArgs args)
        {
            --Attack;
        }

        private void OnGameOnNotifyRat(object sender, Rat rat)
        {
            if (rat == this) 
                ++Attack;
        }

        public void Dispose()
        {
            game.FireRatDies(this);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var rat = new Rat(game);
        }
    }
}



