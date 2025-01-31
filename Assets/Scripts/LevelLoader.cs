using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator Transition;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            //StartCoroutine(CarregarFase("SampleScene"));
            SceneManager.LoadScene("SampleScene");
        }

        ////corrotina
        //IEnumerator CarregarFase(string nomeFase)
        //{
        //    SceneManager.LoadScene(nomeFase);
        //}
        //{

        //}
    }
}
