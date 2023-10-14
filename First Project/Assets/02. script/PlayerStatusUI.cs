using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;

public class PlayerStatusUI : MonoBehaviour
{
    [SerializeField] public Slider _hpBar;
    [SerializeField] public Player _player;

    void Start()
    {
        Debug.Log("Start");
        //_hpBar = GetComponent<RectTransform>().GetChild(0).GetComponent<Slider>();
        //GetComponentInChildren<Slider>();
        //�� ������Ʈ�� ������ GameObject�� ������ ������Ʈ�� ���� �ش� Ÿ���� ã�� ��ȯ
        //GetComponent<RectTransform>();

        _hpBar.minValue= 0.0f;
        _hpBar.maxValue= _player.hpMax;
        _hpBar.value = _player.hp;
        //_player.onHpChanged += RefreshHPBar;
        //�ζ��� �Լ� : �Լ� ������带 ���̱� ���� ��� �����θ� �ش� ���ο� ���� �����ϴ� �Լ�
        //C# ������ �ζ��� �Լ� ���� : �͸��Լ�(���ٽ�)�� ������
        //���ٽ� : �����Ϸ��� �Ǵ��Ҽ� �ִ� �ڵ带 ��� �����ϰ� �̸��� ������ �Լ���
        _player.onHpChanged += (value) => _hpBar.value = value;
    }

    public void RefreshHPBar(float value)
    {
        _hpBar.value = value;
    }

}
