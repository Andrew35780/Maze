using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishBehaviour : MonoBehaviour
{
    [SerializeField] private string levelToGo = "Level1";

    public void GoToLevel() => SceneManager.LoadScene(levelToGo);
}
