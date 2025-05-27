using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("assignment 3 BenL");
        }
    }
}
