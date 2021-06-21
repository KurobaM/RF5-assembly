using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000965 RID: 2405
[Token(Token = "0x200064E")]
public class ImagePaneDatas : ScriptableObject
{
	// Token: 0x06003F8B RID: 16267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E0")]
	[Address(RVA = "0x222C500", Offset = "0x222C601", VA = "0x222C500")]
	public ImagePaneDatas()
	{
	}

	// Token: 0x04008207 RID: 33287
	[Token(Token = "0x4007508")]
	[FieldOffset(Offset = "0x18")]
	public ImagePaneDatas.ImagePaneData[] datas;

	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2001299")]
	[Serializable]
	public struct ImagePaneData
	{
		// Token: 0x04008208 RID: 33288
		[Token(Token = "0x4019962")]
		[FieldOffset(Offset = "0x0")]
		public int ID;

		// Token: 0x04008209 RID: 33289
		[Token(Token = "0x4019963")]
		[FieldOffset(Offset = "0x8")]
		public string ImagePaneName;

		// Token: 0x0400820A RID: 33290
		[Token(Token = "0x4019964")]
		[FieldOffset(Offset = "0x10")]
		public string FileName;

		// Token: 0x0400820B RID: 33291
		[Token(Token = "0x4019965")]
		[FieldOffset(Offset = "0x18")]
		public string FilePath;
	}
}
