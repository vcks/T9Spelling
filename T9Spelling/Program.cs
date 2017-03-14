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
            string[] c = new string[line.Length];

            for (int i = 0; i < line.Length; i++)
                switch ((int)line[i])
                {
                    case 32:
                        c[i] = "0";
                        break;
                    case 97: case 98: case 99:
                        c[i] = new string('2', line[i] - 97 + 1);
                        break;
                    case 100: case 101: case 102:
                        c[i] = new string('3', line[i] - 100 + 1);
                        break;
                    case 103: case 104: case 105:
                        c[i] = new string('4', line[i] - 103 + 1);
                        break;
                    case 106: case 107: case 108:
                        c[i] = new string('5', line[i] - 106 + 1);
                        break;
                    case 109: case 110: case 111:
                        c[i] = new string('6', line[i] - 109 + 1);
                        break;
                    case 112: case 113: case 114: case 115:
                        c[i] = new string('7', line[i] - 112 + 1);
                        break;
                    case 116: case 117: case 118:
                        c[i] = new string('8', line[i] - 116 + 1);
                        break;
                    case 119: case 120: case 121: case 122:
                        c[i] = new string('9', line[i] - 119 + 1);
                        break;
                }

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
