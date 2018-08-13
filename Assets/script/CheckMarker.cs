using UnityEngine;
using System.Collections;
using Vuforia;

public class CheckMarker : MonoBehaviour, ITrackableEventHandler  {

	private TrackableBehaviour mTrackableBehaviour;
	
	private bool mShowGUIButton, menu, showInfo = false;
	public GameObject objekHuruf, objekAngka;

	public GUISkin guiSkin;
	
	//the GUI scale ratio
	private float guiRatio;
	
	//the screen width
	private float sWidth;
	public Vector2 scrollPosition1 = Vector2.zero;
	
	//A vector3 that will be created using the scale ratio
	private Vector3 GUIsF;


	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
		//get the screen's width
		sWidth = Screen.width;
		//calculate the scale ratio
		guiRatio = sWidth/1920;
		//create a scale Vector3 with the above ratio
		GUIsF = new Vector3(guiRatio,guiRatio,1);
	
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED)
		{
			mShowGUIButton = true;
			Animation anim0 = objekAngka.GetComponent<Animation>();
			anim0 ["1"].speed = 0.2f;
			anim0 ["2"].speed = 0.2f;
			anim0 ["3"].speed = 0.2f;
			anim0 ["4"].speed = 0.2f;
			anim0 ["5"].speed = 0.2f;
			anim0 ["6"].speed = 0.2f;
			anim0 ["7"].speed = 0.2f;
			anim0 ["8"].speed = 0.2f;
			anim0 ["9"].speed = 0.2f;
			Animation anim = objekHuruf.GetComponent<Animation>();
			anim ["A"].speed = 0.2f;
			anim ["B"].speed = 0.2f;
			anim ["C"].speed = 0.2f;
			anim ["D"].speed = 0.2f;
			anim ["E"].speed = 0.2f;
			anim ["F"].speed = 0.2f;
			anim ["G"].speed = 0.2f;
			anim ["H"].speed = 0.2f;
			anim ["I"].speed = 0.2f;
			anim ["J"].speed = 0.2f;
			anim ["K"].speed = 0.2f;
			anim ["L"].speed = 0.2f;
			anim ["M"].speed = 0.2f;
			anim ["N"].speed = 0.2f;
			anim ["O"].speed = 0.2f;
			anim ["P"].speed = 0.2f;
			anim ["Q"].speed = 0.2f;
			anim ["R"].speed = 0.2f;
			anim ["S"].speed = 0.2f;
			anim ["T"].speed = 0.2f;
			anim ["U"].speed = 0.2f;
			anim ["V"].speed = 0.2f;
			anim ["W"].speed = 0.2f;
			anim ["X"].speed = 0.2f;
			anim ["Y"].speed = 0.2f;
			anim ["Z"].speed = 0.2f;
			anim.Play();
		}
		else
		{
			mShowGUIButton=false;
		}
	}
	
	void OnGUI() {
		GUI.skin = guiSkin;

		if (mShowGUIButton) {

			GUI.matrix = Matrix4x4.TRS(new Vector3(GUIsF.x,Screen.height - 89*GUIsF.y,0),Quaternion.identity,GUIsF);

			GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width - 258*GUIsF.x,Screen.height - 89*GUIsF.y,0),Quaternion.identity,GUIsF);

//			if(GUI.RepeatButton(new Rect(-100,-60,320,150), "PUTAR KANAN")) {
//				objekHuruf.transform.Rotate(Vector3.up * 20f * - Time.deltaTime, Space.World);
//				objekAngka.transform.Rotate(Vector3.up * 20f * - Time.deltaTime, Space.World);
//			}
//
//			if(GUI.RepeatButton(new Rect(-450,-60,320,150), "PUTAR KIRI")) {
//				objekHuruf.transform.Rotate(Vector3.up * 20f * Time.deltaTime, Space.World);
//				objekAngka.transform.Rotate(Vector3.up * 20f * Time.deltaTime, Space.World);
//			}
		}
	}
}
