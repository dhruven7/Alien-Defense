using UnityEngine;
using System.Collections;
using System;

public class HealthPickup : MonoBehaviour, ISubject
{
	public float healthBonus;				// How much health the crate gives the player.
	public AudioClip collect;				// The sound of the crate being collected.


	private PickupSpawner pickupSpawner;	// Reference to the pickup spawner.
	private Animator anim;					// Reference to the animator component.
	private bool landed;					// Whether or not the crate has landed.

    ArrayList observers; 

	void Awake ()
	{
		// Setting up the references.
		pickupSpawner = GameObject.Find("pickupManager").GetComponent<PickupSpawner>();
		anim = transform.root.GetComponent<Animator>();
        observers = new ArrayList();
        //attach(GameObject.Find("playerHealth").GetComponent<PlayerHealth>());
        //attach(GetComponent<PlayerHealth>());
    }


	void OnTriggerEnter2D (Collider2D other)
	{
		// If the player enters the trigger zone...
		if(other.tag == "Player")
		{
            // Get a reference to the player health script.
            //PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            // Increasse the player's health by the health bonus but clamp it at 100.
            //playerHealth.health += healthBonus;
            //playerHealth.health = Mathf.Clamp(playerHealth.health, 0f, 100f);

            // Update the health bar.
            //playerHealth.UpdateHealthBar();
            attach(other.GetComponent<PlayerHealth>());            
            notify(healthBonus);
            detach(other.GetComponent<PlayerHealth>());
            //notify(10f);

            // Trigger a new delivery.
            pickupSpawner.StartCoroutine(pickupSpawner.DeliverPickup());

			// Play the collection sound.
			AudioSource.PlayClipAtPoint(collect,transform.position);

			// Destroy the crate.
			Destroy(transform.root.gameObject);
		}
		// Otherwise if the crate hits the ground...
		else if(other.tag == "ground" && !landed)
		{
			// ... set the Land animator trigger parameter.
			anim.SetTrigger("Land");

			transform.parent = null;
			gameObject.AddComponent<Rigidbody2D>();
			landed = true;	
		}
	}

    public void attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void notify(float healthValue)
    {
        foreach (IObserver observer in observers)
        {            
            observer.update(healthValue);

        }
    }
}
