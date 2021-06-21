using System;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x020005B7 RID: 1463
[Token(Token = "0x2000419")]
[Serializable]
public struct FurnitureData
{
	// Token: 0x060023D8 RID: 9176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E1E")]
	[Address(RVA = "0x2EB620", Offset = "0x2EB721", VA = "0x2EB620")]
	public FurnitureData(FurnitureID id, Prefab prefab_id, string name_id, string script_name, int hp)
	{
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E1F")]
	[Address(RVA = "0x2EB670", Offset = "0x2EB771", VA = "0x2EB670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x060023DA RID: 9178 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004AD")]
	public static FurnitureDataTableArray FurnitureDataTableArray
	{
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x23F0C90", Offset = "0x23F0D91", VA = "0x23F0C90")]
		get
		{
			return null;
		}
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
	[Token(Token = "0x6001E21")]
	[Address(RVA = "0x23F0D00", Offset = "0x23F0E01", VA = "0x23F0D00")]
	public static FurnitureData GetData(FurnitureID id)
	{
		return default(FurnitureData);
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x23F0EC0", Offset = "0x23F0FC1", VA = "0x23F0EC0")]
	public static string GetNameId(FurnitureID id)
	{
		return null;
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x23F0F40", Offset = "0x23F1041", VA = "0x23F0F40")]
	public static string GetScriptName(FurnitureID id)
	{
		return null;
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
	[Token(Token = "0x6001E24")]
	[Address(RVA = "0x23F0FC0", Offset = "0x23F10C1", VA = "0x23F0FC0")]
	public static Prefab GetPrefabId(FurnitureID id)
	{
		return Prefab.NONE;
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
	[Token(Token = "0x6001E25")]
	[Address(RVA = "0x23F1040", Offset = "0x23F1141", VA = "0x23F1040")]
	public static int GetHp(FurnitureID id)
	{
		return 0;
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E26")]
	[Address(RVA = "0x23F10C0", Offset = "0x23F11C1", VA = "0x23F10C0")]
	public static void LoadData()
	{
	}

	// Token: 0x04006B6F RID: 27503
	[Token(Token = "0x40064C6")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public FurnitureID Id;

	// Token: 0x04006B70 RID: 27504
	[Token(Token = "0x40064C7")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public Prefab PrefabId;

	// Token: 0x04006B71 RID: 27505
	[Token(Token = "0x40064C8")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public string NameId;

	// Token: 0x04006B72 RID: 27506
	[Token(Token = "0x40064C9")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string ScriptName;

	// Token: 0x04006B73 RID: 27507
	[Token(Token = "0x40064CA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Hp;

	// Token: 0x04006B74 RID: 27508
	[Token(Token = "0x40064CB")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04006B75 RID: 27509
	[Token(Token = "0x40064CC")]
	[FieldOffset(Offset = "0x8")]
	private static FurnitureDataTableArray _FurnitureDataTableArray;
}
