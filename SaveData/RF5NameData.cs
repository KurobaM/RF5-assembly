using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED6 RID: 3798
	[Token(Token = "0x20009B7")]
	public class RF5NameData : SaveDataValueBase
	{
		// Token: 0x06006346 RID: 25414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005257")]
		[Address(RVA = "0x1F03930", Offset = "0x1F03A31", VA = "0x1F03930")]
		public RF5NameData()
		{
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005258")]
		[Address(RVA = "0x1F03960", Offset = "0x1F03A61", VA = "0x1F03960", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005259")]
		[Address(RVA = "0x1F03970", Offset = "0x1F03A71", VA = "0x1F03970", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525A")]
		[Address(RVA = "0x1F03980", Offset = "0x1F03A81", VA = "0x1F03980", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525B")]
		[Address(RVA = "0x1F03990", Offset = "0x1F03A91", VA = "0x1F03990", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525C")]
		[Address(RVA = "0x1F03AE0", Offset = "0x1F03BE1", VA = "0x1F03AE0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C320 RID: 49952
		[Token(Token = "0x400922F")]
		[FieldOffset(Offset = "0x10")]
		public string Name_Farm_Soil;

		// Token: 0x0400C321 RID: 49953
		[Token(Token = "0x4009230")]
		[FieldOffset(Offset = "0x18")]
		public string Name_Farm_Fire;

		// Token: 0x0400C322 RID: 49954
		[Token(Token = "0x4009231")]
		[FieldOffset(Offset = "0x20")]
		public string Name_Farm_Ice;

		// Token: 0x0400C323 RID: 49955
		[Token(Token = "0x4009232")]
		[FieldOffset(Offset = "0x28")]
		public string Name_Farm_Wind;

		// Token: 0x0400C324 RID: 49956
		[Token(Token = "0x4009233")]
		[FieldOffset(Offset = "0x30")]
		public string Name_Farm_Ground;

		// Token: 0x0400C325 RID: 49957
		[Token(Token = "0x4009234")]
		[FieldOffset(Offset = "0x38")]
		public string Name_FarmPet_Soil_A;

		// Token: 0x0400C326 RID: 49958
		[Token(Token = "0x4009235")]
		[FieldOffset(Offset = "0x40")]
		public string Name_FarmPet_Soil_B;

		// Token: 0x0400C327 RID: 49959
		[Token(Token = "0x4009236")]
		[FieldOffset(Offset = "0x48")]
		public string Name_FarmPet_Fire_A;

		// Token: 0x0400C328 RID: 49960
		[Token(Token = "0x4009237")]
		[FieldOffset(Offset = "0x50")]
		public string Name_FarmPet_Fire_B;

		// Token: 0x0400C329 RID: 49961
		[Token(Token = "0x4009238")]
		[FieldOffset(Offset = "0x58")]
		public string Name_FarmPet_Ice_A;

		// Token: 0x0400C32A RID: 49962
		[Token(Token = "0x4009239")]
		[FieldOffset(Offset = "0x60")]
		public string Name_FarmPet_Ice_B;

		// Token: 0x0400C32B RID: 49963
		[Token(Token = "0x400923A")]
		[FieldOffset(Offset = "0x68")]
		public string Name_FarmPet_Wind_A;

		// Token: 0x0400C32C RID: 49964
		[Token(Token = "0x400923B")]
		[FieldOffset(Offset = "0x70")]
		public string Name_FarmPet_Wind_B;

		// Token: 0x0400C32D RID: 49965
		[Token(Token = "0x400923C")]
		[FieldOffset(Offset = "0x78")]
		public string Name_FarmPet_Ground_A;

		// Token: 0x0400C32E RID: 49966
		[Token(Token = "0x400923D")]
		[FieldOffset(Offset = "0x80")]
		public string Name_FarmPet_Ground_B;
	}
}
