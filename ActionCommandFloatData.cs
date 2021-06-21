using System;
using Il2CppDummyDll;

// Token: 0x0200008E RID: 142
[Token(Token = "0x200006E")]
[Serializable]
public class ActionCommandFloatData : ActionCommandDataParameter<float>
{
	// Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1FD5FA0", Offset = "0x1FD60A1", VA = "0x1FD5FA0")]
	public ActionCommandFloatData(float value)
	{
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1FD6010", Offset = "0x1FD6111", VA = "0x1FD6010", Slot = "5")]
	public override float GetFloat()
	{
		return 0f;
	}
}
