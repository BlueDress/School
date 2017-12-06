import java.util.Scanner;

public class ReverseCharacters {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        char firstChar = sc.nextLine().charAt(0);
        char secondChar = sc.nextLine().charAt(0);
        char thirdChar = sc.nextLine().charAt(0);

        System.out.printf("%c%c%c",thirdChar, secondChar, firstChar);
    }
}
