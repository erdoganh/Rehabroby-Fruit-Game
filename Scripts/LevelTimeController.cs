using UnityEngine;
using System.Collections;

public class LevelTimeController : MonoBehaviour {

	float levelTime;
	float time;

	static public bool isLevelOver;
	static public bool stopTime;

	void Start () {
		levelTime = PlayerPrefs.GetFloat(MenuPlayerPrefs.levelTimeInput);
		isLevelOver = false;
		stopTime = false;
		time = 0.0f;
	}
	
	void Update () {
		if(stopTime == false){
			time = time + Time.deltaTime;
		}
		transform.GetComponent<GUIText>().text = "Time : " + ( (levelTime - time) ).ToString("f2");
		if(time >= levelTime){
			isLevelOver = true;
			stopTime = true;
			transform.GetComponent<GUIText>().text = "Time : " + ( (levelTime - time) ).ToString("f0");
			print("Level is OVER!");
		}
	}
}
