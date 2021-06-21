using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000548 RID: 1352
[Token(Token = "0x20003D3")]
public class SnowmanPlayer : MonoBehaviour
{
	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0000D650 File Offset: 0x0000B850
	[Token(Token = "0x1700044D")]
	public float Scale
	{
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x2256FD0", Offset = "0x22570D1", VA = "0x2256FD0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0000D668 File Offset: 0x0000B868
	[Token(Token = "0x1700044E")]
	public bool EnableMove
	{
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x2256FF0", Offset = "0x22570F1", VA = "0x2256FF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000555 RID: 1365
	// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0000D680 File Offset: 0x0000B880
	[Token(Token = "0x1700044F")]
	public bool IsSpeedUp
	{
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x2254230", Offset = "0x2254331", VA = "0x2254230")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x060020BA RID: 8378 RVA: 0x0000D698 File Offset: 0x0000B898
	// (set) Token: 0x060020BB RID: 8379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000450")]
	public bool IsInvincible
	{
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x2257010", Offset = "0x2257111", VA = "0x2257010")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x2255FC0", Offset = "0x22560C1", VA = "0x2255FC0")]
		set
		{
		}
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC1")]
	[Address(RVA = "0x2257030", Offset = "0x2257131", VA = "0x2257030")]
	private void Start()
	{
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x2257210", Offset = "0x2257311", VA = "0x2257210")]
	private void Update()
	{
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0x22570B0", Offset = "0x22571B1", VA = "0x22570B0")]
	private void CreatePlayerSnowball()
	{
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x22573B0", Offset = "0x22574B1", VA = "0x22573B0")]
	public SnowmanPlayer()
	{
	}

	// Token: 0x04006798 RID: 26520
	[Token(Token = "0x4006186")]
	[FieldOffset(Offset = "0x18")]
	private PlayerSnowball playerSnowball;

	// Token: 0x04006799 RID: 26521
	[Token(Token = "0x4006187")]
	private const float INCREASE = 1.002f;

	// Token: 0x0400679A RID: 26522
	[Token(Token = "0x4006188")]
	[FieldOffset(Offset = "0x20")]
	private float increasingDistance;

	// Token: 0x0400679B RID: 26523
	[Token(Token = "0x4006189")]
	[FieldOffset(Offset = "0x24")]
	private float movement;

	// Token: 0x0400679C RID: 26524
	[Token(Token = "0x400618A")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 pastTrans;
}
