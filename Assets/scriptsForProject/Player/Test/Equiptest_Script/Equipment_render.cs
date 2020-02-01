using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentManager
{

    //プレイアブルキャラクターのgameobjectにアタッチする

    public class Equipment_render : MonoBehaviour
    {
        public List<Head> Head_tempo = new List<Head>();
        public List<Right_arm> Rightarm_tempo = new List<Right_arm>();
        public List<Left_arm> Leftarm_tempo = new List<Left_arm>();
        public List<Body> Body_tempo = new List<Body>();
        public List<Leg> Leg_tempo = new List<Leg>();
        public GameObject Parent_head;
        public GameObject Parent_RightArm;
        public GameObject Parent_LeftArm;
        public GameObject Parent_Body;
        public GameObject Parent_Leg;
        public GameObject Parent_Leg2;

        public List<GameObject> Render_Head = new List<GameObject>();
        public List<GameObject> Render_RA = new List<GameObject>();
        public List<GameObject> Render_LA = new List<GameObject>();
        public List<GameObject> Render_Body =  new List<GameObject>();
        public List<GameObject> Render_LEG = new List<GameObject>();
        public List<GameObject> Render_LEG_L = new List<GameObject>();
       
        public Read_EquipmentFile read;
        public EquipmentIDmanager IDManager;
        public Material mat;
        // Start is called before the first frame update
        void Start()
        {
            read.Initialize(ref Head_tempo, ref Rightarm_tempo, ref Leftarm_tempo, ref Body_tempo,ref Leg_tempo);
            CreateGameObject();
        }

        private void Update()
        {
            Draw();
        }
        //SelectEquipmentクラスから描画に必要な情報を取得して、それを元にゲームオブジェクトを生成する
        void CreateGameObject()
        {
            for (int i = 0; i < Head_tempo.Count; i++)
            {


                GameObject OUT = new GameObject();
             
                Render_Head.Add(OUT);

                Render_Head[i].AddComponent<MeshFilter>();
                Render_Head[i].AddComponent<MeshRenderer>();
                Render_Head[i].AddComponent<Renderer>();
                
                Render_Head[i].GetComponent<MeshFilter>().mesh = Head_tempo[i].meshparts.sharedMesh;
                Render_Head[i].GetComponent<Renderer>().material = mat;
                Render_Head[i].transform.parent = Parent_head.transform;
                Render_Head[i].transform.localPosition = Vector3.zero;
                Render_Head[i].transform.localScale = new Vector3(100f,100f,100f);
                Render_Head[i].transform.localRotation = Quaternion.identity;
                //Material[] material = GetComponent<SkinnedMeshRenderer>().materials;
                //material[0] = mat;

                //GetComponent<SkinnedMeshRenderer>().materials = material;
                Render_Head[i].name = "List_head" + i;
                Render_Head[i].SetActive(false);

                
            }
            for (int i = 0; i < Rightarm_tempo.Count; i++)
            {
                GameObject OUT = new GameObject();

                Render_RA.Add(OUT);

                Render_RA[i].AddComponent<MeshFilter>();
                Render_RA[i].AddComponent<MeshRenderer>();
                Render_RA[i].AddComponent<Renderer>();
                Render_RA[i].GetComponent<MeshFilter>().mesh = Rightarm_tempo[i].meshparts.sharedMesh;
                Render_RA[i].transform.parent = Parent_RightArm.transform;
                Render_RA[i].GetComponent<Renderer>().material = mat;
                Material[] material = GetComponent<MeshRenderer>().materials;
                material[0] = mat;

                GetComponent<MeshRenderer>().materials = material;
                Render_RA[i].transform.localPosition = Vector3.zero;
                GetComponent<MeshRenderer>().sharedMaterials[0] = mat;
                Render_RA[i].transform.localScale = new Vector3(10.99f, 5.96f, 13.01f);
                Render_RA[i].transform.localRotation = Quaternion.identity;
                Render_RA[i].name = "List_RA" + i;
                Render_RA[i].SetActive(false);
            }
            

            for (int i = 0; i < Leftarm_tempo.Count; i++)
            {
                GameObject OUT = new GameObject();

                Render_LA.Add(OUT);

                Render_LA[i].AddComponent<MeshFilter>();
                Render_LA[i].AddComponent<MeshRenderer>();
                Render_LA[i].AddComponent<Renderer>();
                Render_LA[i].GetComponent<MeshFilter>().mesh = Rightarm_tempo[i].meshparts.sharedMesh;
                Render_LA[i].GetComponent<Renderer>().material = mat;
                
                Render_LA[i].transform.parent = Parent_LeftArm.transform;
                Render_LA[i].transform.localPosition = new Vector3(0f, 2f, 0f);
                Render_LA[i].transform.localScale = new Vector3(10.99f, 5.96f, 13.01f);
                Render_LA[i].transform.localRotation = new Quaternion(0, -180.0f, 0f, 1); ;
                Render_LA[i].name = "List_LA" + i;
                Render_LA[i].SetActive(false);
            }
            

            for (int i = 0; i < Body_tempo.Count; i++)
            {
                GameObject OUT = new GameObject();

                Render_Body.Add(OUT);

                Render_Body[i].AddComponent<MeshFilter>();
                Render_Body[i].AddComponent<MeshRenderer>();
                Render_Body[i].AddComponent<Renderer>();
                Render_Body[i].GetComponent<MeshFilter>().mesh = Body_tempo[i].meshparts.sharedMesh;
                Material[] material = GetComponent<MeshRenderer>().materials;
                material[0] = mat;
                Render_Body[i].GetComponent<Renderer>().material = mat;
                Render_Body[i].transform.parent = Parent_Body.transform;
                Render_Body[i].transform.localPosition = Vector3.zero;
                Render_Body[i].transform.localScale = new Vector3(1f,100f,1f);
                Render_Body[i].transform.localRotation = Quaternion.identity;
                Render_Body[i].name = "List_Body" + i;
                Render_Body[i].SetActive(false);
            }

           
            for (int i = 0; i < Leg_tempo.Count; i++)
            {
                Debug.Log("足");
                GameObject OUT = new GameObject();

                Render_LEG.Add(OUT);

                Render_LEG[i].AddComponent<MeshFilter>();
                Render_LEG[i].AddComponent<MeshRenderer>();
                Render_LEG[i].AddComponent<Renderer>();
                GetComponent<MeshRenderer>().sharedMaterials[0] = mat;
                Render_LEG[i].GetComponent<MeshFilter>().mesh = Leg_tempo[i].meshparts.sharedMesh;
                Render_LEG[i].transform.parent = Parent_Leg.transform;
                Render_LEG[i].GetComponent<Renderer>().material = mat;
                Material[] material = GetComponent<MeshRenderer>().materials;
                material[0] = mat;

                GetComponent<MeshRenderer>().materials = material;
                Render_LEG[i].transform.localPosition = Vector3.zero;
                Render_LEG[i].transform.localScale = new Vector3(100f,100f,100f);
                Render_LEG[i].transform.localRotation = Quaternion.identity;
                Render_LEG[i].name = "List_LegR" + i;
                Render_LEG[i].SetActive(false);
            }

            for (int j = 0; j < Leg_tempo.Count; j++)
            {
                GameObject OUT = new GameObject();

                Render_LEG_L.Add(OUT);

                Render_LEG_L[j].AddComponent<MeshFilter>();
                Render_LEG_L[j].AddComponent<MeshRenderer>();
                Material[] material = GetComponent<MeshRenderer>().materials;
                material[0] = mat;
                Render_LEG_L[j].AddComponent<Renderer>();

                Render_LEG_L[j].GetComponent<Renderer>().material = mat;
                
                Render_LEG_L[j].GetComponent<MeshFilter>().mesh = Leg_tempo[j].meshparts.sharedMesh;
                Render_LEG_L[j].transform.parent = Parent_Leg2.transform;
                Render_LEG_L[j].transform.localPosition = Vector3.zero;
                Render_LEG_L[j].transform.localScale = new Vector3(100f,100f,100f);
                Render_LEG_L[j].transform.localRotation = Quaternion.identity;
                Render_LEG_L[j].name = "List_Leg_L" + j;
                Render_LEG_L[j].SetActive(false);
            }

            //指定したGameObject以外は表示しない
            Render_Head[IDManager.Head_pointer].SetActive(true);
            
            Render_RA[IDManager.RightArm_pointer].SetActive(true);
            
            Render_LA[IDManager.LeftArm_pointer].SetActive(true);
            Render_Body[IDManager.Body_pointer].SetActive(true);
            Render_LEG[IDManager.Leg_pointer].SetActive(true);
            Render_LEG_L[IDManager.Leg_pointer].SetActive(true);
         }

        //ゲームオブジェクトを描画する
        void Draw()
        {


            if (IDManager.Head_pointer < Head_tempo.Count - 1) {
                Render_Head[IDManager.Head_pointer + 1].SetActive(false);
                    }

            if (IDManager.Head_pointer > 0) {
                Render_Head[IDManager.Head_pointer - 1].SetActive(false);

            } 
         
                Render_Head[IDManager.Head_pointer].SetActive(true);
            
           
               
            

             
             //左腕
             
         
            if (IDManager.LeftArm_pointer < Render_LA.Count - 1)
            {
                Render_LA[IDManager.LeftArm_pointer + 1].SetActive(false);
            }
             if (IDManager.LeftArm_pointer > 0)
            {
                Render_LA[IDManager.LeftArm_pointer- 1].SetActive(false);
            }
            Render_LA[IDManager.LeftArm_pointer].SetActive(true);

            //右腕
            if(IDManager.RightArm_pointer<Render_RA.Count-1)
            {
                Render_RA[IDManager.RightArm_pointer + 1].SetActive(false);
            }
            if(IDManager.RightArm_pointer>0)
            {
                Render_RA[IDManager.RightArm_pointer - 1].SetActive(false);
            }
            Render_RA[IDManager.RightArm_pointer].SetActive(true);
            
            //胴体
           if (IDManager.Body_pointer< Render_Body.Count - 1)
           {
               Render_Body[IDManager.Body_pointer + 1].SetActive(false);
           }
            if (IDManager.Body_pointer > 0)
           {
               Render_Body[IDManager.Body_pointer - 1].SetActive(false);
           }
            Render_Body[IDManager.Body_pointer].SetActive(true);

            //足
           

           if (IDManager.Leg_pointer< Render_LEG.Count - 1)
           {
               Render_LEG[IDManager.Leg_pointer + 1].SetActive(false);
           }
           if (IDManager.Leg_pointer > 0)
           {
               Render_LEG[IDManager.Leg_pointer - 1].SetActive(false);
           }
            Render_LEG[IDManager.Leg_pointer].SetActive(true);

            if (IDManager.Leg_pointer < Render_LEG.Count - 1)
            {
                Render_LEG_L[IDManager.Leg_pointer + 1].SetActive(false);
            }
            if (IDManager.Leg_pointer > 0)
            {
                Render_LEG_L[IDManager.Leg_pointer - 1].SetActive(false);
            }
            Render_LEG_L[IDManager.Leg_pointer].SetActive(true);
        }

    }


}
