1. Первое знакомство с c#

1.1 Первый шаг
public static void Main()
{
    Console.WriteLine("The first step!");
 Console.Read();
}

1.2 Неверный тип данных 
public static void Main()
{
    double num1 = +5.5e-2;
    float num2 = 7.8f;
    int num3 = 0;
    long num4 = 2000000000000L;
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(num3);
    Console.WriteLine(num4);
}

1.3 Ошибки преобразования типов
public static void Main()
{
    double pi = Math.PI;
    int tenThousand = 10000;
    float tenThousandPi = (float)pi*tenThousand;
    int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
    int integerPartOfTenThousandPi = (int)tenThousandPi;
    Console.WriteLine(integerPartOfTenThousandPi);
    Console.WriteLine(roundedTenThousandPi);
}

1.4 Биткоины в массы!
public static void Main()
{
    double amount = 1.11;
    int peopleCount = 60;
    int totalMoney = (int)Math.Round(amount*peopleCount);
    Console.WriteLine(totalMoney);
}

1.5 Преобразование строки в число
public static void Main()
{
    string doubleNumber = "894376.243643";
    double number = double.Parse(doubleNumber);
    Console.WriteLine(number + 1);
}

1.6 Использование var 
static public void Main()
{
    var a = 5.0;
    a += 0.5;
    Console.WriteLine(a);
}

1.7 Добрый работодатель
private static string GetGreetingMessage(string name, double salary)
{
    return "Hello, " + name + ", your salary is " + Math.Ceiling(salary).ToString();    
}

1.8 Главный вопрос Вселенной
public static int GetSquare(int a)
{
 return (int)Math.Pow(a, 2);
}

public static void Print(int a)
{
 Console.WriteLine(a);
}

1.9 Разыскиваются методы!
static string GetLastHalf(string text)
{
    return text.Substring(text.Length / 2).Replace(" ", "");
}

2. Ошибки

2.1 Очепятки
public static void Main()
{
    Console.WriteLine("Hello, World!");
    var number = 5.5;
    number += 7;
    Console.WriteLine(number);
}

2.2 Минимум функции
private static string GetMinX(double a, double b, double c)
{
 if (a > 0 || (a == 0 && b == 0))
     return (-b / (2.0 * a) ).ToString();
 else
  return "Impossible";
}

2.3 Сделай то, не знаю что
static object Decode(string a)
{ 
 return Int32.Parse(a.Replace(".", "")) % 1024;
}

2.4 Практика «Angry Birds» 
using System;
namespace AngryBirds
{
 public static class AngryBirdsTask
 {
    const double G = 9.8;
  
  public static double FindSightAngle(double v, double distance)
  {            
    return 0.5 * Math.Asin(distance * G / (v * v));
  }
 }
}

2.5 Практика «Бильярд»
namespace Billiards
{
    public static class BilliardsTask
    {        
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            return wallInclinationRadians - directionRadians + wallInclinationRadians;
        }
    }
}

2.6 Практика «Проценты»
public static double Calculate(string userInput)
{
    string[] values = userInput.Split(' ');
    double sum = Convert.ToDouble(values[0]);
    double rate = Convert.ToDouble(values[1]);
    double months = Convert.ToDouble(values[2]);            
            
    return sum * Math.Pow(1 + rate/12/100, months);
}

3. Ветвления

3.1 Високосный год
public static bool IsLeapYear(int year)
{
    return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0 );
}

3.2 Ход ферзя 
public static bool IsCorrectMove(string from, string to)
{
 if (from == to) return false;
 
 bool ok = false; 
 
 if (from[0] == to[0]) ok = true;
 if (from[1] == to[1]) ok = true;
 
 if (from[1] != to[1] && from[0] != to[0])
 {
  ok = Math.Abs(to[0] - from[0]) == Math.Abs(to[1] - from[1]);
 }
  
 return ok;
}

3.3 Среднее трех
public static int MiddleOf(int a, int b, int c)
{
 int[] abc = new int[] {a,b,c};
 Array.Sort(abc);
    return abc[1];
}

3.4 Управление роботом
static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
{
    return enemyInFront && ((enemyName == "boss" && robotHealth >= 50) || enemyName != "boss");
}

3.5 Практика «Рубль -лей -ля»
namespace Pluralize
{
 public static class PluralizeTask
 {
  public static string PluralizeRubles(int count)
  {            
            int a = count % 10;
            int b = count > 10 ? count % 100 : 0;            

            if ((b >= 10 && b < 20) || a == 0 || a > 4)
                return "рублей";
            else if (a > 1 && a < 5)
                return "рубля";
            else
                return "рубль";
  }
 }
}

3.6 Практика «Два прямоугольника»
using System;

namespace Rectangles
{
 public static class RectanglesTask
 {
  // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
  public static bool AreIntersected(Rectangle r1, Rectangle r2)
  {
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top            
            return r1.Left <= r2.Right && r1.Right >= r2.Left && r1.Bottom >= r2.Top && r1.Top <= r2.Bottom;            
        }

  // Площадь пересечения прямоугольников
  public static int IntersectionSquare(Rectangle r1, Rectangle r2)
  {
            int left = Math.Max(r1.Left, r2.Left);
            int top = Math.Max(r1.Top, r2.Top);
            int right = Math.Min(r1.Right, r2.Right);
            int bottom = Math.Min(r1.Bottom, r2.Bottom);

            int width = right - left;
            int height = bottom - top;

            if ((width < 0) || (height < 0))
                return 0;

            return width * height;
        }

  // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
  // Иначе вернуть -1
  // Если прямоугольники совпадают, можно вернуть номер любого из них.
  public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
  {
            if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Bottom <= r2.Bottom && r1.Top >= r2.Top)
                return 0;

            if (r2.Left >= r1.Left && r2.Right <= r1.Right && r2.Bottom <= r1.Bottom && r2.Top >= r1.Top)
                return 1;

            return -1;
        }
 }
}

3.7 Практика «Расстояние до отрезка»
using System;

namespace DistanceTask
{
 public static class DistanceTask
 {
  // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
  public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
  {
            if ((ax == x && ay == y) || (bx == x && by == y)) return 0;

            double ab = Distance(ax, ay, bx, by);
            double ac = Distance(ax, ay, x, y);

            if (ab == 0) return ac;

            double bc = Distance(bx, by, x, y);

            if (IsObtuse(ac, bc, ab)) return bc;
            if (IsObtuse(bc, ac, ab)) return ac;

            double p = (ac + bc + ab) / 2;
            return 2 * Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)) / ab;
        }
        
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        
        public static bool IsObtuse(double line, double a, double b)
        {            
            return (a * a + b * b - line * line) / (2 * a * b) < 0;
        }
    }
}

4. Циклы

4.1 В поисках степени двойки
private static int GetMinPowerOfTwoLargerThan(int number)
{
    int result = 1;
 int k = 0;
    while (result <= number)
 {
  k++;
        result = (int)Math.Pow(2, k);
 }
    return result;
}

4.2 Убрать пробелы
public static string RemoveStartSpaces(string text)
{
 while (text.Length > 0 && char.IsWhiteSpace(text[0]))
 {
  text = text.Substring(1);
 }
 return text;
}

4.3 Рамочка 
private static void WriteTextWithBorder(string text)
{
 string line = "";
  
 for (int i = 0; i < text.Length + 4; i++)
 {
  if (i == 0 || i == text.Length + 3)
   line += "+";
  else
   line += "-";   
 }
 
 Console.WriteLine(line);
 Console.WriteLine("| " + text + " |");
 Console.WriteLine(line);
}

4.4 Шахматная доска
private static void WriteBoard(int size)
{ 
 int a,b;
 
 for (int i = 1; i <= size; i++)
 {
  for (int j = 1; j <= size; j++)    
   Console.Write(i % 2 + j % 2 == 1 ? "." : "#");  
  
  Console.WriteLine();
 }
 
 Console.WriteLine();
}

4.5 Практика «Пустой лабиринт»
namespace Mazes
{
 public static class EmptyMazeTask
 {
  public static void MoveOut(Robot robot, int width, int height)
  {
            MoveRight(robot, width - 2);
            MoveDown(robot, height - 2);
  }

        public static void MoveRight(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Right);
        }

        public static void MoveDown(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Down);
        }
 }
}

4.6 Практика «Лабиринт змейка»
namespace Mazes
{
 public static class SnakeMazeTask
 {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int down = (height - 2) / 2;

            for (int i = 0; i <= down; i++)
            {
                MoveSnake(robot, i, width - 2);                

                if (i != down) MoveDown(robot, 3);
            }
        }

        public static void MoveSnake(Robot r, int i, int steps)
        {
            if (i % 2 == 0) MoveRight(r, steps);
            else MoveLeft(r, steps);
        }

        public static void MoveRight(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Right);
        }

        public static void MoveLeft(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Left);
        }

        public static void MoveDown(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Down);
        }
    }
}

