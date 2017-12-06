import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BombNumbers {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(sc.nextLine().split("\\s+")).map(Integer::parseInt).collect(Collectors.toList());
        Integer[] arguments = Arrays.stream(sc.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);

        int specialNumber = arguments[0];
        int power = arguments[1];

        for (int i = 0; i < numbers.size(); i++) {
            if (specialNumber == numbers.get(i)){
                for (int j = Math.min(i + power, numbers.size() - 1); j >= Math.max(0, i - power); j--) {
                    numbers.remove(j);
                }

                i = -1;
            }
        }

        int sum = 0;

        for (int i = 0; i < numbers.size(); i++) {
            sum += numbers.get(i);
        }

        System.out.println(sum);
    }
}
