using UnityEngine;
using System.Collections;

public class UIState : MonoBehaviour {
	public GameObject bgPanel;
	public GameObject startBtn;
	public GameObject rankBtn;
	public GameObject rankUI;
	public GameObject aboutButton;
	public GameObject aboutUI;
	public GameObject inGameUI;

	public GameObject[] spawners;
	public GameObject pickup;

	// Use this for initialization
	void Start () {
		inGameUI.SetActive(false);
		aboutUI.SetActive (false);
		rankUI.SetActive (false);
	}

	public void GameStart(){
		bgPanel.SetActive (false);
		startBtn.SetActive (false);
		rankBtn.SetActive (false);
		aboutButton.SetActive (false);

		inGameUI.SetActive(true);
		spawners[0].GetComponent<Spawner> ().GameStart ();
		spawners[1].GetComponent<Spawner> ().GameStart ();
		spawners[2].GetComponent<Spawner> ().GameStart ();
		pickup.GetComponent<PickupSpawner>().GameStart ();
	}

	public void RankUI() {
		startBtn.SetActive (false);
		rankBtn.SetActive (false);
		aboutButton.SetActive (false);

		rankUI.SetActive (true);
	}

	public void AboutUI() {
		startBtn.SetActive (false);
		rankBtn.SetActive (false);
		aboutButton.SetActive (false);

		aboutUI.SetActive (true);
	}

	public void Back(){
		aboutUI.SetActive (false);
		rankUI.SetActive (false);

		startBtn.SetActive (true);
		rankBtn.SetActive (true);
		aboutButton.SetActive (true);
	}
}
