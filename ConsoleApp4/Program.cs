
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


        int[] myArray = { 3, 6, 7 };
        Resize(ref myArray,2);
        AddToFirstIndexInArray(ref myArray, 10);
        AddToLastIndexInArray(ref myArray, 10);
        AddToAnyIndexInArray(ref myArray, 10,3);
    }
    public static void Resize<T>(ref T[] myArray,int newSize)
    {
        T[] newarray= new T[newSize];
        
        for (int i = 0; i < myArray.Length && i < newarray.Length; i++)
        {
            newarray[i]= myArray[i];

        
        }
        myArray= newarray;

    }
    public static void AddToFirstIndexInArray(ref int[] myArray,int n)
    {
        myArray = new int[myArray.Length+1];
        myArray[0] = n;

    }
    public static void AddToLastIndexInArray(ref int[] myArray, int n)
    {
        myArray = new int[myArray.Length];
        myArray[myArray.Length-1] = n;

    }

    public static void AddToAnyIndexInArray(ref int[] myArray, int n,int place)
    {
        myArray = new int[myArray.Length + 1];
        myArray[place] = n;

    }

    public static void RemoveFirstIndexInArray(ref int[] myArray, int n, int place)
    {
        myArray = new int[myArray.Length -1];


    }
    

}