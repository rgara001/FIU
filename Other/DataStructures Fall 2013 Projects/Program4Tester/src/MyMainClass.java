/*********************************************************************
Author     : Raul Garay 
Course     : COP 3530 T,R 2-3pm
Professor  : Michael Robinson 
Program #  : 4
                                        
Due Date   : 12/03/2013 

Certification: 
I hereby certify that this work is my own and none of it
is the work of any other person. 
       

Raul Garay
*********************************************************************/


import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MyMainClass {
    
    /**
     * Creates a HashMap from the given file...Ends with createMap() method
     * Parameter: String inputFile: Name of the file that is to be read from
     * Parse through file: Key = word ... Value = first location of word only
     * No duplicate keys
     * Prints the HashMap to a file
    */
    private static void part1(String inputFile) 
    {
        Hashtable<String, Integer> hash = new Hashtable<String, Integer>();
        
        //Declare and initialize scanner to read from file.
        //in.useDelimiter("[^A-Za-z]+") only allows scanner to read the alphabet
        //Exception is caught and handled by reporting the issue
        Scanner in = new Scanner(System.in);
        try
        {
            in = new Scanner(new File(inputFile));
            in.useDelimiter("[^A-Za-z]+");
        }
        catch(FileNotFoundException e)
        {
            System.out.println("Error " + inputFile + " file not found...");
            System.exit(1);
        }
        
        //Parse through file as long as there are still words in the file
        //Only add to hash if word has not been added yet
        //Increment wordLocation during every read
        int wordLocation = 1;
        while(in.hasNext())
        {
            String word = in.next();
            if(!hash.containsKey(word))
            {
                hash.put(word, wordLocation);
            }
            wordLocation++;
        }
        
        printToFile(hash, "hashResults.txt");
        createMap(hash);
    }
    
    /**
     * Creates a TreeMap using the Hashtable passed as a parameter
     * Use hash keys as values for map and hash values as keys for map
     * 
    */
    private static void createMap(Hashtable hash)
    {
        TreeMap<Integer, String> map = new TreeMap<Integer, String>();
        
        Iterator<String> inValue = (Iterator<String>) hash.keySet().iterator();
        Iterator<Integer> inKey = (Iterator<Integer>) hash.values().iterator();
        while(inValue.hasNext() && inKey.hasNext())
        {
            map.put(inKey.next(), inValue.next());
        }
        
        printToFile(map, "mapResults.txt");
    }
    
    public static void printToFile(Map object, String fileName)
    {
        
        //Create filewriter (uses polymorphism)
        File path = new File(fileName);
        try{
            PrintWriter out = new PrintWriter(path);
            out.println(object.entrySet().toString());
            out.close();
        }
        catch(IOException e){
            System.out.println(e.getMessage());
        }
    }
    
    private static void bucket()
    {
        final int MAX = 9;
        int[] data= {5,4,9,0,1,0,2,3,1,4,5,9,3,0,5};
        int[] bucket = new int[MAX+1];
        
        for(int i = 0; i < bucket.length; i++)
        {
            bucket[i] = 0;
        }
        
        for(int i = 0; i < data.length; i++)
        {
            bucket[data[i]]++;
        }
        
        int outPosition = 0;
        for(int i = 0; i < bucket.length; i++)
        {
            for(int j = 0; j < bucket[i]; j++)
            {
                data[outPosition++] = i;
            }
        }
        printBucket(data, "bucketResults.txt");
        
        ArrayList<Integer> even = new ArrayList<Integer>();
        ArrayList<Integer> odd = new ArrayList<Integer>();
        
        for(int i = 0; i < data.length; i++)
        {
            if(data[i]%2 == 0)
                even.add(data[i]);
            else
                odd.add(data[i]);
        }
        
        int[] evenAr = new int[even.size()];
        int[] oddAr = new int[odd.size()];
        for(int i = 0; i < even.size(); i++)
        {
            evenAr[i] = even.get(i);
        }
        for(int i = 0; i < odd.size(); i++)
        {
            oddAr[i] = odd.get(i);
        }
        
        printBucket(evenAr, "evenBucketResults.txt");
        printBucket(oddAr, "oddBucketResults.txt");
        
        
    }
    
    private static void printBucket(int[] data, String fileName)
    {
                //Create filewriter (uses polymorphism)
        File path = new File(fileName);
        try{
            PrintWriter out = new PrintWriter(path);
            for(int i = 0; i < data.length; i++)
            {
                out.print(data[i] + " ");
            }
            out.close();
        }
        catch(IOException e){
            System.out.println(e.getMessage());
        }
    }

    
    /**
     * Main Method implements Part1 (HashMap & TreeMap) and Part2 (bucketSort)
       of Assignment 4.
     * The results of each part are then printed onto their respective text
       files.
    */
    public static void main(String[] args)
    {
        part1("dataSample.txt");        
        bucket();
    }
    
}
