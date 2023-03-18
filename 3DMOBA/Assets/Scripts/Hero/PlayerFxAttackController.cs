using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFxAttackController : MonoBehaviour
{
    public GameObject normalAttack;

    public GameObject specialAttackPrefab1, 
    specialAttackPrefab2,  specialAttackPrefab3;

     public Transform specialAttackPrefabPosition1, 
    specialAttackPrefabPosition2,  specialAttackPrefabPosition3, normalAttackPosition;

    public Transform  specialAttackPrefabPosition2_1, specialAttackPrefabPosition2_2;


    public bool isLeiZhengzi;
    public bool isBadeerAngel;
    public bool isLianYou;
    public bool isLianKing;
    public bool isDarkSorcerer;
    public bool isEvilKing;
    
    // Here we script badeer angel
   
   void ActivateNormalAttack()
   {
    normalAttack.SetActive(true);
   }

    void DeactivateNormalAttack()
   {
    normalAttack.SetActive(false);
    
   }

   void SpawnSpecialAttackEffect1() 
   {
    if(isBadeerAngel || isLeiZhengzi)
    {
        Instantiate(specialAttackPrefab1,
        specialAttackPrefabPosition1.position, Quaternion.identity);
    }


    if(isLianYou || isEvilKing || isDarkSorcerer)
    {
        Instantiate(specialAttackPrefab1, specialAttackPrefabPosition1.position, transform.rotation);
    }

   }

   void SpawnSpecialAttackEffect2()
   {
        if(isLeiZhengzi || isEvilKing)
        {
            Instantiate(specialAttackPrefab2, specialAttackPrefabPosition2.position, transform.rotation);
        }

        if(isBadeerAngel)
        {
            GameObject special2 = Instantiate(specialAttackPrefab2);
            special2.transform.position =  specialAttackPrefabPosition2.position;
            special2.transform.SetParent(specialAttackPrefabPosition2);

            // call angel script
        }

        if(isLianYou)
        {
            Instantiate(specialAttackPrefab2, specialAttackPrefabPosition2.position, Quaternion.identity);
        }

        if(isDarkSorcerer) 
        {
            Instantiate(specialAttackPrefab3, specialAttackPrefabPosition2.position, transform.rotation);
            Instantiate(specialAttackPrefab3, specialAttackPrefabPosition2.position, transform.rotation);
            Instantiate(specialAttackPrefab3, specialAttackPrefabPosition2.position, transform.rotation);
        }
   }

   void SpawnSpecialAttackEffect3()
   {
    if(isLeiZhengzi || isBadeerAngel || isLianYou || isEvilKing) {
        Instantiate(specialAttackPrefab3, specialAttackPrefabPosition3.position, transform.rotation);
        
    }

    if(isDarkSorcerer) {
        Instantiate(specialAttackPrefab3, specialAttackPrefabPosition2.position, transform.rotation);
        Instantiate(specialAttackPrefab3, specialAttackPrefabPosition2_1.position, transform.rotation);
        Instantiate(specialAttackPrefab3, specialAttackPrefabPosition2_2.position, transform.rotation);
    }
   }// Especial fx 3

//For evil king and dark sorcerer
   void SpawnNormalAttackEffect()
   {
    Instantiate(normalAttack, normalAttackPosition.position, transform.rotation);

   }
}
