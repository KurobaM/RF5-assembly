using System;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200084D RID: 2125
[Token(Token = "0x2000573")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146380", Offset = "0x146481")]
public class FieldOnGroundItemInfo
{
	// Token: 0x06003866 RID: 14438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x2033680", Offset = "0x2033781", VA = "0x2033680")]
	public FieldOnGroundItemInfo(FieldSceneId fieldSceneId, ItemData itemData, Vector3 position, float axisY)
	{
	}

	// Token: 0x04007B71 RID: 31601
	[Token(Token = "0x4006F96")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B5D0", Offset = "0x16B6D1")]
	public FieldSceneId FieldSceneId;

	// Token: 0x04007B72 RID: 31602
	[Token(Token = "0x4006F97")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B5F0", Offset = "0x16B6F1")]
	public ItemData ItemData;

	// Token: 0x04007B73 RID: 31603
	[Token(Token = "0x4006F98")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B610", Offset = "0x16B711")]
	public Vector3 Position;

	// Token: 0x04007B74 RID: 31604
	[Token(Token = "0x4006F99")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B630", Offset = "0x16B731")]
	public float AxisY;

	// Token: 0x04007B75 RID: 31605
	[Token(Token = "0x4006F9A")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x16B650", Offset = "0x16B751")]
	public OnGroundItem OnGroundItem;
}
