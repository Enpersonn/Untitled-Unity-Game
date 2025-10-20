using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Player
{
    [System.Serializable]
    public class ResourceEntry
    {
        public ResourceType name;
        public int amount;
    }

    public class PlayerResourceInventory : MonoBehaviour
    {
        [FormerlySerializedAs("InitialResources")] [SerializeField] private List<ResourceEntry> initialResources = new();
    
        private readonly Dictionary<ResourceType, int> _resources = new();
        public PlayerResourceManager Manager { get; private set; }
    
    
        private void Awake()
        {
            foreach (var entry in initialResources)
            {
                _resources[entry.name] = entry.amount;
            }
        
            Manager = new PlayerResourceManager(_resources);
        }
    }

   
}