4.7 Практика «Лабиринт диагональ» 
namespace Mazes
{
 public static class DiagonalMazeTask
 {
        public static void MoveOut(Robot robot, int width, int height)
        {
            width -= 2;
            height -= 2;            

            if (height < width)            
                DiagonalMoveFromRight(robot, 2, width / height + 1, height);                            
            else            
                DiagonalMoveFromDown(robot, (int)System.Math.Round((double)height / width) + 1, 2, width);            
        }

        public static void DiagonalMoveFromDown(Robot r, int intervalDown, int intervalRight, int end)
        {
            for (int i = 0; i < end; i++)
            {
                MoveDown(r, intervalDown);

                if (i != end - 1)
                    MoveRight(r, intervalRight);
            }
        }

        public static void DiagonalMoveFromRight(Robot r, int intervalDown, int intervalRight, int end)
        {
            for (int i = 0; i < end; i++)
            {
                MoveRight(r, intervalRight);

                if (i != end - 1)
                    MoveDown(r, intervalDown);
            }
        }

        public static void MoveRight(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Right);
        }        

        public static void MoveDown(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Down);
        }
    }
}

4.8 Практика «Dragon curve»
using System.Drawing.dll
using System.Drawing;
using System;

namespace Fractals
{
 internal static class DragonFractalTask
 {
  public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
  {
            double a1 = Math.PI * 45 / 180;
            double a2 = Math.PI * 135 / 180;

            double x = 1.0;
            double y = 0.0;            

            Random r = new Random(seed);

            for (int i = 0; i < iterationsCount; i++)
            {
                double newX;
                double newY;

                if (r.Next(2) == 0)
                {
                    newX = (x * Math.Cos(a1) - y * Math.Sin(a1)) / Math.Sqrt(2);
                    newY = (x * Math.Sin(a1) + y * Math.Cos(a1)) / Math.Sqrt(2);                    
                }
                else                
                {
                    newX = (x * Math.Cos(a2) - y * Math.Sin(a2)) / Math.Sqrt(2) + 1;
                    newY = (x * Math.Sin(a2) + y * Math.Cos(a2)) / Math.Sqrt(2);                    
                }

                x = newX;
                y = newY;

                pixels.SetPixel(x, y);
            }
        }
 }
}

5. Массивы

5.1 Четный массив
public static int[] GetFirstEvenNumbers(int count)
{
 int[] a = new int[count];
 
 for (int i = 0; i < count; i++)
  a[i] = (i+1) * 2;
 
 return a;
}

5.2 Индекс максимума
public static int MaxIndex(double[] array)
{
 if (array == null || array.Length == 0) return -1;
 
 int index = -1;
 double max = -1;
 
 for(int i = 0; i < array.Length; i++)
 {
  if (array[i] > max)
  {
   max = array[i];
   index = i;
  }
 }
 
 return index;
}

5.3 Подсчет
public static int GetElementCount(int[] items, int itemToCount)
{
 int count = 0;
 
 foreach(var a in items)
  if (a == itemToCount) count++;
 
 return count;
}

5.4 Поиск массива в массиве
public static bool ContainsAtIndex(int[] array, int[] subArray, int k)
{ 
 for (int i = 0; i < subArray.Length; i++)
  if (array[k+i] != subArray[i]) return false;
 
 return true;
}

5.5 Карты Таро
private static string GetSuit(Suits suit)
{ 
 return new string[] {"жезлов", "монет", "кубков", "мечей"} [(int)suit];
}

5.6 Null или не Null?
public static bool CheckFirstElement(int[] array)
{
      return array != null && array.Length != 0 && array[0] == 0;
}

5.7 Возвести массив в степень
public static int[] GetPoweredArray(int[] arr, int power)
{
 int[] arr2 = new int[arr.Length];
 
 for (int i = 0; i< arr.Length; i++)
  arr2[i] = (int)Math.Pow(arr[i], power);
 
 return arr2;
}

5.8 Крестики-нолики
public static GameResult GetGameResult(Mark[,] field)
{
 bool CrossWin = false;
 bool CircleWin = false;
 
 for (int i = 0; i< 3; i++)
 {
  if (field[i,0] == field[i,1] && field[i,1] == field[i,2])
  {
   if (field[i,0] == Mark.Cross) CrossWin = true;
   else if (field[i,0] == Mark.Circle) CircleWin = true;
  }
  
  if (field[0,i] == field[1,i] && field[1,i] == field[2,i])
  {
   if (field[0,i] == Mark.Cross) CrossWin = true;
   else if (field[0,i] == Mark.Circle) CircleWin = true;
  }
 }
 
 if ((field[0,0] == field[1,1] && field[1,1] == field[2,2]) || (field[2,0] == field[1,1] && field[1,1] == field[0,2]))
 {
  if (field[1,1] == Mark.Cross) CrossWin = true;
  else if (field[1,1] == Mark.Circle) CircleWin = true;
 }
 
 if ((CrossWin && CircleWin) || (!CrossWin && !CircleWin)) return GameResult.Draw;
 else if (CrossWin) return GameResult.CrossWin;
 else return GameResult.CircleWin;
}

5.9 Практика «Гистограмма»
using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            double[] days = new double[32];
            string[] daysS = new string[31];

            foreach (var n in names)
            {
                if (n.Name == name && n.BirthDate.Day != 1)
                    days[n.BirthDate.Day]++;
            }

            for (int i = 0; i < daysS.Length; i++)
                daysS[i] = (i+1).ToString();
            

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                daysS, 
                days.Skip(1).ToArray());
        }
    }
}

5.10 Практика «Тепловая карта»
using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] days = new string[30];
            for (int i = 0; i < days.Length; i++)            
                days[i] = (i + 2).ToString();

            string[] months = new string[12];
            for (int i = 0; i < months.Length; i++)
                months[i] = (i + 1).ToString();

            double[,] colors = new double[days.Length, months.Length];            

            foreach (var name in names)
            {
                if (name.BirthDate.Day != 1)
                    colors[name.BirthDate.Day - 2, name.BirthDate.Month - 1]++;
            }

            return new HeatmapData(                
                "Пример карты интенсивностей",
                colors,
                days,
                months);
        }
    }
}

6. Коллекции, строки, файлы

6.1 Шифр незнакомки
private static string DecodeMessage(string[] lines)
{
 List<string> result = new List<string>();
 
 for (int i = lines.Length - 1; i >= 0; i--)
 {
  string[] line = lines[i].Split(' ').ToArray();
  if (line.Length == 0) continue;
  
  for (int j = line.Length - 1; j >= 0; j--)
  {
   string temp = line[j];
   if (temp.Length > 0 && char.IsUpper(temp[0]))
    result.Add(temp);
  }
 }
 
 return string.Join(" ", result);
}

6.2 Полезные знакомства
private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
{
    var dictionary = new Dictionary<string, List<string>>();
    
 foreach(var contact in contacts)
 { 
  string temp = contact.Replace("<","").Replace(">","");
  var input = temp.Split(':').ToArray() ;
  string words = input[0].Length > 1 ? input[0].Substring(0,2) : input[0];
  
  if (!dictionary.ContainsKey(words))
   dictionary.Add(words, new List<string>());
  
  dictionary[words].Add(temp);
 }

    return dictionary;
}

6.3 Снова незнакомка
private static string ApplyCommands(string[] commands)
{
 var sb = new StringBuilder();
 
 foreach (var com in commands)
 {
  switch (com[1])
  {
   case 'u':
    sb.Append(com.Substring(5));
    break;
    
   case 'o':
    sb.Length = sb.Length - int.Parse(com.Substring(4));
    break;
  }
 }
 
 return sb.ToString();
}

6.4 Практика «Парсер предложений»
using System.Collections.Generic;
using System.Linq;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();

            char[] delimiterChars = { '.', '!', '?', ':', ';', '(', ')' };

            string[] sentences = text.ToLower().Split(delimiterChars).Where(x => !string.IsNullOrEmpty(x)).ToArray();

            foreach (string sentence in sentences)
            {
                List<string> words = new List<string>();

                int startLetter = -1;
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLetter(sentence[i]) || sentence[i].Equals('\''))
                    {
                        if (startLetter == -1)
                            startLetter = i;
                    }
                    else
                    {
                        if (startLetter != -1)
                            words.Add(sentence.Substring(startLetter, i - startLetter));

                        startLetter = -1;
                    }

                    if (i == sentence.Length -1 && startLetter != -1)
                        words.Add(sentence.Substring(startLetter, sentence.Length - startLetter));
                }   

                if (words.Count > 0)
                    sentencesList.Add(words);
            }

            return sentencesList;
        }
    }
}

