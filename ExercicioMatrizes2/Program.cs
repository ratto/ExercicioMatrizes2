using System;

/* 
 * Another exercise using matrix.
 * First the user will set the matrix size and then will populate it with
 * some random numbers. These number can repeat in the table.
 * 
 * The second part os the exercise is to request a random number for the
 * user. The programm will look into the matrix for the requested number
 * and will show it's position and it's neighbors.
 * 
 * No exception treatment will be done for now. It is just a simple
 * exercise.
 */

namespace ExercicioMatrizes2 {
    class Program {
        static void Main(string[] args) {
            int l, c;

            // For now we will create and populate our matrix
            Console.Write("How many lines will the matrix have? ");
            l = int.Parse(Console.ReadLine());
            Console.Write("How many columns will the matrix have? ");
            c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++) {
                Console.WriteLine("Insert the {0} values for line {1}: ", c, l);
                String[] val = Console.ReadLine().Split(' ');
                for (int j; j < c; j++) {
                    mat[i, j] = int.Parse(val[j]);
                }
            }
            Console.WriteLine();

            // With the matrix done, we can start playing with it
            int request = 0;
            request = int.Parse(Console.ReadLine());
        }
    }
}
