﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace Runtime._Game.Sources.Runtime.Infrastructure.Factories.AbstractFactory
{
    public class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory(DiContainer container)
        {
            _container = container;
        }

        private readonly DiContainer _container;

        public List<GameObject> Instances { get; } = new();
        
        public GameObject CreateInstance(GameObject prefab, Vector3 spawnPoint)
        {
            var instance = _container.InstantiatePrefab(prefab, spawnPoint, Quaternion.identity, null);
        
            Instances.Add(instance);

            return instance;
        }

        public void DestroyInstance(GameObject instance)
        {
            if (instance == null)
            {
                throw new NullReferenceException("There is no instance to destroy");
            }
        
            if (!Instances.Contains(instance))
            {
                throw new NullReferenceException($"Instance {instance} can't be destroyed, cause there is no {instance} on Abstract Factory Instances");
            }
        
            Object.Destroy(instance);
            Instances.Remove(instance);
        }

        public void DestroyAllInstances()
        {
            for (int i = 0; i < Instances.Count; i++)
            {
                Object.Destroy(Instances[i]);
            }
        
            Instances.Clear();
        }

        public void DestroyAllInstances<T>(List<T> list) where T : Object
        {
            for (int i = 0; i < list.Count; i++)
            {
                Object.Destroy(list[i]);
            }
        
            list.Clear();
        }
    }
}