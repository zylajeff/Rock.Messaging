﻿using System;

namespace Rock.Messaging
{
    public class ExampleMessagingScenarioFactory : IMessagingScenarioFactory
    {
        private readonly int _intData;

        public ExampleMessagingScenarioFactory()
            : this(0)
        {
        }

        public ExampleMessagingScenarioFactory(int intData = 0)
        {
            _intData = intData;
        }

        public int IntData
        {
            get { return _intData; }
        }

        public ISender CreateQueueProducer(string name)
        {
            throw new NotImplementedException();
        }

        public IReceiver CreateQueueConsumer(string name)
        {
            throw new NotImplementedException();
        }

        public ISender CreateTopicPublisher(string name)
        {
            throw new NotImplementedException();
        }

        public IReceiver CreateTopicSubscriber(string name)
        {
            throw new NotImplementedException();
        }

        public bool HasScenario(string name)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
        }
    }
}
