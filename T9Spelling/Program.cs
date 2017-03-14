using System.Linq;
using System.Text;
using System.IO;

namespace T9Spelling
{
    public class Program
    {

        // Можно было бы не создавать массив символов и закодировать за один проход цикла, но такое решение показалось мне более элегантным.

        static void Main(string[] args)
        {
            var inputPath = @"..\C-large-practice.in";
            var outputPath = @"..\C-large-practice.out";

            using (var sr = new StreamReader(inputPath))
            using (var sw = new StreamWriter(outputPath, false))
            {
                var n = int.Parse(sr.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    var line = sr.ReadLine();
                    var newLine = Replacer(line);
                    sw.WriteLine($"Case #{i + 1}: {newLine}");
                }
            }
        }

        public static string Replacer(string line)
        {
            string[] c = line.Select(x =>
            {
                switch ((int)x)
                {
                    case 32:
                       return "0";
                    case 97: case 98: case 99:
                       return new string('2', x - 97 + 1);
                    case 100: case 101: case 102:
                       return new string('3', x - 100 + 1);
                    case 103: case 104: case 105:
                       return new string('4', x - 103 + 1);
                    case 106: case 107: case 108:
                       return new string('5', x - 106 + 1);
                    case 109: case 110: case 111:
                       return new string('6', x - 109 + 1);
                    case 112: case 113: case 114: case 115:
                       return new string('7', x - 112 + 1);
                    case 116: case 117: case 118:
                       return new string('8', x - 116 + 1);
                    case 119: case 120: case 121: case 122:
                       return new string('9', x - 119 + 1);
                    default: throw new IOException();
                }
            }).ToArray();

            var sb = new StringBuilder();

            for (int i = 0; i < c.Length - 1; i++)
            {
                sb.Append(c[i]);
                if (c[i][0] == c[i + 1][0])
                    sb.Append(" ");
            }

            sb.Append(c.Last());

            return sb.ToString();
        }
    }
}
