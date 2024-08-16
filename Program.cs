namespace Program
{
    abstract class Father
    {
        public abstract void   hanshu();//申明一个抽象方法

    }
    class Son : Father
    {
        public override void hanshu()
        {
            
        }//子类必须实现父类的抽象方法
    }

    class Program {
    //抽象类不能被实例化
    
    }

}