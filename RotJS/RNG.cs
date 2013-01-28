
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
    public static class RNG
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
        public static int GetSeed()
        {
            return 0;
        }
        public static void SetSeed(int seed)
        {
        }
        public static double GetUniform()
        {
            return 0.0;
        }

        public static double GetNormal(double mean, double stddev)
        {
            return 0.0;
        }
        public static int GetPercentage()
        {
            return 0;
        }
        public static object GetState()
        {
            return null;
        }
        public static void SetState(object state)
        {
        }
    }

}

