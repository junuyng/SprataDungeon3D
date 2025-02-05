﻿using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public StatHandler statHandler;
    public PlayerCondition condition;
    public PlayerInteractionController interactionController;
    public PlayerInventory inventory;

    
    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        statHandler = GetComponent<StatHandler>();
        condition = GetComponent<PlayerCondition>();
        interactionController = GetComponent<PlayerInteractionController>();
        inventory = GetComponent<PlayerInventory>();
    }
    
    
    
}