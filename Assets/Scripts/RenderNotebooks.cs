using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evernote.EDAM.Type;

public class RenderNotebooks : MonoBehaviour {

	public GameObject prefabNotebook;

	// Use this for initialization
	// change this to occur on a trigger

	void Awake () {
		Notebook[] nbs = { new Notebook() };
		nbs [0].Name = "Leo Gong";
			
		foreach (Notebook n in nbs) {
			Instantiate(prefabNotebook, new Vector3(i * 2.0f, 0, 4), Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
