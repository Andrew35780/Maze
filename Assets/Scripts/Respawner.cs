using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private CollisionDetector detector;

    private void OnEnable() => detector.OnCrashed += Respawn;

    private void OnDisable() => detector.OnCrashed -= Respawn;

    private void Respawn() => player.position = spawnPoint.position;
}

