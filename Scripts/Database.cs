using UnityEngine;
using System.Collections;

public class Database : MonoBehaviour {

	public string basketSpeedInput;
	public string basketSizeInput;
	public string levelTimeInput;
	public string fruitNumberInput;
	public string fruitSpeedInput;
	public string rockNumberInput;
	public string rockSpeedInput;
	public string spawnWaitTimeInput;
	public string waveWaitTimeInput;
	public string showScoreToggle;

	public Database(string levelName){
		basketSpeedInput = "basketSpeedInput" + levelName;
		basketSizeInput = "basketSizeInput" + levelName;
		levelTimeInput = "levelTimeInput" + levelName;
		fruitNumberInput = "fruitNumberInput" + levelName;
		fruitSpeedInput = "fruitSpeedInput" + levelName;
		rockNumberInput = "rockNumberInput" + levelName;
		rockSpeedInput = "rockSpeedInput" + levelName;
		spawnWaitTimeInput = "spawnWaitTimeInput" + levelName;
		waveWaitTimeInput = "waveWaitTimeInput" + levelName;
		showScoreToggle = "showScoreToggle" + levelName;

		if( PlayerPrefs.HasKey( basketSpeedInput) == false ){ PlayerPrefs.SetFloat ( basketSpeedInput, 0 );	}
		//else{ basketSpeedInput = PlayerPrefs.GetFloat(basketSpeedInput); }
		if( PlayerPrefs.HasKey( basketSizeInput) == false ){ PlayerPrefs.SetFloat ( basketSizeInput, 0 ); }
		if( PlayerPrefs.HasKey( levelTimeInput) == false ){ PlayerPrefs.SetFloat ( levelTimeInput, 0 );	}
		if( PlayerPrefs.HasKey( fruitNumberInput) == false ){ PlayerPrefs.SetFloat ( fruitNumberInput, 0 ); }
		if( PlayerPrefs.HasKey( fruitSpeedInput) == false ){ PlayerPrefs.SetFloat ( fruitSpeedInput, 0 ); }
		if( PlayerPrefs.HasKey( rockNumberInput) == false ){ PlayerPrefs.SetFloat ( rockNumberInput, 0 ); }
		if( PlayerPrefs.HasKey( rockSpeedInput) == false ){ PlayerPrefs.SetFloat ( rockSpeedInput, 0 );	}
		if( PlayerPrefs.HasKey( spawnWaitTimeInput) == false ){ PlayerPrefs.SetFloat ( spawnWaitTimeInput, 0 );	}
		if( PlayerPrefs.HasKey( waveWaitTimeInput) == false ){ PlayerPrefs.SetFloat ( waveWaitTimeInput, 0 );	}
		if( PlayerPrefs.HasKey( showScoreToggle) == false ){ PlayerPrefs.SetFloat ( showScoreToggle, 0 ); }
	}

	public void SetThisToPlayerPrefs(){
		PlayerPrefs.SetFloat(MenuPlayerPrefs.basketSpeedInput, PlayerPrefs.GetFloat(basketSpeedInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.basketSizeInput, PlayerPrefs.GetFloat(basketSizeInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.levelTimeInput, PlayerPrefs.GetFloat(levelTimeInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.fruitNumberInput, PlayerPrefs.GetFloat(fruitNumberInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.fruitSpeedInput, PlayerPrefs.GetFloat(fruitSpeedInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.rockNumberInput, PlayerPrefs.GetFloat(rockNumberInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.rockSpeedInput, PlayerPrefs.GetFloat(rockSpeedInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.spawnWaitTimeInput, PlayerPrefs.GetFloat(spawnWaitTimeInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.waveWaitTimeInput, PlayerPrefs.GetFloat(waveWaitTimeInput));
		PlayerPrefs.SetFloat(MenuPlayerPrefs.showScoreToggle, PlayerPrefs.GetFloat(showScoreToggle));
	}
	public void SetPlayerPrefsToThis(){
		PlayerPrefs.SetFloat(basketSpeedInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.basketSpeedInput));
		PlayerPrefs.SetFloat(basketSizeInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.basketSizeInput));
		PlayerPrefs.SetFloat(levelTimeInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.levelTimeInput));
		PlayerPrefs.SetFloat(fruitNumberInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.fruitNumberInput));
		PlayerPrefs.SetFloat(fruitSpeedInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.fruitSpeedInput));
		PlayerPrefs.SetFloat(rockNumberInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.rockNumberInput));
		PlayerPrefs.SetFloat(rockSpeedInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.rockSpeedInput));
		PlayerPrefs.SetFloat(spawnWaitTimeInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.spawnWaitTimeInput));
		PlayerPrefs.SetFloat(waveWaitTimeInput, PlayerPrefs.GetFloat(MenuPlayerPrefs.waveWaitTimeInput));
		PlayerPrefs.SetFloat(showScoreToggle, PlayerPrefs.GetFloat(MenuPlayerPrefs.showScoreToggle));
	}
}
