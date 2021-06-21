using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] GameObject deathFX;
   [SerializeField] Transform parent;
   [SerializeField] int scorePerHit = 12;
   [SerializeField] int hits = 10;
   ScoreBoard scoreBoard;
   void Start ()
   {
      addCollider();
      scoreBoard = FindObjectOfType<ScoreBoard>();
   }

   void addCollider() 
   {
      //adds script-independent nonTrigger Box Collider.
      Collider collider = gameObject.AddComponent<BoxCollider>();
      collider.isTrigger = false;
   }
 void OnParticleCollision(GameObject other)
 {
    ProcessHit();
    if (hits < 1)
    {
       KillEnemy();
    }
 }

 void ProcessHit()
 {
    scoreBoard.ScoreHit(scorePerHit);
    hits--;
    //todo add hit FX
 }

 void KillEnemy()
 {
    GameObject fx = Instantiate(deathFX, transform.localPosition, Quaternion.identity);
    fx.transform.parent = parent;
    Destroy(gameObject);
 }
}
