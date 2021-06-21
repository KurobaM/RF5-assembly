using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader;
using RF5WANTED;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000A7C RID: 2684
[Token(Token = "0x200070B")]
public class UIWantedBoardController : CursorLinkConnector
{
	// Token: 0x1700096B RID: 2411
	// (get) Token: 0x060045FD RID: 17917 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060045FE RID: 17918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000791")]
	public List<WantedData> WantedDatas
	{
		[Token(Token = "0x6003A9A")]
		[Address(RVA = "0x2123E20", Offset = "0x2123F21", VA = "0x2123E20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7CA0", Offset = "0x1A7DA1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x2123E30", Offset = "0x2123F31", VA = "0x2123E30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7CB0", Offset = "0x1A7DB1")]
		private set
		{
		}
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A9C")]
	[Address(RVA = "0x2123E40", Offset = "0x2123F41", VA = "0x2123E40")]
	private void Start()
	{
	}

	// Token: 0x06004600 RID: 17920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A9D")]
	[Address(RVA = "0x2124410", Offset = "0x2124511", VA = "0x2124410")]
	private void LoadAtlas(AssetHandle<SpriteAtlas> _handle)
	{
	}

	// Token: 0x06004601 RID: 17921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A9E")]
	[Address(RVA = "0x2123FC0", Offset = "0x21240C1", VA = "0x2123FC0")]
	private void SetBlocks()
	{
	}

	// Token: 0x06004602 RID: 17922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A9F")]
	[Address(RVA = "0x21244A0", Offset = "0x21245A1", VA = "0x21244A0")]
	private void Update()
	{
	}

	// Token: 0x06004603 RID: 17923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA0")]
	[Address(RVA = "0x2124E70", Offset = "0x2124F71", VA = "0x2124E70")]
	public static void Call(UnityEvent _callback)
	{
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA1")]
	[Address(RVA = "0x2124F00", Offset = "0x2125001", VA = "0x2124F00")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA2")]
	[Address(RVA = "0x2124F80", Offset = "0x2125081", VA = "0x2124F80")]
	public UIWantedBoardController()
	{
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA3")]
	[Address(RVA = "0x2124F90", Offset = "0x2125091", VA = "0x2124F90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7CC0", Offset = "0x1A7DC1")]
	private void <Update>b__27_0(bool select)
	{
	}

	// Token: 0x0400A4F6 RID: 42230
	[Token(Token = "0x4007CA2")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UIWantedBlock BlockLeft2;

	// Token: 0x0400A4F7 RID: 42231
	[Token(Token = "0x4007CA3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UIWantedBlock BlockLeft1;

	// Token: 0x0400A4F8 RID: 42232
	[Token(Token = "0x4007CA4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UIWantedBlock BlockCenter;

	// Token: 0x0400A4F9 RID: 42233
	[Token(Token = "0x4007CA5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UIWantedBlock BlockRight1;

	// Token: 0x0400A4FA RID: 42234
	[Token(Token = "0x4007CA6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UIWantedBlock BlockRight2;

	// Token: 0x0400A4FB RID: 42235
	[Token(Token = "0x4007CA7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Animator MainAnimator;

	// Token: 0x0400A4FC RID: 42236
	[Token(Token = "0x4007CA8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject ConfirmOK;

	// Token: 0x0400A4FD RID: 42237
	[Token(Token = "0x4007CA9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject ConfirmNG;

	// Token: 0x0400A4FE RID: 42238
	[Token(Token = "0x4007CAA")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text CompleteGroupText;

	// Token: 0x0400A4FF RID: 42239
	[Token(Token = "0x4007CAB")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text CompleteNumText;

	// Token: 0x0400A500 RID: 42240
	[Token(Token = "0x4007CAC")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Text AcceptMonsterNameText;

	// Token: 0x0400A501 RID: 42241
	[Token(Token = "0x4007CAD")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Text AcceptDetailText;

	// Token: 0x0400A502 RID: 42242
	[Token(Token = "0x4007CAE")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172F10", Offset = "0x173011")]
	private List<WantedData> <WantedDatas>k__BackingField;

	// Token: 0x0400A503 RID: 42243
	[Token(Token = "0x4007CAF")]
	[FieldOffset(Offset = "0xC0")]
	private int focusNo;

	// Token: 0x0400A504 RID: 42244
	[Token(Token = "0x4007CB0")]
	[FieldOffset(Offset = "0xC4")]
	private bool focusConfirmOK;

	// Token: 0x0400A505 RID: 42245
	[Token(Token = "0x4007CB1")]
	[FieldOffset(Offset = "0x0")]
	private static UnityEvent callback;

	// Token: 0x0400A506 RID: 42246
	[Token(Token = "0x4007CB2")]
	[FieldOffset(Offset = "0xC8")]
	private AssetHandle<SpriteAtlas> handle;

	// Token: 0x0400A507 RID: 42247
	[Token(Token = "0x4007CB3")]
	[FieldOffset(Offset = "0xD0")]
	private SpriteAtlas spriteAtlas;

	// Token: 0x0400A508 RID: 42248
	[Token(Token = "0x4007CB4")]
	private const int SpriteAtlasId = 19765;

	// Token: 0x0400A509 RID: 42249
	[Token(Token = "0x4007CB5")]
	[FieldOffset(Offset = "0xD8")]
	private UIWantedBoardController.State state;

	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x20012F3")]
	private enum State
	{
		// Token: 0x0400A50B RID: 42251
		[Token(Token = "0x401B4B8")]
		Selecting,
		// Token: 0x0400A50C RID: 42252
		[Token(Token = "0x401B4B9")]
		CompletedCheck,
		// Token: 0x0400A50D RID: 42253
		[Token(Token = "0x401B4BA")]
		Confirm,
		// Token: 0x0400A50E RID: 42254
		[Token(Token = "0x401B4BB")]
		End
	}
}
