using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class OrdinateurSocket : MonoBehaviour
{
    public int a = 0;
    public void OnSelect(SelectEnterEventArgs args)
    {

        a++;

        Debug.Log(args.interactorObject.transform.name);
      

    }

    public void Update()
    {
        if (a == 1)
            this.gameObject.transform.Find("boutonrouge1").gameObject.SetActive(false);
        if (a == 2)
            this.gameObject.transform.Find("boutonrouge2").gameObject.SetActive(false);
        if (a == 3)
            this.gameObject.transform.Find("Future_Door_Final").gameObject.transform.Find("Right_Door_Final").gameObject.SetActive(false);
    }
}
