using System;

namespace SchoolManagementSystem.Common
{
    public static class Messages
    {
        public static readonly string Welcome = "Добре дошли в системата за училищно управление!";
        public static readonly string GoodBye = "Благодаря, че използвахте системата за училищно управление!";
        public static readonly string Menu =
            $@"Въведете номер, за да извършите желаната от Вас операция.{Environment.NewLine}{Environment.NewLine}
                1 - За добавяне на учител.{Environment.NewLine}
                2 - За добавяне на ученик.{Environment.NewLine}
                3 - За добавяне на училищна група.{Environment.NewLine}
                4 - За отпечатване на информация за учител.{Environment.NewLine}
                5 - За добавяне на ученик към училищна група.{Environment.NewLine}
                6 - За добавяне на група към учител.{Environment.NewLine}
                0 - За изход от програмата.{Environment.NewLine}";

        public static readonly string MenuChoiceCreateTeacher = "Избрахте да добавите учител.";
        public static readonly string MenuChoiceCreateStudent = "Избрахте да добавите ученик.";
        public static readonly string MenuChoiceCreateSchoolGroup = "Избрахте да добавите училищна група.";
        public static readonly string MenuChoiceSearchTeacher = "Избрахте да търсите информация за учител.";
        public static readonly string MenuChoiceAddStudentToSchoolGroup   = "Избрахте да добавите ученик към група.";
        public static readonly string MenuChoiceAddSchoolGroupToTeacher = "Избрахте да добавите група към учител.";

        public static readonly string EnterSchoolName = "Моля въведете име на училището: ";
        public static readonly string EnterStudentFirstName = "Моля въведете първото име на ученика: ";
        public static readonly string EnterStudentLastName = "Моля въведете фамилията на ученика: ";
        public static readonly string EnterTeacherFirstName = "Моля въведете първото име на учителя: ";
        public static readonly string EnterTeacherLastName = "Моля въведете фамилията на учителя: ";
        public static readonly string EnterGroupName = "Моля въведете име на училищната група: ";

        public static readonly string ConfirmChoice = "Въведете 1, за да продължите или друг символ за връщане обратно в главното меню: ";
    }
}
