using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using mshtml;

namespace PCVGSTOPS4VGS
{
    public partial class Form1 : Form
    {
        public globalKeyboardHook ghk;

        #region Speech
        public SpeechRecognizer sr;
        public Choices          possible_VGS_inputtable_chars;
        public GrammarBuilder   gb;
        public Grammar          g;
        #endregion
        #region WebBrowser
        public bool once = false;
        public bool? dontFireTwice = null;
        #endregion
        public Form1()
        {
            Application.ApplicationExit += Application_ApplicationExit;
            VGS_Commands.Initialize();
//ENABLING SPEECH
#if false
            #region important - Speech
#if true//WE DETECT THE VGS COMMANDS LETTER BY LETTER THEN RECOMPOSE THEM, SLOW BUT ERROR PROBABILITY REALLY LOW
            sr                            = new SpeechRecognizer();
            possible_VGS_inputtable_chars = new Choices(VGS_Commands.ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands_ToString.ToArray());
            gb                            = new GrammarBuilder(possible_VGS_inputtable_chars);
            g                             = new Grammar(gb);
#endif
#if false//WE DETECT THE VGS COMMANDS AS A WHOLE WORD, FAST BUT ERROR PROBABILITY REALLY HIGH
            sr = new SpeechRecognizer();
            possible_VGS_inputtable_chars = new Choices(VGS_Commands.ListOfVgsCommands.ToArray());
            gb = new GrammarBuilder(possible_VGS_inputtable_chars);
            g = new Grammar(gb);
#endif
            sr.LoadGrammar(g);
            sr.SpeechRecognized += Sr_SpeechRecognized;
            #endregion
#endif
            InitializeComponent();
//ENABLING GLOBAL HOTKEYS
#if false
            #region GlobalHotKeys
            ghk = new globalKeyboardHook();
            //CREATE A HOTKEY FOR EACH ITEM IN ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands
            ghk.HookedKeys.Add(VGS_Commands.Key._01_V.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._02_A.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._03_1.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._04_2.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._05_3.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._06_F.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._07_G.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._08_M.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._09_T.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._10_B.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._11_D.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._12_E.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._13_J.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._14_S.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._15_C.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._16_L.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._17_R.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._18_W.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._19_H.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._20_I.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._21_Q.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._22_N.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._23_O.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._24_K.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._25_P.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._26_X.ValueKey);
            ghk.HookedKeys.Add(VGS_Commands.Key._27_Y.ValueKey);

            ghk.KeyUp += Ghk_KeyUp;//gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
            #endregion
#endif
            #region WebBrowser
            //https://stackoverflow.com/questions/22954934/webbrowser-control-continue-script-execution-without-script-error-warning-box?rq=1
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
            webBrowser1.Navigate("https://smite.gamepedia.com/VGS_Cheat_Sheet");
            #endregion
        }

        private void Ghk_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsRequiredToClearWindowTitle(e.KeyCode))
            {
                ClearWindowTitle();
                return;
            }
            HandleVgsInput_charByChar(((VGS_Commands.Key)e.KeyCode).ValueString);
        }
        public void ClearWindowTitle()
        {
            this.Text = string.Empty;
        }
        public bool IsRequiredToClearWindowTitle(Keys k)
        {
            if (k == Keys.Delete || k == Keys.Back || k == Keys.Escape) return true;
            else return false;
        }
        public void HandleVgsInput_charByChar(string s)
        {
            StringBuilder sb = new StringBuilder(s)
            {
                Length = 1                          //To make sure we only take one char and not more//This line is useless
            };

            string tmp = this.Text.Copy();
            this.Text += sb.ToString();//To make sure we only take one char and not more//This line is useless
            var conditions = VGS_Commands.IsValid(this.Text);
            if (conditions.Item1 == false)
            {
                if (VGS_Commands.IsValid(tmp).Item1)//if the beginning of the previous stored command was valid, we put back this into the title of the window.
                {
                    this.Text = tmp;
                    return;
                }
                else//if the beginning of the previous stored command is invalid, there is no point in keeping it whatsoever the reason. so we clear it.
                {
                    ClearWindowTitle();
                    return;
                }
            }
            if (conditions.Item2 == true)//the inputted command was valid
            {
                FocusVgsCommand(this.Text);
                ClearWindowTitle();
            }
            else
            {

            }
        }

        private void Sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            HandleVgsInput_charByChar(e.Result.Text);
        }
        #region i'm done coding this part
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
//ENABLING NON GLOBAL HOTKEYS
#if true
            if (once == false)
            {
                once = true;
                webBrowser1.PreviewKeyDown += webBrowser1_PreviewKeyDown;
            }
