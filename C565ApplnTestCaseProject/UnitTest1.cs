using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C565Appln_Testcases;

namespace C565ApplnTestCaseProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strexpected;
            string actualresult = "Error in push-stack is full";
            int number = -1;
            int topindex = -1;
            int maxlen = -1;
            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            strexpected = obj.push(number, topindex, maxlen);
            Assert.AreEqual(strexpected, actualresult);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string strexpected;
            string actualresult;
            int[] stack_ref = new int[100];
            int number = 2;
            int topindex = -1;
            int maxlen = 99;
            //stack_ref[++topindex] = number;

            //strexpected = stack_ref[++topindex];
            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            strexpected = obj.push(number, topindex, maxlen);
            actualresult = Convert.ToString(++topindex);
            Assert.AreEqual(strexpected, actualresult);


        }
        [TestMethod]
        public void poptestmethod1()
        {
            string strexpected;
            string stractualresult = "Error in push-stack is empty";
            int top_index = -1;
            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            strexpected = obj.pop(top_index);
            Assert.AreEqual(strexpected, stractualresult);

        }

        [TestMethod]
        public void poptestmethod2()
        {
            string strexpected;
            string stractualresult;
            int top_index = 2;
            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            strexpected = obj.pop(top_index);
            stractualresult = Convert.ToString(--top_index);
            Assert.AreEqual(strexpected, stractualresult);

        }
        //Null Reference Exception Handling for an Array
        [TestMethod]
        public void TestNullReference()
        {
            int[] stack_ref = new int[100];

            foreach (var value in stack_ref)
            {
                if (stack_ref != null)
                {
                    Console.WriteLine(value);
                }
            }
        }

        [TestMethod]
        public void TestTopMethod()
        {
            int actualresult = 10;
            int expectedresult;

            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            expectedresult = obj.top();
            Assert.AreEqual(expectedresult, actualresult);


        }
        [TestMethod]
        public void TestboolMethod()
        {
            bool actualresult = true;
            bool expectedresult;
            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            expectedresult = obj.empty();
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestboolMethod2()
        {
            bool actualresult = false;
            bool expectedresult;
            C565Appln_Testcases.Class1 obj = new C565Appln_Testcases.Class1();
            expectedresult = obj.empty();
            Assert.AreNotEqual(expectedresult, actualresult);

        }

    }
}
