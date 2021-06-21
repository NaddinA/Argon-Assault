
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MusicPlayer : MonoBehaviour
{    //Single-ton pattern without statics
    void Awake() {

        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
