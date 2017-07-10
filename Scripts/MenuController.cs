using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuController : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject optionsMenu;
	public GameObject levelsMenu;

	public GameObject basketSpeedInput ;
	public GameObject basketSizeInput ;
	public GameObject levelTimeInput ;
	public GameObject fruitNumberInput ;
	public GameObject fruitSpeedInput ;
	public GameObject rockNumberInput ;
	public GameObject rockSpeedInput ;
	public GameObject spawnWaitTimeInput;
	public GameObject waveWaitTimeInput;
	public GameObject showScoreToggle;

	public GameObject levelNameInput;
	private string levelName;
	public GameObject levelListSelect;
	private UIPopupList popupListSelect;
	public GameObject levelListDelete;
	private UIPopupList popupListDelete;

	private bool isAllNumber = true;


	void Awake(){
		mainMenu.SetActive(true);
		optionsMenu.SetActive(false);
		levelsMenu.SetActive(false);
	}

	public void MainMenuStart(){
		Application.LoadLevel("FruitPickerGame");
		//LoadLevel();
	}

	public void MainMenuOptions(){
		mainMenu.SetActive(false);
		optionsMenu.SetActive(true);
		levelsMenu.SetActive(false);

		basketSpeedInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.basketSpeedInput).ToString();
		basketSizeInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.basketSizeInput).ToString();
		levelTimeInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.levelTimeInput).ToString();
		fruitNumberInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.fruitNumberInput).ToString();
		fruitSpeedInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.fruitSpeedInput).ToString();
		rockNumberInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.rockNumberInput).ToString();
		rockSpeedInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.rockSpeedInput).ToString();
		spawnWaitTimeInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.spawnWaitTimeInput).ToString();
		waveWaitTimeInput.GetComponentInChildren<UILabel>().text = PlayerPrefs.GetFloat(MenuPlayerPrefs.waveWaitTimeInput).ToString();
		if(PlayerPrefs.GetFloat(MenuPlayerPrefs.showScoreToggle) == 1){
			showScoreToggle.GetComponent<UIToggle>().value = true;
		}
		else{
			showScoreToggle.GetComponent<UIToggle>().value = false;
		}
		//mInput.GetComponentsInChildren<UILabel>().
		//UILabel.print();
	}

	public void MainMenuExit(){
		Application.Quit();
	}

	public void OptionsMenuBack(){
		if(isAllNumber){
			mainMenu.SetActive(true);
			optionsMenu.SetActive(false);	
		}
		else{
			print("Error! There are inputs which are not float.");
		}
	}

	public void OptionsMenuLevels(){
		if(isAllNumber){
			mainMenu.SetActive(false);
			optionsMenu.SetActive(false);	
			levelsMenu.SetActive(true);

			popupListSelect = levelListSelect.GetComponent<UIPopupList>();
			popupListSelect.Clear();
			popupListDelete = levelListDelete.GetComponent<UIPopupList>();
			popupListDelete.Clear();

			List<string> list = popupListSelect.items;
			for(int i = 0; i < MenuPlayerPrefs.levelNames.Length; i++){
				print(i + ": " + PlayerPrefs.GetString(MenuPlayerPrefs.levelNames[i]));
				if(PlayerPrefs.GetString(MenuPlayerPrefs.levelNames[i]) != " "){
					list.Add( PlayerPrefs.GetString(MenuPlayerPrefs.levelNames[i]) );
				}
			}
			popupListSelect.items = list;
			popupListDelete.items = list;
		}
		else{
			print("Error! There are inputs which are not float.");
		}
	}

	public void OptionsBasketSpeedInput(){
		UIInput mInput = basketSpeedInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.basketSpeedInput, float.Parse(text));
			}
		}
	}

	public void OptionsBasketSizeInput(){
		UIInput mInput = basketSizeInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.basketSizeInput, float.Parse(text));
			}
		}
	}

	public void OptionsLevelTimeInput(){
		UIInput mInput = levelTimeInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.levelTimeInput, float.Parse(text));
			}
		}
	}

	public void OptionsFruitNumberInput(){
		UIInput mInput = fruitNumberInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.fruitNumberInput, float.Parse(text));
			}
		}
	}

	public void OptionsFruitSpeedInput(){
		UIInput mInput = fruitSpeedInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.fruitSpeedInput, float.Parse(text));
			}
		}
	}

	public void OptionsRockNumberInput(){
		UIInput mInput = rockNumberInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.rockNumberInput, float.Parse(text));
			}
		}
	}

	public void OptionsRockSpeedInput(){
		UIInput mInput = rockSpeedInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.rockSpeedInput, float.Parse(text));
			}
		}
	}

	public void OptionsSpawnWaitTimeInput(){
		UIInput mInput = spawnWaitTimeInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.spawnWaitTimeInput, float.Parse(text));
			}
		}
	}

	public void OptionsWaveWaitTimeInput(){
		UIInput mInput = waveWaitTimeInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		string text = NGUIText.StripSymbols(mInput.value);
		if (!string.IsNullOrEmpty(text)){
			float num;
			isAllNumber = float.TryParse(text,out num);
			if(isAllNumber){
				PlayerPrefs.SetFloat(MenuPlayerPrefs.waveWaitTimeInput, float.Parse(text));
			}
		}
	}

	public void OptionsShowScoreToggle(){

		UIToggle mToggle = showScoreToggle.GetComponent<UIToggle>();
		//mToggle.value = true;
		if(mToggle.value == true){
			PlayerPrefs.SetFloat(MenuPlayerPrefs.showScoreToggle, 1);
		}
		else{
			PlayerPrefs.SetFloat(MenuPlayerPrefs.showScoreToggle, 0);
		}
	}

	public void OptionsResetHighScoreButton(){
		string highScoreForFruitGame = "highScoreForFruitGame";
		if( PlayerPrefs.HasKey( highScoreForFruitGame) == true ){
			PlayerPrefs.SetInt(highScoreForFruitGame, 0);
		}
	}

	public void LevelsMenuBack(){
		mainMenu.SetActive(false);
		optionsMenu.SetActive(true);	
		levelsMenu.SetActive(false);
	}

	public void levelsLevelNameInput(){
		UIInput mInput = levelNameInput.GetComponent<UIInput>();
		mInput.label.maxLineCount = 1;
		levelName = NGUIText.StripSymbols(mInput.value);
		//print(levelName);
	}

	public void levelsLevelNameSave(){
		List<string> list = popupListSelect.items;
		if( list.Contains(levelName) == false ){
			Database database = new Database(levelName);
			database.SetPlayerPrefsToThis();

			for(int j=0 ; j<10 ; j++){
				if( PlayerPrefs.GetString(MenuPlayerPrefs.levelNames[j]) == " "){
					PlayerPrefs.SetString(MenuPlayerPrefs.levelNames[j], levelName);
					break;
				}
			}
			popupListSelect.AddItem(levelName);
		}
	}

	public void levelsLevelListSelect(){
		List<string> list = popupListSelect.items;
		Database database = new Database(levelListSelect.GetComponentInChildren<UILabel>().text);
		database.SetThisToPlayerPrefs();
	}

	public void levelsLevelListDelete(){
		List<string> list = popupListSelect.items;
		string label = levelListDelete.GetComponentInChildren<UILabel>().text;
		int i = list.IndexOf(label);
		list.RemoveAt(i);
		for(int j=0 ; j<10 ; j++){
			if( label == PlayerPrefs.GetString(MenuPlayerPrefs.levelNames[j])){
				PlayerPrefs.SetString(MenuPlayerPrefs.levelNames[j], " ");
			}
		}
		popupListSelect.items = list;
		popupListDelete.items = list;
	}	
}
