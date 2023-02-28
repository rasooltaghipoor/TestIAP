using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAP : MonoBehaviour
{
    public void InPurchaseSuccess(){
        Debug.Log("Test1 purchase successful");
    }

    public void InPurchaseFailure(){
        Debug.Log("Test1 purchase failed");    
    }
}
