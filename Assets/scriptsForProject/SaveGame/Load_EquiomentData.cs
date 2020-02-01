using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Assertions;
using System;
namespace EquipmentManager {
    public class Load_EquiomentData : MonoBehaviour
    {
        public int headpointer;
        public int RightArmpointer;
        public int LeftArmpointer;
        public int BodyPointer;
        public int LegPointer;
        public Read_EquipmentFile Read_EquipmentFile;
        public Material mat;
        /*
        public Transform Parent_head;
        public Transform Parent_Rightarm;
        public Transform Parent_LeftArm;
        public Transform Parent_Body;
        public Transform Parent_LegL;
        public Transform Parent_LegR;
        */
        public SkinnedMeshRenderer original;
        public GameObject Render_head;
        public GameObject Render_RightArm;
        public GameObject Render_Leftarm;
        public GameObject Render_Body;
        public GameObject Render_LegLeft;
        public GameObject Render_LegRight;
        
        private void Start()
        {
            Init_equipment();

            Render_LoadedEquipment(original);
        }

        private void Update()
        {
            
        }

        void Init_equipment()
        {
            var filepath = "C:\\Users\\Kanta yukawa\\KAIJU_KILLER_Unity2019\\Assets\\scriptsForProject\\SaveGame\\ReadEquipmentData.txt";

            using (var reader = new StreamReader(filepath))
            {
                var pointer = File.ReadAllLines(filepath);

                headpointer = int.Parse(pointer[0]);
                RightArmpointer = int.Parse(pointer[1]);
                LeftArmpointer = int.Parse(pointer[2]);
                BodyPointer = int.Parse(pointer[3]);
                LegPointer = int.Parse(pointer[4]);

               
            }


        }

