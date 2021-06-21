using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000BBD RID: 3005
[Token(Token = "0x20007CD")]
public class PlayerPositionUI : MonoBehaviour
{
	// Token: 0x06004CD2 RID: 19666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004069")]
	[Address(RVA = "0x2497620", Offset = "0x2497721", VA = "0x2497620")]
	public void Start()
	{
	}

	// Token: 0x06004CD3 RID: 19667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600406A")]
	[Address(RVA = "0x24976F0", Offset = "0x24977F1", VA = "0x24976F0")]
	public void Update()
	{
	}

	// Token: 0x06004CD4 RID: 19668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600406B")]
	[Address(RVA = "0x24979E0", Offset = "0x2497AE1", VA = "0x24979E0")]
	public PlayerPositionUI()
	{
	}

	// Token: 0x0400AE65 RID: 44645
	[Token(Token = "0x4008382")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176950", Offset = "0x176A51")]
	public Transform player;

	// Token: 0x0400AE66 RID: 44646
	[Token(Token = "0x4008383")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176990", Offset = "0x176A91")]
	public WorldMover worldMover;

	// Token: 0x0400AE67 RID: 44647
	[Token(Token = "0x4008384")]
	[FieldOffset(Offset = "0x28")]
	public Text text;
}
