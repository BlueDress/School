namespace SchoolManagementSystem.Common
{
    public static class ErrorMessages
    {
        public static readonly string InvalidSchoolName = "Името на училището не може да бъде празно.";
        public static readonly string InvalidMenuInput = "Въведеният номер е невалиден.";
        public static readonly string InvalidTeacherName = "Имената на учителя не може да бъдат празни.";
        public static readonly string InvalidStudentName = "Имената на ученика не може да бъдат празни.";
        public static readonly string InvalidSchoolGroupName = "Името на училищната група не може да бъде празно.";
        public static readonly string InvalidAddStudentToGroupName = "Имената на училищната група и/или на ученика не може да бъдат празни.";
        public static readonly string InvalidSchoolGroupOrTeacherName = "Имената на училищната група и/или на учителя не може да бъдат празни.";

        public static readonly string NoTeacherFound = "Няма такъв учител.";
        public static readonly string NoStudentOrSchoolGroupFound = "Няма такъв ученик и/или училищна група.";
        public static readonly string NoSchoolGroupOrTeacherFound = "Няма такъв учител и/или училищна група.";
    }
}
