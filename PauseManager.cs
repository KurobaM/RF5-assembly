using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000663 RID: 1635
[Token(Token = "0x200048F")]
public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x06002895 RID: 10389 RVA: 0x00010038 File Offset: 0x0000E238
	[Token(Token = "0x1700052C")]
	public static bool IsSystemPause
	{
		[Token(Token = "0x6002251")]
		[Address(RVA = "0x213C040", Offset = "0x213C141", VA = "0x213C040")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x06002896 RID: 10390 RVA: 0x00010050 File Offset: 0x0000E250
	[Token(Token = "0x1700052D")]
	public static bool IsGamePause
	{
		[Token(Token = "0x6002252")]
		[Address(RVA = "0x213C520", Offset = "0x213C621", VA = "0x213C520")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x06002897 RID: 10391 RVA: 0x00010068 File Offset: 0x0000E268
	[Token(Token = "0x1700052E")]
	public static bool IsInputPause
	{
		[Token(Token = "0x6002253")]
		[Address(RVA = "0x213C660", Offset = "0x213C761", VA = "0x213C660")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x06002898 RID: 10392 RVA: 0x00010080 File Offset: 0x0000E280
	[Token(Token = "0x1700052F")]
	public static bool IsTimePause
	{
		[Token(Token = "0x6002254")]
		[Address(RVA = "0x213C7D0", Offset = "0x213C8D1", VA = "0x213C7D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002255")]
	[Address(RVA = "0x213C970", Offset = "0x213CA71", VA = "0x213C970")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002256")]
	[Address(RVA = "0x213C9E0", Offset = "0x213CAE1", VA = "0x213C9E0")]
	private void StartUpdateCroutine()
	{
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002257")]
	[Address(RVA = "0x213CB00", Offset = "0x213CC01", VA = "0x213CB00")]
	private void StopUpdateCroutine()
	{
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002258")]
	[Address(RVA = "0x213CC30", Offset = "0x213CD31", VA = "0x213CC30")]
	private void OnEnable()
	{
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002259")]
	[Address(RVA = "0x213CC40", Offset = "0x213CD41", VA = "0x213CC40")]
	private void OnDisable()
	{
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600225A")]
	[Address(RVA = "0x213CBD0", Offset = "0x213CCD1", VA = "0x213CBD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A2090", Offset = "0x1A2191")]
	private IEnumerator EndFrameUpdate()
	{
		return null;
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225B")]
	[Address(RVA = "0x213CC80", Offset = "0x213CD81", VA = "0x213CC80")]
	public static void OnSystemPause()
	{
	}

	// Token: 0x060028A0 RID: 10400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225C")]
	[Address(RVA = "0x213CCF0", Offset = "0x213CDF1", VA = "0x213CCF0")]
	public static void OffSystemPause()
	{
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225D")]
	[Address(RVA = "0x213CD60", Offset = "0x213CE61", VA = "0x213CD60")]
	public static void OnGamePause()
	{
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225E")]
	[Address(RVA = "0x213CDF0", Offset = "0x213CEF1", VA = "0x213CDF0")]
	public static void OffGamePause()
	{
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600225F")]
	[Address(RVA = "0x213CF60", Offset = "0x213D061", VA = "0x213CF60")]
	public static void OnInputPause()
	{
	}

	// Token: 0x060028A4 RID: 10404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002260")]
	[Address(RVA = "0x213CEF0", Offset = "0x213CFF1", VA = "0x213CEF0")]
	public static void OffInputPause()
	{
	}

	// Token: 0x060028A5 RID: 10405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002261")]
	[Address(RVA = "0x213CFD0", Offset = "0x213D0D1", VA = "0x213CFD0")]
	public static void OnGameTimePause()
	{
	}

	// Token: 0x060028A6 RID: 10406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002262")]
	[Address(RVA = "0x213D040", Offset = "0x213D141", VA = "0x213D040")]
	public static void OffGameTimePause()
	{
	}

	// Token: 0x060028A7 RID: 10407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002263")]
	[Address(RVA = "0x213D0D0", Offset = "0x213D1D1", VA = "0x213D0D0")]
	public PauseManager()
	{
	}

	// Token: 0x0400700E RID: 28686
	[Token(Token = "0x4006856")]
	[FieldOffset(Offset = "0x0")]
	private static bool m_ReserveSystemPause;

	// Token: 0x0400700F RID: 28687
	[Token(Token = "0x4006857")]
	[FieldOffset(Offset = "0x1")]
	private static bool m_IsSystemPause;

	// Token: 0x04007010 RID: 28688
	[Token(Token = "0x4006858")]
	[FieldOffset(Offset = "0x2")]
	private static bool m_IsGamePause;

	// Token: 0x04007011 RID: 28689
	[Token(Token = "0x4006859")]
	[FieldOffset(Offset = "0x3")]
	private static bool m_IsInputPause;

	// Token: 0x04007012 RID: 28690
	[Token(Token = "0x400685A")]
	[FieldOffset(Offset = "0x4")]
	private static bool m_IsGameTimePause;

	// Token: 0x04007013 RID: 28691
	[Token(Token = "0x400685B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HideInInspector", RVA = "0x168760", Offset = "0x168861")]
	public UnityEvent OnGamePauseEvent;

	// Token: 0x04007014 RID: 28692
	[Token(Token = "0x400685C")]
	[FieldOffset(Offset = "0x8")]
	private static float PrevTimeScale;

	// Token: 0x04007015 RID: 28693
	[Token(Token = "0x400685D")]
	[FieldOffset(Offset = "0x10")]
	private static Coroutine m_endFrameUpdateCoroutine;

	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x200115D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1581F0", Offset = "0x1582F1")]
	private sealed class <EndFrameUpdate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060028A9 RID: 10409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600712F")]
		[Address(RVA = "0x213CC50", Offset = "0x213CD51", VA = "0x213CC50")]
		[DebuggerHidden]
		public <EndFrameUpdate>d__21(int <>1__state)
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007130")]
		[Address(RVA = "0x213D1F0", Offset = "0x213D2F1", VA = "0x213D1F0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x6007131")]
		[Address(RVA = "0x213D200", Offset = "0x213D301", VA = "0x213D200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D09")]
		private object Current
		{
			[Token(Token = "0x6007132")]
			[Address(RVA = "0x213D440", Offset = "0x213D541", VA = "0x213D440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007133")]
		[Address(RVA = "0x213D450", Offset = "0x213D551", VA = "0x213D450", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0A")]
		private object Current
		{
			[Token(Token = "0x6007134")]
			[Address(RVA = "0x213D4B0", Offset = "0x213D5B1", VA = "0x213D4B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007016 RID: 28694
		[Token(Token = "0x401942B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007017 RID: 28695
		[Token(Token = "0x401942C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
