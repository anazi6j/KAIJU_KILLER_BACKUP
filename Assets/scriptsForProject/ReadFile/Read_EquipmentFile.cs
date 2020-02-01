using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using EquipmentManager;
namespace EquipmentManager
{
    
    public class Read_EquipmentFile : MonoBehaviour
    {
     
  
        //public List<Weapon> weapon_tempo;
       public  Equipment_Scriptable ES;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        

        public void Initialize(ref List<Head> head_tempo, ref List<Right_arm> rightarm_tempo, ref List<Left_arm> leftarm_tempo, ref List<Body> body_tempo, ref List<Leg> leg_tempo)
        {
                for ( int head = 0; head < ES.headlist.Count; head++)
                {
                Head add = gameObject.AddComponent<Head>();
                add.AddElement(ES.headlist[head].Objectparts, ES.headlist[head].meshparts);
                head_tempo.Add(add);
                }
               
            
        
            for(int rightarm =0;rightarm < ES.rightarmlist.Count;rightarm++)
            {
                Right_arm add = gameObject.AddComponent<Right_arm>();
                add.AddelementExceptHead(ES.rightarmlist[rightarm].Objectparts, ES.rightarmlist[rightarm].meshparts, ES.rightarmlist[rightarm].attackpower,ES.rightarmlist[rightarm].weight);
                rightarm_tempo.Add(add);
            }

            
            for (int leftarm = 0; leftarm < ES.leftarmlist.Count; leftarm++)
            {
                Left_arm add = gameObject.AddComponent<Left_arm>();
                add.AddelementExceptHead(ES.leftarmlist[leftarm].Objectparts, ES.leftarmlist[leftarm].meshparts, ES.leftarmlist[leftarm].attackpower, ES.leftarmlist[leftarm].weight);
                leftarm_tempo.Add(add);
            }

            for (int leg = 0; leg < ES.leglist.Count; leg++)
            {
                Leg add = gameObject.AddComponent<Leg>();
                add.AddelementExceptHead(ES.leglist[leg].Objectparts, ES.leglist[leg].meshparts, ES.leglist[leg].attackpower, ES.leglist[leg].weight);
                leg_tempo.Add(add);
            }

            for (int body = 0; body < ES.bodylist.Count; body++)
            {
                Body add = gameObject.AddComponent<Body>();
                add.AddelementExceptHead(ES.bodylist[body].Objectparts, ES.bodylist[body].meshparts, ES.bodylist[body].attackpower, ES.bodylist[body].weight);
                body_tempo.Add(add);
            }


        }
        
    }

}
