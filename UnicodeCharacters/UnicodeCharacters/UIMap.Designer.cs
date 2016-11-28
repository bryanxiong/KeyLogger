﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UnicodeCharacters
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// UnicodeCharacterTest - Use 'UnicodeCharacterTestParams' to pass parameters into this method.
        /// </summary>
        public void UnicodeCharacterTest()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UIUntitledNotepadWindow.UIItemWindow.UIItemEdit;
            #endregion

            // Type 'Hello World!' in text box
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText1.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText2.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText3.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText4.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText5.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText6.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText7.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText8.ToString();
            uIItemEdit.Text = this.UnicodeCharacterTestParams.UIItemEditText9.ToString();
        }
        
        #region Properties
        public virtual UnicodeCharacterTestParams UnicodeCharacterTestParams
        {
            get
            {
                if ((this.mUnicodeCharacterTestParams == null))
                {
                    this.mUnicodeCharacterTestParams = new UnicodeCharacterTestParams();
                }
                return this.mUnicodeCharacterTestParams;
            }
        }
        
        public UIUntitledNotepadWindow UIUntitledNotepadWindow
        {
            get
            {
                if ((this.mUIUntitledNotepadWindow == null))
                {
                    this.mUIUntitledNotepadWindow = new UIUntitledNotepadWindow();
                }
                return this.mUIUntitledNotepadWindow;
            }
        }
        #endregion
        
        #region Fields
        private UnicodeCharacterTestParams mUnicodeCharacterTestParams;
        
        private UIUntitledNotepadWindow mUIUntitledNotepadWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'UnicodeCharacterTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UnicodeCharacterTestParams
    {
        
        #region Fields
        /// <summary>
        /// Type set unicode characters into a text box
        /// </summary>
        public char UIItemEditText = '\u0af9';
        public char UIItemEditText1 = '\u0bfa';
        public char UIItemEditText2 = '\u0cf2';
        public char UIItemEditText3 = '\u0df4';
        public char UIItemEditText4 = '\u0edf';
        public char UIItemEditText5 = '\u0fda';
        public char UIItemEditText6 = '\u09fb';
        public char UIItemEditText7 = '\u08ff';
        public char UIItemEditText8 = '\u07fa';
        public char UIItemEditText9 = '\u06ff';
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIUntitledNotepadWindow : WinWindow
    {
        
        public UIUntitledNotepadWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Untitled - Notepad";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Notepad";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "15";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
}
