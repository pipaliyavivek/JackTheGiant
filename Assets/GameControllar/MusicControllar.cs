    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControllar : MonoBehaviour
{
    public static MusicControllar instance;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        MakeSingalton();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playMusic(bool ply)
    {
        if(ply)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if(audioSource .isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

    void MakeSingalton()
    {
        if (instance != null){
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
    }
}
