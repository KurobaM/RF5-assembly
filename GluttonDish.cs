using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000515 RID: 1301
[Token(Token = "0x20003B5")]
public class GluttonDish : MonoBehaviour
{
	// Token: 0x06001F9F RID: 8095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x1FEF0D0", Offset = "0x1FEF1D1", VA = "0x1FEF0D0")]
	private void Start()
	{
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x1FEF270", Offset = "0x1FEF371", VA = "0x1FEF270")]
	public void OnSpawn()
	{
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x1FEF1E0", Offset = "0x1FEF2E1", VA = "0x1FEF1E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FE10", Offset = "0x19FF11")]
	protected IEnumerator DelayMethod(float waitTime, Action action)
	{
		return null;
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x1FEF300", Offset = "0x1FEF401", VA = "0x1FEF300")]
	public GluttonDish()
	{
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AFB")]
	[Address(RVA = "0x1FEF310", Offset = "0x1FEF411", VA = "0x1FEF310")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FE80", Offset = "0x19FF81")]
	private void <Start>b__1_0()
	{
	}

	// Token: 0x04006685 RID: 26245
	[Token(Token = "0x40060CC")]
	[FieldOffset(Offset = "0x18")]
	private Animator Animator;

	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x20010E9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157CD0", Offset = "0x157DD1")]
	private sealed class <DelayMethod>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001FA4 RID: 8100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0x1FEF2D0", Offset = "0x1FEF3D1", VA = "0x1FEF2D0")]
		[DebuggerHidden]
		public <DelayMethod>d__3(int <>1__state)
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0x1FEF370", Offset = "0x1FEF471", VA = "0x1FEF370", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x6006F95")]
		[Address(RVA = "0x1FEF380", Offset = "0x1FEF481", VA = "0x1FEF380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAB")]
		private object Current
		{
			[Token(Token = "0x6006F96")]
			[Address(RVA = "0x1FEF450", Offset = "0x1FEF551", VA = "0x1FEF450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F97")]
		[Address(RVA = "0x1FEF460", Offset = "0x1FEF561", VA = "0x1FEF460", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAC")]
		private object Current
		{
			[Token(Token = "0x6006F98")]
			[Address(RVA = "0x1FEF4C0", Offset = "0x1FEF5C1", VA = "0x1FEF4C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006686 RID: 26246
		[Token(Token = "0x401922C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006687 RID: 26247
		[Token(Token = "0x401922D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006688 RID: 26248
		[Token(Token = "0x401922E")]
		[FieldOffset(Offset = "0x20")]
		public float waitTime;

		// Token: 0x04006689 RID: 26249
		[Token(Token = "0x401922F")]
		[FieldOffset(Offset = "0x28")]
		public Action action;
	}
}
