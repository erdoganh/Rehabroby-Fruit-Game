using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int score;
	public GUIText scoreText;

	public GameObject myAnimation1;
	public GameObject myAnimation2;

	void Start(){
		score = 0;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}

		if (other.tag == "Rock") {
			myAnimation1.animation.Play();
			score = score - 20;
			FruitPickerPausePose.takenRockNumber++;

			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
		} 
		else if(other.tag == "Banana" || other.tag == "Red_Apple" ||
		        other.tag == "Lemon" || other.tag == "Peach"){
			FruitPickerPausePose.takenFruitNumber++;
			myAnimation2.animation.Play();
			score = score + 10;
			Instantiate(explosion, transform.position, transform.rotation);
			Destroy(other.gameObject);
		}
		scoreText.guiText.text = "Score : " + score.ToString ();
	}
}