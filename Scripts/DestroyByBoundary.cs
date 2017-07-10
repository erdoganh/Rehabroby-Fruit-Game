using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		if( other.gameObject.transform.parent != null){
			if(other.gameObject.transform.parent.gameObject.tag != "Basket"){
				Destroy (other.gameObject.transform.parent.gameObject);
			}
		}
		else {
			if(other.gameObject.tag != "Basket"){
				Destroy (other.gameObject);
			}
		}
	}

	
}
