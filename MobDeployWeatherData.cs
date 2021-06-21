using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000398 RID: 920
[Token(Token = "0x20002C0")]
[Serializable]
public class MobDeployWeatherData
{
	// Token: 0x06001719 RID: 5913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x1D79A40", Offset = "0x1D79B41", VA = "0x1D79A40")]
	public MobDeployWeatherData()
	{
	}

	// Token: 0x0400103A RID: 4154
	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int min;

	// Token: 0x0400103B RID: 4155
	[Token(Token = "0x4000CEF")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int max;
}
