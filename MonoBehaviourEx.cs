using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004CB RID: 1227
[Token(Token = "0x200038A")]
public static class MonoBehaviourEx
{
	// Token: 0x06001E2C RID: 7724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x1D7C5F0", Offset = "0x1D7C6F1", VA = "0x1D7C5F0")]
	public static void SetActive(this MonoBehaviour self, bool isActive)
	{
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x0000CED0 File Offset: 0x0000B0D0
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x1D7C6C0", Offset = "0x1D7C7C1", VA = "0x1D7C6C0")]
	public static bool IsActive(this MonoBehaviour self)
	{
		return default(bool);
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x1D80270", Offset = "0x1D80371", VA = "0x1D80270")]
	public static bool IsEnabled(this MonoBehaviour self)
	{
		return default(bool);
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x1D80290", Offset = "0x1D80391", VA = "0x1D80290")]
	public static void IsEnabled(this MonoBehaviour self, bool value)
	{
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x1D802B0", Offset = "0x1D803B1", VA = "0x1D802B0")]
	public static void SetLayer(this MonoBehaviour self, int layer, bool isRecursion = true)
	{
	}

	// Token: 0x06001E31 RID: 7729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x1D802F0", Offset = "0x1D803F1", VA = "0x1D802F0")]
	public static void Invoke(this MonoBehaviour self, Action method, float delay)
	{
	}

	// Token: 0x06001E32 RID: 7730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x1D80350", Offset = "0x1D80451", VA = "0x1D80350")]
	public static void DoEvent(this MonoBehaviour self, Action handler)
	{
	}

	// Token: 0x06001E33 RID: 7731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A16")]
	public static void DoEvent<T>(this MonoBehaviour self, Action<T> handler, T parameter)
	{
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A17")]
	public static void DoEvent<T1, T2>(this MonoBehaviour self, Action<T1, T2> handler, T1 arg1, T2 arg2)
	{
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A18")]
	public static void DoEvent<T1, T2, T3>(this MonoBehaviour self, Action<T1, T2, T3> handler, T1 arg1, T2 arg2, T3 arg3)
	{
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A19")]
	public static TResult DoEvent<TResult>(this MonoBehaviour self, Func<TResult> handler)
	{
		return null;
	}

	// Token: 0x06001E37 RID: 7735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1A")]
	public static TResult DoEvent<T, TResult>(this MonoBehaviour self, Func<T, TResult> handler, T parameter)
	{
		return null;
	}

	// Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1B")]
	public static TResult DoEvent<T1, T2, TResult>(this MonoBehaviour self, Func<T1, T2, TResult> handler, T1 arg1, T2 arg2)
	{
		return null;
	}

	// Token: 0x06001E39 RID: 7737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x1D80370", Offset = "0x1D80471", VA = "0x1D80370")]
	public static void StartCoroutine(this MonoBehaviour self, Func<IEnumerator> method)
	{
	}

	// Token: 0x06001E3A RID: 7738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x1D803C0", Offset = "0x1D804C1", VA = "0x1D803C0")]
	public static void StopCoroutine(this MonoBehaviour self, Func<IEnumerator> method)
	{
	}

	// Token: 0x06001E3B RID: 7739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x1D80410", Offset = "0x1D80511", VA = "0x1D80410")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F190", Offset = "0x19F291")]
	public static IEnumerator PlayAnimationAsync(this MonoBehaviour self, string animationName, [Optional] Animation playAnimation)
	{
		return null;
	}

	// Token: 0x06001E3C RID: 7740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x1D804F0", Offset = "0x1D805F1", VA = "0x1D804F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F210", Offset = "0x19F311")]
	public static IEnumerator PlayAnimatorStateAsync(this MonoBehaviour self, string stateName, [Optional] Animator playAnimator)
	{
		return null;
	}

	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20010CA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B20", Offset = "0x157C21")]
	private sealed class <PlayAnimationAsync>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F08")]
		[Address(RVA = "0x1D804C0", Offset = "0x1D805C1", VA = "0x1D804C0")]
		[DebuggerHidden]
		public <PlayAnimationAsync>d__15(int <>1__state)
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F09")]
		[Address(RVA = "0x1D805D0", Offset = "0x1D806D1", VA = "0x1D805D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0x1D805E0", Offset = "0x1D806E1", VA = "0x1D805E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C85")]
		private object Current
		{
			[Token(Token = "0x6006F0B")]
			[Address(RVA = "0x1D807B0", Offset = "0x1D808B1", VA = "0x1D807B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0x1D807C0", Offset = "0x1D808C1", VA = "0x1D807C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C86")]
		private object Current
		{
			[Token(Token = "0x6006F0D")]
			[Address(RVA = "0x1D80820", Offset = "0x1D80921", VA = "0x1D80820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400643C RID: 25660
		[Token(Token = "0x40191B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400643D RID: 25661
		[Token(Token = "0x40191B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400643E RID: 25662
		[Token(Token = "0x40191B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animation playAnimation;

		// Token: 0x0400643F RID: 25663
		[Token(Token = "0x40191BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonoBehaviour self;

		// Token: 0x04006440 RID: 25664
		[Token(Token = "0x40191BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string animationName;

		// Token: 0x04006441 RID: 25665
		[Token(Token = "0x40191BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animation <anim>5__2;
	}

	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20010CB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B30", Offset = "0x157C31")]
	private sealed class <PlayAnimatorStateAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E43 RID: 7747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0x1D805A0", Offset = "0x1D806A1", VA = "0x1D805A0")]
		[DebuggerHidden]
		public <PlayAnimatorStateAsync>d__16(int <>1__state)
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0F")]
		[Address(RVA = "0x1D80830", Offset = "0x1D80931", VA = "0x1D80830", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Token(Token = "0x6006F10")]
		[Address(RVA = "0x1D80840", Offset = "0x1D80941", VA = "0x1D80840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C87")]
		private object Current
		{
			[Token(Token = "0x6006F11")]
			[Address(RVA = "0x1D80A50", Offset = "0x1D80B51", VA = "0x1D80A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0x1D80A60", Offset = "0x1D80B61", VA = "0x1D80A60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C88")]
		private object Current
		{
			[Token(Token = "0x6006F13")]
			[Address(RVA = "0x1D80AC0", Offset = "0x1D80BC1", VA = "0x1D80AC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006442 RID: 25666
		[Token(Token = "0x40191BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006443 RID: 25667
		[Token(Token = "0x40191BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006444 RID: 25668
		[Token(Token = "0x40191BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator playAnimator;

		// Token: 0x04006445 RID: 25669
		[Token(Token = "0x40191C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonoBehaviour self;

		// Token: 0x04006446 RID: 25670
		[Token(Token = "0x40191C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string stateName;

		// Token: 0x04006447 RID: 25671
		[Token(Token = "0x40191C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator <animator>5__2;
	}
}
