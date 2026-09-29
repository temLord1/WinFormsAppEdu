using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WinFormsAppEdu
{
    // Включает в себя:
    // Все свойства, на которые далее легче ссылаться в программе
    // Методы записи, чтения и обработки матрицы
    // Возможно слишком много лишнего, idk.
    static public class MatrixProvider
    {
        static public string READPATH { get; private set; } = "tabel.txt";
        static public string WRITEPATH { get; private set; } = "results.txt";
        static public int MONTHS { get; private set; } = 12;
        static public int[,]? Matrix { get; private set; }
        static public string[]? Headers { get; private set; }
        static public int[]? RowsSums { get; private set; }
        static public int[]? ColsSums { get; private set; }
        static public int RowsMaxIdx { get; private set; } = -1;
        static public int ColsMinIdx { get; private set; } = -1;
        static public Boolean ErrorFlag { get; private set; } = false;

        public static void GenerateTextFile()
        {
            using (var writer = new StreamWriter(READPATH))
            {
                var rand = new Random();
                int shops_rnd = rand.Next(5, 10);

                for (int i = 0; i < shops_rnd; i++)
                {
                    writer.Write($"Магазин{i + 1} ");
                    for (int month = 0; month < 12; month++)
                    {
                        writer.Write($"{rand.Next(1, 100)} ");
                    }
                    writer.Write("\n");
                }
            }
        }

        static public void ReadMatrixFile()
        {
            ResetProperties();
            if (!(File.Exists(READPATH))) // Если идёт попытка прочитать несуществующий файл
            {
                MessageBox.Show("Файл не существует!", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorFlag = true;
                return;
            }

            int strings = FileStringsCount(READPATH);
            Matrix = new int[MONTHS, strings];


            using (var reader = new StreamReader(READPATH))
            {
                Headers = new string[strings];

                for (int i = 0; i < strings; i++)
                {
                    string? currentLine = reader.ReadLine();
                    if ((!string.IsNullOrWhiteSpace(currentLine))) // Обрабатываются только заполненные строки
                    {
                        string[] items = currentLine!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string mask = @"Магазин\d+";
                        if (!(Regex.IsMatch(items[0], mask))) // Проверка названий магазинов по маске
                        {
                            MessageBox.Show("Некорректное название магазинов!\nПроверьте файл чтения.", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ErrorFlag = true;
                            return;
                        }
                        Headers[i] = items[0];

                        if (items.Length != MONTHS + 1) // Слишком много/мало элементов через пробел в одной строке
                        {
                            MessageBox.Show("Слишком много/мало данных!\nПересмотрите пример задачи и исправьте исходный файл", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ErrorFlag = true;
                            return;
                        }

                        for (int j = 1; j < items.Length; j++)
                        {
                            if (int.TryParse(items[j], out int value))
                            {
                                Matrix[j - 1, i] = value;
                                RowsSums![j - 1] += value;
                                ColsSums![i] += value;

                            }
                            else // Не удалось запарсить элемент
                            {
                                MessageBox.Show("Некорректные данные в файле!", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ErrorFlag = true;
                                return;
                            }
                        }
                    }
                    else // Уменьшение индекса, чтобы строка попала по настоящему месту.
                    {
                        i--;
                    }
                }
            }
            if (Matrix.GetLength(1) <= 0 || Matrix.GetLength(0) <= 0) // Последняя проверка на успешное чтение файла
            {
                MessageBox.Show("Не удалось прочитать файл!", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorFlag = true;
                return;
            }
            FindMinMax();
        }

        // Метод для счёта количества строк в файле
        // Я не нашел способа лучше, пусть хоть так ig
        static public int FileStringsCount(string readPath)
        {
            using (var reader = new StreamReader(readPath))
            {
                string? currentLine;
                int linesCounter = 0;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(currentLine))
                    {
                        linesCounter++;
                    }
                }
                ColsSums = new int[linesCounter];
                RowsSums = new int[MONTHS];
                return linesCounter;
            }
        }

        static public void ResetProperties() 
        {
            RowsMaxIdx = -1;
            ColsMinIdx = -1;
            Matrix = null;
            Headers = null;
            RowsSums = null;
            ColsSums = null;
            ErrorFlag = false;
        }

        static public void FindMinMax()
        {
            int rowsMax = int.MinValue;
            int colsMin = int.MaxValue;
            for (int j = 0; j < RowsSums!.Length; j++)
            {
                if (RowsSums[j] > rowsMax)
                {
                    rowsMax = RowsSums[j];
                    RowsMaxIdx = j;
                }
            }
            for (int i = 0; i < ColsSums!.Length; i++)
            {
                if (ColsSums[i] < colsMin)
                {
                    colsMin = ColsSums[i];
                    ColsMinIdx = i;
                }
            }
        }

        static public string FindShopsStatistic()
        {
            string result = "";
            int[] colsSumsCopy = new int[ColsSums!.Length];
            string[] headersCopy = new string[Headers!.Length];
            ColsSums.CopyTo(colsSumsCopy);
            Headers.CopyTo(headersCopy);

            for (int i = 0; i < colsSumsCopy.Length; i++)
            {
                int minNum = int.MaxValue; 
                int minIdx = -1;
                for (int j = i; j < colsSumsCopy.Length; j++)
                {
                    if (colsSumsCopy[j] < minNum) 
                    {
                        minNum = colsSumsCopy[j];
                        minIdx = j;
                    }
                }
                int tempInt = colsSumsCopy[i];
                string tempStr = headersCopy[i];
                colsSumsCopy[i] = colsSumsCopy[minIdx];
                headersCopy[i] = headersCopy[minIdx];
                colsSumsCopy[minIdx] = tempInt;
                headersCopy[minIdx] = tempStr;

                result += $"{headersCopy[i]} - {colsSumsCopy[i]}\r\n";
                // TextBox настолько старый, что все еще использует CRLF.
            }
            return result;
        }

        static public void WriteStatisticFile()
        {
            using (var writer = new StreamWriter(WRITEPATH))
            {
                writer.Write(FindShopsStatistic());
            }
        }
    }
}
