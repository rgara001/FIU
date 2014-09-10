/*********************************************************************
Author     : Raul Garay 
Course     : COP 3530 T,R 2-3pm
Professor  : Michael Robinson 
Program #  : Implement Insertion Sort
                                         Bucket Sort
                                         Merge Sort
                                         Quicksort Sort
                                         External Sort
Due Date   : 11/12/2013 

Certification: 
I hereby certify that this work is my own and none of it
is the work of any other person. 
       


*********************************************************************/

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class GarayRpgm3 {

    //Load data from file
    //Return array of Strings, where each line in data is an array element
    private static String[] createData(String fileName)
            throws FileNotFoundException
    {
        File inputFile = new File(fileName);
        Scanner in = new Scanner(inputFile);
        
        ArrayList<String> tmp = new ArrayList<>();
        
        //load data into ArrayList
        while(in.hasNextLine())
            tmp.add(in.nextLine());
        
        //convert data to an array
        String[] data = new String[tmp.size()];
        tmp.toArray(data);
        
        return data;
    }
    
    /**********************************************************************/
    /**********************************************************************/
    
    private static void insertionSort(String fileName)
            throws FileNotFoundException
    {
        String[] data = createData(fileName);
        
        double start = System.nanoTime(); //start time here
        insertionSort(data);
        double end = System.nanoTime();  //end time here
        printTime((end - start) / 1000);
    }
            
    private static void insertionSort(String[] data)
    {
        //Standard Insertion Sort Algorithm
        int j;
        for (int p = 1; p < data.length; p++) {
            String tmp = data[p];
            for (j = p; j > 0 && tmp.compareTo(data[j - 1]) < 0; j--) {
                data[j] = data[j - 1];
            }
            data[j] = tmp;
        }
    }

     /**********************************************************************/
    /**********************************************************************/
    
    private static void BucketSort(String fileName)
            throws FileNotFoundException
    {
        String[] data = createData(fileName);
        
        double start = System.nanoTime(); //start time here
        countingRadixSort(data, data[0].length());
        double end = System.nanoTime();  //end time here
        printTime((end - start) / 1000);
    }

    public static void countingRadixSort(String[] data, int stringLen) {
        final int BUCKETS = 256;

        int N = data.length;
        String[] buffer = new String[N];

        String[] in = data;
        String[] out = buffer;

        for (int pos = stringLen - 1; pos >= 0; pos--) {
            int[] count = new int[BUCKETS + 1];

            for (int i = 0; i < N; i++) {
                count[ in[ i].charAt(pos) + 1]++;
            }
            for (int b = 1; b <= BUCKETS; b++) {
                count[ b] += count[ b - 1];
            }
            for (int i = 0; i < N; i++) {
                out[ count[ in[ i].charAt(pos)]++] = in[ i];
            }
            // swap in and out roles
            String[] tmp = in;
            in = out;
            out = tmp;
        }

        // if odd number of passes, in is buffer, out is arr; so copy back
        if (stringLen % 2 == 1) {
            System.arraycopy(in, 0, out, 0, data.length);
        }
    }

    /**********************************************************************/
    /**********************************************************************/
    
    private static void quickSort(String fileName)
            throws FileNotFoundException
    {
        String[] data = createData(fileName);
        
        double start = System.nanoTime(); //start time here
        quickSort(data, 0, data.length);
        double end = System.nanoTime();  //end time here
	printTime((end - start) / 1000);
    }

    private static void quickSort(String[] data, int left, int right) {
        final int CUTOFF = 10;
        
        if (left + CUTOFF <= right) {
            String pivot = median3(data, left, right);

            //Begin partitioning
            int i = left;
            int j = right - 1;
            for (;;) {
                while (data[i++].compareTo(pivot) < 0) {
                }
                while (data[j--].compareTo(pivot) > 0) {
                }
                if (i < j) {
                    swapReferences(data, i, j);
                } else {
                    break;
                }
            }

            swapReferences(data, i, right - 1); //Restore Pivot

            quickSort(data, left, i - 1);
            quickSort(data, i + 1, right);
        } else //Do an insertion sort on the subarray
        {
            insertionSort(data);
        }
    }

    private static String median3(String[] data, int left, int right) {
        int center = (left + right) / 2;
        if (data[center].compareTo(data[left]) < 0)
        {    swapReferences(data, left, center);}
        if (data[right].compareTo(data[left]) < 0)
        {    swapReferences(data, left, right);}
        if (data[right].compareTo(data[center]) < 0)
        {    swapReferences(data, center, right);}

        //Place pivot at position right - 1
        swapReferences(data, center, right - 1);
        return data[right - 1];
    }

    private static void swapReferences(String[] data, int item1, int item2) {
        String tmp = data[item1];
        data[item1] = data[item2];
        data[item2] = tmp;
    }

    /**********************************************************************/
    /**********************************************************************/
    
    //Called from main method
    //Loads 2 files and passes them to mergeSort(String[] data) method
    private static void mergeSort(String fileName1, String fileName2)
            throws FileNotFoundException
    {
        String[] data1 = createData(fileName1);
        String[] data2 = createData(fileName2);
        String[] data = new String[data1.length + data2.length];
        System.arraycopy(data1, 0, data, 0, data1.length);
        System.arraycopy(data2, 0, data, data1.length, data2.length);
        
        double start = System.nanoTime(); //start time here
        mergeSort(data);
        double end = System.nanoTime();  //end time here
	printTime((end - start) / 1000);
    }
    
    //Called from mergeSort(fileName1, fileName2) method
    private static void mergeSort(String[] data)
    {
        String[] tmpArray = (String[]) new Comparable[data.length];
        mergeSort(data, tmpArray, 0, data.length-1);
    }
    
    //Called from mergeSort(String[] data) method
    private static void mergeSort(String[] data,
            String[] tmpArray, int left, int right) {
        if(left < right)
        {
            int center = (left + right)/2;
            mergeSort(data,tmpArray, left, center);
            mergeSort(data,tmpArray, center+1, right);
            merge(data, tmpArray, left, center+1, right);
        }
    }
    
    //Helper method
    //Provides the physical changes to both passed arrays
    private static void merge(String[] data, String[] tmpArray,
            int leftPos, int rightPos, int rightEnd)
    {
        int leftEnd = rightPos - 1;
        int tmpPos = leftPos;
        int numElements = rightEnd - leftPos + 1;
        
        //Main Loop
        while(leftPos <= leftEnd && rightPos <= rightEnd)
            if(data[leftPos].compareTo(data[rightPos]) <= 0)
                tmpArray[tmpPos++] = data[leftPos++];
            else
                tmpArray[tmpPos++] = data[rightPos++];
        
        while(leftPos <= leftEnd)   //Copy rest of first half
            tmpArray[tmpPos++] = data[leftPos++];
        while(rightPos <= rightEnd) //Copy rest of right half
            tmpArray[tmpPos++] = data[rightPos++];
        
        //Copy tmpArray back
        for(int i = 0; i < numElements; i++, rightEnd--)
            data[rightEnd] = tmpArray[rightEnd];
    }

    /**********************************************************************
     **********************************************************************
    
    private static void externalSort(String fileName)
            throws FileNotFoundException
    {
        String[] data = createData(fileName);
        externalSort(data);
    }
    
    private static void externalSort(String[] data)
    {
        
    }

    **********************************************************************
    **********************************************************************/
    
    public static void main(String[] args) {
        try
        {
            insertionSort("b23.txt");
            BucketSort("bucketData.txt");
            quickSort("b23.txt");
            mergeSort("b23_1.txt", "b23_2.txt");
            //externalSort("b23.pro");
        }
        catch(FileNotFoundException e)
        {
            System.out.println("Error: File not found...");
        }
    }

    private static void printTime(double microseconds)
    {
 	System.out.printf("\n %.4f seconds\n", microseconds/1000000);
	System.out.printf(" %.4f minutes\n", (microseconds/1000000)/60);
	System.out.printf(" %.4f hours\n", ((microseconds/1000000)/60)/60);
    }
    
    
}
