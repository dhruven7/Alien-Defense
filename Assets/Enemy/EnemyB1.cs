using UnityEngine;
public class EnemyB1 : MonoBehaviour,IEnemyB{
	
	private float moveSpeed = 5f;		// The speed the enemy moves at.
	private int HP = 2;					// How many times the enemy can be hit before it dies.
	
	
	public float getMoveSpeed(){
		return moveSpeed;
	}
	public int getHP() {
		return HP;
	}

	public void show() {
		Debug.Log ("B1");
	}
	
}
