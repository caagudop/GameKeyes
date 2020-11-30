using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CrediText : MonoBehaviour
{
    [SerializeField] bool crawling = false;

    List<string> creds = new List<string>(){
        "Juego realizado por",
        "CARLOS AGUDO POSTIGO",
         "Muchas gracias por jugarlo"}; 
    
    void Update()
    {
        if (crawling)
        {
            crawling = false;
            StartCoroutine(ExampleCoroutine());
        }
    }


    IEnumerator ExampleCoroutine()
    {
        for (int i = 0; i < creds.Count; i++)
        {
            GetComponent<Text>().text = creds[i];
            yield return new WaitForSeconds(4);
            GetComponent<Text>().text = "";
        }
        crawling = false;
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
