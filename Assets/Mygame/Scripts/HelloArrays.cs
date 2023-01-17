using UnityEngine;

public class HelloArrays : MonoBehaviour
{
    string[,] alphabet1 = new string[4, 3];

    char[,] alphabetArray2 = new char[4, 3];

    void Start()
    {
        //direkt
        alphabet1[0, 0] = "A";
        alphabet1[1, 0] = "B";
        alphabet1[2, 0] = "C";
        alphabet1[3, 0] = "D";
        alphabet1[0, 1] = "E";
        alphabet1[1, 1] = "F";
        alphabet1[2, 1] = "G";
        alphabet1[3, 1] = "H";
        alphabet1[0, 2] = "I";
        alphabet1[1, 2] = "J";
        alphabet1[2, 2] = "K";
        alphabet1[3, 2] = "L";

        Debug.Log("1st column" + alphabet1[0, 0] + alphabet1[1, 0] + alphabet1[2, 0] + alphabet1[3, 0]);
        Debug.Log("2nd column" + alphabet1[0, 1] + alphabet1[1, 1] + alphabet1[2, 1] + alphabet1[3, 1]);
        Debug.Log("3rd column" + alphabet1[0, 2] + alphabet1[1, 2] + alphabet1[2, 2] + alphabet1[3, 2]);

        //for
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("1st column" + i);
        }

        for (int i = 4; i < 8; i++)
        {
            Debug.Log("2nd column" + i);
        }

        for (int i = 8; i < 12; i++)
        {
            Debug.Log("3rd column" + i);
        }

        //for 2
        int letterIndex = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                alphabetArray2[row, col] = (char)('A' + letterIndex);
                letterIndex++;
            }
        }
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Debug.Log(alphabetArray2[row, col] + " ");
            }
        }
        Debug.Log(alphabetArray2.GetLength(0));
        Debug.Log(alphabetArray2.GetLength(1));
    }
}
