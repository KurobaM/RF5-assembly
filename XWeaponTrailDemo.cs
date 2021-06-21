using System;
using Il2CppDummyDll;
using UnityEngine;
using XftWeapon;

// Token: 0x02000BC1 RID: 3009
[Token(Token = "0x20007D1")]
public class XWeaponTrailDemo : MonoBehaviour
{
	// Token: 0x06004CE2 RID: 19682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004079")]
	[Address(RVA = "0x1E56B70", Offset = "0x1E56C71", VA = "0x1E56B70")]
	public void Start()
	{
	}

	// Token: 0x06004CE3 RID: 19683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600407A")]
	[Address(RVA = "0x1E56D20", Offset = "0x1E56E21", VA = "0x1E56D20")]
	private void OnGUI()
	{
	}

	// Token: 0x06004CE4 RID: 19684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600407B")]
	[Address(RVA = "0x1E57550", Offset = "0x1E57651", VA = "0x1E57550")]
	public XWeaponTrailDemo()
	{
	}

	// Token: 0x0400AE75 RID: 44661
	[Token(Token = "0x4008392")]
	[FieldOffset(Offset = "0x18")]
	public Animation SwordAnimation;

	// Token: 0x0400AE76 RID: 44662
	[Token(Token = "0x4008393")]
	[FieldOffset(Offset = "0x20")]
	public XWeaponTrail ProTrailDistort;

	// Token: 0x0400AE77 RID: 44663
	[Token(Token = "0x4008394")]
	[FieldOffset(Offset = "0x28")]
	public XWeaponTrail ProTrailShort;

	// Token: 0x0400AE78 RID: 44664
	[Token(Token = "0x4008395")]
	[FieldOffset(Offset = "0x30")]
	public XWeaponTrail ProTraillong;

	// Token: 0x0400AE79 RID: 44665
	[Token(Token = "0x4008396")]
	[FieldOffset(Offset = "0x38")]
	public XWeaponTrail SimpleTrail;
}
