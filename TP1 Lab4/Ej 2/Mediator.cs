using System;
using System.Collections.Generic;

namespace TP1_Lab4.Ej_2
{
    // Mediator
    interface IChatMediator
    {
        void SendMessage(string message, IUser user);
    }

    // ConcreteMediator
    class ChatMediator : IChatMediator
    {
        public void SendMessage(string message, IUser user)
        {
            Console.WriteLine($"[{user.Name}] says: {message}");
        }
    }

    // Colleague
    interface IUser
    {
        string Name { get; }
        void Send(string message);
        void Receive(string message);
    }

    // ConcreteColleague
    class ChatUser : IUser
    {
        private IChatMediator _mediator;
        public string Name { get; }

        public ChatUser(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }
}

