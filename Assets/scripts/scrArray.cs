using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrArray : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var arr = array(2);
        var mat = Matrix(2);
        Debug.Log("" + arr[0][0]);
        Debug.Log("" + mat[1, 2]);
	}

    int[][] array(int n)
    {
        int[][] arr = new int[3][];

        arr[0] = new int[] { n };
        arr[1] = new int[] { n + 1, n + 2 };
        arr[2] = new int[] { n + 3, n + 4, n + 5};
        return arr;
    }

    int[,] Matrix(int n)
    {
        int[,] mat = new int[3, 3] {    
        {n, 0, 0},
        {n + 1, n + 2, 0},
        {n + 3, n + 4, n + 5},
        };
        return mat;
    }
}
