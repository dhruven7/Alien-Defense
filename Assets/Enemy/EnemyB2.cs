using UnityEngine;
using System.Collections;

public class EnemyB2 : MonoBehaviour,IEnemyB {
	
	private float moveSpeed = 6f;		// The speed the enemy moves at.
	private int HP = 3;					// How many times the enemy can be hit before it dies.
	
	
	public float getMoveSpeed(){
		return moveSpeed;
	}
	public int getHP() {
		return HP;
	}

	public void show() {
		Debug.Log ("B2");
	}
	
}

