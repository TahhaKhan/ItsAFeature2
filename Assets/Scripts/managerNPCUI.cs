using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class managerNPCUI : MonoBehaviour
{
    public Image prefabUi;
    private Image uiUse;
    private Transform tr_Indicator;
    private Vector3 offSet = new Vector3(0, 1.5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        uiUse = Instantiate(prefabUi, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
        tr_Indicator = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        uiUse.transform.position = Camera.main.WorldToScreenPoint(tr_Indicator.position + offSet);
    }
}
