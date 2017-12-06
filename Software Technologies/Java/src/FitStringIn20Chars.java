import java.util.Scanner;

public class FitStringIn20Chars {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        if (input.length() >= 20) {
            System.out.println(input.substring(0, 20));
        } else {
            int numberOfStarsToDraw = 20 - input.length();
            System.out.print(input);

            for (int i = 0; i < numberOfStarsToDraw; i++) {
                System.out.print("*");
            }

            System.out.println();
        }
    }
}
