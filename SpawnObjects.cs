using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B6B RID: 2923
[Token(Token = "0x200079C")]
public class SpawnObjects : MonoBehaviour
{
	// Token: 0x06004B33 RID: 19251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F06")]
	[Address(RVA = "0x225DBB0", Offset = "0x225DCB1", VA = "0x225DBB0")]
	private void Start()
	{
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F07")]
	[Address(RVA = "0x225DBC0", Offset = "0x225DCC1", VA = "0x225DBC0")]
	private void Update()
	{
	}

	// Token: 0x06004B35 RID: 19253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F08")]
	[Address(RVA = "0x225DD10", Offset = "0x225DE11", VA = "0x225DD10")]
	public SpawnObjects()
	{
	}

	// Token: 0x0400ABCA RID: 43978
	[Token(Token = "0x4008199")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ObjectToSpawn;

	// Token: 0x0400ABCB RID: 43979
	[Token(Token = "0x400819A")]
	[FieldOffset(Offset = "0x20")]
	public float Interval;

	// Token: 0x0400ABCC RID: 43980
	[Token(Token = "0x400819B")]
	[FieldOffset(Offset = "0x24")]
	public float NumObjects;

	// Token: 0x0400ABCD RID: 43981
	[Token(Token = "0x400819C")]
	[FieldOffset(Offset = "0x28")]
	private float SpawnTimer;

	// Token: 0x0400ABCE RID: 43982
	[Token(Token = "0x400819D")]
	[FieldOffset(Offset = "0x2C")]
	private int SpawnCounter;
}
