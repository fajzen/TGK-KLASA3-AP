using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicoff : MonoBehaviour
{
    [SerializeField] AudioSource music;
    
    public void OffMusic()
    {
        music.Stop();
    }
}
