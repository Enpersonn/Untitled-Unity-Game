using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerResourceManager
    {
        private readonly Dictionary<ResourceType, int> _resources;

        public PlayerResourceManager(Dictionary<ResourceType, int> resources)
        {
            _resources = resources;
        }

        public void Add(ResourceType type, int amount)
        {
            _resources.TryAdd(type, 0);
            _resources[type] += amount;
        }

        public int GetAmount(ResourceType type)
        {
            return _resources[type];
        }

        public bool HasResource(ResourceType type, int price)
        {
            return _resources.ContainsKey(type) && _resources[type] >= price;
        }

        public bool Spend(ResourceType type, int amount)
        {
            if (!HasResource(type, amount))
            {
                Debug.Log("Not enough resources");
                return false;
            }
            _resources[type] -= amount;        
            return true;
        }
    
        public IReadOnlyDictionary<ResourceType, int> GetAll() => _resources;
    }
}