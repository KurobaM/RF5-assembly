using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000200 RID: 512
[Token(Token = "0x200019C")]
public abstract class CharaFaceController : MonoBehaviour
{
	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000A80 RID: 2688 RVA: 0x000053A0 File Offset: 0x000035A0
	// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C4")]
	public FaceType CurrentFaceType
	{
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1E83B10", Offset = "0x1E83C11", VA = "0x1E83B10")]
		get
		{
			return FaceType.Normal;
		}
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1E83B00", Offset = "0x1E83C01", VA = "0x1E83B00")]
		protected set
		{
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000053B8 File Offset: 0x000035B8
	// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C5")]
	public FaceType RequestFaceType
	{
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1E83B30", Offset = "0x1E83C31", VA = "0x1E83B30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B0A0", Offset = "0x19B1A1")]
		get
		{
			return FaceType.Normal;
		}
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1E83B20", Offset = "0x1E83C21", VA = "0x1E83B20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B090", Offset = "0x19B191")]
		protected set
		{
		}
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x1E83B40", Offset = "0x1E83C41", VA = "0x1E83B40")]
	private void Awake()
	{
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x1E83C00", Offset = "0x1E83D01", VA = "0x1E83C00", Slot = "4")]
	public virtual void SetFaceType(FaceType requestFaceType)
	{
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x1E83C30", Offset = "0x1E83D31", VA = "0x1E83C30", Slot = "5")]
	public virtual void ResetFaceType()
	{
	}

	// Token: 0x06000A86 RID: 2694
	[Token(Token = "0x6000936")]
	public abstract void ApplyFaceType(FaceType faceType);

	// Token: 0x06000A87 RID: 2695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x1E83C40", Offset = "0x1E83D41", VA = "0x1E83C40")]
	protected CharaFaceController()
	{
	}

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Character chara;

	// Token: 0x04000699 RID: 1689
	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected FaceType currentFaceType;

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D240", Offset = "0x15D341")]
	private FaceType <RequestFaceType>k__BackingField;
}
