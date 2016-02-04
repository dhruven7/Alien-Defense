using UnityEngine;
using System.Collections;

public class EnemyA2 :MonoBehaviour,IEnemyA {
	
	private float moveSpeed = 7f;		// The speed the enemy moves at.
	private int HP = 2;					// How many times the enemy can be hit before it dies.
	
	
	public float getMoveSpeed(){
		return moveSpeed;
	}
	public int getHP() {
		return HP;
	}

	public void show() {
		Debug.Log ("A2");
	}
	
}
