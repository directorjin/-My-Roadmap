using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    public List<Vector3> positionList; //원본 Vector 리스트
    public List<Vector3> filter_positionList; // 필터 후 담을 Vector 리스트

    // Normal
    public void NormalFuntion()
    {
        filter_positionList = new List<Vector3>();
        List<Vector3> pre_filter_positionList = new List<Vector3>();

        for (int i = 0; i < positionList.Count; i++)
        {
            if (Vector3.Distance(transform.position, positionList[i]) > 2f)
                pre_filter_positionList.Add(positionList[i]);
        }

        for (int i = 0; i < pre_filter_positionList.Count; i++)
        {
            int l_higherNum = 0;

            for (int j = 0; j < filter_positionList.Count; j++)
            {
                if (Vector3.Distance(transform.position, pre_filter_positionList[i])
                    > Vector3.Distance(transform.position, filter_positionList[j]))
                    l_higherNum++;
            }

            filter_positionList.Insert(l_higherNum, pre_filter_positionList[i]);
        }

    }




    // LINQ
    public void LINQFuntion()
    {
        filter_positionList = new List<Vector3>();

        filter_positionList = positionList
            .Where(n => Vector3.Distance(transform.position, n) > 2f)
            .OrderBy(n => Vector3.Distance(transform.position, n))
            .ToList();
    }
}