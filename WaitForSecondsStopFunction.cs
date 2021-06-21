using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DE RID: 734
[Token(Token = "0x200023E")]
public sealed class WaitForSecondsStopFunction : CustomYieldInstruction
{
	// Token: 0x1700037B RID: 891
	// (get) Token: 0x0600138F RID: 5007 RVA: 0x00008D60 File Offset: 0x00006F60
	[Token(Token = "0x17000343")]
	public override bool keepWaiting
	{
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x1E4BF40", Offset = "0x1E4C041", VA = "0x1E4BF40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x1E4BFD0", Offset = "0x1E4C0D1", VA = "0x1E4BFD0")]
	public WaitForSecondsStopFunction(float time, [Optional] Func<bool> func)
	{
	}

	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Func<bool> stopFunc;

	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float waitTime;

	// Token: 0x020002DF RID: 735
	[Token(Token = "0x2001029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157380", Offset = "0x157481")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001392 RID: 5010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CB5")]
		[Address(RVA = "0x1E4C170", Offset = "0x1E4C271", VA = "0x1E4C170")]
		public <>c()
		{
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x6006CB6")]
		[Address(RVA = "0x1E4C180", Offset = "0x1E4C281", VA = "0x1E4C180")]
		internal bool <.ctor>b__4_0()
		{
			return default(bool);
		}

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4018ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WaitForSecondsStopFunction.<>c <>9;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4018ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> <>9__4_0;
	}
}
