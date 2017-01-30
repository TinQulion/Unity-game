using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerAttack : MonoBehaviour {
	public GUIStyle myGUIStyle;
	public List<GameObject> targets;
	public float attackTimer;
	public float coolDown;
	public bool m_Attack;
	public Image image;
	// Use this for initialization
	void Start () {
		attackTimer = 0;
		coolDown = 0.1f;

		GameObject[] enemyTargets = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemyTargets != null){
            foreach(GameObject go in enemyTargets){
                 targets.Add(go);
            }
        }
         
        GameObject[] moreTargets = GameObject.FindGameObjectsWithTag("Enemy");
        if (moreTargets != null){
            foreach(GameObject go in moreTargets){
                targets.Add(go);
            }
        }    
         
    }
	
	
	// Update is called once per frame
	void Update (){
}


	public void Attack(){

        float distance = float.MaxValue;
        if (targets == null) return;
         
        foreach (GameObject target in targets){
            if (target != null){
                distance = Vector3.Distance(target.transform.position, transform.position);
             
                if (distance < 3.5f){
                    EnemyHealth eh =(EnemyHealth)target.GetComponent("EnemyHealth");
                     
                    if (eh != null){
                        eh.AddjustCurrentHealth(-100);
                 	}
                     
                    EnemyHealth eh2 = (EnemyHealth)target.GetComponent("EnemyHealth");
                    if (eh2 != null){
                        eh2.AddjustCurrentHealth(-100);
                    }
                }
            }
        }
    }	


}