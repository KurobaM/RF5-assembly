using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005EA RID: 1514
[Token(Token = "0x2000443")]
public class GimmickSwitchDoor : GimmickBase
{
	// Token: 0x06002549 RID: 9545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x1FE9C60", Offset = "0x1FE9D61", VA = "0x1FE9C60", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x1FE9C70", Offset = "0x1FE9D71", VA = "0x1FE9C70", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x1FE9CF0", Offset = "0x1FE9DF1", VA = "0x1FE9CF0", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F74")]
	[Address(RVA = "0x1FE9E80", Offset = "0x1FE9F81", VA = "0x1FE9E80")]
	private void Update()
	{
	}

	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x0600254D RID: 9549 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
	[Token(Token = "0x170004CF")]
	public bool IsEvent
	{
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x1FE9FA0", Offset = "0x1FEA0A1", VA = "0x1FE9FA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x1FE9D80", Offset = "0x1FE9E81", VA = "0x1FE9D80")]
	private void DoorCameraStart(GimmickLayoutID gid)
	{
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x1FE9FB0", Offset = "0x1FEA0B1", VA = "0x1FE9FB0")]
	private void DoorCameraSet()
	{
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x1FEA200", Offset = "0x1FEA301", VA = "0x1FEA200")]
	private void DoorCameraEnd()
	{
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x1FE9F10", Offset = "0x1FEA011", VA = "0x1FE9F10")]
	private void DoorCameraUpdate()
	{
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x1FEA300", Offset = "0x1FEA401", VA = "0x1FEA300")]
	public GimmickSwitchDoor()
	{
	}

	// Token: 0x04006C8F RID: 27791
	[Token(Token = "0x40065BB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public OnChangeStateOnDoor OnChangeStateOnDoor;

	// Token: 0x04006C90 RID: 27792
	[Token(Token = "0x40065BC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167620", Offset = "0x167721")]
	private bool CameraViewEnable;

	// Token: 0x04006C91 RID: 27793
	[Token(Token = "0x40065BD")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167670", Offset = "0x167771")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167670", Offset = "0x167771")]
	private float CameraViewTime;

	// Token: 0x04006C92 RID: 27794
	[Token(Token = "0x40065BE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1676E0", Offset = "0x1677E1")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1676E0", Offset = "0x1677E1")]
	private float CameraOffsetZ;

	// Token: 0x04006C93 RID: 27795
	[Token(Token = "0x40065BF")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167750", Offset = "0x167851")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x167750", Offset = "0x167851")]
	private float CameraOffsetY;

	// Token: 0x04006C94 RID: 27796
	[Token(Token = "0x40065C0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x1677C0", Offset = "0x1678C1")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1677C0", Offset = "0x1678C1")]
	private float CameraLookY;

	// Token: 0x04006C95 RID: 27797
	[Token(Token = "0x40065C1")]
	[FieldOffset(Offset = "0x0")]
	public static GimmickLayoutID gimmickID;

	// Token: 0x04006C96 RID: 27798
	[Token(Token = "0x40065C2")]
	[FieldOffset(Offset = "0x3C")]
	private GimmickSwitchDoor.DoorCameraState doorCameraState;

	// Token: 0x04006C97 RID: 27799
	[Token(Token = "0x40065C3")]
	[FieldOffset(Offset = "0x40")]
	private float EventTime;

	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x2001130")]
	private enum DoorCameraState
	{
		// Token: 0x04006C99 RID: 27801
		[Token(Token = "0x4019348")]
		IDLE,
		// Token: 0x04006C9A RID: 27802
		[Token(Token = "0x4019349")]
		WAIT,
		// Token: 0x04006C9B RID: 27803
		[Token(Token = "0x401934A")]
		DOOR
	}
}
