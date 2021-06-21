using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005CC RID: 1484
[Token(Token = "0x200042C")]
public abstract class GimmickBase : MonoBehaviour
{
	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x0600246A RID: 9322 RVA: 0x0000EB80 File Offset: 0x0000CD80
	// (set) Token: 0x0600246B RID: 9323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004BD")]
	public GimmickLayoutID GimmickLayoutID
	{
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x1FA8A40", Offset = "0x1FA8B41", VA = "0x1FA8A40")]
		get
		{
			return GimmickLayoutID.None;
		}
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x1FA8A50", Offset = "0x1FA8B51", VA = "0x1FA8A50")]
		set
		{
		}
	}

	// Token: 0x170005EC RID: 1516
	// (get) Token: 0x0600246C RID: 9324 RVA: 0x0000EB98 File Offset: 0x0000CD98
	// (set) Token: 0x0600246D RID: 9325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004BE")]
	public virtual bool GimmickPassFlag
	{
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x1FA8A60", Offset = "0x1FA8B61", VA = "0x1FA8A60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x1FA8A70", Offset = "0x1FA8B71", VA = "0x1FA8A70")]
		private set
		{
		}
	}

	// Token: 0x170005ED RID: 1517
	// (get) Token: 0x0600246E RID: 9326 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
	// (set) Token: 0x0600246F RID: 9327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004BF")]
	public bool IsInit
	{
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x1FA8A80", Offset = "0x1FA8B81", VA = "0x1FA8A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1320", Offset = "0x1A1421")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x1FA8A90", Offset = "0x1FA8B91", VA = "0x1FA8A90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1330", Offset = "0x1A1431")]
		protected set
		{
		}
	}

	// Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0x1FA8AA0", Offset = "0x1FA8BA1", VA = "0x1FA8AA0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06002471 RID: 9329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0x1FA8B50", Offset = "0x1FA8C51", VA = "0x1FA8B50", Slot = "6")]
	protected virtual void Start()
	{
	}

	// Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0x1FA8BD0", Offset = "0x1FA8CD1", VA = "0x1FA8BD0", Slot = "7")]
	public virtual void SetGimmickState(bool newState)
	{
	}

	// Token: 0x06002473 RID: 9331 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0x1FA8BE0", Offset = "0x1FA8CE1", VA = "0x1FA8BE0", Slot = "8")]
	public virtual bool GetGimmickState()
	{
		return default(bool);
	}

	// Token: 0x06002474 RID: 9332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0x1FA8BF0", Offset = "0x1FA8CF1", VA = "0x1FA8BF0", Slot = "9")]
	public virtual void Init()
	{
	}

	// Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x1FA8C00", Offset = "0x1FA8D01", VA = "0x1FA8C00", Slot = "10")]
	public virtual void SetGimmickActiveFlag(bool isActive)
	{
	}

	// Token: 0x06002476 RID: 9334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0x1FA8C40", Offset = "0x1FA8D41", VA = "0x1FA8C40")]
	protected GimmickBase()
	{
	}

	// Token: 0x04006BDF RID: 27615
	[Token(Token = "0x400652F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GimmickLayoutID _GimmickLayoutID;

	// Token: 0x04006BE0 RID: 27616
	[Token(Token = "0x4006530")]
	[FieldOffset(Offset = "0x1C")]
	private bool _GimmickFlag;

	// Token: 0x04006BE1 RID: 27617
	[Token(Token = "0x4006531")]
	[FieldOffset(Offset = "0x1D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x167010", Offset = "0x167111")]
	private bool <IsInit>k__BackingField;
}