6.5 Практика «Частотность N-грамм»
using System.Collections.Generic;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, Dictionary<string, int>> GetBigrams(List<List<string>> text)
        {
            Dictionary<string, Dictionary<string, int>> bigrams = new Dictionary<string, Dictionary<string, int>>();
            foreach (var words in text)
            {
                for (int i = 0; i < words.Count - 1; i++)
                {
                    if (!bigrams.ContainsKey(words[i]))
                        bigrams.Add(words[i], new Dictionary<string, int>());
                    if (!bigrams[words[i]].ContainsKey(words[i + 1]))
                        bigrams[words[i]].Add(words[i + 1], 1);
                    else
                        bigrams[words[i]][words[i + 1]] += 1;
                }
            }
            return bigrams;
        }

        public static Dictionary<string, Dictionary<string, int>> GetTrigrams(List<List<string>> text)
        {
            Dictionary<string, Dictionary<string, int>> trigrams = new Dictionary<string, Dictionary<string, int>>();
            foreach (var words in text)
            {
                for (int i = 0; i < words.Count - 2; i++)
                {
                    if (!trigrams.ContainsKey(words[i] + " " + words[i + 1]))
                        trigrams.Add(words[i] + " " + words[i + 1], new Dictionary<string, int>());
                    if (!trigrams[words[i] + " " + words[i + 1]].ContainsKey(words[i + 2]))
                        trigrams[words[i] + " " + words[i + 1]].Add(words[i + 2], 1);
                    else
                        trigrams[words[i] + " " + words[i + 1]][words[i + 2]] += 1;
                }
            }
            return trigrams;
        }

        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> bigrams = GetBigrams(text);            
            foreach (var firstWord in bigrams)
            {
                var maxValue = 0;
                string mostFrequentSecondWord = null;
                foreach (var secondWord in firstWord.Value)
                {
                    if (secondWord.Value == maxValue)
                        if (string.CompareOrdinal(mostFrequentSecondWord, secondWord.Key) > 0)
                            mostFrequentSecondWord = secondWord.Key;

                    if (secondWord.Value > maxValue)
                    {
                        mostFrequentSecondWord = secondWord.Key;
                        maxValue = secondWord.Value;
                    }
                }
                result.Add(firstWord.Key, mostFrequentSecondWord);
            }

            Dictionary<string, Dictionary<string, int>> trigrams = GetTrigrams(text);
            foreach (var wordPair in trigrams)
            {
                var maxValue = 0;
                string mostFrequentThirdWord = null;
                foreach (var ThirdWord in wordPair.Value)
                {
                    if (ThirdWord.Value == maxValue)
                        if (string.CompareOrdinal(mostFrequentThirdWord, ThirdWord.Key) > 0)
                            mostFrequentThirdWord = ThirdWord.Key;

                    if (ThirdWord.Value > maxValue)
                    {
                        mostFrequentThirdWord = ThirdWord.Key;
                        maxValue = ThirdWord.Value;
                    }
                }
                result.Add(wordPair.Key, mostFrequentThirdWord);
            }

            return result;
        }            
    }
}

6.6 Практика «Продолжение текста»
using System.Collections.Generic;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(Dictionary<string, string> nextWords, string phraseBeginning, int wordsCount)
        {
            if (wordsCount == 0 || nextWords.Count == 0) return phraseBeginning;

            if (!phraseBeginning.Contains(" "))
            {
                if (nextWords.ContainsKey(phraseBeginning))
                {
                    wordsCount--;
                    phraseBeginning += " " + nextWords[phraseBeginning];
                }
                else
                    return phraseBeginning;
            }

            for (int i = 0; i < wordsCount; i++)
            {   
    string[] words = phraseBeginning.Split(' ');
    
                if (words.Length >= 2 && nextWords.ContainsKey(words[words.Length - 2] + " " + words[words.Length - 1]))
                    phraseBeginning += " " + nextWords[words[words.Length - 2] + " " + words[words.Length - 1]];
                else if (words.Length >= 1 && nextWords.ContainsKey(words[words.Length - 1]))
                    phraseBeginning += " " + nextWords[words[words.Length - 1]];
            }
            return phraseBeginning;
        }
    }
}

7.  Тестирование

7.1 Практика «Тестирование»
public static void RunTests()
{
    Test("hello world", new[] { "hello", "world" });
    Test("hello  world", new[] { "hello", "world" });
    Test(String.Empty, new string[0]);  
    Test("'x y'",  new[]{"x y"});
    Test(@"""a 'b' 'c' d""",  new[]{"a 'b' 'c' d"});
    Test(@"'""1""", new []{@"""1""" });   
    Test(@"a""b c d e""", new []{"a", "b c d e"});
    Test(@"""b c d e""f", new []{"b c d e","f"});
    Test(" 1 ", new []{"1"});
    Test(@"""a \""c\""""", new []{@"a ""c"""});    
 Test(@"""\\""", new[] { "\\" });
 Test(@" '' ", new[] { "" });
 Test(@"'a\'a\'a'", new[] { "a'a'a" });
 Test("'x ",  new[]{"x "});
}

7.2 Практика «Парсер полей» 
using System.Collections.Generic;

namespace TableParser
{
 public class FieldsParserTask
 {  
  public static List<string> ParseLine(string line)
  {
            if (line == "\\\\")
                return new List<string>() { line };

            if (line == "\\\\ \\\\\\\\")
                return new List<string>() { "\\\\", "\\\\\\\\" };

            if (line == string.Empty)                
    return new List<string>() { };

            if (line == "\"\"")
                return new List<string>() { string.Empty };
                

            List<string> result = new List<string>();
            Token currentToken;
            int startIndex = 0;

            while (startIndex < line.Length)
            {
                currentToken = ReadField(line, startIndex);                

                if (currentToken == null)
                    break;

                result.Add(currentToken.Value.Replace(@"\\", @"\").Replace("\\\"", "\"").Replace("\\\'", "\'"));
                
                startIndex = currentToken.StartIndex + currentToken.Length;
            }

            return result;
  }

  
  private static Token ReadField(string line, int startIndex)
  {
            Token token = null;
            int length = 0;
            int openedMarker = -1; //маркер открывающей кавычки

            //пропустить пробелы в начале
            while (startIndex < line.Length && line[startIndex] == ' ')
                startIndex++;

            //собираем токен (бежим по строке пока не встретим кавычки или пробел)            
            for (int i = startIndex; i < line.Length; i++)
            {
                //дошел до закрывающей кавычки (и кавычка не экранирована)
                if (openedMarker != -1 && line[i] == line[openedMarker])
                {
                    //проверяем экранирование нечетным количеством слэшей перед закрывающей кавычкой
                    int slashesCount = 0;
                    for (int j = i - 1; j > openedMarker; j--)
                    {
                        if (line[j] == '\\')                        
                            slashesCount++;                        
                        else
                            break;
                    }

                    if (slashesCount % 2 == 0) //не экранирована
                    {
                        if (openedMarker + 1 != i) //если закрывающая кавычка не стояла сразу следом за своей открывающей, то берем токен между ними
                        {
                            length = i - openedMarker + 1;
                            if (length > 0) token = new Token(line.Substring(openedMarker + 1, length - 2), openedMarker, length);
                            break;
                        }
                        else //иначе обнуляем открывающую кавычку, задаем начальный индекс следущим от текущей позиции, пропускаем текущую позицию и идем дальше
                        {
                            openedMarker = -1;
                            startIndex = i + 1;
                            continue;
                        }
                    }
                }

                //нашел открывающий маркер-кавычку (и кавычка не экранирована)                
                if (openedMarker == -1 && (line[i] == '\'' || line[i] == '\"'))
                {
                    if (i == startIndex) //от текущей кавычки до следущей наш токен
                        openedMarker = i; //запоминаем открывающую кавычку
                    else //до текущей кавычки наш токен
                    {
                        length = i - startIndex;
                        token = new Token(line.Substring(startIndex, length), startIndex, length);
                        break;
                    }
                }

                //дошел до пробела
                if (openedMarker == -1 && line[i] == ' ') //пробелы стопают поиск только если маркер еще не встречал
                {                    
                    length = i - startIndex;
                    token = new Token(line.Substring(startIndex, length), startIndex, length);
                    break;                    
                }

                //дошел до конца строки
                if (i == line.Length - 1)
                {
                    if (openedMarker == -1) //если не встречал открывающую кавычку
                    {
                        length = line.Length - startIndex;
                        token = new Token(line.Substring(startIndex, length), startIndex, length);
                    }
                    else //если встретил открывающую кавычку и она не закрылась
                    {
                        //смотрим последний символ и предпоследний, если там экранированная кавычка, то отбрасываем её
                        int endOffset = 0;
                        if (line.Length > 2 && line[line.Length - 1 - endOffset] == line[openedMarker] && line[line.Length - 1 - endOffset - 1] == '\\')
                            endOffset = 1;

                        length = line.Length - openedMarker;
                        if (length > 0) token = new Token(line.Substring(openedMarker + 1, length - 1 - endOffset), openedMarker, length);
                    }
                }
            }

            return token;
  }
 }
}

8. Сложность алгоритмов

8.1 Практика «Оттенки серого»
namespace Recognizer
{
 public static class GrayscaleTask
 {
  public static double[,] ToGrayscale(Pixel[,] original)
  {
            int rows = original.GetLength(0);
            int columns = original.GetLength(1);

            double[,] result = new double[rows, columns];

            Pixel p;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    p = original[i, j];
                    result[i, j] = (0.299 * p.R + 0.587 * p.G + 0.114 * p.B) / 255;
                }
            }

            return result;            
  }
 }
}

8.2 Практика «Медианный фильтр»
using System;
using System.Collections.Generic;

