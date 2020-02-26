using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClassLibrary
{
    public class UserBase : IEquatable<UserBase>
    {
        [Category("Личные данные")]
        [DisplayName("Фамилия")]
        [Description("")]
        public string Name1 { get; set; } = "Иванов";

        [Category("Личные данные")]
        [DisplayName("Имя")]
        [Description("")]
        public string Name2 { get; set; } = "Иван";

        [Category("Личные данные")]
        [DisplayName("Отчество")]
        [Description("")]
        public string Name3 { get; set; } = "Иванович";

        public bool Equals(UserBase other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name1 == other.Name1 && Name2 == other.Name2 && Name3 == other.Name3;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((UserBase) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name1 != null ? Name1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name2 != null ? Name2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name3 != null ? Name3.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(UserBase left, UserBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserBase left, UserBase right)
        {
            return !Equals(left, right);
        }
    }

    public class User : IEquatable<User>
    {
        //private readonly UserBase _userBase = new UserBase();
        //public UserBase UserBase { get; set; } = new UserBase();

        [Category("Личные данные")]
        [DisplayName("Фамилия")]
        [Description("")]
        public string Name1 { get; set; } = "Иванов";

        [Category("Личные данные")]
        [DisplayName("Имя")]
        [Description("")]
        public string Name2 { get; set; } = "Иван";

        [Category("Личные данные")]
        [DisplayName("Отчество")]
        [Description("")]
        public string Name3 { get; set; } = "Иванович";

        [Category("Курс")]
        [DisplayName("Курс")]
        [Description("")]
        public int Course { get; set; } = 2;
        [Category("Курс")]
        [DisplayName("Группа")]
        [Description("")]
        public string Group { get; set; } = "0000-0000";
        [Category("Работа")]
        [DisplayName("Дата выполнения работы")]
        [Description("")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Category("Работа")]
        [DisplayName("Название работы")]
        [Description("")]
        public string Title { get; set; } = "Интервальные оценки";

        [Category("")]
        [DisplayName("Код")]
        [Description("")]
        public int HashCode => GetHashCode();


        public bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Name1 == other.Name1 && Name2 == other.Name2 && Name3 == other.Name3 && Course == other.Course && Group == other.Group && Title == other.Title;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Name1 != null ? Name1.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name2 != null ? Name2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name3 != null ? Name3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Course;
                hashCode = (hashCode * 397) ^ (Group != null ? Group.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(User left, User right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !Equals(left, right);
        }
    }
}
