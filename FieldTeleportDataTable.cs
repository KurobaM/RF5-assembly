using System;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000370 RID: 880
[Token(Token = "0x200029C")]
[Serializable]
public class FieldTeleportDataTable
{
	// Token: 0x060016B8 RID: 5816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001429")]
	[Address(RVA = "0x2033710", Offset = "0x2033811", VA = "0x2033710")]
	public FieldTeleportDataTable()
	{
	}

	// Token: 0x04000F08 RID: 3848
	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public FieldSceneId SceneID;

	// Token: 0x04000F09 RID: 3849
	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public FieldSceneId MoveSceneID;

	// Token: 0x04000F0A RID: 3850
	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Place PlaceID;

	// Token: 0x04000F0B RID: 3851
	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string TextID;

	// Token: 0x04000F0C RID: 3852
	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int ReplaceNameID;

	// Token: 0x04000F0D RID: 3853
	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public GameFlagData FlagID;

	// Token: 0x04000F0E RID: 3854
	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string FlagTextID;

	// Token: 0x04000F0F RID: 3855
	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public bool UsePosition;

	// Token: 0x04000F10 RID: 3856
	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float PositionX;

	// Token: 0x04000F11 RID: 3857
	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float PositionY;

	// Token: 0x04000F12 RID: 3858
	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float PositionZ;

	// Token: 0x04000F13 RID: 3859
	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float RotationY;

	// Token: 0x04000F14 RID: 3860
	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public string TeleportName;

	// Token: 0x04000F15 RID: 3861
	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public float MovePositionX;

	// Token: 0x04000F16 RID: 3862
	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public float MovePositionY;

	// Token: 0x04000F17 RID: 3863
	[Token(Token = "0x4000BDF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float MovePositionZ;

	// Token: 0x04000F18 RID: 3864
	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float MoveRotationY;

	// Token: 0x04000F19 RID: 3865
	[Token(Token = "0x4000BE1")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public float MoveCameraRotationY;
}
