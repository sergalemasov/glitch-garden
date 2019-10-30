using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int splashScreenVisibilityTime = 4;
    // Start is called before the first frame update
    void Start()
    {
        SetupSplashScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupSplashScreen()
    {
        if (SceneManager.GetActiveScene().name != "Splash Screen")
        {
            return;
        }

        StartCoroutine(LoadStartScreenWithDelay());
    }

    IEnumerator LoadStartScreenWithDelay()
    {
        yield return new WaitForSeconds(splashScreenVisibilityTime);

        SceneManager.LoadScene("Start Screen");
    }
}
