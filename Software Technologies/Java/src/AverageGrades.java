import java.util.ArrayList;
import java.util.Comparator;
import java.util.Scanner;
import java.util.stream.Collectors;

public class AverageGrades {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        ArrayList<Student> students = new ArrayList<>();
        int numberOfStudents = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < numberOfStudents; i++) {

            String[] studentArgs = sc.nextLine().split("\\s+");
            String studentName = studentArgs[0];

            ArrayList<Double> studentGrades = new ArrayList<>();

            for (int j = 1; j < studentArgs.length; j++) {
                studentGrades.add(Double.parseDouble(studentArgs[j]));
            }

            Student student = new Student(studentName, studentGrades);
            students.add(student);
        }

        students = students.stream().filter(s -> s.getAverageGrade() >= 5).collect(Collectors.toCollection(ArrayList::new));

        Comparator<Student> comparator = Comparator.comparing(s -> s.getName());
        comparator = comparator.thenComparing((s1, s2) -> Double.compare(s2.getAverageGrade(), s1.getAverageGrade()));

        students = students.stream().sorted(comparator).collect(Collectors.toCollection(ArrayList::new));

        for (Student student : students) {
            System.out.printf("%s -> %.2f", student.getName(), student.getAverageGrade());
            System.out.println();
        }
    }
}

class Student{
    private String name;
    private ArrayList<Double> grades;
    private double averageGrade;

    public Student(String name, ArrayList<Double> grades) {
        this.name = name;
        this.grades = grades;
        this.setAverageGrade();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public ArrayList<Double> getGrades() {
        return grades;
    }

    public void setGrades(ArrayList<Double> grades) {
        this.grades = grades;
    }

    public double getAverageGrade() {
        return averageGrade;
    }

    private void setAverageGrade() {
        double gradesSum = 0;

        for (int i = 0; i < this.grades.size(); i++) {
            gradesSum += this.grades.get(i);
        }

        this.averageGrade = gradesSum / this.grades.size();
    }
}
