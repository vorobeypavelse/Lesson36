using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//����������

public class PlayerControl38 : MonoBehaviour
//�������� ������    
{
    //lesson 39
    public int speed = 20;

    void Start()
    //����� ������ 1 ���
    {
        
    }

  
    void Update()
    //����� ������ ����� ���
    {
        // ��� ������� ������ ���� ���������
        //Translate ������� ��� ������������
        //new Vector3 ������� ��������
        //lessson 38
        //transform.Translate(new Vector3(0,0,1));

        //lesson 39
        // Time.deltaTime - ������� ����� ����� 2 ������� ���� . ��������� ��� speed
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
