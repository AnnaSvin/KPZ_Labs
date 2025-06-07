using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToe.Patterns
{
    public class GameEventNotifier : Singleton<GameEventNotifier>
    {
        private readonly List<IGameObserver> _observers = new();

        public void Subscribe(IGameObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void Unsubscribe(IGameObserver observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public void NotifyMoveMade(Player player, int row, int col)
        {
            foreach (var observer in _observers)
            {
                observer.OnMoveMade(player, row, col);
            }
        }

        public void NotifyGameReset()
        {
            foreach (var observer in _observers)
            {
                observer.OnGameReset();
            }
        }
    }
}
