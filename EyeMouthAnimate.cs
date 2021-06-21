using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x0200092D RID: 2349
[Token(Token = "0x2000624")]
public class EyeMouthAnimate : MonoBehaviour
{
	// Token: 0x170008C5 RID: 2245
	// (get) Token: 0x06003D5E RID: 15710 RVA: 0x00015438 File Offset: 0x00013638
	// (set) Token: 0x06003D5F RID: 15711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000704")]
	private bool PlayMouth
	{
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x21BDF50", Offset = "0x21BE051", VA = "0x21BDF50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x21BDF60", Offset = "0x21BE061", VA = "0x21BDF60")]
		set
		{
		}
	}

	// Token: 0x170008C6 RID: 2246
	// (get) Token: 0x06003D60 RID: 15712 RVA: 0x00015450 File Offset: 0x00013650
	// (set) Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000705")]
	public int CharactorId
	{
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x21BDF80", Offset = "0x21BE081", VA = "0x21BDF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6CC0", Offset = "0x1A6DC1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x21BDF90", Offset = "0x21BE091", VA = "0x21BDF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6CD0", Offset = "0x1A6DD1")]
		private set
		{
		}
	}

	// Token: 0x170008C7 RID: 2247
	// (get) Token: 0x06003D62 RID: 15714 RVA: 0x00015468 File Offset: 0x00013668
	// (set) Token: 0x06003D63 RID: 15715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000706")]
	public int VariationId
	{
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x21BDFA0", Offset = "0x21BE0A1", VA = "0x21BDFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6CE0", Offset = "0x1A6DE1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x21BDFB0", Offset = "0x21BE0B1", VA = "0x21BDFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6CF0", Offset = "0x1A6DF1")]
		private set
		{
		}
	}

	// Token: 0x06003D64 RID: 15716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003398")]
	[Address(RVA = "0x21BDFC0", Offset = "0x21BE0C1", VA = "0x21BDFC0")]
	public void StartMouth()
	{
	}

	// Token: 0x06003D65 RID: 15717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003399")]
	[Address(RVA = "0x21BDFE0", Offset = "0x21BE0E1", VA = "0x21BDFE0")]
	public void StopMouth()
	{
	}

	// Token: 0x06003D66 RID: 15718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600339A")]
	[Address(RVA = "0x21BE100", Offset = "0x21BE201", VA = "0x21BE100")]
	public void EndAnim()
	{
	}

	// Token: 0x06003D67 RID: 15719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600339B")]
	[Address(RVA = "0x21BE110", Offset = "0x21BE211", VA = "0x21BE110")]
	private Sprite GetEyesSprite(int charaId, int faceId, int costumeId, int poseId, int animId)
	{
		return null;
	}

	// Token: 0x06003D68 RID: 15720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600339C")]
	[Address(RVA = "0x21BE380", Offset = "0x21BE481", VA = "0x21BE380")]
	private Sprite GetEyeBrowsSprite(int charaId, int faceId, int costumeId, int poseId, int animId)
	{
		return null;
	}

	// Token: 0x06003D69 RID: 15721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600339D")]
	[Address(RVA = "0x21BE5F0", Offset = "0x21BE6F1", VA = "0x21BE5F0")]
	private Sprite GetMouthSprite(int charaId, int faceId, int costumeId, int poseId, int animId)
	{
		return null;
	}

	// Token: 0x06003D6A RID: 15722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600339E")]
	[Address(RVA = "0x21BE860", Offset = "0x21BE961", VA = "0x21BE860")]
	private Sprite GetMainSprite(int charaId, int faceId, int costumeId, int poseId)
	{
		return null;
	}

	// Token: 0x06003D6B RID: 15723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600339F")]
	[Address(RVA = "0x21BEAE0", Offset = "0x21BEBE1", VA = "0x21BEAE0")]
	private Sprite GetNoFaceSprite(int charaId, int faceId, int costumeId, int poseId)
	{
		return null;
	}

	// Token: 0x06003D6C RID: 15724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x21BEBF0", Offset = "0x21BECF1", VA = "0x21BEBF0")]
	private void GetImageSet()
	{
	}

