using SchoolManagementSystem.Common;
using SchoolManagementSystem.Contracts.Controllers;
using SchoolManagementSystem.Contracts.Core;
using SchoolManagementSystem.Contracts.Entities;
using SchoolManagementSystem.Contracts.IO;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SchoolManagementSystem.Core
{
    public class Engine : IEngine
    {
        private const string Exit = "0";
        private const string AddTeacher = "1";
        private const string AddStudent = "2";
        private const string AddSchoolGroup = "3";
        private const string PrintTeacherInfo = "4";
        private const string AddStudentToSchoolGroup = "5";
        private const string AddSchoolGroupToTeacher = "6";

        private const string CreateTeacherCommand = "CreateTeacherCommand";
        private const string CreateStudentCommand = "CreateStudentCommand";
        private const string CreateSchoolGroupCommand = "CreateSchoolGroupCommand";
        private const string PrintTeacherInfoCommand = "PrintTeacherInfoCommand";
        private const string AddStudentToSchoolGroupCommand = "AddStudentToSchoolGroupCommand";
        private const string AddSchoolGroupToTeacherCommand = "AddSchoolGroupToTeacherCommand";

        private IManager manager;
        private IReader reader;
        private IWriter writer;
        private ITextFormatter formatter;

        public Engine(IManager manager, IReader reader, IWriter writer, ITextFormatter formatter)
        {
            this.manager = manager;
            this.reader = reader;
            this.writer = writer;
            this.formatter = formatter;
        }

        public void Run()
        {
            this.writer.WriteLine(Messages.Welcome);
            this.writer.WriteLine();

            string schoolName = ReadSchoolName();
            CreateSchool(schoolName);

            ParseInput();
        }

        private string ReadSchoolName()
        {
            this.writer.Write(Messages.EnterSchoolName);
            string schoolName = this.reader.ReadLine();

            if (NameIsInvalid(schoolName))
            {
                this.writer.WriteLine(ErrorMessages.InvalidSchoolName);
                this.writer.WriteLine();
                return this.ReadSchoolName();
            }
            else
            {
                return schoolName;
            }
        }

        private void CreateSchool(string schoolName)
        {
            this.manager.CreateSchool(schoolName);
            this.formatter.ClearScreen();
            this.writer.WriteLine($"{schoolName} {SuccessMessages.SchoolCreatedSuccessfully}");
            this.writer.WriteLine();
        }

        private void ParseInput()
        {
            while (true)
            {
                this.writer.WriteLine(Messages.Menu);

                string menuChoice = this.reader.ReadLine();

                if (menuChoice.Equals(Exit))
                {
                    this.formatter.ClearScreen();
                    this.writer.WriteLine(Messages.GoodBye);
                    break;
                }

                this.formatter.ClearScreen();

                string commandName = string.Empty;
                IList<string> args = new List<string>();

                switch (menuChoice)
                {
                    case AddTeacher:
                        args = ParseTeacherInfo();
                        commandName = CreateTeacherCommand;
                        break;
                    case AddStudent:
                        args = ParseStudentInfo();
                        commandName = CreateStudentCommand;
                        break;
                    case AddSchoolGroup:
                        args = ParseSchoolGroupInfo();
                        commandName = CreateSchoolGroupCommand;
                        break;
                    case PrintTeacherInfo:
                        args = ParseTeacherName();
                        commandName = PrintTeacherInfoCommand;
                        break;
                    case AddStudentToSchoolGroup:
                        args = ParseStudentAndSchoolGroupNames();
                        commandName = AddStudentToSchoolGroupCommand;
                        break;
                    case AddSchoolGroupToTeacher:
                        args = ParseTeacherAndSchoolGroupNames();
                        commandName = AddSchoolGroupToTeacherCommand;
                        break;
                    default:
                        this.formatter.ClearScreen();
                        this.writer.WriteLine(ErrorMessages.InvalidMenuInput);
                        break;
                }

                if (args != null && args.Count > 0)
                {
                    Type commandType = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name.Equals(commandName));
                    ConstructorInfo[] constructors = commandType.GetConstructors();
                    ICommand command = (ICommand)constructors[0].Invoke(new object[] { args, this.manager, this.formatter });
                    this.writer.WriteLine(command.Execute());
                }

                this.writer.WriteLine();
            }
        }

        private IList<string> ParseTeacherInfo()
        {
            this.writer.WriteLine(Messages.MenuChoiceCreateTeacher);
            this.writer.WriteLine();

            if (!ConfirmedChoice())
            {
                return null;
            }

            this.writer.Write(Messages.EnterTeacherFirstName);
            string teacherFirstName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterTeacherLastName);
            string teacherLastName = this.reader.ReadLine();

            if (NameIsInvalid(teacherFirstName, teacherLastName))
            {
                this.writer.WriteLine(ErrorMessages.InvalidTeacherName);
                this.writer.WriteLine();
                return this.ParseTeacherInfo();
            }

            return new List<string>() { teacherFirstName, teacherLastName };
        }

        private IList<string> ParseStudentInfo()
        {
            this.writer.WriteLine(Messages.MenuChoiceCreateStudent);
            this.writer.WriteLine();

            if (!ConfirmedChoice())
            {
                return null;
            }

            this.writer.Write(Messages.EnterStudentFirstName);
            string studentFirstName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterStudentLastName);
            string studentLastName = this.reader.ReadLine();

            if (NameIsInvalid(studentFirstName, studentLastName))
            {
                this.writer.WriteLine(ErrorMessages.InvalidStudentName);
                this.writer.WriteLine();
                return this.ParseStudentInfo();
            }

            return new List<string>() { studentFirstName, studentLastName };
        }

        private IList<string> ParseSchoolGroupInfo()
        {
            this.writer.WriteLine(Messages.MenuChoiceCreateSchoolGroup);
            this.writer.WriteLine();

            if (!ConfirmedChoice())
            {
                return null;
            }

            this.writer.Write(Messages.EnterGroupName);
            string schoolGroupName = this.reader.ReadLine();

            if (NameIsInvalid(schoolGroupName))
            {
                this.writer.WriteLine(ErrorMessages.InvalidSchoolGroupName);
                this.writer.WriteLine();
                return this.ParseSchoolGroupInfo();
            }

            return new List<string>() { schoolGroupName };
        }

        private IList<string> ParseTeacherName()
        {
            this.writer.WriteLine(Messages.MenuChoiceSearchTeacher);
            this.writer.WriteLine();

            if (!ConfirmedChoice())
            {
                return null;
            }

            this.writer.Write(Messages.EnterTeacherFirstName);
            string teacherFirstName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterTeacherLastName);
            string teacherLastName = this.reader.ReadLine();

            Teacher teacher = this.manager.GetTeacher(teacherFirstName, teacherLastName);

            if (teacher == null)
            {
                this.writer.WriteLine(ErrorMessages.NoTeacherFound);
                this.writer.WriteLine();
                return ParseTeacherName();
            }

            return new List<string>() { teacherFirstName, teacherLastName };
        }

        private IList<string> ParseStudentAndSchoolGroupNames()
        {
            this.writer.WriteLine(Messages.MenuChoiceAddStudentToSchoolGroup);
            this.writer.WriteLine();

            if (!ConfirmedChoice())
            {
                return null;
            }

            this.writer.Write(Messages.EnterGroupName);
            string schoolGroupName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterStudentFirstName);
            string studentFirstName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterStudentLastName);
            string studentLastName = this.reader.ReadLine();

            if (NameIsInvalid(schoolGroupName, studentFirstName, studentLastName))
            {
                this.writer.WriteLine(ErrorMessages.InvalidAddStudentToGroupName);
                this.writer.WriteLine();
                return this.ParseStudentAndSchoolGroupNames();
            }
            else
            {
                Student student = this.manager.GetStudent(studentFirstName, studentLastName);
                SchoolGroup schoolGroup = this.manager.GetSchoolGroup(schoolGroupName);

                if (student == null || schoolGroup == null)
                {
                    this.writer.WriteLine(ErrorMessages.NoStudentOrSchoolGroupFound);
                    this.writer.WriteLine();
                    return ParseStudentAndSchoolGroupNames();
                }

                return new List<string>() { studentFirstName, studentLastName, schoolGroupName };
            }
        }

        private IList<string> ParseTeacherAndSchoolGroupNames()
        {
            this.writer.WriteLine(Messages.MenuChoiceAddSchoolGroupToTeacher);
            this.writer.WriteLine();

            if (!ConfirmedChoice())
            {
                return null;
            }

            this.writer.Write(Messages.EnterGroupName);
            string schoolGroupName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterTeacherFirstName);
            string teacherFirstName = this.reader.ReadLine();

            this.writer.Write(Messages.EnterTeacherLastName);
            string teacherLastName = this.reader.ReadLine();

            if (NameIsInvalid(schoolGroupName, teacherFirstName, teacherLastName))
            {
                this.writer.WriteLine(ErrorMessages.InvalidSchoolGroupOrTeacherName);
                this.writer.WriteLine();
                return this.ParseTeacherAndSchoolGroupNames();
            }
            else
            {
                Teacher teacher = this.manager.GetTeacher(teacherFirstName, teacherLastName);
                SchoolGroup schoolGroup = this.manager.GetSchoolGroup(schoolGroupName);

                if (teacher == null || schoolGroup == null)
                {
                    this.writer.WriteLine(ErrorMessages.NoSchoolGroupOrTeacherFound);
                    this.writer.WriteLine();
                    return ParseTeacherAndSchoolGroupNames();
                }

                return new List<string>() { teacherFirstName, teacherLastName, schoolGroupName };
            }
        }

        private bool NameIsInvalid(params string[] names)
        {
            foreach (string name in names)
            {
                if (string.IsNullOrWhiteSpace(name) || name.Equals(string.Empty))
                {
                    return true;
                }
            }

            return false;
        }

        private bool ConfirmedChoice()
        {
            this.writer.Write(Messages.ConfirmChoice);

            string choice = this.reader.ReadLine();

            this.writer.WriteLine();
            this.formatter.ClearScreen();

            return choice.Equals("1");
        }
    }
}
