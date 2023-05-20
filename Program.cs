using System;

class PascalsTriangle
{
    static void Main()
    {
        while(true){
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = int.Parse(Console.ReadLine());

        if(numRows<0){
            Console.WriteLine("Invalid Pascal’s triangle row number.");          
        }
        
        else 
        {
            for (int row = 0; row < numRows+1; row++)               
            {
                for (int col = 0; col <= row; col++)
                {
                    int coef = CalculateCoefficient(row, col);
                    Console.Write(" " + coef );
                }
                Console.WriteLine();
            }
            break;
        }
    }
} 
    static int CalculateCoefficient(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1;
        }
        else
        {
            return CalculateCoefficient(n - 1, k - 1) + CalculateCoefficient(n - 1, k);
        }
    }
}