using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	//references to our blueprints/PREFABS
	public Transform buildingPrefab; 
	public Transform statueOfLibertyMallPrefab;
	public Transform streetLampPrefab;
	public Transform taxiPrefab;
	public Transform treePrefab;

	int sceneCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (sceneCount < 500) {
			//float randomNumber = Random.Range (0f, 10f);

			if (Random.value <= .10f) {
				//spawn a building
				Instantiate (buildingPrefab, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity); 
			} 
			else if (Random.value <= .25f){
				//spawn a statue
				Instantiate (statueOfLibertyMallPrefab, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity); 
			} 
			else if (Random.value <= .20f) {
				//spawn a lamp
				Instantiate (streetLampPrefab, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			} 
			else if (Random.value <= .20f){
				//spawn a taxi
				Instantiate (taxiPrefab, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
			else if (Random.value <= .25f){
				//spawn a tree
				Instantiate (treePrefab, new Vector3 (Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
			}
			sceneCount = sceneCount + 1;
		}
	}
}
