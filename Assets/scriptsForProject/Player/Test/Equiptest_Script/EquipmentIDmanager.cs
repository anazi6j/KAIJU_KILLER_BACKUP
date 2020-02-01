using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
namespace EquipmentManager
{
    public enum Part
    {
        HEAD=0,
        BODY=1,
        RIGHTARM=2,
        LEFTARM=3,
        LEG=4,
        SAVE=5
        //武器は要らない。腕にする
    }
    

    public class EquipmentIDmanager : MonoBehaviour
    {
        public Write_Equipment Write_Equipment;

        public int PointerVertical;
        public int Head_pointer;
        public int LeftArm_pointer;
        public int RightArm_pointer;
        public int Body_pointer;
        public int Leg_pointer;
        public Part partpointer;
        //十字キーで部位と装備を選択する
        public Read_EquipmentFile Read_Equipment;
        public EquipmentParameterManager equipmentParameter;
        private void Start()
        {
            

            equipmentParameter.head_attackpower = Read_Equipment.ES.headlist[Head_pointer].attackpower;
            equipmentParameter.head_weight = Read_Equipment.ES.headlist[Head_pointer].weight;
            equipmentParameter.RightArm_attackpower = Read_Equipment.ES.rightarmlist[RightArm_pointer].attackpower;
            equipmentParameter.RightArm_weight= Read_Equipment.ES.rightarmlist[RightArm_pointer].weight;
            equipmentParameter.LeftArm_attackpower = Read_Equipment.ES.leftarmlist[LeftArm_pointer].attackpower;
            equipmentParameter.LeftArm_weight = Read_Equipment.ES.leftarmlist[LeftArm_pointer].weight;
            equipmentParameter.Body_attackpower = Read_Equipment.ES.bodylist[Body_pointer].attackpower;
            equipmentParameter.Body_weight = Read_Equipment.ES.bodylist[Body_pointer].weight;
            equipmentParameter.Leg_attackpower = Read_Equipment.ES.leglist[Leg_pointer].attackpower;
            equipmentParameter.Leg_weight = Read_Equipment.ES.leglist[Leg_pointer].weight;

            equipmentParameter.setTotalparameter();
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                if(PointerVertical<=(int)Part.SAVE)
                {
                    PointerVertical++;
                }
            }else if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(PointerVertical >0)
                {
                    PointerVertical--;
                }
            }

            switch (PointerVertical)
            {
                case 0:

                    partpointer = Part.HEAD;
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (Head_pointer < Read_Equipment.ES.headlist.Count-1)
                        {
                            Head_pointer++;
                        }

                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (Head_pointer > 0)
                            Head_pointer--;
                    }

                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        equipmentParameter.Equip_head(Read_Equipment.ES.headlist[Head_pointer].attackpower, Read_Equipment.ES.headlist[Head_pointer].weight);
                    }
                    break;

                case 1:

                    partpointer = Part.LEFTARM;
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (LeftArm_pointer < Read_Equipment.ES.leftarmlist.Count-1)
                        {
                            LeftArm_pointer++;
                        }

                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (LeftArm_pointer >0)
                            LeftArm_pointer--;
                    }

                    if(Input.GetKeyDown(KeyCode.K))
                    {
                        equipmentParameter.Equip_leftarm(Read_Equipment.ES.leftarmlist[LeftArm_pointer].attackpower, Read_Equipment.ES.leftarmlist[LeftArm_pointer].weight);
                    }


                    break;

                case 2:
                    partpointer = Part.RIGHTARM;
                    
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (RightArm_pointer < Read_Equipment.ES.rightarmlist.Count-1)
                        {
                            RightArm_pointer++;
                        }

                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (RightArm_pointer > 0)
                            RightArm_pointer--;
                    }

                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        equipmentParameter.Equip_rightarm(Read_Equipment.ES.rightarmlist[RightArm_pointer].attackpower, Read_Equipment.ES.rightarmlist[RightArm_pointer].weight);
                    }

                    break;

                case 3:
                    partpointer = Part.BODY;
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (Body_pointer < Read_Equipment.ES.bodylist.Count)
                         Body_pointer++;
                        

                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (Body_pointer > 0)
                            Body_pointer--;
                        
                    }

                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        equipmentParameter.Equip_Body(Read_Equipment.ES.bodylist[Body_pointer].attackpower, Read_Equipment.ES.bodylist[Body_pointer].weight);
                    }

                    break;

                case 4:
                    partpointer = Part.LEG;
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (Leg_pointer < Read_Equipment.ES.leglist.Count-1)
                        {
                           Leg_pointer++;
                        }

                    }

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (Leg_pointer > 0)
                            Leg_pointer--;
                        
                    }

                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        equipmentParameter.Equip_leg(Read_Equipment.ES.leglist[Leg_pointer].attackpower, Read_Equipment.ES.leglist[Leg_pointer].weight);
                    }

                    break;

                case 5:
                    partpointer = Part.SAVE;

                    if(Input.GetKeyDown(KeyCode.K))
                    {
                        Write_Equipment.Save_Equip();
                    }

                    break;
            }

           
        }
        


        void Save_Equip()
        {

            string headpointer = Head_pointer.ToString();
            
            var filepath = "C:\\Users\\Kanta yukawa\\KAIJU_KILLER_Unity2019\\Assets\\scriptsForProject\\SaveGame\\ReadEquipmentData.txt";

            using (var writer_head = new StreamWriter(filepath))
            {
                writer_head.WriteLine(headpointer);
            }
        }

        

    }
}

      

    