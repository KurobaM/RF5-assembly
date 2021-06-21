using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x020005BD RID: 1469
[Token(Token = "0x200041F")]
public class DN17Light : MonoBehaviour
{
	// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x1D9EEC0", Offset = "0x1D9EFC1", VA = "0x1D9EEC0")]
	public void SetLightColor(Color color, float duration)
	{
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x1D9EF20", Offset = "0x1D9F021", VA = "0x1D9EF20")]
	public void SetConstraintPosition(Transform transform)
	{
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x1D9EFD0", Offset = "0x1D9F0D1", VA = "0x1D9EFD0")]
	public DN17Light()
	{
	}

	// Token: 0x04006B79 RID: 27513
	[Token(Token = "0x40064D0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Light Light;

	// Token: 0x04006B7A RID: 27514
	[Token(Token = "0x40064D1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PositionConstraint PositionConstraint;

	// Token: 0x04006B7B RID: 27515
	[Token(Token = "0x40064D2")]
	[FieldOffset(Offset = "0x28")]
	private bool IsInit;
}
