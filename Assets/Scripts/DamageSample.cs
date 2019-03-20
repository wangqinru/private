using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageSample : MonoBehaviour
{
    [SerializeField]
    Image[] damageImages;

    public void SetDamage(int dmg, Sprite[] damageTextures)
    {
        string damageText = dmg.ToString();

        if (damageText.Length > damageImages.Length) { return; }

        for (int i = 0; i < damageImages.Length; i++)
        {
            if (i >= damageText.Length)
            {
                damageImages[i].gameObject.SetActive(false);
                continue;
            }

            int num = int.Parse(damageText.Substring(i, 1));
            if (num >= damageTextures.Length) { return; }

            if (i >= damageImages.Length) { return; }
            damageImages[i].sprite = damageTextures[num];

            damageImages[i].gameObject.SetActive(true);
        }
    }

}
