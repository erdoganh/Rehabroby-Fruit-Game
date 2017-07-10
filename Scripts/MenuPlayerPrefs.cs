using UnityEngine;
using System.Collections;

public class MenuPlayerPrefs : MonoBehaviour {

	static public string[] levelNames = {"levelName1", "levelName2", "levelName3", "levelName4",
		"levelName5", "levelName6", "levelName7", "levelName8", "levelName9", "levelName10"};

	static public string basketSpeedInput = "basketSpeedInput";
	static public string basketSizeInput = "basketSizeInput";
	static public string levelTimeInput = "levelTimeInput";
	static public string fruitNumberInput = "fruitNumberInput";
	static public string fruitSpeedInput = "fruitSpeedInput";
	static public string rockNumberInput = "rockNumberInput";
	static public string rockSpeedInput = "rockSpeedInput";
	static public string spawnWaitTimeInput = "spawnWaitTimeInput";
	static public string waveWaitTimeInput = "waveWaitTimeInput";
	static public string showScoreToggle = "showScoreToggle";
	
	// Use this for initialization
	void Awake () {
		if( PlayerPrefs.HasKey( basketSpeedInput) == false ){ PlayerPrefs.SetFloat ( basketSpeedInput, 0 );	}
		if( PlayerPrefs.HasKey( basketSizeInput) == false ){ PlayerPrefs.SetFloat ( basketSizeInput, 0 ); }
		if( PlayerPrefs.HasKey( levelTimeInput) == false ){ PlayerPrefs.SetFloat ( levelTimeInput, 0 );	}
		if( PlayerPrefs.HasKey( fruitNumberInput) == false ){ PlayerPrefs.SetFloat ( fruitNumberInput, 0 ); }
		if( PlayerPrefs.HasKey( fruitSpeedInput) == false ){ PlayerPrefs.SetFloat ( fruitSpeedInput, 0 ); }
		if( PlayerPrefs.HasKey( rockNumberInput) == false ){ PlayerPrefs.SetFloat ( rockNumberInput, 0 ); }
		if( PlayerPrefs.HasKey( rockSpeedInput) == false ){ PlayerPrefs.SetFloat ( rockSpeedInput, 0 );	}
		if( PlayerPrefs.HasKey( spawnWaitTimeInput) == false ){ PlayerPrefs.SetFloat ( spawnWaitTimeInput, 0 );	}
		if( PlayerPrefs.HasKey( waveWaitTimeInput) == false ){ PlayerPrefs.SetFloat ( waveWaitTimeInput, 0 );	}
		if( PlayerPrefs.HasKey( showScoreToggle) == false ){ PlayerPrefs.SetFloat ( showScoreToggle, 0 ); }

		for(int i = 0; i<10; i++){
			if( PlayerPrefs.HasKey( levelNames[i]) == false ){ PlayerPrefs.SetString ( levelNames[0], " " );}
		}

	}
	
}
