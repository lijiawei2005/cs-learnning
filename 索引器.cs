namespace Suoyinqi
{
    class Person
    {
        public string[] Age = new string[2];

        public string this[int index]
        {
            get { return Age[index]; }
            set { Age[index] = value; }
        }

        
    }




    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person[0] = "";
            person[1] = "";

            Console.WriteLine(person.Age.Length);
        }
    }


}//相当于有了这个索引器，我们就可以像person[0]=1这样写，因为person是Person类实例化的一个对象，而这个对象是有Age这个字符串数组的,没有索引器不可以person[0]=1这样来访问写入的，索引器的get,set就是跟属性一样
