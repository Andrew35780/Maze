using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    void Update()
    {
        Collider[] collisions = Physics.OverlapSphere(transform.position, 0.45f);

        if (collisions.Length > 0)
        {
            GameObject collided = collisions[0].gameObject;

            switch (collided.tag)
            {
                case "PickUp":
                    collided.GetComponent<IPickUpable>().PickUp();
                    break;
                case "Finish":
                    collided.GetComponent<FinishBehaviour>().GoToLevel();
                    break;
            }          
        }
    }
}
