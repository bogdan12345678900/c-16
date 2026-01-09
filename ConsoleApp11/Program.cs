// static class IntExtensions
// {
//     public static bool IsFibonacci(this int number)
//     {
//         if (number < 0) return false;
//
//         int a = 5 * number * number + 4;
//         int b = 5 * number * number - 4;
//
//         return IsPerfectSquare(a) || IsPerfectSquare(b);
//     }
//
//     private static bool IsPerfectSquare(int x)
//     {
//         int s = (int)Math.Sqrt(x);
//         return s * s == x;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(8.IsFibonacci()); // True
//         Console.WriteLine(10.IsFibonacci()); // False
//         Console.WriteLine(21.IsFibonacci()); // True
//     }
// }


// static class StringExtensions
// {
//     public static int WordCount(this string text)
//     {
//         if (string.IsNullOrWhiteSpace(text))
//             return 0;
//
//         return text.Split(
//             new char[] { ' ', '\t', '\n' },
//             StringSplitOptions.RemoveEmptyEntries
//         ).Length;
//     }
// }
//
//
// class Program
// {
//     static void Main()
//     {
//         string s = "C# extension methods are useful";
//         Console.WriteLine(s.WordCount());
//     }
// }


// static class StringLastWordExtension
// {
//     public static int LastWordLength(this string text)
//     {
//         if (string.IsNullOrWhiteSpace(text))
//             return 0;
//
//         string[] words = text.Split(
//             new char[] { ' ', '\t', '\n' },
//             StringSplitOptions.RemoveEmptyEntries
//         );
//
//         return words[^1].Length;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         string s2 = "Hello world from CSharp";
//         Console.WriteLine(s2.LastWordLength());
//     }
// }


using System.Collections.Generic;

// static class BracketExtensions
// {
//     public static bool IsValidBrackets(this string text)
//     {
//         Stack<char> stack = new Stack<char>();
//
//         foreach (char c in text)
//         {
//             if (c == '(' || c == '{' || c == '[')
//             {
//                 stack.Push(c);
//             }
//             else if (c == ')' || c == '}' || c == ']')
//             {
//                 if (stack.Count == 0)
//                     return false;
//
//                 char open = stack.Pop();
//
//                 if (!IsMatching(open, c))
//                     return false;
//             }
//         }
//
//         return stack.Count == 0;
//     }
//
//     private static bool IsMatching(char open, char close)
//     {
//         return (open == '(' && close == ')') ||
//                (open == '{' && close == '}') ||
//                (open == '[' && close == ']');
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("()[]{}".IsValidBrackets());
//         Console.WriteLine("(())".IsValidBrackets());
//         Console.WriteLine("([)]".IsValidBrackets());
//         Console.WriteLine("{[()]}".IsValidBrackets());
//         Console.WriteLine("{[(])}".IsValidBrackets());
//
//     }
// }

// static class ArrayIntExtensions
// {
//     public static int[] Filter(this int[] source, Func<int, bool> predicate)
//     {
//         if (source == null) throw new ArgumentNullException(nameof(source));
//         if (predicate == null) throw new ArgumentNullException(nameof(predicate));
//         int count = 0;
//         for (int i = 0; i < source.Length; i++)
//             if (predicate(source[i]))
//                 count++;
//         int[] result = new int[count];
//         int index = 0;
//         for (int i = 0; i < source.Length; i++)
//         {
//             if (predicate(source[i]))
//             {
//                 result[index] = source[i];
//                 index++;
//             }
//         }
//
//         return result;
//     }
//
//     public static int[] Filter(this int[] source, Predicate<int> predicate)
//     {
//         if (predicate == null) throw new ArgumentNullException(nameof(predicate));
//         return source.Filter(new Func<int, bool>(predicate));
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         int[] nums = { 1, 2, 3, 4, 5, 6 };
//
//         int[] evens = nums.Filter(x => x % 2 == 0);
//         int[] odds  = nums.Filter(x => x % 2 != 0);
//
//         Console.WriteLine(string.Join(", ", evens));
//         Console.WriteLine(string.Join(", ", odds));
//     }
// }


// static class IntExtensions
// {
//     // 1
//     public static bool IsOdd(this int number)
//     {
//         return number % 2 != 0;
//     }
//
//     // 2
//     public static bool IsEven(this int number)
//     {
//         return number % 2 == 0;
//     }
//
//     // 3
//     public static bool IsPrime(this int number)
//     {
//         if (number < 2)
//             return false;
//
//         for (int i = 2; i * i <= number; i++)
//         {
//             if (number % i == 0)
//                 return false;
//         }
//
//         return true;
//     }
// }
//
//
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(5.IsOdd());
//         Console.WriteLine(8.IsOdd());
//
//         Console.WriteLine(10.IsEven());
//         Console.WriteLine(7.IsEven());
//         
//         Console.WriteLine(7.IsPrime());
//         Console.WriteLine(9.IsPrime());
//     }
// }

// static class StringExtensions
// {
//     // 4
//     public static int CountVowels(this string text)
//     {
//         if (string.IsNullOrEmpty(text))
//             return 0;
//
//         int count = 0;
//         string vowels = "aeiouAEIOUаеёиоуыэюяАЕЁИОУЫЭЮЯ";
//
//         for (int i = 0; i < text.Length; i++)
//         {
//             if (vowels.IndexOf(text[i]) >= 0)
//                 count++;
//         }
//
//         return count;
//     }
//
//     // 5
//     public static int CountConsonants(this string text)
//     {
//         if (string.IsNullOrEmpty(text))
//             return 0;
//
//         int count = 0;
//         string vowels = "aeiouAEIOUаеёиоуыэюяАЕЁИОУЫЭЮЯ";
//
//         for (int i = 0; i < text.Length; i++)
//         {
//             char c = text[i];
//
//             if (char.IsLetter(c) && vowels.IndexOf(c) < 0)
//                 count++;
//         }
//
//         return count;
//     }
// }
//
// class Program 
// {
//     static void Main()
//     {
//         string s = "Hello Привет";
//
//         Console.WriteLine(s.CountVowels());
//         Console.WriteLine(s.CountConsonants());
//     }
// }