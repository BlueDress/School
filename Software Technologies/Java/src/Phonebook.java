import java.util.*;

public class Phonebook {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        HashMap<String, String> phonebook = new HashMap<>();

        while (true) {
            String input = sc.nextLine();

            if (input.equals("END")){
                break;
            }

            String[] commands = input.split("\\s+");

            String command = commands[0];
            String name = commands[1];

            if (command.equals("A")){
                String phoneNumber = commands[2];

                if (!phonebook.containsKey(name)){
                    phonebook.put(name, phoneNumber);
                }

                phonebook.put(name, phoneNumber);
            } else {
                if (!phonebook.containsKey(name)){
                    System.out.printf("Contact %s does not exist.", name);
                    System.out.println();
                } else {
                    System.out.printf("%s -> %s", name, phonebook.get(name));
                    System.out.println();
                }
            }
        }
    }
}
