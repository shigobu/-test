using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 元年テスト
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1989, 8, 18);
            var cal = new JapaneseCalendar();
            var jaJP = new CultureInfo("ja-JP", false);
            jaJP.DateTimeFormat.Calendar = cal;
            Console.WriteLine(date.ToString("ggy年MM月dd日", jaJP));
            Console.WriteLine($"{date:ggy年MM月d日}");
            Console.WriteLine(date.ToString("ggy'年'MM月dd日", jaJP));
            Console.WriteLine($"{date:ggy'年'MM月d日}");
            Console.Read();
        }
    }
}
