using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000862 RID: 2146
[Token(Token = "0x2000586")]
[Attribute(Name = "UnionAttribute", RVA = "0x146720", Offset = "0x146821")]
[Attribute(Name = "UnionAttribute", RVA = "0x146720", Offset = "0x146821")]
[Attribute(Name = "UnionAttribute", RVA = "0x146720", Offset = "0x146821")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146720", Offset = "0x146821")]
public abstract class StatusDataBase
{
	// Token: 0x060038CE RID: 14542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F52")]
	[Address(RVA = "0x238ABD0", Offset = "0x238ACD1", VA = "0x238ABD0")]
	protected StatusDataBase()
	{
	}

	// Token: 0x04007C1A RID: 31770
	[Token(Token = "0x400702D")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D300", Offset = "0x16D401")]
	public int Level;

	// Token: 0x04007C1B RID: 31771
	[Token(Token = "0x400702E")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D320", Offset = "0x16D421")]
	public int Exp;

	// Token: 0x04007C1C RID: 31772
	[Token(Token = "0x400702F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D340", Offset = "0x16D441")]
	public int Hp;

	// Token: 0x04007C1D RID: 31773
	[Token(Token = "0x4007030")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D360", Offset = "0x16D461")]
	public int Rp;

	// Token: 0x04007C1E RID: 31774
	[Token(Token = "0x4007031")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D380", Offset = "0x16D481")]
	public Parameter SaveParameter;

	// Token: 0x04007C1F RID: 31775
	[Token(Token = "0x4007032")]
	[FieldOffset(Offset = "0xDC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D3A0", Offset = "0x16D4A1")]
	public BadStatus BadStatus;

	// Token: 0x04007C20 RID: 31776
	[Token(Token = "0x4007033")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D3C0", Offset = "0x16D4C1")]
	public ItemData TemporaryStatus_UseItem;

	// Token: 0x04007C21 RID: 31777
	[Token(Token = "0x4007034")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D3E0", Offset = "0x16D4E1")]
	public int TemporaryStatus_UseItem_Time;

	// Token: 0x04007C22 RID: 31778
	[Token(Token = "0x4007035")]
	[FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D400", Offset = "0x16D501")]
	public HotSpringID TemporaryStatus_HotSpring;

	// Token: 0x04007C23 RID: 31779
	[Token(Token = "0x4007036")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D420", Offset = "0x16D521")]
	public int TemporaryStatus_HotSpring_Time;

	// Token: 0x04007C24 RID: 31780
	[Token(Token = "0x4007037")]
	[FieldOffset(Offset = "0xF4")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D440", Offset = "0x16D541")]
	public VaccinationID TemporaryStatus_Vaccination;

	// Token: 0x04007C25 RID: 31781
	[Token(Token = "0x4007038")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D460", Offset = "0x16D561")]
	public int TemporaryStatus_Vaccination_Time;

	// Token: 0x04007C26 RID: 31782
	[Token(Token = "0x4007039")]
	[FieldOffset(Offset = "0xFC")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D480", Offset = "0x16D581")]
	public int Score_ATKUp_Level;

	// Token: 0x04007C27 RID: 31783
	[Token(Token = "0x400703A")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D4A0", Offset = "0x16D5A1")]
	public int Score_ATKUp_Time;

	// Token: 0x04007C28 RID: 31784
	[Token(Token = "0x400703B")]
	[FieldOffset(Offset = "0x104")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D4C0", Offset = "0x16D5C1")]
	public int Score_DEFUp_Level;

	// Token: 0x04007C29 RID: 31785
	[Token(Token = "0x400703C")]
	[FieldOffset(Offset = "0x108")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16D4E0", Offset = "0x16D5E1")]
	public int Score_DEFUp_Time;
}
