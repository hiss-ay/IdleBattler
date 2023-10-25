using System.Collections.Generic;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Infrastructure.Factories.AbstractFactory
{
    public interface IAbstractFactory
    {
        public List<GameObject> Instances { get; }
        public GameObject CreateInstance(GameObject prefab, Vector3 spawnPoint);
        public void DestroyInstance(GameObject instance);
        public void DestroyAllInstances();
        public void DestroyAllInstances<T>(List<T> list) where T : Object;
    }
}