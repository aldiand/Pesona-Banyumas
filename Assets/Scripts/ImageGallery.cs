using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageGallery : MonoBehaviour {
    public Texture[] image;
    int maxTextures;
    int arrayPos = 0;
    Renderer rend;
	// Use this for initialization
	void Start () {
        maxTextures = image.Length-1;
        rend = GetComponent<Renderer>();
	}
	
    public void changeImage(){
        rend.material.mainTexture = image[arrayPos];
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void next(){
        if (arrayPos + 1 < maxTextures)
        {
            arrayPos++;
        }
        else
        {
            arrayPos = 0;
        }
        changeImage();
    }
    public void prev(){
        if(arrayPos - 1 > 0)
        {
            arrayPos--;
        }
        else
        {
            arrayPos = maxTextures;
        }
        changeImage();
    }

}
