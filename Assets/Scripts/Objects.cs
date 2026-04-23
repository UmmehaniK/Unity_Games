using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
   public float objectHealth = 100f;
   //public int EnemyCount = 10;

   public void objectHitDamage(float amount)
   {
	   objectHealth -= amount;
	   if(objectHealth <= 0f)
	   {
			//destroy	
			Die();
			//EnemyCount -= EnemyCount;

	   }
   }

   void Die()
   {
        EnemyCount.Instance.EnemyDie();
        Destroy(gameObject);
   }
}