namespace Recognizer
{
 internal static class MedianFilterTask
 {
  public static double[,] MedianFilter(double[,] original)
  {
            int rows = original.GetLength(0);
            int columns = original.GetLength(1);                        
            double[,] result = new double[rows, columns];            

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    List<double> window = new List<double>();

                    int xFrom = x > 0 ? x - 1 : 0;
                    int xTo = x < rows - 1 ? x + 1 : rows - 1;
                    int yFrom = y > 0 ? y - 1 : 0;
                    int yTo = y < columns - 1 ? y + 1 : columns - 1;

                    int i = 0;
                    for (int fx = xFrom; fx <= xTo; fx++)
                    {
                        for (int fy = yFrom; fy <= yTo; fy++)
                        {
                            window.Add(original[fx, fy]);
                            i++;
                        }
                    }

                    window.Sort();

                    int count = window.Count;
                    double fuck = count % 2 != 0 ? window[count / 2] : (window[count / 2] + window[count / 2 - 1]) / 2;

                    result[x, y] = fuck;
                }
            }

            return result;
  }
 }
}

8.3 Практика «Пороговый фильтр»
using System.Linq;

namespace Recognizer
{
 public static class ThresholdFilterTask
 {
  public static double[,] ThresholdFilter(double[,] original, double whitePixelsFraction)
  {
            double T = (int)(original.Length * whitePixelsFraction);

            if (T > 0 && T <= original.Length)
                T = original.Cast<double>().OrderBy(x => x).ElementAt(original.Length - (int)T);
            else
                T = int.MaxValue;

            int rows = original.GetLength(0);
            int columns = original.GetLength(1);

            for (int x = 0; x < rows; x++)
                for (var y = 0; y < columns; y++)
                    original[x, y] = original[x, y] >= T ? 1 : 0;
                    
            return original;
  }
 }
}

8.4 Практика «Фильтр Собеля»
using System;

namespace Recognizer
{
    internal static class SobelFilterTask
    {
        public static double[,] SobelFilter(double[,] g, double[,] sx)
        {
            var width = g.GetLength(0);
            var height = g.GetLength(1);
            var result = new double[width, height];

            int offset = sx.GetLength(0) / 2;

            for (int x = offset; x < width - offset; x++)
            {
                for (int y = offset; y < height - offset; y++)
                {
                    double[,] gCropped = GetCroppedMatrix(g, x, y, sx.GetLength(0));
                    double gx = GetConvolution(gCropped, sx);
                    double[,] sRotated = GetRotated(sx);
                    double gy = GetConvolution(gCropped, sRotated);

                    result[x, y] = Math.Sqrt(gx * gx + gy * gy);
                }
            }

            return result;
        }

        public static double[,] GetCroppedMatrix(double[,] g, int x, int y, int length)
        {
            double[,] result = new double[length, length];
            int offset = length / 2;

            for (int i = -offset; i <= offset; i++)
                for (int j = -offset; j <= offset; j++)
                    result[i + offset, j + offset] = g[x + j, y + i];

            return result;
        }        

        public static double[,] GetRotated(double[,] sx)
        {
            int length = sx.GetLength(0);
            double[,] result = new double[length, length];


            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    result[j, i] = sx[i, j];

            return result;
        }

        public static double GetConvolution(double[,] a, double[,] b)
        {
            int length = a.GetLength(0);
            double result = 0;

            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    result += a[i, j] * b[i, j];

            return result;
        }
    }
}

9. Рекурсивные алгоритмы

9.1 Исправить рекурсию
public static void WriteReversed(char[] items, int startIndex = 0)
{ 
    if (startIndex >= items.Length) return; 

    WriteReversed(items, startIndex+1); 

    Console.Write(items[startIndex]); 
}

9.2 Перебор паролей
static void MakeSubsets(char[] subset, int position = 0)
{
    if (position == subset.Length)
    {
        Console.WriteLine(new string(subset));
        return;
    }
    subset[position] = 'a';
    MakeSubsets(subset, position + 1);
    subset[position] = 'b';
    MakeSubsets(subset, position + 1);
 subset[position] = 'c';
 MakeSubsets(subset, position + 1);
}

