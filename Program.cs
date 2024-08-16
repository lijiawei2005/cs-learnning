using System.Text;

namespace StringBuderMinMIng
{
    class Program
    {
        static void Main(string[] args) {
            //修改字符串不创建新的对象，需要频繁修改和拼接的字符串可以使用它，来提升性能
            StringBuilder sb = new StringBuilder("afef");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);

            Console.WriteLine(sb.Capacity);
            //增加
            sb.Append("21g");
            sb.AppendFormat("{0}" ,12);
            //删除
            sb.Remove(1,2);
            Console.WriteLine(sb.ToString());
            //改
            sb[1] = 'w';//如果这样写 string s="fa";s[0]='e';这样写是错误示范
            //替换
            sb.Replace('1','t'); Console.WriteLine(sb);
            if (sb.Equals("123"))
            {
                Console.WriteLine("两者相等");
            }
        }
    }
}