using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour {

    public GameObject towerPrefab;
    private GameObject tower;

    private bool canPlaceTower()
    {
        return tower == null;
    }

    private void OnMouseUp()
    {
        if (canPlaceTower())
        {
            tower = (GameObject)Instantiate(towerPrefab, transform.position, Quaternion.identity);

            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);

        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
