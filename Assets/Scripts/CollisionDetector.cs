using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CollisionDetector : MonoBehaviour
{
    public event Action OnCrashed = delegate { };

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.layer == 8)
            OnCrashed?.Invoke();
    }
}
