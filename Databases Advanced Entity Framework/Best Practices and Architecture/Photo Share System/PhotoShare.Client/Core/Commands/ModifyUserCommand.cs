namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using System;
    using System.Linq;

    public class ModifyUserCommand : ICommand
    {
        private PhotoShareContext context;

        public ModifyUserCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var username = data[0];
            var property = data[1];
            var newValue = data[2];

            if (Session.User.Username.Equals(username))
            {
                if (!context.Users.Any(u => u.Username.Equals(username)))
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                switch (property)
                {
                    case "Password":
                        var hasDigit = false;
                        var hasLowerCaseLetter = false;

                        foreach (var symbol in newValue)
                        {
                            if (Char.IsDigit(symbol))
                            {
                                hasDigit = true;
                            }

                            if (Char.IsLower(symbol))
                            {
                                hasLowerCaseLetter = true;
                            }
                        }

                        if (hasDigit && hasLowerCaseLetter)
                        {
                            context.Users.First(u => u.Username.Equals(username)).Password = newValue;
                            context.SaveChanges();

                            break;
                        }

                        throw new ArgumentException("Invalid Password");
                    case "BornTown":
                        if (!context.Towns.Any(t => t.Name.Equals(newValue)))
                        {
                            throw new ArgumentException($"Town {newValue} not found!");
                        }

                        context.Users.First(u => u.Username.Equals(username)).BornTown = context.Towns.First(t => t.Name.Equals(newValue));
                        context.SaveChanges();

                        break;
                    case "CurrentTown":
                        if (!context.Towns.Any(t => t.Name.Equals(newValue)))
                        {
                            throw new ArgumentException($"Town {newValue} not found!");
                        }

                        context.Users.First(u => u.Username.Equals(username)).CurrentTown = context.Towns.First(t => t.Name.Equals(newValue));
                        context.SaveChanges();

                        break;
                    default:
                        throw new ArgumentException($"Property {property} not supported!");
                }

                return $"User {username} {property} is {newValue}.";
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
