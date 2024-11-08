using System;

public class Program
{
    public static void Main(string[] args)
    {
        string adventurerPath = "15F6B6B5L16R8B16F20L6F13F11R";
        int forward = 0;
        int right = 0;

        for (int i = 0; i < adventurerPath.Length; i++)
        {
            int stepsTaken = 0;

            // Extract steps
            while (char.IsDigit(adventurerPath[i]))
            {
                stepsTaken = stepsTaken * 10 + (adventurerPath[i] - '0');
                i++;
            }

            // Get direction
            char direction = adventurerPath[i];
            switch (direction)
            {
                case 'F':
                    forward += stepsTaken;
                    break;
                case 'B':
                    forward -= stepsTaken;
                    break;
                case 'L':
                    right -= stepsTaken;
                    break;
                case 'R':
                    right += stepsTaken;
                    break;
                default:
                    Console.WriteLine("Invalid Character: " + direction);
                    break;
            }
        }
        
        double euclideanDistance = Math.Sqrt(forward * forward + right * right);
        Console.WriteLine("Euclidean Distance is " + euclideanDistance);
    }
}
