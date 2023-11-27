using UnityEngine;

public class Rotater : MonoBehaviour
{
    public Vector3 rotation;

    void Update() => transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + rotation * Time.deltaTime);
}
