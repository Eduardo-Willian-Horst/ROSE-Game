using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    [SerializeField] private Button PlayButton;


    private void Awake(){
        PlayButton.onClick.AddListener(LoadScene);
    }


    private void LoadScene()
    {
        SceneManager.LoadScene("CutScene");
        
    }
}