        void Render_LoadedEquipment(SkinnedMeshRenderer skinnedMeshRenderer)
        {

            Render_head.GetComponent<MeshRenderer>().material = mat;
            Render_head.GetComponent<MeshFilter>().sharedMesh = Read_EquipmentFile.ES.headlist[headpointer].meshparts.sharedMesh;

            Render_Body.GetComponent<MeshRenderer>().material = mat;
            Render_Body.GetComponent<MeshFilter>().sharedMesh = Read_EquipmentFile.ES.bodylist[BodyPointer].meshparts.sharedMesh;

            Render_RightArm.GetComponent<MeshRenderer>().material = mat;
            Render_RightArm.GetComponent<MeshFilter>().sharedMesh = Read_EquipmentFile.ES.rightarmlist[RightArmpointer].meshparts.sharedMesh;



            Render_Leftarm.GetComponent<MeshRenderer>().material = mat;
            Render_Leftarm.GetComponent<MeshFilter>().sharedMesh = Read_EquipmentFile.ES.leftarmlist[LeftArmpointer].meshparts.sharedMesh;

            Render_LegLeft.GetComponent<MeshRenderer>().material = mat;
            Render_LegLeft.GetComponent<MeshFilter>().sharedMesh = Read_EquipmentFile.ES.leglist[LegPointer].meshparts.sharedMesh;

            Render_LegRight.GetComponent<MeshRenderer>().material = mat;
            Render_LegRight.GetComponent<MeshFilter>().sharedMesh = Read_EquipmentFile.ES.leglist[LegPointer].meshparts.sharedMesh;

            /*
            Render_head = new GameObject();


            Render_head.AddComponent<MeshFilter>();
            Render_head.AddComponent<MeshRenderer>();
            Render_head.AddComponent<Renderer>();
          

            Render_head.GetComponent<MeshFilter>().mesh = Read_EquipmentFile.ES.headlist[headpointer].meshparts.sharedMesh;
            Render_head.GetComponent<Renderer>().material = mat;
            Render_head.transform.parent = Parent_head.transform;
            Render_head.transform.local.Position = Vector3.zero;
            Render_head.transform.localScale = Vector3.one;
            Render_head.transform.localRotation = Quaternion.identity;
            Parent_head.GetComponent<SkinnedMeshRenderer>().sharedMesh = Render_head.GetComponent<MeshFilter>().sharedMesh;

           
            Render_head.name = "List_head" + headpointer;
            Render_head.SetActive(true);



            Render_RightArm = new GameObject();

            Render_RightArm.AddComponent<MeshFilter>();
            Render_RightArm.AddComponent<MeshRenderer>();
            Render_RightArm.AddComponent<Renderer>();

            Render_RightArm.GetComponent<MeshFilter>().mesh = Read_EquipmentFile.ES.rightarmlist[RightArmpointer].meshparts.sharedMesh;
            Render_RightArm.GetComponent<Renderer>().material = mat;
            Render_RightArm.transform.parent = Parent_Rightarm.transform;
            Render_RightArm.transform.localPosition = Vector3.zero;
            Render_RightArm.transform.localScale = Vector3.one;
            Render_RightArm.transform.localRotation = Quaternion.identity;
            Parent_Rightarm.GetComponent<SkinnedMeshRenderer>().sharedMesh = Render_RightArm.GetComponent<MeshFilter>().sharedMesh;


            Render_RightArm.name = "List_RA" + RightArmpointer;
            Render_RightArm.SetActive(true);


            Render_Leftarm = new GameObject();

            Render_Leftarm.AddComponent<MeshFilter>();
            Render_Leftarm.AddComponent<MeshRenderer>();
            Render_Leftarm.AddComponent<Renderer>();
            Render_Leftarm.GetComponent<MeshFilter>().mesh = Read_EquipmentFile.ES.leftarmlist[LeftArmpointer].meshparts.sharedMesh;
            Render_Leftarm.GetComponent<Renderer>().material = mat;

            Render_Leftarm.transform.parent = Parent_LeftArm.transform;
            Render_Leftarm.transform.localPosition = Vector3.zero;
            Render_Leftarm.transform.localScale = Vector3.one;
            Render_Leftarm.transform.localRotation = new Quaternion(0, -180.0f, 0f, 1); ;



            GameObject Render_Body = new GameObject();

            Render_Body.AddComponent<MeshFilter>();
            Render_Body.AddComponent<MeshRenderer>();
            Render_Body.AddComponent<Renderer>();
            Render_Body.GetComponent<MeshFilter>().mesh = Read_EquipmentFile.ES.bodylist[BodyPointer].meshparts.sharedMesh;
            Render_Body.GetComponent<Renderer>().material = mat;

            Render_Body.transform.parent = Parent_Body.transform;
            Render_Body.transform.localPosition = Vector3.zero;
            Render_Body.transform.localScale = Vector3.one;
            Render_Body.transform.localRotation = Quaternion.identity;
            

            Render_Body.name = "List_Body" + BodyPointer;
            Render_Body.SetActive(true);

            LegLeft = new GameObject();

            LegLeft.AddComponent<MeshFilter>();
            LegLeft.AddComponent<MeshRenderer>();
            LegLeft.AddComponent<Renderer>();
            LegLeft.GetComponent<MeshFilter>().mesh = Read_EquipmentFile.ES.leglist[LegPointer].meshparts.sharedMesh;
            LegLeft.GetComponent<Renderer>().material = mat;

            LegLeft.transform.parent = Parent_LegL.transform;
            LegLeft.transform.localPosition = Vector3.zero;
            LegLeft.transform.localScale = Vector3.one;
            LegLeft.transform.localRotation = Quaternion.identity;


            LegLeft.name = "List_LeftLeg" + LegPointer;
            LegLeft.SetActive(true);

            LegRight = new GameObject();

            LegRight.AddComponent<MeshFilter>();
            LegRight.AddComponent<MeshRenderer>();
            LegRight.AddComponent<Renderer>();
            LegRight.GetComponent<MeshFilter>().mesh = Read_EquipmentFile.ES.leglist[LegPointer].meshparts.sharedMesh;
            LegRight.GetComponent<Renderer>().material = mat;

            LegRight.transform.parent = Parent_LegR.transform;
            LegRight.transform.localPosition = Vector3.zero;
            LegRight.transform.localScale = Vector3.one;
            LegRight.transform.localRotation = Quaternion.identity;


            LegRight.name = "List_LeftLeg" + LegPointer;
            LegRight.SetActive(true);


                */


        }

        void Test_Rotate_Mesh()
        {
           
           
        }
    }
}