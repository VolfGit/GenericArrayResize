
public class Class
{

    public static void Main(String[] args)
    {
        /* 1.Написать метод Resize изменяющий количество элементов массива
    (метод должен иметь возможность увеличить или уменьшить количество элементов
    массива).
2. Написать методы для добавления элемента в начало массива, в конец массива и по
указанному индексу.
3. Написать методы для удаления первого элемента массива, последнего элемента
массива и элемента по указанному индексу.
*/


        int[] myArray = { 3, 6, 7, 8, 10, 12 };
       // Resize(ref myArray, 5);
        //Insert(ref myArray,2,2);
        //AddToFirstIndexInArray(ref myArray, 10);
       // AddToLastIndexInArray(ref myArray, 11);
        
        RemoveAt(ref myArray, 2);
        //AddToLastIndexInArray(ref myArray, 10);
        //AddToAnyIndexInArray(ref myArray, 10,3);
    }
    public static void Resize<T>(ref T[] myArray, int newSize)
    {
        T[] newarray = new T[newSize];

        for (int i = 0; i < myArray.Length && i < newarray.Length; i++)
        {
            newarray[i] = myArray[i];


        }
        myArray = newarray;

    }
   

    public static void AddToFirstIndexInArray(ref int[] myArray, int value)
    {

        Insert(ref myArray, value, 0);
        
    }
    public static void AddToLastIndexInArray(ref int[] myArray, int value)
    {

        Insert(ref myArray, value, myArray.Length);

    }

    public static void Insert(ref int[] myArray, int value,int index)
    {
         
       int[] newArray = new int[myArray.Length + 1];
       newArray[index] = value;
       for (int i = 0; i < index; i++)
        {
            newArray[i] = myArray[i];


        }
        for (int i = index; i < myArray.Length; i++)
        {
            newArray[i+1] = myArray[i];


        }
        myArray=newArray;

    }

    /*
    public static void DeleteFirstElementFromArray(ref int[] myArray)
    {

        int[] newArray = new int[myArray.Length -1 ];
        
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            newArray[i] = myArray[i+1];


        }
        
        myArray = newArray;

    }
    */

    public static void RemoveAtFirstElement(ref int[] myArray, int index)
    {
        RemoveAt(ref myArray, 0);
    }
    public static void RemoveAtLastElement(ref int[] myArray, int index)
    {
        RemoveAt(ref myArray, myArray.Length-1);
    }

    public static void RemoveAt(ref int[] myArray, int index)
    {

        int[] newArray = new int[myArray.Length -1];
        
        for (int i = 0; i < index; i++)
        {
            newArray[i] = myArray[i];


        }
        for (int i = index+1; i < myArray.Length; i++)
        {
            newArray[i -1] = myArray[i];


        }
        myArray = newArray;

    }

}
