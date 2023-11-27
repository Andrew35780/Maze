using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private Rigidbody player;
    private bool isSceneLoaded;

    private void Awake()
    {
        player = GetComponent<Rigidbody>();
        StartCoroutine(WaitSceneLoadCoroutine());
    }

    private void Update ()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.red);

        if (Physics.Raycast(ray, out hit) && isSceneLoaded)
            Move((Vector2)hit.point);
    }

    private void Move(Vector2 target)
    {
        Vector3 middle = Vector3.Lerp(player.position, (Vector3)target, Time.deltaTime * speed);
        player.position = middle;
    }

    private IEnumerator WaitSceneLoadCoroutine()
    {
        yield return new WaitForSeconds(0.5f);

        isSceneLoaded = true;
    }
}