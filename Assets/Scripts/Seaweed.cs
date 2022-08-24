using UnityEngine;
using UnityEngine.SceneManagement;
public class Seaweed : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Fish>() != null)
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}
