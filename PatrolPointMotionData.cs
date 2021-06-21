using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000813 RID: 2067
[Token(Token = "0x2000552")]
[Serializable]
public class PatrolPointMotionData
{
	// Token: 0x0600373A RID: 14138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x213C510", Offset = "0x213C611", VA = "0x213C510")]
	public PatrolPointMotionData()
	{
	}

	// Token: 0x04007A58 RID: 31320
	[Token(Token = "0x4006EC6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string PatrolPointName;

	// Token: 0x04007A59 RID: 31321
	[Token(Token = "0x4006EC7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ScriptNames> PointMotions;

	// Token: 0x04007A5A RID: 31322
	[Token(Token = "0x4006EC8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<ScriptNames> PointEatMotions;
}
