using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020001F9 RID: 505
[Token(Token = "0x2000197")]
public class BodyPartsCollision : CharacterBase
{
	// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090D")]
	[Address(RVA = "0x2456CD0", Offset = "0x2456DD1", VA = "0x2456CD0")]
	public void Setup(CharacterBase characterBase)
	{
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600090E")]
	[Address(RVA = "0x2456DB0", Offset = "0x2456EB1", VA = "0x2456DB0")]
	public void SetEnabled(bool enabled)
	{
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x000052C8 File Offset: 0x000034C8
	[Token(Token = "0x600090F")]
	[Address(RVA = "0x2456DC0", Offset = "0x2456EC1", VA = "0x2456DC0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000052E0 File Offset: 0x000034E0
	[Token(Token = "0x170001BF")]
	public override Alliance Alliance
	{
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2456EA0", Offset = "0x2456FA1", VA = "0x2456EA0", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x6000911")]
	[Address(RVA = "0x2456F90", Offset = "0x2457091", VA = "0x2456F90", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00005310 File Offset: 0x00003510
	[Token(Token = "0x170001C0")]
	public override Vector3 GetTakeLockonPos
	{
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x2457090", Offset = "0x2457191", VA = "0x2457090", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x24572E0", Offset = "0x24573E1", VA = "0x24572E0", Slot = "15")]
	public virtual string GetBodyPartsTypeName()
	{
		return null;
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000914")]
	[Address(RVA = "0x24572F0", Offset = "0x24573F1", VA = "0x24572F0", Slot = "16")]
	public virtual void SetBodyPartsType(int type)
	{
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x2457300", Offset = "0x2457401", VA = "0x2457300")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000916")]
	[Address(RVA = "0x2457420", Offset = "0x2457521", VA = "0x2457420")]
	public BodyPartsCollision()
	{
	}

	// Token: 0x0400067C RID: 1660
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string BodyPartsTypeName;

	// Token: 0x0400067D RID: 1661
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int BodyPartsType;

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x74")]
	public bool _IsCanNotLockon;

	// Token: 0x0400067F RID: 1663
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x75")]
	public bool _UseParentLockOn;

	// Token: 0x04000680 RID: 1664
	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 LockonPotitionOffset;

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x84")]
	public bool IsCanNotPlayerOverlap;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x88")]
	public BodyPartsCollision.BodyPartsOverlapEvent OverlapEvent;

	// Token: 0x020001FA RID: 506
	[Token(Token = "0x2000FEB")]
	public class BodyPartsOverlapEvent : UnityEvent<BodyPartsCollision, Collider>
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3A")]
		[Address(RVA = "0x2457530", Offset = "0x2457631", VA = "0x2457530")]
		public BodyPartsOverlapEvent()
		{
		}
	}
}
