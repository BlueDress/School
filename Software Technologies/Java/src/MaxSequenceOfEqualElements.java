import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Integer[] numbers = Arrays.stream(sc.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);

        int element = numbers[0];
        int timesRepeated = 1;

        for (int i = 0; i < numbers.length; i++) {

            int currentTimesRepeated = 1;

            for (int j = i + 1; j < numbers.length; j++) {
                if (numbers[i] == numbers[j]) {
                    currentTimesRepeated++;
                } else {
                    break;
                }
            }

            if (currentTimesRepeated > timesRepeated) {
                timesRepeated = currentTimesRepeated;
                element = numbers[i];
            }
        }

        for (int i = 0; i < timesRepeated; i++) {
            System.out.print(element + " ");
        }

        System.out.println();
    }
}
