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
                Console.WriteLine("Insert the {0} values for line {1}: ", c, i + 1);
                String[] val = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(val[j]);
                }
            }
            Console.WriteLine();

            // With the matrix done, we can start playing with it
            int request = 0;
            Console.Write("Wich number do I have to look for? ");
            request = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    // We need to find our requested number first
                    if (request == mat[i, j]) {
                        Console.WriteLine("Position ({0},{1})", i, j);
                        // Now we will find it's neighbors
                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Up: " + mat[(i - 1), j]);
                        }
                        if (j + 1 < c) {
                            Console.WriteLine("Right: " + mat[i, (j + 1)]);
                        }
                        if (i + 1 < l) {
                            Console.WriteLine("Down: " + mat[(i + 1), j]);
                        }
                    }
                }
            }
        }
    }
}
