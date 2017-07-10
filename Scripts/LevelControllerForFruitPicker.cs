using UnityEngine;
using System.Collections;

public class LevelControllerForFruitPicker : MonoBehaviour {

	//public 

	private float fruitSpeed;
	private float fruitCount;
	private float rockSpeed;
	private float rockCount;

	void Awake () {
		//print(fruitSpeed + "/" + rockSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		if(!FruitPickerPausePose.isPaused){
			PrepareLevelDifficulty ();
		}
	}

	void PrepareLevelDifficulty(){
		fruitSpeed = -1 * PlayerPrefs.GetFloat(MenuPlayerPrefs.fruitSpeedInput);
		rockSpeed = -1 * PlayerPrefs.GetFloat(MenuPlayerPrefs.rockSpeedInput);

		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Rock");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, rockSpeed);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Banana");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, fruitSpeed);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Lemon");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, fruitSpeed);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Peach");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, fruitSpeed);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Red_Apple");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, fruitSpeed);
		}
	}
}
