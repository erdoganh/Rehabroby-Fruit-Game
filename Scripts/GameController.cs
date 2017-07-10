using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject redApple;
	public GameObject banana;
	public GameObject peach;
	public GameObject lemon;
	public GameObject rock;
	public int fruitTypeCount;

	public Vector3 spawnValues;
	public int objectCount;

	public int fruitNumber;
	public int rockNumber;
	private int spawnedFruitNumber;
	private int spawnedRockNumber;


	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	void Start(){
		spawnWait = PlayerPrefs.GetFloat(MenuPlayerPrefs.spawnWaitTimeInput);
		waveWait = PlayerPrefs.GetFloat(MenuPlayerPrefs.waveWaitTimeInput);
		fruitNumber = (int)PlayerPrefs.GetFloat(MenuPlayerPrefs.fruitNumberInput);
		rockNumber = (int)PlayerPrefs.GetFloat(MenuPlayerPrefs.rockNumberInput);
		
		objectCount = fruitNumber + rockNumber;
		
		spawnedFruitNumber = 0;
		spawnedRockNumber = 0;

		fruitTypeCount = 4;

		StartCoroutine( SpawnWaves () );
	}

	IEnumerator SpawnWaves(){
		yield return new WaitForSeconds(startWait );
		while(true){
			for(int i=0 ; i<objectCount ; i++){

				int fruitOrRock = Random.Range(0,2);
				if(fruitOrRock == 0 && spawnedFruitNumber >= fruitNumber){
					fruitOrRock = 1;
				}
				else if(fruitOrRock == 1 && spawnedRockNumber >= rockNumber){
					fruitOrRock = 0;
				}

				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				if(fruitOrRock == 0){
					spawnedFruitNumber++;
					int selectFruit = Random.Range(0,fruitTypeCount);
					
					if(selectFruit == 0){ Instantiate (redApple,spawnPosition,spawnRotation); }
					else if(selectFruit == 1){ Instantiate (banana,spawnPosition,spawnRotation); }
					else if(selectFruit == 2){ Instantiate (peach,spawnPosition,spawnRotation); }
					else if(selectFruit == 3){ Instantiate (lemon,spawnPosition,spawnRotation); }
				}
				else if(fruitOrRock == 1){
					spawnedRockNumber++;
					Instantiate (rock,spawnPosition,spawnRotation);
				}

				yield return new WaitForSeconds(spawnWait);
			}
			spawnedFruitNumber = 0;
			spawnedRockNumber = 0;
			yield return new WaitForSeconds(waveWait);
		}
	}


}
