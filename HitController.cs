using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000601 RID: 1537
[Token(Token = "0x2000452")]
public class HitController : MonoBehaviour
{
	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x06002609 RID: 9737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004DE")]
	public HitSystem ActiveHitSystem
	{
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x24F5130", Offset = "0x24F5231", VA = "0x24F5130")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x0600260A RID: 9738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004DF")]
	public string[] HitSystemNames
	{
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x24F5140", Offset = "0x24F5241", VA = "0x24F5140")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x0600260B RID: 9739 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004E0")]
	public HitSystem[] HitSystems
	{
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x24F5150", Offset = "0x24F5251", VA = "0x24F5150")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x24F5160", Offset = "0x24F5261", VA = "0x24F5160")]
		set
		{
		}
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002015")]
	[Address(RVA = "0x24F5170", Offset = "0x24F5271", VA = "0x24F5170")]
	private void Awake()
	{
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002016")]
	[Address(RVA = "0x24F51C0", Offset = "0x24F52C1", VA = "0x24F51C0")]
	public void HitUpdate(float deltaTime)
	{
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002017")]
	[Address(RVA = "0x24F53D0", Offset = "0x24F54D1", VA = "0x24F53D0")]
	public void HitTimeSync(float time)
	{
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002018")]
	[Address(RVA = "0x24F55D0", Offset = "0x24F56D1", VA = "0x24F55D0")]
	public HitSystem StartMotion(string motion_name)
	{
		return null;
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002019")]
	[Address(RVA = "0x24F5740", Offset = "0x24F5841", VA = "0x24F5740")]
	public void StartMotion()
	{
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600201A")]
	[Address(RVA = "0x24F5680", Offset = "0x24F5781", VA = "0x24F5680")]
	public void ClearMotion()
	{
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600201B")]
	[Address(RVA = "0x24F5AC0", Offset = "0x24F5BC1", VA = "0x24F5AC0")]
	public void ResetPosition(float position)
	{
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600201C")]
	[Address(RVA = "0x24F5AF0", Offset = "0x24F5BF1", VA = "0x24F5AF0")]
	public void ResetScale(float scale)
	{
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600201D")]
	[Address(RVA = "0x24F5B20", Offset = "0x24F5C21", VA = "0x24F5B20")]
	public HitController()
	{
	}

	// Token: 0x04006D50 RID: 27984
	[Token(Token = "0x400665A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167F90", Offset = "0x168091")]
	private float Position;

	// Token: 0x04006D51 RID: 27985
	[Token(Token = "0x400665B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167FD0", Offset = "0x1680D1")]
	private float Scale;

	// Token: 0x04006D52 RID: 27986
	[Token(Token = "0x400665C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HitSystem activeHitSystem;

	// Token: 0x04006D53 RID: 27987
	[Token(Token = "0x400665D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168020", Offset = "0x168121")]
	[SerializeField]
	private string[] hitSystemNames;

	// Token: 0x04006D54 RID: 27988
	[Token(Token = "0x400665E")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168070", Offset = "0x168171")]
	[SerializeField]
	private HitSystem[] hitSystems;
}
