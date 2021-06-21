using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x020002F1 RID: 753
[Token(Token = "0x200024B")]
public class ItemIconMng : SingletonMonoBehaviour<ItemIconMng>
{
	// Token: 0x060013FC RID: 5116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x208CDD0", Offset = "0x208CED1", VA = "0x208CDD0")]
	private void SetImageSprite(Image image, Sprite sprite)
	{
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x208C6D0", Offset = "0x208C7D1", VA = "0x208C6D0")]
	public void SetLoadIcon(Image Image, ItemID itemID)
	{
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x208C850", Offset = "0x208C951", VA = "0x208C850")]
	public void SetLoadIcon(Image Image, string iconName, ItemID itemID = ItemID.ITEM_EMPTY)
	{
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x208D0C0", Offset = "0x208D1C1", VA = "0x208D0C0")]
	public void RemoveAllResources()
	{
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600122F")]
	[Address(RVA = "0x208D1D0", Offset = "0x208D2D1", VA = "0x208D1D0")]
	private void AttachSprite(ItemIconMng.ImageLoaderObj imageLoaderObj, SpriteAtlas spriteAtlas)
	{
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x208D3F0", Offset = "0x208D4F1", VA = "0x208D3F0")]
	private void IconImageLoaded(AssetHandle<SpriteAtlas> handle)
	{
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x208D5D0", Offset = "0x208D6D1", VA = "0x208D5D0")]
	private void IconImageLoadedSetIcon(SpriteAtlas spriteAtlas, int atlasId)
	{
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001232")]
	[Address(RVA = "0x208D6D0", Offset = "0x208D7D1", VA = "0x208D6D0")]
	public void SetAmountSprite(int amount, Image amountImage)
	{
	}

	// Token: 0x06001404 RID: 5124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001233")]
	[Address(RVA = "0x208D770", Offset = "0x208D871", VA = "0x208D770")]
	public ItemIconMng()
	{
	}

	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x18")]
	public Sprite LoadingSprite;

	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x40008CD")]
	private const int workBuf = 19;

	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x20")]
	private SpriteAtlas[] WorkSpriteAtlas;

	// Token: 0x04000B48 RID: 2888
	[Token(Token = "0x40008CF")]
	[FieldOffset(Offset = "0x28")]
	private bool[] loadStarted;

	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Sprite[] AmountNumberSprite;

	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x38")]
	private List<ItemIconMng.SpriteWork> ItemIconSprites;

	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x40008D2")]
	[FieldOffset(Offset = "0x40")]
	private List<ItemIconMng.ImageLoaderObj> ImageLoaderObjs;

	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x200102F")]
	private class SpriteWork
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0x208CFF0", Offset = "0x208D0F1", VA = "0x208CFF0")]
		public SpriteWork(Sprite sprite, ItemID itemID)
		{
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0x208D9C0", Offset = "0x208DAC1", VA = "0x208D9C0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4018EEC")]
		[FieldOffset(Offset = "0x10")]
		public Sprite Sprite;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4018EED")]
		[FieldOffset(Offset = "0x18")]
		public ItemID ItemID;
	}

	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x2001030")]
	private class ImageLoaderObj
	{
		// Token: 0x06001407 RID: 5127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBE")]
		[Address(RVA = "0x208D040", Offset = "0x208D141", VA = "0x208D040")]
		public ImageLoaderObj(Image _image, ItemID _itemId, string _iconName, int _atlasId)
		{
		}

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4018EEE")]
		[FieldOffset(Offset = "0x10")]
		public ItemID itemId;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4018EEF")]
		[FieldOffset(Offset = "0x18")]
		public Image image;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4018EF0")]
		[FieldOffset(Offset = "0x20")]
		public string iconName;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4018EF1")]
		[FieldOffset(Offset = "0x28")]
		public int atlasId;
	}

	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x2001031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1573B0", Offset = "0x1574B1")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CBF")]
		[Address(RVA = "0x208CFE0", Offset = "0x208D0E1", VA = "0x208CFE0")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6006CC0")]
		[Address(RVA = "0x208D870", Offset = "0x208D971", VA = "0x208D870")]
		internal bool <SetLoadIcon>b__1(ItemIconMng.ImageLoaderObj a)
		{
			return default(bool);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x6006CC1")]
		[Address(RVA = "0x208D900", Offset = "0x208DA01", VA = "0x208D900")]
		internal bool <SetLoadIcon>b__0(ItemIconMng.ImageLoaderObj a)
		{
			return default(bool);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x6006CC2")]
		[Address(RVA = "0x208D990", Offset = "0x208DA91", VA = "0x208D990")]
		internal bool <SetLoadIcon>b__2(ItemIconMng.SpriteWork a)
		{
			return default(bool);
		}

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4018EF2")]
		[FieldOffset(Offset = "0x10")]
		public Image Image;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4018EF3")]
		[FieldOffset(Offset = "0x18")]
		public ItemID itemID;
	}
}
