using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textElement;
    void Start()
    {
        if (textElement != null)
            textElement.text = "Level: " + SceneManager.GetActiveScene().name;
    }
}
