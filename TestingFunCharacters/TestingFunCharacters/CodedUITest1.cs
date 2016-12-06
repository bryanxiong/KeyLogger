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


namespace TestingFunCharacters
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
            this.UIMap.TestChar170();
            this.UIMap.TestChar171();
            this.UIMap.TestChar172();
            this.UIMap.TestChar169();
            this.UIMap.TestChar174();
            this.UIMap.TestChar175();
            this.UIMap.TestChar176();
            this.UIMap.TestChar177();
            this.UIMap.TestChar178();
            this.UIMap.TestChar179();
            this.UIMap.TestChar180();
            this.UIMap.TestChar181();
            this.UIMap.TestChar182();
            this.UIMap.TestChar183();
            this.UIMap.TestChar184();
            this.UIMap.TestChar185();
            this.UIMap.TestChar186();
            this.UIMap.TestChar187();
            this.UIMap.TestChar188();
            this.UIMap.TestChar189();
            this.UIMap.TestChar190();
            this.UIMap.TestChar191();
            this.UIMap.TestChar192();
            this.UIMap.TestChar193();
            this.UIMap.TestChar194();
            this.UIMap.TestChar195();
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
