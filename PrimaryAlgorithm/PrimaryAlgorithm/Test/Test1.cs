using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaryAlgorithm.Test
{
    public delegate void showMessageHandler(string message);

    class Test1{

        public showMessageHandler showMessage;
        public showMessageHandler showMessageB;

        public showMessageHandler showMessageTest;

        public Test1() {
            showMessage += A;
            showMessage += B;
            showMessageTest += showMessage;
        }

        public void Test2(showMessageHandler test) {

        }

        public void ShowDelegate() {
            Delegate[] delegates = showMessage.GetInvocationList();
            foreach (Delegate @deleagate in delegates) {
                ((showMessageHandler)deleagate).Invoke("a");
                showMessageB += ((showMessageHandler)deleagate);
            }
        }

        public void Execute() {
            showMessageB("b");
        }

        public void A(string message) {
            Console.WriteLine("执行A方法,messagg:"+message);
        }

        public void B(string message) {
            Console.WriteLine("执行B方法,messagg:" + message);
        }

        public static void Main(string[] args) {
            Test1 test1 = new Test1();
            //test1.ShowDelegate();
            test1.Execute();
            test1.Test2(test1.A);
        }
    }
}
