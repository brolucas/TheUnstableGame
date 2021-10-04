using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UnstableFall : MonoBehaviour
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

    private void OnTriggerStay2D(Collider2D other)
    {
    
        GameOver();
        
       
    }


    private void GameOver()
    {
        SceneManager.LoadScene(leveltoload);
    }
}
