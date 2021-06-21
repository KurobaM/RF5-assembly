using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024C RID: 588
[Token(Token = "0x20001D8")]
[Serializable]
public class HumanModelSocket
{
	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000290")]
	public Transform AttachSocket
	{
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x2225FD0", Offset = "0x22260D1", VA = "0x2225FD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000291")]
	public Transform EquipItem
	{
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x2225FE0", Offset = "0x22260E1", VA = "0x2225FE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00006840 File Offset: 0x00004A40
	[Token(Token = "0x6000CED")]
	[Address(RVA = "0x2225FF0", Offset = "0x22260F1", VA = "0x2225FF0")]
	public bool Reset(HumanAttachIDEnum id, Transform target, HumanJoint[] joints)
	{
		return default(bool);
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x2225660", Offset = "0x2225761", VA = "0x2225660")]
	public Transform Attach(Transform item, HumanJoint[] joints)
	{
		return null;
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x2225840", Offset = "0x2225941", VA = "0x2225840")]
	public Transform Detach(HumanJoint[] joints)
	{
		return null;
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x2225960", Offset = "0x2225A61", VA = "0x2225960")]
	public void EraseOn(HumanJoint[] joints)
	{
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x2225B50", Offset = "0x2225C51", VA = "0x2225B50")]
	public void EraseOff(HumanJoint[] joints)
	{
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x22266E0", Offset = "0x22267E1", VA = "0x22266E0")]
	public void SetAlpha(float alpha)
	{
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x22266F0", Offset = "0x22267F1", VA = "0x22266F0")]
	public HumanModelSocket()
	{
	}

	// Token: 0x0400083D RID: 2109
	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public HumanAttachIDEnum AttachId;

	// Token: 0x0400083E RID: 2110
	[Token(Token = "0x40006A5")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public bool IsVisible;

	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x40006A6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Transform AttachTarget;

	// Token: 0x04000840 RID: 2112
	[Token(Token = "0x40006A7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E390", Offset = "0x15E491")]
	public float Weight;

	// Token: 0x04000841 RID: 2113
	[Token(Token = "0x40006A8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Vector3 AttachPosition;

	// Token: 0x04000842 RID: 2114
	[Token(Token = "0x40006A9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector3 AttachRotation;

	// Token: 0x04000843 RID: 2115
	[Token(Token = "0x40006AA")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public Vector3 AttachScale;

	// Token: 0x04000844 RID: 2116
	[Token(Token = "0x40006AB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform AttachedObject;

	// Token: 0x04000845 RID: 2117
	[Token(Token = "0x40006AC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public List<EraseObject> EraseList;

	// Token: 0x04000846 RID: 2118
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string[] AttachPointName;

	// Token: 0x04000847 RID: 2119
	[Token(Token = "0x40006AE")]
	[FieldOffset(Offset = "0x58")]
	private readonly string[] EraseName;
}
