using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Lots_of_Test_cases
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.TestAsciiValue32();
            this.UIMap.TestAsciiValue33();
            this.UIMap.TestAsciiValue34();
            this.UIMap.TestAsciiValue35();
            this.UIMap.TestAsciiValue36();
            this.UIMap.TestAsciiValue37();
            this.UIMap.TestAsciiValue38();
            this.UIMap.TestAsciiValue39();
            this.UIMap.TestAsciiValue40();
            this.UIMap.TestAsciiValue41();
            this.UIMap.TestAsciiValue42();
            this.UIMap.TestAsciiValue43();
            this.UIMap.TestAsciiValue44();
            this.UIMap.TestAsciiValue45();
            this.UIMap.TestAsciiValue46();
            this.UIMap.TestAsciiValue47();
            this.UIMap.TestAsciiValue48();
            this.UIMap.TestAsciiValue49();
            this.UIMap.TestAsciiValue50();
            this.UIMap.TestAsciiValue51();
            this.UIMap.TestAsciiValue52();
            this.UIMap.TestAsciiValue53();
            this.UIMap.TestAsciiValue54();
            this.UIMap.TestAsciiValue55();
            this.UIMap.TestAsciiValue56();
            this.UIMap.TestAsciiValue57();
            this.UIMap.TestAsciiValue58();
            this.UIMap.TestAsciiValue59();
            this.UIMap.TestAsciiValue60();
            this.UIMap.TestAsciiValue61();
            this.UIMap.TestAsciiValue62();
            this.UIMap.TestAsciiValue63();
            this.UIMap.TestAsciiValue64();
            this.UIMap.TestAsciiValue65();
            this.UIMap.TestAsciiValue66();
            this.UIMap.TestAsciiValue67();
            this.UIMap.TestAsciiValue68();
            this.UIMap.TestAsciiValue69();
            this.UIMap.TestAsciiValue70();
            this.UIMap.TestAsciiValue71();
            this.UIMap.TestAsciiValue72();
            this.UIMap.TestAsciiValue73();
            this.UIMap.TestAsciiValue74();
            this.UIMap.TestAsciiValue75();
            this.UIMap.TestAsciiValue76();
            this.UIMap.TestAsciiValue77();
            this.UIMap.TestAsciiValue78();
            this.UIMap.TestAsciiValue79();
            this.UIMap.TestAsciiValue80();
            this.UIMap.TestAsciiValue81();
            this.UIMap.TestAsciiValue82();
            this.UIMap.TestAsciiValue83();
            this.UIMap.TestAsciiValue84();
            this.UIMap.TestAsciiValue85();
            this.UIMap.TestAsciiValue86();
            this.UIMap.TestAsciiValue87();
            this.UIMap.TestAsciiValue88();
            this.UIMap.TestAsciiValue89();
            this.UIMap.TestAsciiValue90();
            this.UIMap.TestAsciiValue91();
            this.UIMap.TestAsciiValue92();
            this.UIMap.TestAsciiValue93();




        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
