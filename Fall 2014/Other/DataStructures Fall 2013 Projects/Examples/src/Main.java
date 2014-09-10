
import java.io.*;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
public class Main {
    
  
    public static void main(String[] args)
    {
        
        File path = new File("hello.txt");
        try{
            PrintWriter out = new PrintWriter(path);
            out.print("dale");
            out.close();
        }
        catch(IOException e){
            System.out.println(e.getMessage());
        }
 
        List<String> people = new ArrayList<>();
        
        Collections.sort(people);
        
        //Create HashMap/TreeMap
        //Create files and scanner. Use in.delimiter("[A-Za-z]+")
        //Parse through file with in.hasNext() and in.next() in a while loop
            //Check if key (word) is already in Map
                //If so, increment the value field by 1
                //If not, create Map.Entry with word = key and long = value
        //If hash, sort data
            //Create new ArrayList
        String x = "a";
        String y = "b";
        List<String> c = new ArrayList<>();
        c.add(y); c.add(x);
        System.out.println(c.toString());
        Collections.sort(c);
        System.out.println(c.toString());
        
    }
}
