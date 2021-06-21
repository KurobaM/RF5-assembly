using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F5 RID: 1269
[Token(Token = "0x20003A0")]
public class BeanSowingCamera : FestivalCamera
{
	// Token: 0x06001F11 RID: 7953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x2208C10", Offset = "0x2208D11", VA = "0x2208C10", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A9A")]
	[Address(RVA = "0x2208C20", Offset = "0x2208D21", VA = "0x2208C20")]
	private void Start()
	{
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A9B")]
	[Address(RVA = "0x2208C60", Offset = "0x2208D61", VA = "0x2208C60")]
	private void Update()
	{
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x2208E90", Offset = "0x2208F91", VA = "0x2208E90")]
	public BeanSowingCamera()
	{
	}

	// Token: 0x040065F1 RID: 26097
	[Token(Token = "0x400606A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject blueLine;

	// Token: 0x040065F2 RID: 26098
	[Token(Token = "0x400606B")]
	private const float SMOOTH_SPEED = 7f;

	// Token: 0x040065F3 RID: 26099
	[Token(Token = "0x400606C")]
	[FieldOffset(Offset = "0x48")]
	private float distance;

	// Token: 0x040065F4 RID: 26100
	[Token(Token = "0x400606D")]
	[FieldOffset(Offset = "0x4C")]
	private float startCameraPos_z;
}
