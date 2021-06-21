using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000195 RID: 405
[Token(Token = "0x2000140")]
[Serializable]
public abstract class BulletSubModule : MonoBehaviour, IBulletModule
{
	// Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071F")]
	[Address(RVA = "0x219A6A0", Offset = "0x219A7A1", VA = "0x219A6A0", Slot = "7")]
	public virtual void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x219A6B0", Offset = "0x219A7B1", VA = "0x219A6B0", Slot = "8")]
	public virtual void OnUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000721")]
	[Address(RVA = "0x219A6C0", Offset = "0x219A7C1", VA = "0x219A6C0", Slot = "9")]
	public virtual void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000722")]
	[Address(RVA = "0x219A6D0", Offset = "0x219A7D1", VA = "0x219A6D0", Slot = "10")]
	public virtual void OnHit(BulletBase bullet)
	{
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000723")]
	[Address(RVA = "0x219A6E0", Offset = "0x219A7E1", VA = "0x219A6E0", Slot = "11")]
	public virtual void OnDead(BulletBase bullet)
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x219A6F0", Offset = "0x219A7F1", VA = "0x219A6F0", Slot = "12")]
	public virtual void DoExtension(BulletBase bullet)
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x218E4C0", Offset = "0x218E5C1", VA = "0x218E4C0")]
	protected BulletSubModule()
	{
	}

	// Token: 0x040004E9 RID: 1257
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public new bool enabled;
}
