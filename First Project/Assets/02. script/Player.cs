using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

public class Operatable<T>
{
    public T value;
    public static Operatable<T> operator +(Operatable<T> a, Operatable<T> b)
    {
        return a;
    }
}

public class Player : MonoBehaviour
{

    public float hp
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value == _hp)
                return;

            _hp = value;
            onHpChanged(value);
        }
    }
    [SerializeField]public float _hp; // SerializeField : �����͸� �ؽ�Ʈ��, Deserialize : �ؽ�Ʈ�� �����ͷ�

    public float hpMax
    {
        get
        {
            return _hpMax;
        }
    }
    [SerializeField] public float _hpMax = 100;
    public delegate void onHpChangedHandler(float value);
    //public event onHpChangedHandler onHpChanged;
    public event Action<float> onHpChanged;

    //Action �븮��
    public Action<int, float, string> action;

    //Func �븮��
    //�Ķ���͸� 0~16�� ���� ���� �� �ִ�
    //void �� ��ȯ�ϴ� ������ �븮��
    public Func<int, float, string> func;

    //Predicate �븮��
    //�Ķ���� 1�� �ް�
    //bool Ÿ���� ��ȯ�ϴ� ������ �븮��
    //� �������� match ������ �˻��Ҷ� �����
    public Predicate<int> match;

    //Generic
    //� Ÿ���� �Ϲ�ȭ �ϴ� ��������� ����

    //where ������
    //Generic Ÿ���� � Ÿ������ ������������ ������ �Ŵ� ������
    public T Sum<T>(T a, T b)
        where T : Operatable<T>
        => (a + b).value;

    public int Sum(int a, int b)
        => a + b;

    public float Sum(float a, float b)
        => a + b;

    public double Sum(double a, double b)
        => a + b;


    public void DepleteHP(float amout)
    {
        hp -= amout;
    }
}
