using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000192 RID: 402
[Token(Token = "0x200013D")]
public class BulletScriptPlayer : BulletSubModule
{
	// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x2199C90", Offset = "0x2199D91", VA = "0x2199C90", Slot = "7")]
	public override void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000715")]
	[Address(RVA = "0x2199D80", Offset = "0x2199E81", VA = "0x2199D80", Slot = "10")]
	public override void OnHit(BulletBase bullet)
	{
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000716")]
	[Address(RVA = "0x2199E40", Offset = "0x2199F41", VA = "0x2199E40", Slot = "11")]
	public override void OnDead(BulletBase bullet)
	{
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000717")]
	[Address(RVA = "0x2199DF0", Offset = "0x2199EF1", VA = "0x2199DF0")]
	private void Play(BulletBase bullet)
	{
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000718")]
	[Address(RVA = "0x2199EB0", Offset = "0x2199FB1", VA = "0x2199EB0")]
	public BulletScriptPlayer()
	{
	}

	// Token: 0x040004E2 RID: 1250
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public BulletScriptPlayType playtype;

	// Token: 0x040004E3 RID: 1251
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string scriptName;
}
