using System;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200097D RID: 2429
[Token(Token = "0x200065D")]
public class WarpPoints : ScriptableObject
{
	// Token: 0x06003F9C RID: 16284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034F0")]
	[Address(RVA = "0x1E4F9E0", Offset = "0x1E4FAE1", VA = "0x1E4F9E0")]
	public WarpPoints()
	{
	}

	// Token: 0x04009DEF RID: 40431
	[Token(Token = "0x4007711")]
	[FieldOffset(Offset = "0x18")]
	public WarpPoints.WarpPoint[] datas;

	// Token: 0x0200097E RID: 2430
	[Token(Token = "0x20012A2")]
	[Serializable]
	public struct WarpPoint
	{
		// Token: 0x04009DF0 RID: 40432
		[Token(Token = "0x401B341")]
		[FieldOffset(Offset = "0x0")]
		public int NumId;

		// Token: 0x04009DF1 RID: 40433
		[Token(Token = "0x401B342")]
		[FieldOffset(Offset = "0x4")]
		public FieldSceneId SceneId;

		// Token: 0x04009DF2 RID: 40434
		[Token(Token = "0x401B343")]
		[FieldOffset(Offset = "0x8")]
		public string SystemTextId;

		// Token: 0x04009DF3 RID: 40435
		[Token(Token = "0x401B344")]
		[FieldOffset(Offset = "0x10")]
		public string SceneName;

		// Token: 0x04009DF4 RID: 40436
		[Token(Token = "0x401B345")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		// Token: 0x04009DF5 RID: 40437
		[Token(Token = "0x401B346")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		// Token: 0x04009DF6 RID: 40438
		[Token(Token = "0x401B347")]
		[FieldOffset(Offset = "0x30")]
		public string TeleportName;

		// Token: 0x04009DF7 RID: 40439
		[Token(Token = "0x401B348")]
		[FieldOffset(Offset = "0x38")]
		public GameFlagData IconOpenFlg;

		// Token: 0x04009DF8 RID: 40440
		[Token(Token = "0x401B349")]
		[FieldOffset(Offset = "0x3C")]
		public GameFlagData WarpOpenFlg;

		// Token: 0x04009DF9 RID: 40441
		[Token(Token = "0x401B34A")]
		[FieldOffset(Offset = "0x40")]
		public int groupId;

		// Token: 0x04009DFA RID: 40442
		[Token(Token = "0x401B34B")]
		[FieldOffset(Offset = "0x44")]
		public int groupInId;

		// Token: 0x04009DFB RID: 40443
		[Token(Token = "0x401B34C")]
		[FieldOffset(Offset = "0x48")]
		public bool floorFlg;

		// Token: 0x04009DFC RID: 40444
		[Token(Token = "0x401B34D")]
		[FieldOffset(Offset = "0x4C")]
		public int iconId;

		// Token: 0x04009DFD RID: 40445
		[Token(Token = "0x401B34E")]
		[FieldOffset(Offset = "0x50")]
		public bool minimapFlg;

		// Token: 0x04009DFE RID: 40446
		[Token(Token = "0x401B34F")]
		[FieldOffset(Offset = "0x51")]
		public bool mapFlg;

		// Token: 0x04009DFF RID: 40447
		[Token(Token = "0x401B350")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 GuidePosition;

		// Token: 0x04009E00 RID: 40448
		[Token(Token = "0x401B351")]
		[FieldOffset(Offset = "0x60")]
		public string GuideSystemTextId;

		// Token: 0x04009E01 RID: 40449
		[Token(Token = "0x401B352")]
		[FieldOffset(Offset = "0x68")]
		public bool DrawMapFlg;

		// Token: 0x04009E02 RID: 40450
		[Token(Token = "0x401B353")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 DrawPosition;

		// Token: 0x04009E03 RID: 40451
		[Token(Token = "0x401B354")]
		[FieldOffset(Offset = "0x78")]
		public string DrawSceneName;
	}
}
