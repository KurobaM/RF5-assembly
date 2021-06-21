using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007E1 RID: 2017
[Token(Token = "0x2000539")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1462B0", Offset = "0x1463B1")]
[Serializable]
public class ChildData
{
	// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x1E9EE30", Offset = "0x1E9EF31", VA = "0x1E9EE30")]
	public void Initialize()
	{
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x1E9EEA0", Offset = "0x1E9EFA1", VA = "0x1E9EEA0")]
	public void SetName(string name)
	{
	}

	// Token: 0x060034BE RID: 13502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x1E9EEB0", Offset = "0x1E9EFB1", VA = "0x1E9EEB0")]
	public void SetIsMale(bool isMale)
	{
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x1E9EEC0", Offset = "0x1E9EFC1", VA = "0x1E9EEC0")]
	public void SetBirthDay(int season, int day)
	{
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x1E9EED0", Offset = "0x1E9EFD1", VA = "0x1E9EED0")]
	public void SetData(ChildData data)
	{
	}

	// Token: 0x060034C1 RID: 13505 RVA: 0x00011F58 File Offset: 0x00010158
	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x1E9EF20", Offset = "0x1E9F021", VA = "0x1E9EF20")]
	public int GetPersonalityByGender()
	{
		return 0;
	}

	// Token: 0x060034C2 RID: 13506 RVA: 0x00011F70 File Offset: 0x00010170
	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x1E9EF50", Offset = "0x1E9F051", VA = "0x1E9EF50")]
	public bool IsBorn()
	{
		return default(bool);
	}

	// Token: 0x060034C3 RID: 13507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x1E9EF60", Offset = "0x1E9F061", VA = "0x1E9EF60")]
	public void SetGender(int select)
	{
	}

	// Token: 0x060034C4 RID: 13508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x1E9EFB0", Offset = "0x1E9F0B1", VA = "0x1E9EFB0")]
	public void SetPersonality(int p)
	{
	}

	// Token: 0x060034C5 RID: 13509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x1E9F0D0", Offset = "0x1E9F1D1", VA = "0x1E9F0D0")]
	public void SetPersonalityByGender(int p)
	{
	}

	// Token: 0x060034C6 RID: 13510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x1E9F200", Offset = "0x1E9F301", VA = "0x1E9F200")]
	public void SetRandomPersonality()
	{
	}

	// Token: 0x060034C7 RID: 13511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x1E9F240", Offset = "0x1E9F341", VA = "0x1E9F240")]
	public ChildData()
	{
	}

	// Token: 0x0400786E RID: 30830
	[Token(Token = "0x4006D54")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x169F00", Offset = "0x16A001")]
	[SerializeField]
	public string Name;

	// Token: 0x0400786F RID: 30831
	[Token(Token = "0x4006D55")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x169F50", Offset = "0x16A051")]
	[SerializeField]
	public bool IsMale;

	// Token: 0x04007870 RID: 30832
	[Token(Token = "0x4006D56")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x169FA0", Offset = "0x16A0A1")]
	[SerializeField]
	public int Personality;

	// Token: 0x04007871 RID: 30833
	[Token(Token = "0x4006D57")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x169FF0", Offset = "0x16A0F1")]
	[SerializeField]
	public int BirthDay;
}
