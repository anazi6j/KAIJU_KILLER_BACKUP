using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EquipmentManager
{
    public abstract class Equipment : MonoBehaviour
    {
       public GameObject Objectparts;

       public  MeshFilter meshparts;

        public float attackpower;
        public float weight;
        public float equipNo;
        public AnimationClip Animation;
        public virtual void AddElement(GameObject in_g, MeshFilter in_M)
        {
            this.Objectparts = in_g;
            this.meshparts = in_M;
          
        }

        public virtual void AddelementExceptHead(GameObject in_g, MeshFilter in_M,float in_attackpower=0,float in_weight=0,AnimationClip in_animationClip=null)
        {
            this.Objectparts = in_g;
            this.meshparts = in_M;
           
            if(in_attackpower != 0)
            {
                this.attackpower = in_attackpower;
            }
            if(in_animationClip != null)
            {
                this.Animation = in_animationClip;
            }

            if(in_weight != 0)
            {
                this.weight = in_weight;
            }

        }

    }
    

   
}