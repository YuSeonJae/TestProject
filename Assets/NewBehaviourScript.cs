using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �ʱ�ȭ - 1
    private void Awake()
    {
        Debug.Log("�ʱ�ȭ1Awake");
    }

    // �ʱ�ȭ - 2
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("�ʱ�ȭ2 Start");
    }

    // �������� ������ ȣ��
    private void FixedUpdate()
    {

    }

    // �� Frame ���� ȣ��
    // Update is called once per frame
    private void Update()
    {

    }

    // ���� �ֵ� ������
    private void LateUpdate()
    {

    }

    private void OnEnable()
    {
        Debug.Log("������.");
    }

    private void OnDisable()
    {
        Debug.Log("������.");
    }
}
