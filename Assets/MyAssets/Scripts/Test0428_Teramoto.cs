using UnityEngine;
using System.Collections;

public class Test0428_Teramoto : MonoBehaviour {

	public GameObject FirePrefab;

    private bool pushed = false;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            if (pushed == false)
            {
                // 生成する  👇プレハブ　　　👇生成位置              👇生成時点の角度
                Instantiate(FirePrefab, transform.position, Quaternion.identity);
             }

            pushed = true; // フラグ(旗)を立てる
        }
        else
        {
            pushed = false; // フラグを折る
        }
	}
}
