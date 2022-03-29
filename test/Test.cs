class Test
{

    public static void Main(string[] args)
    {

        string[] myArray = new string[] {"1", "2", "3"};
        myArray = appendArray(myArray, "4");
        Console.Write(myArray);

    }

    public static dynamic[] appendArray(dynamic[] baseArray, dynamic[] items)
    {

        int addCount = items.Length;
        dynamic[] newArray = new dynamic[baseArray.Length + addCount];

        for (int i = 0 ; i<baseArray.Length ; i++)
        {

            newArray[i] = baseArray[i];

        }

        for (int i = baseArray.Length ; i<addCount ; i++)
        {

            newArray[i] = items[i]

        }

        return newArray;

    }

}
