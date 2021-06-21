using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200073C RID: 1852
[Token(Token = "0x2000503")]
public class LastBossBone : MonoBehaviour
{
	// Token: 0x06002F44 RID: 12100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027D2")]
	[Address(RVA = "0x2307150", Offset = "0x2307251", VA = "0x2307150")]
	private void Start()
	{
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027D3")]
	[Address(RVA = "0x2307580", Offset = "0x2307681", VA = "0x2307580")]
	private void Update()
	{
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027D4")]
	[Address(RVA = "0x2307760", Offset = "0x2307861", VA = "0x2307760")]
	public void FadeOut(float duration)
	{
	}

	// Token: 0x06002F47 RID: 12103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027D5")]
	[Address(RVA = "0x23073A0", Offset = "0x23074A1", VA = "0x23073A0")]
	private void SetEnableDither(Material material, bool enable)
	{
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027D6")]
	[Address(RVA = "0x2307490", Offset = "0x2307591", VA = "0x2307490")]
	private void SetEnableDitherAlpha(Material material, bool enable)
	{
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027D7")]
	[Address(RVA = "0x2307770", Offset = "0x2307871", VA = "0x2307770")]
	public LastBossBone()
	{
	}

	// Token: 0x040074DC RID: 29916
	[Token(Token = "0x4006B5B")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer MeshRenderer;

	// Token: 0x040074DD RID: 29917
	[Token(Token = "0x4006B5C")]
	[FieldOffset(Offset = "0x20")]
	public List<Material> BoneMaterialList;

	// Token: 0x040074DE RID: 29918
	[Token(Token = "0x4006B5D")]
	[FieldOffset(Offset = "0x28")]
	private bool IsFadeOut;

	// Token: 0x040074DF RID: 29919
	[Token(Token = "0x4006B5E")]
	[FieldOffset(Offset = "0x2C")]
	private float BoneFadeTimer;

	// Token: 0x040074E0 RID: 29920
	[Token(Token = "0x4006B5F")]
	[FieldOffset(Offset = "0x30")]
	private float BoneFadeDuration;
}
