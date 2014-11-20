namespace ConsoleApplication1
{
    using System;
    namespace Sample
    {
        public class cTest
        {
            static void Main(string[] args)
            {
                aTest o = new aTest();
                o.SampleMethod1();
                o.SampleMethod2();
                o.SampleMethod3();
                o.SampleMethod4();
                o.SampleMethod5();
                o.M();
                o.M1();
                o.M2();

                IT1 i1 = o;
                i1.M();
                i1.M1();

                IT2 i2 = o;
                i2.M();
                i2.M2();

                abTest o1 = new aTest();
                o1.SampleMethod1();
                o1.SampleMethod2();
                o1.SampleMethod3();
                o1.SampleMethod4();

                SealedClass s = new SealedClass();
                Console.WriteLine(s.Count.ToString());

                I1 oClsI1 = new cls();
                Console.WriteLine(oClsI1.i);
                I2 oClsI2 = oClsI1 as I2;
                Console.WriteLine(oClsI2.j);
                Console.ReadLine();

            }
        }

        public interface I1
        {
            int i { get; set; }
        }

        public interface I2
        {
            int j { get; set; }
        }

        public class cls : I1, I2
        {
            private int _i;

            public int i { get { return _i; } set { _i = value; } }
            private int _j;

            public int j { get { return _j; } set { _j = value; } }
            public cls()
            {

            }

        }

        public sealed class SealedClass
        {
            public int Count { set; get; }
            public SealedClass()
            {
                Count = 0;
            }

            public void Increment()
            {
                Count += 1;
                return;
            }

            public void Decrement()
            {
                Count -= 1;
                return;
            }
        }

        public interface IT1
        {
            void M1();
            void M();
        }

        public interface IT2
        {
            void M2();
            void M();
        }

        public abstract class abTest
        {
            public abstract void SampleMethod1();

            public virtual void SampleMethod2()
            {
                Console.WriteLine(this.GetType().ToString() + " abstract abstract");
            }

            public void SampleMethod3()
            {
                Console.WriteLine("My Sample Method 3");
            }

            public virtual void SampleMethod4()
            {
                Console.WriteLine(this.GetType().ToString() + " Virtual Test");
            }
        }

        public class aTest : abTest, IT1, IT2
        {
            void IT1.M()
            {
                Console.WriteLine("ITC1 M");
            }

            void IT1.M1()
            {
                Console.WriteLine("ITC1 M1");
            }

            void IT2.M()
            {
                Console.WriteLine("ITC2 M");
            }

            void IT2.M2()
            {
                Console.WriteLine("ITC2 M2");
            }

            public void M()
            {
                Console.WriteLine("aTest M");
            }

            public void M1()
            {
                Console.WriteLine("M1");
            }

            public void M2()
            {
                Console.WriteLine("M2");
            }

            public override void SampleMethod1()
            {
                Console.WriteLine(this.GetType().ToString() + " aTest SampleMethod1");
            }

            public override void SampleMethod2()
            {
                Console.WriteLine(this.GetType().ToString() + " aTest SampleMethod2");
            }

            public new void SampleMethod4()
            {
                Console.WriteLine(this.GetType().ToString() + " New SampleMethod4");
            }

            public void SampleMethod5()
            {
                Console.WriteLine("SampleMethod5");
            }
        }
    }

    /* Result
    Sample.aTest aTest SampleMethod1
    Sample.aTest aTest SampleMethod2
    My Sample Method 3
    Sample.aTest New SampleMethod4
    SampleMethod5
    aTest M
    M1
    M2
    ITC1 M
    ITC1 M1
    ITC2 M
    ITC2 M2
    Sample.aTest aTest SampleMethod1
    Sample.aTest aTest SampleMethod2
    My Sample Method 3
    Sample.aTest Virtual Test
    0
    */


}
