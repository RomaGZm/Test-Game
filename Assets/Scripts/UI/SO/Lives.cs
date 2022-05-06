using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LivesData", menuName = "ScriptableObjects/LivesData", order = 1)]
public class Lives : ScriptableObject
{
     
    public int livesCounter = 0;
    public int  timerCounter = 0;

}
