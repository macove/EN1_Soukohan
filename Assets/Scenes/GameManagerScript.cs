using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    int[] map;

    void PrintArray()
    {
        string debugText = "";
        for (int i = 0; i < map.Length; i++)
        {
            debugText += map[i].ToString() + ",";
        }
        Debug.Log(debugText);
    }


    void Start()
    {
        map = new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };
        // Debug.Log("Hello World");

        PrintArray();

       // string debugText = "";
       //
       // for (int i =0; i<map.Length;i++)
       // {
       //     //Debug.Log(map[i] + ",");
       //
       //     debugText += map[i].ToString() + ",";
       // }
       // Debug.Log(debugText);
    }

    // Update is called once per frame

    int GetPlayerIndex()
    {
        for(int i=0; i< map.Length; i++)
        {
            if (map[i] == 1)
            {
                return i;
            }
        }
        return -1;
    }
  /// <summary>
  /// 
  /// </summary>
  /// <param name="number"></param>
  /// <param name="moveFrom"></param>
  /// <param name="moveTo"></param>
  /// <returns></returns>
    bool MoveNumber(int number,int moveFrom,int moveTo)
    {
        if(moveTo<0 || moveTo >= map.Length)
        {
            return false;
        }
        map[moveTo] = number;
        map[moveFrom] = 0;
        return true;
    }


    void Update()
    {
       if(Input.GetKeyDown(KeyCode.RightArrow))
       {
           int playerIndex = GetPlayerIndex();
       
          // for(int i = 0; i<map.Length;i++)
          // {
          //
          //     if (map[i] == 1)
          //     {
          //         playerIndex = i;
          //         break;
          //     }
          //
          // }
       
             MoveNumber(1, playerIndex, playerIndex + 1);

          //if (playerIndex < map.Length - 1)
          //{
          //    map[playerIndex + 1] = 1;
          //    map[playerIndex] = 0;
          //}

            PrintArray();

            //string debugText = "";
            //
            //for (int i = 0; i < map.Length; i++)
            //{
            //
            //
            //    debugText += map[i].ToString() + ",";
            //}
            //Debug.Log(debugText);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int playerIndex = GetPlayerIndex();

            // for (int i = 0; i < map.Length; i++)
            // {
            //
            //     if (map[i] == 1)
            //     {
            //         playerIndex = i;
            //         break;
            //     }
            //
            // }

            MoveNumber(1, playerIndex, playerIndex-1);

            //if (playerIndex > 0)
            //{
            //    map[playerIndex - 1] = 1;
            //    map[playerIndex] = 0;
            //}

            PrintArray();

            //string debugText = "";
            //
            //for (int i = 0; i < map.Length; i++)
            //{
            //
            //
            //    debugText += map[i].ToString() + ",";
            //}
            //Debug.Log(debugText);
        }
    }
}
