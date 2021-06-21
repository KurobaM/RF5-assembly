using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009C3 RID: 2499
[Token(Token = "0x200068D")]
public class HudPadLock : MonoBehaviour
{
	// Token: 0x06004134 RID: 16692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003667")]
	[Address(RVA = "0x20937E0", Offset = "0x20938E1", VA = "0x20937E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004135 RID: 16693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003668")]
	[Address(RVA = "0x2093820", Offset = "0x2093921", VA = "0x2093820")]
	public void Setup(MonsterControllerBase _monsterControllerBase)
	{
	}

	// Token: 0x06004136 RID: 16694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003669")]
	[Address(RVA = "0x2093900", Offset = "0x2093A01", VA = "0x2093900")]
	private void Update()
	{
	}

	// Token: 0x06004137 RID: 16695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600366A")]
	[Address(RVA = "0x2093A70", Offset = "0x2093B71", VA = "0x2093A70")]
	public void EndExitAnim()
	{
	}

	// Token: 0x06004138 RID: 16696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600366B")]
	[Address(RVA = "0x2093AB0", Offset = "0x2093BB1", VA = "0x2093AB0")]
	public HudPadLock()
	{
	}

	// Token: 0x0400A002 RID: 40962
	[Token(Token = "0x40078B1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator animator;

	// Token: 0x0400A003 RID: 40963
	[Token(Token = "0x40078B2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HUDLockOnObject parentObject;

	// Token: 0x0400A004 RID: 40964
	[Token(Token = "0x40078B3")]
	[FieldOffset(Offset = "0x28")]
	private bool nowState;

	// Token: 0x0400A005 RID: 40965
	[Token(Token = "0x40078B4")]
	[FieldOffset(Offset = "0x30")]
	private MonsterControllerBase monsterControllerBase;

	// Token: 0x0400A006 RID: 40966
	[Token(Token = "0x40078B5")]
	[FieldOffset(Offset = "0x38")]
	private bool isActived;
}
