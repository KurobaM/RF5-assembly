using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace DG.Tweening
{
	// Token: 0x020015F9 RID: 5625
	[Token(Token = "0x2000F7C")]
	public static class DOTweenModuleAudio
	{
		// Token: 0x0600803C RID: 32828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0x20EEF80", Offset = "0x20EF081", VA = "0x20EEF80")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7B")]
		[Address(RVA = "0x20EF100", Offset = "0x20EF201", VA = "0x20EF100")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7C")]
		[Address(RVA = "0x20EF260", Offset = "0x20EF361", VA = "0x20EF260")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x0002E098 File Offset: 0x0002C298
		[Token(Token = "0x6006A7D")]
		[Address(RVA = "0x20EF3D0", Offset = "0x20EF4D1", VA = "0x20EF3D0")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return 0;
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		[Token(Token = "0x6006A7E")]
		[Address(RVA = "0x20EF450", Offset = "0x20EF551", VA = "0x20EF450")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return 0;
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		[Token(Token = "0x6006A7F")]
		[Address(RVA = "0x20EF4D0", Offset = "0x20EF5D1", VA = "0x20EF4D0")]
		public static int DOFlip(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x0002E0E0 File Offset: 0x0002C2E0
		[Token(Token = "0x6006A80")]
		[Address(RVA = "0x20EF540", Offset = "0x20EF641", VA = "0x20EF540")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return 0;
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
		[Token(Token = "0x6006A81")]
		[Address(RVA = "0x20EF5D0", Offset = "0x20EF6D1", VA = "0x20EF5D0")]
		public static int DOPause(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x0002E110 File Offset: 0x0002C310
		[Token(Token = "0x6006A82")]
		[Address(RVA = "0x20EF640", Offset = "0x20EF741", VA = "0x20EF640")]
		public static int DOPlay(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x0002E128 File Offset: 0x0002C328
		[Token(Token = "0x6006A83")]
		[Address(RVA = "0x20EF6B0", Offset = "0x20EF7B1", VA = "0x20EF6B0")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x0002E140 File Offset: 0x0002C340
		[Token(Token = "0x6006A84")]
		[Address(RVA = "0x20EF720", Offset = "0x20EF821", VA = "0x20EF720")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x0002E158 File Offset: 0x0002C358
		[Token(Token = "0x6006A85")]
		[Address(RVA = "0x20EF790", Offset = "0x20EF891", VA = "0x20EF790")]
		public static int DORestart(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x0002E170 File Offset: 0x0002C370
		[Token(Token = "0x6006A86")]
		[Address(RVA = "0x20EF800", Offset = "0x20EF901", VA = "0x20EF800")]
		public static int DORewind(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x0002E188 File Offset: 0x0002C388
		[Token(Token = "0x6006A87")]
		[Address(RVA = "0x20EF870", Offset = "0x20EF971", VA = "0x20EF870")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
		[Token(Token = "0x6006A88")]
		[Address(RVA = "0x20EF8E0", Offset = "0x20EF9E1", VA = "0x20EF8E0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return 0;
		}

		// Token: 0x020015FA RID: 5626
		[Token(Token = "0x20015CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA00", Offset = "0x15AB01")]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x0600804B RID: 32843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FCF")]
			[Address(RVA = "0x20EF0F0", Offset = "0x20EF1F1", VA = "0x20EF0F0")]
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x0600804C RID: 32844 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
			[Token(Token = "0x6007FD0")]
			[Address(RVA = "0x20EF950", Offset = "0x20EFA51", VA = "0x20EF950")]
			internal float <DOFade>b__0()
			{
				return 0f;
			}

			// Token: 0x0600804D RID: 32845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD1")]
			[Address(RVA = "0x20EF970", Offset = "0x20EFA71", VA = "0x20EF970")]
			internal void <DOFade>b__1(float x)
			{
			}

			// Token: 0x0401C1A8 RID: 115112
			[Token(Token = "0x401C38A")]
			[FieldOffset(Offset = "0x10")]
			public AudioSource target;
		}

		// Token: 0x020015FB RID: 5627
		[Token(Token = "0x20015CF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA10", Offset = "0x15AB11")]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x0600804E RID: 32846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD2")]
			[Address(RVA = "0x20EF250", Offset = "0x20EF351", VA = "0x20EF250")]
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x0600804F RID: 32847 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
			[Token(Token = "0x6007FD3")]
			[Address(RVA = "0x20EF990", Offset = "0x20EFA91", VA = "0x20EF990")]
			internal float <DOPitch>b__0()
			{
				return 0f;
			}

			// Token: 0x06008050 RID: 32848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD4")]
			[Address(RVA = "0x20EF9B0", Offset = "0x20EFAB1", VA = "0x20EF9B0")]
			internal void <DOPitch>b__1(float x)
			{
			}

			// Token: 0x0401C1A9 RID: 115113
			[Token(Token = "0x401C38B")]
			[FieldOffset(Offset = "0x10")]
			public AudioSource target;
		}

		// Token: 0x020015FC RID: 5628
		[Token(Token = "0x20015D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA20", Offset = "0x15AB21")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06008051 RID: 32849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD5")]
			[Address(RVA = "0x20EF3C0", Offset = "0x20EF4C1", VA = "0x20EF3C0")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06008052 RID: 32850 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
			[Token(Token = "0x6007FD6")]
			[Address(RVA = "0x20EF9D0", Offset = "0x20EFAD1", VA = "0x20EF9D0")]
			internal float <DOSetFloat>b__0()
			{
				return 0f;
			}

			// Token: 0x06008053 RID: 32851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD7")]
			[Address(RVA = "0x20EFA10", Offset = "0x20EFB11", VA = "0x20EFA10")]
			internal void <DOSetFloat>b__1(float x)
			{
			}

			// Token: 0x0401C1AA RID: 115114
			[Token(Token = "0x401C38C")]
			[FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			// Token: 0x0401C1AB RID: 115115
			[Token(Token = "0x401C38D")]
			[FieldOffset(Offset = "0x18")]
			public string floatName;
		}
	}
}
