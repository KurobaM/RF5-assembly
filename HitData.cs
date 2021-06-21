using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000603 RID: 1539
[Token(Token = "0x2000454")]
[Serializable]
public class HitData : MonoBehaviour
{
	// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600201F")]
	[Address(RVA = "0x24F5B30", Offset = "0x24F5C31", VA = "0x24F5B30")]
	private void Awake()
	{
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002020")]
	[Address(RVA = "0x24F5C20", Offset = "0x24F5D21", VA = "0x24F5C20")]
	private void Reset()
	{
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002021")]
	[Address(RVA = "0x24F5B40", Offset = "0x24F5C41", VA = "0x24F5B40")]
	[Attribute(Name = "ContextMenu", RVA = "0x1A19D0", Offset = "0x1A1AD1")]
	public void ResetUnit()
	{
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002022")]
	[Address(RVA = "0x24F5C30", Offset = "0x24F5D31", VA = "0x24F5C30")]
	public void DoPlay()
	{
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x0000F138 File Offset: 0x0000D338
	[Token(Token = "0x6002023")]
	[Address(RVA = "0x24F5C60", Offset = "0x24F5D61", VA = "0x24F5C60")]
	public bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002024")]
	[Address(RVA = "0x24F5CB0", Offset = "0x24F5DB1", VA = "0x24F5CB0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002025")]
	[Address(RVA = "0x24F5CC0", Offset = "0x24F5DC1", VA = "0x24F5CC0")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002026")]
	[Address(RVA = "0x24F5D30", Offset = "0x24F5E31", VA = "0x24F5D30")]
	public HitData()
	{
	}

	// Token: 0x04006D55 RID: 27989
	[Token(Token = "0x400665F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Collider HitCollider;

	// Token: 0x04006D56 RID: 27990
	[Token(Token = "0x4006660")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public HitEvent OnHitTriggerEnter;

	// Token: 0x04006D57 RID: 27991
	[Token(Token = "0x4006661")]
	[FieldOffset(Offset = "0x28")]
	private bool IsCanStop;
}