#endif
            #region shit didn't work - i didn't find a way to disable spacebar scroll

            //https://stackoverflow.com/questions/7557442/keyeventargs-handled-vs-keyeventargs-supresskeypress
            //if (e.KeyCode == Keys.Space) { e.Handled = true; return; }

            #region URL for source
            //SOURCE : How to disable web page scroll on spacebar press
            //https://stackoverflow.com/questions/22559830/html-prevent-space-bar-from-scrolling-page/22559927
            //not really useful https://stackoverflow.com/questions/4955422/disable-space-key-for-webbrowser

            //SOURCE : How to inject javascript into WebBrowser control
            //https://stackoverflow.com/questions/153748/how-to-inject-javascript-in-webbrowser-control
            #endregion
            //            HtmlElement body = webBrowser1.Document.GetElementsByTagName("body")[0];
            //            HtmlElement scriptEl = webBrowser1.Document.CreateElement("script");
            //            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            //            element.text =
            //            @"
            //window.addEventListener('keydown', function(e) {
            //  if(e.keyCode == 32 && e.target == document.body) {
            //    e.preventDefault();
            //  }
            //});";
            //            body.AppendChild(scriptEl);
            //            //webBrowser1.Document.InvokeScript("nameOfTheFunction");
            #endregion
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (ghk != null) ghk.unhook();
        }

        private HtmlElement GetElementByInnerText(string innerText, WebBrowser wb)
        {
            var result = GetElementByInnerText_(innerText, wb.Document.All);
            if (result.Item2 == false)
            {
                return null;
            }
            else
            {
                return result.Item1;
            }
        }
        /// <summary>
        /// https://stackoverflow.com/questions/16181773/loop-over-every-htmlelement-on-a-page-in-a-webbrowser-control
        /// </summary>
        /// <param name="innerText"></param>
        /// <param name="elementCollection"></param>
        /// <returns></returns>
        private Tuple<HtmlElement, bool> GetElementByInnerText_(string innerText, HtmlElementCollection elementCollection)
        {
            foreach (HtmlElement element in elementCollection)
            {
                if (!string.IsNullOrWhiteSpace(element.InnerText) && element.InnerText.Trim() == innerText)
                {
                    return new Tuple<HtmlElement, bool>(element, true);
                }
            }

            return new Tuple<HtmlElement, bool>(null, false);
        }
        public void FocusVgsCommand(string VGS_Command)
        {
            var HTML_Tag_Containing_VGSCOMMAND = GetElementByInnerText(VGS_Command, webBrowser1);
            if (HTML_Tag_Containing_VGSCOMMAND != null)
            {
                this.Text = string.Empty;
                HTML_Tag_Containing_VGSCOMMAND.ScrollIntoView(true);
            }
            else
            {
                this.Text = "No match found";
            }
        }
        #endregion

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {//This event will always fire twice.
            #region handling the annoying thing that is that this event fires twice
            if (dontFireTwice == false)//This section of code handles the first time it fires.
            {
                dontFireTwice = true;
                goto Here;
            }
            if (dontFireTwice == true)//This section of code handles the second time it fires.
            {
                dontFireTwice = false;
                return;
            }
            if (dontFireTwice == null)//This section of code handles the time where the program just started.
            {
                dontFireTwice = true;
                //goto Here;
                //no need because it's already the next statement
            }
            #endregion
            Here:
            if (IsRequiredToClearWindowTitle(e.KeyCode))
            {
                ClearWindowTitle();
                return;
            }
            var tmpKey = ((VGS_Commands.Key)e.KeyCode);
            if (tmpKey != null)
            {
                HandleVgsInput_charByChar(tmpKey.ValueString);
            }
        }
    }
}
