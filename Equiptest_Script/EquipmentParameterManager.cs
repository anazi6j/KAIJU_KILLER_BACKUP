using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentManager
{

    //初期化して装備する
    //選択した装備を
    public class EquipmentParameterManager : MonoBehaviour
    {
        public float Playerattackpower;
        public float Playerweight;
        public float head_attackpower;
        public float LeftArm_attackpower;
        public float RightArm_attackpower;
        public float Body_attackpower;
        public float Leg_attackpower;

        public float head_weight;
        public float LeftArm_weight;
        public float RightArm_weight;
        public float Body_weight;
        public float Leg_weight;

        public Read_EquipmentFile Read_Equipment;
        public EquipmentIDmanager IDmanager;
        // Start is called before the first frame update
        void Start()
        {
            Initialize_equipmentparameter();

            
            
        }
        //

        void Initialize_equipmentparameter()
        {
            Playerattackpower = 0;
            Playerweight = 0;
            //部位毎に装備している装備のパラメーターを加算する
            //頭
            Playerattackpower += Read_Equipment.ES.headlist[IDmanager.Head_pointer].attackpower;
            Playerweight += Read_Equipment.ES.headlist[IDmanager.Head_pointer].weight;
            //右腕
         
            Playerattackpower += Read_Equipment.ES.rightarmlist[IDmanager.RightArm_pointer].attackpower;
            Playerweight += Read_Equipment.ES.rightarmlist[IDmanager.RightArm_pointer].weight;
           

        }

        

      public  void Equip_head(float in_attackpower,float in_weight)
        {


            Debug.Log("頭を装備した");
            head_attackpower = in_attackpower;
           head_weight = in_weight;

          
                    
            SetCurEquipmentID_Head(IDmanager.Head_pointer);
            setTotalparameter();


        }

        public void Equip_rightarm(float in_attackpower, float in_weight)
        {

               RightArm_attackpower = in_attackpower;
           RightArm_weight= in_weight;



            SetCurEquipmentID_Head(IDmanager.RightArm_pointer);
            setTotalparameter();


        }

        public void Equip_leftarm(float in_attackpower, float in_weight)
        {

            LeftArm_attackpower = in_attackpower;
           LeftArm_weight= in_weight;



            SetCurEquipmentID_RightArm(IDmanager.LeftArm_pointer);
            setTotalparameter();


        }


        public void Equip_Body(float in_attackpower, float in_weight)
        {

            Body_attackpower = in_attackpower;
            Body_weight = in_weight;



           SetCurEquipmentID_Body(IDmanager.Body_pointer);
            setTotalparameter();


        }

        public void Equip_leg(float in_attackpower, float in_weight)
        {

            Leg_attackpower = in_attackpower;
            Leg_weight = in_weight;



            SetCurEquipmentID_Leg(IDmanager.Leg_pointer);
            setTotalparameter();


        }


        //装備する(装備の攻撃力　装備の重さ　装備の種類
        /*
         装備するのが頭の場合

            頭の攻撃力　= 装備の攻撃力

            //の重さ　＝//の重さ

            //SetCurEquipmentID_head(IDmanager.RightArm_pointer);
            setTotalparameter();

            以下同じ要領で
             */


        void SetCurEquipmentID_Head(int in_id)
        {
            IDmanager.Head_pointer = in_id;
        }

        void SetCurEquipmentID_RightArm(int in_id)
        {
            IDmanager.RightArm_pointer = in_id;
        }

        void SetCurEquipmentID_Body(int in_id)
        {
            IDmanager.Body_pointer = in_id;
        }

        void SetCurEquipmentID_Leg(int in_id)
        {
            IDmanager.Body_pointer = in_id;
        }

       public void  setTotalparameter()
        {
            Debug.Log("現在の攻撃力" + Playerattackpower);
            Debug.Log("現在の重さ" + Playerweight);
            Playerattackpower = head_attackpower+LeftArm_attackpower + RightArm_attackpower + Leg_attackpower+Body_attackpower;
            Playerweight = head_weight + RightArm_weight + LeftArm_weight + LeftArm_weight + Leg_weight + Body_weight;
                
                }
    }
}