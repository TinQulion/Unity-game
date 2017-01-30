using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameSound : MonoBehaviour {


	public AudioClip[] list;

	// Use this for initialization
	void Start () {
		list =  new AudioClip[]{(AudioClip)Resources.Load("SpeletsLjud/Swing1"),
                	(AudioClip)Resources.Load("SpeletsLjud/Swing2"), 
                    (AudioClip)Resources.Load("SpeletsLjud/Swing3"), 
                    (AudioClip)Resources.Load("SpeletsLjud/Swing4"),
                    (AudioClip)Resources.Load("SpeletsLjud/Swing5"),
                    (AudioClip)Resources.Load("SpeletsLjud/Swing6")
                };

		
	}
	
	// Update is called once per frame
	void Update () {

		
	
	}

	public void OnClick(){
		GetComponent<AudioSource>().clip = list[Random.Range(0, list.Length)];
		GetComponent<AudioSource>().Play();
	}
}
