using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button quitButton;


    private void Awake(){
        quitButton.onClick.AddListener(quit);
    }

 
    private void quit()
    {
        Application.Quit();
        
    }
}