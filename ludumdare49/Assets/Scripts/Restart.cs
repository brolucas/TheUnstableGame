using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public string leveltoload;
    

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reload()
    {
        SceneManager.LoadScene(leveltoload);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
