using UnityEngine;
using System.Collections;

public class FruitPickerPausePose : MonoBehaviour {

	static public int takenRockNumber = 0;
	static public int takenFruitNumber = 0;

	static public bool isPaused = false;
	static public bool isFinished = false;

	public GameObject resume;
	public GameObject mainMenu;

	public GameObject performanceMenu;
	public UILabel performanceMenuScore;
	public UILabel performanceMenuFruitCount;
	public UILabel performanceMenuRockCount;
	public UILabel performanceMenuPerformance;

	public GUIText score;

	private GameController gameController;

	void Start () {
		isFinished = false;
		isPaused = false;
		
		gameController = transform.GetComponent<GameController>();
		PlayGame();
		performanceMenu.SetActive(false);
	}

	void Update(){
		if(LevelTimeController.isLevelOver){
			FinishGame();
		}

	}

	public void ResumeMenuPause(){
		LevelTimeController.stopTime = true;
		isPaused = true;
		PauseGame();
	} 

	public void ResumeMenuResume(){
		LevelTimeController.stopTime = false;
		isPaused = false;
		PlayGame();
	} 

	public void ResumeMenuMainMenu(){
		Application.LoadLevel("FruitPickerMenu");
		takenFruitNumber = 0;
		takenRockNumber = 0;
	} 

	void PauseGame(){
		mainMenu.SetActive(true);
		resume.SetActive(true);

		gameController.objectCount = 0;
		isPaused = true;

		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Rock");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Banana");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Lemon");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Peach");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Red_Apple");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
	}


	void PlayGame(){
		mainMenu.SetActive(false);
		resume.SetActive(false);

		gameController.objectCount = gameController.fruitNumber + gameController.rockNumber;
		isPaused = false;

		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Rock");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, -4.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Banana");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, -4.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Lemon");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, -4.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Peach");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, -4.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Red_Apple");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, -4.0f);
		}
	}

	void FinishGame(){
		performanceMenu.SetActive(true);
		resume.SetActive(false);
		mainMenu.SetActive(false);

		gameController.objectCount = 0;
		isFinished = true;

		performanceMenuScore.text = score.text;
		performanceMenuFruitCount.text = "Fruit Count : " + takenFruitNumber;
		performanceMenuRockCount.text = "Rock Count : " + takenRockNumber;
		performanceMenuPerformance.text = "EXELLENT!";
		
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Rock");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
			gameObjects[i].rigidbody.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Banana");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
			gameObjects[i].rigidbody.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Lemon");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
			gameObjects[i].rigidbody.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Peach");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
			gameObjects[i].rigidbody.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
		gameObjects = GameObject.FindGameObjectsWithTag("Red_Apple");
		for (int i=0; i<gameObjects.Length; i++) {
			gameObjects[i].rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
			gameObjects[i].rigidbody.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);
		}
	}
}
