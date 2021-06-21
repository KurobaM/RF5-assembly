using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common
{
	// Token: 0x020011CB RID: 4555
	[Token(Token = "0x2000BA0")]
	[Serializable]
	public class VariableVector3 : Variable<Vector3>
	{
		// Token: 0x06007129 RID: 28969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0x20DBEF0", Offset = "0x20DBFF1", VA = "0x20DBEF0")]
		public VariableVector3(Vector3 value)
		{
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x00027000 File Offset: 0x00025200
		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0x20DBF70", Offset = "0x20DC071", VA = "0x20DBF70", Slot = "9")]
		public override Vector3 GetVector3()
		{
			return default(Vector3);
		}
	}
}
