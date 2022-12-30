using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainLoader : MonoBehaviour
{
    
    public GameObject loadScreen;
    public Slider slider;
    public Text text;
    public Button button;

    public void LoadLevel()
    {
        StartCoroutine(AsyncLoad());
    }
    
    IEnumerator AsyncLoad()
    {
        button.gameObject.SetActive(false);
        loadScreen.SetActive(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
        asyncOperation.allowSceneActivation = false;
        while (!asyncOperation.isDone)
        {
            slider.value = asyncOperation.progress;
            text.text = "loading..." + asyncOperation.progress * 100 + "%";
            if (asyncOperation.progress >= 0.9f)
            {
                slider.value = 1;
                text.text = "press any key...";
                if (Input.anyKeyDown) asyncOperation.allowSceneActivation = true;

            }

            yield return null;
        }

        asyncOperation.allowSceneActivation = true;
       
        
    }
}
