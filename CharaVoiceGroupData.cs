using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200034A RID: 842
[Token(Token = "0x2000279")]
[Serializable]
public class CharaVoiceGroupData
{
	// Token: 0x06001654 RID: 5716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x1E85A60", Offset = "0x1E85B61", VA = "0x1E85A60")]
	public CharaVoiceGroupData()
	{
	}

	// Token: 0x04000E31 RID: 3633
	[Token(Token = "0x4000B12")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public List<GroupSoundData> Datas;
}
