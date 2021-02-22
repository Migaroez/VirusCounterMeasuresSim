﻿using System;
using System.Collections.Generic;
using Assets.Core.Interfaces;

namespace Core.Ioc
{
    public class DiContainer
    {
        private static DiContainer _current;
        private static readonly object _currentLock = new object();
        private readonly Dictionary<Type, object> _registrationList = new Dictionary<Type, object>();

        public static DiContainer Current
        {
            get
            {
                lock (_currentLock)
                {
                    return _current ?? (_current= new DiContainer());
                }
            }
        }

        public void Register<T>(T implementation) where T : class
        {
            if (Resolve<T>() != null)
            {
                return;
            }

            var type = typeof(T);

            if (_registrationList.ContainsKey(type) && _registrationList[type] != null)
            {
                throw new ArgumentException("Type " + type + " is already registered");
            }
            _registrationList[type] = implementation;
        }

        public T Resolve<T>() where T : class
        {
            var type = typeof(T);
            if (_registrationList.ContainsKey(type) == false)
            {
                return null;
            }
            return _registrationList[type] as T;
        }

        public void Start()
        {
            foreach (KeyValuePair<Type, object> keyValuePair in _registrationList)
            {
                if (keyValuePair.Value is IInitializableScriptableObject scriptableObject)
                {
                    scriptableObject.Start();
                }
            }
        }
    }
}
