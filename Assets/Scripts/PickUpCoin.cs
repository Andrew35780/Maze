using System;
using UnityEngine;

public class PickUpCoin : MonoBehaviour, IPickUpable 
{
    public static event Action OnPickUp;
    
    public void PickUp()
    {
        Destroy(gameObject);
        OnPickUp?.Invoke();
    }
}

