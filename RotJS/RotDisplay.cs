
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Html;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ROT
{

    [Imported]
    [IgnoreNamespace]
    [PreserveMemberCase]
    public class Display
    {
        /// <summary>
        /// Fiddling with this, unsure what it needs.
        /// </summary>
        /// <param name="options"></param>
        [InlineCode("ROT.Display({*options})")]
        public Display(params object[] options)
        {
        }
        [PreserveCase]
        public void DEBUG(int x, int y, int what)
        {
        }

        public void clear()
        {
        }

        public Display setOptions(JsDictionary options)
        {
            return null;
        }

        public Display getOptions()
        {
            return null;
        }

        public Element getContainer()
        {
            return null;
        }

        public int[] computeSize(int availWidth, int availHeight)
        {
            return null;
        }

        public int computeFontSize(int availWidth, int availHeight)
        {
            return 0;
        }

        public void draw(int x, int y, string ch)
        {
        }

        public void draw(int x, int y, string ch, string fg)
        {
        }

        public void draw(int x, int y, string ch, string fg, string bg)
        {
        }


        public int drawText(int x, int y, string text, int maxWidth)
        {
            return 0;
        }

        public object measureText(string text, int maxWidth)
        {
            return null;
        }

        public void _tick()
        {
        }

        public void _draw(string key, bool clearBefore)
        {
        }


        public void _fillHex(int x, int y)
        {
        }

        public void _compute()
        {
        }
    }
}

