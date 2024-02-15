using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cometFade : MonoBehaviour
{
    	// Update is called once per frame
    	void Update()
    	{
        	for (int i = 0; i < transform.childCount; i++)
		{
			Transform c = transform.GetChild(i);
			SpriteRenderer sr = c.GetComponent<SpriteRenderer>();

			Color fade = new Color(0.0f, 0.0f, 0.0f, 0.1f);
			sr.color = sr.color - fade;

			if (sr.color.a <= 0.0f) Destroy(c);
		}
    	}
}
