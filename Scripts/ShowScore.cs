using UnityEngine;
using System.Collections;

public class ShowScore : MonoBehaviour {

	public GameObject scoreText;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetFloat(MenuPlayerPrefs.showScoreToggle) == 0){
			scoreText.SetActive(false);
		}
	}
	

}