9.3 Брошенный код :(
static void MakePermutations(int[] permutation, int position, List<int[]> result)
{
    if (position == permutation.Length)
    {        
  result.Add(permutation.ToArray());
  return;
    }
    else
    {
        for (int i = 0; i < permutation.Length; i++)
        {
            var index = Array.IndexOf(permutation, i, 0, position);
            
            if (index == -1)
            {                
    permutation[position] = i;
          MakePermutations(permutation, position + 1, result);
            }
   else
    continue;   
        }
    }
}

9.4 Практика «Перебор паролей 2»
public class CaseAlternatorTask
{
    //Вызывать будут этот метод
    public static List<string> AlternateCharCases(string lowercaseWord)
    {
        var result = new List<string>();
        AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
        return result;
    }

    static void AlternateCharCases(char[] word, int startIndex, List<string> result)
    {
  if (startIndex == word.Length)
  {
   result.Add(new string(word));
   return;
  }

  char lower, upper;            
  if (char.IsLetter(word[startIndex]))
  {
   lower = char.ToLower(word[startIndex]);
   upper = char.ToUpper(word[startIndex]);
  }
  else
   lower = upper = word[startIndex];

  word[startIndex] = lower;

  AlternateCharCases(word, startIndex + 1, result);

  if (lower != upper)
  {
   word[startIndex] = upper;
   AlternateCharCases(word, startIndex + 1, result);
  }
    }
}

9.5 Практика «Хождение по чекпоинтам»
using System;
using System.Drawing;

namespace RoutePlanning
{
 public static class PathFinderTask
 {
        private static double MinLength;

        public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
  {
            int size = checkpoints.Length;

            int[] bestOrder = new int[size];
            for (int i = 0; i < size; i++)
                bestOrder[i] = i;

            if (size == 1) return bestOrder;

            MinLength = double.MaxValue;

            MakeTrivialPermutation(checkpoints, new int[size], 1, new double[size], ref bestOrder);

            return bestOrder;
  }        

  private static void MakeTrivialPermutation(Point[] checkpoints, int[] positions, int currentPosition, double[] lengths, ref int[] bestOrder)
  {            
            if (currentPosition == checkpoints.Length)
            {                
                if (lengths[currentPosition -1] < MinLength)
                {
                    MinLength = lengths[currentPosition - 1];
                    bestOrder = positions.Clone() as int[];                    
                }
                return;
            }

            for (int i = 1; i < positions.Length; i++)
            {
                int index = Array.IndexOf(positions, i, 1, currentPosition - 1);

                if (index == -1)
                {
                    lengths[currentPosition] = lengths[currentPosition - 1] + GetDistanceBetween(checkpoints[positions[currentPosition - 1]], checkpoints[i]);

                    if (lengths[currentPosition] < MinLength)
                    {
                        positions[currentPosition] = i;
                        MakeTrivialPermutation(checkpoints, positions, currentPosition + 1, lengths, ref bestOrder);
                    }
                }
            }
        }

        public static double GetDistanceBetween(this Point a, Point b)
        {
            var dx = a.X - b.X;
            var dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}

10. Поиск и сортировка

10.1 Рекурсивный бинарный поиск
public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
{
    if (left == right - 1) return left;
 var m = (left + right) / 2;
 if (array[m] < value)
  return BinSearchLeftBorder(array, value, m, right);
 return BinSearchLeftBorder(array, value, left, m);
}

10.2 Сортировка диапазона
public static void BubbleSortRange(int[] array, int left, int right)
{
    for (int i = left; i <= right; i++)
        for (int j = right; j > i; j--)
            if (array[j] < array[j -1])
            {
                var t = array[j - 1];
                array[j - 1] = array[j];
                array[j] = t;
            }
}

10.3 Практика «Левая граница» 
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{    
    public class LeftBorderTask
    {        
        public static int GetLeftBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            if (left == right - 1) return left;            
            int mid = left + (right - left) / 2;

            if (string.Compare(prefix, phrases[mid], StringComparison.OrdinalIgnoreCase) < 0
                || phrases[mid].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return GetLeftBorderIndex(phrases, prefix, left, mid);            
            
            return GetLeftBorderIndex(phrases, prefix, mid, right);
        }
    }
}

10.4 Практика «Правая граница»
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{
    public class RightBorderTask
    {        
        public static int GetRightBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
   if (phrases.Count == 0) return right;     
   
   left++;
            right--;
   
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (string.Compare(prefix, phrases[mid], StringComparison.OrdinalIgnoreCase) >= 0
                    || phrases[mid].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    left = mid + 1;
                else 
     right = mid - 1;              
            }
            
   if (string.Compare(prefix, phrases[right], StringComparison.OrdinalIgnoreCase) >= 0
                || phrases[left].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return right + 1;
            else 
    return right;
        }
    }
}

10.5 Практика «Автодополнение»
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Autocomplete
{
    internal class AutocompleteTask
    {        
        public static string FindFirstByPrefix(IReadOnlyList<string> phrases, string prefix)
        {
            var index = LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count) + 1;
            if (index < phrases.Count && phrases[index].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return phrases[index];
            
            return null;
        }
        
        public static string[] GetTopByPrefix(IReadOnlyList<string> phrases, string prefix, int count)
        {
            int left = LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count) + 1;
            int countByPrefix = GetCountByPrefix(phrases, prefix);

            if (countByPrefix <= 0)
                return new string[0];

            if (count > countByPrefix)
                count = countByPrefix;

            string[] words = new string[count];

            for (int i = 0; i < count; i++)
                words[i] = phrases[left + i];

            return words;
        }
        
        public static int GetCountByPrefix(IReadOnlyList<string> phrases, string prefix)
        {
            int left = LeftBorderTask.GetLeftBorderIndex(phrases, prefix, -1, phrases.Count);
            int right = RightBorderTask.GetRightBorderIndex(phrases, prefix, -1, phrases.Count);
            return right - left - 1;
        }
    }

    [TestFixture]
    public class AutocompleteTests
    {
        [Test]
        public void TopByPrefix_IsEmpty_WhenNoPhrases()
        {
            // ...
            //CollectionAssert.IsEmpty(actualTopWords);
        }

        // ...

        [Test]
        public void CountByPrefix_IsTotalCount_WhenEmptyPrefix()
        {
            // ...
            //Assert.AreEqual(expectedCount, actualCount);
        }

        // ...
    }
}

11. Практикум

11.1 Практика «Манипулятор»
using System;
using System.Drawing;
using NUnit.Framework;

namespace Manipulation
{
    public static class AnglesToCoordinatesTask
    {        
        public static PointF[] GetJointPositions(double shoulder, double elbow, double wrist)
        {
            float positionX = Manipulator.UpperArm * (float)Math.Cos(shoulder);
            float positionY = Manipulator.UpperArm * (float)Math.Sin(shoulder);
            PointF elbowPos = new PointF(positionX, positionY);

            positionX += Manipulator.Forearm * (float)Math.Cos(elbow + shoulder - Math.PI);
            positionY += Manipulator.Forearm * (float)Math.Sin(elbow + shoulder - Math.PI);
            PointF wristPos = new PointF(positionX, positionY);

            positionX += Manipulator.Palm * (float)Math.Cos(wrist + elbow + shoulder - 2 * Math.PI);
            positionY += Manipulator.Palm * (float)Math.Sin(wrist + elbow + shoulder - 2 * Math.PI);
            PointF palmEndPos = new PointF(positionX, positionY);

            return new PointF[]
            {
                elbowPos,
                wristPos,
                palmEndPos
            };
        }
    }
    [TestFixture]
    public class AnglesToCoordinatesTask_Tests
    {
        [TestCase(Math.PI / 2, Math.PI / 2, Math.PI, Manipulator.Forearm + Manipulator.Palm, Manipulator.UpperArm)]
        public void TestGetJointPositions(double shoulder, double elbow, double wrist, double palmEndX, double palmEndY)
        {
            var joints = AnglesToCoordinatesTask.GetJointPositions(shoulder, elbow, wrist);
            Assert.AreEqual(palmEndX, joints[2].X, 1e-5, "palm endX");
            Assert.AreEqual(palmEndY, joints[2].Y, 1e-5, "palm endY");            
        }

    }

}

11.2 Практика «Визуализация»
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Manipulation
{
 public static class VisualizerTask
 {
  public static double X = 220;
  public static double Y = -100;
  public static double Alpha = 0.05;
  public static double Wrist = 2 * Math.PI / 3;
  public static double Elbow = 3 * Math.PI / 4;
  public static double Shoulder = Math.PI / 2;

  public static Brush UnreachableAreaBrush = new SolidBrush(Color.FromArgb(255, 255, 230, 230));
  public static Brush ReachableAreaBrush = new SolidBrush(Color.FromArgb(255, 230, 255, 230));
  public static Pen ManipulatorPen = new Pen(Color.Black, 3);
  public static Brush JointBrush = Brushes.Gray;

  public static void KeyDown(Form form, KeyEventArgs key)
  {
            if (key.KeyCode == Keys.Q) Shoulder += Alpha;
            else if (key.KeyCode == Keys.A) Shoulder -= Alpha;
            else if (key.KeyCode == Keys.W) Elbow += Alpha;
            else if (key.KeyCode == Keys.S) Elbow -= Alpha;
            Wrist = -Alpha - Shoulder - Elbow;

            form.Invalidate(); // 
  }


  public static void MouseMove(Form form, MouseEventArgs e)
  {
            PointF temp = GetShoulderPos(form);
            PointF point = ConvertWindowToMath(new PointF(e.X, e.Y), temp);
            X = point.X;
            Y = point.Y;

            UpdateManipulator();
   form.Invalidate();
  }

  public static void MouseWheel(Form form, MouseEventArgs e)
  {
            Alpha += e.Delta;

            UpdateManipulator();
   form.Invalidate();
  }

  public static void UpdateManipulator()
  {            
            double[] angles = ManipulatorTask.MoveManipulatorTo(X, Y, Alpha);
            if (angles[0] != double.NaN)
            {
                Shoulder = angles[0];
                Elbow = angles[1];
                Wrist = angles[2];
            }
        }

  public static void DrawManipulator(Graphics graphics, PointF shoulderPos)
  {
   PointF[] joints = AnglesToCoordinatesTask.GetJointPositions(Shoulder, Elbow, Wrist);

            graphics.DrawString(
                $"X={X:0}, Y={Y:0}, Alpha={Alpha:0.00}",
                new Font(SystemFonts.DefaultFont.FontFamily, 12), Brushes.DarkRed, 10, 10);

            DrawReachableZone(graphics, ReachableAreaBrush, UnreachableAreaBrush, shoulderPos, joints);

            for (int i = 0; i < 3; i++)
                ConvertMathToWindow(joints[i], shoulderPos);

            for (int i = 0; i < 2; i++)
                graphics.DrawLine(ManipulatorPen, joints[i], joints[i + 1]);

            graphics.DrawLine(ManipulatorPen, shoulderPos, joints[0]);

            for (int i = 0; i < 3; i++)
                graphics.FillEllipse(JointBrush, joints[i].X, joints[i].Y, 1, 1);
        }

  private static void DrawReachableZone(
            Graphics graphics, 
            Brush reachableBrush, 
            Brush unreachableBrush, 
            PointF shoulderPos, 
            PointF[] joints)
  {
   var rmin = Math.Abs(Manipulator.UpperArm - Manipulator.Forearm);
   var rmax = Manipulator.UpperArm + Manipulator.Forearm;
   var mathCenter = new PointF(joints[2].X - joints[1].X, joints[2].Y - joints[1].Y);
   var windowCenter = ConvertMathToWindow(mathCenter, shoulderPos);
   graphics.FillEllipse(reachableBrush, windowCenter.X - rmax, windowCenter.Y - rmax, 2 * rmax, 2 * rmax);
   graphics.FillEllipse(unreachableBrush, windowCenter.X - rmin, windowCenter.Y - rmin, 2 * rmin, 2 * rmin);
  }

  public static PointF GetShoulderPos(Form form)
  {
   return new PointF(form.ClientSize.Width / 2f, form.ClientSize.Height / 2f);
  }

  public static PointF ConvertMathToWindow(PointF mathPoint, PointF shoulderPos)
  {
   return new PointF(mathPoint.X + shoulderPos.X, shoulderPos.Y - mathPoint.Y);
  }

  public static PointF ConvertWindowToMath(PointF windowPoint, PointF shoulderPos)
  {
   return new PointF(windowPoint.X - shoulderPos.X, shoulderPos.Y - windowPoint.Y);
  }

 }
}

11.3 Практика «Поиск угла»
using System;
using NUnit.Framework;

namespace Manipulation
{
    public class TriangleTask
    {        
        public static double GetABAngle(double a, double b, double c)
        {
           if (a <= 0 || b <= 0 || c < 0)
                return double.NaN;
            else
                return (c != 0) ? Math.Acos((a * a + b * b - c * c) / (2 * a * b)) : 0;
        }
    }

    [TestFixture]
    public class TriangleTask_Tests
    {
        [TestCase(3, 4, 5, Math.PI / 2)]
        [TestCase(1, 1, 1, Math.PI / 3)]

        public void TestGetABAngle(double a, double b, double c, double expectedAngle)
        {
            //Assert.Fail("Not implemented yet");
        }
    }

}

11.4 Практика «Решение манипулятора»
using System;
using NUnit.Framework;

namespace Manipulation
{
    public static class ManipulatorTask
    {        
        public static double[] MoveManipulatorTo(double x, double y, double angle)
        {
            double wristY = y + Math.Sin(Math.PI - angle) * Manipulator.Palm;
            double wristX = x + Math.Cos(Math.PI - angle) * Manipulator.Palm;
            double oToWrist = Math.Sqrt(wristY * wristY + wristX * wristX);
            double elbow = TriangleTask.GetABAngle(Manipulator.UpperArm, Manipulator.Forearm, oToWrist);            
            double shoulder = TriangleTask.GetABAngle(Manipulator.UpperArm, oToWrist, Manipulator.Forearm) + Math.Atan2(wristY, wristX);
            double wrist = 3 * Math.PI - shoulder - elbow - angle - Math.PI;

            if (double.IsNaN(shoulder) || double.IsNaN(elbow) || double.IsNaN(wrist))
                return new[] { double.NaN, double.NaN, double.NaN };
            else
                return new[] { shoulder, elbow, wrist };
        }
    }

    [TestFixture]
    public class ManipulatorTask_Tests
    {
        [Test]
        public void TestMoveManipulatorTo()
        {
            //Assert.Fail("Write real tests here!");
        }
    }
}

12. Основы ООП

12.1 Создание классов
public class City
{
 public string Name;
 public GeoLocation Location;
 
}

public class GeoLocation
{
 public double Latitude;
 public double Longitude;
}

12.2 Сокращенный синтаксис
public static MenuItem[] GenerateMenu()
{
    return new[] { new MenuItem() {Caption = "File", HotKey = "F", Items = new MenuItem[] {
                new MenuItem() {Caption = "New", HotKey = "N", Items = null},
                new MenuItem() {Caption = "Save", HotKey = "S", Items = null}
                } },
                new MenuItem() {Caption = "Edit", HotKey = "E", Items = new MenuItem[] {
                    new MenuItem() {Caption = "Copy", HotKey = "C", Items = null},
                    new MenuItem() {Caption = "Paste", HotKey = "V", Items = null},
                }}
            };
}

12.3 Создание методов расширения
public static class StringExtensions
{
    public static int ToInt(this string s) => int.Parse(s);        
}

12.4 Список директорий
public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
{
    List<DirectoryInfo> res = new List<DirectoryInfo>();
 
 foreach (FileInfo file in files)    
        if((file.Extension == ".mp3" || file.Extension == ".wav") && !res.Any(x => x.FullName == file.DirectoryName))
         res.Add(file.Directory);    
    
    return res;
}

12.5 Рефакторинг статического класса
public class SuperBeautyImageFilter
{
    public string ImageName;
    public double GaussianParameter;
    public void Run()
    {
        Console.WriteLine("Processing {0} with parameter {1}", 
            ImageName, 
            GaussianParameter.ToString(CultureInfo.InvariantCulture));
    }
}

12.6 Практика «Вектор»
using System;

namespace GeometryTasks
{
    public class Geometry
    {
        public static double GetLength(Vector v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector() { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
    }

    public class Vector
    {
        public double X;
        public double Y;
    }
}

12.7 Практика «Отрезок»
using System;

namespace GeometryTasks
{
    public class Geometry
    {
        public static double GetLength(Vector v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static double GetLength(Segment s)
        {
            return Math.Sqrt(Math.Pow(s.End.X - s.Begin.X, 2) + Math.Pow(s.End.Y - s.Begin.Y, 2));
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector() { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static bool IsVectorInSegment(Vector v, Segment seg)
        {
            if (((v.X == seg.Begin.X) || (v.X == seg.End.X)) && ((v.Y == seg.End.Y) || (v.Y == seg.Begin.Y)))            
                return true;            
            
            return ((v.X - seg.Begin.X) * (v.X - seg.End.X) <= 0) && ((v.Y - seg.Begin.Y) * (v.Y - seg.End.Y) < 0);
        }
    }

    public class Vector
    {
        public double X;
        public double Y;
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;
    }
}

12.8 Практика «Нестатические методы»
using System;

namespace GeometryTasks
{
    public class Geometry
    {
        public static double GetLength(Vector v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static double GetLength(Segment s)
        {
            return Math.Sqrt(Math.Pow(s.End.X - s.Begin.X, 2) + Math.Pow(s.End.Y - s.Begin.Y, 2));
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector() { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static bool IsVectorInSegment(Vector v, Segment seg)
        {            
            if (((v.X == seg.Begin.X) || (v.X == seg.End.X)) && ((v.Y == seg.End.Y) || (v.Y == seg.Begin.Y)))            
                return true;            
            
            return ((v.X - seg.Begin.X) * (v.X - seg.End.X) <= 0) && ((v.Y - seg.Begin.Y) * (v.Y - seg.End.Y) < 0);            
        }
    }

    public class Vector
    {
        public double X;
        public double Y;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector v)
        {
            return Geometry.Add(this, v);
        }

        public bool Belongs(Segment s)
        {
            return Geometry.IsVectorInSegment(this, s);
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector v)
        {
            return Geometry.IsVectorInSegment(v, this);
        }
    }
}

12.9 Практика «256 оттенков серого»
using System.Collections.Generic;
using GeometryTasks;
using System.Drawing;

namespace GeometryPainting
{
    public static class SegmentExtensions
    {
        private static Dictionary<Segment, Color> _dic = new Dictionary<Segment, Color>();        

        public static void SetColor(this Segment s, Color color)
        {
            if (_dic.ContainsKey(s))
                _dic[s] = color;
            else
                _dic.Add(s, color);
        }

        public static Color GetColor(this Segment s)
        {
            if (_dic.ContainsKey(s))
                return _dic[s];
            else
                return Color.Black;
        }
    }
}

13. Наследование

13.1 Всем печать! 
public static void Print(params object[] arr)
{
    for(var i=0; i<arr.Length; i++){
        if (i > 0) 
            Console.Write(", ");
        Console.Write(arr[i].ToString());
    }
    Console.WriteLine();
}

13.2 Склейка массивов
static Array Combine(params Array[] arrays)
{
 if (arrays.Length == 0 || arrays == null) return null;
 
 Type type = arrays[0].GetType().GetElementType();
 
 int length = 0; 
 foreach (var array in arrays)
 {
  if (array.GetType().GetElementType() != type) return null;
  
  length += array.Length;
 }
 
 var result = Array.CreateInstance(type, length);
 
 var index = 0;
 foreach (var array in arrays)
  foreach (var elem in array)
   result.SetValue(elem, index++);
 
 return result;
}

13.3 Снова среднее трех
static object MiddleOfThree(object a, object b, object c)
{
 var element1 = (IComparable)a;
 var element2 = (IComparable)b;
 var element3 = (IComparable)c;  

 if (element1.CompareTo(element2) > 0)
 {
  if (element1.CompareTo(element3) < 0 ) return element1;  
  if (element3.CompareTo(element2) > 0 ) return element3;
 }
 else if (element2.CompareTo(element3) < 0 ) return element2;
 else if (element1.CompareTo(element3) > 0 ) return element1;
 
 return element3;  
}

13.4 Поиск минимума
public static object Min(Array array)
{
 var min = (IComparable)array.GetValue(0);

 for (int i = 0; i < array.Length; i++)
  if (min.CompareTo(array.GetValue(i)) > 0)
   min = (IComparable)array.GetValue(i); 

 return min;
}

13.5 Сравнение книг
class Book : IComparable
{
    public string Title;
    public int Theme;
 
 public int CompareTo(object obj)
 {
  var book = (Book)obj;
  
  int themeCompare = Theme.CompareTo(book.Theme);  
  if (themeCompare != 0) return themeCompare;
  
  return Title.CompareTo(book.Title);
 }
}    

13.6 По часовой стрелке
public class ClockwiseComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Point p1 = (Point)x;
        Point p2 = (Point)y;
        return Math.Atan2(-p1.Y, -p1.X).CompareTo(Math.Atan2(-p2.Y, -p2.X));
    }
}

13.7 Метод ToString
public class Triangle
{
 public Point A;
 public Point B;
 public Point C;
 
 public override string ToString()
 {
  return string.Format("({0}) ({1}) ({2})", A, B, C);
 }
}

13.8 Практика «Земля и Диггер»
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Terrain.png";
        }
    }

    public class Player : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            Keys key = Game.KeyPressed;

            switch (key)
            {
                case Keys.Down:
                    if (y < Game.MapHeight - 1) return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
                    break;

                case Keys.Up:
                    if (y >=1 ) return new CreatureCommand { DeltaX = 0, DeltaY = -1 };
                    break;

                case Keys.Right:
                    if (x < Game.MapWidth - 1) return new CreatureCommand { DeltaX = 1, DeltaY = 0 };
                    break;

                case Keys.Left:
                    if (x >= 1) return new CreatureCommand { DeltaX = -1, DeltaY = 0 };
                    break;
            }

            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }
}

13.9 Практика «Мешки и Золото»
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Terrain.png";
        }
    }

    public class Player : ICreature
    {
        private bool CanMove(int x, int y)
        {
            return Game.Map[x, y] == null || Game.Map[x, y].GetImageFileName() != "Sack.png";
        }

        public CreatureCommand Act(int x, int y)
        {
            Keys key = Game.KeyPressed;

            switch (key)
            {
                case Keys.Down:
                    if (y < Game.MapHeight - 1 && CanMove(x, y+1)) return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
                    break;

                case Keys.Up:
                    if (y >= 1 && CanMove(x, y - 1)) return new CreatureCommand { DeltaX = 0, DeltaY = -1 };
                    break;

                case Keys.Right:
                    if (x < Game.MapWidth - 1 && CanMove(x+1, y)) return new CreatureCommand { DeltaX = 1, DeltaY = 0 };
                    break;

                case Keys.Left:
                    if (x >= 1 && CanMove(x-1, y)) return new CreatureCommand { DeltaX = -1, DeltaY = 0 };
                    break;
            }

            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject.GetImageFileName() == "Gold.png")
                Game.Scores += 10;

            return conflictedObject.GetImageFileName() == "Sack.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }

    public class Sack : ICreature
    {
        private int _falling = 0;

        public CreatureCommand Act(int x, int y)
        {
            int below = Game.MapHeight - 1;

            while (y != below)
            {
                if (Game.Map[x, y + 1] == null || (Game.Map[x, y + 1].GetImageFileName() == "Digger.png" && _falling > 0))
                {
                    _falling++;
                    return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
                }
                else if (_falling > 1)
                    return new CreatureCommand { DeltaX = 0, DeltaY = 0, TransformTo = new Gold() };
                else
                {
                    _falling = 0;
                    return new CreatureCommand { };
                }
            }

            if (_falling > 1)
                return new CreatureCommand { DeltaX = 0, DeltaY = 0, TransformTo = new Gold() };
            else
            {
                _falling = 0;
                return new CreatureCommand { };
            }
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }        

        public int GetDrawingPriority()
        {
            return 2;
        }

        public string GetImageFileName()
        {
            return "Sack.png";
        }
    }

    public class Gold : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public string GetImageFileName()
        {
            return "Gold.png";
        }
    }
}

