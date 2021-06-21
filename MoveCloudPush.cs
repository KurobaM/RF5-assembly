using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005F6 RID: 1526
[Token(Token = "0x200044A")]
public class MoveCloudPush : MonoBehaviour
{
	// Token: 0x060025B9 RID: 9657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x1E10E90", Offset = "0x1E10F91", VA = "0x1E10E90")]
	private void Awake()
	{
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x1E10EB0", Offset = "0x1E10FB1", VA = "0x1E10EB0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x1E11100", Offset = "0x1E11201", VA = "0x1E11100")]
	public MoveCloudPush()
	{
	}

	// Token: 0x04006CF7 RID: 27895
	[Token(Token = "0x400660F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x167C60", Offset = "0x167D61")]
	private float PushPercent;
}
