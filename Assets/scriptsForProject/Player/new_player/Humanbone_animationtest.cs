using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace robot
{
    [ExecuteInEditMode]
    public class Humanbone_animationtest : MonoBehaviour
    {
        public Animator anim;
        [Range(0, 1)]
        public float move;
        public Inputhandler inputhandler;
        public bool isGuarding;
        
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            anim.SetFloat("Move", move);
            anim.SetBool("IsGuarding", isGuarding);
        }
    }
}