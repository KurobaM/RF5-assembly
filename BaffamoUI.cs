using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004F0 RID: 1264
[Token(Token = "0x200039B")]
public class BaffamoUI : FestivalUI
{
	// Token: 0x06001EFF RID: 7935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x22A11C0", Offset = "0x22A12C1", VA = "0x22A11C0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A88")]
	[Address(RVA = "0x22A1210", Offset = "0x22A1311", VA = "0x22A1210")]
	private void Update()
	{
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x229E8E0", Offset = "0x229E9E1", VA = "0x229E8E0")]
	public void OnImagePlay(AvoidType _type)
	{
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x22A12B0", Offset = "0x22A13B1", VA = "0x22A12B0")]
	public BaffamoUI()
	{
	}

	// Token: 0x040065DB RID: 26075
	[Token(Token = "0x4006054")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image TextImagePerfect;

	// Token: 0x040065DC RID: 26076
	[Token(Token = "0x4006055")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image TextImageSuccess;

	// Token: 0x040065DD RID: 26077
	[Token(Token = "0x4006056")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image TextImageFailed;
}
