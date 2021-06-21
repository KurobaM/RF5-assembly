using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace RF5_Sound
{
	// Token: 0x02000EC0 RID: 3776
	[Token(Token = "0x20009A9")]
	public class SEController : AudioSourceController<SoundID>
	{
		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x000211E0 File Offset: 0x0001F3E0
		[Token(Token = "0x17000A03")]
		public override SoundID EmptyValue
		{
			[Token(Token = "0x60051BD")]
			[Address(RVA = "0x1F388F0", Offset = "0x1F389F1", VA = "0x1F388F0", Slot = "9")]
			get
			{
				return SoundID.Sound_EMPTY;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600629F RID: 25247 RVA: 0x000211F8 File Offset: 0x0001F3F8
		[Token(Token = "0x17000A04")]
		public override bool IsLoopClip
		{
			[Token(Token = "0x60051BE")]
			[Address(RVA = "0x1F38900", Offset = "0x1F38A01", VA = "0x1F38900", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BF")]
		[Address(RVA = "0x1F38370", Offset = "0x1F38471", VA = "0x1F38370", Slot = "10")]
		public override void DoPlay(SoundID id, int priority = 0)
		{
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x00021210 File Offset: 0x0001F410
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A05")]
		private bool IsLoopMode
		{
			[Token(Token = "0x60051C0")]
			[Address(RVA = "0x1F38980", Offset = "0x1F38A81", VA = "0x1F38980")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC960", Offset = "0x1ACA61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051C1")]
			[Address(RVA = "0x1F38990", Offset = "0x1F38A91", VA = "0x1F38990")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC970", Offset = "0x1ACA71")]
			set
			{
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x00021228 File Offset: 0x0001F428
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A06")]
		private bool IsOverrideLoop
		{
			[Token(Token = "0x60051C2")]
			[Address(RVA = "0x1F389A0", Offset = "0x1F38AA1", VA = "0x1F389A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC980", Offset = "0x1ACA81")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051C3")]
			[Address(RVA = "0x1F389B0", Offset = "0x1F38AB1", VA = "0x1F389B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC990", Offset = "0x1ACA91")]
			set
			{
			}
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x1F389C0", Offset = "0x1F38AC1", VA = "0x1F389C0")]
		public void OverrideLoopMode(bool isLoop)
		{
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C5")]
		[Address(RVA = "0x1F38A40", Offset = "0x1F38B41", VA = "0x1F38A40", Slot = "12")]
		protected override AudioMixerGroup GetOutputMixer(SoundID id)
		{
			return null;
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x1F38B50", Offset = "0x1F38C51", VA = "0x1F38B50", Slot = "13")]
		protected override void SetupBeforePlayByDataTable()
		{
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x1F38700", Offset = "0x1F38801", VA = "0x1F38700", Slot = "20")]
		protected override void Done_Enter()
		{
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x1F38C00", Offset = "0x1F38D01", VA = "0x1F38C00", Slot = "14")]
		protected override void Loading_Enter()
		{
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C9")]
		[Address(RVA = "0x1F388A0", Offset = "0x1F389A1", VA = "0x1F388A0")]
		public SEController()
		{
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x1F38D10", Offset = "0x1F38E11", VA = "0x1F38D10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC9A0", Offset = "0x1ACAA1")]
		private void <Loading_Enter>b__17_0(int backid, AudioClip clip)
		{
		}

		// Token: 0x0400C2C5 RID: 49861
		[Token(Token = "0x40091F4")]
		[FieldOffset(Offset = "0x7B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F2E0", Offset = "0x17F3E1")]
		private bool <IsLoopMode>k__BackingField;

		// Token: 0x0400C2C6 RID: 49862
		[Token(Token = "0x40091F5")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F2F0", Offset = "0x17F3F1")]
		private bool <IsOverrideLoop>k__BackingField;
	}
}
