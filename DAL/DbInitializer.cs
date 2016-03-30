using System;
using System.Collections.Generic;
using System.Data.Entity;
using DAL.Entities;

namespace DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var quizes = new List<Quiz>
            {
                new Quiz
                {
                    Name = "Спорт",
                    Description = "Опрос на тему спорта",
                    CreatedOn = DateTime.Now,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Text = "Вы спортивный человек?",
                            QuestionType = QuestionType.radio,
                            Options = new List<Option>
                            {
                                new Option
                                {
                                    Name = "Нет, к сожалению",
                                    OptionType = OptionType.label,
                                    Position = 1
                                },
                                new Option
                                {
                                    Name = "Да, я иногда посещаю бассейн, тренажёрный зал или стадион",
                                    OptionType = OptionType.label,
                                    Position = 2
                                },
                                new Option
                                {
                                    Name = "Да, я регулярно тренируюсь, обычно несколько раз в неделю, не прерываясь на значительное время",
                                    OptionType = OptionType.label,
                                    Position = 3
                                },
                                new Option
                                {
                                    Name = "Другое",
                                    OptionType = OptionType.textbox,
                                    Position = 4
                                }
                            }
                        },
                        new Question
                        {
                            Text = "Какой вид автогонок вы предпочитаете?",
                            QuestionType = QuestionType.ckeckbox,
                            Options = new List<Option>
                            {
                                new Option
                                {
                                    Name = "Формула-1",
                                    OptionType = OptionType.label,
                                    Position = 1
                                },
                                new Option
                                {
                                    Name = "Ралли",
                                    OptionType = OptionType.label,
                                    Position = 2
                                },
                                new Option
                                {
                                    Name = "Гонки грузовиков",
                                    OptionType = OptionType.label,
                                    Position = 3
                                },
                                new Option
                                {
                                    Name = "Драг-рейсинг",
                                    OptionType = OptionType.label,
                                    Position = 4
                                },
                                new Option
                                {
                                    Name = "Картинг",
                                    OptionType = OptionType.label,
                                    Position = 4
                                },
                                new Option
                                {
                                    Name = "Трофи",
                                    OptionType = OptionType.label,
                                    Position = 4
                                }
                            }
                        },
                        new Question
                        {
                            Text = "Опишите первое спортивное соревнование, в котром вам приходилось участвовать",
                            QuestionType = QuestionType.textarea,
                            Options = new List<Option>
                            {
                                new Option
                                {
                                    OptionType = OptionType.textarea,
                                    Position = 1
                                }
                            }
                        }
                    }
                }
            };
            quizes.ForEach(q => context.Quizes.Add(q));
            context.SaveChanges();
        }
    }
}
