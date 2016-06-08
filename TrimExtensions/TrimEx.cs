using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrimExtensions {
    public static class TrimEx {
        // ab;cd;ef, ; => ab
        private static string TrimAfterFirstOf(string s, string delimiter) {
            return s;
        }

        // ab;cd;ef, ; => ab;cd
        private static string TrimAfterLastOf(this string s, string delimiter) {
            return s;
        }

        // ab;cd;ef, ; => cd;ef
        private static string TrimBeforeFirstOf(this string s, string delimiter) {
            return s;
        }

        // ef, ; => ab;cd
        private static string TrimBeforeLastOf(this string s, string delimiter) {
            return s;
        }
    }
}
