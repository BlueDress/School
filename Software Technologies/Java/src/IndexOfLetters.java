import java.util.Scanner;

public class IndexOfLetters {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        for (int i = 0; i < input.length(); i++) {
            System.out.printf("%c -> %d", input.charAt(i), input.charAt(i) - 'a');
            System.out.println();
        }
    }
}
