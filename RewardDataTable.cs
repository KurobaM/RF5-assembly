using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000474 RID: 1140
[Token(Token = "0x200036D")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145E10", Offset = "0x145F11")]
[Serializable]
public class RewardDataTable : ScriptableObject
{
	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000407")]
	public List<RewardData> RewardDatas
	{
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x2492C40", Offset = "0x2492D41", VA = "0x2492C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x2492C50", Offset = "0x2492D51", VA = "0x2492C50")]
	public RewardDataTable()
	{
	}

	// Token: 0x04006090 RID: 24720
	[Token(Token = "0x4005C8A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<RewardData> rewardDatas;
}
