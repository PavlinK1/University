using System;

class RecursionExercise
{
    static double Barrels = 3;
    static double barrelCapacity = 100.0;

    static double carCapacity = 20.0;
    static double distance = 0;
    static double wholeBarrels = Barrels * barrelCapacity;


    

    static double findMaxKm()
    {
        if (wholeBarrels <= 0.0)
        {
            Console.Write(" The distance is {0} ", distance);
            return distance;
        }


        if (wholeBarrels == 140 && Barrels == 2) 
        {
            distance += (200.0 / 3 + 1200);
            wholeBarrels -= 140;
        }

        if (Barrels == 2)
        {
            if (wholeBarrels > 140)
            {
                wholeBarrels -= 60;
                distance += 200;

            }
        }
        
        if (Barrels == 3)
        {
            if (barrelCapacity > 100)
            {

            } else if (barrelCapacity == 100)
            {

                double check = barrelCapacity / 5;
                if (check == carCapacity)
                {
                    Barrels -= 1;
                    wholeBarrels -= barrelCapacity;
                    distance += 200;
                }

            } else if (barrelCapacity < 100)

        }
        
        return findMaxKm();
    }
    
    static void Main()
    {
        findMaxKm();
    }
}
