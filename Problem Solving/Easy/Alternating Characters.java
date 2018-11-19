import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {
    // https://www.hackerrank.com/challenges/alternating-characters

    // Complete the alternatingCharacters function below.
    static int alternatingCharacters(String s) {
        int numOfDeletions = 0;
        Character previousCharacter = null;
        
        for (char character : s.toCharArray()) {
            if (previousCharacter != null && previousCharacter == character){
                numOfDeletions++;
            }
            
            previousCharacter = character;
        }
        
        return numOfDeletions;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            int result = alternatingCharacters(s);

            bufferedWriter.write(String.valueOf(result));
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
