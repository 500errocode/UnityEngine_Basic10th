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
        //이 컴포넌트를 가지는 GameObject가 가지는 컴포넌트를 통해 해당 타입을 찾아 반환
        //GetComponent<RectTransform>();

        _hpBar.minValue= 0.0f;
        _hpBar.maxValue= _player.hpMax;
        _hpBar.value = _player.hp;
        //_player.onHpChanged += RefreshHPBar;
        //인라인 함수 : 함수 오버헤드를 줄이기 위해 기능 구현부를 해당 라인에 직접 삽입하는 함수
        //C# 에서의 인라인 함수 구현 : 익명함수(람다식)로 구현함
        //람다식 : 컴파일러가 판단할수 있는 코드를 모두 생략하고 이름을 생략한 함수식
        _player.onHpChanged += (value) => _hpBar.value = value;
    }

    public void RefreshHPBar(float value)
    {
        _hpBar.value = value;
    }

}
