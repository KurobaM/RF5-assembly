using System;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D6 RID: 1494
[Token(Token = "0x2000434")]
public class GimmickCheckFlag : GimmickBase
{
	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
	// (set) Token: 0x060024B3 RID: 9395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C1")]
	public FieldUniqueTreasureBoxSpawnID UniqueBoxSpawnID
	{
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x1FE1440", Offset = "0x1FE1541", VA = "0x1FE1440")]
		get
		{
			return FieldUniqueTreasureBoxSpawnID.EMPTY;
		}
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x1FE1450", Offset = "0x1FE1551", VA = "0x1FE1450")]
		private set
		{
		}
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x1FE1460", Offset = "0x1FE1561", VA = "0x1FE1460", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x1FE1530", Offset = "0x1FE1631", VA = "0x1FE1530", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x1FE1560", Offset = "0x1FE1661", VA = "0x1FE1560")]
	private void Awake()
	{
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x1FE1650", Offset = "0x1FE1751", VA = "0x1FE1650", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x1FE1660", Offset = "0x1FE1761", VA = "0x1FE1660")]
	private void Update()
	{
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x1FE1490", Offset = "0x1FE1591", VA = "0x1FE1490")]
	public void UpdateObjectVisible()
	{
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x1FE16C0", Offset = "0x1FE17C1", VA = "0x1FE16C0")]
	protected void SetTargetActive(bool setValue)
	{
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x1FE17C0", Offset = "0x1FE18C1", VA = "0x1FE17C0")]
	public GimmickCheckFlag()
	{
	}

	// Token: 0x04006C12 RID: 27666
	[Token(Token = "0x4006555")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FieldUniqueTreasureBoxSpawnID _UniqueBoxSpawnID;

	// Token: 0x04006C13 RID: 27667
	[Token(Token = "0x4006556")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected bool _IsFlagVisivle;

	// Token: 0x04006C14 RID: 27668
	[Token(Token = "0x4006557")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected GameObject[] VisibleChangeObject;
}