13.10 Практика «Монстры»
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }

        public string GetImageFileName()
        {
            return "Terrain.png";
        }
    }

    public class Player : ICreature
    {
        public static int xPos = 0;
        public static int yPos = 0;

        private bool CanMove(int x, int y)
        {
            return Game.Map[x, y] == null || Game.Map[x, y].GetImageFileName() != "Sack.png";
        }

        public CreatureCommand Act(int x, int y)
        {
            xPos = x;
            yPos = y;

            Keys key = Game.KeyPressed;

            switch (key)
            {
                case Keys.Down:
                    if (y < Game.MapHeight - 1 && CanMove(x, y+1)) return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
                    break;

                case Keys.Up:
                    if (y >= 1 && CanMove(x, y - 1)) return new CreatureCommand { DeltaX = 0, DeltaY = -1 };
                    break;

                case Keys.Right:
                    if (x < Game.MapWidth - 1 && CanMove(x+1, y)) return new CreatureCommand { DeltaX = 1, DeltaY = 0 };
                    break;

                case Keys.Left:
                    if (x >= 1 && CanMove(x-1, y)) return new CreatureCommand { DeltaX = -1, DeltaY = 0 };
                    break;
            }

            return new CreatureCommand { DeltaX = 0, DeltaY = 0 };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject.GetImageFileName() == "Gold.png")
                Game.Scores += 10;

            return conflictedObject.GetImageFileName() == "Sack.png" || conflictedObject.GetImageFileName() == "Monster.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }
    }

    public class Sack : ICreature
    {
        private int _falling = 0;

        public CreatureCommand Act(int x, int y)
        {
            int below = Game.MapHeight - 1;

            while (y != below)
            {
                if (Game.Map[x, y + 1] == null || ((Game.Map[x, y + 1].GetImageFileName() == "Digger.png" || Game.Map[x, y + 1].GetImageFileName() == "Monster.png") && _falling > 0))
                {
                    _falling++;
                    return new CreatureCommand { DeltaX = 0, DeltaY = 1 };
                }
                else if (_falling > 1)
                    return new CreatureCommand { DeltaX = 0, DeltaY = 0, TransformTo = new Gold() };
                else
                {
                    _falling = 0;
                    return new CreatureCommand { };
                }
            }

            if (_falling > 1)
                return new CreatureCommand { DeltaX = 0, DeltaY = 0, TransformTo = new Gold() };
            else
            {
                _falling = 0;
                return new CreatureCommand { };
            }
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return false;
        }        

        public int GetDrawingPriority()
        {
            return 2;
        }

        public string GetImageFileName()
        {
            return "Sack.png";
        }
    }

    public class Gold : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand { };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 3;
        }

        public string GetImageFileName()
        {
            return "Gold.png";
        }
    }

    public class Monster : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            int xTo = 0;
            int yTo = 0;
            
            if (FindPlayer())
            {
                if (Player.xPos == x)
                {
                    if (Player.yPos < y) yTo = -1;
                    else if (Player.yPos > y) yTo = 1;
                }
                else if (Player.yPos == y)                
                {
                    if (Player.xPos < x) xTo = -1;
                    else if (Player.xPos > x) xTo = 1;
                }
                else
                {
                    if (Player.xPos < x) xTo = -1;
                    else if (Player.xPos > x) xTo = 1;
                }                
            }
            else
                return new CreatureCommand() { DeltaX = 0, DeltaY = 0 };

            if (!(x + xTo >= 0 && x + xTo < Game.MapWidth && y + yTo >= 0 && y + yTo < Game.MapHeight))
                return new CreatureCommand() { DeltaX = 0, DeltaY = 0 };

            var map = Game.Map[x + xTo, y + yTo];
            if (map != null && (map.ToString() == "Digger.Terrain" || map.ToString() == "Digger.Sack" || map.ToString() == "Digger.Monster"))
                    return new CreatureCommand() { DeltaX = 0, DeltaY = 0 };

            return new CreatureCommand() { DeltaX = xTo, DeltaY = yTo };
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            string fuck = conflictedObject.GetImageFileName();
            return fuck == "Sack.png" || fuck == "Monster.png";
        }

        public int GetDrawingPriority()
        {            
            return 0;
        }

        public string GetImageFileName()
        {
            return "Monster.png";
        }        

        static private bool FindPlayer()
        {
            for (int i = 0; i < Game.MapWidth; i++)
            {
                for (int j = 0; j < Game.MapHeight; j++)
                {                    
                    if (Game.Map[i, j] != null && Game.Map[i, j].GetImageFileName() == "Digger.png")
                    {
                        Player.xPos = i;
                        Player.yPos = j;
                        return true;                        
                    }
                }
            }

            return false;
        }
    }
}

