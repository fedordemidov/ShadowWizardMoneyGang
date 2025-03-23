using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame(int index) 
    {
        SceneManager.LoadScene(index);
    }
    public void PlayOut() 
    {
        Debug.Log("Ты вышел");
        Application.Quit();
    }
}
