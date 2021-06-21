using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200094C RID: 2380
[Token(Token = "0x200063B")]
public class UIFaceIconLoader : MonoBehaviour
{
	// Token: 0x06003F15 RID: 16149 RVA: 0x00015768 File Offset: 0x00013968
	[Token(Token = "0x6003470")]
	[Address(RVA = "0x200F9D0", Offset = "0x200FAD1", VA = "0x200F9D0")]
	private int GetCharaNo(NPCID npcid)
	{
		return 0;
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003471")]
	[Address(RVA = "0x200FBD0", Offset = "0x200FCD1", VA = "0x200FBD0")]
	private string GetCharaIconPath(NPCID npcid)
	{
		return null;
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003472")]
	[Address(RVA = "0x2010200", Offset = "0x2010301", VA = "0x2010200")]
	public void SetFaceIcon(NPCID npcid)
	{
	}

	// Token: 0x06003F18 RID: 16152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003473")]
	[Address(RVA = "0x2010360", Offset = "0x2010461", VA = "0x2010360")]
	public void SetFaceIcon(MonsterID monsterId)
	{
	}

	// Token: 0x06003F19 RID: 16153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003474")]
	[Address(RVA = "0x20104E0", Offset = "0x20105E1", VA = "0x20104E0")]
	public UIFaceIconLoader()
	{
	}

	// Token: 0x0400809D RID: 32925
	[Token(Token = "0x40073D2")]
	[FieldOffset(Offset = "0x18")]
	private readonly int[] HUDFaceIdTable;
}
