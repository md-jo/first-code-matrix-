// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter matrix 3,3");
  Matrix c1 = new Matrix();
            c1.ReadMatrix();
            c1.Print();
            Console.WriteLine();
            c1.Transpose();
 class Matrix
    {
        private int i ;
        private int s ;
        private int[,] array = new int[3,3]; 
        public void ReadMatrix()
        {
            for (i=0;i<3;i++)
            {
                for (s = 0; s < 3; s++)
                {
                    array[i, s] = Convert.ToInt32(Console.ReadLine());
                }
                    
            }
        }
        public void Transpose()
        {
            Console.WriteLine("Print Transpose");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (s = 0; s < 3; s++)
                {
                    Console.Write(array[s, i]);
                }
            }
            }
        public void Print()
        {
            Console.WriteLine("Print Matrix");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (s = 0; s < 3; s++)
                {
                    Console.Write( array[i, s] );
                }

            }
        }

    }

