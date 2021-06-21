using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004DB RID: 1243
[Token(Token = "0x2000392")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145F20", Offset = "0x146021")]
[Serializable]
public class FarmCropsDataTable : ScriptableObject
{
	// Token: 0x06001E8E RID: 7822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x21A8000", Offset = "0x21A8101", VA = "0x21A8000")]
	public FarmCropsDataTable()
	{
	}

	// Token: 0x04006564 RID: 25956
	[Token(Token = "0x4006004")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int ClopId;

	// Token: 0x04006565 RID: 25957
	[Token(Token = "0x4006005")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int SeedId;

	// Token: 0x04006566 RID: 25958
	[Token(Token = "0x4006006")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int ItemID;

	// Token: 0x04006567 RID: 25959
	[Token(Token = "0x4006007")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int mDay_SeedToSprout;

	// Token: 0x04006568 RID: 25960
	[Token(Token = "0x4006008")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int mDay_SproutToLeaf1;

	// Token: 0x04006569 RID: 25961
	[Token(Token = "0x4006009")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int mDay_Leaf1ToLeaf2;

	// Token: 0x0400656A RID: 25962
	[Token(Token = "0x400600A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int mDay_Leaf2ToFruits;

	// Token: 0x0400656B RID: 25963
	[Token(Token = "0x400600B")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int mAppRate;

	// Token: 0x0400656C RID: 25964
	[Token(Token = "0x400600C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int mHp;

	// Token: 0x0400656D RID: 25965
	[Token(Token = "0x400600D")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int mSize;

	// Token: 0x0400656E RID: 25966
	[Token(Token = "0x400600E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int mRepeat;

	// Token: 0x0400656F RID: 25967
	[Token(Token = "0x400600F")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public int mDefNum;

	// Token: 0x04006570 RID: 25968
	[Token(Token = "0x4006010")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int mDefense;

	// Token: 0x04006571 RID: 25969
	[Token(Token = "0x4006011")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int mRune;

	// Token: 0x04006572 RID: 25970
	[Token(Token = "0x4006012")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public int mDamage;

	// Token: 0x04006573 RID: 25971
	[Token(Token = "0x4006013")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public int mExp;

	// Token: 0x04006574 RID: 25972
	[Token(Token = "0x4006014")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public int mExpSpd;

	// Token: 0x04006575 RID: 25973
	[Token(Token = "0x4006015")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public int mExpLevel;

	// Token: 0x04006576 RID: 25974
	[Token(Token = "0x4006016")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int mExpSize;

	// Token: 0x04006577 RID: 25975
	[Token(Token = "0x4006017")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public int mExpNum;

	// Token: 0x04006578 RID: 25976
	[Token(Token = "0x4006018")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public int mRateSpd;

	// Token: 0x04006579 RID: 25977
	[Token(Token = "0x4006019")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public int mRateLevel;

	// Token: 0x0400657A RID: 25978
	[Token(Token = "0x400601A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public int mRateSize;

	// Token: 0x0400657B RID: 25979
	[Token(Token = "0x400601B")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public int mRateNum;

	// Token: 0x0400657C RID: 25980
	[Token(Token = "0x400601C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public int mDamageSpd;

	// Token: 0x0400657D RID: 25981
	[Token(Token = "0x400601D")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public int mDamageLevel;

	// Token: 0x0400657E RID: 25982
	[Token(Token = "0x400601E")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public int mDamageSize;

	// Token: 0x0400657F RID: 25983
	[Token(Token = "0x400601F")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public int mDamageNum;

	// Token: 0x04006580 RID: 25984
	[Token(Token = "0x4006020")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public ItemID mItemID;

	// Token: 0x04006581 RID: 25985
	[Token(Token = "0x4006021")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	public ItemID mSeedID;

	// Token: 0x04006582 RID: 25986
	[Token(Token = "0x4006022")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public int mType;
}