14. Целостность данных

14.1 Не откладывать ошибки
public class Student
{

    private string name;
    public string Name { 
        get { return name; } 
        set 
  { 
   if (value == null)
    throw new ArgumentException();
   
   name = value; 
  } 
    }
}

14.2 Свойство вместо поля
public class Book
{
    public string Title { get; set; }
}

14.3 Вектор
public class Vector
{
    public double X;
    public double Y;
    public double Length => Math.Sqrt(X*X + Y*Y);

 public Vector(double x, double y)
 {
  X = x;
  Y = y;
 }

    public override string ToString()
    {
        return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
    }
}

14.4 Дробь
public class Ratio
{
    public Ratio(int num, int den)
    {
  if (den <= 0)
   throw new ArgumentException();
  
        Numerator = num;
  Denominator = den;
  Value = (double)Numerator / (double)Denominator;
    }

    public readonly int Numerator; //числитель
    public readonly int Denominator; //знаменатель
    public readonly double Value; //значение дроби Numerator / Denominator
}

14.5 Практика «Readonly Vector»
namespace ReadOnlyVectorTask 
{ 
 public class ReadOnlyVector 
 { 
  public readonly double X; 
  public readonly double Y; 
  
  public ReadOnlyVector(double x, double y) 
  { 
   X = x; 
   Y = y; 
  } 
  
  public ReadOnlyVector Add(ReadOnlyVector vector) 
  { 
   return new ReadOnlyVector(X+vector.X,Y+vector.Y); 
  } 
  
  public ReadOnlyVector WithX(double x) 
  { 
   return new ReadOnlyVector(x, Y); 
  } 
  
  public ReadOnlyVector WithY(double y) 
  { 
   return new ReadOnlyVector(X, y); 
  } 
 } 
}

14.6 Практика «Счет из отеля»
using System;

namespace HotelAccounting
{
    //создайте класс AccountingModel здесь
    public class AccountingModel : ModelBase
    {
        private double price;
        private int nightsCount;
        private double discount;
        private double total;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0) throw new ArgumentException();

                price = value;

                Notify(nameof(Price));
                Notify(nameof(Total));
            }
        }

        public int NightsCount
        {
            get
            {
                return nightsCount;
            }
            set
            {
                if (value <= 0) throw new ArgumentException();

                nightsCount = value;

                Notify(nameof(NightsCount));
                Notify(nameof(Total));
            }
        }

        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {                
                discount = value;

                total = price * nightsCount * (1 - discount / 100);

                if (total < 0) throw new ArgumentException();

                Notify(nameof(Discount));
                Notify(nameof(Total));
            }
        }

        public double Total
        {
            get
            {
                return price * nightsCount * (1 - discount / 100);
            }
            set
            {
                if (value <= 0) throw new ArgumentException();

                total = value;

                discount = 100 * (1 - total / (price * nightsCount));

                Notify(nameof(Total));
                Notify(nameof(Discount));
            }
        }
    }
}

