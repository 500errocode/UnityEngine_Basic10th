using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Runner : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    //�̵��Ÿ� = �ӷ� * �ð�
    // ���� �����Ӵ� �̵��Ÿ� = �ӷ� * ���� �����Ӱ� �ð���ȭ
    private void FixedUpdate()
    {
        //transform.position.z += Vector3.forward * _speed * Time.fixedDeltaTime;
        transform.Translate(Vector3.forward * _speed * Time.fixedDeltaTime);
    }
}
