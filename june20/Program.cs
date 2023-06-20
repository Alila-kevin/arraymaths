internal class Program
{
    private static void Main(string[] args)
    {
        //declear the array
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        int[] arri =new int[size];
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < size; i++)
        {
            arri[i] = int.Parse(Console.ReadLine());
        }
        int sum=0;
        int summ = arri.Sum();
        double mult;
        double div;
        double rem;
        Console.WriteLine("Total sum of given array: " + summ);
        for (int i=0; i < arri.Length; i++)
        {
            sum +=1;
            
        }
        mult= sum * summ;
        div = summ / sum;
        rem = summ % sum;
        Console.WriteLine("the number of array is: " + sum);
        Console.WriteLine("the multiplication between the sum and number of array: " + mult);
        Console.WriteLine("the devision between the sum and number of array: " + div);
        Console.WriteLine("the remender between sum and number of array: " + rem);


    }
}