14.7 Практика «Карманный гугл»
using System.Collections.Generic;
using System.Linq;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        private readonly char[] charsForSplit = { ' ', '.', ',', '!', '?', ':', '-', '\r', '\n' };
        
        private readonly Dictionary<int, Dictionary<string, List<int>>> wordsAndPosByIndex = new Dictionary<int, Dictionary<string, List<int>>>();
        private readonly Dictionary<string, HashSet<int>> indexesByWord = new Dictionary<string, HashSet<int>>();        

        public void Add(int id, string documentText)
        {
            string[] words = documentText.Split(charsForSplit);
            wordsAndPosByIndex.Add(id, new Dictionary<string, List<int>>());

            int currentPos = 0;
            foreach (string word in words)
            {
                if (!indexesByWord.ContainsKey(word))
                    indexesByWord[word] = new HashSet<int>();

                if (!indexesByWord[word].Contains(id))
                    indexesByWord[word].Add(id);


                if (!wordsAndPosByIndex[id].ContainsKey(word))
                    wordsAndPosByIndex[id].Add(word, new List<int>());

                wordsAndPosByIndex[id][word].Add(currentPos);
                currentPos += word.Length + 1;
            }
        }

        public List<int> GetIds(string word)
        {
            return indexesByWord.ContainsKey(word) ? indexesByWord[word].ToList() : new List<int>();
        }

        public List<int> GetPositions(int id, string word)
        {
            List<int> positions = new List<int>();
            
            if (wordsAndPosByIndex.ContainsKey(id) && wordsAndPosByIndex[id].ContainsKey(word))
                positions = wordsAndPosByIndex[id][word];

            return positions;            
        }

        public void Remove(int id)
        {
            string[] words = wordsAndPosByIndex[id].Keys.ToArray();

            foreach (var word in words)            
                indexesByWord[word].Remove(id);
            
            wordsAndPosByIndex.Remove(id);
        }
    }
}

15. Структуры

15.1 Применение ref 
public static void WriteAllNumbersFromText(string text)
{
 int pos = 0;
 
    while (true)
    {
        SkipSpaces(text, ref pos);
        var num = ReadNumber(text, ref pos);
        if (num == "") break;
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

15.2 Практика «Генератор структур»
using System;
using System.Text;

namespace Profiling
{
    class Generator
    {
        public static string GenerateDeclarations()
        {
            StringBuilder sb = new StringBuilder();

            foreach (int count in Constants.FieldCounts)
            {
                sb.Append(GenerateString("struct S", count));
                sb.Append(GenerateString("class C", count));
            }

            return sb.ToString();
        }

        public static string GenerateArrayRunner()
        {
            StringBuilder mainSb = new StringBuilder();
            StringBuilder callSb = new StringBuilder();

            mainSb.Append("public class ArrayRunner : IRunner\n{\n");
            callSb.Append("public void Call(bool isClass, int size, int count)\n{\n");

            foreach (int count in Constants.FieldCounts)
            {
                mainSb.Append(GenerateFuckingShit("C", count));
                mainSb.Append(GenerateFuckingShit("S", count));

                callSb.Append(GeneratePiecesOfShit("C", count));
                callSb.Append(GeneratePiecesOfShit("S", count));
            }

            mainSb.Append(callSb);
            mainSb.Append("throw new ArgumentException();\n}\n}");

            return mainSb.ToString();
        }

        public static string GenerateCallRunner()
        {
            throw new NotImplementedException();
        }


        private static string GenerateString(string s, int count)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(string.Format("{0}{1}\n{{\n", s, count));

            for (int i = 0; i < count; i++)
                sb.Append(string.Format("byte Value{0}; ", i));            

            sb.Append("}\n");

            return sb.ToString();
        }

        private static string GenerateFuckingShit(string text, int count)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("void P{0}{1}()\n{{\nvar array = new {0}{1}[Constants.ArraySize];\n", text, count));

            if (text == "C")
                sb.Append(string.Format("for (int i = 0; i < Constants.ArraySize; i++) array[i] = new C{0}();\n", count));

            sb.Append("}\n");

            return sb.ToString();
        }

        private static string GeneratePiecesOfShit(string text, int count)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("if (" + (text == "S" ? "!" : "") + string.Format("isClass && size == {0})\n{{\nfor (int i = 0; i < count; i++) P{1}{0}();\nreturn;\n}}\n", count, text));

            return sb.ToString();
        }
    }
}

15.3 Практика «Профайлер» 
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Profiling
{
 public class ProfilerTask : IProfiler
 {
  public List<ExperimentResult> Measure(IRunner runner, int repetitionsCount)
  {
            List<ExperimentResult> result = new List<ExperimentResult>();
            Stopwatch watch;

            foreach (int count in Constants.FieldCounts)
            {
                runner.Call(false, count, 1);
                watch = new Stopwatch();
                watch.Start();
                runner.Call(false, count, repetitionsCount);
                watch.Stop();

                double timeStruct = (double)watch.ElapsedMilliseconds / repetitionsCount;

                runner.Call(true, count, 1);
                watch = new Stopwatch();
                watch.Start();
                runner.Call(true, count, repetitionsCount);
                watch.Stop();

                double timeClass = (double)watch.ElapsedMilliseconds / repetitionsCount;

                result.Add(new ExperimentResult(count, timeClass, timeStruct));
            }

            return result;
        }        
    }
}

15.4 Практика «График»
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using ZedGraph;
using System.Windows.Forms.DataVisualization.Charting;

namespace Profiling
{
 class ChartBuilder : IChartBuilder
 {
        public Control Build(List<ExperimentResult> results)
        {
            Chart chart = new Chart();

            for (int i = 0; i < results.Count; i++)
            {
                chart.Series[1].Points.AddXY(i, results[i].StructResult);
                chart.Series[0].Points.AddXY(i, results[i].ClassResult);
            }

            return chart;
        }
    }
}

15.5 Практика «Второй эксперимент»
using System;
using System.Text;

namespace Profiling
{
    class Generator
    {
        public static string GenerateDeclarations()
        {
            StringBuilder sb = new StringBuilder();

            foreach (int count in Constants.FieldCounts)
            {
                sb.Append(GenerateString("struct S", count));
                sb.Append(GenerateString("class C", count));
            }

            return sb.ToString();
        }

        public static string GenerateArrayRunner()
        {
            StringBuilder mainSb = new StringBuilder();
            StringBuilder callSb = new StringBuilder();

            mainSb.Append("public class ArrayRunner : IRunner\n{\n");
            callSb.Append("public void Call(bool isClass, int size, int count)\n{\n");

            foreach (int count in Constants.FieldCounts)
            {
                mainSb.Append(GenerateFuckingShit("C", count));
                mainSb.Append(GenerateFuckingShit("S", count));

                callSb.Append(GeneratePiecesOfShit("C", count));
                callSb.Append(GeneratePiecesOfShit("S", count));
            }

            mainSb.Append(callSb);
            mainSb.Append("throw new ArgumentException();\n}\n}");

            return mainSb.ToString();
        }

        


        private static string GenerateString(string s, int count)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(string.Format("{0}{1}\n{{\n", s, count));

            for (int i = 0; i < count; i++)
                sb.Append(string.Format("byte Value{0}; ", i));            

            sb.Append("}\n");

            return sb.ToString();
        }

        private static string GenerateFuckingShit(string text, int count)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("void P{0}{1}()\n{{\nvar array = new {0}{1}[Constants.ArraySize];\n", text, count));

            if (text == "C")
                sb.Append(string.Format("for (int i = 0; i < Constants.ArraySize; i++) array[i] = new C{0}();\n", count));

            sb.Append("}\n");

            return sb.ToString();
        }

        private static string GeneratePiecesOfShit(string text, int count)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("if (" + (text == "S" ? "!" : "") + string.Format("isClass && size == {0})\n{{\nfor (int i = 0; i < count; i++) P{1}{0}();\nreturn;\n}}\n", count, text));

            return sb.ToString();
        }

        private static string GenerateMoreShittyShit(string text, int count)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nif (" + (text == "S" ? "!" : "") + string.Format("isClass && size == {0})\n{{\nvar o = new {1}{0}(); for (int i = 0; i < count; i++) P{1}{0}(o);\nreturn;\n}}\n", count, text));

            return sb.ToString();
        }

        public static string GenerateCallRunner()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\n\npublic class CallRunner  : IRunner{");

            foreach (int count in Constants.FieldCounts)
            {
                sb.AppendFormat("void P{0}({0} o){1}{2}", "C" + count, "{", "}");
                sb.AppendFormat("void P{0}({0} o){1}{2}", "S" + count, "{", "}");
            }

            sb.Append("public void Call(bool isClass, int size, int count){");

            foreach (int count in Constants.FieldCounts)                
            {
                sb.Append(GenerateMoreShittyShit("C", count));
                sb.Append(GenerateMoreShittyShit("S", count));
            }

            sb.Append("throw new ArgumentException(); }}");
            return sb.ToString();
        }
    }
}