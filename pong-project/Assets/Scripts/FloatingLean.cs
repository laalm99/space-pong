using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingLean : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] float to;

    void Start()
    {
        LeanTween.moveY(GetComponent<RectTransform>(), to, time).setLoopPingPong();

       
    }
}
