import java.util.Scanner;

public class BooleanVariable {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        Boolean result = Boolean.valueOf(input);

        if (result) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
