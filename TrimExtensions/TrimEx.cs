using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrimExtensions {
    public static class TrimEx {
        // ab;cd;ef, ; => ab
        public static string TrimAfterFirstOf(this string s, string delimiter) {
            return s;
        }

        // ab;cd;ef, ; => ab;cd
        public static string TrimAfterLastOf(this string s, string delimiter) {
            return s;
        }

        // ab;cd;ef, ; => cd;ef
        public static string TrimBeforeFirstOf(this string s, string delimiter) {
            return s;
        }

        // ef, ; => ab;cd
        public static string TrimBeforeLastOf(this string s, string delimiter) {
            return s;
        }
    }
}
