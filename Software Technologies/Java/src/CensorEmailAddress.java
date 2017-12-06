import java.util.Scanner;

public class CensorEmailAddress {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String email = sc.nextLine();
        String textToCensor = sc.nextLine();

        int indexOfAt = email.indexOf('@');

        String domain = email.substring(indexOfAt);
        String censored = email.substring(0, indexOfAt).replaceAll(".", "*");
        String censoredEmail = censored + domain;

        String censoredText = textToCensor.replaceAll(email, censoredEmail);

        System.out.println(censoredText);
    }
}
