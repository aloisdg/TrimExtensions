﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrimExtensions {
    public static class TrimEx {
        // ab;cd;ef, ; => ab
        public static string TrimAfterFirstOf(this string source, string delimiter, bool hasDelimiter = false) {
            var delimiterSize = hasDelimiter ? delimiter.Length : 0;
            var end = source.IndexOf (delimiter) + delimiterSize;
            var result = source.Remove (end);
            return result;
        }

        // ab;cd;ef, ; => ab;cd
        public static string TrimAfterLastOf(this string source, string delimiter, bool hasDelimiter = false) {
            var delimiterSize = hasDelimiter ? delimiter.Length : 0;
            var end = source.LastIndexOf (delimiter) + delimiterSize;
            var result = source.Remove (end);
            return result;
        }

        // ab;cd;ef, ; => cd;ef
        public static string TrimBeforeFirstOf(this string source, string delimiter, bool hasDelimiter = false) {
            var delimiterSize = !hasDelimiter ? delimiter.Length : 0;
            var start = source.IndexOf (delimiter) + delimiterSize;
            var result = source.Substring (start);
            return result;
        }

        // ef, ; => ab;cd
        public static string TrimBeforeLastOf(this string source, string delimiter, bool hasDelimiter = false) {
            var delimiterSize = !hasDelimiter ? delimiter.Length : 0;
            var start = source.LastIndexOf (delimiter) + delimiterSize;
            var result = source.Substring (start);
            return result;
        }
    }
}
