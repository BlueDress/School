import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        Integer[] numbers = Arrays.stream(sc.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);

        int element = 0;
        int sequenceLenght = 1;

        for (int i = 0; i < numbers.length; i++) {

            int currentSequenceLenght = 1;

            for (int j = i; j < numbers.length - 1; j++) {
                if (numbers[j] < numbers[j + 1]) {
                    currentSequenceLenght++;
                } else {
                    break;
                }
            }

            if (currentSequenceLenght > sequenceLenght) {
                sequenceLenght = currentSequenceLenght;
                element = i;
            }
        }

        for (int i = element; i < element + sequenceLenght; i++) {
            System.out.print(numbers[i] + " ");
        }

        System.out.println();
    }
}
