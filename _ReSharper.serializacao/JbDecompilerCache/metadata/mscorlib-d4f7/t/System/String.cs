// Type: System.String
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System
{
	[ComVisible(true)]
	[Serializable]
	public sealed class String : IComparable, ICloneable, IConvertible, IComparable<string>, IEnumerable<char>, IEnumerable, IEquatable<string>
	{
		public static readonly string Empty;

		[CLSCompliant(false)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(char* value);

		[SecurityCritical]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(char* value, int startIndex, int length);

		[CLSCompliant(false)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(sbyte* value);

		[CLSCompliant(false)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(sbyte* value, int startIndex, int length);

		[SecurityCritical]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(sbyte* value, int startIndex, int length, Encoding enc);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(char[] value, int startIndex, int length);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(char[] value);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public String(char c, int count);

		[IndexerName("Chars")]
		public char this[int index] { [SecuritySafeCritical, MethodImpl(MethodImplOptions.InternalCall)]
		get; }

		public int Length { [SecuritySafeCritical, MethodImpl(MethodImplOptions.InternalCall)]
		get; }

		#region ICloneable Members

		public object Clone();

		#endregion

		#region IComparable Members

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int CompareTo(object value);

		#endregion

		#region IComparable<string> Members

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int CompareTo(string strB);

		#endregion

		#region IConvertible Members

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string ToString(IFormatProvider provider);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public TypeCode GetTypeCode();

		bool IConvertible.ToBoolean(IFormatProvider provider);
		char IConvertible.ToChar(IFormatProvider provider);

		[SecuritySafeCritical]
		sbyte IConvertible.ToSByte(IFormatProvider provider);

		[SecuritySafeCritical]
		byte IConvertible.ToByte(IFormatProvider provider);

		[SecuritySafeCritical]
		short IConvertible.ToInt16(IFormatProvider provider);

		[SecuritySafeCritical]
		ushort IConvertible.ToUInt16(IFormatProvider provider);

		[SecuritySafeCritical]
		int IConvertible.ToInt32(IFormatProvider provider);

		[SecuritySafeCritical]
		uint IConvertible.ToUInt32(IFormatProvider provider);

		[SecuritySafeCritical]
		long IConvertible.ToInt64(IFormatProvider provider);

		[SecuritySafeCritical]
		ulong IConvertible.ToUInt64(IFormatProvider provider);

		[SecuritySafeCritical]
		float IConvertible.ToSingle(IFormatProvider provider);

		[SecuritySafeCritical]
		double IConvertible.ToDouble(IFormatProvider provider);

		[SecuritySafeCritical]
		decimal IConvertible.ToDecimal(IFormatProvider provider);

		[SecuritySafeCritical]
		DateTime IConvertible.ToDateTime(IFormatProvider provider);

		object IConvertible.ToType(Type type, IFormatProvider provider);

		#endregion

		#region IEnumerable<char> Members

		IEnumerator<char> IEnumerable<char>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();

		#endregion

		#region IEquatable<string> Members

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public bool Equals(string value);

		#endregion

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator ==(string a, string b);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool operator !=(string a, string b);

		public static string Join(string separator, params string[] value);

		[ComVisible(false)]
		public static string Join(string separator, params object[] values);

		[ComVisible(false)]
		public static string Join<T>(string separator, IEnumerable<T> values);

		[ComVisible(false)]
		public static string Join(string separator, IEnumerable<string> values);

		[SecuritySafeCritical]
		public static string Join(string separator, string[] value, int startIndex, int count);

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public override bool Equals(object obj);

		[SecuritySafeCritical]
		public bool Equals(string value, StringComparison comparisonType);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool Equals(string a, string b);

		[SecuritySafeCritical]
		public static bool Equals(string a, string b, StringComparison comparisonType);

		[SecuritySafeCritical]
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);

		[SecuritySafeCritical]
		public char[] ToCharArray();

		[SecuritySafeCritical]
		public char[] ToCharArray(int startIndex, int length);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool IsNullOrEmpty(string value);

		public static bool IsNullOrWhiteSpace(string value);

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecuritySafeCritical]
		public override int GetHashCode();

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string[] Split(params char[] separator);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string[] Split(char[] separator, int count);

		[ComVisible(false)]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string[] Split(char[] separator, StringSplitOptions options);

		[ComVisible(false)]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string[] Split(char[] separator, int count, StringSplitOptions options);

		[ComVisible(false)]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string[] Split(string[] separator, StringSplitOptions options);

		[ComVisible(false)]
		public string[] Split(string[] separator, int count, StringSplitOptions options);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string Substring(int startIndex);

		[SecuritySafeCritical]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string Substring(int startIndex, int length);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string Trim(params char[] trimChars);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string TrimStart(params char[] trimChars);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string TrimEnd(params char[] trimChars);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public bool IsNormalized();

		[SecuritySafeCritical]
		public bool IsNormalized(NormalizationForm normalizationForm);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string Normalize();

		[SecuritySafeCritical]
		public string Normalize(NormalizationForm normalizationForm);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static int Compare(string strA, string strB);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static int Compare(string strA, string strB, bool ignoreCase);

		[SecuritySafeCritical]
		public static int Compare(string strA, string strB, StringComparison comparisonType);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture);

		public static int Compare(string strA, int indexA, string strB, int indexB, int length);
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase);
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture);
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options);

		[SecuritySafeCritical]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static int CompareOrdinal(string strA, string strB);

		[SecuritySafeCritical]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public bool Contains(string value);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public bool EndsWith(string value);

		[ComVisible(false)]
		[SecuritySafeCritical]
		public bool EndsWith(string value, StringComparison comparisonType);

		public bool EndsWith(string value, bool ignoreCase, CultureInfo culture);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int IndexOf(char value);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int IndexOf(char value, int startIndex);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public int IndexOf(char value, int startIndex, int count);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int IndexOfAny(char[] anyOf);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int IndexOfAny(char[] anyOf, int startIndex);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public int IndexOfAny(char[] anyOf, int startIndex, int count);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public int IndexOf(string value);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public int IndexOf(string value, int startIndex);

		public int IndexOf(string value, int startIndex, int count);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		[SecuritySafeCritical]
		public int IndexOf(string value, StringComparison comparisonType);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int IndexOf(string value, int startIndex, StringComparison comparisonType);

		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int LastIndexOf(char value);

		public int LastIndexOf(char value, int startIndex);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public int LastIndexOf(char value, int startIndex, int count);

		public int LastIndexOfAny(char[] anyOf);
		public int LastIndexOfAny(char[] anyOf, int startIndex);

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count);

		[SecuritySafeCritical]
		public int LastIndexOf(string value);

		public int LastIndexOf(string value, int startIndex);
		public int LastIndexOf(string value, int startIndex, int count);

		[SecuritySafeCritical]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public int LastIndexOf(string value, StringComparison comparisonType);

		public int LastIndexOf(string value, int startIndex, StringComparison comparisonType);
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string PadLeft(int totalWidth);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string PadLeft(int totalWidth, char paddingChar);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string PadRight(int totalWidth);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string PadRight(int totalWidth, char paddingChar);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public bool StartsWith(string value);

		[SecuritySafeCritical]
		[ComVisible(false)]
		public bool StartsWith(string value, StringComparison comparisonType);

		public bool StartsWith(string value, bool ignoreCase, CultureInfo culture);
		public string ToLower();

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string ToLower(CultureInfo culture);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string ToLowerInvariant();

		public string ToUpper();

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string ToUpper(CultureInfo culture);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string ToUpperInvariant();

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public override string ToString();

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string Trim();

		[SecuritySafeCritical]
		public string Insert(int startIndex, string value);

		[SecuritySafeCritical]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public string Replace(char oldChar, char newChar);

		[SecuritySafeCritical]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public string Replace(string oldValue, string newValue);

		[SecuritySafeCritical]
		public string Remove(int startIndex, int count);

		public string Remove(int startIndex);
		public static string Format(string format, object arg0);
		public static string Format(string format, object arg0, object arg1);
		public static string Format(string format, object arg0, object arg1, object arg2);
		public static string Format(string format, params object[] args);

		[SecuritySafeCritical]
		public static string Format(IFormatProvider provider, string format, params object[] args);

		[SecuritySafeCritical]
		public static string Copy(string str);

		public static string Concat(object arg0);
		public static string Concat(object arg0, object arg1);
		public static string Concat(object arg0, object arg1, object arg2);

		[SecuritySafeCritical]
		[CLSCompliant(false)]
		public static string Concat(object arg0, object arg1, object arg2, object arg3);

		public static string Concat(params object[] args);

		[ComVisible(false)]
		public static string Concat<T>(IEnumerable<T> values);

		[ComVisible(false)]
		public static string Concat(IEnumerable<string> values);

		[SecuritySafeCritical]
		public static string Concat(string str0, string str1);

		[SecuritySafeCritical]
		public static string Concat(string str0, string str1, string str2);

		[SecuritySafeCritical]
		public static string Concat(string str0, string str1, string str2, string str3);

		public static string Concat(params string[] values);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		[SecuritySafeCritical]
		public static string Intern(string str);

		[SecuritySafeCritical]
		public static string IsInterned(string str);

		public CharEnumerator GetEnumerator();
	}
}
