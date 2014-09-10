/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package test;

/**
 *
 * @author Raul Garay
 */
public class Test {

    public static void main(String[] args)

    {

        //BigO();
        int fInt50 = facInt(10);
        System.out.println("Int 50!: " + fInt50);
        System.out.println("Recursion fails at 13 for int.");

        //long fLong50 = facLong(50);

        //System.out.println("Long 50!: " + fLong50);

    }

    private static void BigO()

    {

        int[][] bigOAr = new int[10][10];

        for(int x = 0; x < 10; x++)

        {

            for(int y = 0; y < 10 ; y++)

            {

                bigOAr[x][y] = x + y;

                System.out.print(bigOAr[x][y] + " ");

            }

            System.out.println();

        }

        int cols09 = 0;

        int rows45 = 0;

        int cols54 = 0;

        int rows90 = 0;

        System.out.println("Totals are");

        //Total for columns 0 and 9 into variable cols09

        for(int x = 0; x < 10; x++)

            {cols09 =+ bigOAr[x][0];}

        for(int x = 0; x < 10; x++)

            {cols09 =+ bigOAr[x][9];}

        System.out.println("Columns 0 and 9: " + cols09);

        //Total for rows 4 and 5 into variable rows45

        for(int y = 0; y < 10; y++)

            {rows45 =+ bigOAr[4][y];}

        for(int y = 0; y < 10; y++)

            {rows45 =+ bigOAr[5][y];}

        System.out.println("Rows 4 and 5: " + rows45);

        //Total for columns 5 and 4 into variable cols54

        for(int x = 0; x < 10; x++)

            {cols54 =+ bigOAr[x][5];}

        for(int x = 0; x < 10; x++)

            {cols54 =+ bigOAr[x][4];}

        System.out.println("Columns 5 and 4: " + cols54);

        //Total for rows 9 and 0 into variable rows90

        for(int y = 0; y < 10; y++)

            {rows90 =+ bigOAr[9][y];}

        for(int y = 0; y < 10; y++)

            {rows90 =+ bigOAr[0][y];}

        System.out.println("Rows 9 and 0: " + rows90);

    }

    private static int facInt(int fac)

    {

        if(fac == 1)

            {return 1;}

        return fac*facInt(fac - 1);

    }

    /**

    private static long facLong(int fac)

    {

        if(fac == 1)

            {return 1;}

        return fac*facLong(fac - 1);

    }

    private static BigInteger facBigInt(int fac)

    {

        if(fac == 1)

            {return 1;}

        return fac*facBigInt(fac - 1);

    }

    */

}