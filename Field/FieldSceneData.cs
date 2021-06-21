using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200111A RID: 4378
	[Token(Token = "0x2000B03")]
	public class FieldSceneData : ScriptableObject
	{
		// Token: 0x06006EB5 RID: 28341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0x1F8A020", Offset = "0x1F8A121", VA = "0x1F8A020")]
		public FieldSceneData()
		{
		}

		// Token: 0x0401813D RID: 98621
		[Token(Token = "0x4014BF6")]
		[FieldOffset(Offset = "0x18")]
		public FieldSceneData.Data[] Datas;

		// Token: 0x0200111B RID: 4379
		[Token(Token = "0x2001583")]
		[Serializable]
		public struct Data
		{
			// Token: 0x0401813E RID: 98622
			[Token(Token = "0x401C153")]
			[FieldOffset(Offset = "0x0")]
			public int Id;

			// Token: 0x0401813F RID: 98623
			[Token(Token = "0x401C154")]
			[FieldOffset(Offset = "0x8")]
			public string SceneName;

			// Token: 0x04018140 RID: 98624
			[Token(Token = "0x401C155")]
			[FieldOffset(Offset = "0x10")]
			public FieldPlaceId PlaceId;

			// Token: 0x04018141 RID: 98625
			[Token(Token = "0x401C156")]
			[FieldOffset(Offset = "0x14")]
			public int NamingId;

			// Token: 0x04018142 RID: 98626
			[Token(Token = "0x401C157")]
			[FieldOffset(Offset = "0x18")]
			public bool Indoor;

			// Token: 0x04018143 RID: 98627
			[Token(Token = "0x401C158")]
			[FieldOffset(Offset = "0x19")]
			public bool IsDungeon;

			// Token: 0x04018144 RID: 98628
			[Token(Token = "0x401C159")]
			[FieldOffset(Offset = "0x1A")]
			public bool IsSceneWeather;

			// Token: 0x04018145 RID: 98629
			[Token(Token = "0x401C15A")]
			[FieldOffset(Offset = "0x1B")]
			public bool InvalidSkyProfile;

			// Token: 0x04018146 RID: 98630
			[Token(Token = "0x401C15B")]
			[FieldOffset(Offset = "0x1C")]
			public bool InvalidWeatherSound;

			// Token: 0x04018147 RID: 98631
			[Token(Token = "0x401C15C")]
			[FieldOffset(Offset = "0x1D")]
			public bool Bloom;

			// Token: 0x04018148 RID: 98632
			[Token(Token = "0x401C15D")]
			[FieldOffset(Offset = "0x20")]
			public float BloomIntensity;

			// Token: 0x04018149 RID: 98633
			[Token(Token = "0x401C15E")]
			[FieldOffset(Offset = "0x24")]
			public bool UseWorldStreamer;

			// Token: 0x0401814A RID: 98634
			[Token(Token = "0x401C15F")]
			[FieldOffset(Offset = "0x25")]
			public bool CacheScene;

			// Token: 0x0401814B RID: 98635
			[Token(Token = "0x401C160")]
			[FieldOffset(Offset = "0x26")]
			public bool DoCache;

			// Token: 0x0401814C RID: 98636
			[Token(Token = "0x401C161")]
			[FieldOffset(Offset = "0x27")]
			public bool KeepScene;

			// Token: 0x0401814D RID: 98637
			[Token(Token = "0x401C162")]
			[FieldOffset(Offset = "0x28")]
			public bool IsField;

			// Token: 0x0401814E RID: 98638
			[Token(Token = "0x401C163")]
			[FieldOffset(Offset = "0x2C")]
			public int CrystalWeather;

			// Token: 0x0401814F RID: 98639
			[Token(Token = "0x401C164")]
			[FieldOffset(Offset = "0x30")]
			public int BgmType;

			// Token: 0x04018150 RID: 98640
			[Token(Token = "0x401C165")]
			[FieldOffset(Offset = "0x34")]
			public BGMID BgmId;

			// Token: 0x04018151 RID: 98641
			[Token(Token = "0x401C166")]
			[FieldOffset(Offset = "0x38")]
			public string[] AddSceneNames;

			// Token: 0x04018152 RID: 98642
			[Token(Token = "0x401C167")]
			[FieldOffset(Offset = "0x40")]
			public ItemLevelWeightID LevelWeightID;

			// Token: 0x04018153 RID: 98643
			[Token(Token = "0x401C168")]
			[FieldOffset(Offset = "0x44")]
			public int EquipItemLevelCap;
		}
	}
}
