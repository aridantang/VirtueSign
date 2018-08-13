using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	
	public void simulasi () {
		Application.LoadLevel (1);
	}

	public void panduan () {
		Application.LoadLevel (2);
	}

	public void tentang () {
		Application.LoadLevel (3);
	}

	public void keluar(){
		Application.Quit();
	}
}
