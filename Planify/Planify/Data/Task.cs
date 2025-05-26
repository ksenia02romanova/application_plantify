using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planify.Data
{
    public class Task
    {
        public Task(){}
        public Task(string name, Category сategory, DateTime deadLine, Priority priority, Reminder reminder)
        {
            Name = name;
            this.category = сategory;
            DeadLine = deadLine;
            this.priority = priority;
            this.reminder = reminder;
        }

        public string Name { get; set; }
        public Category category { get; set; }
        public DateTime DeadLine { get; set; }
        public Priority priority { get; set; }
        public Reminder reminder { get; set; }
        public bool IsCompleted { get; set; } = false;

        public override string ToString()
        {
            string category = string.Empty;
            switch (this.category)
            {
                case Category.Material:
                    category = "Материальные";
                    break;
                case Category.Personal:
                    category = "Личные";
                    break;
                case Category.Professional:
                    category = "Профессиональные";
                    break;
                case Category.Spiritual:
                    category = "Духовные";
                    break;
            }
            string priority = string.Empty;
            switch (this.priority)
            {
                case Priority.Low:
                    priority = "Низкий";
                    break;
                case Priority.Medium:
                    priority = "Средний";
                    break;
                case Priority.High:
                    priority = "Высокий";
                    break;
            }
            string reminder = string.Empty;
            switch (this.reminder)
            {
                case Reminder.None:
                    reminder = "нет";
                    break;
                case Reminder.Speedy:
                    reminder = "за 15 минут";
                    break;
                case Reminder.Fast:
                    reminder = "за 1 час";
                    break;
                case Reminder.Slow:
                    reminder = "за день";
                    break;
            }
            string status = IsCompleted ? "[✓]" : "[ ]";
            return $"Название: {Name}; Категория: {category}; Дедлайн: {DeadLine:dd.MM.yyyy}; " +
                $"Приоритет: {priority}; Напоминание: {reminder}; Статус: {status}";
        }
    }
}
