using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cometTail : MonoBehaviour
{
	public Transform cometContainer;
	public GameObject cometPrefab;

    	// Start is called before the first frame update
    	void Start()
    	{
        	cometContainer = GameObject.Find("CometContainer").transform;
    	}

    	// Update is called once per frame
    	void Update()
    	{
        	Instantiate(cometPrefab, transform.position,
				Quaternion.identity, cometContainer);
    	}
}
