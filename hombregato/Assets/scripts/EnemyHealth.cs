using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyHealth : MonoBehaviour 
{
	public float health = 100f;



	private bool playerDead;




	void PlayerDying()
	{
		playerDead = true;
		Destroy (gameObject);
	}



	public void TakeDamage(float amount)
	{
		health -= amount;

		if (health <= 0f) 
		{
			if (!playerDead) {
				PlayerDying ();
			}

		}
	}
}	
