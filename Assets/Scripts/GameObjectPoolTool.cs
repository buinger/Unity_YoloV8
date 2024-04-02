using System.Collections.Generic;
using UnityEngine;


public class GameObjectPoolTool : MonoBehaviour
{
    public static GameObject GetFromPool(string path, string name)
    {
        GameObject aimGameObj;
        aimGameObj = GameObjectPool.OutPool(path + name);

        if (aimGameObj == null)
        {
            GameObject temp = Resources.Load<GameObject>(path + name);
            aimGameObj = Instantiate(temp);
            aimGameObj.name = path + name;
        }
        aimGameObj.transform.SetParent(null);
        return aimGameObj;
    }

    public static GameObject GetFromPool(string path, string name, Vector3 postion)
    {
        GameObject aimGameObj = GetFromPool(path, name);
        aimGameObj.transform.position = postion;
        return aimGameObj;
    }

    public static GameObject GetFromPool(string path, string name, Vector3 postion, Transform father, bool isLocalSet = false)
    {

        GameObject aimGameObj = GetFromPool(path, name);
        aimGameObj.transform.SetParent(father);
        if (isLocalSet)
        {
            aimGameObj.transform.localPosition = postion;
        }
        else
        {
            aimGameObj.transform.position = postion;
        }
        return aimGameObj;
    }

    public static GameObject GetFromPoolLikeFather(string path, string name, Transform tempTrans, bool beSon = false)
    {
        GameObject aimGameObj = GetFromPool(path, name);
        if (beSon == true)
        {
            aimGameObj.transform.SetParent(tempTrans);
            aimGameObj.transform.position = Vector3.zero;
            aimGameObj.transform.rotation = Quaternion.identity;
        }
        else
        {
            aimGameObj.transform.position = tempTrans.position;
            aimGameObj.transform.rotation = tempTrans.rotation;
        }
        return aimGameObj;
    }

    public static void PutInPool(GameObject gameObj)
    {
        GameObjectPool.InPool(gameObj);
    }

    class GameObjectPool
    {
        public static Dictionary<string, List<GameObject>> itemPool = new Dictionary<string, List<GameObject>>();

        public static void ClearPool()
        {
            itemPool.Clear();
        }

        public static bool InPool(GameObject gameObj)
        {
            if (itemPool.ContainsKey(gameObj.name) == false)
            {
                itemPool.Add(gameObj.name, new List<GameObject>());
            }

            gameObj.SetActive(false);

            if (!itemPool[gameObj.name].Contains(gameObj))
            {
                itemPool[gameObj.name].Add(gameObj);
            }
            return true;
        }

        public static GameObject OutPool(string itemName)
        {
            if (itemPool.ContainsKey(itemName) == false)
            {
                itemPool.Add(itemName, new List<GameObject>());
            }

            if (itemPool[itemName].Count == 0)
            {
                return null;
            }
            else
            {
                GameObject outGo = itemPool[itemName][0];
                itemPool[itemName].RemoveAt(0);
                outGo.SetActive(true);
                return outGo;
            }
        }
    }
}
