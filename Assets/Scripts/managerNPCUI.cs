using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class managerNPCUI : MonoBehaviour
{
    private GameObject objPlayer;
    public Image prefabUi;
    private Image uiUse;
    private Transform tr_Indicator;
    private Vector3 offSet = new Vector3(0, 1.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        objPlayer = GameObject.FindGameObjectWithTag("Player");
        uiUse = Instantiate(prefabUi, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
        tr_Indicator = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        uiUse.transform.position = Camera.main.WorldToScreenPoint(tr_Indicator.position + offSet);
        //distance
        float dist = 1/Vector3.Distance(transform.position, objPlayer.transform.position)*4f;
        //UI size change
        dist = Mathf.Clamp(dist, 1f, 2.0f);
        uiUse.transform.localScale = new Vector3(dist, dist, 0);
    }
}