	// Token: 0x06003D6D RID: 15725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x21BF1F0", Offset = "0x21BF2F1", VA = "0x21BF1F0")]
	public void SetImage(Image parentImg, int charaId, int variationId, int EyeVar, int EyeBrowsVar, int MouthVar)
	{
	}

	// Token: 0x06003D6E RID: 15726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x21BF5B0", Offset = "0x21BF6B1", VA = "0x21BF5B0")]
	private void Start()
	{
	}

	// Token: 0x06003D6F RID: 15727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x21BF7E0", Offset = "0x21BF8E1", VA = "0x21BF7E0")]
	private void SetStartFace()
	{
	}

	// Token: 0x06003D70 RID: 15728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x21BFA30", Offset = "0x21BFB31", VA = "0x21BFA30")]
	private void SetEndFace()
	{
	}

	// Token: 0x06003D71 RID: 15729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x21BFAA0", Offset = "0x21BFBA1", VA = "0x21BFAA0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06003D72 RID: 15730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x21BFB40", Offset = "0x21BFC41", VA = "0x21BFB40")]
	private void Update()
	{
	}

	// Token: 0x06003D73 RID: 15731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x21BE050", Offset = "0x21BE151", VA = "0x21BE050")]
	private void SetNullImageOff(Image image)
	{
	}

	// Token: 0x06003D74 RID: 15732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x21BF520", Offset = "0x21BF621", VA = "0x21BF520")]
	private void SetFaceImageEnable(Image image)
	{
	}

	// Token: 0x06003D75 RID: 15733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x21BFF00", Offset = "0x21C0001", VA = "0x21BFF00")]
	public EyeMouthAnimate()
	{
	}

	// Token: 0x04007FCF RID: 32719
	[Token(Token = "0x400732B")]
	[FieldOffset(Offset = "0x18")]
	private bool PlayEye;

	// Token: 0x04007FD0 RID: 32720
	[Token(Token = "0x400732C")]
	[FieldOffset(Offset = "0x19")]
	private bool PlayEyeBrows;

	// Token: 0x04007FD1 RID: 32721
	[Token(Token = "0x400732D")]
	[FieldOffset(Offset = "0x1A")]
	private bool MouthSeted;

	// Token: 0x04007FD2 RID: 32722
	[Token(Token = "0x400732E")]
	[FieldOffset(Offset = "0x1B")]
	private bool _PlayMouth;

