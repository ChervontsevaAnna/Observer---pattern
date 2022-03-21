using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteSubject : Subject
    {
        private List<Observer> people = new List<Observer>();
        public void notifyObservers()
        {
            foreach (var i in people)
            {
                i.update();
            }
        }

        public void registerObserver(Observer observer)
        {
            people.Add(observer);
        }

        public void removeObserver(Observer observer)
        {
            people.Remove(observer);
        }
        string state;
        public string State
        {
            get { return state; }
            set { state = value; notifyObservers(); }
        }
    }
}
