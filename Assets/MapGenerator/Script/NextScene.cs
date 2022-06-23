using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Portal"))
        {
            Invoke("ProximaCena", 0f);
        }
    }
    void ProximaCena()
    {
        SceneManager.LoadScene("Andar2");
    }
}
