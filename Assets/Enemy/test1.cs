using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IEnemyFactory factory = new EnemyFactoryEasy ();
		factory.createEnemyA ().show ();
		factory.createEnemyB().show();

		IEnemyFactory factoryHard = new EnemyFactoryHard ();
		factoryHard.createEnemyA ().show ();
		factoryHard.createEnemyB ().show ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
