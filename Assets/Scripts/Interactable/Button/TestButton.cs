using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    private Transform _button;
    private Transform _player;

    [SerializeField] private float interactDistance = 8f;
    [SerializeField] private PlayerResourceInventory playerInventory;
    
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

        if (distance <= interactDistance) HandleClick();
    }

    private void HandleClick()
    {
        playerInventory.Manager.Add(ResourceType.Gold, 10);
        Debug.Log($"Gained 10 Gold. Total: {playerInventory.Manager.GetAmount(ResourceType.Gold)}");

    }
}
