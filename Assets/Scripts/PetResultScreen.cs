using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetResultScreen : MonoBehaviour
{
    int level;
    int atk;
    int def;
    int hp;
    int mp;
    int xp;

    [SerializeField] Texture pet1Sprite;
    [SerializeField] Texture pet1UpgradedSprite;

    [SerializeField] Texture pet2Sprite;
    [SerializeField] Texture pet2UpgradedSprite;

    [SerializeField] Texture pet3Sprite;
    [SerializeField] Texture pet3UpgradedSprite;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if(bool.Parse(PlayerPrefs.GetString("pet1Chosen")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet1Upgraded")))
            {
                gameObject.GetComponentInChildren<RawImage>().texture = pet1UpgradedSprite;
            }
            gameObject.GetComponentInChildren<RawImage>().texture = pet1Sprite;
        }

        else if (bool.Parse(PlayerPrefs.GetString("pet2Chosen")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet2Upgraded")))
            {
                gameObject.GetComponentInChildren<RawImage>().texture = pet2UpgradedSprite;
            }
            gameObject.GetComponentInChildren<RawImage>().texture = pet2Sprite;
        }

        else if (bool.Parse(PlayerPrefs.GetString("pet3Chosen")))
        {
            if (bool.Parse(PlayerPrefs.GetString("pet3Upgraded")))
            {
                gameObject.GetComponentInChildren<RawImage>().texture = pet3UpgradedSprite;
            }
            gameObject.GetComponentInChildren<RawImage>().texture = pet3Sprite;
        }
    }

    void IncreaseLevel(int petId)
    {
        switch(petId)
        {
            case 1:
                level = PlayerPrefs.GetInt("pet1Level");
                atk = PlayerPrefs.GetInt("pet1Atk");
                def = PlayerPrefs.GetInt("pet1Def");
                hp = PlayerPrefs.GetInt("pet1Hp");
                mp = PlayerPrefs.GetInt("pet1Mp");
                level += 1;
                if (level >= 15)
                {
                    PlayerPrefs.SetString("pet1Upgraded", "true");
                }
                if (level < 15)
                {
                    atk += 1;
                    def += 1;
                    hp += 1;
                    mp += 3;
                }
                else
                {
                    atk += 2;
                    def += 1;
                    hp += 2;
                    mp += 4;
                }
                PlayerPrefs.SetInt("pet1Level", level);
                PlayerPrefs.SetInt("pet1Atk", atk);
                PlayerPrefs.SetInt("pet1Def", def);
                PlayerPrefs.SetInt("pet1Hp", hp);
                PlayerPrefs.SetInt("pet1Mp", mp);
                break;

            case 2:
                level = PlayerPrefs.GetInt("pet2Level");
                atk = PlayerPrefs.GetInt("pet2Atk");
                def = PlayerPrefs.GetInt("pet2Def");
                hp = PlayerPrefs.GetInt("pet2Hp");
                mp = PlayerPrefs.GetInt("pet2Mp");
                level += 1;
                if (level >= 10)
                {
                    PlayerPrefs.SetString("pet2Upgraded", "true");
                }
                if (level < 10)
                {
                    atk += 2;
                    def += 2;
                    hp += 3;
                    mp += 1;
                }
                else
                {
                    atk += 2;
                    def += 2;
                    hp += 4;
                    mp += 1;
                }
                PlayerPrefs.SetInt("pet2Level", level);
                PlayerPrefs.SetInt("pet2Atk", atk);
                PlayerPrefs.SetInt("pet2Def", def);
                PlayerPrefs.SetInt("pet2Hp", hp);
                PlayerPrefs.SetInt("pet2Mp", mp);
                break;

            case 3:
                level = PlayerPrefs.GetInt("pet3Level");
                atk = PlayerPrefs.GetInt("pet3Atk");
                def = PlayerPrefs.GetInt("pet3Def");
                hp = PlayerPrefs.GetInt("pet3Hp");
                mp = PlayerPrefs.GetInt("pet3Mp");
                level += 1;
                if (level >= 12)
                {
                    PlayerPrefs.SetString("pet3Upgraded", "true");
                }
                if (level < 12)
                {
                    atk += 2;
                    def += 1;
                    hp += 1;
                    mp += 1;
                }
                else
                {
                    atk += 3;
                    def += 1;
                    hp += 2;
                    mp += 1;
                }
                PlayerPrefs.SetInt("pet3Level", level);
                PlayerPrefs.SetInt("pet3Atk", atk);
                PlayerPrefs.SetInt("pet3Def", def);
                PlayerPrefs.SetInt("pet3Hp", hp);
                PlayerPrefs.SetInt("pet3Mp", mp);
                break;
        }
    }

    public int IncreaseXp(int petId,int addedXp)
    {
        switch (petId)
        {
            case 1:
                xp = PlayerPrefs.GetInt("pet1Xp");
                level = PlayerPrefs.GetInt("pet1Level");
                xp += addedXp;
                if (xp >= (300 + level * 30) && level < 10)
                {
                    while (xp >= (300 + level * 30))
                    {
                        xp -= (300 + level * 30);
                        IncreaseLevel(1);
                        level = PlayerPrefs.GetInt("pet1Level");
                    }
                }
                else if (xp >= (500 + level * 30))
                {
                    while (xp >= (500 + level * 30))
                    {
                        xp -= (500 + level * 30);
                        IncreaseLevel(1);
                        level = PlayerPrefs.GetInt("pet1Level");
                    }
                }
                PlayerPrefs.SetInt("pet1Xp", xp);
                break;

            case 2:
                xp = PlayerPrefs.GetInt("pet2Xp");
                level = PlayerPrefs.GetInt("pet2Level");
                xp += addedXp;

                if (xp >= (450 + level * 50) && level < 15)
                {
                    while (xp >= (450 + level * 50))
                    {
                        xp -= (450 + level * 50);
                        IncreaseLevel(2);
                        level = PlayerPrefs.GetInt("pet2Level");
                    }
                }
                else if (xp >= (750 + level * 50))
                {
                    while (xp >= (750 + level * 50))
                    {
                        xp -= (750 + level * 50);
                        IncreaseLevel(2);
                        level = PlayerPrefs.GetInt("pet2Level");
                    }
                }

                PlayerPrefs.SetInt("pet2Xp", xp);
                break;

            case 3:
                xp = PlayerPrefs.GetInt("pet3Xp");
                level = PlayerPrefs.GetInt("pet3Level");
                xp += addedXp;
                if (xp >= (400 + level * 40) && level < 12)
                {
                    while(xp >= (400 + level * 40))
                    {
                        xp -= (400 + level * 40);
                        IncreaseLevel(3);
                        level = PlayerPrefs.GetInt("pet3Level");
                    }
                }
                else if (xp >= (600 + level * 40))
                {
                    while(xp >= (600 + level * 40))
                    {
                        xp -= (600 + level * 40);
                        IncreaseLevel(3);
                        level = PlayerPrefs.GetInt("pet3Level");
                    }
                }
                PlayerPrefs.SetInt("pet3Xp", xp);
                break;
            default: break;
        }
        return xp;
    }
}
