using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000724 RID: 1828
[Token(Token = "0x20004FB")]
public class KrakenStickController : MonoBehaviour
{
	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000568")]
	private Collider Collider
	{
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x224AB30", Offset = "0x224AC31", VA = "0x224AB30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002727")]
	[Address(RVA = "0x224ABE0", Offset = "0x224ACE1", VA = "0x224ABE0")]
	private void Start()
	{
	}

	// Token: 0x06002E7E RID: 11902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002728")]
	[Address(RVA = "0x224A730", Offset = "0x224A831", VA = "0x224A730")]
	public void Play()
	{
	}

	// Token: 0x06002E7F RID: 11903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002729")]
	[Address(RVA = "0x2249650", Offset = "0x2249751", VA = "0x2249650")]
	public void End()
	{
	}

	// Token: 0x06002E80 RID: 11904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600272A")]
	[Address(RVA = "0x224AC40", Offset = "0x224AD41", VA = "0x224AC40")]
	private void Update()
	{
	}

	// Token: 0x06002E81 RID: 11905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600272B")]
	[Address(RVA = "0x224AD60", Offset = "0x224AE61", VA = "0x224AD60")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002E82 RID: 11906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600272C")]
	[Address(RVA = "0x224AE40", Offset = "0x224AF41", VA = "0x224AE40")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06002E83 RID: 11907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600272D")]
	[Address(RVA = "0x224AF40", Offset = "0x224B041", VA = "0x224AF40")]
	public KrakenStickController()
	{
	}

	// Token: 0x04007484 RID: 29828
	[Token(Token = "0x4006B2C")]
	[FieldOffset(Offset = "0x18")]
	private List<Character> CharaList;

	// Token: 0x04007485 RID: 29829
	[Token(Token = "0x4006B2D")]
	[FieldOffset(Offset = "0x20")]
	private Animator Animator;

	// Token: 0x04007486 RID: 29830
	[Token(Token = "0x4006B2E")]
	[FieldOffset(Offset = "0x28")]
	private Collider _Collider;
}
