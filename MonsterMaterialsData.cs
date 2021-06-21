using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000687 RID: 1671
[Token(Token = "0x20004AA")]
[Serializable]
public class MonsterMaterialsData : ScriptableObject
{
	// Token: 0x0600291E RID: 10526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x1E6D7B0", Offset = "0x1E6D8B1", VA = "0x1E6D7B0")]
	public Material GetMaterial(string materialName, int No)
	{
		return null;
	}

	// Token: 0x0600291F RID: 10527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022C2")]
	[Address(RVA = "0x1E6DAF0", Offset = "0x1E6DBF1", VA = "0x1E6DAF0")]
	public MonsterMaterialsData()
	{
	}

	// Token: 0x040070E7 RID: 28903
	[Token(Token = "0x40068E5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Material[] MaterialArray;

	// Token: 0x02000688 RID: 1672
	[Token(Token = "0x2001166")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158240", Offset = "0x158341")]
	private sealed class <>c__DisplayClass1_0
	{
		// Token: 0x06002920 RID: 10528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007148")]
		[Address(RVA = "0x1E6DAE0", Offset = "0x1E6DBE1", VA = "0x1E6DAE0")]
		public <>c__DisplayClass1_0()
		{
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x6007149")]
		[Address(RVA = "0x1E6DB00", Offset = "0x1E6DC01", VA = "0x1E6DB00")]
		internal bool <GetMaterial>b__0(Material datamaterial)
		{
			return default(bool);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x600714A")]
		[Address(RVA = "0x1E6DB40", Offset = "0x1E6DC41", VA = "0x1E6DB40")]
		internal bool <GetMaterial>b__1(Material datamaterial)
		{
			return default(bool);
		}

		// Token: 0x040070E8 RID: 28904
		[Token(Token = "0x4019475")]
		[FieldOffset(Offset = "0x10")]
		public string oriMaterialName;

		// Token: 0x040070E9 RID: 28905
		[Token(Token = "0x4019476")]
		[FieldOffset(Offset = "0x18")]
		public StringBuilder stringBuilder;
	}
}
