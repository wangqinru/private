using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    [SerializeField]
    RectTransform canvas;

    [SerializeField]
    GameObject damageObject;

    [SerializeField]
    Sprite[] damageTextures;

    [SerializeField]
    int damage = 34512;

    private void Start()
    {
        CreateDamage(damage, new Vector2(50.0f, 50.0f));
    }

    void CreateDamage(int dmg, Vector2 pos)
    {
        GameObject obj = Instantiate(damageObject);

        obj.transform.SetParent(canvas, false);
        obj.transform.localPosition = pos;

        DamageSample dmgSctipt = obj.GetComponent<DamageSample>();

        dmgSctipt.SetDamage(dmg, damageTextures);
    }
}
