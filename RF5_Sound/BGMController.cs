using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace RF5_Sound
{
	// Token: 0x02000EBE RID: 3774
	[Token(Token = "0x20009A7")]
	public class BGMController : AudioSourceController<BGMID>
	{
		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x00021198 File Offset: 0x0001F398
		[Token(Token = "0x17000A00")]
		public override BGMID EmptyValue
		{
			[Token(Token = "0x60051AC")]
			[Address(RVA = "0x1F37D50", Offset = "0x1F37E51", VA = "0x1F37D50", Slot = "9")]
			get
			{
				return BGMID.BGM_EMPTY;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x000211B0 File Offset: 0x0001F3B0
		[Token(Token = "0x17000A01")]
		public override bool IsLoopClip
		{
			[Token(Token = "0x60051AD")]
			[Address(RVA = "0x1F37D60", Offset = "0x1F37E61", VA = "0x1F37D60", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AE")]
		[Address(RVA = "0x1F37DC0", Offset = "0x1F37EC1", VA = "0x1F37DC0", Slot = "12")]
		protected override AudioMixerGroup GetOutputMixer(BGMID id)
		{
			return null;
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051AF")]
		[Address(RVA = "0x1F37E40", Offset = "0x1F37F41", VA = "0x1F37E40", Slot = "14")]
		protected override void Loading_Enter()
		{
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B0")]
		[Address(RVA = "0x1F37F50", Offset = "0x1F38051", VA = "0x1F37F50", Slot = "13")]
		protected override void SetupBeforePlayByDataTable()
		{
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B1")]
		[Address(RVA = "0x1F37F60", Offset = "0x1F38061", VA = "0x1F37F60")]
		public BGMController()
		{
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B2")]
		[Address(RVA = "0x1F37FB0", Offset = "0x1F380B1", VA = "0x1F37FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC930", Offset = "0x1ACA31")]
		private void <Loading_Enter>b__5_0(int backid, AudioClip clip)
		{
		}
	}
}
