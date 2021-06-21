using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000AB8 RID: 2744
[Token(Token = "0x2000735")]
public class UIShopCoinGen : MonoBehaviour
{
	// Token: 0x06004747 RID: 18247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003BBD")]
	[Address(RVA = "0x1EBA9A0", Offset = "0x1EBAAA1", VA = "0x1EBA9A0")]
	public UIShopCoinGen CloneUse(int totalPrice)
	{
		return null;
	}

	// Token: 0x06004748 RID: 18248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BBE")]
	[Address(RVA = "0x1EBAB00", Offset = "0x1EBAC01", VA = "0x1EBAB00")]
	private void SetCloneInit(UIShopCoinGen originalObj)
	{
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BBF")]
	[Address(RVA = "0x1EBAB70", Offset = "0x1EBAC71", VA = "0x1EBAB70")]
	private void CreateCoin()
	{
	}

	// Token: 0x0600474A RID: 18250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC0")]
	[Address(RVA = "0x1EBAC00", Offset = "0x1EBAD01", VA = "0x1EBAC00")]
	private void Update()
	{
	}

	// Token: 0x0600474B RID: 18251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BC1")]
	[Address(RVA = "0x1EBACF0", Offset = "0x1EBADF1", VA = "0x1EBACF0")]
	public UIShopCoinGen()
	{
	}

	// Token: 0x0400A676 RID: 42614
	[Token(Token = "0x4007DDE")]
	[FieldOffset(Offset = "0x18")]
	private int CountMax;

	// Token: 0x0400A677 RID: 42615
	[Token(Token = "0x4007DDF")]
	[FieldOffset(Offset = "0x1C")]
	private int NowCount;

	// Token: 0x0400A678 RID: 42616
	[Token(Token = "0x4007DE0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float DelayMax;

	// Token: 0x0400A679 RID: 42617
	[Token(Token = "0x4007DE1")]
	[FieldOffset(Offset = "0x24")]
	public float DelayMin;

	// Token: 0x0400A67A RID: 42618
	[Token(Token = "0x4007DE2")]
	[FieldOffset(Offset = "0x28")]
	private float DelayTimeMax;

	// Token: 0x0400A67B RID: 42619
	[Token(Token = "0x4007DE3")]
	[FieldOffset(Offset = "0x2C")]
	private float DelayTime;

	// Token: 0x0400A67C RID: 42620
	[Token(Token = "0x4007DE4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector2 AddRandStartPos;

	// Token: 0x0400A67D RID: 42621
	[Token(Token = "0x4007DE5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float AddRandTime;

	// Token: 0x0400A67E RID: 42622
	[Token(Token = "0x4007DE6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public UIShopCoinAnim UIShopCoinAnim;
}
