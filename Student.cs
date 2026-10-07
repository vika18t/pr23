using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace pr23
{
    internal class Student : IDataErrorInfo
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(FullName) && string.IsNullOrWhiteSpace(FullName))
                    return "ФИО не может быть пустым";

                if (columnName == nameof(Group))
                {
                    if (string.IsNullOrWhiteSpace(Group))
                        return "Группа не может быть пустой";

                    foreach (char c in Group)
                        if (!char.IsLetterOrDigit(c))
                            return "Только буквы или цифры";

                }

                if (columnName == nameof(Age) && (Age < 16 || Age > 70))

                    return "Возраст должен быть от 16 до 70";

                return null;

            }
        }
    }
}
