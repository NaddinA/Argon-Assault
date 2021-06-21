using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
  [Tooltip("in seconds")][SerializeField] float sceneLoadDelay = 1f;
  [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;
       void OnTriggerEnter(Collider other)
    {
        initiateDeathSequence();
        deathFX.SetActive(true);
        Invoke("reloadGame", sceneLoadDelay);
    }

    void initiateDeathSequence() 
    {
      SendMessage("OnPlayerDeath");
    }

    void reloadGame() //string referenced
    {
      SceneManager.LoadScene(1);
    }
}
