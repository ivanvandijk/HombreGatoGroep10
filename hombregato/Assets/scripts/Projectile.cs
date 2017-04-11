	using UnityEngine;
	using System.Collections;

	public class Projectile : MonoBehaviour 
	{
	private float _speed;

	void Start()
	{
		Destroy (gameObject, 2f); //hier verander je wanneer je de bullets wil laten verdwijnen.
	}

	void Update()
	{
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);

	}

	public void SetSpeed(float value)
	{
		_speed = value;
	}

	void OnTriggerEnter(Collider other) {
		
		
		
		if (other.CompareTag("Enemy")) {
			EnemyHealth enemyhealth = other.GetComponent<EnemyHealth> ();
			enemyhealth.TakeDamage (50f);
			Destroy(gameObject);

		}
	}

	}

