using System;
using Define;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;

// Token: 0x02000216 RID: 534
[Token(Token = "0x20001B2")]
public class ActorVoiceController : VoiceController
{
	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DE")]
	public static VoiceGroupDataTable VoiceGroup
	{
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1D55B10", Offset = "0x1D55C11", VA = "0x1D55B10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B290", Offset = "0x19B391")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x1D55B60", Offset = "0x1D55C61", VA = "0x1D55B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B2A0", Offset = "0x19B3A1")]
		private set
		{
		}
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x1D55BC0", Offset = "0x1D55CC1", VA = "0x1D55BC0", Slot = "21")]
	public virtual void DoPlayGroupVoice(VoiceGroup group)
	{
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x1D55BD0", Offset = "0x1D55CD1", VA = "0x1D55BD0")]
	protected SoundID GetRandomSoundID(CharaVoiceGroupData table)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x1D55DD0", Offset = "0x1D55ED1", VA = "0x1D55DD0")]
	public ActorVoiceController()
	{
	}

	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected SoundID currentSoundID;

	// Token: 0x040006DB RID: 1755
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x90")]
	protected CharaVoiceDataTable m_VoiceDataTable;

	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D470", Offset = "0x15D571")]
	private static VoiceGroupDataTable <VoiceGroup>k__BackingField;
}
