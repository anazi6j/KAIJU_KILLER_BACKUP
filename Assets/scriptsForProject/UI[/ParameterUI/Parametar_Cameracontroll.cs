using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace robot
{
   public enum Camera_Type
    {
        Selected,
        NOT_Selected
    }
    public class Parametar_Cameracontroll : MonoBehaviour
    {

        readonly float NOTSELECTED = 48;
        readonly float SELECTED = 9;

        public Inputhandler inputhandler;
        public Camera_Type Camera_Type;
        public GameObject[] Upparameter;
       
       
        Camera cam;
        bool CamisZooming;
        public int selectedNum_Item = 0;
        
        // Start is called before the first frame update
        private void Start()
        {
            
            inputhandler = GetComponent<Inputhandler>();
            cam = Camera.main;
            Camera_Type = Camera_Type.NOT_Selected;
        
        }

        // Update is called once per frame
        private void Update()
        {
           
            //アイテム決定中と選択中の視野角調整
            cam.fieldOfView = GetFieldOfView();
            Set_CameraType(inputhandler.maru_pressed);
            //IsZoomingをtrueにしたりfalseにしたりする
            CamisZooming= GetCamisZooming();
            //カメラの位置をセットする
            SetCameraPos();
            //アイテムの要素番号を決定する（アイテムを選択する）
            Set_selectedNumItem();
            
        }




        public bool GetCamisZooming()
        {
            return Camera_Type == Camera_Type.Selected;
           
        }

        private void SetCameraPos()
        {
            //このスクリプトをアタッチしたゲームオブジェクトの位置は各ボタンの位置と連動する
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, GetCamerapos(), Time.deltaTime * 100);
        }

        private void Set_selectedNumItem()
        {
            //
            if (!CamisZooming)
            {
                if (Input.GetAxis("DS4_DpadX") < 0)
                {
                    selectedNum_Item = 0;
                }
                else if (Input.GetAxis("DS4_DpadX") > 0)
                {
                    selectedNum_Item = 1;
                }
            }
        }

        void Set_maru_delta()
        {
            if(inputhandler.maru_pressed)
            {
                inputhandler.maru_delta += Time.deltaTime;
            }
            else { inputhandler.maru_delta = 0f; }
        }
        
       
        
        public  void Set_CameraType(bool marupressed)
        {
            if(marupressed)
            {
                Camera_Type = Camera_Type.Selected;
            }
            else
            {
                Camera_Type = Camera_Type.NOT_Selected;
            }

        }
        
        public Vector3 GetCamerapos()
        {
            Vector3 campos=new Vector3(0,0,0);
            campos.x = Upparameter[selectedNum_Item].transform.position.x;
            campos.y = Upparameter[selectedNum_Item].transform.position.y;
            campos.z = cam.transform.position.z;
            return campos;
        }

       public float GetFieldOfView()
        {


            float FOV=0;

           if(Camera_Type ==Camera_Type.NOT_Selected)
            {
                FOV = NOTSELECTED;
            }

           else if(Camera_Type ==Camera_Type.Selected)
            {
                FOV = SELECTED;
            }
      

                return FOV;
            
        }
     
          
        
    }

    


}