	// Token: 0x04007FD3 RID: 32723
	[Token(Token = "0x400732F")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F030", Offset = "0x16F131")]
	private int <CharactorId>k__BackingField;

	// Token: 0x04007FD4 RID: 32724
	[Token(Token = "0x4007330")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F040", Offset = "0x16F141")]
	private int <VariationId>k__BackingField;

	// Token: 0x04007FD5 RID: 32725
	[Token(Token = "0x4007331")]
	[FieldOffset(Offset = "0x28")]
	public Image MainImage;

	// Token: 0x04007FD6 RID: 32726
	[Token(Token = "0x4007332")]
	[FieldOffset(Offset = "0x30")]
	public Image NoFaceImage;

	// Token: 0x04007FD7 RID: 32727
	[Token(Token = "0x4007333")]
	[FieldOffset(Offset = "0x38")]
	public Image EyeImage;

	// Token: 0x04007FD8 RID: 32728
	[Token(Token = "0x4007334")]
	[FieldOffset(Offset = "0x40")]
	public Image EyeBrowsImage;

	// Token: 0x04007FD9 RID: 32729
	[Token(Token = "0x4007335")]
	[FieldOffset(Offset = "0x48")]
	public Image MouthImage;

	// Token: 0x04007FDA RID: 32730
	[Token(Token = "0x4007336")]
	[FieldOffset(Offset = "0x50")]
	public Sprite[] BaseImage;

	// Token: 0x04007FDB RID: 32731
	[Token(Token = "0x4007337")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Sprite[] EyeImgs;

	// Token: 0x04007FDC RID: 32732
	[Token(Token = "0x4007338")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Sprite[] EyeBrowsImgs;

	// Token: 0x04007FDD RID: 32733
	[Token(Token = "0x4007339")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Sprite[] MouthImgs;

	// Token: 0x04007FDE RID: 32734
	[Token(Token = "0x400733A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int MaxEyeId;

	// Token: 0x04007FDF RID: 32735
	[Token(Token = "0x400733B")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private int MaxEyeBrowsId;

	// Token: 0x04007FE0 RID: 32736
	[Token(Token = "0x400733C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int MaxMouthId;

	// Token: 0x04007FE1 RID: 32737
	[Token(Token = "0x400733D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private EyeMouthAnimate.EMAnimSet[] EyeSet;

	// Token: 0x04007FE2 RID: 32738
	[Token(Token = "0x400733E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private EyeMouthAnimate.EMAnimSet[] EyeBrowsSet;

	// Token: 0x04007FE3 RID: 32739
	[Token(Token = "0x400733F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private EyeMouthAnimate.EMAnimSet[] MouthSet;

	// Token: 0x04007FE4 RID: 32740
	[Token(Token = "0x4007340")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private float EyeFrame;

	// Token: 0x04007FE5 RID: 32741
	[Token(Token = "0x4007341")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float EyeBrowsFrame;

	// Token: 0x04007FE6 RID: 32742
	[Token(Token = "0x4007342")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float MouthFrame;

	// Token: 0x04007FE7 RID: 32743
	[Token(Token = "0x4007343")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private int EyeAnimPoint;

	// Token: 0x04007FE8 RID: 32744
	[Token(Token = "0x4007344")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private int EyeBrowsAnimPoint;

	// Token: 0x04007FE9 RID: 32745
	[Token(Token = "0x4007345")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private int MouthAnimPoint;

	// Token: 0x04007FEA RID: 32746
	[Token(Token = "0x4007346")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private float EyeWaitTimeMin;

	// Token: 0x04007FEB RID: 32747
	[Token(Token = "0x4007347")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private float EyeWaitTimeMax;

	// Token: 0x04007FEC RID: 32748
	[Token(Token = "0x4007348")]
	[FieldOffset(Offset = "0xB8")]
	private Image ParentImage;

	// Token: 0x04007FED RID: 32749
	[Token(Token = "0x4007349")]
	[FieldOffset(Offset = "0xC0")]
	public SpriteAtlas spriteAtlas;

	// Token: 0x04007FEE RID: 32750
	[Token(Token = "0x400734A")]
	[FieldOffset(Offset = "0xC8")]
	private int EyeVariation;

	// Token: 0x04007FEF RID: 32751
	[Token(Token = "0x400734B")]
	[FieldOffset(Offset = "0xCC")]
	private int EyeBrowsVariation;

	// Token: 0x04007FF0 RID: 32752
	[Token(Token = "0x400734C")]
	[FieldOffset(Offset = "0xD0")]
	private int MouthVariation;

	// Token: 0x04007FF1 RID: 32753
	[Token(Token = "0x400734D")]
	[FieldOffset(Offset = "0xD8")]
	private BustupDataList.MouthTable mouthTable;

	// Token: 0x04007FF2 RID: 32754
	[Token(Token = "0x400734E")]
	[FieldOffset(Offset = "0xE0")]
	private int defaultMouthVal;

	// Token: 0x04007FF3 RID: 32755
	[Token(Token = "0x400734F")]
	[FieldOffset(Offset = "0xE4")]
	private bool fadeInCompleted;

	// Token: 0x0200092E RID: 2350
	[Token(Token = "0x200128B")]
	[Serializable]
	public struct EMAnimSet
	{
		// Token: 0x04007FF4 RID: 32756
		[Token(Token = "0x4019907")]
		[FieldOffset(Offset = "0x0")]
		public float frame;

		// Token: 0x04007FF5 RID: 32757
		[Token(Token = "0x4019908")]
		[FieldOffset(Offset = "0x4")]
		public int id;
	}
}
