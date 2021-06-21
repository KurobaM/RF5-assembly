using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B1F RID: 2847
[Token(Token = "0x200076B")]
public class UIImageColorLoop : MonoBehaviour
{
	// Token: 0x0600499D RID: 18845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D8F")]
	[Address(RVA = "0x2011010", Offset = "0x2011111", VA = "0x2011010")]
	private void Start()
	{
	}

	// Token: 0x0600499E RID: 18846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D90")]
	[Address(RVA = "0x2011080", Offset = "0x2011181", VA = "0x2011080")]
	private void Update()
	{
	}

	// Token: 0x0600499F RID: 18847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D91")]
	[Address(RVA = "0x20111C0", Offset = "0x20112C1", VA = "0x20111C0")]
	public UIImageColorLoop()
	{
	}

	// Token: 0x0400A96A RID: 43370
	[Token(Token = "0x4007F9F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color BaseColor;

	// Token: 0x0400A96B RID: 43371
	[Token(Token = "0x4007FA0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color ToColor;

	// Token: 0x0400A96C RID: 43372
	[Token(Token = "0x4007FA1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float LoopSpeed;

	// Token: 0x0400A96D RID: 43373
	[Token(Token = "0x4007FA2")]
	[FieldOffset(Offset = "0x40")]
	private Image image;

	// Token: 0x0400A96E RID: 43374
	[Token(Token = "0x4007FA3")]
	[FieldOffset(Offset = "0x48")]
	private float time;
}
