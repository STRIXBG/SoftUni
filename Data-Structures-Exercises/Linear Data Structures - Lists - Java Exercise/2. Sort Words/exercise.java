import java.util.*;

public class Main {

    public static int compare(String a, String b){
        char chA = a.charAt(0);
        char chB = b.charAt(0);
        int asciiA = chA;
        int asciiB = chB;
        if(asciiA > asciiB) return 0;
        return 1;
    }

    public static void sort(List<String> seq){
        Collections.sort(seq);
        for(String str : seq){
            System.out.printf("%s ",str);
        }
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<String> sequence = new ArrayList<>();
        while(sc.hasNext()){
            sequence.add(sc.next());
        }
        sort(sequence);
    }
}
