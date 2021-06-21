using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000559 RID: 1369
[Token(Token = "0x20003E2")]
public class MapFieldCollider : MonoBehaviour
{
	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700045E")]
	public Collider Collider
	{
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x1F226E0", Offset = "0x1F227E1", VA = "0x1F226E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A06D0", Offset = "0x1A07D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x1F226F0", Offset = "0x1F227F1", VA = "0x1F226F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A06E0", Offset = "0x1A07E1")]
		private set
		{
		}
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C33")]
	[Address(RVA = "0x1F22700", Offset = "0x1F22801", VA = "0x1F22700")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C34")]
	[Address(RVA = "0x1F227B0", Offset = "0x1F228B1", VA = "0x1F227B0")]
	private void Awake()
	{
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C35")]
	[Address(RVA = "0x1F22840", Offset = "0x1F22941", VA = "0x1F22840")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x1F22B40", Offset = "0x1F22C41", VA = "0x1F22B40")]
	public FieldPlaceId GetFieldPlaceId()
	{
		return FieldPlaceId.None;
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x1F22B50", Offset = "0x1F22C51", VA = "0x1F22B50")]
	public MapFieldCollider()
	{
	}

	// Token: 0x040067E6 RID: 26598
	[Token(Token = "0x40061CB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string MapId;

	// Token: 0x040067E7 RID: 26599
	[Token(Token = "0x40061CC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FieldPlaceId FieldPlaceId;

	// Token: 0x040067E8 RID: 26600
	[Token(Token = "0x40061CD")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166070", Offset = "0x166171")]
	private Collider <Collider>k__BackingField;
}
