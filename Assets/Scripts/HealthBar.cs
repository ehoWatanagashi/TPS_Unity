using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image _bar;
    public float _maxValue = 1f;
    public float _current;
    void Start()
    {
        _current = _maxValue;
       // var bar = gameObject.CompareTag("Bar");
    }


    void Update()
    {
        // _fill -=  Time.deltaTime * 0.1f;
        //AdjustCurrentValue(-0.0005f);
        _bar.fillAmount = _current;



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ammo"))
        {
            AdjustCurrentValue(-0.1f);
            Debug.Log("Попал!");
        }
    }

    public  void AdjustCurrentValue(float adjust)
    {
        _current += adjust;
    }

}
