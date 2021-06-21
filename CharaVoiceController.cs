using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000217 RID: 535
[Token(Token = "0x20001B3")]
public class CharaVoiceController<T> : ActorVoiceController where T : Character
{
	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x170001DF")]
	protected virtual CharID CharID
	{
		[Token(Token = "0x60009E5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B2B0", Offset = "0x19B3B1")]
		get
		{
			return CharID.ch000;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x170001E0")]
	protected virtual int Variation
	{
		[Token(Token = "0x60009E6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B2C0", Offset = "0x19B3C1")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E1")]
	public Dictionary<VoiceGroup, CharaVoiceGroupData> VoiceTable
	{
		[Token(Token = "0x60009E7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B2D0", Offset = "0x19B3D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B2E0", Offset = "0x19B3E1")]
		private set
		{
		}
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E9")]
	protected override void Awake()
	{
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EA")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EB")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EC")]
	public void Init()
	{
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009ED")]
	protected override AudioSource ReadyAudioSourceComponent()
	{
		return null;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EE")]
	public override void DoPlayGroupVoice(VoiceGroup group)
	{
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009EF")]
	public CharaVoiceController()
	{
	}

	// Token: 0x040006DD RID: 1757
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T chara;

	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D490", Offset = "0x15D591")]
	private readonly CharID <CharID>k__BackingField;

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D4A0", Offset = "0x15D5A1")]
	private readonly int <Variation>k__BackingField;

	// Token: 0x040006E0 RID: 1760
	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D4B0", Offset = "0x15D5B1")]
	private Dictionary<VoiceGroup, CharaVoiceGroupData> <VoiceTable>k__BackingField;
}
