using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000505 RID: 1285
[Token(Token = "0x20003AB")]
public class CheerVoiceDataTable : ScriptableObject
{
	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000426")]
	public List<CheerVoiceData> DataTable
	{
		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x1E9E4D0", Offset = "0x1E9E5D1", VA = "0x1E9E4D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB00", Offset = "0x19FC01")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x1E9E4E0", Offset = "0x1E9E5E1", VA = "0x1E9E4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB10", Offset = "0x19FC11")]
		private set
		{
		}
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x1E9E4F0", Offset = "0x1E9E5F1", VA = "0x1E9E4F0")]
	public void Setup(List<ActorID> _festival_actor)
	{
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x1E9E8C0", Offset = "0x1E9E9C1", VA = "0x1E9E8C0")]
	public void SetupPriscillaVoice(CheerVoiceDataTable.Flag _prs_flag)
	{
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x1E9EA10", Offset = "0x1E9EB11", VA = "0x1E9EA10")]
	public void SetupChildVoice(CheerVoiceDataTable.Flag _baby_flag, CheerVoiceDataTable.Flag _child_boy_flag, CheerVoiceDataTable.Flag _child_girl_flag)
	{
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x1E9ECE0", Offset = "0x1E9EDE1", VA = "0x1E9ECE0")]
	public void RemoveKey(ActorID _actor_id)
	{
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x1E9EDB0", Offset = "0x1E9EEB1", VA = "0x1E9EDB0")]
	public void Clear()
	{
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x1E9EE20", Offset = "0x1E9EF21", VA = "0x1E9EE20")]
	public CheerVoiceDataTable()
	{
	}

	// Token: 0x04006641 RID: 26177
	[Token(Token = "0x40060A5")]
	[FieldOffset(Offset = "0x18")]
	public List<PlayerCheerVoiceData> PlayerCheerVoiceData;

	// Token: 0x04006642 RID: 26178
	[Token(Token = "0x40060A6")]
	[FieldOffset(Offset = "0x20")]
	public List<CheerVoiceData> CheerVoiceDatas;

	// Token: 0x04006643 RID: 26179
	[Token(Token = "0x40060A7")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165790", Offset = "0x165891")]
	private List<CheerVoiceData> <DataTable>k__BackingField;

	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x20010E3")]
	public enum Flag
	{
		// Token: 0x04006645 RID: 26181
		[Token(Token = "0x4019210")]
		None,
		// Token: 0x04006646 RID: 26182
		[Token(Token = "0x4019211")]
		Neutral,
		// Token: 0x04006647 RID: 26183
		[Token(Token = "0x4019212")]
		Active,
		// Token: 0x04006648 RID: 26184
		[Token(Token = "0x4019213")]
		Gentle,
		// Token: 0x04006649 RID: 26185
		[Token(Token = "0x4019214")]
		Healthy,
		// Token: 0x0400664A RID: 26186
		[Token(Token = "0x4019215")]
		Mature,
		// Token: 0x0400664B RID: 26187
		[Token(Token = "0x4019216")]
		Lady,
		// Token: 0x0400664C RID: 26188
		[Token(Token = "0x4019217")]
		Before,
		// Token: 0x0400664D RID: 26189
		[Token(Token = "0x4019218")]
		After
	}
}
