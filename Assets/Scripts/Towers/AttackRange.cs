using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRange : MonoBehaviour
{
    public LayerMask enemyMask;

    private void OnTriggerEnter(Collider other)
    {
        // if(other.gameObject.layer == enemyMask) LayerMask랑 layer는 다름, bit mask에 대한 이해
        // Utills에 확장메서드로 구현

        if (enemyMask.IsContaion(other.gameObject.layer))
        {

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (enemyMask.IsContaion(other.gameObject.layer))
        {

        }
    }
}
