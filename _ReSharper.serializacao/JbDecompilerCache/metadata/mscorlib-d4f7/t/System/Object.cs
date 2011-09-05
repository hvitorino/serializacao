// Type: System.Object
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	[Serializable]
	public class Object
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public Object();

		public virtual string ToString();

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public virtual bool Equals(object obj);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool Equals(object objA, object objB);

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public static bool ReferenceEquals(object objA, object objB);

		[TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
		public virtual int GetHashCode();

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public Type GetType();

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		~Object();

		[SecuritySafeCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected object MemberwiseClone();
	}
}
