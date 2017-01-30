using UnityEngine;
//using UnityEngine.UI;
using System.Collections;



	public class EnemyHealth : MonoBehaviour 
	{

		public int StartingHealth = 100;
		public int currentHealth = 100;
		public float healthBarLength;
		//public  slider healthSlider;
	
		//PlayerMovement playerMovement; 
		//PlayerAttack playerAttack;
		Animator anim;  
		bool isDead;
		bool damaged;

			void start()
			{
				healthBarLength =  Screen.width / 2;
				anim = GetComponent <Animator> ();
				currentHealth = StartingHealth;
	
			}


			void update()
			{
				damaged = false;
			}
	
		
			// Update is called once per frame
			public void TakeDamage (int amount) 
			{
				// reduce currenthealth by damage amount.
				currentHealth -= amount;

				// set health to bar's value to the current health.
				//healthSlider.Value = currentHealth;

					if(currentHealth <= 0 && !isDead)
					{
						Death();
	
	
					}

			
			}
			void Death()
			{
				isDead = true;

				//PlayerAttack. DisableEffects ();

				anim.SetTrigger ("dead");

				//playerMovement.enabled = false;
				//playerAttack.enabled = false;

			}
			void OnGUI(){
				GUI.Box(new Rect(10, 40, Screen.width / 2 / (StartingHealth / currentHealth), 20), currentHealth + "/" + StartingHealth);
			}
			public void AddjustCurrentHealth(int adj){
				currentHealth += adj;

				if(currentHealth > StartingHealth)
					currentHealth = StartingHealth;
				if(StartingHealth < 1)
					StartingHealth = 1;
				if(currentHealth <= 0 && gameObject.tag == "Enemy")
					Destroy(gameObject);
					

				healthBarLength = (Screen.width / 2) * (currentHealth / (float)StartingHealth);
			}
	}	
