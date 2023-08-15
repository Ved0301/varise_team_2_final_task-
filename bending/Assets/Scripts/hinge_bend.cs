using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinge_bend : MonoBehaviour
{
   public GameObject c_1,c_2,c_3,c_4;
   public static string IS_CLICKED= "isClicked";
   private Animator a_1,a_2,a_3,a_4;

   private void Awake()
   {
        a_1 = GetComponent<Animator>();
        a_2 = GetComponent<Animator>();
        a_3 = GetComponent<Animator>();
        a_4 = GetComponent<Animator>();
   }

   void Update()
   {
        a_1.SetBool(IS_CLICKED,true);
        a_2.SetBool(IS_CLICKED,true);
        a_3.SetBool(IS_CLICKED,true);
        a_4.SetBool(IS_CLICKED,true);
   }
}
