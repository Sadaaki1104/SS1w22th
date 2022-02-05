using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    RectTransform rec;
    [SerializeField] float TargetPosMin;
    [SerializeField] float TargetPosMax;
    [SerializeField] Vector3 NativePos;
    [SerializeField] float slotspeed;
    // Start is called before the first frame update
    void Start()
    {
        rec = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rec.localPosition += new Vector3(0,slotspeed * Time.deltaTime,0);
        if(TargetPosMin >= rec.localPosition.y)
        {
            rec.localPosition = NativePos;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            slotspeed = 0;
            StartCoroutine(ReStart());
        }
    }

    IEnumerator ReStart()
    {
        yield return new WaitForSeconds(2);
        slotspeed = -600;
    }
}
