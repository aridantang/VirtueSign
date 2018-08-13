using UnityEngine;
using System.Collections;

public class backLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
			if (Input.GetKey(KeyCode.Escape))
			{
				Application.LoadLevel(0);
				
				return;
			}
	}
}