using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200050E RID: 1294
[Token(Token = "0x20003B1")]
public class FestivalUI : MonoBehaviour
{
	// Token: 0x06001F7A RID: 8058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x1F81DC0", Offset = "0x1F81EC1", VA = "0x1F81DC0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x1F81E60", Offset = "0x1F81F61", VA = "0x1F81E60")]
	public void SetScoreUI(int _score)
	{
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x1F81E80", Offset = "0x1F81F81", VA = "0x1F81E80")]
	public void SetTimer(float _time)
	{
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x1F7DB60", Offset = "0x1F7DC61", VA = "0x1F7DB60")]
	public void ActiveTimer(bool _flag)
	{
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x1F7D0A0", Offset = "0x1F7D1A1", VA = "0x1F7D0A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FC80", Offset = "0x19FD81")]
	public IEnumerator OnStart()
	{
		return null;
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x1F7D750", Offset = "0x1F7D851", VA = "0x1F7D750")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FCF0", Offset = "0x19FDF1")]
	public IEnumerator OnFinish()
	{
		return null;
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x1F7D010", Offset = "0x1F7D111", VA = "0x1F7D010")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FD60", Offset = "0x19FE61")]
	public IEnumerator OnCountDown(int _count)
	{
		return null;
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x1F81F30", Offset = "0x1F82031", VA = "0x1F81F30")]
	public FestivalUI()
	{
	}

	// Token: 0x0400666C RID: 26220
	[Token(Token = "0x40060BD")]
	[FieldOffset(Offset = "0x18")]
	protected Animator animator;

	// Token: 0x0400666D RID: 26221
	[Token(Token = "0x40060BE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image startImage;

	// Token: 0x0400666E RID: 26222
	[Token(Token = "0x40060BF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image finishImage;

	// Token: 0x0400666F RID: 26223
	[Token(Token = "0x40060C0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private FestivalCountDown countDownUI;

	// Token: 0x04006670 RID: 26224
	[Token(Token = "0x40060C1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private FestivalNumScore scoreUI;

	// Token: 0x04006671 RID: 26225
	[Token(Token = "0x40060C2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private FestivalNumScore timerUI;

	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x20010E6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157CA0", Offset = "0x157DA1")]
	private sealed class <OnStart>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F82 RID: 8066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F81")]
		[Address(RVA = "0x1F81EA0", Offset = "0x1F81FA1", VA = "0x1F81EA0")]
		[DebuggerHidden]
		public <OnStart>d__10(int <>1__state)
		{
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F82")]
		[Address(RVA = "0x1F82300", Offset = "0x1F82401", VA = "0x1F82300", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6006F83")]
		[Address(RVA = "0x1F82310", Offset = "0x1F82411", VA = "0x1F82310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA5")]
		private object Current
		{
			[Token(Token = "0x6006F84")]
			[Address(RVA = "0x1F82450", Offset = "0x1F82551", VA = "0x1F82450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F85")]
		[Address(RVA = "0x1F82460", Offset = "0x1F82561", VA = "0x1F82460", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA6")]
		private object Current
		{
			[Token(Token = "0x6006F86")]
			[Address(RVA = "0x1F824C0", Offset = "0x1F825C1", VA = "0x1F824C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006672 RID: 26226
		[Token(Token = "0x4019222")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006673 RID: 26227
		[Token(Token = "0x4019223")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006674 RID: 26228
		[Token(Token = "0x4019224")]
		[FieldOffset(Offset = "0x20")]
		public FestivalUI <>4__this;
	}

	// Token: 0x02000510 RID: 1296
	[Token(Token = "0x20010E7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157CB0", Offset = "0x157DB1")]
	private sealed class <OnFinish>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F87")]
		[Address(RVA = "0x1F81ED0", Offset = "0x1F81FD1", VA = "0x1F81ED0")]
		[DebuggerHidden]
		public <OnFinish>d__11(int <>1__state)
		{
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F88")]
		[Address(RVA = "0x1F82150", Offset = "0x1F82251", VA = "0x1F82150", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6006F89")]
		[Address(RVA = "0x1F82160", Offset = "0x1F82261", VA = "0x1F82160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA7")]
		private object Current
		{
			[Token(Token = "0x6006F8A")]
			[Address(RVA = "0x1F82280", Offset = "0x1F82381", VA = "0x1F82280", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8B")]
		[Address(RVA = "0x1F82290", Offset = "0x1F82391", VA = "0x1F82290", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA8")]
		private object Current
		{
			[Token(Token = "0x6006F8C")]
			[Address(RVA = "0x1F822F0", Offset = "0x1F823F1", VA = "0x1F822F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006675 RID: 26229
		[Token(Token = "0x4019225")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006676 RID: 26230
		[Token(Token = "0x4019226")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006677 RID: 26231
		[Token(Token = "0x4019227")]
		[FieldOffset(Offset = "0x20")]
		public FestivalUI <>4__this;
	}

	// Token: 0x02000511 RID: 1297
	[Token(Token = "0x20010E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157CC0", Offset = "0x157DC1")]
	private sealed class <OnCountDown>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0x1F81F00", Offset = "0x1F82001", VA = "0x1F81F00")]
		[DebuggerHidden]
		public <OnCountDown>d__12(int <>1__state)
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F8E")]
		[Address(RVA = "0x1F81F40", Offset = "0x1F82041", VA = "0x1F81F40", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0x1F81F50", Offset = "0x1F82051", VA = "0x1F81F50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA9")]
		private object Current
		{
			[Token(Token = "0x6006F90")]
			[Address(RVA = "0x1F820D0", Offset = "0x1F821D1", VA = "0x1F820D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F91")]
		[Address(RVA = "0x1F820E0", Offset = "0x1F821E1", VA = "0x1F820E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAA")]
		private object Current
		{
			[Token(Token = "0x6006F92")]
			[Address(RVA = "0x1F82140", Offset = "0x1F82241", VA = "0x1F82140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006678 RID: 26232
		[Token(Token = "0x4019228")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006679 RID: 26233
		[Token(Token = "0x4019229")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400667A RID: 26234
		[Token(Token = "0x401922A")]
		[FieldOffset(Offset = "0x20")]
		public FestivalUI <>4__this;

		// Token: 0x0400667B RID: 26235
		[Token(Token = "0x401922B")]
		[FieldOffset(Offset = "0x28")]
		public int _count;
	}
}
