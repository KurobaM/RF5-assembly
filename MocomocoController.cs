using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000742 RID: 1858
[Token(Token = "0x2000506")]
public class MocomocoController : MonsterControllerBase
{
	// Token: 0x06002F68 RID: 12136 RVA: 0x00010DE8 File Offset: 0x0000EFE8
	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x1D7DDC0", Offset = "0x1D7DEC1", VA = "0x1D7DDC0", Slot = "149")]
	public override bool DoUseScissors(out float size)
	{
		return default(bool);
	}

	// Token: 0x06002F69 RID: 12137 RVA: 0x00010E00 File Offset: 0x0000F000
	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x1D7E090", Offset = "0x1D7E191", VA = "0x1D7E090", Slot = "150")]
	public override bool CanUseScissors(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x00010E18 File Offset: 0x0000F018
	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x1D7DFC0", Offset = "0x1D7E0C1", VA = "0x1D7DFC0")]
	public bool CanCutWool()
	{
		return default(bool);
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027F5")]
	[Address(RVA = "0x1D7E080", Offset = "0x1D7E181", VA = "0x1D7E080")]
	public void CutWool(bool isCreateItem = false, [Optional] Action<bool> callBack)
	{
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027F6")]
	[Address(RVA = "0x1D7E550", Offset = "0x1D7E651", VA = "0x1D7E550")]
	public void GrowWool([Optional] Action<bool> callBack)
	{
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x1D7E560", Offset = "0x1D7E661", VA = "0x1D7E560")]
	private void SpowanWoolItem()
	{
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027F8")]
	[Address(RVA = "0x1D7E1B0", Offset = "0x1D7E2B1", VA = "0x1D7E1B0")]
	private void ChangeModel(bool isWoolModel, bool isCreateItem = false, [Optional] Action<bool> callBack)
	{
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027F9")]
	[Address(RVA = "0x1D7E9A0", Offset = "0x1D7EAA1", VA = "0x1D7E9A0")]
	private void CheckDamageWool(bool isDamage, ref DamageInfo damageInfo)
	{
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x00010E30 File Offset: 0x0000F030
	[Token(Token = "0x60027FA")]
	[Address(RVA = "0x1D7EA20", Offset = "0x1D7EB21", VA = "0x1D7EA20", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027FB")]
	[Address(RVA = "0x1D7F110", Offset = "0x1D7F211", VA = "0x1D7F110")]
	public MocomocoController()
	{
	}

	// Token: 0x04007516 RID: 29974
	[Token(Token = "0x4006B8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
	private bool IsModelChanging;

	// Token: 0x02000743 RID: 1859
	[Token(Token = "0x20011C3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1585B0", Offset = "0x1586B1")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06002F72 RID: 12146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007261")]
		[Address(RVA = "0x1D7E990", Offset = "0x1D7EA91", VA = "0x1D7E990")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007262")]
		[Address(RVA = "0x1D7F390", Offset = "0x1D7F491", VA = "0x1D7F390")]
		internal void <ChangeModel>b__0(MonsterModelDataID modelDataId, GameObject model)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007263")]
		[Address(RVA = "0x1D7F710", Offset = "0x1D7F811", VA = "0x1D7F710")]
		internal void <ChangeModel>b__2()
		{
		}

		// Token: 0x04007517 RID: 29975
		[Token(Token = "0x40195F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MocomocoController <>4__this;

		// Token: 0x04007518 RID: 29976
		[Token(Token = "0x40195F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isWoolModel;

		// Token: 0x04007519 RID: 29977
		[Token(Token = "0x40195F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isCreateItem;

		// Token: 0x0400751A RID: 29978
		[Token(Token = "0x40195F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool> callBack;

		// Token: 0x0400751B RID: 29979
		[Token(Token = "0x40195F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action <>9__2;
	}

	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x20011C4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1585C0", Offset = "0x1586C1")]
	private sealed class <>c__DisplayClass7_1
	{
		// Token: 0x06002F75 RID: 12149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007264")]
		[Address(RVA = "0x1D7F600", Offset = "0x1D7F701", VA = "0x1D7F600")]
		public <>c__DisplayClass7_1()
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007265")]
		[Address(RVA = "0x1D7F800", Offset = "0x1D7F901", VA = "0x1D7F800")]
		internal void <ChangeModel>b__1()
		{
		}

		// Token: 0x0400751C RID: 29980
		[Token(Token = "0x40195FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject model;

		// Token: 0x0400751D RID: 29981
		[Token(Token = "0x40195FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MocomocoController.<>c__DisplayClass7_0 CS$<>8__locals1;
	}
}
