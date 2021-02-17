using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFadere : MonoBehaviour
{
    public static SceneFadere instance;
    [SerializeField]
    private GameObject fadepenal;
    [SerializeField]
    private Animator fadeAnim;
    // Start is called before the first frame update
    void Awake()
    {
        MakeSingalton();
    }
    public void LoadLevel(string level)
    {
        StartCoroutine(FadeInOut(level));
    }
    IEnumerator FadeInOut(string level)
    {
        fadepenal.SetActive(true);
        fadeAnim.Play("FadeIn");
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(level);
        

        fadeAnim.Play("FadeOut");

        yield return StartCoroutine(MyCorutine.WaitForRealSeconds(.7f));

        fadepenal.SetActive(false);


    }
    void MakeSingalton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }

}
