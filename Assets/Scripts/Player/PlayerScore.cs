using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    
    [SerializeField]
    private AudioClip coinClip, lifeClip;
    
    private CameraScript cameraScript;
    /*[SerializeField]
    private GameManager GameScript;*/

    private Vector3 previousPosition;
    private bool countScore;

    public static int scoreCount;
    public static int lifeCount;
    public static int coinCount;


   void Awake()
    {
        /*if (!GameManager.instance)
        { SceneManager.LoadScene(0); }*/
        cameraScript = Camera.main.GetComponent<CameraScript>();
    }
    // Start is called before the first frame update
    void Start()
    { 
        previousPosition = transform.position;
        countScore = true;
    }

    // Update is called once per frame
    void Update()
    {
        CountScore();
    }
    void CountScore()
    {
        if (countScore)
        {
            if (transform.position.y < previousPosition.y)
            {
                scoreCount++;
            }
            previousPosition = transform.position;
          //  Debug.Log(scoreCount);
            GamePlyControllar.instance.SetScore(scoreCount);

        }
    }
    
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Coin")
        {
            Debug.Log(target.gameObject.name);
            coinCount +=1;
            scoreCount += 200;
            GamePlyControllar.instance.SetScore(scoreCount);
            GamePlyControllar.instance.SetCoinScore(coinCount );

            AudioSource.PlayClipAtPoint(coinClip, transform.position);
            target.gameObject.SetActive(false);
        }
        if (target.gameObject.tag == "Cloud")
        {
            Debug.Log(target.gameObject.name);
           // coinCount += 1;
            scoreCount += 200;
            GamePlyControllar.instance.SetScore(scoreCount);
            //GamePlyControllar.instance.SetCoinScore(coinCount);

           // AudioSource.PlayClipAtPoint(coinClip, transform.position);
            //target.gameObject.SetActive(false);
        }
        if (target.gameObject.tag == "Life")
        {
            Debug.Log("2");
            lifeCount++;
            scoreCount += 300;
            GamePlyControllar.instance.SetScore(scoreCount);
            GamePlyControllar.instance.SetLifeScore(lifeCount);

            AudioSource.PlayClipAtPoint(lifeClip, transform.position);
            target.gameObject.SetActive(false);
        }
        if (target.gameObject.tag == "Bounds")
        {
            Debug.Log(target.gameObject.name);
            Debug.Log(gameObject.name);
            Debug.Log("3");
            Debug.Log("Bounds Touched!!!!!");
            cameraScript.moveCamera = false;
            countScore = false;
           // transform.position = new Vector3(500, 500, 0);
            lifeCount--;
          //  scoreCount += 100;
            GameManager.instance.CheckGameStatus(scoreCount, coinCount, lifeCount);
            //GameScript.CheckGameStatus(scoreCount, coinCount, lifeCount);
        }
        if (target.gameObject.tag == "Deadly") 
        {

            Debug.Log("4");
            Debug.Log("DarkCloud Triggred!!!!");

            cameraScript.moveCamera = false;
            countScore = false;
            transform.position = new Vector3(500, 500, 0);
            lifeCount--;
             GameManager.instance.CheckGameStatus(scoreCount ,coinCount ,lifeCount );
            //GameManager.instance.CheckGameStatus(scoreCount, coinCount, lifeCount);
            //GameScript.CheckGameStatus(scoreCount, coinCount, lifeCount);
        }
        
    }
        
    }

