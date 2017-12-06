import java.util.Scanner;

public class VariableInHexadecimalFormat {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String variableInHex = sc.nextLine();

        int variableInDecimal = Integer.parseInt(variableInHex, 16);

        System.out.println(variableInDecimal);
    }
}
