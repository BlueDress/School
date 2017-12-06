import java.util.Scanner;

public class CompareCharArrays {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] firstArray = sc.nextLine().split("\\s+");
        String[] secondArray = sc.nextLine().split("\\s+");

        String firstString = String.join("", firstArray);
        String secondString = String.join("", secondArray);

        if (firstString.compareTo(secondString) < 0){
            System.out.println(firstString);
            System.out.println(secondString);
        } else {
            System.out.println(secondString);
            System.out.println(firstString);
        }
    }
}
