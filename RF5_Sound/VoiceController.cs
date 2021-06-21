using System;
using Il2CppDummyDll;
using RF5Subtitle;
using UnityEngine;
using UnityEngine.Audio;

namespace RF5_Sound
{
	// Token: 0x02000EC1 RID: 3777
	[Token(Token = "0x20009AA")]
	public class VoiceController : AudioSourceController<SoundID>
	{
		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060062AC RID: 25260 RVA: 0x00021240 File Offset: 0x0001F440
		[Token(Token = "0x17000A07")]
		public override SoundID EmptyValue
		{
			[Token(Token = "0x60051CB")]
			[Address(RVA = "0x1F38DD0", Offset = "0x1F38ED1", VA = "0x1F38DD0", Slot = "9")]
			get
			{
				return SoundID.Sound_EMPTY;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060062AD RID: 25261 RVA: 0x00021258 File Offset: 0x0001F458
		[Token(Token = "0x17000A08")]
		public override bool IsLoopClip
		{
			[Token(Token = "0x60051CC")]
			[Address(RVA = "0x1F38DE0", Offset = "0x1F38EE1", VA = "0x1F38DE0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x1F38E40", Offset = "0x1F38F41", VA = "0x1F38E40", Slot = "12")]
		protected override AudioMixerGroup GetOutputMixer(SoundID id)
		{
			return null;
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x1F38EC0", Offset = "0x1F38FC1", VA = "0x1F38EC0", Slot = "13")]
		protected override void SetupBeforePlayByDataTable()
		{
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x1F38F70", Offset = "0x1F39071", VA = "0x1F38F70", Slot = "14")]
		protected override void Loading_Enter()
		{
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D0")]
		[Address(RVA = "0x1F39080", Offset = "0x1F39181", VA = "0x1F39080", Slot = "15")]
		protected override void Play_Enter()
		{
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D1")]
		[Address(RVA = "0x1F39150", Offset = "0x1F39251", VA = "0x1F39150", Slot = "20")]
		protected override void Done_Enter()
		{
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x1F391D0", Offset = "0x1F392D1", VA = "0x1F391D0")]
		public VoiceController()
		{
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D3")]
		[Address(RVA = "0x1F39220", Offset = "0x1F39321", VA = "0x1F39220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC9B0", Offset = "0x1ACAB1")]
		private void <Loading_Enter>b__6_0(int backid, AudioClip clip)
		{
		}

		// Token: 0x0400C2C7 RID: 49863
		[Token(Token = "0x40091F6")]
		[FieldOffset(Offset = "0x80")]
		private SubtitleHandler handler;
	}
}
