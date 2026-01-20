using UnityEngine;
using UnityEngine.SceneManagement;

public class Bucket : MonoBehaviour
{
    [SerializeField] private GameObject coinObject;
    [SerializeField] private Object sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == coinObject && sceneToLoad != null)
        {
            SceneManager.LoadScene(sceneToLoad.name);
        }
    }
}
