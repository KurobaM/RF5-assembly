using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020008A9 RID: 2217
[Token(Token = "0x20005BF")]
public class InstantStatus : StatusBase
{
	// Token: 0x06003AB5 RID: 15029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003123")]
	[Address(RVA = "0x22319F0", Offset = "0x2231AF1", VA = "0x22319F0")]
	public InstantStatus(Parameter parameter)
	{
	}

	// Token: 0x17000854 RID: 2132
	// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x000147F0 File Offset: 0x000129F0
	[Token(Token = "0x17000699")]
	public override Alliance Alliance
	{
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x2231AD0", Offset = "0x2231BD1", VA = "0x2231AD0", Slot = "6")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x06003AB7 RID: 15031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003125")]
	[Address(RVA = "0x2231AE0", Offset = "0x2231BE1", VA = "0x2231AE0")]
	public void SetAlliance(Alliance alliance)
	{
	}

	// Token: 0x17000855 RID: 2133
	// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x00014808 File Offset: 0x00012A08
	// (set) Token: 0x06003AB9 RID: 15033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700069A")]
	public override int Hp
	{
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x2231AF0", Offset = "0x2231BF1", VA = "0x2231AF0", Slot = "8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A62E0", Offset = "0x1A63E1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x2231B00", Offset = "0x2231C01", VA = "0x2231B00", Slot = "9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A62F0", Offset = "0x1A63F1")]
		set
		{
		}
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x00014820 File Offset: 0x00012A20
	[Token(Token = "0x6003128")]
	[Address(RVA = "0x2231B10", Offset = "0x2231C11", VA = "0x2231B10", Slot = "12")]
	public override ValueTuple<Parameter, EquipSubAttributeCollection> CalcCurrentParameter(HumanEquip humanEquip, bool isWeapon)
	{
		return default(ValueTuple<Parameter, EquipSubAttributeCollection>);
	}

	// Token: 0x04007D9F RID: 32159
	[Token(Token = "0x4007191")]
	[FieldOffset(Offset = "0xF0")]
	private Parameter InstantParameter;

	// Token: 0x04007DA0 RID: 32160
	[Token(Token = "0x4007192")]
	[FieldOffset(Offset = "0x1AC")]
	private Alliance _Alliance;

	// Token: 0x04007DA1 RID: 32161
	[Token(Token = "0x4007193")]
	[FieldOffset(Offset = "0x1B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E580", Offset = "0x16E681")]
	private int <Hp>k__BackingField;
}
