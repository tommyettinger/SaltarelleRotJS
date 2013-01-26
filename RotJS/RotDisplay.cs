
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

    [Imported, Serializable]
    public class DisplayOptions
    {
        /*
         * 
 * @param {int} [options.height=ROT.DEFAULT_HEIGHT]
 * @param {int} [options.fontSize=15]
 * @param {string} [options.fontFamily="monospace"]
 * @param {string} [options.fontStyle=""] bold/italic/none/both
 * @param {string} [options.fg="#ccc"]
 * @param {string} [options.bg="#000"]
 * @param {int} [options.fps=25]
 * @param {float} [options.spacing=1]
 * @param {string} [options.layout="rect"]
         */
        public int Width { get; set; }
        public int Height { get; set; }
        public int Fps { get; set; }
        public int FontSize { get; set; }
        public string FontFamily { get; set; }
        public string FontStyle { get; set; }
        [PreserveCase]
        public string fg { get; set; }
        [PreserveCase]
        public string bg { get; set; }
        public float Spacing { get; set; }
        public string Layout { get; set; }
        public DisplayOptions() { }
        public DisplayOptions(int width, int height) { }
        public DisplayOptions(int width, int height, string fontFamily) { }
        public DisplayOptions(int width, int height, string fontFamily, string fontStyle) { }
        public DisplayOptions(int width, int height, string fontFamily, string fontStyle, string fg, string bg) { }
        public DisplayOptions(int width, int height, string fontFamily, string fontStyle, string fg, string bg, int fps) { }
        public DisplayOptions(int width, int height, string fontFamily, string fontStyle, string fg, string bg, int fps, float spacing) { }
        public DisplayOptions(int width, int height, string fontFamily, string fontStyle, string fg, string bg, int fps, float spacing, string layout) { }
    }

    [Imported]
    [PreserveMemberCase]
    public class Display
    {
        /// <summary>
        /// Fiddling with this, unsure what it needs.
        /// </summary>
        /// <param name="options"></param>

        public Display(DisplayOptions options) { }
    
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

