import java.util.Scanner;

public class ChangeToUppercase {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        while (true){
            int openTagIndex = input.indexOf("<upcase>");
            int closeTagIndex = input.indexOf("</upcase>");

            if (openTagIndex < 0 || closeTagIndex < 0){
                break;
            }

            String stringToReplace = input.substring(openTagIndex, closeTagIndex + 9);
            String stringToInsert = input.substring(openTagIndex + 8, closeTagIndex).toUpperCase();

            input = input.replaceFirst(stringToReplace, stringToInsert);
        }

        System.out.println(input);
    }
}
