using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009B0 RID: 2480
[Token(Token = "0x200067E")]
public class HUDLockOnObject : MonoBehaviour
{
	// Token: 0x060040B4 RID: 16564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035EF")]
	[Address(RVA = "0x204BE80", Offset = "0x204BF81", VA = "0x204BE80")]
	private void Awake()
	{
	}

	// Token: 0x060040B5 RID: 16565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F0")]
	[Address(RVA = "0x204BF00", Offset = "0x204C001", VA = "0x204BF00")]
	private void PlayStartAnim()
	{
	}

	// Token: 0x060040B6 RID: 16566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F1")]
	[Address(RVA = "0x204BFB0", Offset = "0x204C0B1", VA = "0x204BFB0")]
	public void ReplayStartAnim()
	{
	}

	// Token: 0x060040B7 RID: 16567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x204C060", Offset = "0x204C161", VA = "0x204C060")]
	private void ChangeToIdelAnim()
	{
	}

	// Token: 0x060040B8 RID: 16568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F3")]
	[Address(RVA = "0x204C0B0", Offset = "0x204C1B1", VA = "0x204C0B0")]
	private void EndAnim()
	{
	}

	// Token: 0x060040B9 RID: 16569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F4")]
	[Address(RVA = "0x204C110", Offset = "0x204C211", VA = "0x204C110")]
	private void Update()
	{
	}

	// Token: 0x060040BA RID: 16570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035F5")]
	[Address(RVA = "0x204C640", Offset = "0x204C741", VA = "0x204C640")]
	public HUDLockOnObject()
	{
	}

	// Token: 0x04009F69 RID: 40809
	[Token(Token = "0x4007828")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject LockOnImage;

	// Token: 0x04009F6A RID: 40810
	[Token(Token = "0x4007829")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject StartLockOnImage;

	// Token: 0x04009F6B RID: 40811
	[Token(Token = "0x400782A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UIImageMove[] UIImageMoves;

	// Token: 0x04009F6C RID: 40812
	[Token(Token = "0x400782B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private HudPadLock HudPadLock;

	// Token: 0x04009F6D RID: 40813
	[Token(Token = "0x400782C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float StartAnimTime;

	// Token: 0x04009F6E RID: 40814
	[Token(Token = "0x400782D")]
	[FieldOffset(Offset = "0x3C")]
	private float nowStartTime;

	// Token: 0x04009F6F RID: 40815
	[Token(Token = "0x400782E")]
	[FieldOffset(Offset = "0x40")]
	private bool playingStartAnim;

	// Token: 0x04009F70 RID: 40816
	[Token(Token = "0x400782F")]
	[FieldOffset(Offset = "0x48")]
	private CharacterBase LockonTarget;

	// Token: 0x04009F71 RID: 40817
	[Token(Token = "0x4007830")]
	[FieldOffset(Offset = "0x50")]
	private bool isEnable;
}
