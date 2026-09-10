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
        static public int[,]? matrix { get; private set; }
        static public string[]? headers { get; private set; }
        static public int[]? rowsSums { get; private set; }
        static public int[]? colsSums { get; private set; }
        static public int rowsMaxIdx { get; private set; } = -1;
        static public int colsMinIdx { get; private set; } = -1;
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
            int strings = FileStringsCount(READPATH);
            matrix = new int[MONTHS, strings];

            using (var reader = new StreamReader(READPATH))
            {
                headers = new string[strings];

                for (int i = 0; i < strings; i++)
                {
                    string currentLine = reader.ReadLine() ?? "null";
                    string[] items = currentLine!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string mask = @"Магазин\d+";
                    if (!(Regex.IsMatch(items[0], mask)))
                    {
                        MessageBox.Show("Некорректное название магазинов!\nПроверьте файл чтения.", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ErrorFlag = true;
                        return;
                    }
                    headers[i] = items[0];

                    if (items.Length != MONTHS+1) // Слишком много/мало элементов через пробел в одной строке
                    {
                        MessageBox.Show("Слишком много/мало данных!\nПересмотрите пример задачи и исправьте исходный файл", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ErrorFlag = true;
                        return;
                    }

                    for (int j = 1; j < items.Length; j++)
                    {
                        if (int.TryParse(items[j], out int value))
                        {
                            matrix[j-1, i] = value;
                            rowsSums![j - 1] += value;
                            colsSums![i] += value;

                        }
                        else // Не удалось запарсить элемент
                        {
                            MessageBox.Show("Некорректные данные в файле!","Ошибка Чтения Файла",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ErrorFlag = true;
                            return;
                        }
                    }
                }
            }
            if (matrix.GetLength(1) <= 0 || matrix.GetLength(0) <= 0) // Последняя проверка на успешное чтение файла
            {
                MessageBox.Show("Не удалось прочитать файл.", "Ошибка Чтения Файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorFlag = true;
                return;
            }

            // Следующие два for'a на поиск макс/мин.
            int rowsMax = int.MinValue;
            int colsMin = int.MaxValue;
            for (int j = 0; j < rowsSums!.Length; j++)
            {
                if (rowsSums[j] > rowsMax)
                {
                    rowsMax = rowsSums[j];
                    rowsMaxIdx = j;
                }
            }
            for (int i = 0; i < colsSums!.Length; i++)
            {
                if (colsSums[i] < colsMin)
                {
                    colsMin = colsSums[i];
                    colsMinIdx = i;
                }
            }
        }

        // Метод для счёта количества строк в файле
        // Я не нашел способа лучше, пусть хоть так ig
        static public int FileStringsCount(string readPath)
        {
            using (var reader = new StreamReader(readPath))
            {
                string? currentLine;
                int linesCounter = 0;

                while ((currentLine = reader.ReadLine()) != null && currentLine != "")
                {
                    linesCounter++;
                }
                colsSums = new int[linesCounter];
                rowsSums = new int[MONTHS];
                return linesCounter;
            }
        }

        static public void ResetProperties() 
        {
            rowsMaxIdx = -1;
            colsMinIdx = -1;
            matrix = null;
            headers = null;
            rowsSums = null;
            colsSums = null;
            ErrorFlag = false;
        }

        static public string FindShopsStatistic()
        {
            string result = "";
            int[] colsSumsCopy = new int[colsSums!.Length];
            string[] headersCopy = new string[headers!.Length];
            colsSums.CopyTo(colsSumsCopy);
            headers.CopyTo(headersCopy);

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
