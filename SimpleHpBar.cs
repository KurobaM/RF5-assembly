using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B34 RID: 2868
[Token(Token = "0x200077E")]
public class SimpleHpBar : MonoBehaviour
{
	// Token: 0x06004A08 RID: 18952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DFA")]
	[Address(RVA = "0x1DE4030", Offset = "0x1DE4131", VA = "0x1DE4030")]
	private void Start()
	{
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DFB")]
	[Address(RVA = "0x1DE46F0", Offset = "0x1DE47F1", VA = "0x1DE46F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004A0A RID: 18954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DFC")]
	[Address(RVA = "0x1DE4630", Offset = "0x1DE4731", VA = "0x1DE4630")]
	public void SetAppear(bool stat)
	{
	}

	// Token: 0x06004A0B RID: 18955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DFD")]
	[Address(RVA = "0x1DE4760", Offset = "0x1DE4861", VA = "0x1DE4760")]
	private void SetVisible(bool Flag)
	{
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DFE")]
	[Address(RVA = "0x1DE47D0", Offset = "0x1DE48D1", VA = "0x1DE47D0")]
	private void Update()
	{
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DFF")]
	[Address(RVA = "0x1DE44B0", Offset = "0x1DE45B1", VA = "0x1DE44B0")]
	private void UpdateHp(CharacterStatusBase status, int amount)
	{
	}

	// Token: 0x06004A0E RID: 18958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E00")]
	[Address(RVA = "0x1DE4C20", Offset = "0x1DE4D21", VA = "0x1DE4C20")]
	public void SetHide(bool val)
	{
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E01")]
	[Address(RVA = "0x1DE4C30", Offset = "0x1DE4D31", VA = "0x1DE4C30")]
	public SimpleHpBar()
	{
	}

	// Token: 0x0400AA2C RID: 43564
	[Token(Token = "0x4008052")]
	[FieldOffset(Offset = "0x18")]
	private CharacterStatusBase Sstatus;

	// Token: 0x0400AA2D RID: 43565
	[Token(Token = "0x4008053")]
	[FieldOffset(Offset = "0x20")]
	private GameObject Prefab;

	// Token: 0x0400AA2E RID: 43566
	[Token(Token = "0x4008054")]
	[FieldOffset(Offset = "0x28")]
	private Image Gauge;

	// Token: 0x0400AA2F RID: 43567
	[Token(Token = "0x4008055")]
	[FieldOffset(Offset = "0x30")]
	private HUDDamageHpBar HUDDamageHpBar;

	// Token: 0x0400AA30 RID: 43568
	[Token(Token = "0x4008056")]
	[FieldOffset(Offset = "0x38")]
	private Image borderObject;

	// Token: 0x0400AA31 RID: 43569
	[Token(Token = "0x4008057")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 offset;

	// Token: 0x0400AA32 RID: 43570
	[Token(Token = "0x4008058")]
	[FieldOffset(Offset = "0x50")]
	private Camera Camera;

	// Token: 0x0400AA33 RID: 43571
	[Token(Token = "0x4008059")]
	[FieldOffset(Offset = "0x58")]
	private UIPositionOnModelHead UIPositionOnModelHead;

	// Token: 0x0400AA34 RID: 43572
	[Token(Token = "0x400805A")]
	[FieldOffset(Offset = "0x60")]
	private float appearTime;

	// Token: 0x0400AA35 RID: 43573
	[Token(Token = "0x400805B")]
	[FieldOffset(Offset = "0x64")]
	private readonly float appearTimeMax;

	// Token: 0x0400AA36 RID: 43574
	[Token(Token = "0x400805C")]
	[FieldOffset(Offset = "0x68")]
	private bool nowAppear;

	// Token: 0x0400AA37 RID: 43575
	[Token(Token = "0x400805D")]
	[FieldOffset(Offset = "0x69")]
	private bool visible;

	// Token: 0x0400AA38 RID: 43576
	[Token(Token = "0x400805E")]
	[FieldOffset(Offset = "0x6A")]
	private bool hiding;

	// Token: 0x0400AA39 RID: 43577
	[Token(Token = "0x400805F")]
	[FieldOffset(Offset = "0x70")]
	private HUDBadStatusIconDisp BadStatusIcon;

	// Token: 0x0400AA3A RID: 43578
	[Token(Token = "0x4008060")]
	[FieldOffset(Offset = "0x78")]
	private float hp;

	// Token: 0x0400AA3B RID: 43579
	[Token(Token = "0x4008061")]
	[FieldOffset(Offset = "0x7C")]
	private float hpMax;
}
