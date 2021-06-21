using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200091C RID: 2332
[Token(Token = "0x200061E")]
public class AdvShowOneImage : MonoBehaviour
{
	// Token: 0x06003D26 RID: 15654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003373")]
	[Address(RVA = "0x2432D30", Offset = "0x2432E31", VA = "0x2432D30")]
	public void RemoveLoader(AdvShowOneImage.AdvSpriteLoader AdvSpriteLoader)
	{
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003374")]
	[Address(RVA = "0x2432DA0", Offset = "0x2432EA1", VA = "0x2432DA0")]
	public void SetInit(AdvShowOneImage AdvShowOneImage, AdvShowOneImage.AdvSpriteLoader _loader, float x, float y, int _time)
	{
	}

	// Token: 0x06003D28 RID: 15656 RVA: 0x00015378 File Offset: 0x00013578
	[Token(Token = "0x6003375")]
	[Address(RVA = "0x2432F40", Offset = "0x2433041", VA = "0x2432F40")]
	private int GetImageLoaderId(int id)
	{
		return 0;
	}

	// Token: 0x06003D29 RID: 15657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003376")]
	[Address(RVA = "0x24330C0", Offset = "0x24331C1", VA = "0x24330C0")]
	public AdvShowOneImage OpenImage(int _imageId, int x, int y, int _time)
	{
		return null;
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003377")]
	[Address(RVA = "0x2433490", Offset = "0x2433591", VA = "0x2433490")]
	public void EndImage(int _imageId, int _time)
	{
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003378")]
	[Address(RVA = "0x2433760", Offset = "0x2433861", VA = "0x2433760")]
	public void EndAllImage(int _time)
	{
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003379")]
	[Address(RVA = "0x2433880", Offset = "0x2433981", VA = "0x2433880")]
	public void DoOpenImage(Sprite sprite)
	{
	}

	// Token: 0x06003D2D RID: 15661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337A")]
	[Address(RVA = "0x24339F0", Offset = "0x2433AF1", VA = "0x24339F0")]
	public void DoEndImage(int _time)
	{
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337B")]
	[Address(RVA = "0x2432F10", Offset = "0x2433011", VA = "0x2432F10")]
	private void SetFadeTime(int _time)
	{
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337C")]
	[Address(RVA = "0x2433A60", Offset = "0x2433B61", VA = "0x2433A60")]
	private void Update()
	{
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600337D")]
	[Address(RVA = "0x2433D40", Offset = "0x2433E41", VA = "0x2433D40")]
	public AdvShowOneImage()
	{
	}

	// Token: 0x04007F7A RID: 32634
	[Token(Token = "0x4007309")]
	[FieldOffset(Offset = "0x18")]
	private Image image;

	// Token: 0x04007F7B RID: 32635
	[Token(Token = "0x400730A")]
	private const float defaultFadeTime = 0.15f;

	// Token: 0x04007F7C RID: 32636
	[Token(Token = "0x400730B")]
	[FieldOffset(Offset = "0x20")]
	private float fadeTime;

	// Token: 0x04007F7D RID: 32637
	[Token(Token = "0x400730C")]
	[FieldOffset(Offset = "0x24")]
	private float nowTime;

	// Token: 0x04007F7E RID: 32638
	[Token(Token = "0x400730D")]
	[FieldOffset(Offset = "0x28")]
	private bool isOpening;

	// Token: 0x04007F7F RID: 32639
	[Token(Token = "0x400730E")]
	[FieldOffset(Offset = "0x29")]
	private bool isEnding;

	// Token: 0x04007F80 RID: 32640
	[Token(Token = "0x400730F")]
	[FieldOffset(Offset = "0x2C")]
	private float startEndAlpha;

	// Token: 0x04007F81 RID: 32641
	[Token(Token = "0x4007310")]
	[FieldOffset(Offset = "0x30")]
	private float X;

	// Token: 0x04007F82 RID: 32642
	[Token(Token = "0x4007311")]
	[FieldOffset(Offset = "0x34")]
	private float Y;

	// Token: 0x04007F83 RID: 32643
	[Token(Token = "0x4007312")]
	[FieldOffset(Offset = "0x38")]
	private AdvShowOneImage parent;

	// Token: 0x04007F84 RID: 32644
	[Token(Token = "0x4007313")]
	[FieldOffset(Offset = "0x40")]
	private List<AdvShowOneImage.AdvSpriteLoader> AdvSpriteLoaders;

	// Token: 0x04007F85 RID: 32645
	[Token(Token = "0x4007314")]
	[FieldOffset(Offset = "0x48")]
	private AdvShowOneImage.AdvSpriteLoader myLoader;

	// Token: 0x0200091D RID: 2333
	[Token(Token = "0x2001281")]
	public class AdvSpriteLoader
	{
		// Token: 0x06003D31 RID: 15665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749A")]
		[Address(RVA = "0x24332A0", Offset = "0x24333A1", VA = "0x24332A0")]
		public AdvSpriteLoader(int imageId, AdvShowOneImage obj, AdvShowOneImage parent)
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749B")]
		[Address(RVA = "0x24333E0", Offset = "0x24334E1", VA = "0x24333E0")]
		public void AddObj(AdvShowOneImage obj)
		{
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749C")]
		[Address(RVA = "0x2433C90", Offset = "0x2433D91", VA = "0x2433C90")]
		public void ObjRemoved(AdvShowOneImage AdvShowOneImage)
		{
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749D")]
		[Address(RVA = "0x2433E60", Offset = "0x2433F61", VA = "0x2433E60")]
		private void CheckRemoved()
		{
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749E")]
		[Address(RVA = "0x2433590", Offset = "0x2433691", VA = "0x2433590")]
		public void SetAllObjEnd(int _time)
		{
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600749F")]
		[Address(RVA = "0x2434020", Offset = "0x2434121", VA = "0x2434020")]
		public void Loaded(AssetHandle<Sprite> handle)
		{
		}

		// Token: 0x04007F86 RID: 32646
		[Token(Token = "0x40198D6")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04007F87 RID: 32647
		[Token(Token = "0x40198D7")]
		[FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		// Token: 0x04007F88 RID: 32648
		[Token(Token = "0x40198D8")]
		[FieldOffset(Offset = "0x20")]
		public List<AdvShowOneImage> usingObjs;

		// Token: 0x04007F89 RID: 32649
		[Token(Token = "0x40198D9")]
		[FieldOffset(Offset = "0x28")]
		public AdvShowOneImage mainPrefabs;

		// Token: 0x0200091E RID: 2334
		[Token(Token = "0x2001650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15ADF0", Offset = "0x15AEF1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003D38 RID: 15672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080A1")]
			[Address(RVA = "0x2434210", Offset = "0x2434311", VA = "0x2434210")]
			public <>c()
			{
			}

			// Token: 0x06003D39 RID: 15673 RVA: 0x00015390 File Offset: 0x00013590
			[Token(Token = "0x60080A2")]
			[Address(RVA = "0x2434220", Offset = "0x2434321", VA = "0x2434220")]
			internal bool <CheckRemoved>b__7_0(AdvShowOneImage a)
			{
				return default(bool);
			}

			// Token: 0x04007F8A RID: 32650
			[Token(Token = "0x401C3FE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AdvShowOneImage.AdvSpriteLoader.<>c <>9;

			// Token: 0x04007F8B RID: 32651
			[Token(Token = "0x401C3FF")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AdvShowOneImage> <>9__7_0;
		}
	}

	// Token: 0x0200091F RID: 2335
	[Token(Token = "0x2001282")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E10", Offset = "0x158F11")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06003D3A RID: 15674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A0")]
		[Address(RVA = "0x24330B0", Offset = "0x24331B1", VA = "0x24330B0")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x60074A1")]
		[Address(RVA = "0x2433DD0", Offset = "0x2433ED1", VA = "0x2433DD0")]
		internal bool <GetImageLoaderId>b__0(AdvOneImageDataTable.DataTable a)
		{
			return default(bool);
		}

		// Token: 0x04007F8C RID: 32652
		[Token(Token = "0x40198DA")]
		[FieldOffset(Offset = "0x10")]
		public int id;
	}

	// Token: 0x02000920 RID: 2336
	[Token(Token = "0x2001283")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E20", Offset = "0x158F21")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06003D3C RID: 15676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A2")]
		[Address(RVA = "0x2433290", Offset = "0x2433391", VA = "0x2433290")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x60074A3")]
		[Address(RVA = "0x2433E00", Offset = "0x2433F01", VA = "0x2433E00")]
		internal bool <OpenImage>b__0(AdvShowOneImage.AdvSpriteLoader a)
		{
			return default(bool);
		}

		// Token: 0x04007F8D RID: 32653
		[Token(Token = "0x40198DB")]
		[FieldOffset(Offset = "0x10")]
		public int loaderId;
	}

	// Token: 0x02000921 RID: 2337
	[Token(Token = "0x2001284")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E30", Offset = "0x158F31")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06003D3E RID: 15678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A4")]
		[Address(RVA = "0x2433580", Offset = "0x2433681", VA = "0x2433580")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x60074A5")]
		[Address(RVA = "0x2433E30", Offset = "0x2433F31", VA = "0x2433E30")]
		internal bool <EndImage>b__0(AdvShowOneImage.AdvSpriteLoader a)
		{
			return default(bool);
		}

		// Token: 0x04007F8E RID: 32654
		[Token(Token = "0x40198DC")]
		[FieldOffset(Offset = "0x10")]
		public int loaderId;
	}
}
