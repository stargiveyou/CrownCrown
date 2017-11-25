using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TCoin
{

    public enum CharacterType
    {
        None,
    }


    //Character ---> Monster, PlayerCharacter, NPC ETC
public class Character_Default : MonoBehaviour {


        #region Static Temp Method

        public static Character_Default CreateDefaultInstance(string name)
        {
            Character_Default newCharacter = Instantiate(new GameObject(name), Vector3.zero, Quaternion.identity).AddComponent<Character_Default>();

            newCharacter.CreateCharacter(name, 0);

            return newCharacter;
        }

        #endregion

        public virtual CharacterType CharacterType
        {
            get
            {
                return CharacterType.None;
            }
        }

        public string characterName;
        public int characterid;
        public float hp;
        public float speed;


        // Use this for initialization
        void Start () {
        	
        }

#region Character Create and Remove
        public virtual void CreateCharacter(string Name, int id, float hp, float speed)
        {
            
        }
        public virtual void CreateCharacter(string Name, int id)
        {
            
        }
        public virtual void RemoveCharacter(string name)
        {
            
        }
        #endregion

        #region Character Movement


        public void MoveToForward()
        {
            
        }

        public void RotateAxis(float axisValue)
        {
            
        }

        public void Jump()
        {
            
        }



        #endregion



        // Update is called once per frame
        void Update()
        {

        }
   }
}



