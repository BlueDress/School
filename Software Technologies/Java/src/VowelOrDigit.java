import java.util.Scanner;

public class VowelOrDigit {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String inputChar = sc.nextLine().toLowerCase();

        if (inputChar.charAt(0) == 'a' || inputChar.charAt(0) == 'o' || inputChar.charAt(0) == 'e' || inputChar.charAt(0) == 'i' || inputChar.charAt(0) == 'u'){
            System.out.println("vowel");
        } else if (tryParseInt(inputChar)) {
            System.out.println("digit");
        } else {
            System.out.println("other");
        }
    }

    static boolean tryParseInt(String value) {
        try {
            Integer.parseInt(value);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }
}
