using Interactable.Button;
using Player;
using UnityEngine;

namespace Interactable.Spenders
{
    public class Purchase: ButtonHandler
    {
        [SerializeField] private int price;
        [SerializeField] private ResourceType resourceType;

        protected override void HandleInteract()
        {
            if(playerInventory.Manager.Spend(resourceType, price))
                Debug.Log($"Purchased something for {price} {resourceType}. Balance: {playerInventory.Manager.GetAmount(resourceType)}");

        }
    }
}