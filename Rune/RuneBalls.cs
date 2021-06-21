using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace Rune
{
	// Token: 0x0200107E RID: 4222
	[Token(Token = "0x2000AB1")]
	public class RuneBalls : MonoBehaviour
	{
		// Token: 0x06006AA0 RID: 27296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x1EF3190", Offset = "0x1EF3291", VA = "0x1EF3190")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x1EF37F0", Offset = "0x1EF38F1", VA = "0x1EF37F0")]
		private void rf3RuneBallDefaultInit(RuneType type_index, float x, float y, float z)
		{
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x1EF3990", Offset = "0x1EF3A91", VA = "0x1EF3990")]
		public void rf3RuneBallRockInit(float x, float y, float z)
		{
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x1EF39C0", Offset = "0x1EF3AC1", VA = "0x1EF39C0")]
		public void rf3RuneBallFlowerInit(float x, float y, float z)
		{
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x1EF39F0", Offset = "0x1EF3AF1", VA = "0x1EF39F0")]
		public void rf3RuneBallInit(float x, float y, float z, bool isBoost = false)
		{
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x1EF33C0", Offset = "0x1EF34C1", VA = "0x1EF33C0")]
		public void rf3RuneBallSkillUp()
		{
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x1EF3900", Offset = "0x1EF3A01", VA = "0x1EF3900")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADBE0", Offset = "0x1ADCE1")]
		private IEnumerator rf3RuneBallMain(RuneType _runeType = RuneType.Ball)
		{
			return null;
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x1EF3710", Offset = "0x1EF3811", VA = "0x1EF3710")]
		private void DestroyParticle()
		{
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x1EF3B70", Offset = "0x1EF3C71", VA = "0x1EF3B70")]
		public RuneBalls()
		{
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x1EF3B90", Offset = "0x1EF3C91", VA = "0x1EF3B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADC50", Offset = "0x1ADD51")]
		private void <rf3RuneBallMain>b__19_0(ParticleSystem ps)
		{
		}

		// Token: 0x0401729E RID: 94878
		[Token(Token = "0x4013E9A")]
		private const int RF3_RUNE_BALL_FLOWER_RP = -25;

		// Token: 0x0401729F RID: 94879
		[Token(Token = "0x4013E9B")]
		private const int RF3_RUNE_BALL_ROCK_RP = -33;

		// Token: 0x040172A0 RID: 94880
		[Token(Token = "0x4013E9C")]
		private const int RF3_RUNE_BALL_RP = -50;

		// Token: 0x040172A1 RID: 94881
		[Token(Token = "0x4013E9D")]
		private const int RF3_RUNE_BALL_ROONEY = -80;

		// Token: 0x040172A2 RID: 94882
		[Token(Token = "0x4013E9E")]
		private const int RFD_RUNE_DELETE_TIME = 3600;

		// Token: 0x040172A3 RID: 94883
		[Token(Token = "0x4013E9F")]
		[FieldOffset(Offset = "0x0")]
		private static byte _rf_rune_cout;

		// Token: 0x040172A4 RID: 94884
		[Token(Token = "0x4013EA0")]
		[FieldOffset(Offset = "0x18")]
		private int availableCounter;

		// Token: 0x040172A5 RID: 94885
		[Token(Token = "0x4013EA1")]
		[FieldOffset(Offset = "0x1C")]
		private int damage;

		// Token: 0x040172A6 RID: 94886
		[Token(Token = "0x4013EA2")]
		[FieldOffset(Offset = "0x20")]
		private ParticleSystem _particleSystem;

		// Token: 0x040172A7 RID: 94887
		[Token(Token = "0x4013EA3")]
		[FieldOffset(Offset = "0x28")]
		private EffectID vanishId;

		// Token: 0x040172A8 RID: 94888
		[Token(Token = "0x4013EA4")]
		[FieldOffset(Offset = "0x2C")]
		private RuneType runeType;

		// Token: 0x040172A9 RID: 94889
		[Token(Token = "0x4013EA5")]
		[FieldOffset(Offset = "0x30")]
		private bool triggered;

		// Token: 0x040172AA RID: 94890
		[Token(Token = "0x4013EA6")]
		[FieldOffset(Offset = "0x31")]
		private bool effectPlayed;

		// Token: 0x0200107F RID: 4223
		[Token(Token = "0x2001539")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D40", Offset = "0x159E41")]
		private sealed class <rf3RuneBallMain>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006AAB RID: 27307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C8A")]
			[Address(RVA = "0x1EF3B40", Offset = "0x1EF3C41", VA = "0x1EF3B40")]
			[DebuggerHidden]
			public <rf3RuneBallMain>d__19(int <>1__state)
			{
			}

			// Token: 0x06006AAC RID: 27308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C8B")]
			[Address(RVA = "0x1EF3C20", Offset = "0x1EF3D21", VA = "0x1EF3C20", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006AAD RID: 27309 RVA: 0x00024708 File Offset: 0x00022908
			[Token(Token = "0x6007C8C")]
			[Address(RVA = "0x1EF3C30", Offset = "0x1EF3D31", VA = "0x1EF3C30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06006AAE RID: 27310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E99")]
			private object Current
			{
				[Token(Token = "0x6007C8D")]
				[Address(RVA = "0x1EF3F10", Offset = "0x1EF4011", VA = "0x1EF3F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006AAF RID: 27311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C8E")]
			[Address(RVA = "0x1EF3F20", Offset = "0x1EF4021", VA = "0x1EF3F20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E9A")]
			private object Current
			{
				[Token(Token = "0x6007C8F")]
				[Address(RVA = "0x1EF3F80", Offset = "0x1EF4081", VA = "0x1EF3F80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172AB RID: 94891
			[Token(Token = "0x401C010")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172AC RID: 94892
			[Token(Token = "0x401C011")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172AD RID: 94893
			[Token(Token = "0x401C012")]
			[FieldOffset(Offset = "0x20")]
			public RuneBalls <>4__this;

			// Token: 0x040172AE RID: 94894
			[Token(Token = "0x401C013")]
			[FieldOffset(Offset = "0x28")]
			public RuneType _runeType;
		}
	}
}
