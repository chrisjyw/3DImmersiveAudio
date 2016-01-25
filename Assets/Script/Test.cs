using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour {
	private Vector3 targetPosition = new Vector3(0,2,10); 
	private float [] dampVelocity = {0,0,0};
	private float transitionSmoothing = 500;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float x=0, y=0, z=0;
		for(int i = 0; i < 3; i++)
		{	
			if(i == 0){
				x=Mathf.SmoothDamp(transform.position[i], targetPosition[i], ref dampVelocity[i], transitionSmoothing * Time.deltaTime); 
			}
			if(i == 1){
				y=Mathf.SmoothDamp(transform.position[i], targetPosition[i], ref dampVelocity[i], transitionSmoothing * Time.deltaTime); 
			}
			if(i == 2){
				z=Mathf.SmoothDamp(transform.position[i], targetPosition[i], ref dampVelocity[i], transitionSmoothing * Time.deltaTime); 
			}

		}
		transform.position = new Vector3 (x, y, z);

	}

}
