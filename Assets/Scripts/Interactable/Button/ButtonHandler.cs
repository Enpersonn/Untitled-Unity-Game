using Player;
using UnityEngine;

namespace Interactable.Button
{
    public abstract class ButtonHandler: MonoBehaviour
    {
        private Transform _button;
        private Transform _player;

        [SerializeField] private float interactDistance = 8f;
        public PlayerResourceInventory playerInventory;
    
        private void Start()
        {
            _button = GetComponent<Transform>();
        
            if (playerInventory == null)
            {
                var playerGo = GameObject.FindWithTag("Player");
                _player = playerGo.transform;
                playerInventory = playerGo.GetComponent<PlayerResourceInventory>();
            }
            else
            {
                _player = playerInventory.transform;
            }
        }
        
        private void OnMouseDown()
        {
            var distance = Vector3.Distance(_player.position, _button.position);

            if (distance <= interactDistance) HandleInteract();
        }

        protected abstract void HandleInteract();
    }
}